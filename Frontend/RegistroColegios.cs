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
    public partial class RegistroColegios : Form
    {
        Backend.RegistroInstitucion colegio = new Backend.RegistroInstitucion();
        public RegistroColegios()
        {
            InitializeComponent();
        }

        private void BtnGuardarRegColeegio_Click(object sender, EventArgs e)
        {
            try
            {
                colegio.NomInstitucion = Convert.ToString(txtNombreColegio.Text);
                colegio.DireccionInstitucion = Convert.ToString(txtDireccColegio.Text);
                colegio.UsuarioInstitucion = Convert.ToString(txtUsuarioColegio.Text);
                colegio.ContraseñaInstitucion = Convert.ToString(txtContraseñaColegio.Text);
                colegio.GuardarColegio();
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
    }
}
