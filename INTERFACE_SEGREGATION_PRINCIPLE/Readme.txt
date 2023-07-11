SOLID
I = > Interface Segregation Principle

The interface Segregation Principle states that "Clients should not be forced to implement any methods they don't use. Rather than one fat interface, numerous little interfaces are preferred based on groups of methods with each interface serving one submodule."

1. First, no class shuould be forced to implement any method(s) of an interface they don't use.
2. Secondly, instead of creating large or you say fat interfaces, create multiple smaller interfaces with the aim that the clients shuould only think about the 
methods that are interest to them.


As per the Single Responsibility Principle of SOLID, like classes, interfaces also should have a single responsibility.
That means we shouldn't force any class to implement any method(s) that they don't require.

