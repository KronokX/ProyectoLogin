using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System;
using System.Data;
using System.Windows.Forms;

namespace Transacciones
{
    public partial class FrnTransacciones : Form
    {
        clsDaoProductos dao = new clsDaoProductos();

        public FrnTransacciones()
        {
            InitializeComponent();
        }

        private void FrnTransacciones_Load(object sender, EventArgs e)
        {
            // Limpia campos al iniciar
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

        // =======================
        // BOTÓN BUSCAR PRODUCTO
        // =======================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
         
        }

        // =======================
        // BOTÓN DESCONTINUAR
        // =======================



        private void btnDescontinuar_Click_1(object sender, EventArgs e)
        {
            string codigo = txtCodigo_Barras.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese o busque primero un código de barras.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmar = MessageBox.Show("¿Desea marcar este producto como descontinuado?",
                                                     "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    bool resultado = dao.DescontinuarProducto(codigo);

                    if (resultado)
                    {
                        MessageBox.Show("Producto descontinuado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescontinuado.Text = "Sí";
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto. Verifique el código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar descontinuar el producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
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

        private void txtCodigo_Barras_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                btnBuscar.PerformClick(); // Ejecuta el botón buscar
                e.Handled = true;
                e.SuppressKeyPress = true; // Evita el beep
            }
        }

    }
}
