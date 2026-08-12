# Smart Delivery Management System

A C# Console Application built as a practical OOP learning project across **OOP Assignments 01, 02, and 03**.

The project starts with a simple shipment-management design and gradually evolves into a more structured object-oriented delivery system using **Structs, Classes, Encapsulation, Constructors, Indexers, Inheritance, Polymorphism, Method Overloading, Method Overriding, Binding, Static Classes, and Sealed Classes/Methods**.

---

## Project Overview

The system represents a small delivery center that manages different kinds of shipments.

The main idea is:

```text
DeliveryCenter
     |
     |---- StandardShipment
     |---- ExpressShipment
     |---- InternationalShipment
     |
     |---- Driver
```

Each shipment contains common delivery information such as:

- Tracking code
- Description
- Weight
- Delivery fee
- Delivery address
- Estimated cost

Different shipment types then extend the base `Shipment` class and add their own behavior.

---

## Learning Journey

This repository contains the progression of three OOP assignments in one project.

### Assignment 01 — Building the Foundation

The first assignment introduced the basic data model and focused on:

- `struct`
- Value Types vs Reference Types
- Encapsulation
- Fields and Properties
- Property validation
- Constructors
- Constructor overloading
- Methods
- `DeliveryAddress`
- `Shipment`
- `DeliveryCenter`
- Indexers
- Adding and removing shipments
- Searching shipments by tracking code
- Printing shipment information

The original design used `Shipment` and `DeliveryCenter` as structs.

The project also included practical demonstrations of how copying a struct differs from copying a class reference.

---

### Assignment 02 — Moving to Classes and Inheritance

The second assignment redesigned the system around classes.

The main `Shipment` class became the base class for different shipment types:

```text
                 Shipment
                    |
        +-----------+-----------+
        |           |           |
        v           v           v
 Standard      Express      International
 Shipment      Shipment       Shipment
```

This assignment introduced:

- Classes vs Structs
- Reference Types
- Inheritance
- Base and Derived Classes
- Constructor chaining using `base(...)`
- Method overriding
- Virtual members
- Specialized shipment behavior
- `RemoveShipment()`
- `PrintAllShipments()`

Three shipment types were introduced:

### StandardShipment

Represents a normal shipment.

Its estimated cost is calculated from:

```text
Delivery Fee + (Weight × 5)
```

### ExpressShipment

Represents an express shipment.

It adds:

```text
ExtraFee
```

to the estimated cost.

### InternationalShipment

Represents an international shipment.

It adds:

```text
DestinationCountry
CustomsFee
```

to the shipment data and cost calculation.

---

## Assignment 03 — Polymorphism and Advanced OOP

The third assignment builds on the previous design and focuses on runtime behavior and class relationships.

The project now demonstrates:

### Method Overloading

`Shipment` contains two versions of the weight-update method:

```csharp
weightupdate(decimal newWeight)
```

and:

```csharp
weightupdate(decimal newWeight, decimal packingWeight)
```

The method selected depends on the number of arguments supplied.

Example:

```csharp
Standard.weightupdate(5);
```

or:

```csharp
Standard.weightupdate(5, 0.5m);
```

---

### Method Overriding

The base class defines virtual behavior:

```csharp
public virtual void PrintShipment()
```

Derived classes can provide their own implementation:

```csharp
public override void PrintShipment()
```

This allows each shipment type to print its own details.

---

### Polymorphism

The project can treat different shipment types as their common base type:

```csharp
Shipment[] shipments =
{
    Standard,
    Express,
    International
};
```

The array is declared as `Shipment[]`, while the actual objects are different derived classes.

This demonstrates one of the main benefits of polymorphism: different objects can be handled through the same base type.

---

### Dynamic Binding

The following code:

```csharp
foreach (Shipment shipment in shipments)
{
    shipment.PrintShipment();
}
```

calls the appropriate overridden method according to the object's real runtime type.

Conceptually:

```text
shipment -> StandardShipment
              |
              +--> Standard PrintShipment()

shipment -> ExpressShipment
              |
              +--> Express PrintShipment()

shipment -> InternationalShipment
              |
              +--> International PrintShipment()
```

