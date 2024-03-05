

Serializing and Deserialization with the XmlSerializer

use this
formatter to persist the public state of a given object as pure XML. Note that the XmlSerializer requires you
to declare the type that will be serialized (or deserialized).

it is often critical to ensure the data within
an XML document conforms to a set of rules that establishes the validity of the data.

valid documents conform to agreed-upon
formatting rules (e.g., field X must be expressed as an attribute and not a subelement), which are typically
defined by an XML schema or document-type definition (DTD) file.


Select Attributes of the System.Xml.Serialization Namespace
.NET Attribute Meaning in Life
[XmlAttribute] You can use this .NET attribute on a public field or property in a class to tell
XmlSerializer to serialize the data as an XML attribute (rather than as a subelement).
[XmlElement] The field or property will be serialized as an XML element named as you so choose.
[XmlEnum] This attribute provides the element name of an enumeration member.
[XmlRoot] This attribute controls how the root element will be constructed (namespace and
element name).
[XmlText] The property or field will be serialized as XML text (i.e., the content between the start
tag and the end tag of the root element).
[XmlType] This attribute provides the name and namespace of the XML type.


Serializing Objects Using the XmlSerializer
Consider the following local function added to your Program.cs class:
static void SaveAsXmlFormat<T>(T objGraph, string fileName)
{
//Must declare type in the constructor of the XmlSerializer
XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
using (Stream fStream = new FileStream(fileName,
FileMode.Create, FileAccess.Write, FileShare.None))
{
xmlFormat.Serialize(fStream, objGraph);
}
}
Add the following code to your top-level statements:
SaveAsXmlFormat(jbc, "CarData.xml");
Console.WriteLine("=> Saved car in XML format!");
SaveAsXmlFormat(p, "PersonData.xml");
Console.WriteLine("=> Saved person in XML format!");

If you were to look within the newly generated CarData.xml file, you would find the XML data shown
here:
<?xml version="1.0"?>
<JamesBondCar xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd=
"http://www.w3.org/2001/XMLSchema" xmlns="http://www.MyCompany.com">
<TheRadio>
<HasTweeters>true</HasTweeters>
<HasSubWoofers>false</HasSubWoofers>
<StationPresets>
<double>89.3</double>
<double>105.1</double>
<double>97.1</double>
</StationPresets>
<RadioId>XF-552RR6</RadioId>
</TheRadio>
<IsHatchBack>false</IsHatchBack>
<CanFly>true</CanFly>
<CanSubmerge>false</CanSubmerge>
</JamesBondCar>


If you want to specify a custom XML namespace that qualifies the JamesBondCar and encodes the
canFly and canSubmerge values as XML attributes, you can do so by modifying the C# definition of
JamesBondCar, like so:
[Serializable, XmlRoot(Namespace = "http://www.MyCompany.com")]
public class JamesBondCar : Car
{
[XmlAttribute]
public bool CanFly;
[XmlAttribute]
public bool CanSubmerge;


