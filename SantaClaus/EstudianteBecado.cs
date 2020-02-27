using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
    class EstudianteBecado : Estudiante
    {
        private float valorBeca;

        public EstudianteBecado() : base()
        {
        }

        public EstudianteBecado(char tipoDctoIdentidad, long numDctoIdentidad, 
            string apellidos, string nombres, long celular, 
            float valorBeca) : 
            base(tipoDctoIdentidad, numDctoIdentidad, apellidos,  nombres,  celular)
        {
            this.valorBeca = valorBeca;
        }

        public float ValorBeca { get => valorBeca; set => valorBeca = value; }

        public override string ToString()
        {
            return base.ToString() + string.Format(" {0,C:0}", valorBeca);
        }
    }
}
