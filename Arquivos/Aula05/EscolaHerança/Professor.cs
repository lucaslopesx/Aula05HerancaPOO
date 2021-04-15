using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaHerança
{
    class Professor:Pessoa
    {
        private string titulo;

        public Professor(string nome) : base(nome)
        {
        }

        public string Titulo { get => titulo; set => titulo = value; }

        public string MostraProfessor()
        {
            return MostraPessoa() + "\n Titulação: " + Titulo;
            //return "Nome: " + Nome + "\nIdade: " + Idade + "\n Titulação: " + titulo;
        }

    }
}
