using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class Moto : Vehiculo 
    {
        private bool cilindrada;

        public Moto()
        {
            cilindrada = true;
        }

        public Moto(bool cilindrada, String marca, String modelo, int patente)
        {
            this.cilindrada = cilindrada;
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente;
        }

        public void getCilindrada(bool cilindrada)
        {
            this.cilindrada = cilindrada;
        }

        public bool setCilindrada()
        {
            return this.cilindrada;
        }
    }
}
