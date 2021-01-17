# Dojo Electronics TDD

Durant ce dojo, vous allez vous amuser en simulant des composants �lectroniques se branchant entre eux. Il ne ***faut pas modifier les tests***.

## Composition

[Le design pattern **Composite**](https://refactoring.guru/design-patterns/composite) est utilis� afin de tracer le branchement des composants.

## Etapes

### Switch

Commencez par l'impl�mentation de la classe **Switch**. Il s'agit d'un interrupteur. Ainsi, il laisse passer le courant lorsque qu'il est ferm�, et ne laisse pas passer le courant lorsqu'il est ouvert.

### Resistor

Il s'agit d'une r�sistance. Afin de calculer l'intensit� et la tension de sortie, il faut utiliser la loi d'Ohm.