using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace A18_XML_XSD
{
    public class A18CkycResendOTPRequest : RequestBaseClass
    {
        [XmlElement("ReferenceGuid")]
        public string ReferenceGuid { get; set; }
    }
}
