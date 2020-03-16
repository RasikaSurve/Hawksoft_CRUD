# Hawsoft_CRUD
CRUD application for Hawksoft

I, Rasika Surve, spent around 2 hours on this project. Mostly because my nuget package manager refused to work.

Please update the appsettings in the solution file from my server to your server name - "DefaultConnection": "server=RSURVEX-MOBL1.

This project has db migrations that can be run using the command
db ef database update
This will basically create a table called User in the database HawksoftRasika on your local.

You can then just run the solution in VS 2017 IIS Express. Navigate to https://localhost:44325/user for the UI.

This application does basic CRUD. 
I did not write any test cases. Also I did not write a data seeder for 20000 records.
