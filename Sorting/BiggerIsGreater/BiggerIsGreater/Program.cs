using System;
using System.Text;
using System.Linq;

namespace BiggerIsGreater
{
    static class Program
    {
        public static string SwapInString(string str, int pos1, int pos2)
        {
            StringBuilder stringBuilder = new StringBuilder(str);
            char temp = stringBuilder[pos1];
            stringBuilder[pos1] = stringBuilder[pos2];
            stringBuilder[pos2] = temp;
            return stringBuilder.ToString();
        }

        public static int EvalPower(string word)
        {
            int sum = 0;
            for(int i = 0; i < word.Length; i++)
            {
                sum += (word.Length - i) * word[i];
            }
            return sum;
        }

        public static bool IsGreaterThan(this string word1, string word2)
        {
            int powerWord1 = EvalPower(word1);
            int powerWord2 = EvalPower(word2);

            if (powerWord1 > powerWord2) return true;
            return false;
        }

        public static void ReturnGreater(string word)
        {
            string sortWord = String.Concat(word.OrderBy(c => c));
            bool foundGreater = false;
            string greaterWord = null;
            


            if(!foundGreater) Console.WriteLine("no answer");

        }

        static void Main(string[] args)
        {
            Console.WriteLine(EvalPower("hefg"));
            int t = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[t];

            for(int i = 0; i < t; i++)
            {
                arr[i] = Console.ReadLine();
            }

            for(int i = 0; i < t; i++)
            {
                ReturnGreater(arr[i]);
            }

            Console.ReadKey();

        }
    }
}
