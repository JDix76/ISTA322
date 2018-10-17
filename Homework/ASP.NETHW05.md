--Author: James Dix
--Date: 30 SEPT 2018
--Subject: ASP.NETHomework05

ASP.NET MVC Ch 05
1. What is a view engine?
Processes ASP.NET content and looks for instructions typically to insert dynamic content into the output sent to a browser

2. What is Razor?
Razor is the name of the MVC framework view engine

3. What do views do? List two specific things in your answer to this question.
Accept input and display output

4. How does Razor respond when it encounters statements that begin with the at character (@)? Be specific.
The at character signifies transition to a code block of C# It declares type of model object that passes from to view from action model

5. How does Razor respond when it encounters statements that begin with the at character followed by the colon (@:)? Be specific.
Allows you to write html in C#

6. Describe how you implement a standard formatting for all pages in an ASP.NET application.
Create a layout template that contains code that you can use across your app

7. What is the difference in using Razor to interpolate data values as stand-alone HTML elements and as attributes to HTML elements. What is the similarity?
It detracts from the pattern of MVC

8. What is a view start file and where is it located?
_ViewStart.cshtml is located in the views folder

9. What is a Razor code block? What is the syntax of a Razor code block?
@ { }, located in the view

10. Describe the different roles of action methods and views.
The action method passes the myProduct object to the view method Action methods pass a view model object to the view, but doesn't pass formatted data to the view Views use the view model object to present content to the user but doesn't change any aspect of the view model object

11. Describe the use of the @using statement. Give an example of how you would use it.
import the razor.models namespace.

@using razor.models @model product []