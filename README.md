##  File Description

###  OODExamples.cs
Contains examples of:

**Encapsulation**

Protecting internal state using private fields.
Controlled access via public methods.


**Inheritance**

BaseShipment as parent class.
AirShipment and RoadShipment inheriting common behavior.


**Polymorphism**

Method overriding for shipment cost calculation.
Runtime method resolution via base reference.


---

###  PrinciplesExamples.cs

**KISS (Keep It Simple, Stupid)**

Simple shipping cost calculation.
Clear logic without over-engineering.


**DRY (Don't Repeat Yourself)**

Common validation/helper logic centralized.
Avoids duplicate code blocks.


---

###  SOLID Principles (Separate Files)

Each SOLID principle is isolated in its own file for clarity and focused review.

---

####  SRP.cs – Single Responsibility Principle
A class has only one responsibility.
Example separates invoice generation from invoice persistence.

---

####  OCP.cs – Open Closed Principle
Shipment cost calculation is open for extension but closed for modification.
New shipment types can be added without changing existing logic.

---

####  LSP.cs – Liskov Substitution Principle
Derived classes can replace base class without breaking behavior.

---

####  ISP.cs – Interface Segregation Principle
Small, focused interfaces.
Clients depend only on the methods they need.

---

####  DIP.cs – Dependency Inversion Principle
High-level modules depend on abstractions, not concrete implementations.

Example:

INotificationService
EmailNotification / SMSNotification


---

##  program.cs

Acts as the driver file:

Instantiates examples
Demonstrates runtime behavior
Keeps console output minimal and readable


---

##  Design Approach


Real-world inspired logistics domain
Concise and easy-to-review examples
Clear separation of responsibilities
No unnecessary complexity
Each principle demonstrated independently


---

##  Tech Stack


C#
.NET Console Application
Object-Oriented Programming


---

##  Estimated Review Time

Approximately 10–15 minutes.

---

##  Purpose

This assignment was created to strengthen practical understanding of:

OOD concepts
Clean code principles
SOLID architecture
Writing maintainable and extensible code


---

Author: Vedang Atre  
Project: Logistics – OOD & SOLID Assignment
