Entities

The strongly typed classes that map to database tables are officially called entities. The collection of entities
in an application comprises a conceptual model of a physical database.

The entities and their properties are mapped to the tables and columns using
Entity Framework Core conventions, configuration, and the Fluent API (code).

Mapping Classes to Tables
There are two available class to table mapping schemes available in EF Core: table-per-hierarchy (TPH) and
table-per-type (TPT). TPH mapping is the default and maps an inheritance hierarchy to a single table. New in
EF Core 5, TPT maps each class in the hierarchy to its own table.


