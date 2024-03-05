Creating the Database

To create the AutoLot database, connect to your database server using Azure Data Studio. Open a new query
by selecting File ➤ New Query (or by pressing Ctrl+N) and entering the following command text:
USE [master]
GO
CREATE DATABASE [AutoLot]
GO
ALTER DATABASE [AutoLot50] SET RECOVERY SIMPLE
GO
Other than changing the recovery mode to simple, this creates the AutoLot database using the SQL
Server defaults. Click Run (or press F5) to create the database