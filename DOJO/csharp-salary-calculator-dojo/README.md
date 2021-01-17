# Salary Calculator TDD Dojo

Durant ce dojo vous devrez réaliser un calculateur de salaire se basant sur le **taux horaire** en dollar des salariés d'une entreprise.

La visibilité des attributs des classes du projet `SalaryCalculator` ne doit pas être modifiée.

## Etape 1

Réalisez l'implémentation de la classe `SalaryCalculator.Employee` à partir des tests.

Cette classe permet de calculer les salaires mensuels, journaliers et annuels d'un employé.

**Uniquement** l'implémentation des accesseurs (*get { }*) des propriétés `WeeklySalary` et `DailySalary` ont besoin d'être modifiées pour que les tests fonctionnent.

## Etape 2

Réalisez l'implémentation de la classe `SalaryCalculator.Company` à partir des tests

Cette classe permet de faire la somme des salaires des employés d'une entreprise.

*Conseil*: servez-vous de LINQ !

## BONUS

Recommencez en remplaçant tous les `throw new NotImplementedException();` par une et ***une seule*** ligne de code. Tous les tests originels présents dans le projet `SalaryCalculatorTest` doivent passer verts à la fin !

*Conseil*: servez-vous de LINQ !

### Règles de calcul des salaires

Il y a 7 jours dans une semaine, 4 semaines dans un mois et 12 mois par année. 