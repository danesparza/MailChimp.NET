using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Folders
{
    [DataContract]
    public class FolderAddResult
    {
        /// <summary>
        /// the folder_id of the newly created folder.
        /// </summary>
        [DataMember(Name = "folder_id")]
        public int NewFolderId
        {
            get;
            set;
        }
    }
}
