# CRC Software Programmer Demonstration

## Created by Daniel Byerly

## Purpose
This program serves as a demonstration of basic data retrieval using API Calls via ASP.NET Core as well as Entity Framework Core.

## Assumptions
* The user has a Microsoft SQL Server ver. 21.5.14 server and database set up with identical names to the connection string found on line 10 of `appsettings.json`.
* The user's MSS database is populated with one or more items contained in a table called *Products* which is populated with one or more rows containing valid data matching the syntax of the model found in `\Models\Products.cs`.
* The user is using .NET Framework ver. 8.0.410.
* The user has git installed.
* The user is using a code editing software such as Visual Studio Code on a Windows machine.

## Setup Instructions
### 1. Clone Repository
Clone the repository to your local system with the following command:
`git clone >url<`
Where *>url<* is replaced with the url of this repository.

### 2. Match SQL Connection Strings
Ensure that the connection string found in `appsettings.json` has the matching server and database name as the MSS server and database on your local system. If these do not match, simply modify the 'Server=' and 'Database=' fields. 

### 3. Restore Dependencies
* Open the terminal in the repository folder.
* Change directories into the .NET project folder by running the command: `cd .\Demo\`.
* Restore needed dependencies by running the command: `dotnet restore`.

### 4. Build and Run the Project
* Build the .NET project by running the command: `dotnet build`.
* Run the preexisting project file by running the command: `dotnet run --project Demo.csproj`.
* Open the localhost URL found in the terminal (ex. http://localhost:5247).
* Modify the URL to hit the endpoint (ex. http://localhost:5247/api/products).