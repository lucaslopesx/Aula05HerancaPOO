using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaHerança
{
    class Aluno:Pessoa
    {
        private string matricula;

        public Aluno(string nome) : base(nome)
        {
        }

        public string Matricula { get => matricula; set => matricula = value; }
        
        public string MostraAluno()
        {
            return MostraPessoa() + "\nMatrícula: " + Matricula; 
        }

    }
}
