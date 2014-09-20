using System.Runtime.Serialization;

namespace MailChimp.Gallery
{
    [DataContract]
    public class AddGalleryFolderResult
    {
        /// <summary>
        /// the id of the new folder
        /// </summary>
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// the name of the new folder
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }
    }
}