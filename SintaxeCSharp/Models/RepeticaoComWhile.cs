using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class RepeticaoComWhile
    {
        public void Executar(int contmax)
        {
            int contador = 0;

            while (contador <= contmax)
            {
                Console.WriteLine($"Contador é igual a {contador}");
                contador++;
                
                // Exemplo de uso do break para sair do loop antes do final
                if (contador == contmax / 2)
                {
                    break;
                }
            }
        }
    }
}