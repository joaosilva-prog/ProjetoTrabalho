using System;
using System.Collections.Generic;
using ProjetoTrabalho.Entities.Enums;
using ProjetoTrabalho.Entities;
using System.Text;


namespace ProjetoTrabalho.Entities
{
    class Estoque
    {
        public List<Produto> Produto { get; set; } = new List<Produto>();
        public List<string> Peças { get; set; } = new List<string> {"Cabo de Força" , "Tela 32" , "Tela 40" , "Tela 44" , "Carcaça de Tela" , "Apoios" };

        public void AddProduto(Produto produto)
        {
            Produto.Add(produto);
        }

        public void RemoveProduto(Produto produto)
        {
            Produto.Remove(produto);
        }

        public void AddPeça (string peça)
        {
            Peças.Add(peça);
        }
        public void RemovePeça(string peça)
        {
            Peças.Remove(peça);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Aparelhos em Estoque: ");
            foreach (Produto produto in Produto)
            {
                sb.AppendLine(produto.ToString());
            }
            sb.AppendLine("Peças em estoque: ");
            foreach(string peça in Peças)
            {
                sb.AppendLine(peça);
            }
            return sb.ToString();
        }
    }
}
