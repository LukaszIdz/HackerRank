using System;


namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            uint testNumber = Convert.ToUInt16(Console.ReadLine());
            string[] resultsArray = new string[testNumber];

            for (int i = 0; i < testNumber; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');
                uint studentNumber = Convert.ToUInt16(input[0]);
                uint minStudents = Convert.ToUInt16(input[1]);
                input = Console.ReadLine().Split(' ');
                uint currentPresent = 0;

                for (int j = 0; j < studentNumber; ++j)
                {
                    if (Convert.ToInt16(input[j]) <= 0) ++currentPresent;
                }

                if (currentPresent < minStudents) resultsArray[i] = "YES";
                else resultsArray[i] = "NO";

            }

            foreach(string result in resultsArray)
            {
                Console.WriteLine(result);
            }
        }
    }
}
