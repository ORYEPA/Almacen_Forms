using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace Practica_Almacen
{
    public partial class Form_RPT_art : Form
    {
        public Form_RPT_art()
        {
            InitializeComponent();
        }
        #region "metodos"
        private void Listado ()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string cTexto = "%";
                sqlCon = Conexion.GetInstancia().CrearConexion();
                string query = "SELECT " +
                                   "art.ID, " +
                                   "art.DESCRIPCION, " +
                                   "art.MARCA, " +
                                   "unidades.DESCRIPCION AS UNIDAD, " +
                                   "cat.DESCRIPCION AS CATEGORIA, " +
                                   "art.STOCK " +



                                   "FROM udemy.db_articulos art " +
                                   "INNER JOIN udemy.db_unidades unidades ON art.ID_UNIDAD = unidades.ID " +
                                   "INNER JOIN udemy.db_categorias cat ON art.ID_CATEGORIA = cat.ID " +
                                   
                                   "ORDER BY art.ID;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, sqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ReportDataSource fuente = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(fuente);
                reportViewer1.LocalReport.ReportEmbeddedResource = "Practica_Almacen.Rpt_articulo.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();
                
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();

            }

        }

        #endregion

        private void Form_RPT_art_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            this.Listado();
            
        }
    }
}
