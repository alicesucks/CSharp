﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// practice tasks from one of the websites...

namespace practice
{
    class Program
    {
        public static void Sum()
        {
            string[] plus = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(plus[0]) + int.Parse(plus[1]));
        }
        public static void LoopSum()
        {
            Console.WriteLine("Enter amount of numbers:");
            string a = Console.ReadLine();
            int amount = Int32.Parse(a);
            int[] loop = new int[amount];
            int sum = new int();
            Console.WriteLine("Enter numbers via enter:");
            for(int i = 0; i < loop.Length; i++)
            {
                string l = Console.ReadLine();
                loop[i] = Int32.Parse(l);
            }
            Console.Clear();
            for (int i = 0; i < loop.Length; i++)
            {
                Console.Write("{0,5}", loop[i]);
                sum += loop[i];
            }
            Console.WriteLine("\nsum = " + sum);
        }
        public static void LoopsSums()
        {
            Random rand = new Random();
            Console.WriteLine("Write amount of pairs you want to add:");
            string am = Console.ReadLine();
            int amount = Int32.Parse(am);
            int[,] mas = new int[amount,2];
            int sum = new int();
            for(int i = 0; i < mas.GetLength(0); i++)
            {
                for(int j = 0; j < mas.GetLength(1); j++)
                {
                    string input = Console.ReadLine();
                    mas[i, j] = Int32.Parse(input);
                    Console.Write("{0,3}", mas[i, j]);
                    Console.WriteLine();
                    sum += mas[i, j];
                }
                Console.WriteLine("\tsum = " + sum);
                sum = 0;
            }
        }
        public static void MinimumOfTwo()
        {
            Console.WriteLine("Write amount of elements you want to add:");
            string am = Console.ReadLine();
            int amount = Int32.Parse(am);
            int[] mas1 = new int[amount];
            int[] mas2 = new int[amount];
            int[] mas3 = new int[amount];
            for(int i = 0; i < mas1.Length; i++)
            {    
                Console.WriteLine("Enter " + i + " pair:");
                string m1 = Console.ReadLine();
                mas1[i] = Int32.Parse(m1);
                Console.Write("mas 1 - index: " + i + " = " + mas1[i]);
                Console.WriteLine();
                string m2 = Console.ReadLine();
                mas2[i] = Int32.Parse(m2);
                Console.Write("mas 2 - index: " + i + " = " + mas2[i]);
                Console.WriteLine();
            }
            for (int i = 0; i < mas3.Length; i++)
            {
                if(mas1[i] < mas2[i]) {
                    mas3[i] = mas1[i];
                }
                else {
                    mas3[i] = mas2[i];
                }
                Console.Write("mas 3 - index: " + i + " = " + mas3[i]);
                Console.WriteLine();
            }
        }
        public static void MinimumOfThree()
        {
            Console.WriteLine("Write amount of elements you want to add:");
            string am = Console.ReadLine();
            int amount = Int32.Parse(am);
            int[] min = new int[amount];
            for(int i = 0; i < amount; i++)
            {
                Console.WriteLine("Enter 1st element:");
                int arr1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd element:");
                int arr2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter 3rd element:");
                int arr3 = Int32.Parse(Console.ReadLine());
                min[i] = Math.Min(arr1, Math.Min(arr2, arr3));
                Console.WriteLine("Lowest of three: " + min[i]);
            }
            foreach (var a in min)
            {
                Console.Write("{0,5}", a);
            }
            Console.WriteLine();
        }
        public static void Rounding()
        {
            Console.WriteLine("Enter amount of numbers:");
            int amount = Int32.Parse(Console.ReadLine());
            double[] mas1 = new double[amount];
            double[] mas2 = new double[amount];
            Console.WriteLine("Fill in first array:");
            for(int i = 0; i < mas1.Length; i++) {
                double input = double.Parse(Console.ReadLine());
                mas1[i] = input;
            }
            Console.WriteLine("Fill in second array:");
            for (int i = 0; i < mas2.Length; i++) {
                double input = double.Parse(Console.ReadLine());
                mas2[i] = input;
            }
            foreach(var a in mas1) {
                Console.Write("{0,5}", a);
            }
            Console.WriteLine();
            foreach (var a in mas2) {
                Console.Write("{0,5}", a);
            }
            Console.WriteLine();
            int result;
            double res;
            for (int i = 0; i < mas1.Length && i < mas2.Length; i++) {
                res = mas1[i] / mas2[i] + 0.5;
                Console.WriteLine(res);
                result = (int)res;
                Console.WriteLine(result);
            }
        }
        
        // adding new example
        // fahrenheit to celsius converter
        public static void FahrenheitToCelsius()
        {
            double res = new double();
            double[] F_arr = new double[31];
            for(int i = 0; i < F_arr.Length; i++) {
                Console.WriteLine("Enter Fahrenheits ->");
                double F = Double.Parse(Console.ReadLine());
                F_arr[i] = F;
            }
            for(int i = 0; i < F_arr.Length; i++) {
                res = ((5.0 / 9) * (F_arr[i] - 32));
                if(res > 0)
                {
                    Console.WriteLine("Result in Celsius -> " + (int)(res + 0.5));
                }
                else Console.WriteLine("Result in Celsius -> " + (int)(res - 0.5));
            }
        }
        // arithmetic progression 
        public static void ArithmeticProgression()
        {
            int i = 0, j = 0;
            int res = 0, sum = 0;
            while (i < 8) { 
                Console.WriteLine("Enter start value ->");
                int start_value = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter step value ->");
                int step_value = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter how many of start values should be accounted ->");
                int accounted = Int32.Parse(Console.ReadLine());
                while (j < accounted)
                {
                    res = start_value + j * step_value;
                    sum += res;
                    j++;
                }
                Console.WriteLine("SUM - > " + sum);
                j = 0;
                sum = 0;
                i++;
            }
        }
        public static void SumOfDigits()
        {
            Console.WriteLine("Enter amount of triplets ->");
            int triplets = Int32.Parse(Console.ReadLine());
            int[,] arrOfNumbers = new int[triplets,3];
            int temp = 0;
            int sum = 0;
            int arrIndex = 0;
            for(int i = 0; i < arrOfNumbers.GetLength(0); i++) {
                Console.WriteLine("Loop Number: " + i);
                for(int j = 0; j < arrOfNumbers.GetLength(1); j++) {
                    Console.WriteLine("Enter number ->");
                    int number = Int32.Parse(Console.ReadLine());
                    arrOfNumbers[i, j] = number;
                    number = 0;
                }
            }
            for (int i = 0; i < arrOfNumbers.GetLength(0); i++) {
                temp = arrOfNumbers[i, arrIndex] * arrOfNumbers[i, arrIndex + 1] + 
                    arrOfNumbers[i,arrIndex + 2];
                while(temp!=0) {
                    sum = sum + temp % 10;
                    temp = temp / 10;
                }
                Console.WriteLine("Sum of digits = " + sum);
                sum = 0;
                temp = 0;
                arrIndex = 0;
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
