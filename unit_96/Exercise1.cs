using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_96
{
    internal class Exercise1 : IExercise
    {
        public void Run()
        {
            Console.WriteLine("Задание 1:");

            var exceptions = new Exception[] 
            { 
                new DivideByZeroException(), 
                new IndexOutOfRangeException(), 
                new KeyNotFoundException(), 
                new ArgumentNullException(), 
                new ByteConverterException("Значение не входит в диапазон типа byte.") 
            };
            foreach (var e in exceptions)
            {
                try
                {
                    throw e;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    internal class ByteConverterException : Exception
    {
        public ByteConverterException(string message) : base(message)
        { }
    }
}
