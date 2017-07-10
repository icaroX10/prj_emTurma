using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmturmaConsole
{
    class Usuario
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }

        public Usuario()
        {

        }
        public Usuario(String nome, String email, String senha)
        {
            this.Id += 1;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
    }
}
