using System.Text;

namespace ProgrammingQuestions
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //FindLeapyear();

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

        public static void SecondLargestInArray()
        {
            Console.WriteLine("Enter the number of elements in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            var secondLargest = arr.OrderByDescending(x => x).Distinct().Skip(1).FirstOrDefault();
            Console.WriteLine($"The second largest element in the array is: {secondLargest}");


        }

        public static void CountWordsInstring()
        {
            Console.WriteLine("Enter a string to count words");
            string str = Console.ReadLine();
            int wordCount = str.Split(' ').Count();
            //int wordCount = str.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Number of words in the string: {wordCount}");
        }

        public static void FindMissingNumberInArray()
        {
            Console.WriteLine("Enter the number of elements in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array (from 1 to n+1 with one missing)");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine()); //{1,2,4,5}
            }
            int expectedSum = (n + 1) * (n + 2) / 2; // Sum of first n+1 natural numbers // 1+2+3+4+5 = 15
            int actualSum = arr.Sum(); // 12
            int missingNumber = expectedSum - actualSum;
            Console.WriteLine($"The missing number in the array is: {missingNumber}");
        }


        public static void AnagramString()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine().ToLower();
            bool areAnagrams = new string(str1.OrderBy(c => c).ToArray()) == new string(str2.OrderBy(c => c).ToArray());
            Console.WriteLine(areAnagrams ? "The strings are anagrams" : "The strings are not anagrams");
        }

        public static void FrequencyOfCharacters()
        {
            Console.WriteLine("Enter a string to count frequency of characters");
            string str = Console.ReadLine().ToLower();
            var frequency = str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            Console.WriteLine("Frequency of characters in the string:");
            foreach (var kvp in frequency)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public static void LongestString()
        {
            Console.WriteLine("provide the number of elements in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int index = 0;

            string[] arr = new string[n];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine().ToLower();
            }
            //var longestString = arr.OrderByDescending(s => s.Length).FirstOrDefault();
            int maxLength = arr[0].Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > maxLength)
                {
                    index = i;
                }
            }
            Console.WriteLine($"The longest string in the array is: {arr[index]}");
        }

        public static void FindLeapyear()
        {
            Console.WriteLine("Enter a year to check if it's a leap year");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            Console.WriteLine(isLeapYear ? $"{year} is a leap year" : $"{year} is not a leap year");
        }


    }
} 
