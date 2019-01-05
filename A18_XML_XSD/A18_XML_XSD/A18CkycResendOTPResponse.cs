using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace A18_XML_XSD
{
    public class A18CkycResendOTPResponse
    {
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        [XmlElement("ReferenceGuid")]
        public string ReferenceGuid { get; set; }

        [XmlElement("RequestStatus")]
        public string RequestStatus { get; set; }

        [XmlElement("RequestRejectionCode")]
        public string RequestRejectionCode { get; set; }

        [XmlElement("RequestRejectionDescription")]
        public string RequestRejectionDescription { get; set; }

        [XmlArray(ElementName = "OTPStatusDetails")]
        public List<OTPStatusDetail> OTPStatusDetailList { get; set; }
    }
}
