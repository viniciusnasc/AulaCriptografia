using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLogin.Entitie
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public LoginDto(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
