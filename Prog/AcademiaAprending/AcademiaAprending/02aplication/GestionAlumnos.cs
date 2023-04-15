using academia_03data;
using System.Data;

namespace AcademiaAprending._02aplication
{
    internal class GestionAlumnos
    {
        public Alumno Alumno { set; get; }

        public GestionAlumnos()
        {
            Alumno = new Alumno();
        }

        public string Error()
        {
            return BaseDatos.Error;
        }

        public Alumno Primero()
        {
            //Busca el primer alumno y si lo encuentra lo asigna a la propiedad Alumno
            Alumno = GetOneBySql("select * from alumnos");
            return Alumno != null ? Alumno : null;
        }

        public Alumno Ultimo()
        {
            //Busca el últmo alumno y si lo encuentra lo asigna a la propiedad Alumno
            List<Alumno> alumnos = GetAll();
            Alumno = alumnos[alumnos.Count - 1];
            return Alumno != null ? Alumno : null;
        }

        public Alumno Siguiente()
        {
            //Busca el siguiente alumno al actual (Alumno.dni) y si lo encuentra lo asigna a la propiedad Alumno
            List<Alumno> alumnos = GetAll();

            if (Alumno.Dni == null && alumnos.Count > 0)
            {
                Alumno = alumnos[0];
                return Alumno;
            }

            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].Dni == Alumno.Dni)
                {
                    if (i == alumnos.Count - 1)
                        Alumno = alumnos[0];
                    else
                        Alumno = alumnos[i + 1];
                    break;
                }
            }
            return Alumno != null ? Alumno : null;
        }

        public Alumno Anterior()
        {
            //Busca el anterior alumno al actual (Alumno.dni) y si lo encuentra lo asigna a la propiedad Alumno
            List<Alumno> alumnos = GetAll();

            if (Alumno.Dni == null && alumnos.Count > 0)
            {
                Alumno = alumnos[alumnos.Count - 1];
                return Alumno;
            }

            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].Dni == Alumno.Dni)
                {
                    if (i == 0)
                        Alumno = alumnos[alumnos.Count - 1];
                    else
                        Alumno = alumnos[i - 1];
                    break;
                }
            }
            return Alumno != null ? Alumno : null;

        }

        /*Este método actualiza los datos de alumno cargado, hace un select con la clave principal
        Aluno.Dni y si existe en la base de datos hace un update, en caso de no existir devuelve -1 para que la
        capa de encima pueda sacar un mensaje*/
        public int Edit()
        {
            string sql = "select * from alumnos where dni = '" + this.Alumno.Dni + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "update alumnos set nombre = '" + this.Alumno.Nombre + "', apellidos = '"
                + this.Alumno.Apellidos + "', telefono = '" + this.Alumno.Telefono +
                "', poblacion = '" + this.Alumno.Poblacion + "' where dni = '" + this.Alumno.Dni +
                "'";
                return (BaseDatos.Modificacion(sql));
            }
            return -1;
        }

        /*Este método inserta un nuevo alumno cuyos datos tenemos cargados en la propiedad Alumno, para ello
        primero mira que el alumno no exista en la base de datos, en caso de que ya exista devuelve -1*/
        public int Insert()
        {
            string sql = "select * from alumnos where dni = '" + this.Alumno.Dni + "'";
            if (BaseDatos.Consulta(sql).Rows.Count == 0)
            {
                sql = "insert into alumnos (dni,nombre,apellidos,telefono,poblacion)" +
                " values ('" + this.Alumno.Dni + "', '" + this.Alumno.Nombre + "', '" +
                this.Alumno.Apellidos + "', '"
                + this.Alumno.Telefono + "', '" + this.Alumno.Poblacion + "')";
                return (BaseDatos.Modificacion(sql));
            }
            else
                return -1;
        }

        //Este método borra de la base de datos el alumno con la clave principal: Alumno.dni
        public int Remove()
        {
            string sql = "select * from alumnos where dni = '" + this.Alumno.Dni + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "delete from alumnos where dni = '" + this.Alumno.Dni + "'";
                return (BaseDatos.Modificacion(sql));
            }
            else
                return -1;
        }

        //Este método obtiene el alumno cuyo dni se pasa como parámetro
        public Alumno GetById(string dni)
        {
            DataTable dt = BaseDatos.Consulta("select * from alumnos where dni = '" + dni + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                Alumno a = new Alumno(dt.Rows[0]["dni"].ToString(), dt.Rows[0]["nombre"].ToString(),
                dt.Rows[0]["apellidos"].ToString(), dt.Rows[0]["poblacion"].ToString(), dt.Rows[0]["telefono"].ToString());
                return a;
            }
            return null;
        }

        //Este método obtiene una lista con todos los alumnos
        public List<Alumno> GetAll()
        {
            List<Alumno> alumnos = new List<Alumno>();
            DataTable dt = BaseDatos.Consulta("select * from alumnos order by dni");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                alumnos.Add(new Alumno(dt.Rows[i]["dni"].ToString(), dt.Rows[i]["nombre"].ToString(),
                dt.Rows[i]["apellidos"].ToString(), dt.Rows[i]["telefono"].ToString(), dt.Rows[i]["poblacion"].ToString()));
            }
            return (alumnos);
        }

        //Este método obtiene una lista con todos los alumnos de un DataTable
        public List<Alumno> GetAllByDataTable(DataTable dt)
        {
            List<Alumno> alumnos = new List<Alumno>();
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                alumnos.Add(new Alumno(dt.Rows[i]["dni"].ToString(), dt.Rows[i]["nombre"].ToString(),
                dt.Rows[i]["apellidos"].ToString(), dt.Rows[i]["telefono"].ToString(), dt.Rows[i]["poblacion"].ToString()));
            }
            return alumnos;
        }

        //Este método obtiene un alumno (el primero en orden) a partir de una consulta SQL
        public Alumno GetOneBySql(string sql)
        {
            DataTable dt = BaseDatos.Consulta(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                Alumno a = new Alumno(dt.Rows[0]["dni"].ToString(), dt.Rows[0]["nombre"].ToString(),
                dt.Rows[0]["apellidos"].ToString(), dt.Rows[0]["telefono"].ToString(), dt.Rows[0]["poblacion"].ToString());
                return a;
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
