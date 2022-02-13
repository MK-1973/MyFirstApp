using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            String Name = Console.ReadLine();
            Console.WriteLine("Ваш возраст:");
            String strAge = Console.ReadLine();
            Console.WriteLine("Ваш город:");
            String City = Console.ReadLine();
            Console.WriteLine("Ваше хобби:");
            String Hobby = Console.ReadLine();
            int ost = Convert.ToInt32(strAge) % 10;
            string suff = "лет";
            if (ost == 1)
            {
                suff = "год";
            }
            if (ost > 1 && ost < 5)
            {
                suff = "года";
            }
            Console.WriteLine($"Итак, вы - {Name}, вам {strAge} {suff}. Проживаете в городе {City}. Ваше увлечение - {Hobby}.");
            Console.ReadLine();
        }
    }
}
