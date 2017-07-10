using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmturmaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> user = new List<Usuario>();
            UsuarioController ust = new UsuarioController();
            ust.CadastrarUser("teste", "teste", "teste");
            ust.CadastrarUser("teste1", "oi", "oi");
            ust.CadastrarUser("testa", "testando", "test");
            ust.CadastrarUser("teste0", "oi", "teste0");
            if (ust.EfetuarLogin("teste", "teste"))
            {
                Console.WriteLine("Usuario Logado");
            }else
            {
                Console.WriteLine("Usuario não Cadastrado");
            }


            ust.ExibirList();
            ust.EditUsuario(1);
            Console.WriteLine("==========================");
            ust.ExibirList();
            ust.RemoveUsuario(1);
            Console.WriteLine("==========================");
            ust.ExibirList();



            TurmaController turma2 = new TurmaController();
            turma2.CadastrarTurma("Turma1", "Programação", "Ensino Medio");
            if (turma2.BuscarTurma("Turma1"))
            {
                Console.WriteLine("Turma Encontrada");
            }else
            {
                Console.WriteLine("Turma não encontrado!");
            }
            Console.ReadLine();
        }
    }
}