---

## DeliveryHelper

The project contains a static helper class:

```csharp
internal static class DeliveryHelper
{
    public static void PrintShipmentDetails(Shipment shipment)
    {
        shipment.PrintShipment();
    }
}
```

It provides a simple common entry point for printing shipment details.

Usage:

```csharp
DeliveryHelper.PrintShipmentDetails(Standard);
DeliveryHelper.PrintShipmentDetails(Express);
DeliveryHelper.PrintShipmentDetails(International);
```

Because the parameter type is `Shipment`, the call also demonstrates polymorphic behavior.

---

## Driver and DeliveryCenter Relationship

The delivery center can have a driver assigned to it.

Example:

```csharp
Driver driver = new Driver(1, fullName, "0123456789");

Center.Driver = driver;
```

The `DeliveryCenter` also manages its shipment collection through:

```csharp
AddShipment()
RemoveShipment()
PrintAllShipments()
```

The center therefore acts as the main manager of the shipments in the system.

---

## Indexers

`DeliveryCenter` provides two indexers.

### Index by integer

```csharp
Center[0]
```

This allows access to a shipment by its position in the internal array.

### Index by tracking code

```csharp
Center["A1001"]
```

This allows searching for a shipment using its tracking code.

This was one of the important practical concepts introduced during Assignment 01.

---

## Sealed Class

The project contains:

```csharp
internal sealed class CompletedShipmen : Shipment
{
}
```

A sealed class cannot be inherited from.

Conceptually:

```text
Shipment
   |
   v
CompletedShipmen
   X
   |
   +-- Cannot be inherited
```

This demonstrates how a class can intentionally stop further inheritance.

---

## Sealed Method

The project also demonstrates a sealed override through:

```text
InternationalShipment
        |
        | virtual GenerateCustomsReport()
        v
PriorityInternationalShipment
        |
        | sealed override
        v
   No further override
```

The implementation is:

```csharp
public sealed override void GenerateCustomsReport()
{
    Console.WriteLine("التقارير النهائية");
    Console.WriteLine("ممنوع حد يعمل override للميثود دي تاني ويغير فيها");
}
```

The `sealed` keyword here does **not** stop inheritance from the class itself.

It only prevents further overriding of that specific method.

---

## Main Application Flow

The final `Program.cs` demonstrates the complete flow:

```text
1. Create DeliveryCenter
        |
2. Enter Center Name
        |
3. Create Driver
        |
4. Assign Driver to Center
        |
5. Create Standard Shipment
        |
6. Create Express Shipment
        |
7. Create International Shipment
        |
8. Add shipments to DeliveryCenter
        |
9. Print shipment details using DeliveryHelper
        |
10. Update shipment weight
        |
11. Demonstrate overloaded UpdateWeight methods
        |
12. Print all shipments from DeliveryCenter
        |
13. Put mixed shipment types in Shipment[]
        |
14. Iterate using foreach
        |
15. Demonstrate polymorphism / dynamic binding
```

---

## Project Structure

```text
OOP Assignment/
│
├── OOP Assignment/
│   ├── Program.cs
│   ├── Shipment.cs
│   ├── DeliveryAddress.cs
│   ├── DeliveryCenter.cs
│   ├── Driver.cs
│   ├── DeliveryHelper.cs
│   ├── StandardShipment.cs
│   ├── ExpressShipment.cs
│   ├── InternationalShipment.cs
│   ├── PriorityInternationalShipment.cs
│   ├── CompletedShipmen.cs
│   ├── Customer.cs
│   └── Assignment 01 OOP.csproj
│
└── .git/
```

### Main Classes

| Class | Responsibility |
|---|---|
| `Shipment` | Base shipment model and common behavior |
| `StandardShipment` | Standard shipment type |
| `ExpressShipment` | Express shipment with extra fee |
| `InternationalShipment` | International shipment with customs data |
| `PriorityInternationalShipment` | Priority international shipment demonstrating sealed overriding |
| `DeliveryAddress` | Stores city, street, and building number |
| `DeliveryCenter` | Manages shipments and assigned driver |
| `Driver` | Represents the delivery driver |
| `DeliveryHelper` | Static helper for printing shipment details |
| `CompletedShipmen` | Sealed shipment class |

