namespace Brutal.Localization.ResX
{
    /// <summary>
    /// Thrown when a ResX &lt;data&gt; tag has no crucial attribute.
    /// </summary>
    public class ResXNoAttributeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResXNoAttributeException"/> class.
        /// </summary>
        public ResXNoAttributeException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResXNoAttributeException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public ResXNoAttributeException(string? message)
            : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResXNoAttributeException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception (if any.)</param>
        public ResXNoAttributeException(string? message, Exception? innerException)
            : base(message, innerException) { }
    }
}
