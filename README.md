PierresBakery/
├── PierresBakery.csproj
├── Program.cs
├── Models/
│   ├── Bread.cs
│   └── Party.cs
└── PierresBakery.Tests/
    ├── PierresBakery.Tests.csproj
    └── ModelTests/
        └── PierresBakeryTest.cs

## Files and Folders

PierresBakery.csproj: The project file containing project configurations.
Program.cs: The main file where the program starts execution.
Models/: A folder containing model classes.
Bread.cs: A class representing bread products with properties like quantity and price, and methods to calculate total cost and set quantity.
Party.cs: A class representing a party with properties like guest count and theme, and methods to set guest count and theme.
PierresBakery.Tests/: A folder containing test project files.
PierresBakery.Tests.csproj: The project file for the test project.
ModelTests/: A folder containing model tests.
PierresBakeryTest.cs: A file containing unit tests for the Bread and Party classes.

## Getting Started

Prerequisites

To run this project, you need the following installed:

.NET Core 3.1 SDK

Running the Application

Open a terminal and navigate to the PierresBakery folder.
Run the following command to build the project:

dotnet build

dotnet run

Running the Tests

Open a terminal and navigate to the PierresBakery.Tests folder.
Run the following command to run the tests:

dotnet test

## GitHub

https://github.com/izzy503/PierresBakery.git

## Usage

When you run the application, it will first ask you to enter the number of breads you want to buy and the price per bread.
After entering the bread details, it will calculate and display the total cost for the bread.
Next, it will ask you to enter the details for a party, including the number of guests and the theme.
After entering the party details, it will display the party details that you entered.
Contributing

If you would like to contribute to this project, please feel free to fork the repository, create a feature branch, and open a pull request.

## License

This project is licensed under the MIT License.