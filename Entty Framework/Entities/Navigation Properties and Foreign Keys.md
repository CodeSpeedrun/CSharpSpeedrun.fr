Navigation Properties and Foreign Keys

Navigation properties represent how entity classes relate to each other and enable code to traverse from
one entity instance to another. By definition, a navigation property is any property that maps to a nonscalar
type as defined by the database provider.


Terms Used to Describe Navigation Properties and Relationships
Term Meaning in Life
Principal entity The parent of the relationship.
Dependent
entity
The child of the relationship.
Principal key The property/properties used to define the principal entity. Can be the primary key or an
alternate key. Keys can be configured using a single property or multiple properties.
Foreign key The property/properties held by the child entity to store the principal key.
Required
relationship
Relationship where the foreign key value is required (non-nullable).
Optional
relationship
Relationship where the foreign key value is not (nullable).


