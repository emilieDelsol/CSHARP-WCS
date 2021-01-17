# Dojo Electronics TDD

Durant ce dojo, vous allez vous amuser en simulant des composants électroniques se branchant entre eux. Il ne ***faut pas modifier les tests***.

## Composition

[Le design pattern **Composite**](https://refactoring.guru/design-patterns/composite) est utilisé afin de tracer le branchement des composants.

## Etapes

### Switch

Commencez par l'implémentation de la classe **Switch**. Il s'agit d'un interrupteur. Ainsi, il laisse passer le courant lorsque qu'il est fermé, et ne laisse pas passer le courant lorsqu'il est ouvert.

### Resistor

Il s'agit d'une résistance. Afin de calculer l'intensité et la tension de sortie, il faut utiliser la loi d'Ohm.