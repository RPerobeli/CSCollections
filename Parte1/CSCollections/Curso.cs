using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CSCollections
{
    class Curso
    {
        public string Instrutor { get; set; }
        public string Nome { get; set; }

        private IList<Aula> _aulas;
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(_aulas); }
        }

        public Curso(string instrutor, string nome)
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
    }
}
