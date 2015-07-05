using System.Runtime.Serialization;

namespace SmartContactFormApi.Models
{
    [DataContract]
    public enum SubjectType
    {
        [EnumMember] Unknown = 0,
        [EnumMember] GeneralEnquiry = 1,
        [EnumMember] CancelAccount = 2,
        [EnumMember] CanNotLogin = 3,
        [EnumMember] Complaint = 4
    }
}