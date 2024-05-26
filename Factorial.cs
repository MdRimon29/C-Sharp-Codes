using System;

class HelloWorld
{
    static void Answer()
    {
        Console.WriteLine(Factorial(9));
    }
    static int Factorial(int n)
    {
        if(n==0)
        {
            return 1;
        }
        else
        {
            return n*Factorial(n-1);
        }
    }
    public static void Main(string[] args)
    {
        Answer();
    }
}