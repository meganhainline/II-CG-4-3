using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter up to 30 names");
            var names = new string[30];
            var numberNamesEntered = 0;

            for (int i = 0; i <= 30; i++)
            {
                Console.Write("Please enter name #{0}: ", i + 1);
                var userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput)) break;
                names[i] = userInput;
                numberNamesEntered = i;
            }
            var rnd = new Random();
            var winner = rnd.Next(numberNamesEntered);

            Console.WriteLine("{0}Congratulations to {1}!! They won!", Environment.NewLine, names[winner]);
            Console.WriteLine("{0}The \"Better Luck Next Time\" award goes to: ", Environment.NewLine);

            for (int x = 0; x <= numberNamesEntered; x++)
            {
                if (x == winner) continue;
                Console.WriteLine(names[x]);
            }

            Console.ReadLine();
        }
    }

}
