/*
 * HelloConcurrency
 *
 * Runs a few jobs across worker threads with the JobScheduler and waits for them to finish.
 */

#:package Ahwoo.Brutal.Concurrency@2026.10.2

// RIAN: This job system is finely-tuned for the way RW projects like to implement concurrency, and has limitations we should document at some stage.

using Brutal.Concurrency.Jobs;

var scheduler = new JobScheduler(3, "HelloScheduler");

// The second argument is an estimated cost, used to balance jobs across worker threads.
for (var i = 1; i <= 6; i++)
    scheduler.Queue(new HelloJob(i), 10);

scheduler.ExecuteJobs();
scheduler.Wait();

Console.WriteLine("All jobs finished");

class HelloJob(int id) : IJob
{
    public void Run() => Console.WriteLine($"Job {id} running on thread {Environment.CurrentManagedThreadId}");
}
