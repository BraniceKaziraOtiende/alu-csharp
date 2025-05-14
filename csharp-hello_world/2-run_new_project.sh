#!/usr/bin/env bash

# Create and initialize a new C# console project in 2-new_project
dotnet new console -o 2-new_project

# Build the project
dotnet build 2-new_project

# Run the project
dotnet run --project 2-new_project
