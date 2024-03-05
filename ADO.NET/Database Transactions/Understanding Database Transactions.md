Understanding Database Transactions

a transaction is a set of database operations that succeed or fail as a collective unit. If one of the
operations fails, all other operations are rolled back, as if nothing ever happened. As you might imagine,
transactions are quite important to ensure that table data is safe, valid, and consistent.


The bank should remove $500 from your savings account.
2. The bank should add $500 to your checking account.
It would be an extremely bad thing if the money were removed from the savings account but not
transferred to the checking account (because of some error on the bank’s part) because then you would
be out $500! However, if these steps are wrapped up into a database transaction, the DBMS ensures that all
related steps occur as a single unit.

the acronym ACID from looking at transactional literature. This represents
the four key properties of a prim-and-proper transaction: atomic (all or nothing), consistent (data remains
stable throughout the transaction), isolated (transactions do not interfere with other operations), and durable
(transactions are saved and logged).

