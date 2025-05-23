---

# 🚗 Car Simulation (`Voiture`, `Moteur`, `Roue`) - Overview

## 🚀 **Objective**

Create a simple simulation of a **Car system** using **Object-Oriented Programming (OOP)** principles in C#. This includes modeling a **Car** (`Voiture`), its **Engine** (`Moteur`), and **Wheels** (`Roue`).

---

## 🧩 **Components Overview**

### 🔧 `Roue` (Wheel) Class

Represents a single car wheel.

| Property / Method  | Description                                                             |
| ------------------ | ----------------------------------------------------------------------- |
| `Tourne` (bool)    | Indicates whether the wheel is spinning (read-only).                    |
| `Tourner()`        | Starts spinning the wheel if not already. Returns `true` if successful. |
| `ArreterTourner()` | Stops the wheel if spinning. Returns `true` if successful.              |
| Copy Constructor   | Allows deep copying of a wheel.                                         |
| `ToString()`       | Displays the wheel’s brand, size, and status.                           |

---

### ⚙️ `Moteur` (Engine) Class

Models the car’s engine.

| Property / Method           | Description                                                                 |
| --------------------------- | --------------------------------------------------------------------------- |
| `EstDemarre` (bool)         | Indicates if the engine is running (read-only).                             |
| `DemarrerMoteur()`          | Starts the engine.                                                          |
| `ArreterMoteur()`           | Stops the engine.                                                           |
| `Entrainer2RouesMotrices()` | Starts two wheels spinning if the engine is running and they’re stationary. |
| Copy Constructor            | Allows deep copying of an engine.                                           |
| `ToString()`                | Displays engine type and status.                                            |

---

### 🚙 `Voiture` (Car) Class

Represents a complete car with engine and wheels.

| Feature / Method         | Description                                                |
| ------------------------ | ---------------------------------------------------------- |
| Brand & Model            | Basic car identity.                                        |
| Four Wheels + Spare      | Each car has four main wheels and an optional spare wheel. |
| `Demarrer()`             | Starts the engine.                                         |
| `Avancer()`              | Moves the car forward by spinning all wheels.              |
| `Arreter()`              | Stops the engine and all wheels.                           |
| `AjouterRoueDeSecours()` | Adds a spare wheel if none exists.                         |
| Copy Constructor         | Deep copies the entire car.                                |
| `ToString()`             | Displays the car's full state (brand, engine, wheels).     |

---

## 🧪 **Test Cases in `Main()`**

| Test # | Description                                                                             |
| ------ | --------------------------------------------------------------------------------------- |
| 1      | Create and display a default `Voiture`.                                                 |
| 2      | Create and display a custom `Voiture`.                                                  |
| 3      | Copy an existing `Voiture`.                                                             |
| 4      | Test `Moteur` constructors and display them.                                            |
| 5      | Test `Roue` constructors and display them.                                              |
| 6      | Start the car, move it (spin wheels), and stop it. Display the state after each action. |
| 7      | Add a spare wheel and prevent adding duplicates.                                        |

---

## ⚠️ **Error Handling & Validation**

* Ensures wheel size is positive.
* Validates non-null parameters (e.g., brand names).
* Prevents wheels from spinning if already in motion.
* Avoids engine re-starts or stops when already in desired state.
* Handles nulls for spare wheels gracefully.

---

## 🎯 **Learning Goals**

✔ Practice **C# OOP** fundamentals: constructors, encapsulation, delegation.
✔ Implement and test **composite relationships** (Car → Engine + Wheels).
✔ Reinforce **state management** through method logic (e.g., start/stop/spin).
✔ Understand **copy constructors** for deep cloning of complex objects.
✔ Apply clean, testable code design with `ToString()` overrides.

---
