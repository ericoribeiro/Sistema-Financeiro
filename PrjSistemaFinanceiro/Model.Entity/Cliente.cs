using System.ComponentModel.DataAnnotations;

namespace Model.Entity
{
    public class Cliente
    {
        
        private long idCliente;
        private string nome;
        private string endereco;
        private string telefone;
        private string cpf;
        private int estado;

        //Encapsulamento dos Atributos da Classe

        [Display(Name = "Código")]
        public long IdCliente { get => idCliente; set => idCliente = value; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Nome { get => nome; set => nome = value; }

        [Display(Name = "Endereco")]
        public string Endereco { get => endereco; set => endereco = value; }

        [Display(Name = "Telefone")]
        public string Telefone { get => telefone; set => telefone = value; }

        [Display(Name = "CPF")]
        public string Cpf { get => cpf; set => cpf = value; }

        public int Estado { get => estado; set => estado = value; }
        
        //Métodos da Classe

        public Cliente()
        {

        }

        public Cliente(long idCliente)
        {
            this.IdCliente = idCliente;
        }

        public Cliente(long idCliente, string nome, string cpf, string endereco, string telefone)
        {
            this.IdCliente = idCliente;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }

        
    }
}
