namespace AcademiaAprending
{
    partial class FrmAcademia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcademia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManteniminetoAlumnos = new System.Windows.Forms.Button();
            this.btnMantenimientoCursos = new System.Windows.Forms.Button();
            this.btnMatriculacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, 157);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 226);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnManteniminetoAlumnos
            // 
            this.btnManteniminetoAlumnos.Location = new System.Drawing.Point(114, 476);
            this.btnManteniminetoAlumnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManteniminetoAlumnos.Name = "btnManteniminetoAlumnos";
            this.btnManteniminetoAlumnos.Size = new System.Drawing.Size(208, 31);
            this.btnManteniminetoAlumnos.TabIndex = 1;
            this.btnManteniminetoAlumnos.Text = "Mantenimiento de Alumnos";
            this.btnManteniminetoAlumnos.UseVisualStyleBackColor = true;
            this.btnManteniminetoAlumnos.Click += new System.EventHandler(this.btnManteniminetoAlumnos_Clic);
            // 
            // btnMantenimientoCursos
            // 
            this.btnMantenimientoCursos.Location = new System.Drawing.Point(329, 476);
            this.btnMantenimientoCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMantenimientoCursos.Name = "btnMantenimientoCursos";
            this.btnMantenimientoCursos.Size = new System.Drawing.Size(257, 31);
            this.btnMantenimientoCursos.TabIndex = 2;
            this.btnMantenimientoCursos.Text = "Mantenimiento de cursos";
            this.btnMantenimientoCursos.UseVisualStyleBackColor = true;
            this.btnMantenimientoCursos.Click += new System.EventHandler(this.btnMantenimientoCursos_Click);
            // 
            // btnMatriculacion
            // 
            this.btnMatriculacion.Location = new System.Drawing.Point(593, 476);
            this.btnMatriculacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMatriculacion.Name = "btnMatriculacion";
            this.btnMatriculacion.Size = new System.Drawing.Size(165, 31);
            this.btnMatriculacion.TabIndex = 3;
            this.btnMatriculacion.Text = "Matriculación";
            this.btnMatriculacion.UseVisualStyleBackColor = true;
            this.btnMatriculacion.Click += new System.EventHandler(this.btnMatriculacion_Click);
            // 
            // FrmAcademia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnMatriculacion);
            this.Controls.Add(this.btnMantenimientoCursos);
            this.Controls.Add(this.btnManteniminetoAlumnos);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAcademia";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnManteniminetoAlumnos;
        private Button btnMantenimientoCursos;
        private Button btnMatriculacion;
    }
}