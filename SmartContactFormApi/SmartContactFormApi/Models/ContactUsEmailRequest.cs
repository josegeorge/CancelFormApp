using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SmartContactFormApi.Models
{
    [DataContract]
    public class ContactUsEmailRequest
    {
        [DataMember]
        [Required]
        public int ProductId { get; set; }

        [DataMember]
        [Required]
        public SubjectType SubjectType { get; set; }

        [DataMember]
        public Guid? ApplicantId { get; set; }

        [DataMember]
        [Required]
        public string Name { get; set; }

        [DataMember]
        public DateTime RequestDateTime { get; set; }

        [DataMember]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataMember]
        [Required]
        public string Message { get; set; }
    }
}