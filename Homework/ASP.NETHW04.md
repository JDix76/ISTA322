--Author: James Dix
--Date: 23 Sept 2018
--Subject: ASP.NETHomework04


1. Using automatic properties is a shortcut that avoids several explicit steps. List the steps that the use of automatic properties avoids.
You don't need to explicitly define the properties

2. Using the object initializer syntax is a shortcut that avoids several explicit steps. List the steps that the use of object initializers avoids.
3. What is the purpose of creating extension methods?
To extend the functionality of methods without rewriting them

4. What is the one feature of extension methods that will always allow you to identify a method as an extension method?
The this keyword marks it as extension

5. How do you create an extension method that filters the results returned by the method on a user specified criterion?
The yield keyword

6. Explain the syntax of a lambda expression. The term “lambda expression” originates in the lambda calculus developed by the mathematician Alonzo Church in the 1930’s. There is a class of programming languages that are based on the fundamental ideas of lambda calculus.
The lambda operator is used in lambda expressions to separate the input variables on the left side from the lambda body on the right side. Lambda expressions are inline expressions similar to anonymous methods but more flexible; they are used extensively in LINQ queries that are expressed in method syntax.

7. This will require some outside research. What is the distinction between an anonymously typed variable and a dynamically typed variable?
anonymously typed variables have no name, C# allows you to create an object with the new keyword without defining its class, while dynamically typed variables tell the compiler that a variable's type can change or that it is not known until runtime. Think of it as being able to interact with an Object without having to cast it.

8. You are having a discussion about C# with a friend of yours that uses another language. You are telling him about C#’s LINQ library. How would you describe to him the difference between LINQ’s SQL-like notation and LINQ’s dot notation?
LINQ is a SQL-like syntax for querying data in classes. You use the lambda syntax

9. What, exactly, does the await keyword do?
The await operator is applied to a task in an asynchronous method to suspend the execution of the method until the awaited task completes. The task represents ongoing work. The asynchronous method in which await is used must be modified by the async keyword.

10. What is the connection between await and the async keywords?
If you specify that a method is an async method by using an Async or async modifier, you enable the following two capabilities.

The marked async method can use Await or await to designate suspension points. The await operator tells the compiler that the async method can't continue past that point until the awaited asynchronous process is complete. In the meantime, control returns to the caller of the async method.

The suspension of an async method at an await expression doesn't constitute an exit from the method, and finally blocks don’t run.

The marked async method can itself be awaited by methods that call it.