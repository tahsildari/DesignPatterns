## DesignPatterns
I am practicing Design Patterns. This is not a bible of Design Patterns, so you may (and will) see differences as well. This is only my take.<br/>
Design Patterns are categorized in 3 general categories: Creational, Structural, and Behavorial.

<hr>

# 1. Creational
## 1.1. Factory Method
Instead of creating objects everywhere, we put the instantiation logic into a class called Factory. This gives us reusability. <br/>
For example if creation of a class's object requires some parameters and configs, we do them once and reuse it everywhere.

## 1.2. Abstract Factory
Useful for producing families of related objects without specifying their concrete classes. <br/>
Since we don't want to mdoify the existing concrete classes, we create Facotries who know their concrete classes and create a set of objects that belong to the same group.

### Example:
Furniture = Table + Sofa.<br/>
Factories: Wood furniture, Steel furniture.<br/>
Concrete classes: Wood Table, Wood Sofa, Steel Table, Steel Sofa.

## 1.3. Builder
Build object step by step. If your class's constrcutor has many parameters or your client code is doing a lot to create the object, then you need builders. <br/>
Each builder knows how to create and configure the object, and you just ask them to do it for you, with a simple call.

# Structural

# Behavioral
