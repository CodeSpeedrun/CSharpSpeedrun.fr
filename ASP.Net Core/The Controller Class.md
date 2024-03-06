The Controller Class

combines the Controller, ApiController, and AsyncController base classes from MVC5 and Web API
2.2 into one new class, Controller

Some of the Helper Methods Provided by the Controller Class
Helper Method Meaning in Life
ViewDataTempDataViewBag Provide data to the view through the ViewDataDictionary,
TempDataDictionary, and dynamic ViewBag transport.
View Returns a ViewResult (derived from ActionResult) as the HTTP response.
Defaults to a view of the same name as the action method, with the option of
specifying a specific view. All options allow specifying a view model that is
strongly typed and sent to the View. Views are covered in Chapter 31.
PartialView Returns a PartialViewResult to the response pipeline. Partial views are
covered in Chapter 31.
ViewComponent Returns a ViewComponentResult to the response pipeline. ViewComponents
are covered in Chapter 31.
Json Returns a JsonResult containing an object serialized as JSON as the
response.
OnActionExecuting Executes before an action method executes.
OnActionExecutionAsync Async version of OnActionExecuting.
OnActionExecuted Executes after an action method executes.


