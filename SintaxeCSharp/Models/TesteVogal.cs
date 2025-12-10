using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class TesteVogal
    {
        public string Letra { get; set; } = string.Empty;

        public void EhVogal()
        {
            switch (Letra.ToLower())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine($"{Letra} é uma vogal.");
                    break;
                default:
                    Console.WriteLine($"{Letra} não é uma vogal.");
                    break;
            }
        }

    };
}