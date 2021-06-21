using System;
using System.Collections.Generic;
using System.Text;

namespace CSCollections2
{
    public class Mes
    {

        public int QtdDias { get; private set; }
        public string Nome { get; private set; }
        public Mes(string nome, int dias)
        {
            Nome = nome;
            QtdDias = dias;
        }
        public override string ToString()
        {
            return $"{Nome}: {QtdDias} dias.";
        }
    }
}
