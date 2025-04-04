using System;
using System.Collections.Generic;
using System.Text;
using ProjetoTrabalho.Entities.Enums;

namespace ProjetoTrabalho.Entities
{
    class Fornecedor : Pessoa
    {
        public string Cnpj { get; private set; }
        public Fornecedor() : base() 
        {
            Tipo = TipoUsuario.Fornecedor;
        } 

        public Fornecedor(string nome, string cnpj) : base(nome)  
        {
            Nome = nome;
            Cnpj = cnpj;
            Tipo = TipoUsuario.Fornecedor;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DADOS DO FORNECEDOR: ");
            sb.AppendLine("Razão Social: " + Nome);
            sb.AppendLine("CNPJ: " + Cnpj);
            return sb.ToString();
        }
    }
}

