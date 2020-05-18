using System;

namespace caesar
{
    class Program
    {
        static void Caesar(string s)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                                'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] s1 = s.ToCharArray();

            char[] result = new char[s1.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                char item1 = s1[i];

                int index = Array.IndexOf(alphabet, item1);
                int position = (index + 3) % 26;

                result[i] = alphabet[position]; 
            }

            Console.Write("Result: ");
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input sentence: ");
            string s = Console.ReadLine();

            Caesar(s);
        }
    }
}
