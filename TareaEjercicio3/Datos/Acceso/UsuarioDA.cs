using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Acceso
{
    public class UsuarioDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=ProgramacionEjercicio3; Uid=root; Pwd=12345;";

        MySqlConnection conn;
        MySqlCommand cmd;   

       public Usuario Login(string codigo, string clave)
        {
            Usuario user = null;

            try
            {
                string sql = "Select * FROM usuario WHERE  Codigo= @Codigo AND Clave = @Clave;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Rol = reader[2].ToString();
                    user.Celular = reader[3].ToString();
                    user.Clave = reader[4].ToString();
                    user.EstaActivo = Convert.ToBoolean(reader[5]);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

               
            }
            return user;
        }

        public DataTable ListarUsuarios()
        {
            DataTable ListaUsuariosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM Usuario;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                ListaUsuariosDT.Load(reader);
            }
            catch (Exception ex)
            {

               
            }
            return ListaUsuariosDT;
        }

    }
}
