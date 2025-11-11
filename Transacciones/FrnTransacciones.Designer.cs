namespace Transacciones
{
    partial class FrnTransacciones
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigo_Barras = new System.Windows.Forms.Label();
            this.txtCodigo_Barras = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtCodigo_b = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo_b = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtDescontinuado = new System.Windows.Forms.TextBox();
            this.lblDescontinuado = new System.Windows.Forms.Label();
            this.txtProvedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.btnDescontinuar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(519, 32);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblCodigo_Barras
            // 
            this.lblCodigo_Barras.AutoSize = true;
            this.lblCodigo_Barras.Location = new System.Drawing.Point(36, 38);
            this.lblCodigo_Barras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo_Barras.Name = "lblCodigo_Barras";
            this.lblCodigo_Barras.Size = new System.Drawing.Size(112, 16);
            this.lblCodigo_Barras.TabIndex = 1;
            this.lblCodigo_Barras.Text = "Codigo de barras";
            // 
            // txtCodigo_Barras
            // 
            this.txtCodigo_Barras.Location = new System.Drawing.Point(196, 34);
            this.txtCodigo_Barras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo_Barras.Name = "txtCodigo_Barras";
            this.txtCodigo_Barras.Size = new System.Drawing.Size(261, 22);
            this.txtCodigo_Barras.TabIndex = 2;
            this.txtCodigo_Barras.TextChanged += new System.EventHandler(this.txtCodigo_Barras_TextChanged);
            this.txtCodigo_Barras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_Barras_KeyUp);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(160, 110);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(372, 22);
            this.txtClave.TabIndex = 4;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(36, 113);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(42, 16);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Clave";
            // 
            // txtCodigo_b
            // 
            this.txtCodigo_b.Location = new System.Drawing.Point(160, 142);
            this.txtCodigo_b.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo_b.Name = "txtCodigo_b";
            this.txtCodigo_b.Size = new System.Drawing.Size(372, 22);
            this.txtCodigo_b.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 174);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 177);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(160, 206);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(372, 22);
            this.txtDescripcion.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(36, 209);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCodigo_b
            // 
            this.lblCodigo_b.AutoSize = true;
            this.lblCodigo_b.Location = new System.Drawing.Point(36, 145);
            this.lblCodigo_b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo_b.Name = "lblCodigo_b";
            this.lblCodigo_b.Size = new System.Drawing.Size(112, 16);
            this.lblCodigo_b.TabIndex = 11;
            this.lblCodigo_b.Text = "Codigo de barras";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(160, 238);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(372, 22);
            this.txtCategoria.TabIndex = 13;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(36, 241);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(160, 270);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(372, 22);
            this.txtPrecio.TabIndex = 15;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(36, 273);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(160, 302);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(372, 22);
            this.txtExistencia.TabIndex = 17;
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(36, 305);
            this.lblExistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(68, 16);
            this.lblExistencia.TabIndex = 16;
            this.lblExistencia.Text = "Existencia";
            // 
            // txtDescontinuado
            // 
            this.txtDescontinuado.Location = new System.Drawing.Point(160, 366);
            this.txtDescontinuado.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescontinuado.Name = "txtDescontinuado";
            this.txtDescontinuado.Size = new System.Drawing.Size(372, 22);
            this.txtDescontinuado.TabIndex = 21;
            // 
            // lblDescontinuado
            // 
            this.lblDescontinuado.AutoSize = true;
            this.lblDescontinuado.Location = new System.Drawing.Point(36, 369);
            this.lblDescontinuado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontinuado.Name = "lblDescontinuado";
            this.lblDescontinuado.Size = new System.Drawing.Size(98, 16);
            this.lblDescontinuado.TabIndex = 20;
            this.lblDescontinuado.Text = "Descontinuado";
            // 
            // txtProvedor
            // 
            this.txtProvedor.Location = new System.Drawing.Point(160, 334);
            this.txtProvedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvedor.Name = "txtProvedor";
            this.txtProvedor.Size = new System.Drawing.Size(372, 22);
            this.txtProvedor.TabIndex = 19;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(36, 337);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(71, 16);
            this.lblProveedor.TabIndex = 18;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Location = new System.Drawing.Point(160, 398);
            this.txtFechaAlta.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.Size = new System.Drawing.Size(372, 22);
            this.txtFechaAlta.TabIndex = 23;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(36, 401);
            this.lblFechaAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(71, 16);
            this.lblFechaAlta.TabIndex = 22;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // btnDescontinuar
            // 
            this.btnDescontinuar.Location = new System.Drawing.Point(357, 428);
            this.btnDescontinuar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescontinuar.Name = "btnDescontinuar";
            this.btnDescontinuar.Size = new System.Drawing.Size(100, 28);
            this.btnDescontinuar.TabIndex = 24;
            this.btnDescontinuar.Text = "Descontinuar";
            this.btnDescontinuar.UseVisualStyleBackColor = true;
            this.btnDescontinuar.Click += new System.EventHandler(this.btnDescontinuar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Codigo_Barras,
            this.Nombre,
            this.Descripcion,
            this.Categoria});
            this.dataGridView1.Location = new System.Drawing.Point(539, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 150);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.Width = 125;
            // 
            // Codigo_Barras
            // 
            this.Codigo_Barras.HeaderText = "Codigo_Barras";
            this.Codigo_Barras.MinimumWidth = 6;
            this.Codigo_Barras.Name = "Codigo_Barras";
            this.Codigo_Barras.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // FrnTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDescontinuar);
            this.Controls.Add(this.txtFechaAlta);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.txtDescontinuado);
            this.Controls.Add(this.lblDescontinuado);
            this.Controls.Add(this.txtProvedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCodigo_b);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo_b);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtCodigo_Barras);
            this.Controls.Add(this.lblCodigo_Barras);
            this.Controls.Add(this.btnBuscar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrnTransacciones";
            this.Text = "FnrTransacciones";
            this.Load += new System.EventHandler(this.FrnTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCodigo_Barras;
        private System.Windows.Forms.TextBox txtCodigo_Barras;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtCodigo_b;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo_b;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.TextBox txtDescontinuado;
        private System.Windows.Forms.Label lblDescontinuado;
        private System.Windows.Forms.TextBox txtProvedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtFechaAlta;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Button btnDescontinuar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}

