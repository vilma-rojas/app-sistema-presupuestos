using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class Automovil : Vehiculo
    {
        private String tipo;

        private int cantPuertas;

        public Automovil(String tipo)
        {
            this.tipo = tipo;
            this.cantPuertas = 4;
        }

        public Automovil(String tipo, int cantPuertas, String marca, String modelo, int patente)
        {
            this.tipo = tipo;
            this.cantPuertas = cantPuertas;
           
        }

        public String getTipo()
        {
            return this.tipo;
        }

        public int getCantPuertas()
        {
            return this.cantPuertas;
        }

        public void setTipo(String tipo)
        {
            this.tipo = tipo;
        }

        public void setCantPuertas(int cantPuertas)
        {
            this.cantPuertas = cantPuertas;
        }
    }
}
