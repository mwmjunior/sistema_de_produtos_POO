using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace projeto_de_produtos
{


    public class Login
    {

        public bool Logado { get; set; }

        public Login()
        {

            ValidarAcesso();


            if (Logado == true)
            {

                GerarMenuOpcao();

            }
        }


        public string ValidarAcesso()
        {
            string usuarioValido = "MARCIO";
            string senhaValida = "123456";
            bool loginValido = false;

            Console.Write("Digite seu usuário: ");
            string usuario = (Console.ReadLine()).ToUpper();

            while (usuario != usuarioValido)
            {
                Console.Clear();
                Console.WriteLine(@$"                      ACESSO  NEGADO !                                      ");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine(@"       Erro: O nome de usuário digitado está incorreto.Tente novamente");
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.Write("Digite seu usuário: ");
                usuario = (Console.ReadLine()).ToUpper();
            }


            Console.WriteLine();

            do
            {

                string senha = "";
                Console.Write("Digite sua senha de 6 caracteres: ");
                ConsoleKeyInfo keyInfo;

                do
                {
                    keyInfo = Console.ReadKey(true);
                    // Skip if Backspace or Enter is Pressed
                    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                    {
                        senha += keyInfo.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (keyInfo.Key == ConsoleKey.Backspace && senha.Length > 0)
                        {
                            // Remove last charcter if Backspace is Pressed
                            senha = senha.Substring(0, (senha.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
                // Stops Getting Password Once Enter is Pressed
                while (keyInfo.Key != ConsoleKey.Enter);



                if (senha == senhaValida)
                {
                    loginValido = true;
                    Logado = true;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(@$"                      ACESSO  NEGADO !                                      ");
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine(@"           Erro: A senha digitada está incorreta.Tente novamente");
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }


            } while (loginValido == false);


            return "";

        }



        public void GerarMenuOpcao()

        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            bool encerrarPrograma = false;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
BEM VINDO 
=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
|---------------------------------------------------------------|
|                 ESCOLHA UMA OPÇÃO ABAIXO                      |
|---------------------------------------------------------------|
|                                       |                       |
|         [CADASTRAR PRODUTOS]          |            1          |
|         [ EXCLUIR PRODUTOS ]          |            2          |
|         [ LISTAR PRODUTOS  ]          |            3          |
|         [ CADASTRAR MARCAS ]          |            4          |
|         [  LISTAR MARCAS   ]          |            5          |
|         [  EXCLUIR MARCAS  ]          |            6          |
|         [ SAIR DO PROGRAMA ]          |            0          |
|                                                               |
=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
");

                Console.Write("Digite o número da opção desejada: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        // Cadastra o produto                                               
                        Console.Clear();
                        Console.WriteLine(@"    Cadastrar Produtos    ");
                        Console.WriteLine(@"--------------------------");
                        
                        produto.Cadastrar();

                        Console.WriteLine();
                        Console.Write("Aperte <Enter> para voltar ao menu... ");
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter);

                        break;

                    case "2":

                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(@"    Cadastrar Produtos    ");
                        Console.WriteLine(@"--------------------------");
                        
                        produto.Listar ();

                        Console.Write("Aperte <Enter> para voltar ao menu... ");
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter);



                        break;
                    case "0":
                        Console.WriteLine();
                        Console.WriteLine("O programa foi encerrado com sucesso");
                        Environment.Exit(0);
                        encerrarPrograma = true;
                        break;

                    default:
                        Console.WriteLine($"ERRO");
                        break;

                }


            } while (encerrarPrograma == false);

        }











    }
}