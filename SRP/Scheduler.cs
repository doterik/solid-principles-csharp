﻿#pragma warning disable SA1309 // Field names should not begin with underscore.

namespace SRP;

public class Scheduler : IEntryManager<ScheduleTask>
{
    private readonly List<ScheduleTask> _scheduleTasks = [];

    public void AddEntry(ScheduleTask entry) => _scheduleTasks.Add(entry);

    public void RemoveEntryAt(int index) => _scheduleTasks.RemoveAt(index);

    public override string ToString()
        => string.Join(Environment.NewLine, _scheduleTasks.Select(x
            => $"Task with id: {x.TaskId} with content: {x.Content} is going to be executed on: {x.ExecuteOn}"));
}
