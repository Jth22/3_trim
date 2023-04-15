using AcademiaAprending._01view;

namespace AcademiaAprending
{
    public partial class FrmAcademia : Form
    {
        public FrmAcademia()
        {
            InitializeComponent();
        }

        private void btnManteniminetoAlumnos_Clic(object sender, EventArgs e)
        {
            new FrmAlumnos().Show();
           // this.Hide();
        }

        private void btnMantenimientoCursos_Click(object sender, EventArgs e)
        {
            new FrmCursos().Show();
            this.Hide();
        }

        private void btnMatriculacion_Click(object sender, EventArgs e)
        {
            new FrmMatricula().Show();
            this.Hide();
        }
    }
}