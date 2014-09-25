using System.Runtime.Serialization;

namespace MailChimp.Gallery
{
    [DataContract]
    public class GalleryFolder
    {
        /// <summary>
        /// The id of the folder
        /// </summary>
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// The file name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The number of files in the folder
        /// </summary>
        [DataMember(Name = "file_count")]
        public int FileCount
        {
            get;
            set;
        }
    }
}
