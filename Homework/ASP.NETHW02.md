--AUTHOR: JAMES DIX	
--DATE: 23 SEPT 2018
--SUBJECT:ASP.NET-HOMEWORK02

1. Describe what a controller does in the MVC design pattern.
The controller is responsible for responding to user input and perform interactions on data model objects. The controller receives input and passes it to the model

2. What is the ASP.NET MVC convention in naming controllers? What does HomeController.cs do?
Each controller should be plural or singular depending on whether they interact with single or multiple entities. This is displayed in the URL. HomeController.cs controls the functionality of the home page

3. What is the name of the routing configuration file? Where is it located?
Routconfig.cs locateed in App_Start

4. What is Razor? How does Razor treat an expression beginning with the at symbol (@)?
Razor is a programming syntax used to create web pages with .NET programming languages. Razor starts code blocks with @ (signaling the transition from HTML to C# Razor is an engine which converts C# to html

5. How do View methods work?
They create a view object that renders a view to the response (browser)

6. What is the purpose of MVC models?
Models are the guts of an application. They are the methods, classes, and objects that receive input from the controller and view

7. What is a strongly typed view and why do we use strongly typed views?
Strongly typed views are views intended to render a specific domain type. Strongly typing a view causes MVC to create shortcuts to make it easier

8. What is the purpose of setting a start page URL?
A start URL sets the default page of your website

9. Describe the differences between HTTP GET and HTTP POST.
Get requests are what a browser issues when someone clicks a link. HTTP POST methods are responsible for receiving submitted data and deciding what to do with it.

10. Describe the two approaches to validation in web applications.
Validation ensures information users enter are relevant to the information the model can work with. Validation is typically applied in the domain model. Validation is also supported with declarative validation rules.

11. What is the role of Cascading Style Sheets (CSS) in web development?
CSS add style such as font, colors, and spacing to web documents