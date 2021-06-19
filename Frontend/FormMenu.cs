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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        int posX, posY;

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void Panel4_Paint(object sender, PaintEventArgs e){}

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
            Form InstitRegistradas = new ComprobarInstitucionDoc();
                AgregarFormulario(InstitRegistradas);
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
        //metodo para agregar formualrios 
        public void AgregarFormulario (Form AddForm)
        {
            try
            { 
            if (this.panel4.Controls.Count>0)
            {
                this.panel4.Controls.RemoveAt(0);
            }
            AddForm.TopLevel = false;
            this.panel4.Controls.Add(AddForm);
            AddForm.Dock = DockStyle.Fill;
            AddForm.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
        private void BtnRegAlum_Click(object sender, EventArgs e)
        {
            try
            { 
            Form InstitRegistradas = new ComprobarInstitucionAlum();
            AgregarFormulario(InstitRegistradas);
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }

        private void BtnAsisALum_Click(object sender, EventArgs e)
        {
            try
            {
            Form InstitRegistradas = new AsistenciaAlumno();
            AgregarFormulario(InstitRegistradas);
            }
            catch(Exception a)
            {
                MessageBox.Show("¡ERROR!"+a.Message);
            }
        }

        private void BtnAsisDocente_Click(object sender, EventArgs e)
        {
            try
            {
                Form InstitRegistradas = new AsistenciaDocente();
                AgregarFormulario(InstitRegistradas);
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }

        private void BtnReporteDocente_Click(object sender, EventArgs e)
        {
            try
            {
                Form InstitRegistradas = new ReporteDocente();
                AgregarFormulario(InstitRegistradas);
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }

        private void BtnReporteAlumno_Click(object sender, EventArgs e)
        {

        }

        private void BtnReporteCurso_Click(object sender, EventArgs e)
        {

        }

        private void BtnReporteSeccion_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            { 
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left += (e.X - posX);
                Top += (e.Y - posY);
            }
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
    }
}
