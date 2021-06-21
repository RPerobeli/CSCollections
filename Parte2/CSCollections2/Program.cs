using CSCollections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedList();
            //ArrayMultidimensional();
            //JaggedArrays();
            //LINQ();
            OperacaoConjuntosLINQ();
            Console.ReadLine();
        }

        private static void OperacaoConjuntosLINQ()
        {
            string[] seq1 = { "janeiro", "fevereiro", "marco"};
            string[] seq2 = { "fevereiro", "MARCO", "abril" };

            Console.WriteLine("Concatenando");
            IEnumerable<string> consulta = seq1.Concat(seq2);
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Uniao de 2 seq");
            IEnumerable<string> consulta2 = seq1.Union(seq2);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Uniao com comparador");
            IEnumerable<string> consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Intersecão");
            IEnumerable<string> consulta4 = seq1.Intersect(seq2,StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Exceção: elementos da seq1 que nao estao na seq2");
            IEnumerable<string> consulta5 = seq1.Except(seq2);
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void LINQ()
        {
            List<Mes> meses = new List<Mes>()
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Marco", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            //meses.Sort();
            //foreach (var mes in meses)
            //{
            //        if (mes.Dias == 31)
            //        {
            //                Console.WriteLine(mes.Nome.ToUpper());
            //        }

            //Montagem da consulta
            IEnumerable<string> consulta = meses
                                            .Where(n => n.QtdDias == 31)
                                            .OrderBy(n => n.Nome)
                                            .Select(n=>n.Nome.ToUpper());

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            IEnumerable<Mes> consulta2 = meses.Take(3);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            IEnumerable<Mes> consulta3 = meses.Skip(3);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            IEnumerable<Mes> consulta4 = meses.Skip(6).Take(3);
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            IEnumerable<Mes> consulta5 = meses.TakeWhile(n => !n.Nome.StartsWith("S"));
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            IEnumerable<Mes> consulta6 = meses.SkipWhile(n => !n.Nome.StartsWith("S"));
            foreach (var item in consulta6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void JaggedArrays()
        {
            string[][] familias = new string[3][];
            
            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach (var item in familias)
            {
                Console.WriteLine(string.Join(",", item));
            }

        }

        private static void ArrayMultidimensional()
        {
            string[,] resultados = new string[4, 3]
            {
                    {"Alemanha", "Espanha", "Itália"},
                    {"Argentina", "Holanda", "França"},
                    {"Holanda", "Alemanha", "Alemanha"},
                    {"Holanda", "Alemanha", "Alemanha"},
            };

            //foreach (var selecao in resultados)
            //{
            //    Console.WriteLine(selecao);
            //}
            for (int copa = 0; copa < 3; copa++)
            {
                int ano = 2014 - copa * 4;
                Console.Write(ano.ToString().PadRight(12));
            }
            Console.WriteLine();

            for (int posicao = 0; posicao <= resultados.GetUpperBound(0); posicao++)
            {
                for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
                {
                    Console.Write(resultados[posicao, copa].PadRight(12));
                }
                Console.WriteLine();
            }
        }

        private static void SortedList()
        {
            IDictionary<string, Aluno> alunosDict = new Dictionary<string, Aluno>();
            alunosDict.Add("VT", new Aluno("Vanessa", 1234));
            alunosDict.Add("AL", new Aluno("Ana", 5678));
            alunosDict.Add("RN", new Aluno("Rafael", 9012));
            alunosDict.Add("WM", new Aluno("Wanderson", 3456));
            ImprimirDicionario(alunosDict);

            alunosDict.Remove("AL");
            alunosDict.Add("MO", new Aluno("Marcelo", 7890));
            ImprimirDicionario(alunosDict);

            IDictionary<string, Aluno> alunosSortedList = new SortedList<string, Aluno>();
            alunosSortedList.Add("VT", new Aluno("Vanessa", 1234));
            alunosSortedList.Add("AL", new Aluno("Ana", 5678));
            alunosSortedList.Add("RN", new Aluno("Rafael", 9012));
            alunosSortedList.Add("WM", new Aluno("Wanderson", 3456));
            ImprimirDicionario(alunosSortedList);

            alunosSortedList.Remove("AL");
            alunosSortedList.Add("MO", new Aluno("Marcelo", 7890));
            ImprimirDicionario(alunosSortedList);

            IDictionary<string, Aluno> alunosSortedDict = new SortedDictionary<string, Aluno>();
            alunosSortedDict.Add("VT", new Aluno("Vanessa", 1234));
            alunosSortedDict.Add("AL", new Aluno("Ana", 5678));
            alunosSortedDict.Add("RN", new Aluno("Rafael", 9012));
            alunosSortedDict.Add("WM", new Aluno("Wanderson", 3456));
            ImprimirDicionario(alunosSortedDict);

            alunosSortedDict.Remove("AL");
            alunosSortedDict.Add("MO", new Aluno("Marcelo", 7890));
            ImprimirDicionario(alunosSortedDict);
        }

        private static void ImprimirDicionario(IDictionary<string, Aluno> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
