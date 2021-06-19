using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class AsistenciaAlumno : Form
    {
        Backend.Registros alumnos = new Backend.Registros();
        public AsistenciaAlumno()
        {
            InitializeComponent();
             alumnos.NombreALumnosAsistencia();
            dataNOMAsistenciasAlumnos.DataSource = alumnos.MostrarNombreAlumno().ToList();
            dataAsistenciaAlumno.DataSource = alumnos.ListaAsistenciasAlumnos().ToList();
        }

        private void AsistemciaAlumno_Load(object sender, EventArgs e)
        {

        }

        private void TxtEliminarAsisAlumno_TextChanged(object sender, EventArgs e){}

        private void BtnGuardarAsisAlum_Click(object sender, EventArgs e)
        {
            try
            {
                alumnos.InsertarAsistenciaPorDia(Convert.ToString(txtDia1Alum.Text), 
                                                 Convert.ToString(txtDia2Alum.Text), 
                                                 Convert.ToString(txtDia3Alum.Text), 
                                                 Convert.ToString(txtDia4Alum.Text),
                                                 Convert.ToString(txtDia5Alum.Text));
                dataAsistenciaAlumno.DataSource = alumnos.ListaAsistenciasAlumnos().ToList();
            }
            catch (Exception btn)
            {
                MessageBox.Show("¡ERROR!" + btn.Message);
            }
        }
    }
}
