using System.Runtime.Serialization;

namespace MailChimp.Folders
{
    [DataContract]
    public class FolderActionResult
    {
        /// <summary>
        /// whether the call worked. Realistically 
        /// this will always be true as errors will 
        /// be thrown otherwise.
        /// </summary>
        [DataMember(Name = "complete")]
        public bool Complete
        {
            get;
            set;
        }
    }
}
