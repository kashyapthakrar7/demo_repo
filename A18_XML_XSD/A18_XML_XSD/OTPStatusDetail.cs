using System.Xml.Serialization;

namespace A18_XML_XSD
{
    public class OTPStatusDetail
    {
        public OTPStatusDetail() { }

        public OTPStatusDetail(string recipientType, string recepientValue, string status, string description)
        {
            RecipientType = recipientType;
            RecipientValue = RecipientValue;
            Status = status;
            Description = description;
        }

        [XmlElement("RecipientType")]
        public string RecipientType { get; set; }

        [XmlElement("RecipientValue")]
        public string RecipientValue { get; set; }

        [XmlElement("Status")]
        public string Status { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}