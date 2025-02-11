using System;

namespace Sum_Two_Num
{
    class Summation
    {
        static void Main(string[] args)
        {
            string str=""; 
            int num1, num2;
        REPEAT1:
            Console.Write("Enter the First Number: ");
            try
            { num1 = int.Parse(Console.ReadLine()); }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
                goto REPEAT1;
            }

REPEAT3:
            Console.Write("Enter the Second Number: ");
            try        
            { num2 = int.Parse(Console.ReadLine()); }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto REPEAT3;
            }

            int sum = num1 + num2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);

        REPEAT2:
            Console.Write("Enter 'c' to continue. 'f' to finish : ");
            str = string.Copy(Console.ReadLine().ToLower());
            
            switch(str)
            {
                case "c":
                    Console.WriteLine("");
                    goto REPEAT1;

                case "f": break;

                default:
                    Console.WriteLine("");
                    goto REPEAT2;
            }
        }
    }
}
