using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaClaus
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bienvenidos al Instituto SantaClaus");
            Console.WriteLine("\nCatálogo de cursos navideños");

            //se instancia un objeto con constructor sin argumentos
            //luego se van asignando valores
            /*Curso monos1 = new Curso();
            monos1.nombre = "Moños navideños nivel básico";
            monos1.horario = "lunes y miércoles de 8 a 10 am";
            monos1.costo = 75000F;
            //Console.WriteLine("\n{0}\n{1} Costo: {2:C2}", monos1.nombre, monos1.horario, monos1.costo);
            Console.WriteLine(monos1);
            */
            
            //se instancia un objeto con constructor con argumentos
            //desde el mismo comando de creación se pasan los valores del nuevo objeto
            //Curso monos2 = new Curso("Moño navideños nivel avanzado", "martes y viernes 7 a 9 pm", 150000F);
            //Console.WriteLine("\n{0}\n{1} Costo: {2:C2}", monos2.nombre, monos2.horario, monos2.costo);
            //Console.WriteLine(monos2);

            //pueden existir múltiples constructores, 
            //siempre y cuando tengan diferente número o tipo de argumentos
            /*Curso monos3 = new Curso("Moño navideños nivel super avanzado", "miércoles y sábado 10 a 12 m");
            monos3.costo = 50000f;
            //Console.WriteLine("\n{0}\n{1} Costo: {2:C2}", monos3.nombre, monos3.horario, monos3.costo);
            Console.WriteLine(monos3);
            */

            //********** instancias con atributos privados **************//
            /*
            Curso cocina1 = new Curso("Buñuelos", "miércoles y sábado 3 a 5 pm");
            cocina1.setCosto(50000f);
            //Console.WriteLine("{0}\t\t{1}\t\t{2:C2}", cocina1.getNombre(), cocina1.getHorario(), cocina1.getCosto());

            Curso cocina2 = new Curso("Natilla", "miércoles y sábado 1 a 3 pm",30000f);
            //Console.WriteLine(cocina2);

            Curso cocina3 = new Curso("Capón relleno", "martes y jueves 2 a 6 pm",120000f);
            //Console.WriteLine(cocina3);

            Curso cocina4 = new Curso();
            cocina4.capturarDatosPorConsola();
            //Console.WriteLine(cocina4);

            Curso cocina5 = new Curso("Buñuelos", "lunes y jueves de 3 a 5 pm");
            cocina5.setCosto(50000f);
            //Console.WriteLine("{0}\t\t{1}\t\t{2:C2}", cocina5.getNombre(), cocina5.getHorario(), cocina5.getCosto());

            //crear un vector de objetos
            Curso[] vectorCursos = new Curso[4];
            vectorCursos[0] = cocina1;
            vectorCursos[1] = cocina2;
            vectorCursos[2] = cocina3;
            vectorCursos[3] = cocina4;
            
            Console.WriteLine("\nCatálogo de cursos de cocina navideños, usando vectores");
            Console.WriteLine("=================================================================");
            for (int i = 0; i < vectorCursos.Length; i++)
            {
                Console.WriteLine(vectorCursos[i]);
            }


            //crear un arrayList de objetos
            List<Curso> listaCursos = new List<Curso>();
            listaCursos.Add(cocina1);
            listaCursos.Add(cocina2);
            listaCursos.Add(cocina3);
            listaCursos.Add(cocina4);
            listaCursos.Add(cocina5);
            
            Console.WriteLine("\nCatálogo de cursos de cocina navideños, usando listas");
            Console.WriteLine("===============================================================");
            foreach (Curso esteCurso in listaCursos)
            {
                Console.WriteLine(esteCurso);
            }



            //como ordenar listas con el comando OrderBy
            Console.WriteLine("\nCatálogo de cursos de cocina navideños ordenados por nombre");
            Console.WriteLine("===============================================================");
            //este segmento toma la listaCursos, le aplica el método OrderBy 
            //el cual ordena por el atributo nombre (getNombre()), 
            //el resultado lo aloja en la variable x de la cual no se anticipa su tipo de datos
            //este resultado lo convierte en una lista (con el comando .ToList()
            //y lo deposita en una nueva estructura que es una lista de cursos llamada listaCursosOrdenadaPorNombre
            List<Curso> listaCursosOrdenadaPorNombre = listaCursos.OrderBy(x => x.getNombre()).ThenBy(y => y.getCosto()).ToList();
            foreach (Curso estecurso in listaCursosOrdenadaPorNombre)
            {
                Console.WriteLine(estecurso);
            }






            //como ordenar listas con el comando OrderBy
            Console.WriteLine("\nCatálogo de cursos de cocina navideños ordenados por horario");
            Console.WriteLine("===============================================================");
            //en esta forma el listado ordenado por horario fue reasignado a la misma estructura listaCursos, 
            //luego quedó modificado con el nuevo orden
            listaCursos = listaCursos.OrderBy(x => x.getHorario()).ToList();
            foreach (Curso estecurso in listaCursos)
            {
                Console.WriteLine(estecurso);
            }
            */
 
            // como trabajar con una clase Catalogo y las funciones propias de este
            Catalogo catalogo2020 = new Catalogo();
            catalogo2020.leerCatalogoCSV();
            catalogo2020.imprimirCatalogo();

            //********** AHORA VAN LOS ESTUDIANTES **************
            Console.WriteLine("\n\nEstudiantes Inscritos");
            Console.WriteLine("=============================================================");
            Console.WriteLine("Doc Identidad          Nombre Completo         # Afiliación  ");
            
            
            //Crear estudiante de la clase Estudiante mediante el constructor con argumentos
            Estudiante est1 = new Estudiante('c',91211211,"Prada Diaz","Luis Alfonso",3118989899);
            Console.WriteLine(est1);

            //Crear estudiante con constructor sin argumentos y 
            //luego asignar sus datos iniciales a los campos habilitados para recibir datos.
            Estudiante est2 = new Estudiante();
            est2.TipoDctoIdentidad = 'p';
            est2.NumDctoIdentidad = 3434343;
            est2.Apellidos = "Orostegui Plata";
            est2.Nombres = "Olga Lucía";
            est2.Celular = 316989898;
            Console.WriteLine(est2);
            


            //Crear estudiante de la clase  EstudianteAfiliado
            EstudianteAfiliado estAf1 = new EstudianteAfiliado('c',63636363,"Garcia Jerez","Claudia Patricia",3136547896,25);
            Console.WriteLine(estAf1);

            //Crear estudiante de la clase  EstudianteAfiliado
            EstudianteAfiliado estAf2 = new EstudianteAfiliado('c', 65656565, "Hernandez Arenas", "María Carmen", 3144444444,44);
            Console.WriteLine(estAf2);

            Console.WriteLine("=============================================================");
            //Console.WriteLine("\n\nTotal estudiantes afiliados: \t{0, 10:#####}", EstudianteAfiliado.ContadorInscritos  );
            //Console.WriteLine("\n\nTotal estudiantes particulares: {0, 10:#####}", EstudianteParticular.ContadorInscritos);
            Console.WriteLine("\n\nTotal estudiantes inscritos: \t{0, 10:#####}", Estudiante.ContadorInscritos);

            Console.ReadKey();
        }
    }
}
