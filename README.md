question 1
We created ASP.NET core mvc web application.
We made class that called calculator and interface that contain the "Add" method, the class use this interface.
In Startup we made the Dependency-Injection that if the controller constructor get the Calculator object it will create from the Startup.
In additional we added swagger to the project that will run the client when the project is running.
To test our controller you can run the project and use the swagger to check the api.

question 3
We created test project and added the project from question 1 to the references.
In the test project we added MOQ from nuget packages.
In the test method we created mock object of calculator class(fake object), then we made object of CalculatorController and passed it the "fake" object of calculator and did Assert.AreEqual to CalculatorResult API function.
The test succeed.