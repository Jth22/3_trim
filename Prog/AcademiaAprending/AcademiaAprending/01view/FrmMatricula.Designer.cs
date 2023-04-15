namespace AcademiaAprending._01view
{
    partial class FrmMatricula
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
            this.btnVerCursos = new System.Windows.Forms.Button();
            this.btnCursosAlumno = new System.Windows.Forms.Button();
            this.btnVerAlumnos = new System.Windows.Forms.Button();
            this.btnAlumnosCurso = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.btnDesmatricular = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerCursos
            // 
            this.btnVerCursos.Location = new System.Drawing.Point(47, 562);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(190, 61);
            this.btnVerCursos.TabIndex = 0;
            this.btnVerCursos.Text = "Ver todos los cursos";
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // btnCursosAlumno
            // 
            this.btnCursosAlumno.Location = new System.Drawing.Point(280, 562);
            this.btnCursosAlumno.Name = "btnCursosAlumno";
            this.btnCursosAlumno.Size = new System.Drawing.Size(190, 61);
            this.btnCursosAlumno.TabIndex = 1;
            this.btnCursosAlumno.Text = "Ver cursos del alumno";
            this.btnCursosAlumno.UseVisualStyleBackColor = true;
            this.btnCursosAlumno.Click += new System.EventHandler(this.btnCursosAlumno_Click);
            // 
            // btnVerAlumnos
            // 
            this.btnVerAlumnos.Location = new System.Drawing.Point(692, 562);
            this.btnVerAlumnos.Name = "btnVerAlumnos";
            this.btnVerAlumnos.Size = new System.Drawing.Size(190, 61);
            this.btnVerAlumnos.TabIndex = 2;
            this.btnVerAlumnos.Text = "Ver todos los alumnos";
            this.btnVerAlumnos.UseVisualStyleBackColor = true;
            this.btnVerAlumnos.Click += new System.EventHandler(this.btnVerAlumnos_Click);
            // 
            // btnAlumnosCurso
            // 
            this.btnAlumnosCurso.Location = new System.Drawing.Point(951, 562);
            this.btnAlumnosCurso.Name = "btnAlumnosCurso";
            this.btnAlumnosCurso.Size = new System.Drawing.Size(190, 61);
            this.btnAlumnosCurso.TabIndex = 3;
            this.btnAlumnosCurso.Text = "Ver todos";
            this.btnAlumnosCurso.UseVisualStyleBackColor = true;
            this.btnAlumnosCurso.Click += new System.EventHandler(this.btnAlumnosCurso_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(12, 125);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 29;
            this.dgvCursos.Size = new System.Drawing.Size(576, 411);
            this.dgvCursos.TabIndex = 4;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(594, 125);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 29;
            this.dgvAlumnos.Size = new System.Drawing.Size(576, 411);
            this.dgvAlumnos.TabIndex = 5;
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(784, 58);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(190, 61);
            this.btnMatricular.TabIndex = 6;
            this.btnMatricular.Text = "Matricular alumno";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // btnDesmatricular
            // 
            this.btnDesmatricular.Location = new System.Drawing.Point(980, 58);
            this.btnDesmatricular.Name = "btnDesmatricular";
            this.btnDesmatricular.Size = new System.Drawing.Size(190, 61);
            this.btnDesmatricular.TabIndex = 7;
            this.btnDesmatricular.Text = "Desmatricular alumno";
            this.btnDesmatricular.UseVisualStyleBackColor = true;
            this.btnDesmatricular.Click += new System.EventHandler(this.btnDesmatricular_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(463, 92);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(125, 27);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(594, 92);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(125, 27);
            this.txtDni.TabIndex = 9;
            // 
            // Matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 640);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnDesmatricular);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnAlumnosCurso);
            this.Controls.Add(this.btnVerAlumnos);
            this.Controls.Add(this.btnCursosAlumno);
            this.Controls.Add(this.btnVerCursos);
            this.Name = "Matriculas";
            this.Text = "Matriculas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVerCursos;
        private Button btnCursosAlumno;
        private Button btnVerAlumnos;
        private Button btnAlumnosCurso;
        private DataGridView dgvCursos;
        private DataGridView dgvAlumnos;
        private Button btnMatricular;
        private Button btnDesmatricular;
        private TextBox txtCodigo;
        private TextBox txtDni;
    }
}