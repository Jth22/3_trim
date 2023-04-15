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
    public partial class FrmCursos : Form
    {
        GestionCursos gestionCursos = new GestionCursos();
        public FrmCursos()
        {
            InitializeComponent();
            dgvCursos.DataSource = gestionCursos.GetAll();
        }

        private void MapearNegocioPresentacion()
        {
            if (gestionCursos.Curso != null)
            {
                txtCodigo.Text = gestionCursos.Curso.Codigo + "";
                txtTitulo.Text = gestionCursos.Curso.Titulo;
                txtPlazas.Text = gestionCursos.Curso.NumPlazas + "";
                txtPrecio.Text = gestionCursos.Curso.Precio + "";
                txtLugar.Text = gestionCursos.Curso.Lugar;
            }
        }

        private void MaperarPresentacionNegocio()
        {
            if (gestionCursos.Curso != null)
            {
                try
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    int numPlazas = Convert.ToInt32(txtPlazas.Text);
                    int precio = Convert.ToInt32(txtPrecio.Text);
                    gestionCursos.Curso.Codigo = codigo;
                    gestionCursos.Curso.Titulo = txtTitulo.Text;
                    gestionCursos.Curso.NumPlazas = numPlazas;
                    gestionCursos.Curso.Precio = precio;
                    gestionCursos.Curso.Lugar = txtLugar.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los campos codigo, plazas y precio tienen que ser numéricos");
                }
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (gestionCursos.Primero() != null)
            {
                MapearNegocioPresentacion();
            }
            else
                MessageBox.Show("Error al ir al primer curso");
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (gestionCursos.Anterior() != null)
            {
                MapearNegocioPresentacion();
            }
            else
                MessageBox.Show("Error al ir al anterior curso");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (gestionCursos.Siguiente() != null)
            {
                MapearNegocioPresentacion();
            }
            else
                MessageBox.Show("Error al ir al siguiente curso");
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (gestionCursos.Ultimo() != null)
            {
                MapearNegocioPresentacion();
            }
            else
                MessageBox.Show("Error al ir al último curso");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtLugar.Text == "" || txtPlazas.Text == "" ||
               txtPrecio.Text == "" || txtTitulo.Text == "")
            {
                MessageBox.Show("Tienes que seleccionar un curso");
                return;
            }

            MaperarPresentacionNegocio();

            int resgistrosEditados = gestionCursos.Edit();
            MessageBox.Show("Editados " + resgistrosEditados + " registros");

            dgvCursos.DataSource = gestionCursos.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtLugar.Text == "" || txtPlazas.Text == "" ||
                txtPrecio.Text == "" || txtTitulo.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return;
            }

            MaperarPresentacionNegocio();

            if (gestionCursos.Insert() == -1)
            {
                MessageBox.Show("Error al añadir el curso");
            }
            dgvCursos.DataSource = gestionCursos.GetAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtLugar.Text == "" || txtPlazas.Text == "" ||
                txtPrecio.Text == "" || txtTitulo.Text == "")
            {
                MessageBox.Show("Tienes que seleccionar un curso");
                return;
            }

            MaperarPresentacionNegocio();

            if (gestionCursos.Remove() == -1)
                MessageBox.Show("Error al borrar el curso");
            dgvCursos.DataSource = gestionCursos.GetAll();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql =
                "select * from cursos where codigo like '%" + txtCodigo.Text + "%' and " +
                "titulo like '%" + txtTitulo.Text + "%' and " +
                "n_plazas like '%" + txtPlazas.Text + "%' and " +
                "precio like '%" + txtPrecio.Text + "%' and " +
                "lugar_realizacion like '%" + txtLugar.Text + "%'";
            dgvCursos.DataSource =
                gestionCursos.GetAllByDataTable(gestionCursos.GetAllBySql(sql));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtPlazas.Clear();
            txtPrecio.Clear();
            txtLugar.Clear();
            dgvCursos.ClearSelection();
            dgvCursos.DataSource = gestionCursos.GetAll();
        }
    }
}
