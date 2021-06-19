using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Backend
{
    public class RegistroInstitucion
    {
        public string NomInstitucion;
        public string DireccionInstitucion;
        public string UsuarioInstitucion;
        public string ContraseñaInstitucion;

        public string nomU;
        public RegistroInstitucion(){}
        public RegistroInstitucion(string institucion, string direccion, string usuario, string contraseña)
        {
            NomInstitucion = institucion;
            DireccionInstitucion = direccion;
            UsuarioInstitucion = usuario;
            ContraseñaInstitucion = contraseña;
        }
        public void GuardarUniversidad()
        {
            try
            {
                string registrar;
                registrar = $"{this.NomInstitucion}|{this.DireccionInstitucion}|{this.UsuarioInstitucion}|{this.ContraseñaInstitucion}";
                StreamWriter Universidad = new StreamWriter(NomInstitucion + ".txt");
                NomInstitucion = nomU;
                Universidad.WriteLine(registrar);
                Universidad.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show("¡ERROR!"+a.Message);
            }
        }
        public void GuardarColegio()
        {
            try
            { 
            string registrar;
            registrar = $"{this.NomInstitucion}|{this.DireccionInstitucion}|{this.UsuarioInstitucion}|{this.ContraseñaInstitucion}";
            StreamWriter Universidad = new StreamWriter(NomInstitucion+".txt");
            Universidad.WriteLine(registrar);
            Universidad.Close();
        }
            catch(Exception a)
            {
                MessageBox.Show("¡ERROR!"+a.Message);
            }
}
        public void GuardarEscuela()
        {
            try
            {
                string registrar;
                registrar = $"{this.NomInstitucion}|{this.DireccionInstitucion}|{this.UsuarioInstitucion}|{this.ContraseñaInstitucion}";
                StreamWriter Universidad = new StreamWriter(NomInstitucion + ".txt");
                Universidad.WriteLine(registrar);
                Universidad.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
    }
}
