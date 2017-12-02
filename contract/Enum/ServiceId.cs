using System.Runtime.Serialization;

namespace contract.Enum
{
    [DataContract]
    public enum ServiceId
    {
        [EnumMember(Value = "marketing")] Marketing,

        [EnumMember(Value = "alist")] Alist
    }
}