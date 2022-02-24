using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_96
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var exercise in new IExercise[] { new Exercise1(), new Exercise2() })
            {
                exercise.Run();
                Console.WriteLine();
            }
        }
    }
}
