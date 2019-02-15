# PrettyTest

This project is intended to add prettier unit test names when running XUnit tests. It is inspired by the blog post [Creating Readable xUnit Test Method Names Automatically]((https://bitwiseguy.wordpress.com/2015/11/23/creating-readable-xunit-test-method-names-automatically/)).

The gist of it is that underscores in method names will be replaced by spaces. Requests for more comprehensive method name transformation is welcomed.

## Installation

This will be completed once available in a packet managet such as [Nuget](https://www.nuget.org/).

## Features

Currently converting underscores to spaces is supported.

``` csharp
// Test explorer name: 'Some test that does something fun'
public void Some_test_that_does_something_fun()
{
    // Code and things.
}
```
