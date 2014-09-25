using System.Runtime.Serialization;

namespace MailChimp.Gallery
{
    [DataContract]
    public class Gallery
    {
        /// <summary>
        /// The id of the file
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
        /// The creation date for the item
        /// </summary>
        [DataMember(Name = "time")]
        public string Time
        {
            get;
            set;
        }

        /// <summary>
        /// The file size in bytes
        /// </summary>
        [DataMember(Name = "size")]
        public int Size
        {
            get;
            set;
        }

        /// <summary>
        /// The url to the actual item in the gallery
        /// </summary>
        [DataMember(Name = "full")]
        public string Full
        {
            get;
            set;
        }

        /// <summary>
        /// A url for a thumbnail that can be used to represent the item, generally an image thumbnail or an icon for a file type
        /// </summary>
        [DataMember(Name = "thumb")]
        public string Thumb
        {
            get;
            set;
        }
    }
}
