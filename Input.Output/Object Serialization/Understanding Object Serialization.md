Understanding Object Serialization

The term serialization describes the process of persisting (and possibly transferring) the state of an
object into a stream (e.g., file stream or memory stream). The persisted data sequence contains all the
necessary information you need to reconstruct (or deserialize) the public state of the object for use later.


For example, assume you want to create a GUI-based desktop application that provides a way for end
users to save their preferences (e.g., window color and font size). To do this, you might define a class named
UserPrefs that encapsulates 20 or so pieces of field data. Now, if you were to use a System.IO.BinaryWriter
type, you would need to save each field of the UserPrefs object manually. Likewise, if you were to load the
data from a file back into memory, you would need to use a System.IO.BinaryReader and (once again)
manually read in each value to reconfigure a new UserPrefs object.
This is all doable, but you can save yourself a good amount of time by using either eXtensible Markup
Language (XML) or JavaScript Object Notation (JSON) serialization.


