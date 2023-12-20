<h1>Automated QA Engineer Project</h1>

<h2>Overview</h2>
This repository contains the automated testing framework for a ASP.NET Core web application. The purpose of this framework is to assess and automate the testing of critical functionalities within the Partner Portal. The testing is done using Gherkin scenarios, C# programming language, and the Selenium and Specflow frameworks.

<h3>1. Testing Frameworks and Tools</h3>
Selenium with C#: Selenium is chosen for its widespread use in web automation, and C# is selected for its object-oriented nature, especially suitable for ASP.NET Core applications.

SpecFlow: A Behavior-Driven Development (BDD) framework for .NET that integrates seamlessly with the Gherkin language.

<h3>2. Project Structure and Architecture</h3>
The project is organized into folders for features, step definitions, and utility classes, ensuring a clean and maintainable structure.

<h3>3. Requirements</h3>
3.1 Identify Critical Functionalities and Create Test Cases:

```
Feature: Login

@Smoke
Scenario: User shall be able to submit the login form with the correct credentials
  Given the login page is displayed
  And the correct user "****" is entered into the username field
  And the correct password "****" is entered into the password field
  When the user invokes the login action
  Then the login is logged in successfully

Scenario: User cannot submit the login form with the wrong credentials
  Given the login page is displayed
  And the user "user" is entered into the username field
  And the password "password" is entered into the password field
  When the user invokes the login action
  Then the message "Invalid username or password" is displayed
```

```
Feature: Order

Scenario: Submitting an order successfully
  Given the login page is displayed
  When the user navigates to the order submission page
  And they fill in the required order details
  And they submit the order
  Then they should see a success message
  And the order should be visible in the order history

Scenario: Looking up the status of a submitted order
  Given the login page is displayed
  When the user navigates to the order status lookup page
  And they enter the order ID
  Then they should see the current status of the order
  And relevant details about the order should be displayed
```

```
Feature: Order Validation

Scenario: Submitting an order with invalid details
  Given the login page is displayed
  When the user navigates to the order submission page
  And they provide incomplete or incorrect order details
  And they submit the order
  Then they should see error messages indicating the validation issues
  And the order should not be processed or stored in the system
```

```
Feature: Change Request Submission

Scenario: Submitting a change request successfully
  Given the login page is displayed
  When the user navigates to the change request submission page
  And they select the order for which they want to request a change
  And they fill in the required details for the change request
  And they submit the change request
  Then they should see a success message
  And the change request should be associated with the original order
```

<h3>4. Write Automation</h3>

* Page Object Model: Implementation initiated to enhance modularity, creating separate classes for each page, making tests more modular and maintainable.

* SpecFlow Steps: Clear SpecFlow step definitions well-organized for potential future extraction into reusable step methods or creating step bindings with parameters.

* Selenium: Widely used for automating web browsers, especially popular for web testing. Utilized for WebDriver Initialization in DI Container, Dependency Injection, Page Object Pattern, Hooks for WebDriver Initialization and Cleanup.

* BDD: Agile software development approach incorporated by implementing Feature Files, Gherkin, Step Definitions, and Hooks.

<h3>5. Set Up Test Environment</h3>

* Install Visual Studio
* Set Up Selenium:
* Install ChromeDriver, a separate executable used by Selenium WebDriver to control Chrome: ChromeDriver Downloads.
* Configure startup with ChromeDriver.
* Include PATH environment variable.
* WebDriver Setup.

<h3>6. Install Dependencies and Packages</h3>

```
dotnet add package SpecFlow
dotnet add package SpecFlow.Tools.MsBuild.Generation
dotnet add package SpecFlow.NUnit
dotnet add package SpecFlow.Actions.Selenium
dotnet add package Selenium.WebDriver
dotnet add package Selenium.Chrome.WebDriver
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Nunit.ConsoleRunner
dotnet add package FluentAssertions
dotnet add package SeleniumExtras.WaitHelpers
dotnet add package Microsoft.Extensions.DependencyInjection
dotnet add package NLog
dotnet add package Microsoft.Net.Test.sdk
```
