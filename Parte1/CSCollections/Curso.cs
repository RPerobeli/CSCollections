using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CSCollections
{
    class Curso
    {
        public string Instrutor { get; set; }
        public string Nome { get; set; }

        private IDictionary<int, Aluno> _alunosDict = new Dictionary<int, Aluno>();

        private IList<Aula> _aulas;
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(_aulas); }
        }

        private ISet<Aluno> _alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(_alunos.ToList());
            }
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var aula in _aulas)
                //{
                //    total += aula.Duracao;
                //}
                //return total;

                return Aulas.Sum(aula => aula.Duracao);
            }
        }

        public void Matricular(params Aluno[] alunos)
        {
            foreach (var aluno in alunos)
            {
                _alunos.Add(aluno);
                _alunosDict.Add(aluno.Matricula, aluno);
            }   
        }

        public void SubstituiAluno(Aluno aluno)
        {
            _alunosDict[aluno.Matricula] = aluno; 
        }

        public Aluno BuscarMatriculado(int matricula)
        {
            //Busca no hashset
            //foreach (var aluno in _alunos)
            //{
            //    if(aluno.Matricula == matricula)
            //    {
            //        return aluno;
            //    }
            //}
            //throw new Exception($"Matricula {matricula} não encontrada");

            //Busca no Dict
            //return _alunosDict[matricula];
            Aluno aluno = null;
            _alunosDict.TryGetValue(matricula,out aluno);
            return aluno;
        }

        internal bool isMatriculado(Aluno aluno)
        {
            return _alunos.Contains(aluno);
        }

        public Curso(string nome, string instrutor)
        {
            Instrutor = instrutor;
            Nome = nome;
            _aulas = new List<Aula>();
        }

        public void Adicionar(params Aula[] aulas)
        {
            foreach (var item in aulas)
            {
                _aulas.Add(item);
            }
        }
        public override string ToString()
        {
            return $"Curso: {Nome}, Duracao: {TempoTotal},\n Aulas: {string.Join(",\n", _aulas)}";
        }
        
    }
}
