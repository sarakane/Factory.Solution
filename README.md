# _Dr. Sneuss' Factory_

#### _C# ASP .NET Core MVC project for Epicodus, 2020.08.07_

#### By _**Sara Kane**_


## Description

MVC web application for a factory to keep track of machine repairs by managing engineers and the machines they are licensed to fix.


## Specifications

| User Stories                                                                                                                                                                                                                                                               | Input                                                                                                                                  | Output                                                                                           | Completed? |
|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------|------------|
| As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.                                                                                                                                             | Click on 'show all engineers' or 'show all machines'                                                                                   | All engineers or machines are shown                                                              | Y          |
| As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it. | Select an engineer or machine                                                                                                          | Details for that engineer or machine are shown                                                   | Y          |
| As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.                                                                                                              | Click 'Add new engineer' or 'Add new machine', fill out the information and click 'add'                                                | Machine or engineer is added to the system                                                       | Y          |
| As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed                                                                                               | Engineer is added without a machine or machine is added without an engineer                                                            | Machine or engineer is added to the system                                                       | Y          |
| As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.                           | User clicks on 'add machine' or 'remove machine' for an engineer, or user clicks on 'add engineer' or 'remove engineer' for a machine. | A machine is added or removed to an engineer, or the engineer is added or removed for a machine. | Y          |
| I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.                                                               | User navigates to the home index                                                                                                              | All engineers and machines are shows with links to their details                                 | Y          |


## Setup/Installation Requirements
### Required Software
* [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* [MySQL Community Server and MySQL Workbench](https://dev.mysql.com/downloads/)

* Clone the GitHub repository by running `git clone https://github.com/sarakane/Factory.Solution.git` in the terminal.
  * Or download the ZIP file by clicking on `Code` then `Download ZIP` from this repository.

### View locally 
* Navigate to the newly created `Factory.Solution` folder.
* Navigate to the `Factory` project folder.
* In the terminal, run `dotnet restore` and `dotnet build` to build the application.
* Enter `dotnet tool install --global dotnet-ef` to install `dotnet ef` as a global tool.
* Enter `dotnet ef database update` to build the MySQL database from the Migrations folder.
* Enter `dotnet run` to run the program.
* Click on the _now lisetning on_ link to open in your browser.

## Known Bugs

* No known bugs.

## Technologies Used

* C# 
* .NET Core 2.2
* ASP .NET Core
* Entity Famework Core
* MySQL Server 8.0.21
* Visual Studio Code

### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_Sara Kane_**