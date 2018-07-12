# Conference Management System Architecture Notes

This application is a console application that has an architecture inspiring by the following ones:

- [Onion Architecture](https://dzone.com/articles/onion-architecture-is-interesting)
- [Clean Architecture](https://8thlight.com/blog/uncle-bob/2012/08/13/the-clean-architecture.html)

Also, special consideration has been put forth to comply with the SOLID principles.

-[Solid Principles](https://rubygarage.org/blog/solid-principles-of-ood)

## Application Structure

The application structured follows from the following of the Clean Architecture design style, we have a folder for each main functionality that the app provides and inside it we have all the code structure that can leverage the uses cases for said functionality in an independent manner. In the main folder for the functionality we have common clases that are going to be used for the uses cases and we have a folder for each use case so that we can follow the Open Close principle and minimize the modification of existing functionality and add more as the business needs start to come in.

## Application architecture

Following the principles of Clean Architecture we have 3 layers that the application uses to present access to the use case scenarios of the business needs. These three layers are as follows.

Domain layer: Contain the definition of the domain objects that interact in the system. They provide the modeling and encapsulation of business rules specific to the domain of the functionality presented. In this layer we also have repository classes that permit the interaction of other layers to a collection like interface that exposes the persistent data of these domain objects that the application needs to function.

In this particular case we can see that we have an abstract class `TalksRepository` that exposes a method to get a list of talks available from the persistence storage. Using the facilities of polymorphism there are 2 implementations of this repository, one that provides data through an in memory collection and another one that provides data through the mapping of a txt file with the talks data.

Administrator: This layer contains application specific business rules that are needed to provide the functionality. In clean architecture this will be the use case object, the one that controls the domain entities to provide the use case as requested.

In this particular case, the use cases are exposed using the directory structure and namespacing as nomenclature and the implementation of the use case is done using the [Command pattern](https://en.wikipedia.org/wiki/Command_pattern). 

Theres an abstract class provided (Administrator) that can be used to provide multiple implementations of the use case. This allows us to comply with the Single Responsability Principle, the Open Closed principle, the Liskov substitution principle (As long as the clients for the administrator import this abstract class), the Interface segregation principle and the dependency inversion principle. A reference implementation is provided for this example.

Console Interface: As we go up the chains of dependencies, there's more detail in the design of the system. A console interface abstract class is provided so that multiple implementations of the logic to present the use case through the command line can be programmed and chosen at runtime by the system. The same principles of the administrator class follow, command pattern and SOLID, and it's basically a Facade pattern to present information to the end user of the application. A reference implementation is provided for this example.

Program: This is the main function that is executed when we run the program. As this is the topmost layer, the details are really specific. This provides a way to pass parameters from a terminal to the command line interface. In this layer there's wiring of the dependencies for the rest of the layers, using the constructor method of dependency injection implemented manually and parsing of the arguments from the terminal to the command line interface.

# Test Architecture

The same principles are followed for the design of the tests, that for the code. The application structure is roughly the same, but there are some other concepts.

In the tests we have to kind of files, an abstract specification class, and a concrete tests class for the classes that reside in the source code.

The abstract specification is userd to expose the different functionalities expected of each class using a BDD inspired natural language.

The concrete test classes implement these specifications so that we can guarantee that every test class of an implementation, complies with the same set of specifications and we can have that documentation available throughout the lifetime of the project.

# Final Notes

The use of abstract classes instead of interfaces is done as a requirement from the designer so that implementors aren't able to combine diferent use cases into a single implementation class. Interfaces have a place when modeling specific behaviour, something that wasn't required for this project in the mind of the original designer.
