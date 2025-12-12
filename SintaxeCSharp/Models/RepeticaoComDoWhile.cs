using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class RepeticaoComDoWhile
    {
        public void Executar()
        {
            int soma = 0, numero = 0;

            do
            {
                Console.WriteLine("Digite um número (0 para sair): ");
                numero = Convert.ToInt32(Console.ReadLine());
                soma += numero;

            } while (numero != 0);
            
            Console.WriteLine($"A soma dos números digitados é: {soma}");
        }
    }
}