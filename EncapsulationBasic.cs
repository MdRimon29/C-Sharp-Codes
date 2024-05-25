using System;
//encapsulation  means hide "sensitive" data from the users
//properties is another way,but this way is best where we create different method for set and get the value.
class Student
{
    private int id;//this data is private.so we can access the data only from this class

    public void SetId(int num)//write on the private data 
    {
        id=num;
    }
    public int GetId()//read access for the private data
    {
        return id;
    }
}

class HelloWorld
{
    public static void Main(string[] args)
    {
        Student st=new Student();
        st.SetId(1015);
        Console.WriteLine(st.GetId()); 
    }
}