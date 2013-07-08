using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Errors
{
    /// <summary>
    /// Mailchimp API exception class
    /// </summary>
    public class MailChimpAPIException : Exception
    {
        public MailChimpAPIException(string message, Exception innerException, ApiError apiError) 
            : base(message, innerException)
        {
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
    }
}
