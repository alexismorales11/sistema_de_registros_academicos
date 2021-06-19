namespace Frontend
{
    partial class FormRegistrarInstitucion
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnUniversidad = new System.Windows.Forms.Button();
            this.btnEscuela = new System.Windows.Forms.Button();
            this.btnColegio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(749, 36);
            this.label3.TabIndex = 21;
            this.label3.Text = "Registra una nueva Institucion Academica";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUniversidad
            // 
            this.btnUniversidad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUniversidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUniversidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(91)))));
            this.btnUniversidad.FlatAppearance.BorderSize = 0;
            this.btnUniversidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(91)))));
            this.btnUniversidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(91)))));
            this.btnUniversidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUniversidad.Font = new System.Drawing.Font("Broadway", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniversidad.Location = new System.Drawing.Point(60, 90);
            this.btnUniversidad.Name = "btnUniversidad";
            this.btnUniversidad.Size = new System.Drawing.Size(213, 44);
            this.btnUniversidad.TabIndex = 20;
            this.btnUniversidad.Text = "Universidad";
            this.btnUniversidad.UseVisualStyleBackColor = false;
            this.btnUniversidad.Click += new System.EventHandler(this.BtnUniversidad_Click);
            // 
            // btnEscuela
            // 
            this.btnEscuela.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEscuela.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(91)))));
            this.btnEscuela.FlatAppearance.BorderSize = 0;
            this.btnEscuela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(91)))));
            this.btnEscuela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(91)))));
            this.btnEscuela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscuela.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscuela.Location = new System.Drawing.Point(664, 91);
            this.btnEscuela.Name = "btnEscuela";
            this.btnEscuela.Size = new System.Drawing.Size(213, 43);
            this.btnEscuela.TabIndex = 19;
            this.btnEscuela.Text = "Escuela";
            this.btnEscuela.UseVisualStyleBackColor = false;
            this.btnEscuela.Click += new System.EventHandler(this.BtnEscuela_Click);
            // 
            // btnColegio
            // 
            this.btnColegio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnColegio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(91)))));
            this.btnColegio.FlatAppearance.BorderSize = 0;
            this.btnColegio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(91)))));
            this.btnColegio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(105)))), ((int)(((byte)(91)))));
            this.btnColegio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColegio.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColegio.Location = new System.Drawing.Point(365, 86);
            this.btnColegio.Name = "btnColegio";
            this.btnColegio.Size = new System.Drawing.Size(213, 49);
            this.btnColegio.TabIndex = 18;
            this.btnColegio.Text = "Colegio";
            this.btnColegio.UseVisualStyleBackColor = false;
            this.btnColegio.Click += new System.EventHandler(this.BtnColegio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 533);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // FormRegistrarInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(985, 674);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUniversidad);
            this.Controls.Add(this.btnEscuela);
            this.Controls.Add(this.btnColegio);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarInstitucion";
            this.Text = "FormRegistrarInstitucion";
            this.Load += new System.EventHandler(this.FormRegistrarInstitucion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUniversidad;
        private System.Windows.Forms.Button btnEscuela;
        private System.Windows.Forms.Button btnColegio;
        private System.Windows.Forms.Panel panel2;
    }
}