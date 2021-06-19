using Backend;
using System;
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
    public partial class FormDocentes : Form
    {
        Registros reporte = new Registros();
        public FormDocentes()
        {
            InitializeComponent();
            dataRegDocente.DataSource = reporte.ListaDocente().ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BordeBotonesRegDocente.Bordes(txtNombreC);
                BordeBotonesRegDocente.Bordes(txtCarne);
                BordeBotonesRegDocente.Bordes(txtCurso);
                BordeBotonesRegDocente.Bordes(txtJornada);
                BordeBotonesRegDocente.Bordes(txtFacultad);
                BordeBotonesRegDocente.Bordes(btnGuardar);
                BordeBotonesRegDocente.Bordes(btnEliminar);
                BordeBotonesRegDocente.Bordes(dataRegDocente);
            }
            catch (Exception a)
            {
                MessageBox.Show("¡ERROR!" + a.Message);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                    //reporte.NomCompleto2 = Convert.ToString(txtNombreC.Text);
                    //reporte.Carne2 = Convert.ToString(txtCarne.Text);
                    //reporte.Curso2 = Convert.ToString(txtCurso.Text);
                    //reporte.Jornada2 = Convert.ToString(txtJornada.Text);
                    //reporte.FacutadD2 = Convert.ToString(txtFacultad.Text);
                    reporte.InsertarDocente(Convert.ToString(txtNombreC.Text), 
                                            Convert.ToString(txtCarne.Text), 
                                            Convert.ToString(txtCurso.Text), 
                                            Convert.ToString(txtJornada.Text),
                                            Convert.ToString(txtFacultad.Text),
                                            dateTimeDocente.Value);
                    dataRegDocente.DataSource = reporte.ListaDocente().ToList();    
            }
            catch (Exception btn)
            {
                MessageBox.Show("¡ERROR!"+btn.Message);
            }
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                reporte.Buscar = Convert.ToString(txtEliminarD.Text);
                reporte.ElimininarDocente(
                    Convert.ToString(txtNombreC.Text),
                    Convert.ToString(txtEliminarD.Text), 
                    Convert.ToString(txtCurso.Text), 
                    Convert.ToString(txtJornada.Text),
                    Convert.ToString(txtFacultad.Text),
                                    dateTimeDocente.Value);
                dataRegDocente.DataSource = reporte.ListaDocente().ToList();
            }
            catch (Exception but)
            {
                if (reporte.Buscar != txtEliminarD.Text)
                { 
                MessageBox.Show("¡ERROR!" + but.Message);
                }
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}