using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Persona
    {
        public string NombreCompleto { get; set; }
        public string ID { get; set; }
        public Persona(){}
        public Persona(string nombrecompleto, string carne)
        {
            NombreCompleto = nombrecompleto;
            ID = carne;
        }
    }
}
