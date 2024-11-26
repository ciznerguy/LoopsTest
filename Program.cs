using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LoopsTest
{
    internal class Program
    {
    //תבנית מציאת מקסימום
         
        public static void FindMaxTen() 
        {
        int max = int.MinValue;
         for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
        public static void Ex4032() 
        {
            Random rnd = new Random();
            int num;
            int max = int.MinValue, min = int.MaxValue;
            for (int i = 0; i < 10; i++) 
            {
             num =rnd.Next(1, 101);
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"max is {max} mim is {min}");

        }
        // תבנית סכום

        // יש לכתוב תכנית הקולטת 10 מספרים
        // מחשבת ומדפיסה את סכומם
        public static void SumOf10() 
        {
            int sum=0;
            for(int i =0; i<10; i++)
            {
                Console.WriteLine("enter number");
                int num = int.Parse(Console.ReadLine());
                sum += num;//sum = sum +num


            }
            Console.WriteLine(sum);
        }




        // יש לכתוב תכנית המחשבת את סכום
        // המספרים הזוגיים
        public static void SumOfEven()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter number");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    sum += num;
                }//sum = sum +num



            }
            Console.WriteLine(sum);
        }
        // תבנית מציאת מקסימום
        // יש לכתוב תכנית הקולטת מספרים 
        // עד שנקלט אפס ומחשבת את סכומם

       public static void SumOfNumbers() 
        {
            int sum = 0;
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            while (num != 0) 
            {
                sum += num;
                Console.WriteLine("enter number");
                 num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(sum);
        }
        // כנ"ל רק סכום הזוגיים


        
        static void Main(string[] args)
        {
            SumOfNumbers();
        }
    }
}
