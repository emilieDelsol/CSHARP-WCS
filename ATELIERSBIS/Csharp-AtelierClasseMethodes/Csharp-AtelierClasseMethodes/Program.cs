using System;
using System.Collections.Generic;

namespace Csharp_AtelierClasseMethodes
{
    class Program
    {
        static void Main(string[] args)
        {

            Eleve eleve1 = new Eleve();
            eleve1.name = "Emilie";
            eleve1.notes=new int[] { 10, 12, 14 };

            Eleve eleve2 = new Eleve();
            eleve2.name = "Colas";
            eleve2.notes = new int[] { 12, 12, 14 };

            Eleve eleve3 = new Eleve();
            eleve3.name = "Adrien";
            eleve3.notes = new int[] { 14, 16, 14 };

            Eleve eleve4 = new Eleve();
            eleve4.name = "Fabien";
            eleve4.notes = new int[] { 12, 12, 14 };

            Eleve eleve5 = new Eleve();
            eleve5.name = "Mailys";
            eleve5.notes = new int[] { 12, 12, 14 };

            Eleve eleve6 = new Eleve();
            eleve6.name = "François";
            eleve6.notes = new int[] { 12, 12, 14 };

            Eleve eleve7 = new Eleve();
            eleve7.name = "Gabriel";
            eleve7.notes = new int[] { 12, 18, 14 };

            Eleve eleve8 = new Eleve();
            eleve8.name = "Sophie";
            eleve8.notes = new int[] { 20, 12, 14 };

            Eleve eleve9 = new Eleve();
            eleve9.name = "Coline";
            eleve9.notes = new int[] { 15, 12, 14 };

            Eleve eleve10 = new Eleve();
            eleve10.name = "Sebastien";
            eleve10.notes = new int[] { 15, 12, 14 };

            Eleve eleve11 = new Eleve();
            eleve11.name = "Hervé";
            eleve11.notes = new int[] { 15, 12, 14 };

            Eleve eleve12 = new Eleve();
            eleve12.name = "Fabien.D";
            eleve12.notes = new int[] { 15, 12, 14 };

            Eleve eleve13 = new Eleve();
            eleve13.name = "Julien";
            eleve13.notes = new int[] { 15, 12, 14 };

            Eleve eleve14 = new Eleve();
            eleve14.name = "Coralie";
            eleve14.notes = new int[] { 15, 12, 14 };


            eleve1.Parler(eleve9);
            eleve2.Crier(eleve8);

            Campus classe = new Campus();
            classe.Student = new Eleve[] { eleve1, eleve2, eleve3, eleve4, eleve5, eleve6, eleve7, eleve8, eleve9};

            
            classe.AfficherEtudiants();


            Console.WriteLine("La moyenne de {0} est {1}", eleve8.name, eleve8.Moyenne());

            Console.WriteLine("La moyenne de tous les étudiants est : " + classe.MoyenneEtudiants());

            


         }
    }

    public class Eleve
    {
        public string name;
        public int[] notes;

        public void Parler(Eleve autreEleve)
        {
            Console.WriteLine("{0} parle à {1}", name, autreEleve.name);
        }

        public void Crier(Eleve autreEleve)
        {
            Console.WriteLine("{0} crie après {1}", name, autreEleve.name);
        }

        public int Moyenne()
        {
            int sum=0;
            foreach (int value in notes)
            {
                sum = sum + value;
            }
            return sum = sum / notes.Length;
            
        }
    }

    public class Campus
    {
        public Eleve[] Student;
        public void AfficherEtudiants()
        {
            foreach (Eleve value in Student)
            {
                Console.WriteLine(value.name);
                Console.WriteLine();
            }
            
        }

        public int MoyenneEtudiants()
        {
            int sum = 0;
            foreach(Eleve value  in Student)
            {
                sum = sum + value.Moyenne();
            }
            return sum = sum / Student.Length;
        }
        

    }
}
