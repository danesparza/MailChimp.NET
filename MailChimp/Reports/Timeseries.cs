using System.Runtime.Serialization;

namespace MailChimp.Reports
{
    /// <summary>
    /// optional - various extra options based on the campaign type
    /// </summary>
   [DataContract]
   public class Industry
    {
       /// <summary>
       ///the selected industry
       /// </summary>
       [DataMember(Name = "type")]
       public string Type { get; set; }
       /// <summary>
       ///industry open rate
       /// </summary>
       [DataMember(Name = "open_rate")]
       public float OpenRate { get; set; }
       /// <summary>
       ///industry click rate
       /// </summary>
       [DataMember(Name = "click_rate")]
       public float ClickRate { get; set; }
       /// <summary>
       ///industry bounce rate
       /// </summary>
       [DataMember(Name = "bounce_rate")]
       public float BounceRate { get; set; }
       /// <summary>
       ///industry unopen rate
       /// </summary>
       [DataMember(Name = "unopen_rate")]
       public float UnopenRate { get; set; }
       /// <summary>
       ///industry unsub rate
       /// </summary>
       [DataMember(Name = "unsub_rate")]
       public float UnsubRate { get; set; }
       /// <summary>
       ///industry abuse rate
       /// </summary>
       [DataMember(Name = "abuse_rate")]
       public float AbuseRate { get; set; }
    }
}
