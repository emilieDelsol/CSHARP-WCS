using System;
using System.Runtime.InteropServices.ComTypes;

namespace CsharpLesClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Character();
            
            
            Console.WriteLine("Enter player 1 name:");
            players.name = Console.ReadLine();
               
            while (!IsPositif(PV))
            {
                Console.WriteLine("Enter player 1 PV:");
                players.PV = Convert.ToInt32(Console.ReadLine());

            }
                
            while (!IsPositif(force))
            {
                Console.WriteLine("Enter player 1 force:");
                players.force = Convert.ToInt32(Console.ReadLine());

            }
            while (!IsPositif(defense))
            {
                Console.WriteLine("Enter player 1 defense:");
                players.defense = Convert.ToInt32(Console.ReadLine());

            }
            


            Character player2 = new Character();
            Console.WriteLine("Enter player 2 name:");
            players.name = Console.ReadLine();
               
            while (!IsPositif(PV))
            {
                Console.WriteLine("Enter player 2 PV:");
                players.PV = Convert.ToInt32(Console.ReadLine());

            }
                
            while (!IsPositif(force))
            {
                Console.WriteLine("Enter player 2  force:");
                players.force = Convert.ToInt32(Console.ReadLine());

            }
            while (!IsPositif(defense))
            {
                Console.WriteLine("Enter player 2 defense:");
                players.defense = Convert.ToInt32(Console.ReadLine());

            }
            

           
            player1.Attack(player1, player2);
            if (player2.IsAlive())
            {
                player2.Attack(player2, player1);
            }

           
            if (player1.IsAlive()==true)
            {
                Console.WriteLine(player1.name + " is alive!");
            }
            else
            {
                Console.WriteLine(player1.name + " is dead!");
            }

            if (player2.IsAlive()==true)
            {
                Console.WriteLine(player2.name + " is alive!");
            }
            else
            {
                Console.WriteLine(player2.name + " is dead!");
            }



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
                return ( player.PV, otherPlayer.PV )

            }

            
            

        }


        
    }
}
