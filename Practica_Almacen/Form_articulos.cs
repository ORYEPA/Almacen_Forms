using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Almacen
{
    public partial class Form_articulos : Form
    {
        public Form_articulos()
        {
            InitializeComponent();
        }

        #region "Variables"
        int nCodigo_ar = 0;
        int nEstadoguarda =0;
        int nCat = 0;
        int nMedida = 0;
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form_articulos_Load(object sender, EventArgs e)
        {
            this.Listado_art("%");
            this.Listado_categoria();
            this.Listado_medida();
        }

        

        private void bnt_search_Click(object sender, EventArgs e)
        {
            this.Listado_art("%" + text_search.Text.Trim() + "%");
        }

        #region " Metodos"

        private void Formato_ar()
        {
            DGV_ARTICULOS.Columns[0].Width = 80;
            DGV_ARTICULOS.Columns[0].HeaderText = "Código";
            DGV_ARTICULOS.Columns[1].Width = 250;
            DGV_ARTICULOS.Columns[1].HeaderText = "Artículo";
            DGV_ARTICULOS.Columns[2].Width = 150;
            DGV_ARTICULOS.Columns[2].HeaderText = "Marca";
            DGV_ARTICULOS.Columns[3].Width = 80;
            DGV_ARTICULOS.Columns[3].HeaderText = "Medida";
            DGV_ARTICULOS.Columns[4].Width = 150;
            DGV_ARTICULOS.Columns[4].HeaderText = "Categoría";
            DGV_ARTICULOS.Columns[5].Width = 150;
            DGV_ARTICULOS.Columns[5].HeaderText = "Stock Actual";
            DGV_ARTICULOS.Columns[6].Visible = false;
            DGV_ARTICULOS.Columns[7].Visible = false;
        }
        private void Listado_art(string cTexto)
        {
            D_Articulos Datos = new D_Articulos();
            DGV_ARTICULOS.DataSource = Datos.Lista_Art(cTexto);
            this.Formato_ar();
        }

        private void Estado_txt(bool lEstado)
        {
            text_art.ReadOnly = !lEstado;
            text_marca.ReadOnly = !lEstado;
            text_stock.ReadOnly = !lEstado;
        }

        private void Estado_btn(bool lEstado)
        {
            btn_medida.Enabled = lEstado;
            btn_cat.Enabled = lEstado;
            btn_cancelar.Enabled = lEstado;
            btn_guardar.Enabled = lEstado;


            text_search.ReadOnly = lEstado;
            bnt_search.Enabled = !lEstado;
            DGV_ARTICULOS.Enabled = !lEstado;
        }

        private void Estado_btn_principal(bool lEstado)
        {
            btn_new.Enabled = lEstado;
            btn_act.Enabled = lEstado;
            btn_Delete.Enabled = lEstado;
            btn_Rep.Enabled = lEstado;
            btn_Salir.Enabled = lEstado;
        }

        private void Limpia_txt()
        {
            text_art.Text = "";
            text_marca.Text = "";
            text_stock.Text = "";
            text_medida.Text = "";
            text_cat.Text = "";
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DGV_ARTICULOS.CurrentRow.Cells["ID"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_ar =Convert.ToInt32(DGV_ARTICULOS.CurrentRow.Cells["ID"].Value);
                text_art.Text = Convert.ToString(DGV_ARTICULOS.CurrentRow.Cells["DESCRIPCION"].Value);
                text_marca.Text = Convert.ToString(DGV_ARTICULOS.CurrentRow.Cells["MARCA"].Value);
                text_stock.Text = Convert.ToString(DGV_ARTICULOS.CurrentRow.Cells["STOCK"].Value);
                text_cat.Text = Convert.ToString(DGV_ARTICULOS.CurrentRow.Cells["ID_CATEGORIA"].Value);
                text_medida.Text = Convert.ToString(DGV_ARTICULOS.CurrentRow.Cells["ID_UNIDAD"].Value);
                nMedida=  Convert.ToInt32(DGV_ARTICULOS.CurrentRow.Cells["ID_UNIDAD"].Value);
                nCat=  Convert.ToInt32(DGV_ARTICULOS.CurrentRow.Cells["ID_CATEGORIA"].Value);
            }
        }





        #endregion



        #region "Categoria"

        private void Formato_categoria()
        {
            DGV_categoria.Columns[0].Width = 200;
            DGV_categoria.Columns[0].HeaderText = "Categoria";
            DGV_categoria.Columns[1].Visible = false;
            
        }
        private void Listado_categoria()
        {
            D_Articulos Datos = new D_Articulos();
            DGV_categoria.DataSource = Datos.Lista_categoria();
            this.Formato_categoria();
        }

        private void Selecciona_item_cat()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DGV_categoria.CurrentRow.Cells["ID"].Value)))
            {
                MessageBox.Show("Selecciona una categoria",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCat = Convert.ToInt32(DGV_categoria.CurrentRow.Cells["ID"].Value);
                text_cat.Text= Convert.ToString(DGV_categoria.CurrentRow.Cells["DESCRIPCION"].Value);


            }
        }
        #endregion


        #region " medidas"

        private void Formato_medida()
        {
            DGV_Medida.Columns[0].Width = 200;
            DGV_Medida.Columns[0].HeaderText = "Medida";
            DGV_Medida.Columns[1].Visible = false;


        }
        private void Listado_medida()
        {
            D_Articulos Datos = new D_Articulos();
            DGV_Medida.DataSource = Datos.Lista_Medida();
            this.Formato_medida();
        }
        private void Selecciona_item_medida()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DGV_Medida.CurrentRow.Cells["ID"].Value)))
            {
                MessageBox.Show("Selecciona una categoria",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nMedida = Convert.ToInt32(DGV_Medida.CurrentRow.Cells["ID"].Value);
                text_medida.Text = Convert.ToString(DGV_Medida.CurrentRow.Cells["DESCRIPCION"].Value);


            }
        }

        #endregion
        private void btn_new_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 1;
            this.Limpia_txt();
            this.Estado_txt(true);
            this.Estado_btn(true);
            this.Estado_btn_principal(false);
            text_art.Focus();


        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            nCodigo_ar = 0;
            nEstadoguarda = 0;

            this.Estado_txt(false);
            this.Estado_btn(false);
            this.Estado_btn_principal(true);
            text_search.Focus();
        }

        private void guardar_click(object sender, EventArgs e)
        {
            string respuesta = "";
            P_articulos oArt = new P_articulos();
            oArt.ID = nCodigo_ar;
            oArt.DESCRIPCION = text_art.Text.Trim();
            oArt.MARCA= text_marca.Text.Trim();
            oArt.STOCK= Convert.ToDecimal(text_stock.Text);
            oArt.FECHA_MODIFICACION = DateTime.Now.ToString("yyyy-MM-dd");
            oArt.FECHA_REGISTRO = DateTime.Now.ToString("yyyy-MM-dd");
            oArt.ID_UNIDAD = this.nMedida;
            oArt.ID_CATEGORIA= this.nCat;
            D_Articulos Datos = new D_Articulos();
            respuesta = Datos.Guardar_art(nEstadoguarda, oArt);

            if (respuesta.Equals("OK"))
            {
                this.Estado_txt(false);
                this.Estado_btn(false);
                this.Estado_btn_principal(true);
                this.Listado_art("%");
                nCodigo_ar = 0;
                nEstadoguarda = 0;
                nMedida = 0;
                nCat = 0;

                MessageBox.Show("Los datos han sido guardados correctamente",
                                "Aviso del sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta,
                                "Aviso del sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            
        }

        private void btn_update(object sender, EventArgs e)
        {
            nEstadoguarda = 2;
            
            this.Estado_txt(true);
            this.Estado_btn(true);
            this.Estado_btn_principal(false);
            text_art.Focus();

        }

        private void dgv_click(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

        private void delete_click(object sender, EventArgs e)
        {
            if(nCodigo_ar  >  0)
            {
                string respuesta = "";
                D_Articulos Datos = new D_Articulos();
                respuesta = Datos.Eliminar_art(nCodigo_ar);
                if(respuesta.Equals("OK"))
                {
                    this.Limpia_txt();
                    nCodigo_ar = 0;
                    this.Listado_art("%");
                    MessageBox.Show("El registro se elimino correctamente",
                                "Aviso del sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se tiene un registro seleccionado",
                               "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void click_exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Rep_Click(object sender, EventArgs e)
        {
            Form_RPT_art oRpt = new Form_RPT_art();
            oRpt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_Medida.Visible = false;
        }

        private void btn_medida_Click(object sender, EventArgs e)
        {
            Panel_Medida.Location = btn_medida.Location;
            Panel_Medida.Visible= true;
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            Panel_categoria.Location = btn_cat.Location;
            Panel_categoria.Visible= true;
        }

        private void Return_categoria_Click(object sender, EventArgs e)
        {
            Panel_categoria.Visible = false;

        }

        private void DGV_Medida_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void DGV_Medida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_medida();
            Panel_Medida.Visible = false;
        }

        private void DGV_categoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_cat();
            Panel_categoria.Visible = false;
        }
    }
}
