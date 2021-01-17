using Dojo_UnitTest_241120;
using NUnit.Framework;
using System;

namespace NUnitTest_Dojo241120
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestToCharAndUppercase()
        {
            //Transformer une string en tableau de caractères en majuscule

            //Chaîne en entré
            string entry = "abcde";
            char[] expected = new char[] { 'A', 'B', 'C', 'D', 'E' };

            var transformator = new Transformator { Strings = entry };
            char[] result = transformator.ToCharAndUppercase();

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestCalculateCircleSurface()
        {
            //Test de la méthode qui calcule l'aire d'un cercle à partir de son rayon

            int radius = 3;
            double expected = 28.27;

            var calculator = new Calculator();
            double result = calculator.CalculateCircleSurface(radius);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestAddCalculator()
        {
            Int32[] integers = new int[] { 1, 2, 3, 4, 5 };

            var add = new Add { ValueSet = integers };
            Int32[] resultingIntegers = add.AddCalculator();

            Int32[] expectedIntegers = { 1, 3, 6, 10, 15 };
            Assert.AreEqual(expectedIntegers, resultingIntegers);
        }
        [Test]
        public void TestFactorielles()
        {
            int valeur = 9;
            var calculatorFact = new CalculatorFact { integer = valeur };
            int resultat = calculatorFact.CalculateFactorielle();
            Assert.AreEqual(362880, resultat);
        }

        [Test]
        //Complete the solution so that it splits the string into pairs of two characters. 
        //If the string contains an odd number of characters then it should replace the missing 
        //second character of the final pair with an underscore ('_').
        public void TestSplitString()
        {
            string entry = "abcde";
            string entry2 = "abcd";
            string[] result_entry = { "ab", "cd", "e_" };
            string[] result_entry2 = { "ab", "cd" };

            var codewar = new Codewar();
            string[] resultat_expected = codewar.SplitString(entry);
            string[] resultat_expected2 = codewar.SplitString(entry2);

            Assert.AreEqual(result_entry, resultat_expected);
            Assert.AreEqual(result_entry2, resultat_expected2);
        }
    }
}