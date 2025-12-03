using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    // PascalCase padráo para Classes, Propriedades e Métodos.
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        //Nunca abreviar nomes de classes, variáveis, propriedades ou métodos.
        public string NomeRepresentanteLegal { get; set; } = string.Empty;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}