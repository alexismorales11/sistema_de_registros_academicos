namespace Frontend
{
    partial class ComprobarInstitucionAlum
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
            this.panelDocentes = new System.Windows.Forms.Panel();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.txtComprobarInstiALum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDocentes
            // 
            this.panelDocentes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDocentes.Location = new System.Drawing.Point(0, 71);
            this.panelDocentes.Name = "panelDocentes";
            this.panelDocentes.Size = new System.Drawing.Size(985, 603);
            this.panelDocentes.TabIndex = 3;
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.Silver;
            this.btnComprobar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnComprobar.FlatAppearance.BorderSize = 0;
            this.btnComprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnComprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobar.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobar.Location = new System.Drawing.Point(608, 11);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(179, 53);
            this.btnComprobar.TabIndex = 2;
            this.btnComprobar.Text = "Ingresar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtComprobarInstiALum
            // 
            this.txtComprobarInstiALum.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComprobarInstiALum.Location = new System.Drawing.Point(378, 21);
            this.txtComprobarInstiALum.Multiline = true;
            this.txtComprobarInstiALum.Name = "txtComprobarInstiALum";
            this.txtComprobarInstiALum.Size = new System.Drawing.Size(196, 35);
            this.txtComprobarInstiALum.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnComprobar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtComprobarInstiALum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Algerian", 19.8F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 71);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15F);
            this.label2.Location = new System.Drawing.Point(110, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15F);
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comprueba tu Institucion ";
            // 
            // ComprobarInstitucionAlum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 674);
            this.Controls.Add(this.panelDocentes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprobarInstitucionAlum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComprobarInstitucionAlum";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDocentes;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.TextBox txtComprobarInstiALum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}