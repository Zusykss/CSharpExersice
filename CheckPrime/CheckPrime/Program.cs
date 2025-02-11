// See https://aka.ms/new-console-template for more information

namespace CheckPrime
{
    class Program
    {
        static List<int> primeList = new List<int>();

        public static void Main(string[] args)
        {
            int num;

REPEAT1:
            Console.Write("Enter an integer larger than 1 AND less than 2B. I will tell you if it is a prime -> ");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto REPEAT1;
            }
            if (num>2000000000)
            {
                Console.WriteLine("Number too large. It cannot exceed 2B");
                goto REPEAT1;   
            }
            if (num <= 1)
            {
                Console.WriteLine("Number has to be larger than 1!");
                goto REPEAT1;
            }

            if (num ==2)
            {
                Console.WriteLine(num + " is a prime.");
                goto REPEAT1;
            }

            if (num % 2==0)
            {
                Console.WriteLine(num + " is NOT a prime.");
                goto REPEAT1;
            }

            findAllPrimes(num);
            if (!checkIfPrime(num)) 
                Console.WriteLine(num + " is NOT a prime.");
            else Console.WriteLine(num + " is a prime.");

            goto REPEAT1;
        }

        static void findAllPrimes(int num)
        {
            primeList.Add(2);
            if (num == 2) return;

            for (int i = 3; i < num; i++)
            {

NEXT1:
                int count = primeList.Count;
                for (int index = 0; index < count-1; index++)
                {
                    if (i % primeList[index] == 0)
                    {
                        i++;
                        if (i > num) return;
                        goto NEXT1;
                    }
                }
                primeList.Add(i);
            }
        }

        static Boolean checkIfPrime(int num)
        {
            foreach (int j in primeList)
                if (num % j == 0) return false;
            return true;
        }
    }
}
