The Bind Attribute

[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Create(Car car)
{
if (ModelState.IsValid)
{
//Add the record
}
//Allow the user to retry
}


[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(
[Bind(nameof(Car.PetName),nameof(Car.Color))]Car car)
{
if (ModelState.IsValid)
{
//Save the data;
}
//Allow the user to retry
}


[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(
[Bind(Prefix="MakeList")]Car car)
{
if (ModelState.IsValid)
{
//Save the data;
}
}


