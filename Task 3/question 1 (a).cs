using System;

public class GenericMethods
{
    public static void ReverseSort<T>(T[] arr) where T : IComparable<T>
    {
        Array.Sort(arr);
        Array.Reverse(arr);
    }
}

class Program
{
    static void Main()
    {
        
        int[] intArray = GetIntArrayFromUser();
        GenericMethods.ReverseSort(intArray);
        Console.WriteLine("Sorted Integer Array in Reverse Order:");
        PrintArray(intArray);

     
        char[] charArray = GetCharArrayFromUser();
        GenericMethods.ReverseSort(charArray);
        Console.WriteLine("Sorted Character Array in Reverse Order:");
        PrintArray(charArray);
        Console.ReadLine();
    }

    static int[] GetIntArrayFromUser()
    {
        Console.WriteLine("Enter the number of elements in the Integer array:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the Integer array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        return arr;
    }

    static char[] GetCharArrayFromUser()
    {
        Console.WriteLine("Enter the number of elements in the Character array:");
        int n = int.Parse(Console.ReadLine());

        char[] arr = new char[n];
        Console.WriteLine("Enter the elements of the Character array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = char.Parse(Console.ReadLine());
        }

        return arr;
    }

    static void PrintArray<T>(T[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
