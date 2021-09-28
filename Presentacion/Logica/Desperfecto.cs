using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class Desperfecto
    {
        private String descripcion;

        private float manoDeObra;

        private int tiempo;

        Repuesto repuesto;
        /*
        public Desperfecto()
        {
            this.descripcion = "";
            this.manoDeObra = 0;
            this.tiempo = 0;
        }*/

        public Desperfecto()
        {
            this.descripcion = "";
            this.manoDeObra = 0;
            this.tiempo = 0;
            this.repuesto = new Repuesto("", 0);
        }

        public Desperfecto(String descripcion, float manoDeObra, int tiempo, Repuesto repuesto)
        {
            this.descripcion = descripcion;
            this.manoDeObra = manoDeObra;
            this.tiempo = tiempo;
            this.repuesto = repuesto;

        }

        public String getDescripcion()
        {
            return this.descripcion;
        }

        public float getManoDeObra()
        {
            return this.manoDeObra;
        }

        public int getTiempo()
        {
            return this.tiempo;
        }

        public Repuesto getRepuesto()
        {
            return this.repuesto;
        }


        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }

        public void setManoDeObra(float manoDeObra)
        {
            this.manoDeObra = manoDeObra;
        }

        public void setTiempo(int tiempo)
        {
            this.tiempo = tiempo;
        }

        public void setRepuesto(Repuesto repuesto)
        {
            this.repuesto = repuesto;
        }
    }
}
