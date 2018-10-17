--Author: James Dix
--Date: 23 SEPT 2018
--Subject: ASP.NETHomework03

ASP.NET MVC Ch 03
1. The book states, “Interactions with an MVC application follow a natural cycle of user actions and view updates, where the view is assumed to be stateless.” What does it mean for the view to be stateless?
It doesn't have any memory of what went on in the past. Doesn't keep track of configuration, or data.

2. The book identifies two kinds of models. Briefly describe each of them.
View model renders the view, domain model

3. Give an example of separation of concerns from your own life experience. This should be a simple, everyday example.
Separation of concerns is the decoupling of the logic and controllers from the view. Delegates different functions to different entities.

4. What is a view engine?
View engines render the view for the user. Takes input and produces output

5. The book notes that the three-tier structure, or n-tier model, is “the most widely used pattern for business applications.” Why do you think that this is true?
Database on bottom, glue in middle, html on top. It didn't matter what language you used, because it all still produced html

6. This question requires some outside research. When we study UWP, you will see that the UWP design pattern is the Model-View-View-Model (MVVM). What is the difference between MVC and MVVM that makes the first good for ASP.NET MVC and the second good for UWP?
In UWP, it's stateful (uses memory), in MVC, it's stateless. MVVM has no controller. The model and the view communicate directly since each of them remembers the last interactions (has states).

With MVC you have to resend all information each time since there is no state.

7. Describe the two parts of the dependency injection (DI) design pattern.
The first part is to remove any dependencies on concrete classes from the component. The second part is to inject the dependency declared by the class. You create the instance of it

8. Give an example of loose coupling from your own life experience. This should be a simple, everyday example.
Loose coupling means you're not tied to any particular implementation.

9. What are the two types of testing discussed in the book?
 Unit testing and automated testing

10. What are the seven steps of the test driven development (TDD) workflow, as stated in the book?
-Determine you need new feature or method -Write the test that will validate the behavior -Run the test and get a red light -Write the code that implements the new feature -Run the test again and correct the code until you get a green light -Refactor the code if required -Run the test to confirm that your changes have not changed the behavior of your additions