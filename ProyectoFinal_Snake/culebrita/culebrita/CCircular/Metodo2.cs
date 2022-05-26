using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colcc
{
    internal class Metodo2
    {
        private static int fin;
        private static int MAXTAMQ = 900000000;
        protected int frente;

        public int NumDeElementos;

        public int numeleme()
        {
            return NumDeElementos; 
        }



        protected Object[] listaCola; //Ac� vemos que lo �nico que cambia es lo de Object 
        // Ac� avanza una posici�n

        private int Siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        //Ac� inicializa la cola vac�a

        public Metodo2()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new Object[MAXTAMQ];
        }

        // Ac� vemos las operaciones de modificaci�n de la cola
        public void Insertar(Object elemento)
        {
            if (!CLlena())
            {
                NumDeElementos++;
                fin = Siguiente(fin);
                listaCola[fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow en la cola");
            }
        }

        public Object Cancelar()
        {
            if (!CVacia())
            {
                NumDeElementos--;
                Object tm = listaCola[frente];
                frente = Siguiente(frente);
                return tm;
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }



        public void SuprimirCOla()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
        }

        // Damos el acceso a la cola
        public Object FrenteCola()
        {
            if (!CVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }

        public Object FinalCola()
        {
            if (!CVacia())
            {
                return listaCola[fin];
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }


        // Luego los m�todos de verificaci�n del estado de la cola

        public bool CVacia()
        {
            return frente == Siguiente(fin);
        }

        // Y comprobamos si est� llena

        public bool CLlena()
        {
            return frente == Siguiente(Siguiente(fin));
        }





    }

}
