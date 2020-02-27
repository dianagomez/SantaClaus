using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SantaClaus
{
    class Catalogo
    {
        private List<Curso> catalogoCursos; 
        public void leerCatalogoCSV()
        {
            using (var reader = new StreamReader(@"cursos2.csv"))
            //using (var reader = new StreamReader(@"cursos2.csv", Encoding.UTF8, false))
            {
                catalogoCursos = new List<Curso>();
                while (!reader.EndOfStream)
                {
                    var items = reader.ReadLine().Split(";");
                    catalogoCursos.Add(new Curso(
                        items[0], items[1], float.Parse(items[2])
                        ));
                }
            }
        } // fin del método leerCatalogoCSV

        public List<Curso> getCatalogo()
        { return catalogoCursos; }

        public void imprimirCatalogo()
        {
            // como imprimir el catalogo de la clase Catalogo
            Console.WriteLine("\nCatálogo de cursos leidos del archivo");
            Console.WriteLine("===============================================================");
            foreach (Curso esteCurso in getCatalogo())
            {
                Console.WriteLine(esteCurso);
            }

        }
    }
}
