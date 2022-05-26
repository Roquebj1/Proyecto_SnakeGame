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



        protected Object[] listaCola; //Acá vemos que lo único que cambia es lo de Object 
        // Acá avanza una posición

        private int Siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        //Acá inicializa la cola vacía

        public Metodo2()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new Object[MAXTAMQ];
        }

        // Acá vemos las operaciones de modificación de la cola
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


        // Luego los métodos de verificación del estado de la cola

        public bool CVacia()
        {
            return frente == Siguiente(fin);
        }

        // Y comprobamos si está llena

        public bool CLlena()
        {
            return frente == Siguiente(Siguiente(fin));
        }





    }

}
