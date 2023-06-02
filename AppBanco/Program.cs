
using bDAO;
using bModel;
using System;
using System.Collections.Generic;

namespace AppBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UsuarioDAO ObjDAO = new UsuarioDAO();
            Usuario objUsuario = new Usuario();
            List<Usuario> listUsuario = new List<Usuario>();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Informe o Id para identificação:");
            Console.ResetColor();

            objUsuario.IdUsu = int.Parse(Console.ReadLine());
            Console.Clear();
            var strDado = ObjDAO.SeletcScalar(objUsuario.IdUsu);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Olá senhor(a)," + strDado + " escolha uma opção do menu.\r\n");
            Console.ResetColor();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }


            bool MainMenu()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗    ");
                Console.WriteLine("║                                               ║    ");
                Console.WriteLine("║        1. CADASTRAR USUÁRIO                   ║    ");
                Console.WriteLine("║        2. ATUALIZAR CADASTRO DO USUÁRIO       ║    ");
                Console.WriteLine("║        3. APAGAR REGISTROS DO USUÁRIO         ║    ");
                Console.WriteLine("║        4. LISTAR TODOS OS USUÁRIOS            ║    ");
                Console.WriteLine("║        5. SAIR                                ║    ");
                Console.WriteLine("║                                               ║    ");
                Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                Console.WriteLine("\r\nDIGITE UMA OPÇÃO :");
                Console.ResetColor();


                //PARTE 1
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Insira um novo registro:\r\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Digite o nome:");
                        Console.ResetColor();
                        objUsuario.NomeUsu = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Digite o cargo:");
                        Console.ResetColor();
                        objUsuario.Cargo = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Informe a data de nascimento:");
                        Console.ResetColor();
                        objUsuario.DataNac = DateTime.Parse(Console.ReadLine());

                        ObjDAO.Insert(objUsuario);

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\r\nUsuários cadastrados\r\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        listUsuario = list(ObjDAO);

                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\r\nPrescione uma tecla para retornar ao menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();
                        return true;

                    //PARTE 2
                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\r\nUsuários cadastrados\r\n");
                        listUsuario = list(ObjDAO);

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\r\nAtualize o registro:\r\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Digite o nome:");
                        Console.ResetColor();
                        objUsuario.NomeUsu = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Digite o cargo:");
                        Console.ResetColor();
                        objUsuario.Cargo = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Informe a data de nascimento:");
                        Console.ResetColor();
                        objUsuario.DataNac = DateTime.Parse(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Digite o Id");
                        Console.ResetColor();
                        objUsuario.IdUsu = int.Parse(Console.ReadLine());

                        ObjDAO.UpDate(objUsuario);

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\r\nUsuários cadastrados\r\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        listUsuario = list(ObjDAO);

                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\r\nPrescione uma tecla para retornar ao menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();

                        return true;

                    //PARTE 3
                    case "3":

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\r\nUsuários cadastrados\r\n");
                        listUsuario = list(ObjDAO);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\r\nApagango um registro:\r\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Digite o Id do registro a ser apagado:");
                        Console.ResetColor();
                        int Id = int.Parse(Console.ReadLine());
                        ObjDAO.Delete(Id);

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\r\nUsuários cadastrados\r\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        listUsuario = list(ObjDAO);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\r\nPrescione uma tecla para retornar ao menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();


                        return true;

                    //PARTE 4
                    case "4":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\r\nUsuários cadastrados\r\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        listUsuario = list(ObjDAO);


                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\r\nPrescione uma tecla para retornar ao menu");
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();

                        return true;

                    //PARTE 5
                    case "5":
                        return false;

                    //PARTE 6
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Prescione o enter e escolha uma das opções: 1, 2, 3 ou 4.");
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.Clear();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Usuário: " + strDado + "\r\n");
                        Console.ResetColor();

                        ;
                        return true;
                }
            }
        }

        private static List<Usuario> list(UsuarioDAO ObjDAO)
        {
            List<Usuario> listUsuario = ObjDAO.SelectList();

            foreach (var item in listUsuario)
            {
                Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
                Console.WriteLine("Codigo = {0} | Nome {1} | Cargo {2} | Nascimento {3}",
                item.IdUsu, item.NomeUsu, item.Cargo, item.DataNac);
                Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            }

            return listUsuario;
        }
    }
}
