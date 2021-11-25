# _02_MonoMySQLConnection

User interface to test connection through MySQL database.

Grafical User interface has been developed using MonoDevelop GUI Toolkits.

Note: MySQL must be installed in your local computer.

Please see [dotnet connector](https://dev.mysql.com/doc/connector-net/en/connector-net-installation-unix.html) to download MySql.Data.dll file in order to compile the application.

## Create a new database
Open MySQL: mysql -u root -p

            CREATE DATABASE     `mydb`;


## GUI input data
Server:    localhost

Port:      3306 (Only numeric digits)

Database:  mydb

User:      root

Passworld: <userPassworld>
            
            

Once that you fill input data to the GUI clic on "Test Connection" button.
