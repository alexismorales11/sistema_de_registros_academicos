using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    //herencia 
    public class Alumno:Persona
    {
        //atributos
        public DateTime HorarioDate;
        public string Facultad {get; set;}
        public string Curso { get; set; }
        public string Seccion { get; set; }
        public string Jornada { get; set; }
        public string Horario { get; set; } 
        //metodos constructores
        public Alumno() { }
        public Alumno(DateTime horarioDate, string facultadA, string curso, string jornada, string nombrecompleto, string carne, string seccion) : base(nombrecompleto, carne)
        {
            NombreCompleto = nombrecompleto;
            Curso = curso;
            ID = carne;
            Jornada = jornada;
            Facultad = facultadA;
            HorarioDate = horarioDate;
            Seccion= seccion;
        }
        public Alumno( string horarioString, string facultadA, string curso, string jornada, string nombrecompleto, string carne, string seccion)
        {
            Facultad = facultadA;
            Curso = curso;
            Jornada = jornada;
            NombreCompleto = nombrecompleto;
            ID = carne;
            Seccion = seccion;
            Horario = horarioString;
        }
        public Alumno(string nombresAlumnos)
        {
            NombreCompleto = nombresAlumnos;
        }
    }
}
