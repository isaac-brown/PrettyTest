# build-nuget-package.ps1 - See LICENCE.txt in root folder for licence details.
# Author: Isaac Brown
# Runs all tests and builds the solution.

Set-Location ..\
dotnet build -c Release
Set-Location .\test\PrettyTest.Test\
dotnet test
