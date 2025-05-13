#!/usr/bin/env bash

# Create a new folder named 0-new_project
mkdir 0-new_project

# Navigate into the new project folder
cd 0-new_project

# Initialize a new C# console application
dotnet new console

# Run dotnet restore to restore any dependencies
dotnet restore

# Inform the user that the process is complete
echo "The template 'Console Application' was created successfully."
