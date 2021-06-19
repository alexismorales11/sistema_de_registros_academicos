namespace Frontend
{
    partial class FormAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimeAlumno = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarAlum = new System.Windows.Forms.Button();
            this.txtEliminarAlumno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarAlum = new System.Windows.Forms.Button();
            this.txtFacultadAlum = new System.Windows.Forms.TextBox();
            this.txtJornadaAlum = new System.Windows.Forms.TextBox();
            this.txtCursoAlum = new System.Windows.Forms.TextBox();
            this.txtCarneAlum = new System.Windows.Forms.TextBox();
            this.txtNombreAlum = new System.Windows.Forms.TextBox();
            this.dataRegAlumno = new System.Windows.Forms.DataGridView();
            this.txtSeccionAlumno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeAlumno
            // 
            this.dateTimeAlumno.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAlumno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAlumno.Location = new System.Drawing.Point(25, 163);
            this.dateTimeAlumno.Name = "dateTimeAlumno";
            this.dateTimeAlumno.Size = new System.Drawing.Size(180, 22);
            this.dateTimeAlumno.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(415, 41);
            this.label8.TabIndex = 35;
            this.label8.Text = "Registro de Alumnos";
            // 
            // btnEliminarAlum
            // 
            this.btnEliminarAlum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminarAlum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnEliminarAlum.FlatAppearance.BorderSize = 0;
            this.btnEliminarAlum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnEliminarAlum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnEliminarAlum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlum.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarAlum.Location = new System.Drawing.Point(705, 156);
            this.btnEliminarAlum.Name = "btnEliminarAlum";
            this.btnEliminarAlum.Size = new System.Drawing.Size(105, 38);
            this.btnEliminarAlum.TabIndex = 34;
            this.btnEliminarAlum.Text = "ELIMINAR";
            this.btnEliminarAlum.UseVisualStyleBackColor = false;
            this.btnEliminarAlum.Click += new System.EventHandler(this.BtnEliminarAlum_Click);
            // 
            // txtEliminarAlumno
            // 
            this.txtEliminarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.txtEliminarAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEliminarAlumno.ForeColor = System.Drawing.Color.White;
            this.txtEliminarAlumno.Location = new System.Drawing.Point(816, 156);
            this.txtEliminarAlumno.Multiline = true;
            this.txtEliminarAlumno.Name = "txtEliminarAlumno";
            this.txtEliminarAlumno.Size = new System.Drawing.Size(116, 34);
            this.txtEliminarAlumno.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(680, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Facultad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Jornada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Carne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre Completo";
            // 
            // btnGuardarAlum
            // 
            this.btnGuardarAlum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardarAlum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnGuardarAlum.FlatAppearance.BorderSize = 0;
            this.btnGuardarAlum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnGuardarAlum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnGuardarAlum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAlum.Font = new System.Drawing.Font("Limelight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAlum.Location = new System.Drawing.Point(426, 147);
            this.btnGuardarAlum.Name = "btnGuardarAlum";
            this.btnGuardarAlum.Size = new System.Drawing.Size(127, 48);
            this.btnGuardarAlum.TabIndex = 27;
            this.btnGuardarAlum.Text = "GUARDAR";
            this.btnGuardarAlum.UseVisualStyleBackColor = false;
            this.btnGuardarAlum.Click += new System.EventHandler(this.BtnGuardarAlum_Click);
            // 
            // txtFacultadAlum
            // 
            this.txtFacultadAlum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtFacultadAlum.BackColor = System.Drawing.Color.White;
            this.txtFacultadAlum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFacultadAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultadAlum.Location = new System.Drawing.Point(652, 116);
            this.txtFacultadAlum.Multiline = true;
            this.txtFacultadAlum.Name = "txtFacultadAlum";
            this.txtFacultadAlum.Size = new System.Drawing.Size(149, 25);
            this.txtFacultadAlum.TabIndex = 26;
            // 
            // txtJornadaAlum
            // 
            this.txtJornadaAlum.BackColor = System.Drawing.Color.White;
            this.txtJornadaAlum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJornadaAlum.Location = new System.Drawing.Point(488, 116);
            this.txtJornadaAlum.Multiline = true;
            this.txtJornadaAlum.Name = "txtJornadaAlum";
            this.txtJornadaAlum.Size = new System.Drawing.Size(149, 25);
            this.txtJornadaAlum.TabIndex = 25;
            // 
            // txtCursoAlum
            // 
            this.txtCursoAlum.BackColor = System.Drawing.Color.White;
            this.txtCursoAlum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCursoAlum.Location = new System.Drawing.Point(218, 116);
            this.txtCursoAlum.Multiline = true;
            this.txtCursoAlum.Name = "txtCursoAlum";
            this.txtCursoAlum.Size = new System.Drawing.Size(70, 25);
            this.txtCursoAlum.TabIndex = 24;
            // 
            // txtCarneAlum
            // 
            this.txtCarneAlum.BackColor = System.Drawing.Color.White;
            this.txtCarneAlum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarneAlum.Location = new System.Drawing.Point(313, 116);
            this.txtCarneAlum.Multiline = true;
            this.txtCarneAlum.Name = "txtCarneAlum";
            this.txtCarneAlum.Size = new System.Drawing.Size(149, 25);
            this.txtCarneAlum.TabIndex = 23;
            // 
            // txtNombreAlum
            // 
            this.txtNombreAlum.BackColor = System.Drawing.Color.White;
            this.txtNombreAlum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreAlum.Location = new System.Drawing.Point(25, 116);
            this.txtNombreAlum.Multiline = true;
            this.txtNombreAlum.Name = "txtNombreAlum";
            this.txtNombreAlum.Size = new System.Drawing.Size(168, 25);
            this.txtNombreAlum.TabIndex = 22;
            // 
            // dataRegAlumno
            // 
            this.dataRegAlumno.AllowUserToAddRows = false;
            this.dataRegAlumno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.dataRegAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataRegAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRegAlumno.Location = new System.Drawing.Point(12, 201);
            this.dataRegAlumno.Name = "dataRegAlumno";
            this.dataRegAlumno.ReadOnly = true;
            this.dataRegAlumno.RowHeadersWidth = 51;
            this.dataRegAlumno.RowTemplate.Height = 24;
            this.dataRegAlumno.Size = new System.Drawing.Size(951, 390);
            this.dataRegAlumno.TabIndex = 21;
            // 
            // txtSeccionAlumno
            // 
            this.txtSeccionAlumno.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtSeccionAlumno.BackColor = System.Drawing.Color.White;
            this.txtSeccionAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeccionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccionAlumno.Location = new System.Drawing.Point(816, 116);
            this.txtSeccionAlumno.Multiline = true;
            this.txtSeccionAlumno.Name = "txtSeccionAlumno";
            this.txtSeccionAlumno.Size = new System.Drawing.Size(88, 25);
            this.txtSeccionAlumno.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(822, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Seccion";
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(985, 603);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSeccionAlumno);
            this.Controls.Add(this.dateTimeAlumno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminarAlum);
            this.Controls.Add(this.txtEliminarAlumno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarAlum);
            this.Controls.Add(this.txtFacultadAlum);
            this.Controls.Add(this.txtJornadaAlum);
            this.Controls.Add(this.txtCursoAlum);
            this.Controls.Add(this.txtCarneAlum);
            this.Controls.Add(this.txtNombreAlum);
            this.Controls.Add(this.dataRegAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlumno";
            this.Text = "FormAlumno";
            this.Load += new System.EventHandler(this.FormAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRegAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeAlumno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminarAlum;
        private System.Windows.Forms.TextBox txtEliminarAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarAlum;
        private System.Windows.Forms.TextBox txtFacultadAlum;
        private System.Windows.Forms.TextBox txtJornadaAlum;
        private System.Windows.Forms.TextBox txtCursoAlum;
        private System.Windows.Forms.TextBox txtCarneAlum;
        private System.Windows.Forms.TextBox txtNombreAlum;
        private System.Windows.Forms.DataGridView dataRegAlumno;
        private System.Windows.Forms.TextBox txtSeccionAlumno;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}