using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class TiposVariaveis
    {
        public string apresentacao { get; set; } = string.Empty;
        public int quantidade { get; set; }
        public double altura { get; set; }
        public decimal preco { get; set; }
        public bool condicao = true;
        public DateTime dataAtual { get; set; }

        public void ExibirTiposVariaveis()
        {
            Console.WriteLine($"Tipo String: {apresentacao}");
            Console.WriteLine($"Tipo Inteiro: {quantidade}");
            //Double corta a ultima casa decimal quando é zero, precisa tratar com "ToString"
            Console.WriteLine($"Tipo Double: {altura.ToString("0.00")}");
            Console.WriteLine($"Tipo Decimal: {preco}");
            Console.WriteLine($"Tipo Booleano: {condicao}");
            Console.WriteLine($"Tipo Data: {dataAtual}");
        }
    }
}