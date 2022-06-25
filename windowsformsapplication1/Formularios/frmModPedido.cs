using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Entidades;
using Validar;
using validacionesGrilla;
using Limpiar;
using Epson.Tickets;

namespace NoHay2Sin3
{

    public partial class frmPedido : Form
    {
        bool clienteNuevo = true;

        public frmPedido()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            chkDomicilioEntrega.Checked = true;
            txtDomicilioAlternativo.Enabled = false;
            btnImprimirPedido.Enabled = false;

            txtDto.Text = "0";


            //Obtiene el precio del Delivery
            DatosPedido d_ped = new DatosPedido();
            txtEnvioPedido.Text = d_ped.getPrecioDelivery().ToString();

            
            //Deshabilita los campos que van a ser rellenados posteriormente para el pedido
            deshabilitarCamposPedido();

            //Obtiene y Carga a la grilla todos los productos.
            DatosProducto prod = new DatosProducto();
            dgvItemsPedido.DataSource = prod.getAllProductos();

            //limpia lista de promociones y detalles de promociones para sumar un nuevo pedido
            Clases.clsPromocion.listaPromo.Clear();
            Clases.clsPromocion.listaDetallePromo.Clear();
        }

        private void deshabilitarCamposPedido()
        {
            txtNombreClientePedido.Enabled = false;
            txtNombreClientePedido.BackColor = Color.DarkGray;

            txtDomicilioClientePedido.Enabled = false;
            txtDomicilioClientePedido.BackColor = Color.DarkGray;

            txtDomicilioAlternativo.Enabled = false;
            txtDomicilioAlternativo.BackColor = Color.DarkGray;

            chkDomicilioEntrega.Enabled = false;

            txtObservacionPedido.Enabled = false;
            txtObservacionPedido.BackColor = Color.DarkGray;
        }

        private void habilitarCamposPedido()
        {
            txtNombreClientePedido.Enabled = true;
            txtNombreClientePedido.BackColor = Color.White;

            txtDomicilioClientePedido.Enabled = true;
            txtDomicilioClientePedido.BackColor = Color.White;

            //txtDomicilioAlternativo.Enabled = true;
            //txtDomicilioAlternativo.BackColor = Color.DarkGray;

            txtObservacionPedido.Enabled = true;
            txtObservacionPedido.BackColor = Color.White;

            chkDomicilioEntrega.Enabled = true;
        }

