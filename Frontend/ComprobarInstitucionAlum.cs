using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using Backend;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class ComprobarInstitucionAlum : Form
    {
        Backend.RegistroInstitucion buscarU = new Backend.RegistroInstitucion();
        public ComprobarInstitucionAlum()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
            if (File.Exists(txtComprobarInstiALum.Text+".txt")) 
            {
                string Buscar;
                Buscar = Convert.ToString(txtComprobarInstiALum.Text);
                StreamReader leer = new StreamReader(txtComprobarInstiALum.Text+".txt");
                string[] caden;
                string linea;

                while ((linea = leer.ReadLine()) != null)
                {
                    caden = linea.Split('|');
                    if (caden[0].Trim().Equals(Buscar))
                    {

                        Form InstitRegistradas = new FormAlumno();
                        AgregarFormulario(InstitRegistradas);
                        //eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                    else
                    {
                        MessageBox.Show("¡Institucion no existente...!");//eliminarAr.WriteLine(cadena);//  eliminarAr.WriteLine(cadena.Split('|')[1]);
                    }
                }
                leer.Close();
            }
            else
            {
                MessageBox.Show("¡Institucion no existente...!");
                
            }
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
        public void AgregarFormulario(Form AddForm)
        {
            try
            { 
            if (this.panelDocentes.Controls.Count > 0)
            {
                this.panelDocentes.Controls.RemoveAt(0);
            }
            AddForm.TopLevel = false;
            this.panelDocentes.Controls.Add(AddForm);
            AddForm.Dock = DockStyle.Fill;
            AddForm.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
    }
}