using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace A18_XML_XSD
{
    public class RequestBaseClass
    {
        [XmlElement("ApiToken")]
        public string ApiToken { get; set; }

        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
