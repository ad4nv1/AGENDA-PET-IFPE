using AgendaContatos.Enum;
using System;
namespace Cadastro_Contatos
{
    class Contato
    {
        public TipoContato TipoContato { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Data { get; set; }
        public string Obs { get; set; }
        public bool Excluido { get; set; }

        public Contato()
        {
        }

        public Contato(TipoContato tipoContato, string telefone, string endereco, string nome, string email, string data, string obs)
        {
            this.TipoContato = tipoContato;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Nome = nome;
            this.Email = email;
            this.Data = data;
            this.Obs = obs;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Tipo de contato: " + this.TipoContato + " | ";
            retorno += "Telefone: " + this.Telefone + " | ";
            retorno += "Endereço: " + this.Endereco + " | ";
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
    }
}

