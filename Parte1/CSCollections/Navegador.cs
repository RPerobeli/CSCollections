using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCollections
{
    public class Navegador
    {
        private string _atual = "vazia";
        private Stack<string> _historico = new Stack<string>();
        private Stack<string> _historicoProximo = new Stack<string>();
        public Navegador()
        {
            Console.WriteLine("Pagina Atual: "+ _atual);
        }

        internal void NavegarPara(string url)
        {
            _historico.Push(_atual);
            _atual = url;
            Console.WriteLine("Pagina Atual: " + _atual);
        }

        internal void Anterior()
        {
            if(_historico.Any())
            {
                _historicoProximo.Push(_atual);
                _atual = _historico.Pop();
                Console.WriteLine("Pagina Atual: " + _atual);
            }else
            {
                Console.WriteLine("Pilha vazia");
            }

        }

        internal void Proximo()
        {
            if (_historico.Any())
            {
                _historico.Push(_atual);
                _atual = _historicoProximo.Pop();
                Console.WriteLine("Pagina Atual: " + _atual);
            }
            else
            {
                Console.WriteLine("Pilha proximo vazia");
            }
        }
    }
}
