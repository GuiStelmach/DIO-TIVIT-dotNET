using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class RepeticaoComFor
    {
        public void Multiplicar(int numero)
        {
            for (int contador = 0; contador <= 10; contador++)
            {
                int resultado = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {resultado}");
            }
        }

        public void Subtrair(int numero)
        {
            for (int contador = 0; contador <= 10; contador++)
            {
                int resultado = numero - contador;
                Console.WriteLine($"{numero} - {contador} = {resultado}");
            }
        }
        public void Somar(int numero)
        {
            for (int contador = 0; contador <= 10; contador++)
            {
                int resultado = numero + contador;
                Console.WriteLine($"{numero} + {contador} = {resultado}");
            }
        }
        public void Dividir(int numero)
        {
            for (int contador = 1; contador <= 10; contador++)
            {
                double resultado = (double)numero / contador;
                Console.WriteLine($"{numero} / {contador} = {Math.Round(resultado, 2)}");
            }
        }
    }
}