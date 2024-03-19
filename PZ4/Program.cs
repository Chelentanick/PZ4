using System;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
namespace PZ4
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            /*          int[] numbers = new int[50];
                        int i = 0;
                        foreach (int number in numbers) 
                        {
                            i += 2;
                            numbers[number] = i;
                            Console.WriteLine($"Element: {numbers[number]}");
                        }
           ______________________________________________________________
            Random rand = new Random();
            const int VALUE = 40;
            int[] numbers = new int[VALUE];
            int counter = 0;
            for (int i = 0; i < 40; i++)
            {
                int randomNumber = rand.Next(0, 101);
                numbers[i] = randomNumber;

            }
            Console.Write($"Pair numbers in array are: \n");
            foreach (int number in numbers)
            {
                
                if (number % 2 == 0 && number != 0)
                {
                    counter++;
                    Console.Write($"{number}, ");


                }
               
            }
            Console.WriteLine($"\nArrays include {counter} pair numbers");
            _____________________________________________________________
           
            int counterOfSymbol = 0;
            int counter = 0;

            Console.WriteLine("Write your text: ");
            string text = Console.ReadLine();

            Console.WriteLine($"Write text: {text}");
            Console.WriteLine("Which symbol we will count?");

            char symbol = char.Parse(Console.ReadLine());
            symbol = char.ToLower(symbol);
            string lowText = (text).ToLower();
            foreach (char character in lowText)
            {
                if (character == symbol)
                {
                    counterOfSymbol++;
                }
                counter++;

            }
            Console.WriteLine($"Text '{text}' include {counter} symbols ");
            Console.WriteLine($"Number of this symbol '{symbol}' is {counterOfSymbol}");
            _____________________________________________________________
           */

            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char) ('a' + i);
                
            }
            foreach (char symbol in alphabet)
            {
                Console.WriteLine($"Letter: {symbol};    In ASCII: {(int)symbol}");
            }
             
        }

    }

}