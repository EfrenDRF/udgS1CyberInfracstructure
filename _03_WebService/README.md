# _03_WebService
Web Service development to execute CRUD (Create, Read, Update, Delete) operation over PostgreSQL database. CRUD operations are managed by REST interface in order to get JSON datatype and HTML service status as well.

NOTE: Project was developed with  .NET core over Ubuntu 20.04 linux platform.

## Create ASP NET Core Empty Project
_03_Webservice project was developed over .NET core templeate. So, Open a new terminal and execute the below commads
  
    cd ./<workDirectory>
    dotnet new web -o _03_WebService

NOTE: This step (Create ASP NET Core Empty Project) is only a reference. It is not necessary to reproduce since project can be cloned from this repository.

## Install Nuget package
In order to interact with PostgreSQL database Nuget package must be installed.

    dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 3.1.3

NOTE: Make sure to move to _03_WebSerice project directory.

## Install PostgreSQL and pgAdmin4
PostgreSQL must be install in order execute CRUD operations. There are so many information over Internet network to install it. Please see this [web page](https://tecadmin.net/how-to-install-postgresql-in-ubuntu-20-04/) as a reference.


## Create Database, table and colmns

    -- Table: public.catpersonal
    -- DROP TABLE IF EXISTS public.catpersonal;

    CREATE TABLE IF NOT EXISTS public.catpersonal
    (
        id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 99999 CACHE 1 ),
        nombre text COLLATE pg_catalog."default",
        CONSTRAINT catpersonal_pkey PRIMARY KEY (id)
    )

    TABLESPACE pg_default;

    ALTER TABLE IF EXISTS public.catpersonal
        OWNER to admin;

## Database connection
PostgreSQL configuration is located on /<workDirectory>/_03_WebService/appsettings.json file.
  
      "PostgreSqlConnectionString": "Server=127.0.0.1;Port=5432;User ID=admin;Database=ciberinfdb;Password=cPostgres1!#;"
  
You have to change string parameters whether to your server info.
  
## Build
Build project operation must be executed to be sure that there are not compiler mistakes. So, run below command:
      dotnet build

NOTE: Make sure to move to _03_WebSerice project directory.
  
## Run 
Execute below command to stat your application.
  
      dotnet run

Go to https://localhost:5001/api/catpersonal using a web browser or you can use Postman with the same Web address in order to excecute REST operation over HTML.

## Publish
    dotnet publish -p:PublishProfile=FolderProfile
    
NOTE: Make sure to move to _03_WebService project directory.
