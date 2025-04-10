# UML Diagram for MiniGame

```mermaid
---
title: Program MiniGame
---

classDiagram
    class Enemy { }

    class Player { }

    class Character {
        +Name
        #Weapon[]
    }

    class Sword {
    +float BladeLength
    +AttackWithSword()
    }

    class Gun {
    +int Ammo
    +FireGun()
    }

    