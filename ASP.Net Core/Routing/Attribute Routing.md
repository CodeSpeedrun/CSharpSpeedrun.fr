Attribute Routing

public class HomeController : Controller
{
[Route("/")]
[Route("/Home")]
[Route("/Home/Index")]
[Route("/Home/Index/{id?}")]

public IActionResult Index(int? id)
{
...
}
}


[Route("[controller]/[action]/{id?}")]
public class CarController : Controller
{
public IActionResult Delete(int id)
{
...
}
}


Routes can also hard-code the route values instead of using token replacement. The following code will
produce the same result as the previous code sample:
[Route("[controller]/[action]/{id?}")]
public class CarController : Controller
{
[Route("/Delete/Car/{id}")]
public IActionResult Delete(int id)
{
...
}
}


