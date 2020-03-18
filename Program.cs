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
        
        // adding new
        
        public static void Num12()
        {
            /* 2 arrays of M and N size, create 3rd array with repeated elements only 1 time */
            Random rand = new Random();
            Console.WriteLine("Enter M size:");
            int M = Int32.Parse(Console.ReadLine());
            int[] mas1 = new int[M];
            Console.WriteLine("Enter N size:");
            int N = Int32.Parse(Console.ReadLine());
            int[] mas2 = new int[N];
            Console.WriteLine("Array 1:");
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = rand.Next(10);
                Console.Write("{0,3}", mas1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Array 2:");
            for (int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = rand.Next(10);
                Console.Write("{0,3}", mas2[i]);
            }
            Console.WriteLine();
            int[] mastemp = new int[M + N];
            int index = 0;
            bool povtor = false;
            for (int i = 0; i < mas1.Length; i++)
            {
                for (int j = 0; j < mas2.Length; j++)
                {
                    if (mas1[i] == mas2[j])
                    {
                        /* loop for guessing arr3 size */
                        for (int k = 0; k < mastemp.Length; k++)
                        {
                            if (mastemp[k] == mas2[j])
                            {
                                povtor = true;
                            }
                        }
                        /* if(!povtor) means index++ to create arr3 with size of 
                         * repeated elements of 1st and 2nd only 1 time */
                        if (!povtor)
                        {
                            mastemp[index++] = mas2[j];
                        }
                        povtor = false;
                    }
                }
            }
            int[] mas3 = new int[index];
            for (int i = 0; i < mas3.Length; i++)
            {
                mas3[i] = mastemp[i];
            }
            Console.WriteLine("Array 3:");
            foreach (var a in mas3)
            {
                Console.Write("{0,3}", a);
            }
            Console.WriteLine();
        }
        public static void Num13()
        {
            Random rand = new Random();
            Console.WriteLine("Enter M size:");
            int M = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter N size:");
            int N = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[M, N];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(100);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter 1 for right shift, enter 2 for left shift:");
            int shift = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Choose how many shifts do you want to perform:");
            int shiftsAmount = Int32.Parse(Console.ReadLine());
            int temp = new int();
            if (shift == 1)
            { // right shift
                /*1st loop for shifts*/
                for (int x = 0; x < shiftsAmount; x++)
                {
                    /*loop for shifting array elements*/
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = arr.GetLength(1) - 1; j > 0; j--)
                        { // starting from back of an array
                            temp = arr[i, j - 1]; // remember the last element
                            arr[i, j - 1] = arr[i, j]; // shifting
                            arr[i, j] = temp; // first elements will be the "remembered" last
                        }
                    }
                }
            }
            else if (shift == 2)
            { // left shift
                for (int x = 0; x < shiftsAmount; x++)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1) - 1; j++)
                        { // starting from the beginning
                            temp = arr[i, j + 1];
                            arr[i, j + 1] = arr[i, j];
                            arr[i, j] = temp;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                return;
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Num14()
        {
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int maxIndexI = 0;
            int maxIndexJ = 0;
            int minIndexI = 0;
            int minIndexJ = 0;
            /* detecting max and min elements of an array */
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[maxIndexI, maxIndexJ])
                    {
                        // if current element is bigger than 0,0 -> we rewrite maxIndexI and maxIndexJ
                        maxIndexI = i;
                        maxIndexJ = j;
                    }
                    if (arr[i, j] < arr[minIndexI, minIndexJ])
                    {
                        // if current element if smaller -> we rewrite min indexes
                        minIndexI = i;
                        minIndexJ = j;
                    }
                }
            }
            Console.WriteLine("Max element of an array is " + arr[maxIndexI, maxIndexJ]
                + " index is: " + maxIndexI + "\\" + maxIndexJ);
            Console.WriteLine("Min element of an array is " + arr[minIndexI, minIndexJ]
                + " index is: " + minIndexI + "\\" + minIndexJ);
            int sum = new int();
            bool p = false;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == maxIndexI && j == maxIndexJ || i == minIndexI && j == minIndexJ)
                    {
                        p = !p;
                        continue;
                    }
                    else if (p)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of elements between max and min = " + sum);
        }
        public static void Num15()
        {
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(0, 100);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] mas = new int[5];
            int sum = 0;
            for (int j = 0, x = 0; j < arr.GetLength(1); j++) {
                for (int i = 0; i < arr.GetLength(0); i++) {
                    sum += arr[i, j];
                }
                mas[x++] = sum;
                sum = 0;
            }
            Console.WriteLine("Array with sorted sums by columns:");
            foreach(var s in mas) {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++) {
                for (int j = mas.Length - 1; j > i; j--) {
                    if (mas[j - 1] < mas[j]) {
                        int temp = mas[j - 1];
                        mas[j - 1] = mas[j];
                        mas[j] = temp;
                        for (int x = 0; x < arr.GetLength(0); x++) {
                            for (int z = 0; z < arr.GetLength(1); z++) {
                                int temp2 = arr[x, j - 1];
                                arr[x, j - 1] = arr[x, j];
                                arr[x, j] = temp2;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            for(int i = 0; i < arr.GetLength(0); i++) {
                for(int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Num16()
        {
            int[][] arr = new int[9][];
            arr[0] = new int[] { 1 };
            arr[1] = new int[] { 2, 2 };
            arr[2] = new int[] { 3, 3, 3 };
            arr[3] = new int[] { 4, 4, 4, 4 };
            arr[4] = new int[] { 5, 5, 5, 5, 5 };
            arr[5] = new int[] { 6, 6, 6, 6, 6, 6 };
            arr[6] = new int[] { 7, 7, 7, 7, 7, 7, 7 };
            arr[7] = new int[] { 8, 8, 8, 8, 8, 8, 8, 8 };
            arr[8] = new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            
        }
    }
}
