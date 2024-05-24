using System;
//creating a method in child class with the same name,same return type or same signature as the method in the base/parent class is called method overriding
//we use virtual keyword in base class method for overriden that perticular method(that mean this method can be overriden)
//override method used in a derived class method for modify a virtual method
class Animal
{
    public virtual void sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public override void sound()
    {
        Console.WriteLine("Dogs sounds like:Gheo Gheo");
        Console.WriteLine("Dogs are more aggressive than cats");
    }
}

class Cat : Animal
{
    public override void sound()
    {
        Console.WriteLine("Cats sounds like:Meow Meow");
        Console.WriteLine("Cats are less aggressive than dogs");
    }
}

class HelloWorld
{
    public static void Main(string[] args)
    {
        //Animal anml=new Animal();
        Dog dog =new Dog();
        Cat cat =new Cat();
        dog.sound();
        cat.sound();
    }
}