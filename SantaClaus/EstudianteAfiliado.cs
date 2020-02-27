using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
    class EstudianteAfiliado : Estudiante
    {
        //static private int contadorAfiliados;
        private long idAfiliacion;
        
        public EstudianteAfiliado() : base()
        {
            //contadorAfiliados++;
        }

        public EstudianteAfiliado(char tipoDctoIdentidad, long numDctoIdentidad, 
            string apellidos, string nombres, long celular,
            long idAf) : 
            base(tipoDctoIdentidad, numDctoIdentidad, apellidos, nombres, celular)
        {
            //contadorAfiliados++;
            this.idAfiliacion = idAf;
        }

        //public int ContadorAfiliados { get => contadorAfiliados; set => contadorAfiliados = value; }
        public long IdAfiliacion { get => idAfiliacion; set => idAfiliacion = value; }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0, 10:00000}", idAfiliacion);
        }

    }
}
