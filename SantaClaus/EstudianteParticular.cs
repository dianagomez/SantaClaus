using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
    class EstudianteParticular : Estudiante
    {
        private int contadorParticulares;
        private float recargo;
        
        public EstudianteParticular() : base()
        {
            contadorParticulares++;
        }

        public EstudianteParticular(char tipoDctoIdentidad, long numDctoIdentidad, string apellidos, string nombres, long celular, float recargo) :
            base(tipoDctoIdentidad, numDctoIdentidad, apellidos, nombres, celular)
        {
            this.recargo = recargo;
            contadorParticulares++;
        }

        public float Recargo { get => recargo; set => recargo = value; }
        public int ContadorParticulares { get => contadorParticulares; set => contadorParticulares = value; }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0, 10:##########}", Recargo);
        }
    }
}
