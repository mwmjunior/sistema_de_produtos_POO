using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_de_produtos
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }
        public int Preco { get; set; }
        public DateTime DataCadastro { get; set; }

        public Marca marca = new Marca();

        public Usuario CadastroPor { get; set; }

        public int contador { get; set; } = 0;

        public string[] produtos = new string[10000];


        List <Produto> ListadeProduto = new List<Produto>();


        public void Cadastrar ()
        {

         do {
            if (contador < 10000) // Permite ao usuário cadastrar até 10000 produtos com seus respectivos nome, preço e se o produto está em promoção
            {
              Console.WriteLine($"Escreva o nome do produto: ");
              produtos[contador] = Console.ReadLine();
            
              contador++;

              Console.WriteLine("Deseja cadastrar outro produto? (S/N)");
              char resposta = Console.ReadKey().KeyChar;
              Console.WriteLine();

              if (resposta == 'N' || resposta == 'n') 
              {
                break;
              }
            } 
            
            else 
            {
              Console.WriteLine("Limite cadastramento de produtos excedido!");
              break;
            }

          } while (true);
          
        }


        public void Listar ()
        {
             // Lista os produtos cadastrados
          Console.Clear();
          Console.WriteLine(@"    Listagem de produtos   ");
          Console.WriteLine("----------------------------");


          // Mostra ao usuário a lista de todos os produtos cadastrados
          for (var i = 0; i < contador; i++) {
            Console.WriteLine($"{i}. {produtos[i]}");
          }


        }

        public void Deletar ()
        {

        }
    }
}