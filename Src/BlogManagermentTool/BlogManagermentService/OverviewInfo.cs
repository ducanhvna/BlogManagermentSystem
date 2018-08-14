using System.Runtime.Serialization;

namespace BlogManagermentService
{
    [DataContract]
    public class OverviewInfo
    {
        [DataMember]
        public short Key { get; set; }
        [DataMember]
        public string DisplayName { get; set; }
    }
}