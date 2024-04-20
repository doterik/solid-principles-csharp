﻿#pragma warning disable SA1309 // Field names should not begin with underscore.

namespace SRP;

public class WorkReport : IEntryManager<WorkReportEntry>
{
    private readonly List<WorkReportEntry> _entries = [];

    public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

    public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

    public override string ToString()
        => string.Join(Environment.NewLine, _entries.Select(x
            => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
}
