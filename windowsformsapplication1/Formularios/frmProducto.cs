using System;
using System.Windows.Forms;
using Datos;
using Entidades;
using Validar;

namespace NoHay2Sin3
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            DatosProducto dp = new DatosProducto();
            dgvProductos.DataSource = dp.getAllProductos();
        }

        private void btnGuardarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                DatosProducto dp = new DatosProducto();
                Producto prod = new Producto();
                prod.nombreProducto = txtProducto.Text;
                prod.observacionProducto = txtObservaciones.Text;
                prod.precioX1 = Convert.ToDecimal(txtX1.Text);
                prod.precioX2 = Convert.ToDecimal(txtX2.Text);
                prod.precioX3 = Convert.ToDecimal(txtX3.Text);

                if (lblIdProducto.Text == "")
                {
                    if (dp.insertarProducto(prod) == true)
                    {
                        dgvProductos.DataSource = dp.getAllProductos();
                        
                        MessageBox.Show("Se ha guardado correctamente el producto: "+ txtProducto.Text, "Confirmación de Producto", MessageBoxButtons.OK);
                        LimpiarFormulario();

                        //DialogResult resultado = MessageBox.Show("Se ha guardado correctamente el producto. \n Desea agregar otro producto?", "Confirmación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if (resultado.ToString() == "Yes")
                        //{
                        //    LimpiarFormulario();
                        //}
                        //else this.Close();
                    }
                }
                else
                {
                    prod.idProducto = Convert.ToInt32(lblIdProducto.Text);
                    if (dp.actualizarProducto(prod) == true)
                    {
                        dgvProductos.DataSource = dp.getAllProductos();

                        DialogResult resultado = MessageBox.Show("Se ha actualizado correctamente el producto. \n Desea agregar otro producto?", "Confirmación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado.ToString() == "Yes")
                        {
                            LimpiarFormulario();
                        }
                        else this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor ingrese: \n"+"-Nombre del Producto.\n"+"-Precio X1.\n"+"-Precio X2.\n"+"-Precio X3.", "ERROR DE CARGA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.ValidarDecimales(e, txtX1);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProductos.SelectedRows[0].Cells["btnEliminar"].ColumnIndex)
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el producto: "+ dgvProductos.SelectedRows[0].Cells["nombreProducto"].Value.ToString() + "?", "Confirmación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado.ToString() == "Yes")
                {
                    DatosProducto dp = new DatosProducto();
                    dp.borrarProducto(Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["idProducto"].Value.ToString()));
                    dgvProductos.DataSource = dp.getAllProductos();
                    dgvProductos.ClearSelection();
                }
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdProducto.Text = dgvProductos.SelectedRows[0].Cells["idProducto"].Value.ToString();
            txtProducto.Text = dgvProductos.SelectedRows[0].Cells["nombreProducto"].Value.ToString();
            txtObservaciones.Text = dgvProductos.SelectedRows[0].Cells["observacionProducto"].Value.ToString();
            txtX1.Text = dgvProductos.SelectedRows[0].Cells["precioX1"].Value.ToString();
            txtX2.Text = dgvProductos.SelectedRows[0].Cells["precioX2"].Value.ToString();
            txtX3.Text = dgvProductos.SelectedRows[0].Cells["precioX3"].Value.ToString();
        }

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.ValidarDecimales(e, txtX2);
        }

        private void txtX3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.ValidarDecimales(e, txtX3);
        }

        private void LimpiarFormulario()
        {
            lblIdProducto.Text = "";
            txtProducto.Text = "";
            txtObservaciones.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
            txtX3.Text = "";
            txtProducto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            dgvProductos.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.Enter) { btnGuardarProduto_Click(sender, e); }
        }

        private void txtX1_Leave(object sender, EventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.CompletarDecimales(txtX1);
        }

        private void txtX2_Leave(object sender, EventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.CompletarDecimales(txtX2);
        }

        private void txtX3_Leave(object sender, EventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.CompletarDecimales(txtX3);
        }
    }
}
