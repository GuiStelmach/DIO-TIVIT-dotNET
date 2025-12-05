using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Trecho criado para exercitar a criação de classes e métodos.
// Ciente de que em um cenário real, a validação de login envolveria práticas mais seguras.

namespace SintaxeCSharp.Models
{
    public class Login
    {
        public string Usuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        public bool ValidarLogin()
        {
            return Usuario == "admin" && Senha == "123";
        }

        public void Conectar()
        {
            if (ValidarLogin())
            {
                Console.WriteLine("Login bem-sucedido!");
            }
            else
            {
                Console.WriteLine("Falha no login. Usuário ou senha incorretos.");
            }
        }
    }
}