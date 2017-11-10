

# Blade - Shaping Source Code - a code generation tool with Handlebars

BLADE - A console utility developed in .NET Core 2.0 using Visual Studio Code on macOS.  The initial goal of the project is to use SQLClient and Handlebars.Net libraries to construct generated program source code (initially C#) for data access.  Ultimately Blade will be able to generate any type of source code the template references.  Blade is a developer tool that shapes source code, saves time, and reduces bugs.

> usage: $> blade {config.json}

## Who makes Blade?  Can I help with the development?

Daniel Pigford, you can find me on GitHub as DanielPigford.  Feel free to pass along _any_ feedback or suggestions for Blade.

## What development tools are used to build Blade?

For the development of BLADE I use Visual Studio Code (macOS), .NET Core 2.0, Handlebars.Net and Json.NET.

* Visual Studio Code: https://code.visualstudio.com
* C#: https://docs.microsoft.com/en-us/dotnet/csharp/csharp
* .NET Core 2.0 SDK: https://github.com/dotnet/core/blob/master/release-notes/download-archives/2.0.0-download.md
* Handlebars.Net: https://github.com/rexm/Handlebars.Net
* Json.NET: https://www.newtonsoft.com/json
* .NET Core Data Access: https://blogs.msdn.microsoft.com/dotnet/2016/11/09/net-core-data-access/

## Why use .NET Core?

Write once, run anywhere. (Windows, macOS, Linux)

## What is Blade?

Blade was created to answer a need to generate data access class source code in .NET projects using the Database First generation approach.  Database First means the database either exists or is created prior to building the application and referenced to create source code patterns.  The long term goal is to make blade compatible with SQL Server, MySQL, Postgres, SQLite and Oracle databases.

The original data access templates that the Blade utility uses were originally developed by Daniel for another generation tool that has since been retired.  The Blade utility replaces that previous tool.  https://my2ndgeneration.wordpress.com/2014/03/20/xojo-mybackspace-and-m2g/

The source code for Blade is available on GitHub.  https://github.com/DanielPigford/blade/

## Why is it called Blade?

Blade is named after devices with ultra fine edges used for cutting, shaping and carving.  We use Blade to build/shape/cut/create source code using Handlebar templates and database schema information.

## What Handlebar Templates are available for Blade?

There is a growing list of template groups available.

* razor - Data access templates for .NET Core, .NET Framework and JavaScript.  100% source code, no assemblies required.
* switch - Development and management templates for TSQL.
* docs - Documentation templates for TSQL.

## Will you be making more templates?

Yes.

## Where are the templates hosted?

The Handlebar templates are currently hosted on GitHub.  The repository is public and we are accepting requests to help with our development process.

* razor:  https://github.com/DanielPigford/razor
* switch: https://github.com/DanielPigford/switch 

## Can I make my own templates?

Yes.  Many people do for coding templates, snippets and libraries.

## What does Blade do?

Blade generates source code files based on Handlebar templates using database schema definition information as input into the template generation process.

## How do I use Blade in my project?


