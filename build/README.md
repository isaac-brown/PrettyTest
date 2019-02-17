# Build Folder

This folder is where scripts live for generating built files for release.

## Files in this folder

 File | Purpose
  --- | ---
 build-nuget-package.ps1 | Builds a NuGet Package ready to upload to [NuGet](https://www.nuget.org/). The package can be found at `.\nuget` once run.
 build-solution.ps1 | Runs all tests and builds the solution.
