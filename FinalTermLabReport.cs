using System;

class Vehicle
{
    private string model;
    private int year;

    public Vehicle()
    {
        model="Rolls Royce";
        year=2000;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine(model);
        Console.WriteLine(year);
    }
}

class Car : Vehicle
{
    private int numberOfDoors;

    public Car()
    {
        numberOfDoors=4;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(numberOfDoors);
    }
}

class Motorcycle : Vehicle
{
    private int SideDoor;

    public Motorcycle()
    {
        SideDoor=10;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(SideDoor);
    }
}

class HelloWorld
{
    public static void Main(string[] args)
    {
        Vehicle vhc=new Vehicle();
        Car car=new Car();
        Motorcycle motorcycle=new Motorcycle();
        
        vhc.DisplayInfo();
        car.DisplayInfo();
        motorcycle.DisplayInfo();
    }
}