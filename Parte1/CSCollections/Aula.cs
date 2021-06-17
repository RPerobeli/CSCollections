using System;
using System.Collections.Generic;
using System.Text;

namespace CSCollections
{
    public class Aula : IComparable
    {
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public Aula(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;
        }
        public override string ToString()
        {
            return $"[Título: {Titulo} - Duração: {Duracao}]";
        }

        public int CompareTo(object obj)
        {
            Aula objeto = obj as Aula;
            return Titulo.CompareTo(objeto.Titulo);
        }
    }
}
