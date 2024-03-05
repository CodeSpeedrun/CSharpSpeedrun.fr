Serializing Collections of Objects

Create a local function that initializes a list of JamesBondCars and then serializes them to XML.
static void SaveListOfCarsAsXml()
{
//Now persist a List<T> of JamesBondCars.
List<JamesBondCar> myCars = new()
{
new JamesBondCar{CanFly = true, CanSubmerge = true},
new JamesBondCar{CanFly = true, CanSubmerge = false},
new JamesBondCar{CanFly = false, CanSubmerge = true},
new JamesBondCar{CanFly = false, CanSubmerge = false},
};


755
using (Stream fStream = new FileStream("CarCollection.xml",
FileMode.Create, FileAccess.Write, FileShare.None))
{
XmlSerializer xmlFormat = new XmlSerializer(typeof(List<JamesBondCar>));
xmlFormat.Serialize(fStream, myCars);
}
Console.WriteLine("=> Saved list of cars!");
}
To wrap it all up, add the following line to exercise the new function:
SaveListOfCarsAsXml();