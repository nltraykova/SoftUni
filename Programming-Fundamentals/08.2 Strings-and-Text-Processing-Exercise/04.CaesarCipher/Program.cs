using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            StringBuilder encryptedMessage = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                char currChar = message[i];
                
                char encryptedChar = (char)(currChar + 3);
                
                encryptedMessage.Append(encryptedChar);
            }

            Console.WriteLine(encryptedMessage);

        }
    }
}
