using academia_03data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAprending._02aplication
{
    internal class GestionCursos
    {
        public Curso Curso { set; get; }

        public GestionCursos()
        {
            Curso = new Curso();
        }

        public string Error()
        {
            return BaseDatos.Error;
        }

        public Curso Primero()
        {
            //Busca el primer curso y si lo encuentra lo asigna a la propiedad Curso
            Curso = GetOneBySql("select * from cursos");
            return Curso != null ? Curso : null;
        }

        public Curso Ultimo()
        {
            //Busca el últmo curso y si lo encuentra lo asigna a la propiedad Curso
            List<Curso> cursos = GetAll();
            Curso = cursos[cursos.Count - 1];
            return Curso != null ? Curso : null;
        }

        public Curso Siguiente()
        {
            //Busca el siguiente curso al actual (Curso.codigo) y si lo encuentra lo asigna a la propiedad Curso
            List<Curso> cursos = GetAll();

            if (Curso.Titulo == null && cursos.Count > 0)
            {
                Curso = cursos[0];
                return Curso;
            }

            for (int i = 0; i < cursos.Count; i++)
            {
                if (cursos[i].Codigo == Curso.Codigo)
                {
                    if (i == cursos.Count - 1)
                        Curso = cursos[0];
                    else
                        Curso = cursos[i + 1];
                    break;
                }
            }
            return Curso != null ? Curso : null;
        }

        public Curso Anterior()
        {
            //Busca el anterior curso al actual (Curso.codigo) y si lo encuentra lo asigna a la propiedad Curso
            List<Curso> cursos = GetAll();

            if (Curso.Titulo == null && cursos.Count > 0)
            {
                Curso = cursos[cursos.Count - 1];
                return Curso;
            }

            for (int i = 0; i < cursos.Count; i++)
            {
                if (cursos[i].Codigo == Curso.Codigo)
                {
                    if (i == 0)
                        Curso = cursos[cursos.Count - 1];
                    else
                        Curso = cursos[i - 1];
                    break;
                }
            }
            return Curso != null ? Curso : null;

        }

        /*Este método actualiza los datos del curso cargado, hace un select con la clave principal
        Curso.Codigo y si existe en la base de datos hace un update, en caso de no existir devuelve -1 para que la
        capa de encima pueda sacar un mensaje*/
        public int Edit()
        {
            string sql = "select * from cursos where codigo = '" + this.Curso.Codigo + "'";

            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "update cursos set titulo = '" + this.Curso.Titulo + "', n_plazas = '"
                + this.Curso.NumPlazas + "', precio = '" + this.Curso.Precio +
                "', lugar_realizacion = '" + this.Curso.Lugar + "' where codigo = '" + this.Curso.Codigo +
                "'";
                return (BaseDatos.Modificacion(sql));
            }
            return -1;
        }

        /*Este método inserta un nuevo curso cuyos datos tenemos cargados en la propiedad Curso, para ello
        primero mira que el curso no exista en la base de datos, en caso de que ya exista devuelve -1*/
        public int Insert()
        {
            string sql = "select * from cursos where codigo = '" + Curso.Codigo + "'";
            if (BaseDatos.Consulta(sql).Rows.Count == 0)
            {
                sql = "insert into cursos (codigo,titulo,n_plazas,precio,lugar_realizacion)" +
                " values ('" + Curso.Codigo + "', '" + Curso.Titulo + "', '" +
                Curso.NumPlazas + "', '" + Curso.Precio + "', '" + Curso.Lugar + "')";
                return (BaseDatos.Modificacion(sql));
            }
            else
                return -1;
        }

        //Este método borra de la base de datos el curso con la clave principal: Curso.codigo
        public int Remove()
        {
            string sql = "select * from cursos where codigo = '" + Curso.Codigo + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "delete from cursos where codigo = '" + Curso.Codigo + "'";
                return (BaseDatos.Modificacion(sql));
            }
            else
                return -1;
        }

        //Este método obtiene el curso cuyo código se pasa como parámetro
        public Curso GetById(int cod)
        {
            DataTable dt = BaseDatos.Consulta("select * from cursos where codigo = '" + cod + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                int codigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
                int numPlazas = Convert.ToInt32(dt.Rows[0]["n_plazas"].ToString());
                int precio = Convert.ToInt32(dt.Rows[0]["precio"].ToString());

                Curso c = new Curso(codigo, dt.Rows[0]["titulo"].ToString(),numPlazas, 
                    dt.Rows[0]["lugar_realizacion"].ToString(),precio);
                return c;
            }
            return null;
        }

        //Este método obtiene una lista con todos los cursos
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            DataTable dt = BaseDatos.Consulta("select * from cursos");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                int codigo = Convert.ToInt32(dt.Rows[i]["codigo"].ToString());
                int numPlazas = Convert.ToInt32(dt.Rows[i]["n_plazas"].ToString());
                int precio = Convert.ToInt32(dt.Rows[i]["precio"].ToString());

                cursos.Add(new Curso(codigo, dt.Rows[i]["titulo"].ToString(),
                numPlazas, dt.Rows[i]["lugar_realizacion"].ToString(), precio));
            }
            return cursos;
        }

        //Este método obtiene una lista con todos los cursos de un DataTable
        public List<Curso> GetAllByDataTable(DataTable dt)
        {
            List<Curso> cursos = new List<Curso>();
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                int codigo = Convert.ToInt32(dt.Rows[i]["codigo"].ToString());
                int numPlazas = Convert.ToInt32(dt.Rows[i]["n_plazas"].ToString());
                int precio = Convert.ToInt32(dt.Rows[i]["precio"].ToString());

                cursos.Add(new Curso(codigo, dt.Rows[i]["titulo"].ToString(),
                numPlazas, dt.Rows[i]["lugar_realizacion"].ToString(), precio));
            }
            return cursos;
        }

        //Este método obtiene un curso (el primero en orden) a partir de una consulta SQL
        public Curso GetOneBySql(string sql)
        {
            DataTable dt = BaseDatos.Consulta(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                int codigo = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
                int numPlazas = Convert.ToInt32(dt.Rows[0]["n_plazas"].ToString());
                int precio = Convert.ToInt32(dt.Rows[0]["precio"].ToString());

                Curso c = new Curso(codigo, dt.Rows[0]["titulo"].ToString(),
                numPlazas, dt.Rows[0]["lugar_realizacion"].ToString(),precio);
                return c;
            }
            return null;
        }

        //Este método devuelve un DataTable con el resultado de la consulta que se le pase
        public DataTable GetAllBySql(string sql)
        {
            return BaseDatos.Consulta(sql);
        }
    }
}
