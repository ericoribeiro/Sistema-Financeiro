using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Vendedor
    {
        private long idVendedor;
        private string nome;
        private string cpf;
        private string telefone;

        //Encapsulamento dos atributos privados

        public long IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CPF { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        //Métodos da classe

        public Vendedor() {

        }
        public Vendedor(long IdVendedor)
        {
            this.idVendedor = IdVendedor;
        }
    }
}
