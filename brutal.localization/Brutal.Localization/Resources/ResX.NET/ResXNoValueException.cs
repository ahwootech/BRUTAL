namespace Brutal.Localization.ResX
{
    /// <summary>
    /// Thrown when a ResX &lt;data&gt; tag has no descendant XML tag of type &lt;value&gt;.
    /// </summary>
    public class ResXNoValueException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResXNoValueException"/> class.
        /// </summary>
        public ResXNoValueException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResXNoValueException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public ResXNoValueException(string? message)
            : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResXNoValueException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception (if any.)</param>
        public ResXNoValueException(string? message, Exception? innerException)
            : base(message, innerException) { }
    }
}
