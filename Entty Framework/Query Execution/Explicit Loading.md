Explicit Loading

Explicit loading is loading data along a navigation property after the core object is already loaded. This
process involves executing an additional database call to get the related data.


The following examples show how to get the related Make data as well as any Orders for a Car record:
//Get the Car record
var car = Context.Cars.First(x => x.Id == 1);
//Get the Make information
Context.Entry(car).Reference(c => c.MakeNavigation).Load();
//Get any orders the Car is related to
Context.Entry(car).Collection(c => c.Orders).Query().IgnoreQueryFilters().Load();

