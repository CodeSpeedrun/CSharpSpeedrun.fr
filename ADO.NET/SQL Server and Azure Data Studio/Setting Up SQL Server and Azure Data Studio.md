Setting Up SQL Server and Azure Data Studio

using a Windows-based development machine and installed Visual Studio 2019, you also
have an instance of SQL Server Express (called localdb) installed,

you can run SQL
Server inside a Docker container on your Mac- or Linux-based workstation. Docker also works on Windows
machines, so you are welcome to run the examples in this book using Docker regardless of your operating
system of choice.


www.docker.com/get-started.
Download and install the
appropriate version (Windows, Mac, Linux) for your workstation (you will need a free DockerHub user
account). Make sure you select Linux containers when prompted.


The container choice (Windows or Linux) is the operating system running inside the container, not the
operating system of your workstation.


Pulling the Image and Running SQL Server 2019
Containers are based on images, and each image is a layered set that builds up the final product.

docker pull mcr.microsoft.com/mssql/server:2019-latest

docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=P@ssw0rd" -p 5433:1433 --name AutoLot -d mcr.
microsoft.com/mssql/server:2019-latest
The previous command accepts the end user license agreement, sets the password (in real life, you
need to use a strong password), sets the port mapping (port 5433 on your machine maps to the default port
for SQL Server in the container (1433), then names the container (AutoLot), and finally informs Docker to
use the previously downloaded image.


To stop the container, enter docker stop 34747, where the numbers 34747 are the first five characters
of the container ID. To restart the container, enter docker start 34747, again updating the command with
the beginning of your container’s ID.


