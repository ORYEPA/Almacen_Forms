using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Practica_Almacen
{
    public class D_Articulos
    {
        public DataTable Lista_Art(string cTexto)
        {
            MySqlDataReader resultado;
            DataTable dataTable = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                {
                    string query = "SELECT " +
                                   "art.ID, " +
                                   "art.DESCRIPCION, " +
                                   "marca.DESCRIPCION as MARCA, " +
                                   "Modelo.DESCRIPCION AS MODELO, " +
                                   "cat.DESCRIPCION AS CATEGORIA, " +
                                   "art.STOCK, " +
                                   "art.ID_MARCA, " +
                                   "art.ID_MODELO, " +
                                   "art.ID_CATEGORIA " +
                                   "FROM udemy.db_articulos art " +
                                   "INNER JOIN udemy.db_modelo modelo ON art.ID_MODELO = modelo.ID " +
                                   "INNER JOIN udemy.db_marca marca ON art.ID_MARCA = marca.ID " +
                                   "INNER JOIN udemy.db_categorias cat ON art.ID_CATEGORIA = cat.ID " +
                                   "WHERE art.DESCRIPCION LIKE @cTexto " +
                                   "ORDER BY art.ID;";

                    using (MySqlCommand command = new MySqlCommand(query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@cTexto", "%" + cTexto + "%");
                        command.CommandTimeout = 60;

                        sqlCon.Open();
                        resultado = command.ExecuteReader();
                        dataTable.Load(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la lista de artículos: " + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return dataTable;
        }

        public string Guardar_art(int nOpcion,P_articulos oAr)
        {
            string Respuesta = "";
            string query = "";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                if (nOpcion == 1)// nuevo registro 
                {
                    query = "Insert into db_articulos(" +
                           "DESCRIPCION," +
                           "MARCA," +
                           "ID_UNIDAD," +
                           "ID_CATEGORIA," +
                           "STOCK," +
                           "FECHA_REGISTRO," +
                           "FECHA_MODIFICACION)" +
                           "VALUES" +
                           " ('" + oAr.DESCRIPCION + "' ," +
                           " '" + oAr.MARCA + "', " +
                           " '" + oAr.ID_UNIDAD + "'," +
                           " '" + oAr.ID_CATEGORIA + "'," +
                           " '" + oAr.STOCK + "', " +
                           " '" + oAr.FECHA_REGISTRO + "', " +
                           " '" + oAr.FECHA_MODIFICACION + "')";
                }
                else //actualizar
                {
                    query = "update db_articulos set DESCRIPCION = '" + oAr.DESCRIPCION + "', " +
                           "MARCA= '" + oAr.MARCA + "', " +
                           "ID_UNIDAD= '" + oAr.ID_UNIDAD + "'," +
                           "ID_CATEGORIA= '" + oAr.ID_CATEGORIA + "'," +
                           "STOCK= '" + oAr.STOCK + "', " +
                           "FECHA_MODIFICACION= '" + oAr.FECHA_MODIFICACION + "'" +
                           "where ID ='"+ oAr.ID+"'";
                           
                }

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                sqlCon.Open();
                Respuesta = command.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close( );
            }

            return Respuesta;
        }


        public string Eliminar_art(int nCodigo_art)
        {
            string Respuesta = "";
            string query = "";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();


                query = "delete from db_articulos where ID ='" + nCodigo_art + "'";



                MySqlCommand command = new MySqlCommand(query, sqlCon);
                sqlCon.Open();
                Respuesta = command.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return Respuesta;
        }


        public DataTable Lista_Marca ()
        {
            MySqlDataReader resultado;
            DataTable dataTable = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                
                string query = "SELECT DESCRIPCION , id FROM udemy.db_marca; ";

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                command.CommandTimeout = 60;
                sqlCon.Open();
                resultado = command.ExecuteReader();
                dataTable.Load(resultado);
                return dataTable;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la lista de marcas: " + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

           
        }

        public DataTable Lista_categoria()
        {
            MySqlDataReader resultado;
            DataTable dataTable = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();

                string query = "SELECT DESCRIPCION , id FROM udemy.db_categorias; ";

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                command.CommandTimeout = 60;
                sqlCon.Open();
                resultado = command.ExecuteReader();
                dataTable.Load(resultado);
                return dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la lista de categorias: " + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }


        }

    }
}
