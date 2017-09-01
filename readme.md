

# Blade - Code Generation Tool based on Handlebars.Net

blade - This project is a console utility developed in .NET Core 2.0 with Visual Studio Code on macOS.  Being my first .NET Core 2.0 project I am sure I will hit a wall or two.  The goal of the project is to use SQLClient and Handlebars.Net libraries to construct generated code (initially C#) for data access.

## Development Tools

For development you will need Visual Studio Code and .NET Core 2.0.

* Visual Studio Code URL: https://code.visualstudio.com
* .NET Core 2.0 SKD URL: https://github.com/dotnet/core/blob/master/release-notes/download-archives/2.0.0-download.md
* .NET Data Access URL: https://blogs.msdn.microsoft.com/dotnet/2016/11/09/net-core-data-access/

## Why Blade?

Blade was created to answer a need to generate data access class source code in .NET projects using a Database First generation approach.  The approach is that the database is either created or exists prior to building the application.  The application is based on the database and therefor we generate data access classes based on those database objects.  The long term goal is to make blade compatible with SQL Server, MySQL, Postgres, SQLite and Oracle databases.

Actually the templates that the Blade utility uses were developed first (in Handlebars) and used with another generation tool that has since been retired.  The Blade utility replaces that previous tool.

## Why is it called Blade?

Blade is named after devices with sharp edges used for cutting, shaping and carving.

## What Handlebar Templates are available for Blade?

As of today there are only a few template groups in our repository.

razor - Data access templates for .NET Core and Framework.  100% source code, no assemblies required.
switch - Development and management templates for TSQL.

## Will you be making more templates?

Yes.

## Can I make my own templates?

Yes.

## What does Blade do?

## How do I use Blade in my project?