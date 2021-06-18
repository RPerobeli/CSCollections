using System;
using System.Collections.Generic;
using System.Text;

namespace CSCollections
{
    public class Aluno
    {

        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Aluno( string nome, int matricula)
        {
            Matricula = matricula;
            Nome = nome;
        }
        public override string ToString()
        {
            return $"Aluno: {Nome} -> Matricula: {Matricula}";
        }
        public override bool Equals(object obj)
        {
            Aluno aluno = obj as Aluno;
            if(aluno == null)
            {
                return false;
            }
            return Nome == aluno.Nome && Matricula == aluno.Matricula;
        }
        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}
