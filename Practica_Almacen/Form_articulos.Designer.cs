namespace Practica_Almacen
{
    partial class Form_articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_ARTICULOS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.text_art = new System.Windows.Forms.TextBox();
            this.text_marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_cat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cat = new System.Windows.Forms.Button();
            this.btn_medida = new System.Windows.Forms.Button();
            this.text_medida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_act = new System.Windows.Forms.Button();
            this.btn_Rep = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.text_search = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.bnt_search = new System.Windows.Forms.Button();
            this.Panel_Medida = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Return_medida = new System.Windows.Forms.Button();
            this.DGV_Medida = new System.Windows.Forms.DataGridView();
            this.Panel_categoria = new System.Windows.Forms.Panel();
            this.Return_categoria = new System.Windows.Forms.Button();
            this.DGV_categoria = new System.Windows.Forms.DataGridView();
            this.btn_marca = new System.Windows.Forms.Button();
            this.Panel_Marca = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ARTICULOS)).BeginInit();
            this.Panel_Medida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Medida)).BeginInit();
            this.Panel_categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_categoria)).BeginInit();
            this.Panel_Marca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ARTICULOS
            // 
            this.DGV_ARTICULOS.AllowUserToAddRows = false;
            this.DGV_ARTICULOS.AllowUserToDeleteRows = false;
            this.DGV_ARTICULOS.AllowUserToOrderColumns = true;
            this.DGV_ARTICULOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ARTICULOS.Location = new System.Drawing.Point(31, 199);
            this.DGV_ARTICULOS.Name = "DGV_ARTICULOS";
            this.DGV_ARTICULOS.ReadOnly = true;
            this.DGV_ARTICULOS.Size = new System.Drawing.Size(1057, 317);
            this.DGV_ARTICULOS.TabIndex = 0;
            this.DGV_ARTICULOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_click);
            this.DGV_ARTICULOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articulo:";
            // 
            // text_art
            // 
            this.text_art.Location = new System.Drawing.Point(366, 19);
            this.text_art.Name = "text_art";
            this.text_art.ReadOnly = true;
            this.text_art.Size = new System.Drawing.Size(100, 20);
            this.text_art.TabIndex = 2;
            // 
            // text_marca
            // 
            this.text_marca.Location = new System.Drawing.Point(542, 19);
            this.text_marca.Name = "text_marca";
            this.text_marca.ReadOnly = true;
            this.text_marca.Size = new System.Drawing.Size(100, 20);
            this.text_marca.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca:";
            // 
            // text_cat
            // 
            this.text_cat.Location = new System.Drawing.Point(601, 68);
            this.text_cat.Name = "text_cat";
            this.text_cat.ReadOnly = true;
            this.text_cat.Size = new System.Drawing.Size(100, 20);
            this.text_cat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria:";
            // 
            // btn_cat
            // 
            this.btn_cat.Enabled = false;
            this.btn_cat.Location = new System.Drawing.Point(708, 71);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(35, 16);
            this.btn_cat.TabIndex = 7;
            this.btn_cat.Text = ":::";
            this.btn_cat.UseVisualStyleBackColor = true;
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // btn_medida
            // 
            this.btn_medida.Enabled = false;
            this.btn_medida.Location = new System.Drawing.Point(473, 68);
            this.btn_medida.Name = "btn_medida";
            this.btn_medida.Size = new System.Drawing.Size(35, 16);
            this.btn_medida.TabIndex = 10;
            this.btn_medida.Text = ":::";
            this.btn_medida.UseVisualStyleBackColor = true;
            this.btn_medida.Click += new System.EventHandler(this.btn_medida_Click);
            // 
            // text_medida
            // 
            this.text_medida.Location = new System.Drawing.Point(366, 65);
            this.text_medida.Name = "text_medida";
            this.text_medida.ReadOnly = true;
            this.text_medida.Size = new System.Drawing.Size(100, 20);
            this.text_medida.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo:";
            // 
            // text_stock
            // 
            this.text_stock.Location = new System.Drawing.Point(756, 19);
            this.text_stock.Name = "text_stock";
            this.text_stock.ReadOnly = true;
            this.text_stock.Size = new System.Drawing.Size(100, 20);
            this.text_stock.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(452, 111);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 22);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Location = new System.Drawing.Point(590, 111);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 22);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.guardar_click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(1144, 61);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(131, 80);
            this.btn_new.TabIndex = 15;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_act
            // 
            this.btn_act.Location = new System.Drawing.Point(1144, 147);
            this.btn_act.Name = "btn_act";
            this.btn_act.Size = new System.Drawing.Size(131, 80);
            this.btn_act.TabIndex = 16;
            this.btn_act.Text = "Acutalizar";
            this.btn_act.UseVisualStyleBackColor = true;
            this.btn_act.Click += new System.EventHandler(this.btn_update);
            // 
            // btn_Rep
            // 
            this.btn_Rep.Location = new System.Drawing.Point(1144, 319);
            this.btn_Rep.Name = "btn_Rep";
            this.btn_Rep.Size = new System.Drawing.Size(131, 80);
            this.btn_Rep.TabIndex = 18;
            this.btn_Rep.Text = "Reporte";
            this.btn_Rep.UseVisualStyleBackColor = true;
            this.btn_Rep.Click += new System.EventHandler(this.btn_Rep_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1144, 233);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(131, 80);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Eliminar";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.delete_click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(1144, 405);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(131, 80);
            this.btn_Salir.TabIndex = 19;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.click_exit);
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(89, 173);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(296, 20);
            this.text_search.TabIndex = 21;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(38, 176);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(43, 13);
            this.search.TabIndex = 20;
            this.search.Text = "Buscar:";
            // 
            // bnt_search
            // 
            this.bnt_search.Location = new System.Drawing.Point(391, 177);
            this.bnt_search.Name = "bnt_search";
            this.bnt_search.Size = new System.Drawing.Size(35, 16);
            this.bnt_search.TabIndex = 22;
            this.bnt_search.Text = ":::";
            this.bnt_search.UseVisualStyleBackColor = true;
            this.bnt_search.Click += new System.EventHandler(this.bnt_search_Click);
            // 
            // Panel_Medida
            // 
            this.Panel_Medida.Controls.Add(this.button4);
            this.Panel_Medida.Controls.Add(this.Return_medida);
            this.Panel_Medida.Controls.Add(this.DGV_Medida);
            this.Panel_Medida.Location = new System.Drawing.Point(442, 232);
            this.Panel_Medida.Name = "Panel_Medida";
            this.Panel_Medida.Size = new System.Drawing.Size(200, 276);
            this.Panel_Medida.TabIndex = 23;
            this.Panel_Medida.Visible = false;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.button4.Location = new System.Drawing.Point(122, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 22);
            this.button4.TabIndex = 26;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Return_medida
            // 
            this.Return_medida.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.Return_medida.Location = new System.Drawing.Point(4, 238);
            this.Return_medida.Name = "Return_medida";
            this.Return_medida.Size = new System.Drawing.Size(75, 22);
            this.Return_medida.TabIndex = 24;
            this.Return_medida.Text = "Regresar";
            this.Return_medida.UseVisualStyleBackColor = true;
            this.Return_medida.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV_Medida
            // 
            this.DGV_Medida.AllowUserToAddRows = false;
            this.DGV_Medida.AllowUserToDeleteRows = false;
            this.DGV_Medida.AllowUserToOrderColumns = true;
            this.DGV_Medida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Medida.Location = new System.Drawing.Point(0, 3);
            this.DGV_Medida.Name = "DGV_Medida";
            this.DGV_Medida.ReadOnly = true;
            this.DGV_Medida.Size = new System.Drawing.Size(200, 229);
            this.DGV_Medida.TabIndex = 24;
            this.DGV_Medida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Medida_CellDoubleClick);
            this.DGV_Medida.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Medida_CellMouseDoubleClick);
            // 
            // Panel_categoria
            // 
            this.Panel_categoria.Controls.Add(this.Return_categoria);
            this.Panel_categoria.Controls.Add(this.DGV_categoria);
            this.Panel_categoria.Location = new System.Drawing.Point(799, 232);
            this.Panel_categoria.Name = "Panel_categoria";
            this.Panel_categoria.Size = new System.Drawing.Size(200, 276);
            this.Panel_categoria.TabIndex = 25;
            this.Panel_categoria.Visible = false;
            // 
            // Return_categoria
            // 
            this.Return_categoria.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.Return_categoria.Location = new System.Drawing.Point(4, 238);
            this.Return_categoria.Name = "Return_categoria";
            this.Return_categoria.Size = new System.Drawing.Size(75, 22);
            this.Return_categoria.TabIndex = 24;
            this.Return_categoria.Text = "Regresar";
            this.Return_categoria.UseVisualStyleBackColor = true;
            this.Return_categoria.Click += new System.EventHandler(this.Return_categoria_Click);
            // 
            // DGV_categoria
            // 
            this.DGV_categoria.AllowUserToAddRows = false;
            this.DGV_categoria.AllowUserToDeleteRows = false;
            this.DGV_categoria.AllowUserToOrderColumns = true;
            this.DGV_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_categoria.Location = new System.Drawing.Point(0, 3);
            this.DGV_categoria.Name = "DGV_categoria";
            this.DGV_categoria.ReadOnly = true;
            this.DGV_categoria.Size = new System.Drawing.Size(200, 229);
            this.DGV_categoria.TabIndex = 24;
            this.DGV_categoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_categoria_CellDoubleClick);
            // 
            // btn_marca
            // 
            this.btn_marca.Enabled = false;
            this.btn_marca.Location = new System.Drawing.Point(648, 23);
            this.btn_marca.Name = "btn_marca";
            this.btn_marca.Size = new System.Drawing.Size(35, 16);
            this.btn_marca.TabIndex = 26;
            this.btn_marca.Text = ":::";
            this.btn_marca.UseVisualStyleBackColor = true;
            this.btn_marca.Click += new System.EventHandler(this.btn_marca_click);
            // 
            // Panel_Marca
            // 
            this.Panel_Marca.Controls.Add(this.button3);
            this.Panel_Marca.Controls.Add(this.button2);
            this.Panel_Marca.Controls.Add(this.dataGridView1);
            this.Panel_Marca.Location = new System.Drawing.Point(100, 232);
            this.Panel_Marca.Name = "Panel_Marca";
            this.Panel_Marca.Size = new System.Drawing.Size(200, 276);
            this.Panel_Marca.TabIndex = 25;
            this.Panel_Marca.Visible = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.button3.Location = new System.Drawing.Point(122, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 25;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.button2.Location = new System.Drawing.Point(4, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 24;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(200, 229);
            this.dataGridView1.TabIndex = 24;
            // 
            // Form_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 550);
            this.Controls.Add(this.Panel_Marca);
            this.Controls.Add(this.btn_marca);
            this.Controls.Add(this.Panel_categoria);
            this.Controls.Add(this.Panel_Medida);
            this.Controls.Add(this.bnt_search);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Rep);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_act);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.text_stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_medida);
            this.Controls.Add(this.text_medida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cat);
            this.Controls.Add(this.text_cat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_art);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_ARTICULOS);
            this.Name = "Form_articulos";
            this.Text = "Form_articulos";
            this.Load += new System.EventHandler(this.Form_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ARTICULOS)).EndInit();
            this.Panel_Medida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Medida)).EndInit();
            this.Panel_categoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_categoria)).EndInit();
            this.Panel_Marca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ARTICULOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_art;
        private System.Windows.Forms.TextBox text_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_cat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cat;
        private System.Windows.Forms.Button btn_medida;
        private System.Windows.Forms.TextBox text_medida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_act;
        private System.Windows.Forms.Button btn_Rep;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Button bnt_search;
        private System.Windows.Forms.Panel Panel_Medida;
        private System.Windows.Forms.DataGridView DGV_Medida;
        private System.Windows.Forms.Button Return_medida;
        private System.Windows.Forms.Panel Panel_categoria;
        private System.Windows.Forms.Button Return_categoria;
        private System.Windows.Forms.DataGridView DGV_categoria;
        private System.Windows.Forms.Button btn_marca;
        private System.Windows.Forms.Panel Panel_Marca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}