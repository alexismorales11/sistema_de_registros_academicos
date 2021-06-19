namespace Frontend
{
    partial class FormDocentes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataRegDocente = new System.Windows.Forms.DataGridView();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtJornada = new System.Windows.Forms.TextBox();
            this.txtFacultad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEliminarD = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeDocente = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRegDocente
            // 
            this.dataRegDocente.AllowUserToAddRows = false;
            this.dataRegDocente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.dataRegDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataRegDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRegDocente.Location = new System.Drawing.Point(14, 205);
            this.dataRegDocente.Name = "dataRegDocente";
            this.dataRegDocente.ReadOnly = true;
            this.dataRegDocente.RowHeadersWidth = 51;
            this.dataRegDocente.RowTemplate.Height = 24;
            this.dataRegDocente.Size = new System.Drawing.Size(947, 386);
            this.dataRegDocente.TabIndex = 0;
            // 
            // txtNombreC
            // 
            this.txtNombreC.BackColor = System.Drawing.Color.White;
            this.txtNombreC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreC.Location = new System.Drawing.Point(14, 104);
            this.txtNombreC.Multiline = true;
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(217, 25);
            this.txtNombreC.TabIndex = 1;
            // 
            // txtCarne
            // 
            this.txtCarne.BackColor = System.Drawing.Color.White;
            this.txtCarne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarne.Location = new System.Drawing.Point(443, 104);
            this.txtCarne.Multiline = true;
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(149, 25);
            this.txtCarne.TabIndex = 2;
            // 
            // txtCurso
            // 
            this.txtCurso.BackColor = System.Drawing.Color.White;
            this.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurso.Location = new System.Drawing.Point(249, 104);
            this.txtCurso.Multiline = true;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(164, 25);
            this.txtCurso.TabIndex = 3;
            // 
            // txtJornada
            // 
            this.txtJornada.BackColor = System.Drawing.Color.White;
            this.txtJornada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJornada.Location = new System.Drawing.Point(611, 104);
            this.txtJornada.Multiline = true;
            this.txtJornada.Name = "txtJornada";
            this.txtJornada.Size = new System.Drawing.Size(149, 25);
            this.txtJornada.TabIndex = 4;
            // 
            // txtFacultad
            // 
            this.txtFacultad.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtFacultad.BackColor = System.Drawing.Color.White;
            this.txtFacultad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultad.Location = new System.Drawing.Point(782, 104);
            this.txtFacultad.Multiline = true;
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.Size = new System.Drawing.Size(149, 25);
            this.txtFacultad.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Limelight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(409, 143);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 48);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Carne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Jornada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad de Cursos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(806, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Facultad";
            // 
            // txtEliminarD
            // 
            this.txtEliminarD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.txtEliminarD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEliminarD.ForeColor = System.Drawing.Color.White;
            this.txtEliminarD.Location = new System.Drawing.Point(835, 150);
            this.txtEliminarD.Multiline = true;
            this.txtEliminarD.Name = "txtEliminarD";
            this.txtEliminarD.Size = new System.Drawing.Size(126, 34);
            this.txtEliminarD.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(747, 147);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 38);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 21;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(426, 41);
            this.label8.TabIndex = 19;
            this.label8.Text = "Registro de Docentes";
            // 
            // dateTimeDocente
            // 
            this.dateTimeDocente.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDocente.Location = new System.Drawing.Point(40, 162);
            this.dateTimeDocente.Name = "dateTimeDocente";
            this.dateTimeDocente.Size = new System.Drawing.Size(176, 22);
            this.dateTimeDocente.TabIndex = 20;
            // 
            // FormDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(985, 603);
            this.Controls.Add(this.dateTimeDocente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtEliminarD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtFacultad);
            this.Controls.Add(this.txtJornada);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.dataRegDocente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDocentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRegDocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRegDocente;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtJornada;
        private System.Windows.Forms.TextBox txtFacultad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEliminarD;
        private System.Windows.Forms.Button btnEliminar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeDocente;
    }
}

