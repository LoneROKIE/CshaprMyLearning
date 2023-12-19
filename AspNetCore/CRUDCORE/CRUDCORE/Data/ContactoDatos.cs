using System.Data;
using System.Data.SqlClient;
using CRUDCORE.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUDCORE.Data
{
    public class ContactoDatos
    {
        // listar contactos
        public List<ContactoModelcs> Listar() 
        {
            var oLista = new List<ContactoModelcs>();
            var cn = new Conexion();

            using(var conexion = new SqlConnection(cn.getCadenaSql()))
            {
                conexion.Open(); // abrimos la cd conex
                SqlCommand cmd = new SqlCommand("sp_Listar",conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using(var dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        oLista.Add(new ContactoModelcs()
                        {
                            IdContacto = Convert.ToInt32(dr["IdContacto"]),
                            Nombre = dr["Nombre"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Correo = dr["Correo"].ToString()
                        });
                    }    
                }
                
            }
            return oLista;
        }

        // obtener contacto
        public ContactoModelcs Obtener(int IdContacto)
        {
            var oContacto = new ContactoModelcs();
            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSql()))
            {
                conexion.Open(); // abrimos la cd conex
                SqlCommand cmd = new SqlCommand("sp_Obtener", conexion);
                cmd.Parameters.AddWithValue("IdContacto",IdContacto);
                cmd.CommandType = CommandType.StoredProcedure; // le decimos que es un stored procedure

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oContacto.IdContacto = Convert.ToInt32(dr["IdContacto"]);
                        oContacto.Nombre = dr["Nombre"].ToString();
                        oContacto.Telefono = dr["Telefono"].ToString();
                        oContacto.Correo = dr["Correo"].ToString();
                    }
                }
            }
            return oContacto;
        }

        // metodo para guardar un contacto en la DB
        public bool Guardar(ContactoModelcs oContacto)
        {
            bool resp;

            try
            {
                //var oContacto = new ContactoModelcs();
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSql()))
                {
                    conexion.Open(); // abrimos la cd conex
                    SqlCommand cmd = new SqlCommand("sp_Guardar", conexion);
                    cmd.Parameters.AddWithValue("Nombre", oContacto.Nombre);
                    cmd.Parameters.AddWithValue("Telefono", oContacto.Telefono);
                    cmd.Parameters.AddWithValue("Correo", oContacto.Correo);
                    cmd.CommandType = CommandType.StoredProcedure; // le decimos que es un stored procedure

                    cmd.ExecuteNonQuery(); // se ejecuta la query
                }
                resp = true;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                resp = false;
            }

            return resp;
        }

        // metodo para editar un contacto de la DB
        public bool Editar(ContactoModelcs oContacto)
        {
            bool resp;

            try
            {
                
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSql()))
                {
                    conexion.Open(); // abrimos la cd conex
                    SqlCommand cmd = new SqlCommand("sp_Editar", conexion);
                    cmd.Parameters.AddWithValue("@IdContacto", oContacto.IdContacto);
                    cmd.Parameters.AddWithValue("@Nombre", oContacto.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", oContacto.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", oContacto.Correo);
                    cmd.CommandType = CommandType.StoredProcedure; // le decimos que es un stored procedure

                    cmd.ExecuteNonQuery(); // se ejecuta la query
                }
                resp = true;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                resp = false;
            }

            return resp;
        }

        // metodo para eliminar un contacto de la DB
        public bool Eliminar(int IdContacto)
        {
            bool resp;

            try
            {
                //var oContacto = new ContactoModelcs();
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSql()))
                {
                    conexion.Open(); // abrimos la cd conex
                    SqlCommand cmd = new SqlCommand("sp_Eliminar", conexion);
                    cmd.Parameters.AddWithValue("@IdContacto", IdContacto);
                    cmd.CommandType = CommandType.StoredProcedure; // le decimos que es un stored procedure

                    cmd.ExecuteNonQuery(); // se ejecuta la query
                }
                resp = true;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                resp = false;
            }

            return resp;
        }

    }
}



