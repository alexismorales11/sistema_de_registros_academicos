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
    public partial class RegistroEscuela : Form
    {
        Backend.RegistroInstitucion escuela = new Backend.RegistroInstitucion();

        public RegistroEscuela()
        {
            InitializeComponent();
        }

        private void BtnRegEscuela_Click(object sender, EventArgs e)
        {
            try
            { 
            escuela.NomInstitucion = Convert.ToString(txtNombreEscu.Text);
            escuela.DireccionInstitucion = Convert.ToString(txtDireccEscu.Text);
            escuela.UsuarioInstitucion = Convert.ToString(txtUsuarioEscu.Text);
            escuela.ContraseñaInstitucion = Convert.ToString(txtContraseñaEscu.Text);
            escuela.GuardarEscuela();
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
    }
}
