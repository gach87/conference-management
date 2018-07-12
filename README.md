# Conference Management System

## Dependencies

This project is done using dotnet core version 2.1. Instructions for installing the framework can be found here:
 [Dotnet Core](https://www.microsoft.com/net/)

## Building the project

To build the project you can go to the src directory and run dotnet build, this will generate the dlls in the src/bin directory that can be run using the dotnet command line.

`dotnet build src/` --> Debug configuration available in `src/bin/Debug/netcoreapp2.1`

`dotnet build src/ --configuration Release` --> Release configuration available in `src/bin/Release/netcoreapp2.1`

## Running the project

There are several ways that dotnet core allows to run the project, the easiest one is to run `dotnet run --project src/conference-management.csproj` from the root directory.

The application comes in two modes, with an in memory collection and with the ability to pass the talks from a txt file.

`dotnet run --project src/conference-management.csproj` --> Will run with the in memory repository for the talks. This repository is in the `src/Conferences/TalksMemoryRepository.cs` file and can be changed before running the program to suit the current tasks list.

`dotnet run --project src/conference-management.csproj --talks {filePath}` --> Will run with the text file repository for the talks. The path to the file will be relative to the directory from wich the command is run, but an example file is located in the `src/Conferences/talks.txt` file.

You can also run a pre-built dll using the `dotnet {pathToDll}` command, pointing to the correct dll in the `src/build` directory after the building process has executed correctly.

## Running tests

This project comes with unit tests that can be run using the `dotnet test tests/` command.

There's also a plugin that can show code coverage for the tests. This command can be run as follows 
`dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info tests/conference-management-tests.csproj`.

## Links

The requirements for the application can be found in the following document: [Requirements](./REQUIREMENTS.md).

An explanation of the application architecture can be found in the following document: 
[Architecture](./ARCHITECTURE.md);