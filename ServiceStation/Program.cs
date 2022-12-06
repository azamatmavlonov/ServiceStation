using System;
using ServiceStation.Model;
using System.Linq;
using System.Collections.Generic;
namespace ServiceStation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] people = { "Ali", "Vali", "Rauf", "Akmal", "Jabbor"};

            var selectedPeople = from p in people
                                 where p.ToUpper().EndsWith("L")
                                 orderby p
                                 select p;

            foreach (string person in selectedPeople)
                Console.WriteLine(person);

            Console.WriteLine("Enter your name:");
            Console.WriteLine("Factorial: 5 = " + Factorial(5));
            Console.WriteLine("Fibonachi: 12 = " + Fibonachi(12));
            */
            int[] numbers1 = { 1, 3, 5, 7 };
            int[] numbers2 = { 7, 5, 3, 1, 10 };
            Compare(numbers1, numbers2);

        }

        static void Compare(int[] numbers1, int[] numbers2)
        {
            int numbers1Sum = 0;
            foreach (int n in numbers1)
                numbers1Sum += n;

            int numbers2Sum = 0;
            foreach (int n in numbers2)
                numbers2Sum += n;

            if (numbers1Sum > numbers2Sum) Console.WriteLine("Sum of numbers from first array more than second array.");
            else if (numbers1Sum < numbers2Sum) Console.WriteLine("Sum of numbers from first array less than second array.");
            else Console.WriteLine("Sums are equal.");
        }

        public static int Factorial(int n)
        {
            if(n == 1) return 1;
            return n * Factorial(n - 1);
        }

        public static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;
            return Fibonachi(n - 2) + Fibonachi(n - 1);
        }
    }
}
