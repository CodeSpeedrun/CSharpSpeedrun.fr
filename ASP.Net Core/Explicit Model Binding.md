Explicit Model Binding

[HttpPost]
public async Task<IActionResult> Create()
{
var vm = new Car();
if (await TryUpdateModelAsync(vm,"",
c=>c.Color,c=>c.PetName,c=>c.MakeId, c=>c.TimeStamp))
{
//do something important
}
}

