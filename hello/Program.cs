using System;
class Hello
{
    static void Main()
    {
        string name = "bob";
        Console.WriteLine("hello world");
        Console.WriteLine("my name is " + name + ". what is your name?");
        string playername = Console.ReadLine();
        Console.WriteLine("hello there, " + playername);
        Console.WriteLine("im thinking of a number between 1 and 10. wpuld you like to guess it?");
        string playgame = Console.ReadLine();
       
        if (playgame is ("y"))
        {
            Console.WriteLine("ok then!");
            Rng();
        }
        
        
        Console.WriteLine("press a key to exit");
        Console.ReadKey();
    }
  
   
    static void Rng()
       {
           Console.WriteLine("ok then!");
       }

    
}

