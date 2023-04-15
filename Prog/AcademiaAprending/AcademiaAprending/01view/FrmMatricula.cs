using AcademiaAprending._02aplication;
using AcademiaAprending;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaAprending._01view
{
    public partial class FrmMatricula : Form
    {
        Matricula gestionMatriculas = new Matricula();
        public FrmMatricula()
        {
            InitializeComponent();
            dgvCursos.DataSource = gestionMatriculas.GestionCursos.GetAll();
            dgvAlumnos.DataSource = gestionMatriculas.GestionAlumnos.GetAll();
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = gestionMatriculas.GestionCursos.GetAll();
        }

        private void btnCursosAlumno_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = gestionMatriculas.CursosAlumno(txtDni.Text);
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = gestionMatriculas.GestionAlumnos.GetAll();
        }

        private void btnAlumnosCurso_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                dgvAlumnos.DataSource = gestionMatriculas.AlumnosCurso(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El código tiene que ser numérico");
            }
        }

        private void btnDesmatricular_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string dni = txtDni.Text;
                if (gestionMatriculas.Desmatricular(codigo, dni) == -1)
                    MessageBox.Show("Error al desmatricular al alumno");
                else MessageBox.Show("Alumno desmatriculado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El código tiene que ser numérico");
            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string dni = txtDni.Text;
                if (gestionMatriculas.Matricular(codigo, dni) == -1)
                    MessageBox.Show("Error al matricular al alumno");
                else MessageBox.Show("Alumno matriculado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El código tiene que ser numérico");
            }
        }
    }
}
