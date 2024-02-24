Naming Conventions for Asynchronous Methods

the await token extracts the internal return value contained in the Task object. Since you have
not used this token, you have a type mismatch.

Microsoft recommends (as a best practice) that any method returning a Task be marked
with an Async suffix.

