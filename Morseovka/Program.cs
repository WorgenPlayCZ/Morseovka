using System;

namespace Morseovka
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--.."};
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("Zadejte zprávu k zakódování:");
            string messege = Console.ReadLine().ToLower();
            string code= "";

            foreach (char letter in messege)
            {
                int index = Array.IndexOf(abecedniZnaky.ToCharArray(), letter);
                //                               Console.WriteLine("{0}",index) ;
                if (index >= 0)
                {
                    code += morseovyZnaky[index];
                    code += " ";
                }
                else
                {
                    code += " | ";
                }
            }

            Console.Write("Zakódovaná zpráva: {0}", code);
            string decode = "";
            string[] symbol = code.Split(' ');
            foreach(string S in symbol)
            {
                char Y = '?';
                int index = Array.IndexOf(morseovyZnaky, S);
                if (index>=0)
                {
                    Y = abecedniZnaky[index];
                    decode += Y;
                }
                else
                {
                    decode += " ";
                }
            }
            Console.WriteLine();
            Console.WriteLine("dekodovana zpráva: " + decode);
            Console.ReadKey();
        }
    }
}
