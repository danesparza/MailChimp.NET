using System.Runtime.Serialization;

namespace MailChimp.Folders
{
    [DataContract]
    public class FolderListResult
    {
        /// <summary>
        /// Folder Id for the given folder, this can be used in the campaigns() function to filter on.
        /// </summary>
        [DataMember(Name = "folder_id")]
        public int FolderId { get; set; }

        /// <summary>
        /// Name of the given folder
        /// </summary>
        [DataMember(Name = "name")]
        public string FolderName { get; set; }

        /// <summary>
        /// The date/time the folder was created
        /// </summary>
        [DataMember(Name = "date_created")]
        public string DateCreated { get; set; }

        /// <summary>
        /// The type of the folders being returned, just to make sure you know.
        /// </summary>
        [DataMember(Name = "type")]
        public string FolderType { get; set; }

        /// <summary>
        ///  number of items in the folder.
        /// </summary>
        [DataMember(Name = "cnt")]
        public int FolderItemCount { get; set; }
    }
}
