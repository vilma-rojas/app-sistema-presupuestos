using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class Automovil : Vehiculo
    {
        private int tipo;

        private int cantPuertas;

        public Automovil(int tipo, int cantPuertas, String marca, String modelo, int patente)
        {
            this.tipo = tipo;
            this.cantPuertas = cantPuertas;
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente; 
           
        }

        public int getTipo()
        {
            return this.tipo;
        }

        public int getCantPuertas()
        {
            return this.cantPuertas;
        }

        public void setTipo(int tipo)
        {
            this.tipo = tipo;
        }

        public void setCantPuertas(int cantPuertas)
        {
            this.cantPuertas = cantPuertas;
        }
    }
}
