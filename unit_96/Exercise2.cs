using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_96
{
    internal class Exercise2 : IExercise
    {
        enum SortType
        {
            Ascending = 1,
            Descending = -1,
        }

        public void Run()
        {
            string[] arrayForSort = { "Кузьмин С.Д.", "Сидоров А.Б.", "Иванов И.И.", "Абрамов И.Н.", "Иванов А.И." };
            SortType sortType = SortType.Ascending;
            Action<string[], SortType> SortAction = Sorting;
            ConsoleKey key;

            Console.WriteLine("Задание 2:");
            Console.WriteLine("Несортированный массив:");
            Console.WriteLine(string.Join("\n", arrayForSort));
            Console.WriteLine("Выберите тип сортировки (1 - А-Я, 2 - Я-А Enter - выход)");

            while ((key = Console.ReadKey().Key) != ConsoleKey.Enter)
            {
                if (key == ConsoleKey.D1) sortType = SortType.Ascending;
                else if (key == ConsoleKey.D2) sortType = SortType.Descending;
                else continue;
                SortAction?.Invoke(arrayForSort, sortType);
                Console.WriteLine("\nСортировка {0}:", sortType == SortType.Ascending ? "А-Я" : "Я-А");
                Console.WriteLine(string.Join("\n", arrayForSort));
            }
        }

        void Sorting(string[] mass, SortType type)
        {
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    var compare = mass[i].CompareTo(mass[j]);
                    if (compare == (int)type)
                    {
                        var temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
        }
    }
}
