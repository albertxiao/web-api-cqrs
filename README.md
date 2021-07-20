# CQRS with MediatR in .NET 5.0 - MariaDB
This repository contains the REST service, built with .NET 5.0 using CQRS(Command Query Responsibility Segregation) design patern & MediatR to illustrate creating REST API to performing CRUD actions.

## Prerequisites

* Visual Studio 2019
* .NET 5.0
* Maria DB

## How to run the project

* Checkout this project to a location in your disk.
* Open the solution file using the Visual Studio 2019.
* Change the connection string in the appsettings.json file that points to your MariaDB
* Restore the NuGet packages by rebuilding the solution.
* Create databse "cqrs-db" on your maria db database management system 
* running "update-database" on Package Manager Console
* Run the project.
