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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Botonaceptar_Click(object sender, EventArgs e)
        {
            try
            { 
            if (usuario.Text == "admin" && contrasena.Text == "12345")
            {
                // MessageBox.Show("Ingresando");
                //this.Hide();
                Form formulario1 = new FormMenu();
                formulario1.Show();
            }
            else
            {
                label2.Show();
            }
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
        int posX, posY;

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
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

        private void BtnRegUniversidad_Click(object sender, EventArgs e)
        {
            try
            { 
            Form InstitRegistradas = new FormRegistrarInstitucion();
            AgregarFormulario(InstitRegistradas);
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
            if (this.panel4.Controls.Count > 0)
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

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
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
