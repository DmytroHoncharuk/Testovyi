using System;
using testoveGit;

namespace StringWithWrongs
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("БД ім'я: ");
                string str1 = Console.ReadLine(); //БД ім'я
                Console.WriteLine("Значення з тесту: ");
                string str2 = Console.ReadLine();// значення з тесту
                Console.WriteLine("БД нік: ");
                string str3 = Console.ReadLine(); // БД нік
                Console.WriteLine("Тест нік: ");
                string str4 = Console.ReadLine(); // значення з тесту
                PersonDetection.DeleteAt(ref str4);
                bool isEqual = PersonDetection.CompareStrings(str3, str4, 0); // порівняння нікнейму
                if (isEqual)
                {
                    Console.WriteLine($"Порівняння нікнейму {isEqual}"); //якесь тіло умови
                }
                else
                {
                    Console.WriteLine("Порівняння за ім'ям");
                    isEqual = PersonDetection.CompareStrings(str1, str2, 1);//перевірка ім'я
                    Console.WriteLine($"Порівняння ім'я {isEqual}");
                }
            }

        }
 
    }
}
