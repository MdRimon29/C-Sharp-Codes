using System;
//method overloading is multiple method with same name but different parameters
//so mainly name same but number of parameters or types of parameter is different 
class HelloWorld
{
    public void student(int x , int y)
    {
        Console.WriteLine(x+y);
    }

    public void student(double x,double y)
    {
        Console.WriteLine(x+y);
    }

    public void student(int x,int y,int z)
    {
        Console.WriteLine(x+y+z);
    }
    
    public static void Main(string[] args)
    {
        HelloWorld hw=new HelloWorld();
        hw.student(5,6);
        hw.student(5.5,6.5);
        hw.student(1,2,3);
    }
}