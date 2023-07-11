SOLID
O => Open Closed Principle

The Open closed Principle states that "Software entities such as modules, classes, functions, etc." should be open for Extension, but closed for Modificaiton.

The Open for Extension means that we need to desing the software modules/classes/functions in such a way that new responsibilities or functionalities should be added easily when new requirements come.

Closed for modification means, we should not modify the class/module/function until we find some bugs.


Implementation Guidlelines for Open-Closed  Prinicple (OCP) using C#

1. The easiest way to implement the Open-Closed Principle in C# is to add new funcitonalities by creating new derived classes which should be inherited from the original base class.
2. Another way is to allow the client to access the original class with an abstract interface.


Problems of Not following the Open-Closed Principle in C#

1. If you allow a class or function to add new logic then as a developer you need to test the entire functionalities which include the old functionalities as well as new functionalities of the application.
2. As a Developer, it is also your responsibility to tell the QA(Quality Assurance) team about the changes in advance, so that they can prepare themselves in advance for regression testing along with the new feature testing.
3. If you are not following the Open-Closed Principle, then it also breaks the Single Responsibility Principle as the class or module is going to perform multiple responsibilities.
4. if you are implementing all the functionalities in a single class, then the maintenance of the class becomes very difficult.



As per the Open-Closed principle, Instead of MODIFYING, we should go for EXTENSION. If you want to follow the Open-Closed Principle in the above example, when a new invoice type needs to be added, then we need to add a new class. As a result, the current functionalities that are already implemented are going to be unchanged. The advantage is that we just only need to test and check the new classes.

Advantages
1. It wil reduce the error as we are not modifying existing classes.
2. It will allow us to add new functionalities by adding new classes where no current functionality depends on the new classes.
3. It will also make sure that Single Responsibility Principle is not violated.
4. It will also allow us to Unit test each class method very easily.
