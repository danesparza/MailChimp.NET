using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    [DataContract]
    public class MemberNote
    {
        /// <summary>
        /// the note id
        /// </summary>
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// the text entered
        /// </summary>
        [DataMember(Name = "note")]
        public string Note
        {
            get;
            set;
        }

        /// <summary>
        /// the date the note was created
        /// </summary>
        [DataMember(Name = "created")]
        public string Created
        {
            get;
            set;
        }

        /// <summary>
        /// the date the note was last updated
        /// </summary>
        [DataMember(Name = "updated")]
        public string Updated
        {
            get;
            set;
        }

        /// <summary>
        /// the name of the user who created the note. This can change as users update their profile.
        /// </summary>
        [DataMember(Name = "created_by_name")]
        public string CreatedByName
        {
            get;
            set;
        }
    }
}