---

## OOP Concepts Demonstrated

This project covers a wide range of C# OOP concepts:

- Structs
- Classes
- Value Types
- Reference Types
- Fields
- Properties
- Encapsulation
- Validation
- Constructors
- Constructor Overloading
- Constructor Chaining
- Methods
- Method Overloading
- Method Overriding
- `virtual`
- `override`
- `sealed`
- Inheritance
- Polymorphism
- Dynamic Binding
- Static Classes
- Indexers
- Arrays
- Base and Derived Classes
- Composition / Object Relationships
- Access Modifiers

---

## Technologies

- **C#**
- **.NET 10**
- **Console Application**
- **Visual Studio**
- **Git**
- **GitHub**

The project targets:

```xml
<TargetFramework>net10.0</TargetFramework>
```

---

## How to Run

### 1. Clone the repository

```bash
git clone <YOUR-GITHUB-REPOSITORY-URL>
```

### 2. Open the solution/project

Open the project in Visual Studio.

### 3. Build the project

Use:

```text
Build → Build Solution
```

### 4. Run

Press:

```text
Ctrl + F5
```

or:

```text
F5
```

The console application will guide the user through entering:

- Delivery center information
- Driver information
- Standard shipment information
- Express shipment information
- International shipment information

---

## Git Commit History

The repository was developed incrementally rather than being written as one large implementation.

The commit history reflects the progression of the assignments and individual requirements.

Examples include:

```text
ASSIGNMENT 03
Q1 Overloading, Overriding, and Binding
Q2 Sealed Classes and Methods
Method Overloading
Q05 & Q06 Class Relationships & Update DeliveryCenter
Q07 Create DeliveryHelper
Q08 Sealed Class
Q09 Sealed Method
Q10 Main() Checklist
```

Earlier commits also show the development of:

```text
Shipment struct
DeliveryCenter struct
RemoveShipment()
PrintAllShipments()
StandardShipment
ExpressShipment
InternationalShipment
```

This makes the repository useful not only as a final solution, but also as a record of the OOP learning progression.

---

## Design Progression

The most important part of this project is the way the design evolved.

### Stage 1

```text
Struct-based design
```

The focus was on understanding:

```text
Value Types
Properties
Validation
Constructors
Indexers
```

### Stage 2

```text
Class-based design
```

The project moved toward:

```text
Shipment
   |
   +-- StandardShipment
   +-- ExpressShipment
   +-- InternationalShipment
```

The focus became:

```text
Reference Types
Inheritance
Constructor Chaining
Virtual / Override
```

### Stage 3

```text
Polymorphic design
```

The project added:

```text
Overloading
Overriding
Dynamic Binding
Static Helper
Sealed Class
Sealed Method
Mixed-type collections
```

This progression demonstrates how the same delivery system can be gradually improved as more OOP concepts are introduced.

---

## Example Polymorphism

A key example in the project is:

```csharp
Shipment[] shipments =
{
    Standard,
    Express,
    International
};

foreach (Shipment shipment in shipments)
{
    shipment.PrintShipment();
}
```

One array handles multiple shipment types.

The caller does not need to write:

```csharp
if (shipment is StandardShipment)
```

or:

```csharp
if (shipment is ExpressShipment)
```

Instead, the overridden method is selected automatically at runtime.

---

## Project Goal

The goal of this project is not to build a production-ready delivery platform.

It is an educational implementation designed to demonstrate how a real-world problem can be modeled using C# OOP concepts.

The project intentionally evolves over multiple assignments so that each new concept can be applied to an existing system instead of being learned in isolation.

---

## Author

**Soliman**

C# / .NET Backend Learning Project

Built as part of an OOP learning track.

---

## Status

**Completed OOP Assignments 01, 02, and 03**

The repository currently represents the combined implementation developed throughout the three assignments.
