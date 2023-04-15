using academia_03data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAprending._02aplication
{
    internal class Matricula
    {
        public GestionCursos GestionCursos { get; set; }
        public GestionAlumnos GestionAlumnos { get; set; }

        public Matricula()
        {
            GestionCursos = new GestionCursos();
            GestionAlumnos = new GestionAlumnos();
        }

        public int Matricular(int codigo, string dni)
        {
            string sql = "select * from matriculas where codigo = '" + codigo + "' and dni = '" + dni + "'";
            if (BaseDatos.Consulta(sql).Rows.Count == 0)
            {
                sql = "insert into matriculas (dni,codigo)" +
                " values ('" + dni + "', '" + codigo + "')";
                return (BaseDatos.Modificacion(sql));
            }
            else
                return -1;
        }

        public int Desmatricular(int codigo, string dni)
        {
            string sql = "select * from matriculas where codigo = '" + codigo + "' and dni = '" + dni + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "delete from matriculas where dni = " +
                "'" + dni + "' and codigo = '" + codigo + "'";
                return (BaseDatos.Modificacion(sql));
            }
            else
                return -1;
        }

        public DataTable CursosAlumno(string dni)
        {
            string sql = "select cursos.* from cursos,alumnos,matriculas where alumnos.dni = '" + dni + "' and alumnos.dni = matriculas.dni and cursos.codigo = matriculas.codigo";
            return GestionCursos.GetAllBySql(sql);
        }

        public DataTable AlumnosCurso(int codigo)
        {
            string sql = "select alumnos.* from cursos,alumnos,matriculas where cursos.codigo = '" + codigo + "' and alumnos.dni = matriculas.dni and cursos.codigo = matriculas.codigo";
            return GestionAlumnos.GetAllBySql(sql);
        }
    }
}
