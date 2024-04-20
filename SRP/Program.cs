/* https://code-maze.com/single-responsibility-principle */

#pragma warning disable RS0030 // Do not use banned APIs.

using SRP;

var report = new WorkReport();
report.AddEntry(new("123Ds", "Project1", 5));
report.AddEntry(new("987Fc", "Project2", 3));

var scheduler = new Scheduler();
scheduler.AddEntry(new(1, "Do something now.", DateTime.Now.AddDays(5)));
scheduler.AddEntry(new(2, "Don't forget to...", DateTime.Now.AddDays(2)));

Console.WriteLine(report.ToString());
Console.WriteLine(scheduler.ToString());

var saver = new FileSaver();
saver.SaveToFile("Reports", "WorkReport.txt", report);
saver.SaveToFile("Schedulers", "Schedule.txt", scheduler);
