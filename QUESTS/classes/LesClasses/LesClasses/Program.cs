using System;



   

namespace LesClasses
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
        if (PV>0){
          return true;
        }
        else{
          return false;
        }
      }
      
    }
    static void Main(string[] args)
    {
      Character player1 = new Character();
      Console.WriteLine("Enter player 1 name:");
      player1.name=Console.ReadLine();
      Console.WriteLine("Enter player 1 PV:");
      player1.PV=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter player 1 force attack:");
      player1.force=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter player 1 force defense:");
      player1.defense=Convert.ToInt32(Console.ReadLine());
      
      Character player2 = new Character();
      Console.WriteLine("Enter player 2 name:");
      player2.name=Console.ReadLine();
      Console.WriteLine("Enter player 2 PV:");
      player2.PV=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter player 2 force attack:");
      player2.force=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter player 2 force defense:");
      player2.defense=Convert.ToInt32(Console.ReadLine());

      int tour=0;
      while (player1.IsAlive()){
        player1.PV=player1.PV-(player2.force-player1.defense);
        tour++;
      }

      if (player1.IsAlive()){
        Console.WriteLine(player1.name + " is alive!");
      }else{
        Console.WriteLine(player1.name + " is dead!"+ " in "+tour+" tour");
      }

      if (player2.IsAlive()){
        Console.WriteLine(player2.name + " is alive!");
      }else{
        Console.WriteLine(player2.name + " is dead!");
      }

    }
  }
}