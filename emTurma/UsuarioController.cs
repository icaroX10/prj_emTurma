using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmturmaConsole;
namespace EmturmaConsole
{
    class UsuarioController
    {
        //Crio a lista onde vai ser armazenado os cadastro..
        List<Usuario> user = new List<Usuario>();
        //Função de Verificação do email,
        public bool VerificaEmail(String email)
        {
            //A função é Any é para procurar ne uma lista, e ela retorna True ou  False
            //Usei a ! para negar oque ele encontrar.. Ou seja, se ela encontrar um email, ele
            //vai negar, fazendo com que entre no Else
            if(!user.Any(n => n.Email == email))
            {
                return true;
            }
            else{
                return false;

            }
        }

        public void CadastrarUser(String nome, String email, String senha)
        {
            //antes de cadastrar verifico se ja existe algum usuario com aquele email
            //como eu neguei na função acima.. ele so vai retorna True se não achar um email
            if (VerificaEmail(email))
            {
                //Crio um objeto com os parametros que foi passado na função
                Usuario adc = new Usuario(nome,email,senha);
                //Adiciono na lista Criado la em cima
                user.Add(adc);
                Console.WriteLine("Usuario Cadastrado!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Usuario Ja Existe!");
                Console.ReadLine();
            }
        }
        public bool EfetuarLogin(String email, String senha)
        {
            //Uso a função Any com o "& = And" pra procurar tanto email quanto senha
            //Ele so vai retorna True se encontrar um usuario que tenha email e senha iguais
            if (user.Any(n => n.Email == email & n.Senha == senha))
            {
                return true;
            }else
            {
                return false;
            }
            
        }
        public void EditUsuario(int id)
        {
            //A função Any é usada aqui pra encontrar o usuario com o ID que foi passado
            //Se encontrar ele vai permitir que possa editar o usuario... 
            //passando o id dele no user.. "user[id]
            if (user.Any(n => n.Id == id))
            {
                Console.WriteLine("Digite o novo Nome:");
                user[id].Nome = Console.ReadLine();
                Console.WriteLine("Digite o novo Email:");
                String email = Console.ReadLine();
                //Vai verificar pra ver se o email q foi digitado ja existe
                if (!VerificaEmail(email))
                {
                    //Caso o email que ele digitou ja exista ele entra ne um while 
                    //onde nega o resultado da função. Ou seja, a função VerificarEmail ela 
                    //por si só ja nega o resultado, mais como eu quero que o while continue
                    //enquanto estiver false , precisei negar o resultado da função

                    while (!VerificaEmail(email))
                    {
                        Console.WriteLine("Digite denovo o Email:");
                        email = Console.ReadLine();
                    }
                    user[id].Email = email;
                }else
                {
                    user[id].Email = email;
                }          
                Console.WriteLine("Digite o novo Senha:");
                user[id].Senha = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Usuario não Encontrado");
            }
        }

        public void RemoveUsuario(int id)
        {
            //A função Any é usada aqui pra encontrar o usuario com o ID que foi passado
            //Se encontrar ele vai Remover o usuario... 
            if (user.Any(n => n.Id == id))
            {
                user.RemoveAt(id);
            }
            else
            {
                Console.WriteLine("Usuario não Encontrado");
            }

        }
        public void ExibirList()
        {
            //Como a lista esta contida nessa classe, eu preciso de uma função nela pra poder
            //exibir oq ta contido na lista..
            foreach (Usuario item in user)
            {
                Console.WriteLine("Nome: " + item.Nome + " Email: " + item.Email + " Senha: " + item.Senha);
            }
        }

    }
}
