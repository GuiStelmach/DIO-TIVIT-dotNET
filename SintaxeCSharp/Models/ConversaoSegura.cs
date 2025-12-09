using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeCSharp.Models
{
    public class ConversaoSegura
    {
        string valorString = "15.5";
        public void Converter()
        {
            // Conversão segura usando TryParse
            bool sucesso = int.TryParse(valorString, out int valorDouble);
            if (sucesso)
            {
                Console.WriteLine($"Conversão bem-sucedida: {valorDouble}");
            }
            else
            {
                Console.WriteLine("Falha na conversão.");
            }
        }
    }
}

// O TryParse tenta converter o valor e retorna um booleano indicando sucesso ou falha, evitando exceções em tempo de execução.