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
    public partial class AsistenciaDocente : Form
    {
        Backend.Registros docente = new Backend.Registros();
        public AsistenciaDocente()
        {
            InitializeComponent();
            docente.NombreDocenteAsistencia();

            dataNOMAsistenciasDocente.DataSource = docente.MostrarNombreDocente().ToList();
            dataAsistenciaDocente.DataSource = docente.ListaAsistenciasDocente().ToList();
        }
        private void BtnGuardarAsisAlum_Click(object sender, EventArgs e)
        {
            try
            {
                docente.InsertarAsistenciaPorDiaDocente(Convert.ToString(txtDia1Doc.Text),
                                                 Convert.ToString(txtDia2Doc.Text),
                                                 Convert.ToString(txtDia3Doc.Text),
                                                 Convert.ToString(txtDia4Doc.Text),
                                                 Convert.ToString(txtDia5Doc.Text));
                dataAsistenciaDocente.DataSource = docente.ListaAsistenciasDocente().ToList();
            }
            catch (Exception btn)
            {
                MessageBox.Show("¡ERROR!" + btn.Message);
            }
        }
        private void DataAsistenciaAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
