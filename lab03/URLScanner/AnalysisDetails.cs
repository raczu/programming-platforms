using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URLScanner.Models.Database;

namespace URLScanner
{
    public partial class AnalysisDetails : Form
    {
        private readonly Analysis _analysis;

        private int _offset = 0;
        private int _limit = 10;

        public AnalysisDetails(Analysis analysis)
        {
            InitializeComponent();
            _analysis = analysis;
        }

        private void AnalysisDetails_Load(object sender, EventArgs e)
        {
            txtUrl.Text = _analysis.Url;
            txtDate.Text = _analysis.Date.ToString();
            txtMalicious.Text = _analysis.Stat.Malicious.ToString();
            txtSuspicious.Text = _analysis.Stat.Suspicious.ToString();
            txtUndetected.Text = _analysis.Stat.Undetected.ToString();
            txtHarmless.Text = _analysis.Stat.Harmless.ToString();
            txtTimeout.Text = _analysis.Stat.Timeout.ToString();
            UpdateResultsDtg();
        }

        private void UpdateResultsDtg(int offset = 0, int limit = 10)
        {
            var results = _analysis.Results.Skip(offset).Take(limit).ToList();
            dtgResults.DataSource = results.Select(r => new
            {
                r.Method,
                r.Engine,
                r.Category,
                r.Outcome
            }).ToList();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _offset = Math.Max(0, _offset - _limit);
            UpdateResultsDtg(_offset, _limit);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var nextPage = _analysis.Results.Skip(_offset + _limit).Take(_limit).ToList();
            if (nextPage.Count != 0)
            {
                _offset += _limit;
                dtgResults.DataSource = nextPage.Select(r => new
                {
                    r.Method,
                    r.Engine,
                    r.Category,
                    r.Outcome
                }).ToList();
                return;
            }
        }
    }
}
