Applying LINQ Queries to Collection Objects
LINQ to
Objects can be used on any type implementing IEnumerable<T>.

// Find all Car objects in the List<>, where the Speed is
// greater than 55.
var fastCars = from c in myCars where c.Speed > 55 select c;

// Find the fast BMWs!
var fastCars = from c in myCars where c.Speed > 90 && c.Make == "BMW" select c;



Applying LINQ Queries to Nongeneric Collections
// Here is a nongeneric collection of cars.
ArrayList myCars = new ArrayList() {
new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
};
// Transform ArrayList into an IEnumerable<T>-compatible type.
var myCarsEnum = myCars.OfType<Car>();
// Create a query expression targeting the compatible type.
var fastCars = from c in myCarsEnum where c.Speed > 55 select c;
foreach (var car in fastCars)


