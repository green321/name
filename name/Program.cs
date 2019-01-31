using System;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name");

            try
            {
                string input = Console.ReadLine();

                Console.WriteLine("Hello " + input);
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("please try again later ");
                Console.WriteLine("press any key to exit");
                Console.ReadKey(true);
            }
        }
    }
}
