using System.Xml.Serialization;

[XmlRoot(ElementName = "ValCurs")]
public class ValCurs
{
    [XmlElement(ElementName = "ValType")]
    public List<ValType> ValType { get; set; }

    [XmlAttribute(AttributeName = "Date")]
    public string Date { get; set; }

    [XmlAttribute(AttributeName = "Name")]
    public string Name { get; set; }

    [XmlAttribute(AttributeName = "Description")]
    public string Description { get; set; }

    [XmlText]
    public string Text { get; set; }
}