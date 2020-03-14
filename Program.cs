using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_in_CSharp
{
    class Program
    {
        public static void Num1()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 30);
            }
            foreach (var a in arr)
            {
                Console.Write("{0,4}", a);
            }
            Console.WriteLine();
            int sum = 0;
            bool found = false;
            for(int i = 0; i < arr.Length; i++)
            {
                if(!found && arr[i] < 0)
                {
                    found = true;
                    continue;
                }
                if(found)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Sum of elements after first negative: " + sum);
        }
        public static void Num2()
        {
            int[] arr = new int[20];
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-30, 10);
            }
            foreach(var a in arr)
            {
                Console.Write("{0,4}", a);
            }
            Console.WriteLine();
            int sum = 0;
            bool found = false;
            int positiveIndex = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (!found && arr[i] > 0)
                {
                    positiveIndex = i;
                    found = true;
                }
            }
            if(found)
            {
                for(int i = 0; i < positiveIndex; i++)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Sum of elements before first positive: " + sum);
        }
        public static void Num3()
        {
            int[] arr = new int[20];
            Random rand = new Random();
            int minElement = 0, maxElement = 0, minIndex = 0, maxIndex = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            foreach(var a in arr)
            {
                Console.Write("{0,4}", a);
            }
            Console.WriteLine();
            // max element and index search
            maxElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > maxElement)
                {
                    maxElement = arr[i];
                    maxIndex = i;
                }
            }
            // min element and index search
            minElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                    minIndex = i;
                }
            }
            Console.WriteLine("Max element: " + maxElement + "\n" + "Max Index: " + maxIndex);
            Console.WriteLine("Min element: " + minElement + "\n" + "Min Index: " + minIndex);
        }
        public static void Num4()
        {
            double[] arr = new double[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.NextDouble() * 150;
            }
            foreach (var i in arr)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine();
            double floating = 0.0;
            int integer = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                integer = (int)arr[i];
                floating = arr[i] - integer;
                Console.WriteLine("integer: " + integer + " floating: " + floating);
            }
        }
        public static void Num5()
        {
            int[] arr = new int[20];
            Random rand = new Random();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 1000);
            }
            Console.WriteLine();
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                count = (arr[i] == 0) ? 1 : 0;
                while(arr[i] != 0)
                {
                    count++;
                    arr[i] /= 10;
                }
                Console.WriteLine(count);
            }
            Console.WriteLine();
        }
        public static void Num6()
        {
            int[] arr = new int[20];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            foreach(var a in arr)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine("\n" + "Simple numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 2; j <= arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        if (arr[i] != j)
                            break;
                        Console.Write("{0,3}", arr[i]);
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
        public static void Num7()
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            foreach (var a in arr)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine("\n" + "Reversed array:");
            for(int i = 0; i < arr.Length; )
            {
                for(int j = arr.Length - 1; j >= 0; j--)
                {
                    arr2[j] = arr[i];
                    i++;
                }
            }
            foreach(var a in arr2)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine();
        }
        public static void Num8()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            foreach (var a in arr)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine("\n" + "changed:");
            int ch = 0;
            for(int i = 0; i < arr.Length; i+=2)
            {
                ch = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = ch;
            }
            foreach (var a in arr)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine();
        }
        public static void Num9()
        {
            int[] arr = new int[5];
            int[] arr2 = new int[5];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
                arr2[i] = rand.Next(0, 100);
            }
            foreach (var a in arr)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine();
            foreach(var a in arr2)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine();
            int[] arr3 = new int[10];
            int indexArr = 0, indexArr2 = 0;
            for (int k = 0; k < arr3.Length; )
            { 
                if(indexArr < arr.Length)
                {
                    arr3[k] = arr[indexArr];
                    indexArr++;
                    k++;
                }
                if(indexArr2 < arr2.Length)
                {
                    arr3[k] = arr2[indexArr2];
                    indexArr2++;
                    k++;
                }
            }
            foreach(var a in arr3)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine();
        }
        public static void Num10()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            Console.WriteLine("First array:");
            foreach (var a in arr)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine("\nSecond array:");
            int[] arr2 = new int[10];
            int arr2index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    arr2[arr2index] = arr[i];
                    arr2index++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr2[arr2index] = arr[i];
                    arr2index++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr2[arr2index] = arr[i];
                    arr2index++;
                }
            }
            foreach (var a in arr2)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine();
        }
        public static void Num11()
        {
            int[] arr = new int[10];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            int indexArr2 = 0, indexArr3 = 0;
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            Console.WriteLine("Arr:");
            foreach (var a in arr)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine();
            for(int i = 0; i < arr.Length; )
            {
                if(indexArr2 < arr.Length)
                {
                    arr2[indexArr2] = arr[i];
                    indexArr2++;
                    i++;
                }
                if(indexArr3 < arr.Length)
                {
                    arr3[indexArr3] = arr[i];
                    indexArr3++;
                    i++;
                }
            }
            Console.WriteLine("Arr2:");
            foreach (var a in arr2)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine("\nArr3:");
            foreach (var a in arr3)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Num1();
            Console.WriteLine();
            Num2();
            Console.WriteLine();
            Num3();
            Console.WriteLine();
            Num4();
            Console.WriteLine();
            Num5();
            Console.WriteLine();
            Num6();
            Console.WriteLine();
            Num7();
            Console.WriteLine();
            Num8();
            Console.WriteLine();
            Num9();
            Console.WriteLine();
            Num10();
            Console.WriteLine();
            Num11();
            Console.WriteLine();
        }
    }
}
