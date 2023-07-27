using System;

public class GenericSwap
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

class Program1
{
    static void Main()
    {
        Console.WriteLine("Enter value of a ");
        int a =Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter value of b ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
        GenericSwap.Swap(ref a, ref b);
        Console.WriteLine("After swapping: a = " + a + ", b = " + b);

        Console.WriteLine("Enter value of c1 ");
        char c1 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter value of c2 ");
         char c2 = Convert.ToChar(Console.ReadLine());
       
        Console.WriteLine("Before swapping: c1 = " + c1 + ", c2 = " + c2);
        GenericSwap.Swap(ref c1, ref c2);
        Console.WriteLine("After swapping: c1 = " + c1 + ", c2 = " + c2);
        Console.ReadLine();
    }
}
