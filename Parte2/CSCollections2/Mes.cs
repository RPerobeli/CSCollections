using System;
using System.Collections.Generic;
using System.Text;

namespace CSCollections2
{
    public class Mes
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            QtdDias = dias;
        }

        public int QtdDias { get; private set; }
        public string Nome { get; private set; }
    }
}
