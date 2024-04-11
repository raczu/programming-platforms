using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using URLScanner.Models.Database;
using URLScanner.Models.DTOs;

namespace URLScanner.Services;

public class AnalysisService(URLScannerContext context)
{
    private readonly URLScannerContext _context = context;

    public Analysis CreateAnalysis(AnalysisDto analysisDto)
    {
        var analysis = new Analysis
        {
            Url = analysisDto.Url,
            Date = analysisDto.Date,
            Stat = new Stat
            {
                Malicious = analysisDto.Stat.Malicious,
                Suspicious = analysisDto.Stat.Suspicious,
                Undetected = analysisDto.Stat.Undetected,
                Harmless = analysisDto.Stat.Harmless,
                Timeout = analysisDto.Stat.Timeout
            },
            Results = new List<Result>()
        };

        foreach (var result in analysisDto.Results.Select(entity => new Result
        {
            Method = entity.Value.Method,
            Engine = entity.Value.Engine,
            Category = entity.Value.Category,
            Outcome = entity.Value.Outcome
        }))
        {
            analysis.Results.Add(result);
        }

        _context.Analyses.Add(analysis);
        _context.SaveChanges();

        return analysis;
    }

    public Analysis? GetAnalysisById(int id)
    {
        return _context.Analyses
            .Include(a => a.Stat)
            .Include(a => a.Results)
            .FirstOrDefault(a => a.Id == id);
    }

    public IEnumerable<Analysis> GetAllAnalyses(int offset = 0, int limit = 15)
    {
        return [.. _context.Analyses
            .Include(a => a.Stat)
            .Include(a => a.Results)
            .OrderByDescending(a => a.Date)
            .Skip(offset)
            .Take(limit)];
    }

    public IEnumerable<Analysis> GetAllAnalysesByFilter(Expression<Func<Analysis, bool>> filter, int offset = 0, int limit = 15)
    {
        return [.. _context.Analyses
            .Include(a => a.Stat)
            .Include(a => a.Results)
            .Where(filter)
            .OrderByDescending(a => a.Date)
            .Skip(offset)
            .Take(limit)];
    }

    public void DeleteAnalysis(int id)
    {
        var analysis = _context.Analyses.FirstOrDefault(a => a.Id == id);
        if (analysis == null) return;
        _context.Analyses.Remove(analysis);
        _context.SaveChanges();
    }
}