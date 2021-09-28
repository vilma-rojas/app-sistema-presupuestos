using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class Repuesto
    {
        private String nombre;

        private float precio;

        public Repuesto(String nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;

        }

        public String getNombre()
        {
            return this.nombre;
        }

        public float getPrecio()
        {
            return this.precio;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }
    }
}
