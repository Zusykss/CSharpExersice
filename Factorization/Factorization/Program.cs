// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;

namespace Factorization
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num;
            List<int> primeList;
            string msg = "f";

        REPEAT1:
            Console.Write("Enter an integer larger than 1 AND less than 2B. I will tell you if it is a prime. 'f' to finish -> ");
            try
            {
                num = int.Parse(msg = Console.ReadLine());
            }
            catch (Exception ex)
            {
                //if (strcomp(msg.Substring(0, 1), "f") == 0) return;
                if (msg != null && msg.Equals("f")) return;
                Console.WriteLine(ex.Message);
                goto REPEAT1;
            }
            if (num > 2000000000)
            {
                Console.WriteLine("Number too large. It cannot exceed 2B");
                goto REPEAT1;
            }
            if (num <= 1)
            {
                Console.WriteLine("Number has to be larger than 1!");
                goto REPEAT1;
            }

            if (num == 2)
            {
                Console.WriteLine(num + " is a prime.");
                goto REPEAT1;
            }

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is NOT a prime. It is an even number.");
                goto REPEAT1;
            }

            primeList = findAllPrimes(num);

            if (primeList.Contains(num))
                Console.WriteLine(num + " is a prime.");
            else
            {
                Console.Write(num + " is NOT a prime. It can be divided by: ");
                Console.WriteLine(commaDelimited(primeList, num));
            }
            goto REPEAT1;
        }

        static string commaDelimited(List<int> primeList, int num)
        {
            string str= "";

            foreach (int prime in primeList)
            {
                if (num % prime == 0) str= str + prime + ",";
            }

            if (str.Length>0) str= str.Remove(str.Length - 1, 1);
            return str;
        }

        static List<int> findAllPrimes(int num)
        {
            List<int> primeList = new List<int>();

            primeList.Add(2);
            if (num == 2) return primeList;

            for (int i = 3; i <= num; i++)
            {
            NEXT1:
                int count = primeList.Count;
                for (int index = 0; index < count - 1; index++)
                {
                    if (i % primeList[index] == 0)
                    {
                        i++;
                        if (i > num) return primeList;
                        goto NEXT1;
                    }
                }
                primeList.Add(i);
            }
            return primeList;
        }
    }
}
