using System;

namespace CSCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduçãoaArrays();
        }

        public static void IntroduçãoaArrays()
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
            Imprimir(aulas);
            Console.WriteLine("------------------------------------------");
            //primeira ocorrencia
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas,aulaModelando));
            //UltimaOcorrencia
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));
            Console.WriteLine("------------------------------------------");

            //Invertendo Array
            Array.Reverse(aulas);
            Imprimir(aulas);
            Array.Reverse(aulas);
            Console.WriteLine("------------------------------------------");

            //Mudando tamanho de array
            Array.Resize(ref aulas, 2);
            Array.Resize(ref aulas, 3);
            Imprimir(aulas);
            Console.WriteLine("------------------------------------------");
            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            Console.WriteLine("------------------------------------------");
            Array.Sort(aulas);
            Imprimir(aulas);

            Console.ReadLine();
        }

        private static void Imprimir(string[] aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
