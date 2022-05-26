using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lca
{
    internal class Metodo1
    {
        ArrayList Carray = new ArrayList();
        int tamano;
        public int TamanioCola()
        {
            return tamano;
        }


        //incializa la cola con una serie de elementos
        public Metodo1()
        {
             this.Carray = new ArrayList();
        }


        public int NumElementos;

        public int NumElement()
        {
            return NumElementos;
        }

        public Object finalcola()
        {

            return Carray[Carray.Count - 1];
        }

        public void Insertar(object dato)
        {
            if (!CLlena())
            {
                NumElementos++;
                Carray.Add(dato);
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
            tamano++;

        }

        public object Cancelar()
        {
            if (!CVacia())
            {
                object dato = Carray[0];
                Carray.RemoveAt(0);
                NumElementos--;
                tamano--;
                return dato;
            }
            else
            {
                throw new Exception("Peeep Cola Vacía");
            }
        }

         
        
        public bool CVacia()
        {
            if (Carray.Count == 1000000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CLlena()
        {
            if (Carray.Count == 1000000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
