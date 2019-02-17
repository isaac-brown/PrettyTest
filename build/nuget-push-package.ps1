# nuget-push-package.ps1 - See LICENCE.txt in root folder for licence details.
# Author: Isaac Brown
# Pushes the built NuGet package to www.nuget.org. The pacakge will be built first.

& "$PSScriptRoot\nuget-build-package.ps1"

$currentPackage = Get-ChildItem $PSScriptRoot\nuget `
                | Where-Object { $_.Name -match "^PrettyTest(\.\d){3}.nupkg" } `
                | Sort-Object { $_.Name } -Descending `
                | Select-Object -First 1

dotnet nuget push $currentPackage.FullName -s https://api.nuget.org/v3/index.json
