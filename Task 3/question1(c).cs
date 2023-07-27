using System;

public class GenericClass<T1, T2, T3>
{
    public T1 Property1 { get; set; }
    public T2 Property2 { get; set; }
    public T3 Property3 { get; set; }

    public GenericClass(T1 val1, T2 val2, T3 val3)
    {
        Property1 = val1;
        Property2 = val2;
        Property3 = val3;
    }

    public void DisplayProperties()
    {
        Console.WriteLine($"Property1: {Property1}, Type: {typeof(T1)}");
        Console.WriteLine($"Property2: {Property2}, Type: {typeof(T2)}");
        Console.WriteLine($"Property3: {Property3}, Type: {typeof(T3)}");
        Console.ReadLine();
    }
}

class Program2
{
    static void Main()
    {
        GenericClass<int, string, double> genericObj = new GenericClass<int, string, double>(180, "yamini", 4.14);
        genericObj.DisplayProperties();
    }
}
