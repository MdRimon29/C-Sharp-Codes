using System;
//in this case we use get set and value keyword for the read write operation with proper symbol
class Student
{
    public string name="Rimon";
    private int id;

    public int Id
    {
        get { return id;}
        set { id= value; }
    }
}

class HelloWorld
{
    public static void Main(string[] args)
    {
        Student st=new Student();
        st.Id=1015;
        Console.WriteLine(st.name +": "+st.Id);
    } 
}