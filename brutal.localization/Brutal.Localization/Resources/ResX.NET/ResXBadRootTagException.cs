namespace Brutal.Localization.ResX
{
    /// <summary>
    /// Thrown when the root tag of the ResX file is not &lt;root&gt;.
    /// </summary>
    public class ResXBadRootTagException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResXBadRootTagException"/> class.
        /// </summary>
        public ResXBadRootTagException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResXBadRootTagException"/> class.
        /// </summary>
        /// <param name="message">Exception message</param>
        public ResXBadRootTagException(string message)
            : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResXBadRootTagException"/> class.
        /// </summary>
        /// <param name="message">Exception messsage</param>
        /// <param name="innerException">Inner exception (if any.)</param>
        public ResXBadRootTagException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
