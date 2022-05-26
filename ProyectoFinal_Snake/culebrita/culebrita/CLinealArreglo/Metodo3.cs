using System;
using System.Collections.Generic;
using System.Text;

namespace lclarr
{
    internal class Metodo3
    {
        protected int Fin;
        private static int MaxTamQ = 900000000;
        protected int Frente;

        public int NumElemen;

        public int numeleme()
        {
            return NumElemen;
        }

        protected Object[] listaCola;

        public Metodo3()
        {
            Frente = 0;
            Fin = -1;
            listaCola = new Object[MaxTamQ];
        }

        // OPERACIONES DE MODIFICACIN DE LA COLA

        public void Insertar(Object elemento)
        {
            if (!Cllena())
            {
                NumElemen++;
                listaCola[++Fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow en la cola");
            }
        
        }

        public Object Cancelar() 
        {
            if (!Cvacia()){

                NumElemen--;
                Object aux = listaCola[Frente++];
                return aux;
            //return listaCola[frente++];
            } 
            else {
            throw new Exception("Cola vacia");
            }
        }
        //cola vacia
        public void SuprimirCola()
        {
            Frente = 0;
            Fin = -1;
        }

        //acceso a la cola
        public Object FrentedeCola()
        {
            if (!Cvacia()){
                return listaCola[Frente];
            } 
            else {
                throw new Exception("Peeep Cola Vacía");
            }
        }

        public Object FinaldeCola()
        {
            if (!Cvacia())
            {
                return listaCola[Fin];
            }
            else
            {
                throw new Exception("Cola vacía");
            }
        }


        //metodos de verificacion de cola
        public bool Cvacia()
        {
            return Frente > Fin;
        }

        public bool Cllena()
        {
            return Fin == MaxTamQ - 1;
        }

    }
}
