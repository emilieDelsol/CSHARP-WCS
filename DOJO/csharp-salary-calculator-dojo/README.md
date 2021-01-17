# Salary Calculator TDD Dojo

Durant ce dojo vous devrez r�aliser un calculateur de salaire se basant sur le **taux horaire** en dollar des salari�s d'une entreprise.

La visibilit� des attributs des classes du projet `SalaryCalculator` ne doit pas �tre modifi�e.

## Etape 1

R�alisez l'impl�mentation de la classe `SalaryCalculator.Employee` � partir des tests.

Cette classe permet de calculer les salaires mensuels, journaliers et annuels d'un employ�.

**Uniquement** l'impl�mentation des accesseurs (*get { }*) des propri�t�s `WeeklySalary` et `DailySalary` ont besoin d'�tre modifi�es pour que les tests fonctionnent.

## Etape 2

R�alisez l'impl�mentation de la classe `SalaryCalculator.Company` � partir des tests

Cette classe permet de faire la somme des salaires des employ�s d'une entreprise.

*Conseil*: servez-vous de LINQ !

## BONUS

Recommencez en rempla�ant tous les `throw new NotImplementedException();` par une et ***une seule*** ligne de code. Tous les tests originels pr�sents dans le projet `SalaryCalculatorTest` doivent passer verts � la fin !

*Conseil*: servez-vous de LINQ !

### R�gles de calcul des salaires

Il y a 7 jours dans une semaine, 4 semaines dans un mois et 12 mois par ann�e. 