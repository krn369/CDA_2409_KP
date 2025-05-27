# **📌 Point Class Exercise Summary**  

## **🎯 Objective**  
Implement a `Point` class in C# that represents a 2D point (x, y) with:  
- **Constructors** (default, custom, copy)  
- **Movement** and **coordinate swapping**  
- **Symmetry operations** (flip over X/Y axes and origin)  
- **Immutability** (methods return new `Point` objects)  

---

## **📝 Key Features**  

| Feature | Method | Example | Output |
|---------|--------|---------|--------|
| **Default Constructor** | `Point()` | `new Point()` | `(0, 0)` |
| **Custom Constructor** | `Point(x, y)` | `new Point(3, 4)` | `(3, 4)` |
| **Copy Constructor** | `Point(Point p)` | `new Point(p1)` | Copy of `p1` |
| **Move Point** | `Deplacer(newX, newY)` | `p1.Deplacer(1, 1)` | `(1, 1)` |
| **Swap Coordinates** | `Permuter()` | `p1.Permuter()` | `(y, x)` |
| **X-Axis Symmetry** | `SymetrieAxeAbscisse()` | `p1.SymetrieAxeAbscisse()` | `(x, -y)` |
| **Y-Axis Symmetry** | `SymetrieAxeOrdonnee()` | `p1.SymetrieAxeOrdonnee()` | `(-x, y)` |
| **Origin Symmetry** | `SymetrieOrigine()` | `p1.SymetrieOrigine()` | `(-x, -y)` |

---

## **💡 Key Concepts**  
- **DRY Principle**: Reused constructors and symmetry methods to avoid code duplication.  
- **Encapsulation**: Private fields (`x`, `y`) with public methods for safety.  
- **Immutability**: Symmetry methods return new `Point` objects instead of modifying the original.  

---
