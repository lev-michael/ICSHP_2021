using System;

namespace Fei
{
    namespace BaseLib
    {
    
        public class Reading
        {
            public static int ReadInt(String text)
            {
                int num;
                String input;
                Console.Write(text);
                input = Console.ReadLine();
                while (!Int32.TryParse(input, out num))
                {
                    Console.WriteLine("Wrong input. Try again");
                    Console.Write(text);
                    input = Console.ReadLine();
                }
                return num;
            }

            public static int ReadInt(int min, String text)
            {
                int num;
                String input;
                Console.Write(text);
                input = Console.ReadLine();
                while (!Int32.TryParse(input, out num) && num >= min)
                {
                    Console.WriteLine("Wrong input. Try again");
                    Console.Write(text);
                    input = Console.ReadLine();
                }
                return num;
            }

            public static char ReadChar(String text)
            {
                char character;
                String input;
                Console.Write(text);
                input = Console.ReadLine();
                while (!Char.TryParse(input, out character))
                {
                    Console.WriteLine("Wrong input. Try again");
                    Console.Write(text);
                    input = Console.ReadLine();
                }
                return character;
            }

            public static String ReadString(String text)
            {
                String input;
                Console.Write(text);
                input = Console.ReadLine();
                while (input.Length != 0)
                {
                    Console.WriteLine("Wrong input. Try again");
                    Console.Write(text);
                    input = Console.ReadLine();
                }
                return input;
            }

            public static double ReadDouble(String text)
            {
                double num;
                String input;
                Console.Write(text);
                input = Console.ReadLine();
                while (!Double.TryParse(input, out num))
                {
                    Console.WriteLine("Wrong input. Try again");
                    Console.Write(text);
                    input = Console.ReadLine();
                }
                return num;
            }
        }
    }
}


