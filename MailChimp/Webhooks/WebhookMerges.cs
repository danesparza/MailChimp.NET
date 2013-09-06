using System.Runtime.Serialization;

namespace MailChimp.Webhooks
{
    /// <summary>
    /// Merge Field information from a webhook response
    /// </summary>
   [DataContract]
   public class WebhookMerges
    {
       [DataMember(Name="EMAIL")]
       public string Email
       {
           get;
           set;
       }
       [DataMember(Name = "FNAME")]
       public string FirstName
       {
           get;
           set;
       }
       [DataMember(Name = "LNAME")]
       public string LastName
       {
           get;
           set;
       }
       [DataMember(Name = "INTERESTS")]
       public string Interests
       {
           get;
           set;
       }
    }
}
