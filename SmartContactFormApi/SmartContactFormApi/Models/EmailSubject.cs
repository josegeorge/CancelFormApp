using System.Runtime.Serialization;

namespace SmartContactFormApi.Models
{
    [DataContract]
    public class EmailSubject
    {
        public EmailSubject(SubjectType subjectType, string subject)
        {
            Type = subjectType;
            Subject = subject;
        }
      
        [DataMember]
        public SubjectType Type { get; private set; }

        [DataMember]
        public string Subject { get; private set; }

        
    }
}