using System;
using System.Text;
using ProjetoTrabalho.Entities;
using ProjetoTrabalho.Entities.Enums;

namespace ProjetoTrabalho.Entities.Enums
{
    class Cliente : Pessoa  
    {
        public string Email { get; private set; }
        public Status Status { get; set; }
        public DateTime DataEntrada { get; private set; }
        public string Cpf { get; private set; }

        public Cliente() :base()
        {
            Tipo = TipoUsuario.Cliente;
            DataEntrada = DateTime.Now;
        }
        public Cliente(string nome, string cpf, string email) : base(nome) 
        {
            Cpf = cpf;
            Email = email;
            Status = Status.Pendente;
            DataEntrada = DateTime.Now;
            Tipo = TipoUsuario.Cliente;
        }

        public override string ToString()
        {   
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados do cliente: ");
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"CPF: {Cpf}"); 
            sb.AppendLine($"Email : {Email}");
            sb.AppendLine($"Data de entrada: {DataEntrada}");
            sb.AppendLine($"Status do Serviço: {Status}");
            return sb.ToString();
        }
    }
}
