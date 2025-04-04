using System;
using ProjetoTrabalho.Entities;
using ProjetoTrabalho.Entities.Enums;
using System.Text;

namespace ProjetoTrabalho.Entities
{
    class OrdemDeServico
    {
        public int IdOrdem { get; set; }
        public Cliente Cliente { get; private set; }
        public Produto Produto { get; private set; }
        public Funcionario Funcionario { get; private set; }

        public OrdemDeServico() { }

        public OrdemDeServico(Cliente cliente, Produto produto, Funcionario funcionario, int ordem)
        {
            Cliente = cliente;
            Produto = produto;
            Funcionario = funcionario;
            IdOrdem = ordem;
        }
        public void AlterarStatus(Status status)
        { 
            Cliente.Status = status;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DADOS DA ORDEM DE SERVIÇO:");
            return sb.ToString();
        }
    }
}
