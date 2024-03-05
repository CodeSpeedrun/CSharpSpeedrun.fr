Deserializing Objects and Collections of Objects

XML deserialization is literally the opposite of serializing objects (and collections of objects). Consider the
following local function to deserialize XML back into an object graph. Notice that, once again, the type to
work with must be passed into the constructor for the XmlSerializer:
static T ReadAsXmlFormat<T>(string fileName)
{
// Create a typed instance of the XmlSerializer
XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
using (Stream fStream = new FileStream(fileName, FileMode.Open))
{
T obj = default;
obj = (T)xmlFormat.Deserialize(fStream);
return obj;
}
}

