using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaHerança
{
    class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome;  }
        public int Idade { get => idade; set => idade = value; }

        public string MostraPessoa()
        {
            return "Nome: " + Nome + "\nIdade: " + Idade;
        }
    }
}
