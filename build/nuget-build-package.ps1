# nuget-build-package.ps1 - See LICENCE.txt in root folder for licence details.
# Author: Isaac Brown
# Builds a nuget package for the application.

dotnet pack ..\src\PrettyTest\PrettyTest.csproj -c Release -o $PSScriptRoot\nuget -v q
