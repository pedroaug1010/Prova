using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Program
    {
        static List<Menu> menus;
        private static object listaPessoas;

        static void Main(string[] args)
        {
            Console.Clear();

            Boolean continua = true;

            List<Menu> listaMenu = new List<Menu>();



            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Menu de cadastro");
                for (int i = 0; i < listaMenu.Count; i++)
                {
                    foreach (Menu p in listaMenu)
                    {
                        Console.WriteLine($"{i++} - {p.Nome} - {p.Id}");
                    }
                }
               
                Console.WriteLine(" 1 - Incluir");
                Console.WriteLine(" 2 - Alterar");
                Console.WriteLine(" 3 - Excluir");
                Console.WriteLine(" 4 - Listar");
                Console.WriteLine(" 5 - Pesquisar");
                Console.WriteLine(" 6 - Sair ");
                Console.WriteLine("Digite sua opção:");

                string opcao = Console.ReadLine();




                switch (opcao)
                {
                    case "1":

                        Console.WriteLine("Cadastro de pessoa");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Senha com numero: ");
                        int senha = Convert.ToInt32(Console.ReadLine());
                        Console.Write("id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Data de nascimento: ");
                        float data = Convert.ToSingle(Console.ReadLine());



                        listaMenu.Add(new Menu(nome, senha, id, data));
                        break;


                    case "2":
                        Console.WriteLine("Alterar");

                        //Qual registro deseja alterar - Ler o ID:
                        int alterarId = int.Parse(Console.ReadLine());
                        Menu alterar = listaMenu.Find(x => x.Id == alterarId);
                        Console.WriteLine("Indique o registro a ser alterado (Nome): ");
                        alterar.Nome = Console.ReadLine();
                        Console.WriteLine("Indique o registro a ser alterado (SENHA):");
                        //int alterarSenha = int.Parse(Console.ReadLine());
                        Console.WriteLine("Indique o registro a ser alterado (ID):");
                        //int alterarId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Indique o registro a ser alterado (DATA):");
                        //float alterarData = float.Parse(Console.ReadLine());





                        //Console.WriteLine("Indique o registro a ser alterado (Nome): ");
                        //string alterarNome = Console.ReadLine();
                        //Console.WriteLine("Indique o registro a ser alterado (SENHA):");
                        //int alterarSenha = int.Parse(Console.ReadLine());
                        //Console.WriteLine("Indique o registro a ser alterado (ID):");
                        //int alterarId = int.Parse(Console.ReadLine());
                        //Console.WriteLine("Indique o registro a ser alterado (DATA):");
                        //float alterarData = float.Parse(Console.ReadLine());
                        //Menu alterar = listaMenu.Find(x => x.Nome == alterarNome);


                        //if (alterarNome != null)
                        //{
                        //    Console.Write("Informe o novo Nome: ");
                        //    string novoNome = Console.ReadLine();
                        //    alterar.alteraNome(novoNome);
                        //    Console.WriteLine("Nome atualizado: " + novoNome);


                        //}
                        //if (alterarSenha != null)
                        //{
                        //    Console.Write("Informe o nova Senha: ");
                        //    int novaSenha = int.Parse(Console.ReadLine());
                        //    alterar.alterarSenha(novaSenha);
                        //    Console.WriteLine("SENHA atualizado: " + novaSenha);
                        //}
                        //if (alterarId != null)
                        //{
                        //    Console.Write("Informe o nova ID: ");
                        //    int novoId = int.Parse(Console.ReadLine());
                        //    alterar.alterarId(novoId);
                        //    Console.WriteLine("ID atualizado: " + novoId);
                        //}
                        //if (alterarData != null)
                        //{
                        //    Console.Write("Informe o nova Data: ");
                        //    float novaData = float.Parse(Console.ReadLine());
                        //    alterar.alterarData(novaData);
                        //    Console.WriteLine("DATA atualizado: " + novaData);
                        //}
                        //else
                        //{
                        //    Console.WriteLine(" ¨¨Registro não existe¨¨ ");
                        //}


                        break;
                    case "3":
                        Console.WriteLine("\n Excluir \n");
                        for (int i = 1; i < listaMenu.Count; i++)
                        {
                            foreach (Menu pessoa in listaMenu)
                            {
                                Console.WriteLine($"{i++} {pessoa.Nome}");
                            }
                        }
                        Console.WriteLine("--------------------------------------------------------------------------\n");
                        Console.WriteLine("Digite o ID do Usuário à ser excuido\n (posição do usuário)");
                        int userDel = Int32.Parse(Console.ReadLine());
                        userDel--;

                        Console.WriteLine("Deseja realmente excluir esse cadastro?\n  (Sim) - (Nao)");
                        string excluir = Console.ReadLine();
                        excluir = excluir.ToUpper();

                        if (excluir == "Sim")
                        {
                            if (userDel <= listaMenu.Count)
                            {
                                listaMenu.RemoveAt(userDel);
                            }
                            else
                            {
                                Console.WriteLine("Usuário não encontrado na lista.");
                            }
                        }


                        break;
                    case "4":
                        Console.WriteLine("Listar");
                        Console.WriteLine("Ordem - Nome. - Senha  - Id - Data \n");

                        for (float i = 0; i < listaMenu.Count; i++)
                        {
                            foreach (Menu p in listaMenu)
                            {
                                Console.WriteLine($"{i++} - {p.Nome} - {p.Senha} - {p.Id}");
                            }
                        }

                      

                        break;
                    case "5":
                        Console.WriteLine("\n Pesquisar");
                        Console.WriteLine("Digite o Nome do usuário");
                        string receber = Console.ReadLine();
                        receber = receber.ToUpper();
                        Menu Pesquisar = listaMenu.Find(x => x.Nome == receber);
                        if (Pesquisar.Nome == "Nome")
                        {
                            Pesquisar.Nome = "Nome";
                        }
                        else if (continua)
                        {
                            Console.WriteLine("Usuário não encontrado.");
                        }
                        Console.WriteLine($"\nNome: {Pesquisar.Nome}");
                        Console.WriteLine($"Id: {Pesquisar.Id}");
                        Console.WriteLine($"Senha: {Pesquisar.Senha}");
                        Console.WriteLine($"Data: {Pesquisar.Data}");
                        break;
                    case "6":
                        Console.WriteLine("Sair");

                        continua = false;
                        break;


                    default:
                        Console.WriteLine("opcão nao existe.");
                        break;


                }

            }

            while (continua);

        }
    }
}