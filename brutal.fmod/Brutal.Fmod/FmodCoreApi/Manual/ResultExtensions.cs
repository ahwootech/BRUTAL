using System;

namespace Brutal.FmodApi;

/// <summary>
///     An exception thrown by a failed result assertion
/// </summary>
public class FmodResultException : Exception
{
    /// <summary>
    ///     Creates an exception for a failed result assertion
    /// </summary>
    /// <param name="message">The message that describes the failed result</param>
    public FmodResultException(string? message)
        : base(message) { }
}

/// <summary>
///     An extension library for the Result enum
/// </summary>
public static partial class ResultExtensions
{
    /// <summary>
    ///     Throws an exception if the Result does not equal Result.Ok
    /// </summary>
    /// <param name="result">The result code to check</param>
    /// <exception cref="FmodResultException"></exception>
    public static void Check(this Result result)
    {
        if (result != Result.Ok)
        {
            throw new FmodResultException($"{result.ToString()}: {
                    result.GetErrorString()}");
        }
    }
}
