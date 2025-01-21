using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp17
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("Enter shift: ");
            int shift = int.Parse(Console.ReadLine());

            string encrypted = CaesarCipher(text, shift);
            Console.WriteLine($"Encrypted: {encrypted}");
            Console.WriteLine($"Decrypted: {CaesarCipher(encrypted, -shift)}");
        }

        static string CaesarCipher(string text, int shift)
        {
            char[] result = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    c = (char)((c - baseChar + shift + 26) % 26 + baseChar);
                }
                result[i] = c;
            }
            return new string(result);
        }
    }
}
