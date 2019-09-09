using System;
using ClassLibrary;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 == 0)
            {
                int s1 = 0;
                int s2 = 0;

                Console.WriteLine("What color is your shape?");
                string color = Console.ReadLine();

                Console.WriteLine("Is it a [R]ectange or [S]quare ?");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();
                if (input.Key.ToString().ToLower() == "r")
                    MakeRectangle(color, 0);
                if (input.Key.ToString().ToLower() == "s")
                    MakeSquare(color);
                        
            }
        }

        private static Square MakeSquare(string color)
        {
            int s1 = 0;
            Console.WriteLine("length of side 1?");
            try
            {
                s1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("not an integer");
                MakeSquare(color);
            }
            Square i = new Square(color, s1);            
            return i;
        }

        public static Rectangle MakeRectangle(string color, int s1)
        {
            int s2 = 0;
            if(s1 == 0)
            {
                Console.WriteLine("length of side 1?");
                try
                {
                    s1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("not an integer");
                    MakeRectangle(color, 0);
                }
            }
            Console.WriteLine("length of side 2?");
            try
            {
                s2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("not an integer");
                MakeRectangle(color, s1);
            }
            Console.Clear();

            Rectangle i = new Rectangle(color, s1, s2);
            return i;
        }
    }
}

