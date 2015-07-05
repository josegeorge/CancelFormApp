using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SmartContactFormApi.Models
{
    [DataContract]
    public class ContactUsEmailResponse
    {
        [DataMember]
        [Required]
        public bool Status { get; set; }


        [DataMember]
        [Required]
        public string Message { get; set; }

        [DataMember]
        [Required]
        public string Error { get; set; }
    }
}