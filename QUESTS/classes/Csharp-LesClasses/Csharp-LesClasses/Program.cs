using System;

namespace Csharp_LesClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Character();
            player1.AskPerson(player1);
            player1.AskParameters(player1);

            Character player2 = new Character();
            player2.AskPerson(player2);
            player2.AskParameters(player2);

            if (player1.force==player2.defense && player2.force == player1.defense)
            {
                Console.WriteLine("There is no winner , {0} force = {1} defense={2} and {3} force = {4} defense ={5} ", player1.name, player2.name, player1.defense, player2.name, player1.name, player2.defense) ;
            }
            else
            {
                while ((player1.PV > 0) && (player2.PV > 0))
                {
                    player1.Attack(player2);
                    if (player2.PV > 0)
                    {
                        player2.Attack(player1);
                    }
                }
            }

            if (player1.PV <= 0)
            {
                Console.WriteLine("{0} is dead", player1.name);
            }
            else if (player2.PV <= 0)
            {
                Console.WriteLine("{0} is dead", player2.name);
            }
            Console.WriteLine("{0} PV = {1}", player1.name, player1.PV);
            Console.WriteLine("{0} PV = {1}", player2.name, player2.PV);
        }


        public class Character
        {
            public string name;
            public int PV;
            public int force;
            public int defense;
            public bool IsAlive()
            { 
                if (PV > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Attack(Character otherPlayer)
            {
                int playerPV = otherPlayer.PV;
                otherPlayer.PV = (otherPlayer.PV - (force - otherPlayer.defense));
                if (otherPlayer.PV>playerPV)
                {
                    otherPlayer.PV = playerPV;
                }
            }

            public void AskPerson(Character player)
            {
                Console.WriteLine("Enter player name: ");
                player.name = Console.ReadLine();
            }
            public void AskParameters(Character player)
            {
                while (player.PV<=0 || player.force<0 || player.defense < 0)
                {
                    Console.WriteLine("Enter {0} PV: ", player.name);
                    player.PV = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter player {0} force", player.name);
                    player.force = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter player {0} defense: ", player.name);
                    player.defense = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} PV={1} force={2} defense={3} ", player.name, player.PV, player.force, player.defense);
                    if (player.PV <=0 || player.defense<0 || player.force < 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please enter positives values!");
          
                    }
                }
                
            }


        }
        
    }
}
