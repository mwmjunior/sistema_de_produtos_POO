using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_de_produtos
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string  Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }


        public Usuario()
        {
            Cadastrar ();
        }

        public void Cadastrar()
        {
            this.Nome = "Marcio";
            this.Email = "mwm.junior@hotmail.com";
            this.Senha = "123456";
            this.DataCadastro = DateTime.Now;
        }


        public void Deletar ()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Now;
        }

    }
}