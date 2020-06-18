using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

            foreach (var item in numeros.Where(n => n %2 == 0))
            {
                Console.Write(item + ", ");
            }
        }
    }
}
