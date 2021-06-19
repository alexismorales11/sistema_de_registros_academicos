using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Backend
{
    public class Registros
    {
        #region CODIGO COMPLETO
        //metodo constructor
        public Registros() { }  
        //atributos
        public string Buscar;
        
        public string FacutadD2;
        public string Curso2;
        public string Jornada2;
        public string NomCompleto2;
        public string Carne2;
        public string Fecha2D;
        
        public Registros(Docente docen)
        {
            //parametros
            docen.NombreCompleto = NomCompleto2;
            docen.ID = Carne2;
            docen.NombreDelCurso = Curso2;
            docen.Jornada = Jornada2;
            docen.Facutad = FacutadD2;
            docen.Fecha = Fecha2D;
        }
        public List<Docente> ListaDocente()
        {
            List<Docente> docente = new List<Docente>();
            try
            {
                if (File.Exists("Docente.txt")) 
                {
                    StreamReader FileDocente = new StreamReader("Docente.txt");
                    string registro;
                    while ((registro = FileDocente.ReadLine()) != null)
                    {
                        string[] atributos = registro.Split('|');

                        Docente Docentes = new Docente();
                        Docentes.NombreCompleto = atributos[0];
                        Docentes.ID = atributos[1];
                        Docentes.NombreDelCurso = atributos[2];
                        Docentes.Jornada = atributos[3];
                        Docentes.Facutad = atributos[4];
                        Docentes.Fecha = atributos[5];
                        docente.Add(Docentes);
                    }
                    FileDocente.Close();
                }
            }
            catch (Exception Lista)
            {
                MessageBox.Show("¡ERROR!" + Lista.Message);
            }
            return docente;
        }
        public void InsertarDocente(string nombrecompleto, string carne, string curso, string jornada, string facultadD, DateTime fechaDate)
        {
            try
            {
                string registro;
                //Guardando datos en la variable *registro*
                registro = $"{nombrecompleto}|{carne}|{curso}|{jornada}|{facultadD}|{fechaDate}";
                //creacioon de archivos
                StreamWriter Filedocente = new StreamWriter("Docente.txt", true);
                //guardando datos de variable registro en archivo 
                Filedocente.WriteLine(registro);
                //cierre de archivo
                Filedocente.Close();
            }
            catch (Exception d)
            {
                MessageBox.Show("¡ERROR!" + d.Message);
            }
        }
        //Metodo para modificar/actualizar datos
        public void ElimininarDocente(string nombrecompleto, string carne, string curso, string jornada, string facultadD, DateTime fechaDate)
        {
            try
            {
                string empleado;
                empleado = $"{this.Buscar}";
                FileStream est = new FileStream("Docente.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader srFile2 = new StreamReader(est);

                FileStream aux = new FileStream("auxDocente.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter eliminarAr = new StreamWriter(aux);
                
                string[] campos;
                string cadena;
                while ((cadena = srFile2.ReadLine()) != null)
                {
                    campos = cadena.Split('|');
                    if (campos[1].Trim().Equals(empleado))
                    {

                        string registro;
                        registro = $"{nombrecompleto}|{carne}|{curso}|{jornada}|{facultadD}|{fechaDate}";
                        eliminarAr.WriteLine(registro);
                    }
                    else
                    {
                        eliminarAr.WriteLine(cadena);
                    }
                }
                srFile2.Close();
                eliminarAr.Close();
                est.Close();
                aux.Close();
                File.Delete("Docente.txt");
                File.Move("auxDocente.txt", "Docente.txt");
            }
            catch (Exception fe)
            {
                MessageBox.Show("¡ERROR!" + fe.Message);
                //Console.WriteLine("ERROR" + fe.Message);
            }
        }
        public string FacultadA2;
        public string CursoA2;
        public string JornadaA2;
        public string NomCompletoA2;
        public string CarneA2;
        public string HorarioA2;
        public string NombresCompletos { get; set; }


        public Registros(Alumno alum)
        {
            alum.Horario = HorarioA2;
            alum.Facultad = FacultadA2;
            alum.Curso = CursoA2;
            alum.Jornada = JornadaA2;
            alum.NombreCompleto = NomCompletoA2;
            alum.ID = CarneA2;
            alum.NombreCompleto = NombresCompletos;
        }
        #endregion

        public void InsertarAlumno(DateTime horarioDate, string facultadA, string curso, string jornada, string nombrecompleto, string carne, string seccion)
        {
            try
            {
                string registroAlum;
                registroAlum = $"{horarioDate}|{facultadA}|{curso}|{jornada}|{nombrecompleto}|{carne}|{seccion}";
                StreamWriter FileAlumno = new StreamWriter("Alumnos.txt", true);
                FileAlumno.WriteLine(registroAlum);
                FileAlumno.Close();
            }
            catch (Exception d)
            {
                MessageBox.Show("¡ERROR!" + d.Message);
            }
        }
        public List<Alumno> ListaAlumno()
        {
            List<Alumno> newalumno = new List<Alumno>();
            try
            {
                if (File.Exists("Alumnos.txt"))
                {
                    StreamReader FileAlumno = new StreamReader("Alumnos.txt");
                    string registroAlum;
                    while ((registroAlum = FileAlumno.ReadLine()) != null)
                    {
                        string[] atributos = registroAlum.Split('|');
                        Alumno Alumnos = new Alumno();
                        Alumnos.Horario = atributos[0];
                        Alumnos.Facultad = atributos[1];
                        Alumnos.Curso = atributos[2];
                        Alumnos.Jornada = atributos[3];
                        Alumnos.NombreCompleto = atributos[4];  
                        Alumnos.ID = atributos[5];
                        Alumnos.Seccion = atributos[6];
                        newalumno.Add(Alumnos);
                    }
                    FileAlumno.Close();
                }
            }
            catch (Exception Lista)
            {
                MessageBox.Show("¡ERROR!" + Lista.Message);
            }
            return newalumno;
        }

        public void ElimininarAlumno()
        {
            try
            {
                string empleado;
                empleado = $"{this.Buscar}";
                FileStream est = new FileStream("Alumnos.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader srFile2 = new StreamReader(est);
                FileStream aux = new FileStream("auxAlumnos.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter eliminarAr = new StreamWriter(aux);
                string[] campos;
                string cadena;
                while ((cadena = srFile2.ReadLine()) != null)
                {
                    campos = cadena.Split('|');
                    if (campos[4].Trim().Equals(empleado))
                    {//eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                    else
                    {
                        eliminarAr.WriteLine(cadena);//  eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                }
                srFile2.Close();
                eliminarAr.Close();
                est.Close();
                aux.Close();
                File.Delete("Alumnos.txt");
                File.Move("auxAlumnos.txt", "Alumnos.txt");
            }
            catch (Exception fe)
            {
                MessageBox.Show("¡ERROR!" + fe.Message);
                //Console.WriteLine("ERROR" + fe.Message);
            }
        }
        #region ASISTENCIA DOCENTE
        public void NombreALumnosAsistencia()
        {
            try
            {
                string empleado;
                empleado = $"{this.Buscar}";
                FileStream est = new FileStream("Alumnos.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader srFile2 = new StreamReader(est);
                FileStream aux = new FileStream("NombreAlumnos.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter eliminarAr = new StreamWriter(aux);
                string[] campos;
                string cadena;
                while ((cadena = srFile2.ReadLine()) != null)
                {
                    campos = cadena.Split('|');
                    if (campos[1].Trim().Equals(empleado))
                    {//eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                    else
                    {
                        eliminarAr.WriteLine(cadena.Split('|')[4]);
                    }
                }
                srFile2.Close();
                eliminarAr.Close();
                est.Close();
                aux.Close();
            }
            catch (Exception fe)
            {
                MessageBox.Show("¡ERROR!" + fe.Message);
            }
        }

        public List<Registros> MostrarNombreAlumno()
        {
            List<Registros> newalumno = new List<Registros>();
            try
            {
                if (File.Exists("NombreAlumnos.txt"))
                {
                    StreamReader FileAlumno = new StreamReader("NombreAlumnos.txt");
                    string registroAlum;
                    while ((registroAlum = FileAlumno.ReadLine()) != null)
                    {
                        string[] atributos = registroAlum.Split('|');
                        Registros Alumno = new Registros();
                        Alumno.NombresCompletos = atributos[0];
                        newalumno.Add(Alumno);
                    }
                    FileAlumno.Close();
                }
            }
            catch (Exception Lista)
            {
                MessageBox.Show("¡ERROR!" + Lista.Message);
            }
            return newalumno;
        }


        public string d1;
        public string d2;
        public string d3;
        public string d4;
        public string d5;

        public Registros(Asistencias asis)
        {
            asis.Dia1 = d1;
            asis.Dia2 = d2;
            asis.Dia3 = d3;
            asis.Dia4 = d4;
            asis.Dia5 = d5;
        }
        public void InsertarAsistenciaPorDia(string dia1, string dia2, string dia3, string dia4, string dia5)
        {
            try
            {
                string registro;
                registro = $"{dia1}|{dia2}|{dia3}|{dia4}|{dia5}";
                StreamWriter Filedocente = new StreamWriter("AsistenciasAlumnos.txt", true);
                Filedocente.WriteLine(registro);
                Filedocente.Close();
            }
            catch (Exception d)
            {
                MessageBox.Show("¡ERROR!" + d.Message);
            }
        }
        public List<Asistencias> ListaAsistenciasAlumnos()
        {
            List<Asistencias> asisAlum = new List<Asistencias>();
            try
            {
                if (File.Exists("AsistenciasAlumnos.txt"))
                {
                    StreamReader FileDocente = new StreamReader("AsistenciasAlumnos.txt");
                    string registro;
                    while ((registro = FileDocente.ReadLine()) != null)
                    {
                        string[] atributos = registro.Split('|');

                        Asistencias asistenciasAlum = new Asistencias();
                        asistenciasAlum.Dia1 = atributos[0];
                        asistenciasAlum.Dia2 = atributos[1];
                        asistenciasAlum.Dia3 = atributos[2];
                        asistenciasAlum.Dia4 = atributos[3];
                        asistenciasAlum.Dia5 = atributos[4];
                        asisAlum.Add(asistenciasAlum);
                    }
                    FileDocente.Close();
                }
            }
            catch (Exception Lista)
            {
                MessageBox.Show("¡ERROR!" + Lista.Message);
            }
            return asisAlum;
        }
        public void ElimininarAsisAlumno()
        {
            try
            {
                string empleado;
                empleado = $"{this.Buscar}";
                FileStream est = new FileStream("AsistenciasAlumnos.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader srFile2 = new StreamReader(est);
                FileStream aux = new FileStream("AuxAsistenciasAlumnos.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter eliminarAr = new StreamWriter(aux);
                string[] campos;
                string cadena;
                while ((cadena = srFile2.ReadLine()) != null)
                {
                    campos = cadena.Split('|');
                    if (campos[0].Trim().Equals(empleado))
                    {//eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                    else
                    {
                        eliminarAr.WriteLine(cadena);//  eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                }
                srFile2.Close();
                eliminarAr.Close();
                est.Close();
                aux.Close();
                File.Delete("AsistenciasAlumnos.txt");
                File.Move("AuxAsistenciasAlumnos.txt", "AsistenciasAlumnos.txt");
            }
            catch (Exception fe)
            {
                MessageBox.Show("¡ERROR!" + fe.Message);
                //Console.WriteLine("ERROR" + fe.Message);
            }
        }
        
        public void InsertarAsistenciaPorDiaDocente(string dia1, string dia2, string dia3, string dia4, string dia5)
        {
            try
            {
                string registro;
                registro = $"{dia1}|{dia2}|{dia3}|{dia4}|{dia5}";
                StreamWriter Filedocente = new StreamWriter("AsistenciasDocente.txt", true);
                Filedocente.WriteLine(registro);
                Filedocente.Close();
            }
            catch (Exception d)
            {
                MessageBox.Show("¡ERROR!" + d.Message);
            }
        }
        public List<Asistencias> ListaAsistenciasDocente()
        {
            List<Asistencias> asisAlum = new List<Asistencias>();
            try
            {
                if (File.Exists("AsistenciasDocente.txt"))
                {
                    StreamReader FileDocente = new StreamReader("AsistenciasDocente.txt");
                    string registro;
                    while ((registro = FileDocente.ReadLine()) != null)
                    {
                        string[] atributos = registro.Split('|');

                        Asistencias asistenciasAlum = new Asistencias();
                        asistenciasAlum.Dia1 = atributos[0];
                        asistenciasAlum.Dia2 = atributos[1];
                        asistenciasAlum.Dia3 = atributos[2];
                        asistenciasAlum.Dia4 = atributos[3];
                        asistenciasAlum.Dia5 = atributos[4];
                        asisAlum.Add(asistenciasAlum);
                    }
                    FileDocente.Close();
                }
            }
            catch (Exception Lista)
            {
                MessageBox.Show("¡ERROR!" + Lista.Message);
            }
            return asisAlum;
        }
        public void ElimininarAsisDocente()
        {
            try
            {
                string empleado;
                empleado = $"{this.Buscar}";
                FileStream est = new FileStream("AsistenciasDocente.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader srFile2 = new StreamReader(est);
                FileStream aux = new FileStream("AuxAsistenciasDocente.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter eliminarAr = new StreamWriter(aux);
                string[] campos;
                string cadena;
                while ((cadena = srFile2.ReadLine()) != null)
                {
                    campos = cadena.Split('|');
                    if (campos[0].Trim().Equals(empleado))
                    {//eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                    else
                    {
                        eliminarAr.WriteLine(cadena);//  eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                }
                srFile2.Close();
                eliminarAr.Close();
                est.Close();
                aux.Close();
                File.Delete("AsistenciasDocente.txt");
                File.Move("AuxAsistenciasDocente.txt", "AsistenciasDocente.txt");
            }
            catch (Exception fe)
            {
                MessageBox.Show("¡ERROR!" + fe.Message);
                //Console.WriteLine("ERROR" + fe.Message);
            }
        }
        public void NombreDocenteAsistencia()
        {
            try
            {
                string empleado;
                empleado = $"{this.Buscar}";
                FileStream est = new FileStream("Docente.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader srFile2 = new StreamReader(est);
                FileStream aux = new FileStream("NombreDocentes.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter eliminarAr = new StreamWriter(aux);
                string[] campos;
                string cadena;
                while ((cadena = srFile2.ReadLine()) != null)
                {
                    campos = cadena.Split('|');
                    if (campos[1].Trim().Equals(empleado))
                    {//eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                    else
                    {
                        eliminarAr.WriteLine(cadena.Split('|')[0]);
                    }
                }
                srFile2.Close();
                eliminarAr.Close();
                est.Close();
                aux.Close();
            }
            catch (Exception fe)
            {
                MessageBox.Show("¡ERROR!" + fe.Message);
            }
        }

        public List<Registros> MostrarNombreDocente()
        {
            List<Registros> newalumno = new List<Registros>();
            try
            {
                if (File.Exists("NombreDocentes.txt"))
                {
                    StreamReader FileAlumno = new StreamReader("NombreDocentes.txt");
                    string registroAlum;
                    while ((registroAlum = FileAlumno.ReadLine()) != null)
                    {
                        string[] atributos = registroAlum.Split('|');
                        Registros Alumno = new Registros();
                        Alumno.NombresCompletos = atributos[0];
                        newalumno.Add(Alumno);
                    }
                    FileAlumno.Close();
                }
            }
            catch (Exception Lista)
            {
                MessageBox.Show("¡ERROR!" + Lista.Message);
            }
            return newalumno;
        }
        #endregion
    }
}