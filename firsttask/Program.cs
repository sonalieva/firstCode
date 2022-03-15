using System;

namespace firsttask
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            //int[] arr = { 13, 45, 67, 86, 34 };          
            //int counter = 0;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    while(arr[i] > 0)
            //    {
            //        sum = sum + (arr[i] % 10);
            //        arr[i] = arr[i] / 10;

            //    }
            //    if (sum < 10)
            //    {
            //        counter++;
            //    }
            //    sum = 0;
            //}
            //Console.WriteLine(counter);

            //TASK2
            //int b = 8000;
            //int count = 0;
            //for (int i = 1; i <= 8000; i++)
            //    if (i % 2 == 0)
            //    {
            //        count++;
            //    }
            //Console.WriteLine(count);


            //TASK3
            int a = 1;
            int b = 49;
            int kok = 0;
            for(a = 1; a * a <= b; a++)
            {
                kok++;
            }
            Console.WriteLine(kok);


       
        }                            
    }
}
