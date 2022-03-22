using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("input amount of face on the dice");
    int dice=Convert.ToInt32(Console.ReadLine());
    Random rd = new Random();
    int roll = rd.Next(1,dice);
    if (dice==6)
    {
      switch (roll)
     {
       case 1:
        Console.WriteLine("...........");
        Console.WriteLine("|         |");
        Console.WriteLine("|         |");
        Console.WriteLine("|    0    |");
        Console.WriteLine("|         |");
        Console.WriteLine("|         |");
        Console.WriteLine("...........");
        break;
       case 2:
        Console.WriteLine("...........");
        Console.WriteLine("|         |");
        Console.WriteLine("|      0  |");
        Console.WriteLine("|         |");
        Console.WriteLine("|  0      |");
        Console.WriteLine("|         |");
        Console.WriteLine("...........");
        break;
       case 3:
        Console.WriteLine("...........");
        Console.WriteLine("|         |");
        Console.WriteLine("|      0  |");
        Console.WriteLine("|    0    |");
        Console.WriteLine("|  0      |");
        Console.WriteLine("|         |");
        Console.WriteLine("...........");
        break;
       case 4:
        Console.WriteLine("...........");
        Console.WriteLine("|         |");
        Console.WriteLine("|  0   0  |");
        Console.WriteLine("|         |");
        Console.WriteLine("|  0   0  |");
        Console.WriteLine("|         |");
        Console.WriteLine("...........");
        break;
       case 5:
        Console.WriteLine("...........");
        Console.WriteLine("|         |");
        Console.WriteLine("|  0   0  |");
        Console.WriteLine("|    0    |");
        Console.WriteLine("|  0   0  |");
        Console.WriteLine("|         |");
        Console.WriteLine("...........");
        break;
       case 6:
        Console.WriteLine("...........");
        Console.WriteLine("|         |");
        Console.WriteLine("|  0   0  |");
        Console.WriteLine("|  0   0  |");
        Console.WriteLine("|  0   0  |");
        Console.WriteLine("|         |");
        Console.WriteLine("...........");
        break;
      
     }
     Console.WriteLine("your d"+dice+" rolled "+roll);
    }
    
    else if (dice==2)
    {
      switch (roll)
      {
        case 1:
          Console.WriteLine("your coin landed on heads");
          Console.WriteLine("  ---------");
          Console.WriteLine(" /         ]");
          Console.WriteLine("|   0   0   |");
          Console.WriteLine("| [_______] |");
          Console.WriteLine(" ]         /");
          Console.WriteLine("  ---------");
          break;
        case 2:
          Console.WriteLine("your coin landed on tails");
          Console.WriteLine("  ---------");
          Console.WriteLine(" /         ]");
          Console.WriteLine("|   ._T_.   |");
          Console.WriteLine("| <_<_<_>_> |");
          Console.WriteLine(" [         /");
          Console.WriteLine("  ---------");
          break;
      }
    
    }
   else if (dice>1)
   {
     Console.WriteLine("     /] ");
     Console.WriteLine("    /  ] ");
     Console.WriteLine("   /    ] ");
     Console.WriteLine("  /  "+roll+"  ] ");
     Console.WriteLine(" /        ] ");
     Console.WriteLine("/          ] ");
     Console.WriteLine("-------------");
     Console.WriteLine("your d"+dice+" rolled "+roll);
   }
   else
   {
     Console.WriteLine("invalid number");
   }
  }
}