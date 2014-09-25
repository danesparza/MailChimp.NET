namespace MailChimp.Reports
{
    using System.Runtime.Serialization;

    /// <summary>
    ///optional - common options for controlling returned data
    /// </summary>
    [DataContract]
    public class CommonOptions
    {
        /// <summary>
        /// optional for large data sets, the page number to start at - defaults to 1st page of data (page 0)
        /// </summary>
        [DataMember(Name = "start")]
        public int Start { get; set; }

        /// <summary>
        /// optional for large data sets, the number of results to return - defaults to 25, upper limit set at 100
        /// </summary>
        [DataMember(Name = "limit")]
        public int Limit { get; set; }
    }
}
