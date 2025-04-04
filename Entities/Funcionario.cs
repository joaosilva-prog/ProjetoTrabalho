using System;
using System.Collections.Generic;
using System.Text;
using ProjetoTrabalho.Entities.Enums;

namespace ProjetoTrabalho.Entities
{
    class Funcionario : Pessoa
    {
        public int Matricula { get; set; }
        public Funcionario() 
        {
            Tipo = TipoUsuario.Funcionario;
        }
        public Funcionario(string nome, int matricula) : base(nome)
        {
            Matricula = matricula;
            Tipo = TipoUsuario.Funcionario;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados do Funcionário do Atendimento:");
            sb.AppendLine($"Nome do Funcionário: {Nome}");
            sb.AppendLine($"Id do Funcionário: {Matricula}");
            return sb.ToString();
        }
    }
}
