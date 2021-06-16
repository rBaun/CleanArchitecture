# CleanArchitecture
Example of [Uncle Bob's Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html "Uncle Bob's Clean Architecture") implemented in ASP.NET

The goal of this project is to create a demo with a CLEAN Architecture approach. 
The demo will include 4 different layer:

* Domain Layer
* Application Layer
* Infrastructure Layer
  * Infrastructure.IoC Layer
  * Infrastructure.Persistence Layer
* Presentation Layer

The purpose is to get a clear understanding of how to take the clean approach to writing code. This demo can be re-used to any project and 
can be adjusted to fit any requirements. This means that the CLEAN approach is not limited to the chosen layers, but can be complimented according to your needs.

## Domain Layer
The domain layer is the heart of the application, containing the core models. 
The Models should be [Persistence Ignorant](https://deviq.com/principles/persistence-ignorance), meaning that the modeling of the business domain should not influence how the objects are being stored. Furthermore, the Models should try to encapsulate logic as much as possible. 

## Application Layer
The Domain only the defines the models, where the Application Layer uses those models to form the application.
The Application Layer can include Interfaces, ViewModels/DTOs, Mappers, Exceptions, Validation, Logic or basically anything related to the application itself. 
But, keep in mind that CLEAN is all about pushing the details outwards, meaning that the application layer should contain just that. Application Details. In this layer we are not worried about databases, webservices, etc. However, the interfaces is defined in this layer, where the Infrastructure Layer may implement those details.

## Infrastructure Layer
The interfaces defined in the Application Layer will be implemented in this layer. This can be details about databases, web services, files, message bus, logging, configuration, etc. This layer is all about technical details, where the previous layer can somewhat be understood by business oriented people. 


## Presentation Layer
The Presentation Layer is what the end user is interacting with. This can be MVC Controllers, Web API Controllers, Swagger, Authentication, etc. 
In this demo there will be implemented MVC Controllers and Swagger.

## Testing Layer
The testing layer is used for tests. The primary focus should be on the Application Layer, since this is the core of the application. 
It could make sense to have tests for the rest aswell, especially if logic is also inside the Domain layer.
Since each layer is using interfaces, the testing should become relatively easy with mocking.
