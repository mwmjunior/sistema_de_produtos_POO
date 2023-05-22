using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_de_produtos
{
    public class Marca
    {
        
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        List<Marca> ListaDeMarcas = new List<Marca> ();



        public Marca Cadastrar()
        {
            
         Marca novaMarca = new Marca();
         return novaMarca;

        }

        public void Listar ()
        {

        }

        public void Deletar ()
        
        {
            
        }
       

        

    }
}