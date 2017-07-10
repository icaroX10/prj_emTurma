using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmturmaConsole
{
    class TurmaController
    {
        List<Turma> turma1 = new List<Turma>();

        public bool BuscarTurma(String turma)
        {
            //Any usada para varrer a lista "turma1" pra encontrar uma turma com o mesmo nome
            if (turma1.Any(t => t.Nome == turma))
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void CadastrarTurma(String nome, String categoria, String nivelEscolar)
        {
            //Preciso negar o resultado da busca, ja q ela ta retornando true quando encontra
            //uma turma com o nome, ai se a função buscar retornar false, no if ele vai 
            //negar o resultado o transformando em true, permitindo criar a turma
            if (!BuscarTurma(nome))
            {
                Turma add = new Turma(nome, categoria, nivelEscolar);
                turma1.Add(add);
                Console.WriteLine("Turma Cadastrada!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Turma Ja Existe!");
                Console.ReadLine();
            }
        }
    }
}
