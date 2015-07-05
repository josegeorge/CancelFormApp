using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartContactFormApi.Models
{
    [DataContract]
    public class ContactUsEmailSubjects
    {
        public ContactUsEmailSubjects()
        {
            Subjects = new List<EmailSubject>
            {
                new EmailSubject(SubjectType.GeneralEnquiry, "General Enquiry"),
                new EmailSubject(SubjectType.CancelAccount, "I want to cancel my account"),
                new EmailSubject(SubjectType.CanNotLogin, "I can’t log into my account"),
                new EmailSubject(SubjectType.Complaint, "I want to make a complaint")
            };
        }

        [DataMember]
        public List<EmailSubject> Subjects { get; private set; }
    }
}