namespace Brutal.Concurrency.Jobs;

/// <summary>
/// Represents a job that can be executed by the JobScheduler.
/// </summary>
public interface IJob
{
    void Run();
}
