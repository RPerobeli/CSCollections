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
            //ListasCurso();
            // Sets();
            //CursoComAlunos();
            //CursoDicionario();
            //LinkedList();
            //Pilhas();
            //Filas();


            Console.ReadLine();
        }

        private static void Filas()
        {
            Queue<string> pedagio = new Queue<string>();

            Enfileirar(pedagio, "van", "kombi", "guincho", "pickup");
            Desenfileirar(pedagio);

        }

        private static void Desenfileirar(Queue<string> pedagio)
        {
            if(pedagio.Any())
            {
                var liberado = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {liberado}");
                ImprimirFila(pedagio);
            }
        }

        private static void Enfileirar(Queue<string> pedagio, params string[] veiculos)
        {
            foreach (var v in veiculos)
            {
                Console.WriteLine("Entrou na fila: " + v);
                pedagio.Enqueue(v);
            }

            ImprimirFila(pedagio);
        }

        private static void ImprimirFila(Queue<string> pedagio)
        {
            Console.WriteLine("Fila:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }

        private static void Pilhas()
        {
            var navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Proximo();
        }

        private static void LinkedList()
        {
            //Dias da semana
            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("quarta");
            Console.WriteLine("d4.value" + d4.Value);

            var d2 = dias.AddBefore(d4, "segunda");
            var d3 = dias.AddAfter(d2, "terça");
            var d6 = dias.AddAfter(d4, "sexta");
            var d7 = dias.AddAfter(d6, "sabado");
            var d5 = dias.AddBefore(d6, "quinta");
            var d1 = dias.AddBefore(d2, "domingo");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            dias.Remove("quarta");
            dias.Remove(d4);
        }

        private static void CursoDicionario()
        {
            var a1 = new Aluno("Vanessa Tonini", 1234);
            var a2 = new Aluno("Ana Losnak", 5678);
            var a3 = new Aluno("Rafael Nercessian", 9012);

            Curso CSharpColecoes = new Curso("c# colecoes", "Perobelis");
            CSharpColecoes.Adicionar(
                new Aula("Listas", 20),
                new Aula("Sets", 40),
                new Aula("Conclusao", 30)
                );
            CSharpColecoes.Matricular(a1, a2, a3);
            Console.WriteLine("Quem é o aluno 5678?");
            Aluno aluno5678 = CSharpColecoes.BuscarMatriculado(5678);
            Console.WriteLine(aluno5678.Nome);

            Aluno fabio = new Aluno("Fabio Gushiken", 5678);
            CSharpColecoes.SubstituiAluno(fabio);

            aluno5678 = CSharpColecoes.BuscarMatriculado(5678);
            Console.WriteLine(aluno5678.Nome);
        }

        private static void CursoComAlunos()
        {
            var a1 = new Aluno("Vanessa Tonini", 1234);
            var a2 = new Aluno("Ana Losnak", 5678);
            var a3 = new Aluno("Rafael Nercessian", 9012);

            Curso CSharpColecoes = new Curso("c# colecoes", "Perobelis");
            CSharpColecoes.Adicionar(
                new Aula("Listas", 20),
                new Aula("Sets", 40),
                new Aula("Conclusao", 30)
                );
            CSharpColecoes.Matricular(a1,a2,a3);

            //Imprimir alunos matriculados 
            foreach (var aluno in CSharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            //imprimir: "O aluno a1 está matriculado?"
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            Console.WriteLine(CSharpColecoes.isMatriculado(a1));
            var tonini = new Aluno("Vanessa Tonini", 1234);
            Console.WriteLine("a1.equals(tonini)?  " + a1.Equals(tonini));
        }

        private static void Sets()
        {
            //Conjuntos / Sets:
            // 1: não tem duplicidade;
            // 2: não tem ordem específica
            //declarando set de alunos
            ISet<string> alunos = new HashSet<string>();
            //adicionando: vanessa, ana, rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //imprimindo
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(",", alunos));

            //adicionando: priscila, rollo, fabio
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));

            
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine(string.Join(",", alunos));

            //Add duplice:
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));
            
            List<string> alunosLista = new List<string>(alunos);
            alunosLista.Sort();
            Console.WriteLine(string.Join(",", alunosLista));
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

            Imprimir(cSharpColecoes.TempoTotal);

            Imprimir(cSharpColecoes);

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

        private static void Imprimir<T>( params T[] aulas)
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
