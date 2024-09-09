Project Overview:

The Tourist Management System is a comprehensive application developed using C# and Oracle Database. It is designed to manage site reservations, user accounts, payments and reporting the tasks. This system uses different design patterns to make it strong and easy to 
maintain. It handles user management, site reservations, payment processing, and reporting the reservation tasks and it contains different User Interface for the Admin and User, differentiating the tasks both can perform.

System Architecture:

The system's architecture is made to be easy to manage, expand, and maintain, using these parts:

1. Presentation layer: User Interface using Windows Forms app in C#.
2. Business Logic Layer: It handles the core application logic including user management, reservations management, payment processing and exporting the reservation report using CSV.
3. Data Access Layer: Deals with working with the Oracle Database.
4. Design Patterns:

o Singleton Design Pattern: Used for Managing database connections.
o Observer design pattern: Used for notifying users about future available sites.
o Strategy design pattern: Used for implementing various payment modes.
