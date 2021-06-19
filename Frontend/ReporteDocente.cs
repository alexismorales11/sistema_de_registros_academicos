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
    public partial class ReporteDocente : Form
    {
        Backend.Registros reporte = new Backend.Registros();
        public ReporteDocente()
        {
            InitializeComponent();
            reporte.NombreALumnosAsistencia();
            reporteDocentesNom.DataSource = reporte.MostrarNombreAlumno().ToList();
            dataADocentes.DataSource = reporte.ListaAsistenciasAlumnos().ToList();
        }
        private void ReporteDocente_Load(object sender, EventArgs e)
        {

        }
    }
}
