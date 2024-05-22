//Basic Multilevel Inheritance
using System;

class Footballer
{
    public string messi="The GOAT of Football is Leo Messi";
}
class Shooting : Footballer 
{
    public string neymar = "Neymar shooting ability is 89% but skillwise he is best";
}
class Scorer: Shooting
{
    public string ronaldo = "Most Goal scorer in this era is Ronaldo";
}

class HelloWorld
{
    public static void Main(String[] args)
    {
        Scorer scr = new Scorer();

        Console.WriteLine(scr.messi);
        Console.WriteLine(scr.neymar);
        Console.WriteLine(scr.ronaldo);    
    }
}