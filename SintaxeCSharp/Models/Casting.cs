using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class Casting
    {
        public void Executar()
        {
            // Casting Implícito (conversão automática)
            int numeroInteiro = 123456;
            double numeroDouble = numeroInteiro; // Conversão implícita de int para double
            Console.WriteLine($"Número Double (implícito): {numeroDouble}");

            // Casting Explícito
            double outroNumeroDouble = 123.45;
            int outroNumeroInteiro = (int)outroNumeroDouble; // Conversão explícita de double para int
            Console.WriteLine($"Número Inteiro (explícito): {outroNumeroInteiro}");

            // Usando Convert para conversão segura
            string numeroString = "789";
            int numeroConvertido = Convert.ToInt32(numeroString);
            Console.WriteLine($"Número Convertido: {numeroConvertido}");
        }
    }
    public class Conversao
    {
        public void Executar()
        {
            // Usando .ToString() para conversão
            int inteiro = 5;
            string inteiroString = inteiro.ToString();
            Console.WriteLine($"Inteiro para String: {inteiroString}");
    }
}
}


// Exemplos adicionais de conversão em C#:

// int a = Convert.ToInt32("123");
// Console.WriteLine(a);
// Resultado: 123 do tipo int
// Conver é uma classe e ToInt32 é um método estático dela que converte o valor passado como parâmetro para o tipo int.

// int b = int.Parse("456");
// Console.WriteLine(b);
// Resultado: 456 do tipo int
// Parse é um método estático da struct int que converte o valor passado como parâmetro

// De inteiro para Double (implícito) não precisa de conversão explícita
// int c = 789;
// double d = c;
// Console.WriteLine(d); pois um inteiro cabe dentro de um double. Assim como int cabe dentro de long, float cabe dentro de double, etc.