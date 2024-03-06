Implicit Model Binding

[HttpPost]
public ActionResult Create(Car entity)
{
if (ModelState.IsValid)
{
//Save the data;
}
}

