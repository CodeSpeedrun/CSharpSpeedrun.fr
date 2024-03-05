Adding a Transaction Method to InventoryDal

public void ProcessCreditRisk(bool throwEx, int customerId)
{
OpenConnection();
// First, look up current name based on customer ID.
string fName;
string lName;
var cmdSelect = new SqlCommand(
"Select * from Customers where Id = @customerId",
_sqlConnection);
SqlParameter paramId = new SqlParameter
{
ParameterName = "@customerId",
SqlDbType = SqlDbType.Int,
Value = customerId,
Direction = ParameterDirection.Input
};
cmdSelect.Parameters.Add(paramId);
using (var dataReader = cmdSelect.ExecuteReader())
{
if (dataReader.HasRows)
{
dataReader.Read();
fName = (string) dataReader["FirstName"];
lName = (string) dataReader["LastName"];
}
else
{
CloseConnection();
return;
}
}
cmdSelect.Parameters.Clear();
// Create command objects that represent each step of the operation.
var cmdUpdate = new SqlCommand(
"Update Customers set LastName = LastName + ' (CreditRisk) ' where Id = @customerId",
_sqlConnection);


cmdUpdate.Parameters.Add(paramId);
var cmdInsert = new SqlCommand(
"Insert Into CreditRisks (CustomerId,FirstName, LastName) Values( @CustomerId, @
FirstName, @LastName)",
_sqlConnection);
SqlParameter parameterId2 = new SqlParameter
{
ParameterName = "@CustomerId",
SqlDbType = SqlDbType.Int,
Value = customerId,
Direction = ParameterDirection.Input
};
SqlParameter parameterFirstName = new SqlParameter
{
ParameterName = "@FirstName",
Value = fName,
SqlDbType = SqlDbType.NVarChar,
Size = 50,
Direction = ParameterDirection.Input
};
SqlParameter parameterLastName = new SqlParameter
{
ParameterName = "@LastName",
Value = lName,
SqlDbType = SqlDbType.NVarChar,
Size = 50,
Direction = ParameterDirection.Input
};
cmdInsert.Parameters.Add(parameterId2);
cmdInsert.Parameters.Add(parameterFirstName);
cmdInsert.Parameters.Add(parameterLastName);
// We will get this from the connection object.
SqlTransaction tx = null;
try
{
tx = _sqlConnection.BeginTransaction();
// Enlist the commands into this transaction.
cmdInsert.Transaction = tx;
cmdUpdate.Transaction = tx;
// Execute the commands.
cmdInsert.ExecuteNonQuery();
cmdUpdate.ExecuteNonQuery();
// Simulate error.
if (throwEx)
{
throw new Exception("Sorry! Database error! Tx failed...");
}
// Commit it!
tx.Commit();
}


catch (Exception ex)
{
Console.WriteLine(ex.Message);
// Any error will roll back transaction. Using the new conditional access operator to
check for null.
tx?.Rollback();
}
finally
{
CloseConnection();
}
}

