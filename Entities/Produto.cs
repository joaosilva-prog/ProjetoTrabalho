using System;
using System.Collections.Generic;
using System.Text;
using ProjetoTrabalho.Entities;
using ProjetoTrabalho.Entities.Enums;
using System.Globalization;

namespace ProjetoTrabalho.Entities
{
    class Produto 
    {
        public int IdProduto { get; private set; }
        public TipoProduto Tipo { get; private set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public Produto() 
        { 
        }
        public Produto(int idproduto, TipoProduto tipo, string nome, double valor)
        {
            IdProduto = idproduto;
            Tipo = tipo;
            Nome = nome;
            Valor = valor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dados do Aparelho:");
            sb.AppendLine($"Aparelho: {Tipo}");
            sb.AppendLine($"Descrição do Aparelho: {Nome}");
            sb.AppendLine($"Valor de Reparo: {Valor.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
