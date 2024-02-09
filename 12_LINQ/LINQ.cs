/* What is LINQ?
LINQ or Language Integrated Query allows us to query data from various sources and formats such as file, database, xml and much more.
*/
string[] myFavCars = {"Toyota", "BMW", "Tesla"};

var myQuery = from car in myFavCars 
                where car.Contains('s')
                select car;
    
foreach(var car in myQuery ){
    Console.WriteLine(car);
}
/*
  
*/