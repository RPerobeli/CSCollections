using CSCollections;
using System;
using System.Collections.Generic;

namespace CSCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedList();
            //ArrayMultidimensional();
            //JaggedArrays();

            Console.ReadLine();
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
