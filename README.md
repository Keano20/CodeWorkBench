# CodeWorkBench

**CodeWorkBench** is a modular C# practice environment built to demonstrate and strengthen core software engineering concepts. It serves as a structured lab for experimenting with algorithms, data structures, LINQ, and Object-Oriented Design patterns.

This project is designed with **Separation of Concerns** in mind, keeping logic decoupled from the main entry point to ensure clean, testable code.

## 🧠 Features & Modules
### Object-Oriented Design(OOP)
- **Inheritence & Abstraction:** Uses an abstract class SmartDevice to define common behaviors for all devices.
- **Interfaces:** Implements Ipowerable, IVolume, and IMotionDetection to demonstrate interface segregation and capability-based design.
- **Polymorphism:** A runtime demo that treats different devices (SmartSpeaker, SmartCamera) as their base type while executing specific behaviours.

## ▶️ Running the project
To build and run the project:
```bash
dotnet run
