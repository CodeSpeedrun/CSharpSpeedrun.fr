HTTP Verbs in Web Application (MVC) Routing

[Route("[controller]/[action]/{id?}")]
public class CarController : Controller
{
[HttpGet]
public IActionResult Delete(int id)
{
...
}

[HttpPost]
public IActionResult Delete(int id, Car recordToDelete)
{
...
}
}

