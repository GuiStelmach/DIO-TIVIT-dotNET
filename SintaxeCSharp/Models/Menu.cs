using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class Menu
    {
        public string Opcao { get; set; } = string.Empty;
        public bool menuOn = true;

        public void ExibirMenu()
        {
            while (menuOn)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Opção 1");
                Console.WriteLine("2 - Opção 2");
                Console.WriteLine("3 - Sair");
                Opcao = Console.ReadLine() ?? string.Empty;

                switch (Opcao)
                {
                    case "1":
                        Console.WriteLine("Você selecionou a Opção 1.");
                        break;
                    case "2":
                        Console.WriteLine("Você selecionou a Opção 2.");
                        break;
                    case "3":
                        Console.WriteLine("Você selecionou a opção Sair.");
                        menuOn = false;
                        // Environment.Exit(0); Finaliza toda a aplicação
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}