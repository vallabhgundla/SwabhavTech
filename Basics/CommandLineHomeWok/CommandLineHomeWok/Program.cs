using System;


namespace CommandLineHomeWok
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double avg;
            int Max = 0;
            int[] arr=new int[5];
            for (int i = 0; i < args.Length; i++)
            {
                arr[i] = Convert.ToInt32(args[i]);
 
            }
            int num = Convert.ToInt32(args[0]);
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / args.Length;

            for(int i = 0; i < args.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            Console.Write("The sum of no is : {0}\nThe Average is : {1}\n The Max no is : {2}\n ", sum, avg, Max);

        }
    }
}
