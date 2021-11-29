# _03_WebService


## Create ASP NET Core Empty Project


dotnet new web -o _03_WebService


## Install Nuget package

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 3.1.3

## Build
dotnet build

## Publish

dotnet publish -p:PublishProfile=FolderProfile