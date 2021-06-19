namespace Frontend
{
    partial class ReporteDocente
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
            this.reporteDocentesNom = new System.Windows.Forms.DataGridView();
            this.dataADocentes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDocentesNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataADocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteDocentesNom
            // 
            this.reporteDocentesNom.AllowUserToAddRows = false;
            this.reporteDocentesNom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.reporteDocentesNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reporteDocentesNom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporteDocentesNom.Location = new System.Drawing.Point(10, 78);
            this.reporteDocentesNom.Name = "reporteDocentesNom";
            this.reporteDocentesNom.ReadOnly = true;
            this.reporteDocentesNom.RowHeadersWidth = 51;
            this.reporteDocentesNom.RowTemplate.Height = 24;
            this.reporteDocentesNom.Size = new System.Drawing.Size(265, 592);
            this.reporteDocentesNom.TabIndex = 65;
            // 
            // dataADocentes
            // 
            this.dataADocentes.AllowUserToAddRows = false;
            this.dataADocentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(104)))));
            this.dataADocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataADocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataADocentes.Location = new System.Drawing.Point(203, 78);
            this.dataADocentes.Name = "dataADocentes";
            this.dataADocentes.ReadOnly = true;
            this.dataADocentes.RowHeadersWidth = 51;
            this.dataADocentes.RowTemplate.Height = 24;
            this.dataADocentes.Size = new System.Drawing.Size(770, 592);
            this.dataADocentes.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 62);
            this.label2.TabIndex = 66;
            this.label2.Text = "Reporte Alumnos";
            // 
            // ReporteDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(985, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reporteDocentesNom);
            this.Controls.Add(this.dataADocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReporteDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDocentesNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataADocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reporteDocentesNom;
        private System.Windows.Forms.DataGridView dataADocentes;
        private System.Windows.Forms.Label label2;
    }
}