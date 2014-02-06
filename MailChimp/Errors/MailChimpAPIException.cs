using System;
using System.Runtime.Serialization;

namespace MailChimp.Errors
{
    /// <summary>
    /// Mailchimp API exception class
    /// </summary>
    public class MailChimpAPIException : Exception
    {
        public MailChimpAPIException(string message, Exception internalException, ApiError apiError)
            : base(message)
        {
            this.InternalException = internalException;
            this.MailChimpAPIError = apiError;
        }

        /// <summary>
        /// The Mailchimp API specific error information
        /// </summary>
        public ApiError MailChimpAPIError
        {
            get;
            set;
        }

        /// <summary>
        /// The internal exception that fired from within the MailChimp.NET error handling code
        /// </summary>
        public Exception InternalException
        {
            get;
            set;
        }
    }
}
