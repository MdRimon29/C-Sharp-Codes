using System;

class HelloWorld
{
    static void Answer()
    {
        Console.WriteLine(Fibonacci(5));
    }
    static int Fibonacci(int n)
    {
        if(n==0)
        {
            return 0;
        }
        else
        {
            return n+Fibonacci(n-1);
        }
    }
    public static void Main(string[] args)
    {
        Answer();
    }
}