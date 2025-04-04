using System;
using System.Collections.Generic;
using ProjetoTrabalho.Entities.Enums;
using System.Text;

namespace ProjetoTrabalho.Entities
{
    class Pessoa
    {
        public string Nome { get; protected set; }
        public TipoUsuario Tipo { get; protected set; }
        public int Identificacao { get; protected set; }

        protected Pessoa() { }
        protected Pessoa(string nome) 
        { 
            Nome = nome;
        }
        protected Pessoa(string nome, TipoUsuario tipo, int identificacao)
        {
            Nome = nome;
            Tipo = tipo;
            Identificacao = identificacao;
        }
    }
}
