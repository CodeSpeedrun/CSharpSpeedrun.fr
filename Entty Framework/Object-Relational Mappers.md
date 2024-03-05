Object-Relational Mappers
ADO.NET lets you select, insert, update, and delete data with connections,
commands, and data readers.
the way in which a physical database is usually constructed is squarely focused
on database constructs such as foreign keys, views, stored procedures, and data normalization, not objectoriented
programming.\

object-relational mapping frameworks (commonly referred to as ORMs) in .NET
greatly enhanced the data access story by managing the bulk of Create, Read, Update, and Delete (CRUD)
data access tasks for the developer. The developer creates a mapping between the .NET objects and the
relational database, and the ORM manages connections, query generation, change tracking, and persisting
the data. This leaves the developer free to focus on the business needs of the application.


ORMs are not magical unicorns riding on rainbows. Every decision
involves trade-offs. ORMs reduce the amount of work for developers creating data access layers but can also
introduce performance and scaling issues if used improperly. Use ORMs for CRUD operations and use the power
of your database for set-based operations.


