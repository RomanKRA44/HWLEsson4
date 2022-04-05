using System;

namespace HWLEsson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Вишневский", "Роман", "Петрович"));
            Console.WriteLine(GetFullName("Есина", "Алена", "Ивановна"));
            Console.WriteLine(GetFullName("Смирнова", "Илона", "Владимировна"));
            Console.WriteLine(GetFullName("Смирнов", "Иван", "Иваныч"));
        }

        static string GetFullName(string lastName, string firstName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
    }
}
