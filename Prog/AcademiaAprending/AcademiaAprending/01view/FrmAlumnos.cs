using AcademiaAprending._02aplication;
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
    public partial class FrmAlumnos : Form
    {
        GestionAlumnos gestionAlumnos = new GestionAlumnos();
        public FrmAlumnos()
        {
            InitializeComponent();
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
        }

        private void MapearNegocioPresentacion()
        {
            if (gestionAlumnos.Alumno != null)
            {
                txtDni.Text = gestionAlumnos.Alumno.Dni;
                txtNombre.Text = gestionAlumnos.Alumno.Nombre;
                txtApellidos.Text = gestionAlumnos.Alumno.Apellidos;
                txtPoblacion.Text = gestionAlumnos.Alumno.Poblacion;
                txtTelefono.Text = gestionAlumnos.Alumno.Telefono;
            }
        }

        private void MaperarPresentacionNegocio()
        {
            if (gestionAlumnos.Alumno != null)
            {
                gestionAlumnos.Alumno.Dni = txtDni.Text;
                gestionAlumnos.Alumno.Nombre = txtNombre.Text;
                gestionAlumnos.Alumno.Apellidos = txtApellidos.Text;
                gestionAlumnos.Alumno.Poblacion = txtPoblacion.Text;
                gestionAlumnos.Alumno.Telefono = txtTelefono.Text;
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (gestionAlumnos.Primero() != null)
            {
                MapearNegocioPresentacion();
            }
            else
                MessageBox.Show("Error al ir al primer alumno");
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (gestionAlumnos.Anterior() != null)
            {
                MapearNegocioPresentacion();
            }
            else
                MessageBox.Show("Error al ir al anterior alumno");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (gestionAlumnos.Siguiente() != null)
            {
                MapearNegocioPresentacion();
            }
            else
                MessageBox.Show("Error al ir al siguiente alumno");
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (gestionAlumnos.Anterior() != null)
            {
                MapearNegocioPresentacion();
            }
            else
                MessageBox.Show("Error al ir al anterior alumno");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" ||
                txtPoblacion.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Tienes que seleccionar a un alumno");
                return;
            }

            MaperarPresentacionNegocio();

            int resgistrosEditados = gestionAlumnos.Edit();
            MessageBox.Show("Editados " + resgistrosEditados + " registros " + gestionAlumnos.Error());

            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" ||
               txtPoblacion.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return;
            }

            MaperarPresentacionNegocio();

            if (gestionAlumnos.Insert() == -1)
            {
                MessageBox.Show("Error al añadir el alumno");
            }
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" ||
               txtPoblacion.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Tienes que seleccionar a un alumno");
                return;
            }

            MaperarPresentacionNegocio();

            if (gestionAlumnos.Remove() == -1)
                MessageBox.Show("Error al borrar el alumno");
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql =
                "select * from alumnos where dni like '%" + txtDni.Text + "%' and " +
                "nombre like '%" + txtNombre.Text + "%' and " +
                "apellidos like '%" + txtApellidos.Text + "%' and " +
                "poblacion like '%" + txtPoblacion.Text + "%' and " +
                "telefono like '%" + txtTelefono.Text + "%'";
            dgvAlumnos.DataSource =
                gestionAlumnos.GetAllByDataTable(gestionAlumnos.GetAllBySql(sql));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtPoblacion.Clear();
            txtTelefono.Clear();
            dgvAlumnos.ClearSelection();
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
        }
    }
}
