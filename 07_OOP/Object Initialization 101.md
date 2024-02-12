object initializer syntax. Using
this technique, it is possible to create a new object variable and assign a slew of properties and/or public
fields in a few lines of code.

// Or make a Point using object init syntax.
Point finalPoint = new Point { X = 30, Y = 30 };
The final Point variable is not making use of a custom constructor (as one might do traditionally) but
is rather setting values to the public X and Y properties. Behind the scenes, the type’s default constructor is
invoked, followed by setting the values to the specified properties. To


