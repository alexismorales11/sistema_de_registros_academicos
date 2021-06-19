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
    public partial class RegistroUniversidad : Form
    {

        Backend.RegistroInstitucion universidad = new Backend.RegistroInstitucion();
        public RegistroUniversidad()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
            universidad.NomInstitucion = Convert.ToString(txtNombreUniv.Text);
            universidad.DireccionInstitucion = Convert.ToString(txtDireccUniv.Text);
            universidad.UsuarioInstitucion = Convert.ToString(txtUsuarioUniv.Text);
            universidad.ContraseñaInstitucion = Convert.ToString(txtContraseñaUnive.Text);
            universidad.GuardarUniversidad();
            this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
    }
}
