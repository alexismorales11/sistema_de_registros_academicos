using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    //clase hija
    public class Asistencias
    {
        //atributos de entrada y salida de datos
        public string Dia1 { get; set; }
        public string Dia2 { get; set; }
        public string Dia3 { get; set; }
        public string Dia4 { get; set; }
        public string Dia5 { get; set; }
        //metodo constructor
        public Asistencias(){}
        public Asistencias(string dia1, string dia2, string dia3, string dia4, string dia5)
        {
            //parametros
            Dia1 = dia1;
            Dia2 = dia2;
            Dia3 = dia3;
            Dia4 = dia4;
            Dia5 = dia5;
        }
    } 
}