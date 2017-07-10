using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmturmaConsole
{
    class Turma
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Categoria { get; set; }
        public String NivelEscolar { get; set; }
        
        public Turma(String nome, String categoria, String NivelEscola)
        {
            this.Id += 1;
            this.Nome = nome;
            this.Categoria = categoria;
            this.NivelEscolar = NivelEscolar;
        }
    }
}
