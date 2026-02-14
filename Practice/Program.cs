using System.Text;

namespace ProgrammingQuestions
{
    internal class Program
    {

        static void Main(string[] args)
        {
            FindSumOfArray();

        }

        public static void Reverse()
        {
            Console.WriteLine("Enter a string to reverse");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
        }

        public static void Palindrome()
        {
            Console.WriteLine("Enter a string to check palindrome");
            string str = Console.ReadLine();
            string reversed = new string(str.Reverse().ToArray());
            Console.WriteLine(str == reversed ? "Palindrome" : "Not Palindrome");
        }
        public static void Swap()
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b; // a = 5
            b = a - b; // b= 2
            a = a - b; // a = 3
            Console.WriteLine($"First Number: {a}, Second Number: {b}");
        }

        public static void factorial()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine($"Factorial of {n} is {fact}");
        }

        public static void FibonacciSeries()
        {
            Console.WriteLine("Enter the number of Fibonacci terms to display");
            int n = Convert.ToInt32(Console.ReadLine()); // n=7
            int a = 0, b = 1;
            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a;           // temp = 0
                a = b;                  // a = 1
                b = temp + b;           // b = 0 + 1 = 1
            }
        }

        public static void PrimeNumbers()
        {
            Console.WriteLine("Enter the number of prime numbers to display");
            int n = Convert.ToInt32(Console.ReadLine());  // n=5
            int count = 0, num = 2;
            Console.WriteLine("Prime Numbers:");
            while (count < n)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(num + " ");
                    count++;
                }
                num++;
            }
        }

        public static void CheckPrime()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isPrime ? $"{n} is a prime number" : $"{n} is not a prime number");
        }

        public static void FindLargestInArray()
        {

            Console.WriteLine("Enter the number of elements in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //int largest = arr.Max();
            //Console.WriteLine($"The largest element in the array is: {largest}");

            int largest = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine($"The largest element in the array is: {largest}");
        }

        public static void CountVOWELS()
        {
            Console.WriteLine("Provide a string");
            string str = Console.ReadLine();
            string vowels = "AEIOUaeiou";

            int count = 0;
            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of vowels in the string: {count}");
        }

        public static void RemoveDuplicates()
        {
            Console.WriteLine("Enter a string to remove duplicates");
            string str = Console.ReadLine();
            string result = new string(str.Distinct().ToArray());
            Console.WriteLine($"String after removing duplicates: {result}");


            Console.WriteLine("Enter a string to remove duplicates");
            string strr = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (char c in strr)
            {
                if (!sb.ToString().Contains(c))
                {
                    sb.Append(c);
                }
            }
            Console.WriteLine($"String after removing duplicates: {sb.ToString()}");
        }

        public static void FindEvenNumbers()
        {
            Console.WriteLine("enter the element in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            var evenNumbers = arr.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine("Even numbers in the array:");
            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }



            //Console.WriteLine("Enter the number of even numbers to display");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Even Numbers:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(i * 2 + " ");
            //}
        }

        public static void FindSumOfArray()
        {
            Console.WriteLine("Enter the number of elements in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = arr.Sum();
            Console.WriteLine($"The sum of the elements in the array is: {sum}");
        }


    }
}
