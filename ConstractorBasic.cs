using System;
//constructor mainly save our time
//if the method name is as simillar as class name then we called it as a constructor
//constructor cannot have a return type

class Subject
{
    public string sub1;
    public string sub2;
    public int time;

    public Subject(string subName,string subName2,int year)//constructor with three parameter
    {
        sub1=subName;
        sub2=subName2;
        time=year;
    }
    public static void Main(string[] args)
    {
        Subject rimonFav=new Subject("Physics","Programming",2024);//value for constructor parameter
        Subject hasibFav=new Subject("Chemistry","Biology",2024);
        Subject sojebFav=new Subject("ICT","Programming",2024);

        
        Console.WriteLine("Rimon:   "+rimonFav.sub1+"   "+rimonFav.sub2+"   "+rimonFav.time);
        Console.WriteLine("Hasib:   "+hasibFav.sub1+"   "+hasibFav.sub2+"   "+hasibFav.time);
        Console.WriteLine("Sojeb:   "+sojebFav.sub1+"   "+sojebFav.sub2+"   "+sojebFav.time);
    }
}