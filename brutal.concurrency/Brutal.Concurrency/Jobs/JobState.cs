namespace Brutal.Concurrency.Jobs;

/// <summary>
/// Specifies the possible states of a JobRunner within the job system.
///
/// Idle - A JobRunner is not performing work and can have items queued to it or have it execute any queued jobs.
/// Scheduled - A JobRunner has been asked to execute jobs but they haven't started running yet.
/// Running - A JobRunner is processing its job queue and running each job.
/// Abort - A JobRunner has been asked to stop running any more jobs.
/// </summary>
/// <remarks>Do not change the underlying type of JobState without looking at JobRunner's state field. It is required for correct behaviour</remarks>
public enum JobState : int
{
    Idle = 0,
    Scheduled = 1,
    Running = 2,
    Abort = 3,
}

public enum ExecutionResult
{
    Success, // All jobs ran and completed
    NoJobs, // No jobs were queued when ExecuteJobs was called
    Aborted, // Jobs were aborted before completion
}
