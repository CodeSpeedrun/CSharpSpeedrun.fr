Convention over Configuration

controllers are typically named with the Controller suffix (e.g., HomeController)

When accessed through routing, the Controller suffix is dropped.


By default, an action method (in an
MVC application) will render the view of the same name as the method. Editor and display templates are
named after the class that they render in the view.


Each controller gets its own folder under
the main Views folder named after the controller name (minus the Controller suffix). The action methods
will render views in their controller’s folder by default. For example, the Views/Home folder holds all the
views for the HomeController controller class.

A special folder under Views is named Shared. This folder is accessible to all controllers and their action
methods. After searching the folder named for the controller, if the view can’t be found, then the Shared
folder is searched for the view.

the client side is all contained under the wwwroot
folder. This separation of compiled files from client-side files significantly cleans up the project structure
when working with ASP.NET Core.


