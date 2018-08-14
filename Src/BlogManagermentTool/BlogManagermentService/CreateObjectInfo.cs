using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BlogManagermentService
{
    [DataContract]
    public class CreateObjectInfo
    {
        [DataMember]
        public short ObjectId { get; set; }
        [DataMember]
        public int ErrorCode { get; set; }
    }
}