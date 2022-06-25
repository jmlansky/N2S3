using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace NoHay2Sin3.Formularios
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            DatosCliente oCli = new DatosCliente();
            dgvClientes.DataSource = oCli.getAllClientes();
            dgvClientes.ClearSelection();
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtNombreCliente.Text = dgvClientes.SelectedRows[0].Cells["nombreCliente"].Value.ToString();
                txtTelCliente.Text = dgvClientes.SelectedRows[0].Cells["telefonoCliente"].Value.ToString();
                txtDomicilioCliente.Text = dgvClientes.SelectedRows[0].Cells["domicilioCliente"].Value.ToString();
                //txtDni.Text = dgvClientes.SelectedRows[0].Cells["dniCliente"].Value.ToString();
                //txtNroTarjeta.Text = dgvClientes.SelectedRows[0].Cells["nroTarjetaTerritorioCliente"].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar los datos de este cliente?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente();
                    oCliente.domicilioCliente = txtDomicilioCliente.Text;
                    oCliente.nombreCliente = txtNombreCliente.Text;
                    oCliente.telefonoCliente = txtTelCliente.Text;
                    
                    DatosCliente oDCli = new DatosCliente();
                    oDCli.updateCliente(oCliente);

                    dgvClientes.DataSource = oDCli.getAllClientes();
                    foreach (DataGridViewRow oDgvr in dgvClientes.Rows)
                    {
                        if (oDgvr.Cells["telefonoCliente"].Value.ToString() == txtTelCliente.Text)
                        {
                            oDgvr.Selected = true;
                        }
                    }
                }
            }
            catch (Exception)
            { MessageBox.Show("No se ha podido modificar los datos del cliente, asegurese que el mismo exista.\nRecuerde: esta interfaz es para modificar datos existentes", "MODIFICAR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtTelCliente.Text = dgvClientes.SelectedRows[0].Cells["telefonoCliente"].Value.ToString();
                    txtNombreCliente.Text = dgvClientes.SelectedRows[0].Cells["nombreCliente"].Value.ToString();
                    txtDomicilioCliente.Text = dgvClientes.SelectedRows[0].Cells["domicilioCliente"].Value.ToString();
                }
            }
            catch (Exception)
            { }
        }

        private void txtBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            DatosCliente oCli = new DatosCliente();
            dgvClientes.DataSource = oCli.getClienteTabla(txtBuscarCliente.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Text = "";
            txtDomicilioCliente.Text = "";
            txtTelCliente.Text = "";
            txtBuscarCliente.Text = "";
            
            DatosCliente oCli = new DatosCliente();
            dgvClientes.DataSource = oCli.getAllClientes();
        }
    }
}
