using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class Estoque
    {
        public string Produto { get; set; } = string.Empty;
        public double Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public bool ConsultarEstoque(int quantidade)
        {
            //Utilizando variável booleana para consulta de estoque
            return QuantidadeDisponivel >= quantidade  && quantidade > 0;
        }

        //Utilizando if/else para comprar a quantidade desejada do produto
        public void ComprarProduto(int quantidade)
        {
            
            bool consulta = ConsultarEstoque(quantidade);
            //Utilizando variavel booleana em estrutura condicional if/else
            if (consulta)
            {
                double total = quantidade * Preco;
                QuantidadeDisponivel -= quantidade;
                Console.WriteLine($"Compra realizada: {quantidade} unidades de {Produto} por R${total:F2}");
            }
            else
            {
                Console.WriteLine("Estoque insuficiente ou quantidade inválida.");
            }
        }
    }
}