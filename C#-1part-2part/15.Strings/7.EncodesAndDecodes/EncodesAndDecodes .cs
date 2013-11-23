// 7. Write a program that encodes and decodes a string using given encryption key (cipher). The key consists
// of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over 
// the first letter of the string with the first of the key, the second – with the second, etc.
// When the last key character is reached, the next is the first.

using System;
using System.Text;


    class Program
    {
        static void Main()
        {
            string text = "Rabbits are small mammals in the family Leporidae of the order Lagomorpha, found in several parts of the world. There are eight different genera in the family classified as rabbits, including the European rabbit (Oryctolagus cuniculus), cottontail rabbits (genus Sylvilagus; 13 species), and the Amami rabbit (Pentalagus furnessi, an endangered species on Amami Ōshima, Japan).";
            string key = "bunny";

            Console.WriteLine(Encryption(text,key));
            Console.WriteLine();
            Console.WriteLine(Decryption((Encryption(text, key)),key));
        }

        static string Encryption(string text, string key)
        {
            StringBuilder result = new StringBuilder(text.Length);
            StringBuilder newKey = new StringBuilder(text.Length);

            //Make ney key with length as text length
            for (int i = 0; i < text.Length/key.Length; i++)
            {
                newKey.Append(key);
            }
            for (int i = 0; i < text.Length % key.Length; i++)
            {
                newKey.Append(key[i]);
            }

            for (int i = 0; i < text.Length; i++)
            {
                result.Append((char)(text[i] ^ newKey[i]));
            }
            text = result.ToString();

            return text;
        }

        static string Decryption(string text, string key)
        {
            return Encryption(text, key);
        }
    }

