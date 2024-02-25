Understanding the Role of .NET Attributes

.NET Core platform provides a way for programmers to embed additional metadata into
an assembly using attributes.

. In a nutshell, attributes are nothing more than code annotations that can
be applied to a given type (class, interface, structure, etc.), member (property, method, etc.), assembly, or
module.


If you have a field that should not be exported to JSON,
you can apply the [JsonIgnore] attribute.
public class Motorcycle
{
[JsonIgnore]
public float weightOfCurrentPassengers;
// These fields are still serializable.
public bool hasRadioSystem;


namespace ApplyingAttributes
{
[XmlRoot(Namespace = "http://www.MyCompany.com"), Obsolete("Use another vehicle!")]
public class HorseAndBuggy

public sealed class ObsoleteAttribute : Attribute
{
public ObsoleteAttribute(string message, bool error);
public ObsoleteAttribute(string message);


HorseAndBuggy mule = new HorseAndBuggy();
you would find that a compiler warning is issued. The warning is specifically CS0618, and the message
includes the information passed into the attribute.
‘HorseAndBuggy’ is obsolete: ‘Use another vehicle!'

