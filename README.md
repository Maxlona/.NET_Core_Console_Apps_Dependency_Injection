# Configure IServiceCollection for .NET Core Console Apps using Microsoft.Extensions.*

This repository demonstrates how to implement **Dependency Injection (DI)** in a **.NET Core Console Application** using `IServiceCollection` and `Microsoft.Extensions.*` libraries. The goal is to create a maintainable and testable architecture in console applications by utilizing DI and middleware-like patterns.

## Key Features

- **Dependency Injection (DI)** setup with `IServiceCollection` to manage application services.
- Integration of **logging** with `ILogger` for runtime logging.
- Implementation of a **middleware-like pattern** for chaining service invocations.
- Simple and extensible architecture suitable for console applications.

## Requirements

- [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet) or later.
- Any IDE or text editor (e.g., **Visual Studio**, **Visual Studio Code**, **JetBrains Rider**).
- Command-line interface (CLI) tools (optional).

## Getting Started

### Clone the Repository

To get started, clone the repository to your local machine:

git clone https://github.com/Maxlona/.NET_Core_Console_Apps_Dependency_Injection.git
cd .NET_Core_Console_Apps_Dependency_Injection


## Project Structure

### Program.cs
The main logic for Dependency Injection (DI) is configured in Program.cs. This file:

### Registers services (e.g., IMyService, IAnotherService) using IServiceCollection so that they can be injected throughout the application.
Sets up logging using AddLogging() to allow for detailed logging in services.
Resolves services from the DI container and invokes them in a predefined order.
Example Services

### IMyService and MyService:
A simple service that contains a method Execute() which logs a message to the console.

### IAnotherService and AnotherService:
A service that depends on IMyService and calls MyService.Execute() within its own Run() method.
