namespace Brutal.Concurrency.Jobs;

/// <summary>
/// Represents performance metrics and operational state details of a job runner.
/// </summary>
public struct JobRunnerMetrics
{
    /// <summary>
    /// The average time taken in milliseconds
    /// </summary>
    public double AverageTickTimeMillis;

    /// <summary>
    /// The largest time taken to date in milliseconds
    /// </summary>
    public double MaxTickTimeMillis;

    /// <summary>
    /// The last execution time taken in milliseconds
    /// </summary>
    public double LastTickTimeMillis;
}
