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
    public partial class FormRegistrarInstitucion : Form
    {
        public FormRegistrarInstitucion()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            { 
            this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }

        private void FormRegistrarInstitucion_Load(object sender, EventArgs e)
        {

        }

        private void BtnUniversidad_Click(object sender, EventArgs e)
        {
            try
            { 
            Form InstitRegistradas = new RegistroUniversidad();
            AgregarFormulario(InstitRegistradas);
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AgregarFormulario(Form AddForm)
        {
            try
            { 
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            AddForm.TopLevel = false;
            this.panel2.Controls.Add(AddForm);
            AddForm.Dock = DockStyle.Fill;
            AddForm.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }

        private void BtnColegio_Click(object sender, EventArgs e)
        {
            try
            { 
            Form InstitRegistradas = new RegistroColegios();
            AgregarFormulario(InstitRegistradas);
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }

        private void BtnEscuela_Click(object sender, EventArgs e)
        {
            try
            { 
            Form InstitRegistradas = new RegistroEscuela();
            AgregarFormulario(InstitRegistradas);
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
    }
}
