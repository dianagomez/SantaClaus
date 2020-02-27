using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
     abstract class Estudiante
    {
        private char tipoDctoIdentidad;
        private long numDctoIdentidad;
        private string apellidos;
        private string nombres;
        private long celular;
        static private int contadorInscritos;



        public Estudiante()
         {
            contadorInscritos++;
         }

         public Estudiante(char tipoDctoIdentidad, long numDctoIdentidad, string apellidos, string nombres, long celular)
         {
             this.TipoDctoIdentidad = tipoDctoIdentidad;
             this.numDctoIdentidad = numDctoIdentidad;
             this.Apellidos = apellidos;
             this.nombres = nombres;
             this.Celular = celular;
             contadorInscritos++;
        }

        public long NumDctoIdentidad { get => numDctoIdentidad; set => numDctoIdentidad = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public long Celular { get => celular; set => celular = value; }
        public static int ContadorInscritos { get => contadorInscritos; set => contadorInscritos = value; }
        public char TipoDctoIdentidad { get => tipoDctoIdentidad; set => tipoDctoIdentidad = value; }

        public override string ToString()
         {
             return string.Format("{0,-3} {1,10:###############}    {2} {3}",
                    TipoDctoIdentidad, NumDctoIdentidad, Apellidos, Nombres);
         }
         
    }
}
