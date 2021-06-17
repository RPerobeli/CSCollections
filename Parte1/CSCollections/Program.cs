using System;
using System.Collections.Generic;
using System.Linq;

namespace CSCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntroduçãoaArrays();
            //IntroducaoListas();
            //ListasObj();
            ListasCurso();

            Console.ReadLine();
        }

        private static void ListasCurso()
        {
            Curso cSharpColecoes = new Curso("C#Colecoes", "Peróbelis");
            Curso cSharpLinq = new Curso("C#Linq", "Peroba");
            Curso cSharpList = new Curso("C#List", "Perobeli");

            //Adicionando uma aula a um curso
            cSharpColecoes.Adicionar(new Aula("Conclusao", 60), new Aula("Capoeira", 120));
            ImprimirList(cSharpColecoes.Aulas);

            //Adicionando duas novas aulas ao curso
            cSharpColecoes.Adicionar(new Aula("Modelando com colecoes", 20), new Aula("dedo no e gritaria", 12));
            ImprimirList(cSharpColecoes.Aulas);
            //Ordenar
            List<Aula> aulasCopiadas = new List<Aula>(cSharpColecoes.Aulas);
            aulasCopiadas.Sort();
            ImprimirList(aulasCopiadas);

        }

        private static void ListasObj()
        {
            var aulaIntro = new Aula("Introdução às Coleções", 16);
            var aulaModelando = new Aula("Modelando a Classe Aula", 45);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 29);

            List<Aula> aulas = new List<Aula>()
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            ImprimirList(aulas);
            Console.WriteLine("------------------------------------------");

            //Sort
            //aulas.Sort();
            //ImprimirList(aulas);

            aulas.Sort( (a,b) => a.Duracao.CompareTo(b.Duracao));
            ImprimirList(aulas);

        }

        public static void IntroducaoListas()
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            List<string> aulas = new List<string>()
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
            ImprimirList(aulas);
            Console.WriteLine("------------------------------------------");

            aulas.Add("Conclusao");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("A primeira aula é " + aulas.First());
            Console.WriteLine("A primeira aula é " + aulas.Last());

            Console.WriteLine("------------------------------------------");
            aulas.FirstOrDefault(aula => aula.Contains("Trabalhando"));
            aulas.LastOrDefault(aula => aula.Contains("Trabalhando"));

            Console.WriteLine("------------------------------------------");
            aulas.Reverse();
            ImprimirList(aulas);

            Console.WriteLine("------------------------------------------");
            List<string> clone = new List<string>(aulas);
            clone.RemoveAt(clone.Count - 1);
            ImprimirList(clone);

            Console.WriteLine("------------------------------------------");
            clone.RemoveRange(clone.Count - 2, 2);
            ImprimirList(clone);

            Console.WriteLine("------------------------------------------");
            aulas.Sort((a, b) => a.Length.CompareTo(b.Length));
            ImprimirList(aulas);

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

        private static void Imprimir<T>(T[] aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
        private static void ImprimirList<T>(IList<T> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
            //aulas.ForEach(aula =>
            //{
            //    Console.WriteLine(aula);
            //});

        }
    }
}
