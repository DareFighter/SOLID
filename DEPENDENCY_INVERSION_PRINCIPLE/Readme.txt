SOLID
D => Dependency Inversion Principle

The Dependency Inversion Principle(DIP) states that High-Level Modules/Classes should not depend on Low-level Modules/Classes. Both should depend upon Abstractions. Secondly, Abstractions should not depend upon Details. Details should depend upong abstractions.

The most important point that you need to remember while developing real time applications is always to try to keep the High-level module and Low-level module as loosely couples as possible.



Advantages of using the Dependency Inversion Principle in C#

Now, the EmployeeBusineesLogic and EmployeeDataAccessLogic classes are loosely coupled classes because EmployeeBusinessLogic does not depend on the concrete EmployeeDataAccessLogic class, instead, it includes a reference of the IEmployeeDataAccessLogic interface. So now, we can easily use another class that implements IEmployeeDataAccessLogic with a different implementation and for that, we don't need to do any changes to the EmployeeBusinessLogic class.
