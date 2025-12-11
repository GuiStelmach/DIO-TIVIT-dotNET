using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public void Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return;
            }
            Console.WriteLine($"{a} / {b} = {a / b}");
        }

        public void Potencia(int a, int b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
        }

        public void RaizQuadrada(int a)
        {
            Console.WriteLine($"√{a} = {Math.Sqrt(a)}");
        }

        public void Porcentagem(int total, int porcentagem)
        {
            Console.WriteLine($"{porcentagem}% de {total} = {(total * porcentagem) / 100}");
        }

        public void Seno(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            double seno = Math.Sin(radianos);
            Console.WriteLine($"sen({angulo}) = {Math.Round(seno, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            double cosseno = Math.Cos(radianos);
            Console.WriteLine($"cos({angulo}) = {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            double tangente = Math.Tan(radianos);
            Console.WriteLine($"tan({angulo}) = {Math.Round(tangente, 4)}");
        }
    }
}