using System;

class RecExercise6
{
    public static void Main()
    {
        int[] a= GetEvenNo();
        Console.WriteLine("\n All even numbers are : ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

        int[] b = GetOddNo();
        Console.WriteLine("\n All Odd numbers are : ");
        for (int i = 0; i < b.Length; i++)
        {           
            Console.WriteLine(b[i]);
        }
    }
    public static int[] GetEvenNo()
    {
        int[] EvenNo = {2,4,6,8,10 };
        return EvenNo;
    }
    public static int[] GetOddNo()
    {
        int[] oddNo = { 1, 3, 5, 7, 9 };
        return oddNo;
    }
}