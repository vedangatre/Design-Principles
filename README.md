##  File Description

###  OODExamples.cs
Contains examples of:

**Encapsulation**

Controlled access via public methods.


**Inheritance**

BaseShipment as parent class.
AirShipment and RoadShipment inheriting common behavior.


**Polymorphism**

Method overriding & overloading for shipment cost calculation.


---

###  PrinciplesExamples.cs

**KISS (Keep It Simple, Stupid)**

Simple delivery estimate calculation.
Clear logic without over-engineering.


**DRY (Don't Repeat Yourself)**

Reused common method to avoid duplicate code blocks.


---

###  SOLID Principles (Separate Files)

Each SOLID principle is isolated in its own file for clarity.

---

####  SRP.cs – Single Responsibility Principle
A class has only one responsibility.
Example separates Driver class from salary calculations.

---

####  OCP.cs – Open Closed Principle
Payment class is open for extension but closed for modification.
New payment types can be added without changing existing logic.

---

####  LSP.cs – Liskov Substitution Principle
Derived classes can replace base class without breaking behavior.

---

####  ISP.cs – Interface Segregation Principle
Small, focused interfaces.
Make each class depend only on the methods they need.

---

####  DIP.cs – Dependency Inversion Principle
High-level modules depend on abstractions, not concrete implementations.

---

##  program.cs

Acts as the driver file

