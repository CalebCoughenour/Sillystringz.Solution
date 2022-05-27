# Sillystringz Factory

#### By Caleb Coughenour

#### This is a factory machine management webpage built using C#/ASP.NET

## Technologies Used

* C#
* HTML
* CSS
* SQL Workbench
* ASP.NET
* Entity Framework
* REPL
* MVC

## Description

 This webpage was programmed using C#, ASP.NET & Entity. It is a factory machine management site that allows the user to add engineers and machines. This is done using the SQL Workbench for the database using three tables to utilize a many-to-many relationship. The user can add multiple engineers to machines that need worked on, they can also add machines to engineers. The home page displays the list of machines and engineers if there are any added. The user can click on each and it will display the details on a separate page.

## Required

* [REPL](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer) - restart terminal after install
* .NET (install using "dotnet tool install -g dotnet-script" in console)
    - Configure Bash environment variables by running "echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.bash_profile" in your gitbash terminal
* [SQL Workbench](https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi)
    - You will need to include your password in the appsettings.json file

## Setup/Installation

* Copy the git repository url from the "code" drop down on this github page
* Open a shell program & navigate to your desktop
* Clone the repository using the copied URL and the "git clone" command
* In the shell program, navigate to the root directory of the newly created file called "Sillstringz.Solution"
* From the root directory, navigate to the directory named "Factory"
* In this directory create a file named "appsettings.json"
* Add the following code to the newly created .json file
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=caleb_coughenour;uid=root;pwd=[YOUR-PASSWORD];"
  }
}
```
* Replace "[YOUR-PASSWORD]" with your SQL password
* Next, in the Factory directory type "dotnet run" to start the program
* Open a web browser and plug "http://localhost:5000/" into the URL bar

## Known Bugs

* No known issues

## License

[MIT](LICENSE)

Copyright (c) 5/27/22 Caleb Coughenour