        private void btnImprimirPedido_Click(object sender, EventArgs e)
        {
            //foreach fila checkeada en la lista de productos verificar cantidades.
            //si cantidad = 0 y esta chequeado --> solicitar cantidad o deschequear la fila.
            //si la cantidad es (-) y esta chequeado --> indicar un numero incorrecto
            List<DetallePromocion> listaProductos = new List<DetallePromocion>();
            int idDetallePedido = 0;


            //Valida que haya direccion a donde enviar el pedido.
            if (txtDomicilioClientePedido.Text == "" && txtDomicilioAlternativo.Text == "")
            {
                MessageBox.Show("Hay domicilio de entrega del pedido. \nPor favor ingrese algun domicilio.", "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Valida que haya un monto de abono.
            if (txtMontoAbono.Text == "")
            {
                MessageBox.Show("Por favor ingrese monto con el que abona el cliente.", "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Valida que hayaun tiempo de demora.
            if (txtDemora.Text == "")
            {
                MessageBox.Show("Por favor ingrese el tiempo de demora del pedido.", "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Recorre la lista de detalles de pedido
            foreach (Promocion promo in Clases.clsPromocion.listaPromo)
            //for (int i = 0; i < dgvItemsPedido.Rows.Count; i++)
            {

                //valida que haya algo en la lista de promociones
                if (Clases.clsPromocion.listaPromo.Count > 0)
                {
                    foreach (DetallePromocion dp in promo.listaDetallePromo)
                    {
                        DetallePromocion dp_nuevo = new DetallePromocion();
                        dp_nuevo.idProducto = dp.idProducto;
                        dp_nuevo.cantidadProducto = dp.cantidadProducto;
                        dp_nuevo.nombreProducto = dp.nombreProducto;
                        dp_nuevo.precioElegido = dp.precioElegido;
                        
                        try
                        {
                            dp_nuevo.observacionProducto = dp.observacionProducto;
                            //dp.observacionDetallePedido = dgvItemsPedido.Rows[i].Cells["observacionDetallePedido"].Value.ToString();
                        }
                        catch (Exception ex)
                        {
                            ex.Message.ToString();
                            dp_nuevo.observacionProducto = "";
                            //dp.observacionDetallePedido = "";
                        }

                        idDetallePedido++;
                        dp_nuevo.idDetallePromocion = idDetallePedido;
                        listaProductos.Add(dp_nuevo);
                    }                    
                }
            }

            //Valida que haya productos seleccionados en la lista de pedidos.
            if (listaProductos.Count == 0)
            {
                MessageBox.Show("No hay productos seleccionados para el pedido. \nPor favor ingrese alguno.", "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado= MessageBox.Show("Está seguro que desea imprimir el pedido?", "Confirmación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado.ToString() == "Yes")
            {

                if (clienteNuevo == true && rbDelivery.Checked)
                {
                    DatosCliente d_cli = new DatosCliente();
                    Cliente cli = new Cliente(0, txtNombreClientePedido.Text, txtDomicilioClientePedido.Text, txtTelefonoClientePedido.Text);
                    
                    //Se guarda el cliente nuevo
                    if (d_cli.insertarCliente(cli)== false)
                    {
                        MessageBox.Show("No se pudo grabar el nuevo cliente, por favor intentelo nuevamente", "ERROR CARGA DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else 
                {
                    if (clienteNuevo == true && rbMostrador.Checked)
                    {
                        DatosCliente d_cli = new DatosCliente();
                        int idCliente = d_cli.getIdCliente("0");

                        if (idCliente == 0) //cliente "Mostrador" no existe
                        {
                            Cliente cli = new Cliente(-1, "Mostrador", "Mostrador", "0");
                            if (d_cli.insertarCliente(cli) == false)
                            {
                                MessageBox.Show("No se pudo grabar el nuevo cliente, por favor intentelo nuevamente", "ERROR CARGA DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }                 
                }

                //Se guarda el pedido para el cliente viejo
                if (GuardarPedido(listaProductos) == true)
                {
                    ImprimirTicket();
                    LimpiarPedido();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el pedido, \n" + "por favor inténtelo nuevamente", "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //TODO ELSE SI NO QUIERE IMPRIMIR EL PEDIDO.

            //limpia lista de promociones y detalles de promociones para sumar un nuevo pedido
            Clases.clsPromocion.listaPromo.Clear();
            Clases.clsPromocion.listaDetallePromo.Clear();
            btnImprimirPedido.Enabled = false;
            LimpiarTablaPromociones();
            
        }

        private void ImprimirTicket()
        {

            manager wPrinterMan = new manager();
            List<string> wDetalle = new List<string>();
            string wTipoEntrega = string.Empty;
            string wNombreCliente = string.Empty;
            string wTelefono = string.Empty;
            string wDomicilio = string.Empty;
            string wObs = string.Empty;
            decimal wMontoTotal = 0;
            decimal wAbonaCon = 0;
            decimal wVuelto = 0;
            int wDemora = 0;
            decimal wCostoEnvio = 0;


            wNombreCliente = txtNombreClientePedido.Text;
            wTelefono = txtTelefonoClientePedido.Text;
            wObs = txtObservacionPedido.Text;
            wMontoTotal = Convert.ToDecimal(txtMontoTotalPedido.Text);
            wAbonaCon = Convert.ToDecimal(txtMontoAbono.Text);
            wVuelto = Convert.ToDecimal(txtVuelto.Text);
            wDemora = Convert.ToInt32(txtDemora.Text);

            if (!String.IsNullOrEmpty(txtEnvioPedido.Text))
                wCostoEnvio = Convert.ToDecimal(txtEnvioPedido.Text);

            if (rbDelivery.Checked)
                wTipoEntrega = "Entregado en domicilio.";
            else
                wTipoEntrega = "Entregado en mostrador.";

            if (chkDomicilioEntrega.Checked)
                wDomicilio = txtDomicilioClientePedido.Text;
            else
                wDomicilio = txtDomicilioAlternativo.Text;

            foreach (DataGridViewRow dr in dgvPromociones.Rows)
            {
                wDetalle.Add(dr.Cells["Descripcion"].Value.ToString());
            }

            //Si se le pasa 0 o -1 al idTicket --> no lo imprime al codigo de ticket
            wPrinterMan.newTicket(0, wNombreCliente, wDomicilio, wTelefono, wObs, wCostoEnvio, wMontoTotal, wAbonaCon, wVuelto, wDetalle, wTipoEntrega, wDemora);
        }

        private void LimpiarPedido()
        {
            //limpiar Formulario.
            LimpiarCampos limpia = new LimpiarCampos();

            List<Panel> listaPaneles = new List<Panel>();
            listaPaneles.Add(panelEncabezadoPedido);
            listaPaneles.Add(panelPago);

            List<TextBox> listaTxt = new List<TextBox>();
            listaTxt.Add(txtMontoAbono);
            listaTxt.Add(txtMontoTotalPedido);

            limpia.LimpiarComponentes(listaPaneles);
            deshabilitarCamposPedido();

            DatosProducto d_prod = new DatosProducto();
            dgvItemsPedido.DataSource = d_prod.getAllProductos();
            LimpiarTablaPromociones();

            DatosPedido d_ped = new DatosPedido();
            txtEnvioPedido.Text = d_ped.getPrecioDelivery().ToString();

            rbDelivery.Checked= true;
            rbDelivery.Focus();
        }

        private bool GuardarPedido(List<DetallePromocion> listaProductos) 
        {
            bool respuesta = false;
            try
            {
                Pedido ped = new Pedido();
                DatosCliente d_cli = new DatosCliente();
                if (txtTelefonoClientePedido.Text == "") txtTelefonoClientePedido.Text = "0";
                int idCliente = d_cli.getIdCliente(txtTelefonoClientePedido.Text);
                
                //carga de datos a la entidad ped = Pedido
                ped.fechaPedido = DateTime.Today.Date.Day.ToString() + "/" + DateTime.Today.Date.Month.ToString() + "/" + DateTime.Today.Date.Year.ToString();
                ped.horaPedido = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                ped.idCliente = idCliente;

                if (chkDomicilioEntrega.Checked == true) ped.domicilioEntregaPedido = txtDomicilioClientePedido.Text;
                if (chkDomicilioEntrega.Checked == false) ped.domicilioEntregaPedido = txtDomicilioAlternativo.Text;

                ped.montoTotalPedido = Convert.ToDecimal(txtMontoTotalPedido.Text);

                ped.montoAbono = Convert.ToDecimal(txtMontoAbono.Text);
                ped.tiempoDemora = Convert.ToInt32(txtDemora.Text);

                DatosPedido d_ped = new DatosPedido();
                if (d_ped.insertarPedido(ped, listaProductos) == true) respuesta = true;

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            return respuesta;

        }

        private void btnBuscarClientePedido_Click(object sender, EventArgs e)
        {
            DatosCliente clienteBuscado = new DatosCliente();
            Cliente cli = clienteBuscado.getCliente(txtTelefonoClientePedido.Text);
            txtNombreClientePedido.Text = cli.nombreCliente;
            txtDomicilioClientePedido.Text = cli.domicilioCliente;

            if (cli.nombreCliente == "")
            {
                MessageBox.Show("No se ha encontrado el cliente.\n Es un nuevo cliente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clienteNuevo = true;

                habilitarCamposPedido();
            }
            else 
            { 
                clienteNuevo = false;
                habilitarCamposPedido();
            }
        }

        private void dgvItemsPedido_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvItemsPedido.SelectedRows[0].Cells["cantidadProducto"].ColumnIndex)
                {
                    validarGrilla val = new validarGrilla();
                    val.validarCeldaNumerica(e);
                }
            }
            catch (Exception ex) { ex.Message.ToString(); }
        }

        private void btnCalcularMontoTotalPedido_Click(object sender, EventArgs e)
        {
            decimal oMonto = 0; ;
            if (txtDto.Text != "0")
                oMonto = (1 - (Convert.ToDecimal(txtDto.Text)/100)) * (calcularTotal(Clases.clsPromocion.listaPromo));
            else
                oMonto = calcularTotal(Clases.clsPromocion.listaPromo);
            oMonto = Math.Round(oMonto, 2);
            txtMontoTotalPedido.Text = (oMonto + Convert.ToDecimal(txtEnvioPedido.Text)).ToString();
            RedondearPrecio(txtMontoTotalPedido);            
            btnImprimirPedido.Enabled = true;
        }

        private void RedondearPrecio(TextBox txt)
        {
            try
            {
                int a = 0;
                foreach (char caracter in txt.Text)
                {
                    a++;
                    if (caracter.Equals(','))
                    {
                        if (!txt.Text.Substring(a, 1).Equals("0") || !txt.Text.Substring(a + 1, 1).Equals("0"))
                        {
                            txt.Text = (Convert.ToInt16(txt.Text.Substring(0, a - 1)) + 1).ToString();
                            txt.Text += ",00";
                        }
                        break;
                    }
                }
            }
            catch (Exception)
            {
                //return;
            }
            txtMontoAbono.Focus();
        }

        private decimal calcularTotal(List <Promocion> listaPromociones)
        {
            decimal montoTotal = 0;
            int cantidadProductos;

            foreach (Promocion promo in listaPromociones)
            {
                cantidadProductos = 0;
                foreach (DetallePromocion dp in promo.listaDetallePromo)
                {
                    cantidadProductos += dp.cantidadProducto;
                }

                if (cantidadProductos == 1)
                {
                    foreach (DetallePromocion dp in promo.listaDetallePromo)
                    {
                        montoTotal += (dp.cantidadProducto * dp.precioX1);
                        dp.precioElegido = dp.precioX1;
                    }
                }

                //Si son 2 productos, calcula el precio acorde a PrecioX2
                if (cantidadProductos == 2)
                {
                    foreach (DetallePromocion dp in promo.listaDetallePromo)
                    {
                        montoTotal += (dp.cantidadProducto * dp.precioX2);
                        dp.precioElegido = dp.precioX2;
                    }
                }

                //Si son 3 o mas productos
                if (cantidadProductos >= 3)
                {
                    //Si la cantidad es múltiplo de 3, calcula toros los productos acorde a PrecioX3
                    if ((cantidadProductos % 3) == 0)
                    {
                        foreach (DetallePromocion dp in promo.listaDetallePromo)
                        {
                            montoTotal += (dp.cantidadProducto * dp.precioX3);
                            dp.precioElegido = dp.precioX3;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ha ingresado una promoción de mas de 3 productos, por favor modifíquelo", "ERROR CANTIDAD DE PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
                //VER DESPUES **********************************************************************
                //**********************************************************************************
                //else
                //{
                //    //Si la cantidad total de productos no es multiplo de 3.
                //    // a) Calcula el precio del producto acorde a Precio X3 de los primeros 3 productos.
                //    // b) Si la cantidad restante es solo 1 producto, calcula el precio acorde a PrecioX1.
                //    // c) Si la cantidad restante es + de 2 productos, calcula todos los precios acorde a PrecioX2.

                //    int cantidadLeidos = 0;
                //    foreach (DetallePedido dp in listaProductos)
                //    {

                //        if (cantidadLeidos <= 3)
                //        {
                //            if ((cantidadLeidos + dp.cantidadProductoDetallePedido) <= 3)
                //            {
                //                cantidadLeidos += dp.cantidadProductoDetallePedido;
                //                montoTotal += (dp.cantidadProductoDetallePedido * dp.precioX3);
                //            }
                //            else
                //            {
                //                if ((cantidadLeidos + dp.cantidadProductoDetallePedido) == 4)
                //                {
                //                    montoTotal += ((3 - cantidadLeidos) * dp.precioX3);
                //                    montoTotal += ((dp.cantidadProductoDetallePedido - (3 - cantidadLeidos)) * dp.precioX1);
                //                }
                //                else
                //                {
                //                    montoTotal += ((3 - cantidadLeidos) * dp.precioX3);
                //                    montoTotal += ((dp.cantidadProductoDetallePedido - (3 - cantidadLeidos)) * dp.precioX2);
                //                }                                
                //                cantidadLeidos += dp.cantidadProductoDetallePedido;
                //            }
                //        }
                //        else
                //        {
                //            montoTotal += (dp.cantidadProductoDetallePedido * dp.precioX2);
                //        }
                //    }
                //}
            //}            
            return montoTotal;
        }

        private Decimal calcularTotalProducto()
        {  
            Decimal total = 0;
            int cantidadProductosPedido = 0;
            List<Producto> lista = new List<Producto>();
            for (int i = 0; i < dgvItemsPedido.Rows.Count; i++)
            {
                try
                {
                    if (dgvItemsPedido.Rows[i].Cells["Seleccionado"].Value.ToString() == "1")
                        {
                            total++;
                            cantidadProductosPedido++;
                        }
                }
                catch (Exception ex) { ex.Message.ToString(); }
            }
            
            return total;
        }

        private void chkDomicilioEntrega_CheckedChanged(object sender, EventArgs e)
        {
            txtDomicilioAlternativo.Text = "";
            if (chkDomicilioEntrega.Checked == false)
            {
                txtDomicilioAlternativo.Enabled = true;
                txtDomicilioAlternativo.BackColor = Color.White;
                txtDomicilioClientePedido.Enabled = false;
                txtDomicilioClientePedido.BackColor = Color.DarkGray;
            }
            else
            {
                txtDomicilioAlternativo.Enabled = false;
                txtDomicilioAlternativo.BackColor = Color.DarkGray;
                txtDomicilioClientePedido.Enabled = true;
                txtDomicilioClientePedido.BackColor = Color.White;
            }
        }

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.Enter && !txtTelefonoClientePedido.Focused) { btnCalcularMontoTotalPedido_Click(sender, e); }
            if (e.KeyCode == Keys.F11 && btnImprimirPedido.Enabled) { btnImprimirPedido_Click(sender, e); }
        }

        private void txtMontoAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones_y_Calculos val = new Validaciones_y_Calculos();
                val.ValidarDecimales(e, txtMontoAbono);
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
        }

        private void txtMontoAbono_Leave(object sender, EventArgs e)
        {
            try
            {
                Validaciones_y_Calculos val = new Validaciones_y_Calculos();
                val.CompletarDecimales(txtMontoAbono);
                txtVuelto.Text = (Convert.ToDecimal(txtMontoAbono.Text) - Convert.ToDecimal(txtMontoTotalPedido.Text)).ToString();
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
        }

        private void txtEnvioPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.ValidarDecimales(e, txtEnvioPedido);
        }

        private void txtEnvioPedido_Leave(object sender, EventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.CompletarDecimales(txtEnvioPedido);
        }

        private void txtTelefonoClientePedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.ValidarDecimales(e, txtTelefonoClientePedido);
        }

        private void btnNuevaPromocion_Click(object sender, EventArgs e)
        {
            //limpiar cantidad de elementos de la lista de promociones guardadas para volver a cargarlos
            for (int i = 0; i<Clases.clsPromocion.listaDetallePromo.Count;i++)
                Clases.clsPromocion.listaDetallePromo.RemoveAt(i);

            Promocion promo = new Promocion();
            List<DetallePromocion> listaPromocion = new List<DetallePromocion>();

            foreach (DataGridViewRow fila in dgvItemsPedido.Rows)
            {
                try
                {
                    if (fila.Cells["Seleccionado"].Value != null && fila.Cells["Seleccionado"].Value.ToString() == "1")
                    {
                        if (fila.Cells["cantidadProducto"].Value != null && Convert.ToInt32(fila.Cells["cantidadProducto"].Value.ToString()) > 0)
                        {
                            DetallePromocion dp = new DetallePromocion();
                            dp.cantidadProducto = Convert.ToInt32(fila.Cells["cantidadProducto"].Value.ToString());
                            dp.idProducto = Convert.ToInt32(fila.Cells["idProducto"].Value.ToString());
                            dp.nombreProducto = fila.Cells["nombreProducto"].Value.ToString();
                            dp.precioX1 = Convert.ToDecimal(fila.Cells["precioX1"].Value.ToString());
                            dp.precioX2 = Convert.ToDecimal(fila.Cells["precioX2"].Value.ToString());
                            dp.precioX3 = Convert.ToDecimal(fila.Cells["precioX3"].Value.ToString());

                            if (fila.Cells["observacionDetallePedido"].Value != null) dp.observacionProducto = fila.Cells["observacionDetallePedido"].Value.ToString();
                            if (fila.Cells["observacionDetallePedido"].Value == null) dp.observacionProducto = "";

                            listaPromocion.Add(dp);

                            Clases.clsPromocion.listaDetallePromo.Add(dp);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }                
            }
            
            if (listaPromocion.Count > 0)
            {
                promo.listaDetallePromo = listaPromocion;
                crearTablaPromociones(promo);
                Clases.clsPromocion.listaPromo.Add(promo); 
            }

            //*****************************************
            dgvItemsPedido.ClearSelection();
            foreach (DataGridViewRow dr in dgvItemsPedido.Rows)
            {
                if (dr.Cells["Seleccionado"].Value != null && dr.Cells["Seleccionado"].Value.ToString() == "1")
                {
                    dr.Cells["Seleccionado"].Value = 0;
                    dr.Cells["cantidadProducto"].Value = "";
                    dr.Cells["observacionDetallePedido"].Value = "";
                }
            }
            //*****************************************
            
        }

        /// <summary>
        /// Agrega una Promocion a la tabla de promociones.
        /// </summary>
        /// <param name="promo"></param>
        private void crearTablaPromociones(Promocion promo)
        {
            DataTable dt = (DataTable)dgvPromociones.DataSource;
            if (dt == null)
            {
                dt = new DataTable();
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Descripcion");
            }
            
            DataRow dr = dt.NewRow();

            int cantidadTotalProductos = 0;
            String descripcion = "";
            foreach (DetallePromocion dp in promo.listaDetallePromo)
            {
                cantidadTotalProductos += dp.cantidadProducto;
                descripcion += dp.getDatos();
            }

            dr["Descripcion"] = descripcion;
            dt.Rows.Add(dr);

            dgvPromociones.DataSource = dt;
            dgvPromociones.ClearSelection();
        }

        private void LimpiarTablaPromociones()
        {
            //dgvPromociones.DataSource = null;
            foreach (DataGridViewRow fila in dgvPromociones.Rows)
                    dgvPromociones.Rows.Remove(fila);

            //DataTable dt = (DataTable)dgvPromociones.DataSource;
            //if (dt == null)
            //{
            //    dt = new DataTable();
            //    dt.Columns.Add("Cantidad");
            //    dt.Columns.Add("Descripcion");
            //}
            //dgvPromociones.DataSource = dt;
            //dgvPromociones.Refresh();
            //dgvPromociones.Columns["Cantidad"].Visible = false;
        }

        private void txtTelefonoClientePedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscarClientePedido_Click(sender, e);
        }

        private void dgvItemsPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
                btnNuevaPromocion_Click(sender, e);
        }

        private void dgvItemsPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dgvItemsPedido_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvItemsPedido.IsCurrentCellDirty)
            {
                dgvItemsPedido.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void txtDemora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.ValidarSoloNumeros(e);
        }

        private void dgvPromociones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPromociones.Rows[e.RowIndex].Cells["eliminarPromo"].ColumnIndex)
            {
                Clases.clsPromocion.removePromocion();
                Clases.clsPromocion.listaPromo.RemoveAt(e.RowIndex);
                dgvPromociones.Rows.RemoveAt(dgvPromociones.SelectedRows[0].Index);
            }
        }

        private void rbMostrador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMostrador.Checked == true)
            {
                habilitarCamposPedido();
                txtDomicilioClientePedido.Text = "Mostrador";
                txtTelefonoClientePedido.Enabled = false;
                txtTelefonoClientePedido.BackColor = Color.DarkGray;
                btnBuscarClientePedido.Enabled = false;
                txtDomicilioClientePedido.Enabled = false;
                chkDomicilioEntrega.Enabled = false;
            }
            else
            {
                deshabilitarCamposPedido();
                txtDomicilioClientePedido.Text = "";
                txtTelefonoClientePedido.Enabled = true;
                txtTelefonoClientePedido.BackColor = Color.White;
                btnBuscarClientePedido.Enabled = true;
            }
        }

        private void txtTelefonoClientePedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDelivery.Checked)
            {
                DatosPedido d_ped = new DatosPedido();
                txtEnvioPedido.Text = d_ped.getPrecioDelivery().ToString();
            }
            else
            {
                txtEnvioPedido.Text = "0,00";
            }
        }

        private void txtDto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.ValidarSoloNumeros(e);
        }        
    }
}