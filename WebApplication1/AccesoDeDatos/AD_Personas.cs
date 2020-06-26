using Microsoft.AspNetCore.JsonPatch.Internal;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;


namespace WebApplication1.AccesoDeDatos
{
    public class AD_Personas
    {
        public static bool InsertarNuevaPersona(Persona per) 
        {
            bool resultado = false;

            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"].ToString();
            //uso la forma incorrecta porque en Visual 2019 no aparece Web.config automáticamente y la key debe agregarse en otro lado, pero no sé dónde
            string cadenaConexion = @"Data Source=(localdb)\DBRODRIGO;Initial Catalog=programacion3;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO personas VALUES(@nombre, @apellido, @edad, @telefono)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@apellido", per.Apellido);
                cmd.Parameters.AddWithValue("@edad", per.Edad);
                cmd.Parameters.AddWithValue("@telefono", per.Telefono);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static List<Persona> ObtenerListaPersonas()
        {
            List<Persona> resultado = new List<Persona>();

            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"].ToString();
            //uso la forma incorrecta porque en Visual 2019 no aparece Web.config automáticamente y la key debe agregarse en otro lado, pero no sé dónde
            string cadenaConexion = @"Data Source=(localdb)\DBRODRIGO;Initial Catalog=programacion3;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personas";
                cmd.Parameters.Clear();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Persona aux = new Persona();
                        aux.Id = int.Parse(dr["Id"].ToString());
                        aux.Nombre = dr["Nombre"].ToString();
                        aux.Apellido = dr["Apellido"].ToString();
                        aux.Telefono = dr["Telefono"].ToString();
                        aux.Edad = int.Parse(dr["Edad"].ToString());

                        resultado.Add(aux);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static Persona ObtenerPersona(int idPersona)
        {
            Persona resultado = new Persona();

            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"].ToString();
            //uso la forma incorrecta porque en Visual 2019 no aparece Web.config automáticamente y la key debe agregarse en otro lado, pero no sé dónde
            string cadenaConexion = @"Data Source=(localdb)\DBRODRIGO;Initial Catalog=programacion3;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personas WHERE Id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idPersona);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        resultado.Id = int.Parse(dr["Id"].ToString());
                        resultado.Nombre = dr["Nombre"].ToString();
                        resultado.Apellido = dr["Apellido"].ToString();
                        resultado.Telefono = dr["Telefono"].ToString();
                        resultado.Edad = int.Parse(dr["Edad"].ToString());
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool ActualizarDatosPersona(Persona per)
        {
            bool resultado = false;

            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"].ToString();
            //uso la forma incorrecta porque en Visual 2019 no aparece Web.config automáticamente y la key debe agregarse en otro lado, pero no sé dónde
            string cadenaConexion = @"Data Source=(localdb)\DBRODRIGO;Initial Catalog=programacion3;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE personas SET Nombre = @nombre, Apellido = @apellido, Edad = @edad, Telefono = @telefono WHERE Id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@apellido", per.Apellido);
                cmd.Parameters.AddWithValue("@edad", per.Edad);
                cmd.Parameters.AddWithValue("@telefono", per.Telefono);
                cmd.Parameters.AddWithValue("@id", per.Id);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool EliminarPersona(Persona per)
        {
            bool resultado = false;

            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"].ToString();
            //uso la forma incorrecta porque en Visual 2019 no aparece Web.config automáticamente y la key debe agregarse en otro lado, pero no sé dónde
            string cadenaConexion = @"Data Source=(localdb)\DBRODRIGO;Initial Catalog=programacion3;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM personas WHERE Id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", per.Id);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }

            return resultado;
        }
    }
}
