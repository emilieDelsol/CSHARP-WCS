using System;
using System.Runtime.InteropServices.ComTypes;

namespace CsharpLesClasses
{
    class Program
    {
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
            public bool IsPositif(int parameter)
            {
                if (parameter>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public void Attack(Character player, Character otherPlayer)
            {
                if ((player.defense >= otherPlayer.force) && (otherPlayer.defense >= player.force))
                {
                    Console.WriteLine("Player defense is better or egal than the other player force. There is no winner!");
                }
                else 
                {
                    while (player.IsAlive() && otherPlayer.IsAlive())
                    {
                        otherPlayer.PV = otherPlayer.PV - (player.force - otherPlayer.defense);
                    }
                }
            }

            public void Person(Character players, int number)
            {
                Console.WriteLine("Enter player "+number+" name:");
                players.name = Console.ReadLine();
               
                while (!IsPositif(PV))
                {
                    Console.WriteLine("Enter player " + number + " PV:");
                    players.PV = Convert.ToInt32(Console.ReadLine());

                }
                
                while (!IsPositif(force))
                {
                    Console.WriteLine("Enter player " + number + " force:");
                    players.force = Convert.ToInt32(Console.ReadLine());

                }
                while (!IsPositif(defense))
                {
                    Console.WriteLine("Enter player " + number + " defense:");
                    players.defense = Convert.ToInt32(Console.ReadLine());

                }
            }

            public void Result (Character player)
            {
                if (player.IsAlive())
                {
                    Console.WriteLine(player.name + " is alive!");
                }
                else
                {
                    Console.WriteLine(player.name + " is dead!");
                }
            }

        }


        static void Main(string[] args)
        {
            Character player1 = new Character();
            player1.Person(player1, 1);

            Character player2 = new Character();
            player2.Person(player2, 2);

           
            player1.Attack(player1, player2);
            if (player2.IsAlive())
            {
                player2.Attack(player2, player1);
            }

            player1.Result(player1);

            player2.Result(player2);

        }
    }
}
