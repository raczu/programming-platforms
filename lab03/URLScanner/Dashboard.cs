using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms.Design;
using URLScanner.API;
using URLScanner.Models.Database;
using URLScanner.Models.DTOs;
using URLScanner.Services;

namespace URLScanner;

public partial class Dashboard : Form
{
    private readonly ApiClient _apiClient;
    private readonly AnalysisService _analysisService;

    private int _offset = 0;
    private int _limit = 10;

    public Dashboard()
    {
        _apiClient = Program.ServiceProvider.GetRequiredService<ApiClient>();
        _analysisService = Program.ServiceProvider.GetRequiredService<AnalysisService>();
        InitializeComponent();
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {
        UpdateAnalysisDtg();
    }

    private async void btnScan_Click(object sender, EventArgs e)
    {
        var url = txtUrlScan.Text.Trim();
        var isValid = Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
            && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        if (!isValid)
        {
            MessageBox.Show(@"Provided URL is invalid. Make sure to use proper schema.",
                @"Invalid URL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var task = _apiClient.SubmitScanAsync(url);
        var result = await task;
        if (result is ApiErrorDto error)
        {
            MessageBox.Show($@"An error occurred while submitting the scan: ({error.Code}) {error.Message}.",
                               @"Scan Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        var scan = result as ScanDto;
        MessageBox.Show(@"Scan has been successfully submitted. Please wait for the results.",
                                   @"Scan Submission Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        btnScan.Enabled = false;

        var analysis = await GetAnalysisAsync(scan!);
        if (analysis != null && analysis.Status == "completed")
        {
            analysis.Url = url;
            _analysisService.CreateAnalysis(analysis);
            MessageBox.Show(@"Analysis has been successfully retrieved and saved.",
                               @"Analysis Retrieval Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        btnScan.Enabled = true;
        UpdateAnalysisDtg();
    }

    private async Task<AnalysisDto?> GetAnalysisAsync(ScanDto scan)
    {
        var status = "pending";
        AnalysisDto? analysis;
        do
        {
            var result = await _apiClient.GetAnalysisAsync(scan.Id);
            if (result is ApiErrorDto error)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($@"An error occurred while retrieving the analysis: {error.Message}",
                                                      @"Analysis Retrieval Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
                return null;
            }
            analysis = result as AnalysisDto;
            status = analysis!.Status;
            await Task.Delay(5000);
        } while (status != "completed");
        return analysis;
    }

    private void UpdateAnalysisDtg(Expression<Func<Analysis, bool>>? filter = null, int offset = 0, int limit = 10)
    {
        var analyses = filter == null
            ? _analysisService.GetAllAnalyses(offset, limit)
            : _analysisService.GetAllAnalysesByFilter(filter, offset, limit);
        dtgAnalysis.DataSource = analyses.Select(a => new
        {
            a.Id,
            a.Url,
            a.Date
        }).ToList();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var url = txtUrlSearch.Text;
        if (string.IsNullOrEmpty(url)) return;
        UpdateAnalysisDtg(a => a.Url.Contains(url.Trim()));

    }

    private void btnPrevious_Click(object sender, EventArgs e)
    {
        string? url = txtUrlSearch.Text;
        _offset = Math.Max(0, _offset - _limit);
        UpdateAnalysisDtg(!string.IsNullOrEmpty(url) ? a => a.Url.Contains(url.Trim()) : null, _offset, _limit);
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        string? url = txtUrlSearch.Text;
        Expression<Func<Analysis, bool>>? filter = string.IsNullOrEmpty(url) ? null : a => a.Url.Contains(url.Trim());
        var nextPage = filter == null
            ? _analysisService.GetAllAnalyses(_offset + _limit, _limit)
            : _analysisService.GetAllAnalysesByFilter(filter, _offset + _limit, _limit);
        if (nextPage.Any())
        {
            _offset += _limit;
            dtgAnalysis.DataSource = nextPage.Select(a => new
            {
                a.Id,
                a.Url,
                a.Date
            }).ToList();
            return;
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in dtgAnalysis.SelectedRows)
        {
            var id = row.Cells["dtgId"].Value;
            _analysisService.DeleteAnalysis((int)id);
        }
        string? url = txtUrlSearch.Text;
        UpdateAnalysisDtg(!string.IsNullOrEmpty(url) ? a => a.Url.Contains(url.Trim()) : null);
        MessageBox.Show(@"Selected analysis has been successfully deleted.",
                       @"Analysis Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        txtUrlSearch.Text = string.Empty;
        UpdateAnalysisDtg();
    }

    private void dtgAnalysis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;
        var id = dtgAnalysis.Rows[e.RowIndex].Cells["dtgId"].Value;
        var analysis = _analysisService.GetAnalysisById((int)id);
        new AnalysisDetails(analysis!).ShowDialog();
    }
}