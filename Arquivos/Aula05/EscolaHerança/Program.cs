using System;
using System.Collections.Generic;

namespace EscolaHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Professor> lp = new List<Professor>();
            List<Aluno> la = new List<Aluno>();

            Professor p = null;
            Aluno a = null;

            string auxnome;
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Professor");
                Console.WriteLine("2 - Cadastrar Aluno");
                Console.WriteLine("3 - Pesquisar Professor pelo nome");
                Console.WriteLine("4 - Pesquisar Alunos pela idade");
                Console.WriteLine("5 - Sair");
                Console.Write("Digite sua opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Nome do professor: ");
                        auxnome = Console.ReadLine();
                        p = new Professor(auxnome);
                        Console.Write("Idade do professor: ");
                        p.Idade = int.Parse(Console.ReadLine());
                        Console.Write("Título do professor: ");
                        p.Titulo = Console.ReadLine();

                        lp.Add(p);
                        break;
                    case 2:
                        Console.Write("Nome do aluno: ");
                        auxnome = Console.ReadLine();
                        a = new Aluno(auxnome);
                        Console.Write("Idade do aluno: ");
                        a.Idade = int.Parse(Console.ReadLine());
                        Console.Write("Matrícula do aluno: ");
                        a.Matricula = Console.ReadLine();

                        la.Add(a);
                        break;
                    case 3:
                        Console.Write("Nome do professor: ");
                        string nomeAux = Console.ReadLine();

                        foreach (var item in lp)
                        {
                            if (item.Nome == nomeAux)
                            {
                                Console.WriteLine(item.MostraProfessor() + "\n");
                            }
                        }
                        Console.ReadKey();

                        break;
                    case 4:
                        Console.Write("Idade dos alunos: ");
                        int idadeAux = int.Parse(Console.ReadLine());

                        foreach (var item in la)
                        {
                            if (item.Idade == idadeAux)
                            {
                                Console.WriteLine(item.MostraAluno() + "\n");
                            }
                        }
                        Console.ReadKey();

                        break;
                }
            } while (op!=6);
        }
    }
}
