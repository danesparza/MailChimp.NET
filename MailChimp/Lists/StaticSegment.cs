using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class StaticSegment
    {
        /// <summary>
        /// the static segment id
        /// </summary>
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// static segment name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// the date the static segment was created
        /// </summary>
        [DataMember(Name = "added")]
        public string Added
        {
            get;
            set;
        }
    }
}
