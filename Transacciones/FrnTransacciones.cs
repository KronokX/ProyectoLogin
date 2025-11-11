using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Transacciones
{
    public partial class FrnTransacciones : Form
    {
        clsDaoProductos dao = new clsDaoProductos();
        List<string> codigosBuscados = new List<string>(); 

        public FrnTransacciones()
        {
            InitializeComponent();
        }

        private void FrnTransacciones_Load(object sender, EventArgs e)
        {
           
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Codigo", "Código de Barras");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Categoria", "Categoría");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Existencia", "Existencia");
            dataGridView1.Columns.Add("Descontinuado", "Descontinuado");

            
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigo_Barras.Clear();
            txtClave.Clear();
            txtCodigo_b.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtExistencia.Clear();
            txtProvedor.Clear();
            txtDescontinuado.Clear();
            txtFechaAlta.Clear();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string codigo = txtCodigo_Barras.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese un código de barras.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = dao.BuscarProductoPorCodigo(codigo);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];

                   
                    txtClave.Text = fila["Id"].ToString();
                    txtCodigo_b.Text = fila["Codigo_Barras"].ToString();
                    txtNombre.Text = fila["Nombre"].ToString();
                    txtDescripcion.Text = fila["Descripcion"].ToString();
                    txtCategoria.Text = fila["Categoria"].ToString();
                    txtPrecio.Text = fila["Precio"].ToString();
                    txtExistencia.Text = fila["Existencia"].ToString();
                    txtProvedor.Text = fila["Proveedor"].ToString();
                    txtDescontinuado.Text = (Convert.ToBoolean(fila["Descontinuado"])) ? "Sí" : "No";
                    txtFechaAlta.Text = Convert.ToDateTime(fila["FechaIngreso"]).ToString("dd/MM/yyyy");

                  
                    if (!codigosBuscados.Contains(codigo))
                    {
                        dataGridView1.Rows.Add(
                            fila["Codigo_Barras"].ToString(),
                            fila["Nombre"].ToString(),
                            fila["Categoria"].ToString(),
                            fila["Precio"].ToString(),
                            fila["Existencia"].ToString(),
                            (Convert.ToBoolean(fila["Descontinuado"])) ? "Sí" : "No"
                        );
                        codigosBuscados.Add(codigo);
                    }
                    else
                    {
                        MessageBox.Show("Este producto ya fue agregado a la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDescontinuar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la lista para descontinuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmar = MessageBox.Show(
                "¿Desea marcar TODOS los productos como descontinuados?",
                "Confirmar acción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmar == DialogResult.Yes)
            {
                int contador = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Codigo"].Value != null)
                    {
                        string codigo = row.Cells["Codigo"].Value.ToString();

                        try
                        {
                            bool resultado = dao.DescontinuarProducto(codigo);

                            if (resultado)
                            {
                                row.Cells["Descontinuado"].Value = "Sí";
                                contador++;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error con el producto " + codigo + ":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                MessageBox.Show($"{contador} productos fueron descontinuados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                codigosBuscados.Clear();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtCodigo_Barras.Text = fila.Cells["Codigo"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtExistencia.Text = fila.Cells["Existencia"].Value.ToString();
                txtDescontinuado.Text = fila.Cells["Descontinuado"].Value.ToString();
            }
        }


        private void txtCodigo_Barras_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                btnBuscar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void txtCodigo_Barras_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

