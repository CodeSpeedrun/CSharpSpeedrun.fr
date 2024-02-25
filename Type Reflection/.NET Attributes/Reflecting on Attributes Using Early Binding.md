Reflecting on Attributes Using Early Binding

this “other piece of software” could discover the presence of a custom attribute
using either early binding or late binding.

// Get a Type representing the Winnebago.
Type t = typeof(Winnebago);
// Get all attributes on the Winnebago.
object[] customAtts = t.GetCustomAttributes(false);
// Print the description.
foreach (VehicleDescriptionAttribute v in customAtts)
{

    