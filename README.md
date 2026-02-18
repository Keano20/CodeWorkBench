# CodeWorkBench

**CodeWorkBench** is a modular C# practice environment built to demonstrate and strengthen core software engineering concepts. It serves as a structured lab for experimenting with algorithms, data structures, LINQ, and Object-Oriented Design patterns.

This project is designed with **Separation of Concerns** in mind, keeping logic decoupled from the main entry point to ensure clean, testable code.

## 🧠 Features & Modules
### Object-Oriented Design(OOP)
- **Inheritence & Abstraction:** Uses an `abstract class SmartDevice` to define common behaviors for all devices.
- **Interfaces:** Implements `Ipowerable`, `IVolume`, and `IMotionDetection` to demonstrate interface segregation and capability-based design.
- **Polymorphism:** A runtime demo that treats different devices (`SmartSpeaker`, `SmartCamera`) as their base type while executing specific behaviours.

### LINQ (Language Intergrated Query)
Practical examples of functional Programming in C#:
- **Objects:** Filtering, sorting, and projecting data from a `List<Person>` (e.g., finding high earners, sorting by age).
- **Numbers:** Transformations (`Select`), filtering (`Where`), and grouping data sets.

### Sorting Algorithms
- **Bubble Sort:** A manual implementation of the sorting algorithm to demonstrate logic flow and array manipulation.
- **Iteration:** Logic for finding maximum values and efficient looping.

### Mathematics & Logic
- **Prime Numbers:** Logic to efficiently detect and list prime numbers.
- **Factors:** Algorithms to find factors and determine if a number is "Perfect".
---
## ▶️ How To Run The Project
**Ensure you have the .NET SDK installed**
1. Clone the repository:
   ```bash
   git clone [https://github.com/Keano20/CodeWorkBench.git](https://github.com/Keano20/CodeWorkBench.git)
   ```
   
2. Navigate to the project folder:
   ```bash
    cd CodeWorkBench
    ```
   
3. Run the project:
    ```bash
    dotnet run
      
