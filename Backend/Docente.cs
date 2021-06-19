using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Backend
{
    public class Docente:Persona
    {
        public string Facutad{ get; set; }
        public string NombreDelCurso { get; set; }
        public string Jornada { get; set; }
        public string Fecha { get; set; }
        public DateTime FechaDate;
        
        public Docente(){}
        public Docente(string nombrecompleto, string carne, string curso, string jornada,string facultadD, DateTime fechaDate) :base (nombrecompleto,carne)
        {
            FechaDate = fechaDate;
            NombreCompleto = nombrecompleto;
            ID = carne;
            NombreDelCurso = curso;
            Jornada = jornada;
            Facutad = facultadD;
        }
        public Docente(string nombrecompleto, string carne, string curso, string jornada, string facultadD, string fecha)
        {
            Fecha = fecha;
            NombreCompleto = nombrecompleto;
            ID = carne;
            NombreDelCurso = curso;
            Jornada = jornada;
            Facutad = facultadD;

        }
    }
}