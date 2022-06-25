using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Limpiar;
using Datos;

namespace NoHay2Sin3
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            rbCajaDiaria.Checked = true;
            //dtpFechaDesdeInforme.MaxDate = DateTime.Today;
            //dtpFechaHastaInforme.MaxDate = DateTime.Today;

            LimpiarCampos limpia = new LimpiarCampos();
            List<Panel> listaPaneles = new List<Panel>();
            limpia.LimpiarComponentes(listaPaneles);

            if (rbCajaDiaria.Checked == true)
            {
                VerPedidos();
            }            
        }

        private void frmReporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        public void VerPedidos()
        {
            DatosPedido dp = new DatosPedido();            
            DateTime fechaDesde = Convert.ToDateTime(dtpFechaDesdeInforme.Value.ToShortDateString());
            DateTime fechaHasta = Convert.ToDateTime(dtpFechaHastaInforme.Value.ToShortDateString());
            dgvInformePedido.DataSource = dp.getAllPedidos(fechaDesde,fechaHasta);
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            DatosPedido dp = new DatosPedido();
            dgvInformeDetallePedido.DataSource = dgvInformeDetallePedido.DataSource = dp.getAllDetallesPedido(-1);
            
            if (rbCajaDiaria.Checked == true)
            {
                dtpFechaDesdeInforme.Value = DateTime.Today;
                dtpFechaHastaInforme.Value = DateTime.Today;
            }
            VerPedidos();

            txtCantidadPedidos.Text = dgvInformePedido.Rows.Count.ToString(); ;

            decimal suma = 0;

            for (int i = 0; i < dgvInformePedido.Rows.Count; i++)
            {
                suma += Convert.ToDecimal(dgvInformePedido.Rows[i].Cells["montoTotal"].Value.ToString());
            }
            txtIngresos.Text = suma.ToString();

            dgvCantidadesVendidas.DataSource = dp.getAllCantidadesVendidas(Convert.ToDateTime(dtpFechaDesdeInforme.Value.ToString()), Convert.ToDateTime(dtpFechaHastaInforme.Value.ToShortDateString()));
        }

        private void rbCajaDiaria_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaDesdeInforme.Value = DateTime.Today;
            dtpFechaHastaInforme.Value = DateTime.Today;

            DatosPedido dp = new DatosPedido();
            dgvInformeDetallePedido.DataSource = dgvInformeDetallePedido.DataSource = dp.getAllDetallesPedido(-1);
        }

        private void dgvInformePedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DatosPedido dp = new DatosPedido();
            dgvInformeDetallePedido.DataSource = dp.getAllDetallesPedido(Convert.ToInt32(dgvInformePedido.SelectedRows[0].Cells["idPedido"].Value.ToString()));
            dgvInformeDetallePedido.ClearSelection();
        }

        private void rbInformeVentas_CheckedChanged(object sender, EventArgs e)
        {
            DatosPedido dp = new DatosPedido();
            dgvInformeDetallePedido.DataSource = dgvInformeDetallePedido.DataSource = dp.getAllDetallesPedido(-1);
        }

        private void dgvInformePedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInformePedido.SelectedRows[0].Cells["Anular"].ColumnIndex == e.ColumnIndex)
            {
                if (MessageBox.Show("Desea anular este pedido?", "ANULAR PEDIDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DatosPedido oDatosPedido = new DatosPedido();
                    int oIdPedido = Convert.ToInt32(dgvInformePedido.SelectedRows[0].Cells["idPedido"].Value);
                    if (oDatosPedido.eliminarPedido(oIdPedido,false))
                        btnVerInforme_Click(sender, e);
                }
            }
        }
    }
}
