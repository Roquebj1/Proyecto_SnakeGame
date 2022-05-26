using System;
using System.Collections.Generic;
using System.Text;

namespace lcle
{
    internal class Metodo4
    {
        public Nodo _first;
        public Nodo _last;
        int tamanio;

        public int NumElementos;

        public int NumElement()
        {
            return NumElementos;
        }

        public Metodo4()
        {
            _first = null;
            _last = null;
        }

        //Devuelve si la Cola esta vacia
        public bool CVacia()
        {
            return _first == null;
        }

        // Devuelve el tamaño de la Cola
        public int TamanoCola()
        {
            return tamanio;
        }

        // Devuelve el frende de la Cola
        public Object FrenteCOla()
        {
            if (!CVacia())
            {
                return (_first.Dato);
               
            }
            throw new Exception("Cola Vacia");
        }

        // Devuelve el fin de la Cola
        public Object FinadeCOla()
        {
            if (!CVacia())
            {
                return (_last.Dato);
                
            }
            throw new Exception("Error Cola Vacia");
        }

        //Inserta un elemento en la cola de ListaEnlazada
        public void Insertar(Object elemento)
        {
            NumElementos++;
            Nodo nuevo =  new Nodo(elemento);
            if (!CVacia())
            {
                _last.Siguiente = nuevo;
            }
            else
            {
                _first = nuevo;
            }
            _last = nuevo;
            tamanio++;
        }

        //Quita un valor de la Cola ListaEnlazada
        public Object SuprimirValor()
        {
            NumElementos--;
            Object auxiliar;
            if (!CVacia())
            {
                auxiliar = _first.Dato;
                _first = _first.Siguiente;
                tamanio--;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }

            return auxiliar;
        }

        //Devuelve el Numero de Elementos de la Lista
        public int NumerodeElementosLista()
        {
            int numero;
            Nodo nodo = _first;
            if (!CVacia())
            {
                numero = 1;
                while (nodo != _last)
                {
                    numero++;
                    nodo = nodo.Siguiente;
                }
            }
            else
            {
                numero = 0;
            }
            return numero;
        }
    }

}
