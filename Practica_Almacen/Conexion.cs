using System;
using MySql.Data.MySqlClient;

namespace Practica_Almacen
{
    internal class Conexion
    {
        private string Base;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "udemy";
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Clave = "";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion.ConnectionString = "datasource=" + this.Servidor +
                                            ";port=" + this.Puerto +
                                            ";username=" + this.Usuario +
                                            ";password=" + this.Clave +
                                            ";database=" + this.Base + ";";
            }
            catch (Exception ex)
            {
                conexion = null;
                Console.WriteLine("Error al crear la conexión: " + ex.Message);
            }
            return conexion;
        }

        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
