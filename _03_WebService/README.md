# _03_WebService


## Create ASP NET Core Empty Project


dotnet new web -o _03_WebService

## PostgreSQL


## Install Nuget package

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 3.1.3

## Build
dotnet build

## Run 
dotnet run
https://localhost:5001/api/catpersonal

## Publish

dotnet publish -p:PublishProfile=FolderProfile