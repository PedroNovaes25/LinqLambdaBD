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
            //LinqLambdaNumeros();
            LinqLambdaCores();
        }

        public static void LinqLambdaNumeros() 
        {
            int[] numeros = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] numeros2 = { 1, 5, 10, 6, 2, 7, 3, 8, 4, 9 };


            #region  #SELECT
            var resultado = from num in numeros2
                            where num % 2 == 0
                            orderby num
                            select num; //ESTE COMANDO FAZ A MESMA COISA QUE a expressão lambda ABAIXO EM UM COMANDO SQL

            Console.Write("\nselect: ");
            foreach (var item in resultado)
            {
                Console.Write(item + ", ");
            }
            #endregion

            #region #LINQLAMBDA
            var resultadoLamb = numeros.Where(n => n % 2 == 0); //Pode ser colocado diretamente no forech //crescente
            var resultadoLamb2 = numeros.Where(n => n % 2 == 0).OrderByDescending(x => x); //decrescente

            Console.Write("\nLinq: ");
            foreach (var item in resultadoLamb2)
            {
                Console.Write(item + ", ");
            }
            #endregion
        }
        public static void LinqLambdaCores() 
        {
            string[] cores = { "AZUL", "PRETO", "VERMELHO", "MARROM", "BEJE", "CINZA" };

            var resultado = cores.Where(c => c.Contains("E"));
            foreach (var item in resultado)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
