
namespace Presentacion
{
    partial class FrmVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVentanaPrincipal = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.pbxVentanaPrincipal = new System.Windows.Forms.PictureBox();
            this.lblAvanzados = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboOrden = new System.Windows.Forms.ComboBox();
            this.lblOrdenarPor = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentanaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVentanaPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentanaPrincipal
            // 
            this.dgvVentanaPrincipal.AllowUserToAddRows = false;
            this.dgvVentanaPrincipal.AllowUserToDeleteRows = false;
            this.dgvVentanaPrincipal.AllowUserToOrderColumns = true;
            this.dgvVentanaPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvVentanaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentanaPrincipal.Location = new System.Drawing.Point(12, 61);
            this.dgvVentanaPrincipal.Name = "dgvVentanaPrincipal";
            this.dgvVentanaPrincipal.ReadOnly = true;
            this.dgvVentanaPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentanaPrincipal.Size = new System.Drawing.Size(508, 230);
            this.dgvVentanaPrincipal.TabIndex = 5;
            this.dgvVentanaPrincipal.SelectionChanged += new System.EventHandler(this.dgvVentanaPrincipal_SelectionChanged);
            // 
            // Articulo
            // 
            this.Articulo.AutoSize = true;
            this.Articulo.Location = new System.Drawing.Point(9, 19);
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(55, 13);
            this.Articulo.TabIndex = 1;
            this.Articulo.Text = "Buscador:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 35);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(218, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cboMarcas
            // 
            this.cboMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(305, 35);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(150, 21);
            this.cboMarcas.TabIndex = 1;
            // 
            // cboCategorias
            // 
            this.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(461, 34);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(150, 21);
            this.cboCategorias.TabIndex = 2;
            // 
            // pbxVentanaPrincipal
            // 
            this.pbxVentanaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxVentanaPrincipal.Location = new System.Drawing.Point(660, 61);
            this.pbxVentanaPrincipal.Name = "pbxVentanaPrincipal";
            this.pbxVentanaPrincipal.Size = new System.Drawing.Size(215, 230);
            this.pbxVentanaPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVentanaPrincipal.TabIndex = 5;
            this.pbxVentanaPrincipal.TabStop = false;
            // 
            // lblAvanzados
            // 
            this.lblAvanzados.AutoSize = true;
            this.lblAvanzados.Location = new System.Drawing.Point(236, 38);
            this.lblAvanzados.Name = "lblAvanzados";
            this.lblAvanzados.Size = new System.Drawing.Size(63, 13);
            this.lblAvanzados.TabIndex = 6;
            this.lblAvanzados.Text = "Avanzados:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(302, 19);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(458, 19);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria";
            // 
            // cboOrden
            // 
            this.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrden.FormattingEnabled = true;
            this.cboOrden.Location = new System.Drawing.Point(617, 34);
            this.cboOrden.Name = "cboOrden";
            this.cboOrden.Size = new System.Drawing.Size(150, 21);
            this.cboOrden.TabIndex = 3;
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.Location = new System.Drawing.Point(617, 19);
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(67, 13);
            this.lblOrdenarPor.TabIndex = 10;
            this.lblOrdenarPor.Text = "Ordenar Por:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(112, 298);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar Articulo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(217, 298);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(327, 298);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(270, 23);
            this.btnMarcas.TabIndex = 10;
            this.btnMarcas.Text = "Lista de Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(605, 298);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(270, 23);
            this.btnCategorias.TabIndex = 11;
            this.btnCategorias.Text = "Lista de Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(773, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // txtDescripción
            // 
            this.txtDescripción.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripción.Location = new System.Drawing.Point(526, 62);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.ReadOnly = true;
            this.txtDescripción.Size = new System.Drawing.Size(128, 230);
            this.txtDescripción.TabIndex = 6;
            this.txtDescripción.TextChanged += new System.EventHandler(this.txtDescripción_TextChanged);
            // 
            // FrmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 325);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblOrdenarPor);
            this.Controls.Add(this.cboOrden);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblAvanzados);
            this.Controls.Add(this.pbxVentanaPrincipal);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.cboMarcas);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.Articulo);
            this.Controls.Add(this.dgvVentanaPrincipal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(903, 364);
            this.MinimumSize = new System.Drawing.Size(903, 364);
            this.Name = "FrmVentanaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.FrmVentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentanaPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVentanaPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentanaPrincipal;
        private System.Windows.Forms.Label Articulo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboMarcas;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.PictureBox pbxVentanaPrincipal;
        private System.Windows.Forms.Label lblAvanzados;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboOrden;
        private System.Windows.Forms.Label lblOrdenarPor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDescripción;
    }
}

