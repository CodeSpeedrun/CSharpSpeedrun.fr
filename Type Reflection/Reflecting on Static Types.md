Reflecting on Static Types

Static types cannot be loaded using the Type.GetType(typeName)
method. Instead, you must use another mechanism, the typeof function from System.Type. Update the
program to handle the System.Console special case like this:
Type t = Type.GetType(typeName);
if (t == null && typeName.Equals("System.Console",


