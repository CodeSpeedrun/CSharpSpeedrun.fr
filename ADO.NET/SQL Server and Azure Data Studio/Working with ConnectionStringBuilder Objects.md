Working with ConnectionStringBuilder Objects

var connectionStringBuilder = new SqlConnectionStringBuilder
{
InitialCatalog = "AutoLot",
DataSource = ".,5433",
UserID = "sa",
Password = "P@ssw0rd",
ConnectTimeout = 30
};
connection.ConnectionString =
connectionStringBuilder.ConnectionString;


