The ControllerBase Class

o helper methods for returning HTTP status codes.

Some of the Helper Methods Provided by the ControllerBase Class
Helper Method Meaning in Life
HttpContext Returns the HttpContext for the currently executing action.
Request Returns the HttpRequest for the currently executing action.
Response Returns the HttpResponse for the currently executing action.
RouteData Returns the RouteData for the currently executing action (routing is covered later in
this chapter).
ModelState Returns the state of the model in regard to model binding and validation (both
covered later in this chapter).
Url Returns an instance of the IUrlHelper, providing access to building URLs for ASP.
NET Core MVC applications and services.



Helper Method Meaning in Life
User Returns the ClaimsPrincipal user.
Content Returns a ContentResult to the response. Overloads allow for adding a content
type and encoding definition.
File Returns a FileContentResult to the response.
Redirect A series of methods that redirect the user to another URL by returning a
RedirectResult.
LocalRedirect A series of methods that redirect the user to another URL only if the URL is local.
More secure than the generic Redirect methods.
RedirectToAction
RedirectToPage
RedirectToRoute
A series of methods that redirect to another action method, Razor Page, or named
route. Routing is covered later in this chapter.
TryUpdateModel Explicit model binding (covered later in this chapter).
TryValidateModel Explicit model validation (covered later in this chapter).