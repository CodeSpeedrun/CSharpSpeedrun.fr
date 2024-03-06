Conventional Routing

The placeholder {id} is custom and is translated into a parameter (named id) for the
action method. Adding a question mark to a route token indicates that it is optional.
app.UseEndpoints(endpoints =>
{
endpoints.MapControllerRoute(
name: "default",
template: "{controller=Home}/{action=Index}/{id?}");
});

