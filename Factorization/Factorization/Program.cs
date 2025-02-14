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
            Console.Write("Enter an integer larger than 1 AND less than 2B. I will show you it's factors. 'f' to finish -> ");
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

            primeList = findAllPrimes(num);

            if (primeList.Contains(num))
                Console.WriteLine(num + " is a prime.");
            else
            {
                List<int> factors = findFactors(num, primeList);

                Console.WriteLine(presentFactors(factors));
            }

            primeList = null;
            goto REPEAT1;
        }

        static string presentFactors(List<int> factors)
        {
            string result= "(";
            int j = -1;

            foreach (int i in factors)
            {
                if (j < 0)
                {
                    result = result + " " + i + " * ";
                    j = i;
                }
                else
                {
                    if (i != j)
                    {
                        result = result.Remove(result.Length - 3, 3);
                        result = result + " )( " + i + " * ";
                    }
                    else 
                    {
                        result = result + i + " * ";
                    }
                    j = i;
                }
            }

            result = result.Remove(result.Length - 2, 2);
            result = result + ")";
            return result;
        }

        static List<int> findFactors(int num, List<int> primeList)
        {
            List<int> factors= new List<int>();

            int dividend= num;
            foreach (int i in primeList)
            {
REPEAT2:
                if ((dividend % i) == 0)
                {
                    factors.Add(i);
                    dividend = dividend / i;
                    if (dividend==1) break;

                    goto REPEAT2;
                }
            }

            return factors;
        }

        static List<int> findAllPrimes(int num)
        {
            List<int> primeList = new List<int>();

            primeList.Add(2);
            if (num == 2) return primeList;

            for (int i = 3; i <= num; i++)
            {
                if ((i % 2)==0) continue;

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
