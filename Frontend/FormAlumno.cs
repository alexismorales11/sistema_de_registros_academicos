using System;
using Backend;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Frontend
{
    public partial class FormAlumno : Form
    {
        //inicializacion del objeto (metodo constructor)
        Registros reporteALu = new Registros();
        public FormAlumno()
        {
            InitializeComponent();
            dataRegAlumno.DataSource = reporteALu.ListaAlumno().ToList();
        }
        private void BtnGuardarAlum_Click(object sender, EventArgs e)
        {
            //excepciones
            try
            {

                //igualando TXT a los atributos 
                reporteALu.InsertarAlumno(dateTimeAlumno.Value,
                                        Convert.ToString(txtFacultadAlum.Text),
                                        Convert.ToString(txtCursoAlum.Text),
                                        Convert.ToString(txtJornadaAlum.Text),
                                        Convert.ToString(txtNombreAlum.Text),
                                        Convert.ToString(txtCarneAlum.Text),
                                        Convert.ToString(txtSeccionAlumno.Text));
                dataRegAlumno.DataSource = reporteALu.ListaAlumno().ToList();
            }
            catch (Exception btn)
            {
                MessageBox.Show("¡ERROR!" + btn.Message);
            }
        }

        private void BtnEliminarAlum_Click(object sender, EventArgs e)
        {
            //excepciones Try, Catch
            try
            {   
                reporteALu.Buscar = Convert.ToString(txtEliminarAlumno.Text);
                reporteALu.ElimininarAlumno();
                dataRegAlumno.DataSource = reporteALu.ListaAlumno().ToList();
            }
            catch (Exception but)
            {
                if (reporteALu.Buscar != txtEliminarAlumno.Text)
                {
                    MessageBox.Show("¡ERROR!" + but.Message);
                }
                else
                {
                    MessageBox.Show("¡ERROR!"+ but.Message);
                }
            }
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
