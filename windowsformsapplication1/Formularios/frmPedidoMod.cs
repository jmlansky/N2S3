﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Datos;
using Entidades;
using Validar;
using validacionesGrilla;
using Limpiar;
using Epson.Tickets;
using System.Configuration;
using System.Linq;

namespace NoHay2Sin3
{

    public partial class frmPedido : Form
    {
        bool clienteNuevo = true;
        // atributo que indica si es una actualizacion de pedido o un nuevo pedido, por defecto es un nuevo pedido
        private bool esActualizacion = false;
        // atributo que contiene el id del pedido que se va a actualizar (se borra y se crea otro nuevo)
        private long idPedidoActualizar = -1;

        public frmPedido()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // volver a cero las tablas y campos de la interfaz
            limpiarYCargarACero();

            SetDeValoresPorDefecto();

            // cargar pedidos del dia
            cargarPedidosDiarios();
        }

        private void SetDeValoresPorDefecto()
        {
            Top = 0;
            Left = 0;
            chkDomicilioEntrega.Checked = true;
            txtDomicilioAlternativo.Enabled = false;
            btnImprimirPedido.Enabled = false;

            txtDto.Text = "0";

            //Obtiene el precio del Delivery
            DatosPedido d_ped = new DatosPedido();
            var precioDelivery = d_ped.getPrecioDelivery().ToString();
            txtEnvioPedido.Text = !string.IsNullOrEmpty(precioDelivery) ? precioDelivery : "0";

            //Deshabilita los campos que van a ser rellenados posteriormente para el pedido
            deshabilitarCamposPedido();
        }

        /// <summary>
        ///  Metodo que permite volver a cero todas las grillas y datos de la interfaz
        /// </summary>
        private void limpiarYCargarACero()
        {
            //Obtiene y Carga a la grilla todos los productos.
            DatosProducto prod = new DatosProducto();
            dgvItemsPedido.DataSource = prod.getAllProductos();

            //limpia lista de promociones y detalles de promociones para sumar un nuevo pedido
            Clases.clsPromocion.listaPromo.Clear();
            Clases.clsPromocion.listaDetallePromo.Clear();
        }

        /// <summary>
        /// Metodo que carga la grilla de pedidos diarios
        /// </summary>
        private void cargarPedidosDiarios()
        {
            // obtiener la lista de los pedidos realizados el dia de hoy
            DatosPedido oDatos = new DatosPedido();
            PedidosLista oLista = new PedidosLista(oDatos.getAllPedidos(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1), OrderEnum.DESC));
            dgvPedidosDia.DataSource = oLista;
            dgvPedidosDia.Refresh();
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

            txtObservacionPedido.Enabled = true;
            txtObservacionPedido.BackColor = Color.White;

            chkDomicilioEntrega.Enabled = true;
        }

        private void btnImprimirPedido_Click(object sender, EventArgs e)
        {
            List<DetallePromocion> listaProductos = new List<DetallePromocion>();
            int idDetallePedido = 0;

            //Valida que haya direccion a donde enviar el pedido.
            if (string.IsNullOrWhiteSpace(txtDomicilioClientePedido.Text) && string.IsNullOrWhiteSpace(txtDomicilioAlternativo.Text))
            {
                MessageBox.Show("No Hay domicilio de entrega del pedido. \nPor favor ingrese algun domicilio.", "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Valida que haya un monto de abono.
            if (string.IsNullOrWhiteSpace(txtMontoAbono.Text))
            {
                MessageBox.Show("Por favor ingrese monto con el que abona el cliente.", "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMontoAbono.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVuelto.Text))
                calcularVuelto();

            //Valida que hayaun tiempo de demora.
            if (string.IsNullOrWhiteSpace(txtDemora.Text))
            {
                txtDemora.Text = "0";
                //MessageBox.Show("Por favor ingrese el tiempo de demora del pedido.", "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }

            //Recorre la lista de detalles de pedido
            foreach (Promocion promo in Clases.clsPromocion.listaPromo)
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
                        }
                        catch (Exception ex)
                        {
                            ex.Message.ToString();
                            dp_nuevo.observacionProducto = string.Empty;
                        }

                        idDetallePedido++;
                        dp_nuevo.idDetallePromocion = idDetallePedido;
                        listaProductos.Add(dp_nuevo);
                    }
                }
            }

            //Valida que haya productos seleccionados en la lista de pedidos.
            if (!listaProductos.Any())
            {
                MessageBox.Show("No hay productos seleccionados para el pedido. \nPor favor ingrese alguno.", "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvItemsPedido.Focus();
                return;
            }

            // validar si es una actualizacion o un nuevo pedido
            //DialogResult resultado;
            //if (esActualizacion)
            //    resultado = MessageBox.Show("Está seguro que desea guardar e imprimir el pedido?", "Confirmación de Modificación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //else
            //    resultado = MessageBox.Show("Está seguro que desea guardar e imprimir el pedido?", "Confirmación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //if (resultado == DialogResult.Yes)
            //{
            
            // validar respuesta de aceptacion de impresion, sea actualizacion o no          
            DatosCliente d_cli = new DatosCliente();            
            try
            {
                if (clienteNuevo && rbDelivery.Checked)
                {
                    Cliente cli = new Cliente(0, txtNombreClientePedido.Text, txtDomicilioClientePedido.Text, txtTelefonoClientePedido.Text);

                    var clienteExistente = d_cli.getCliente(txtTelefonoClientePedido.Text);
                    if (clienteExistente == null || clienteExistente.idCliente == 0)
                    {
                        //Se guarda el cliente nuevo
                        if (!d_cli.insertarCliente(cli))
                        {
                            MessageBox.Show("No se pudo grabar el nuevo cliente, por favor intentelo nuevamente", "ERROR CARGA DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    if (clienteNuevo && rbMostrador.Checked)
                    {
                        var idCliente = d_cli.getIdCliente("0");

                        if (idCliente == 0) //cliente "Mostrador" no existe
                        {
                            var nombre = "Mostrador";
                            Cliente cli = new Cliente(-1, nombre, domicilioCliente: nombre, telefonoCliente: "0");
                            if (!d_cli.insertarCliente(cli))
                            {
                                MessageBox.Show("No se pudo grabar el nuevo cliente, por favor intentelo nuevamente", "ERROR CARGA DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                //Se guarda el pedido para el cliente viejo
                var respuesta = GuardarPedido(listaProductos);
                if (respuesta == "ok")
                {
                    ImprimirTicket();
                    LimpiarPedido();
                }
                else
                {
                    var message = "No se pudo guardar el pedido, \n" + "por favor inténtelo nuevamente\n" + respuesta;
                    MessageBox.Show(message, "ERROR DE PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // si llega a este punto, no surgio ningun error, por lo que se puede eliminar el pedido anterior en caso de ser una actualizacion
                if (esActualizacion)
                {
                    new DatosPedido().eliminarPedido(idPedidoActualizar, true);
                }
            }
            catch (Exception)
            {
                throw;
            }
            //}

            //limpia lista de promociones y detalles de promociones para sumar un nuevo pedido
            Clases.clsPromocion.listaPromo.Clear();
            Clases.clsPromocion.listaDetallePromo.Clear();
            btnImprimirPedido.Enabled = false;
            LimpiarTablaPromociones();

            // se limpian las variables que indican que es una actualizacion
            esActualizacion = false;
            idPedidoActualizar = -1;

            cargarPedidosDiarios();
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

            if (!string.IsNullOrEmpty(txtEnvioPedido.Text))
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
                wDetalle.Add(dr.Cells["Descripcion"].Value.ToString());

            var cantidad = Convert.ToInt32(ConfigurationManager.AppSettings["ImprimirVeces"]);
            for (int i = 0; i < cantidad; i++)
            {
                //Si se le pasa 0 o -1 al idTicket --> no lo imprime al codigo de ticket
                wPrinterMan.newTicket(0, wNombreCliente, wDomicilio, wTelefono, wObs, wCostoEnvio, wMontoTotal, wAbonaCon, wVuelto, wDetalle, wTipoEntrega, wDemora);
            }
        }

        private void LimpiarPedido()
        {
            //limpiar Formulario.
            LimpiarCampos limpia = new LimpiarCampos();
            txtDto.Text = "0";

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

            rbDelivery.Checked = true;
            rbDelivery.Focus();
        }

        private string GuardarPedido(List<DetallePromocion> listaProductos)
        {
            var respuesta = string.Empty;
            try
            {
                Pedido ped = new Pedido();
                DatosCliente d_cli = new DatosCliente();
                if (txtTelefonoClientePedido.Text == "") txtTelefonoClientePedido.Text = "0";
                var idCliente = d_cli.getIdCliente(txtTelefonoClientePedido.Text);

                //carga de datos a la entidad ped = Pedido
                ped.fechaPedido = DateTime.Now.ToShortDateString();
                ped.horaPedido = DateTime.Now.ToString("HH:MM");
                ped.idCliente = idCliente;

                if (chkDomicilioEntrega.Checked == true) ped.domicilioEntregaPedido = txtDomicilioClientePedido.Text;
                if (chkDomicilioEntrega.Checked == false) ped.domicilioEntregaPedido = txtDomicilioAlternativo.Text;

                ped.montoTotalPedido = Convert.ToDecimal(txtMontoTotalPedido.Text);

                ped.montoAbono = Convert.ToDecimal(txtMontoAbono.Text);
                ped.tiempoDemora = Convert.ToInt32(txtDemora.Text);
                ped.nombreClienteMostrador = txtNombreClientePedido.Text;
                ped.observacionPedido = txtObservacionPedido.Text;

                DatosPedido d_ped = new DatosPedido();
                respuesta = d_ped.insertarPedido(ped, listaProductos);
            }
            catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        private void btnBuscarClientePedido_Click(object sender, EventArgs e)
        {
            buscarClientePorTelefono();
        }


        /// <summary>
        /// Metodo que permite buscar a un cliente segun el numero telefonico ingresado
        /// Cargando los datos en los campos de la interfaz
        /// </summary>
        private void buscarClientePorTelefono()
        {
            if (string.IsNullOrEmpty(txtTelefonoClientePedido.Text))
            {
                MessageBox.Show("Por favor ingrese un cliente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DatosCliente clienteBuscado = new DatosCliente();
            Cliente cli = clienteBuscado.getCliente(txtTelefonoClientePedido.Text);
            txtNombreClientePedido.Text = cli.nombreCliente;
            txtDomicilioClientePedido.Text = cli.domicilioCliente;

            if (string.IsNullOrWhiteSpace(cli.nombreCliente))
            {
                clienteNuevo = true;
                MessageBox.Show("No se ha encontrado el cliente.\n Es un nuevo cliente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                CalcularMontoTotalPedido();
                btnImprimirPedido.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CalcularMontoTotalPedido()
        {
            decimal oMonto;
            if (string.IsNullOrWhiteSpace(txtDto.Text))
                txtDto.Text = "0";

            if (txtDto.Text != "0" && txtDto.Text != "0.00" && txtDto.Text != "0,00" && (!string.IsNullOrEmpty(txtDto.Text)))
                oMonto = (1 - (Convert.ToDecimal(txtDto.Text) / 100)) * calcularTotal(Clases.clsPromocion.listaPromo);
            else
                oMonto = calcularTotal(Clases.clsPromocion.listaPromo);
            oMonto = Math.Round(oMonto, 2);
            txtMontoTotalPedido.Text = (oMonto + Convert.ToDecimal(txtEnvioPedido.Text)).ToString();
            RedondearPrecio(txtMontoTotalPedido);
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
                            txt.Text = (Convert.ToInt32(txt.Text.Substring(0, a - 1)) + 1).ToString();
                            txt.Text += ",00";
                        }
                        break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            txtMontoAbono.Focus();
        }

        private decimal calcularTotal(List<Promocion> listaPromociones)
        {
            decimal montoTotal = 0;
            int cantidadProductos;

            foreach (Promocion promo in listaPromociones)
            {
                cantidadProductos = 0;
                foreach (DetallePromocion dp in promo.listaDetallePromo)
                    cantidadProductos += dp.cantidadProducto;


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
            return montoTotal;
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
                calcularVuelto();
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
        }

        /// <summary>
        /// Metodo que permite calcular el vuelto segun el monto total y el monto con el que se abona
        /// </summary>
        private void calcularVuelto()
        {
            txtVuelto.Text = (Convert.ToDecimal(txtMontoAbono.Text) - Convert.ToDecimal(txtMontoTotalPedido.Text)).ToString();
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
            cargarPormocionesSeleccionadasGrillaPedido();
        }


        /// <summary>
        /// Metodo que permite cargar la promo seleccionada a la grilla que contiene los datos del pedido actual
        /// </summary>
        private void cargarPormocionesSeleccionadasGrillaPedido()
        {
            //limpiar cantidad de elementos de la lista de promociones guardadas para volver a cargarlos
            //for (int i = 0; i < Clases.clsPromocion.listaDetallePromo.Count; i++)
            //    Clases.clsPromocion.listaDetallePromo.RemoveAt(i);

            Clases.clsPromocion.listaDetallePromo.Clear();

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
                            dp.idProducto = Convert.ToInt64(fila.Cells["idProducto"].Value.ToString());
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

            if (listaPromocion.Any())
            {
                promo.listaDetallePromo = listaPromocion;
                crearTablaPromociones(promo);
                Clases.clsPromocion.listaPromo.Add(promo);
            }

            LimpiarValoresDeGrillaDeITemsDePedido();

            cargarPedidosDiarios();
        }

        private void LimpiarValoresDeGrillaDeITemsDePedido()
        {
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
            foreach (DataGridViewRow fila in dgvPromociones.Rows)
                dgvPromociones.Rows.Remove(fila);
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



        private void dgvItemsPedido_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvItemsPedido.IsCurrentCellDirty)
                dgvItemsPedido.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

        private void rbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDelivery.Checked)
            {
                DatosPedido d_ped = new DatosPedido();
                txtEnvioPedido.Text = d_ped.getPrecioDelivery().ToString();
            }
            else
                txtEnvioPedido.Text = "0,00";
        }

        private void txtDto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.ValidarSoloNumeros(e);
        }

        /// <summary>
        /// Listener de doble click en la grilla
        /// </summary>
        private void dgvPedidosDia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // obtener el index del click que se selecciono
            int oSelectedIndex = e.RowIndex;

            // validar que no se encuentre fuera del rango
            if (oSelectedIndex >= 0)
            {

                DialogResult oDlgResult = MessageBox.Show("Desea modificar este pedido??", "Modificar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (oDlgResult == DialogResult.Yes)
                {
                    LimpiarTablaPromociones();

                    txtTelefonoClientePedido.Text = String.Empty;


                    // setear el flag de actualizacion
                    esActualizacion = true;

                    // obtener el id del pedido a modificar
                    idPedidoActualizar = Convert.ToInt64(dgvPedidosDia.Rows[oSelectedIndex].Cells[1].Value);

                    // cargar los datos del pedido a modificar
                    cargarEdicionPedido(idPedidoActualizar);
                }

            }
        }

        /// <summary>
        /// Metodo que permite cargar en cada uno de los campos los datos del pedidos a modificar
        /// </summary>
        /// <param name="pIdPedido">Id del pedido a modificar</param>
        private void cargarEdicionPedido(long pIdPedido)
        {
            DatosPedido oDatosPedido = new DatosPedido();
            DatosCliente oDatosCliente = new DatosCliente();
            Pedido oPedido = oDatosPedido.getOnePedidoById(pIdPedido);
            DetallePedidoLista oDetalle = new DetallePedidoLista(oDatosPedido.getAllDetallesPedidoFull(pIdPedido));
            Cliente oCliente = oDatosCliente.getClienteById(oPedido.idCliente);
            txtEnvioPedido.Text = oDatosPedido.getPrecioDelivery().ToString();

            // validar que el cliente sea distinto de null, implica que el cliente si existe en la DB
            if (oCliente != null)
            {
                // validar si es mostrador
                if (oPedido.domicilioEntregaPedido.Equals("Mostrador"))
                {
                    rbMostrador.Checked = true;
                    txtNombreClientePedido.Text = oPedido.nombreClienteMostrador;
                }
                else
                {
                    // es una entreda a domicilio, por lo que hay que cargar algunos datos extras
                    rbDelivery.Checked = true;
                    txtTelefonoClientePedido.Text = oCliente.telefonoCliente;
                    buscarClientePorTelefono();
                    txtDomicilioClientePedido.Text = oPedido.domicilioEntregaPedido;
                }

                txtObservacionPedido.Text = oPedido.observacionPedido;
                txtDto.Text = oPedido.descuento.ToString("F");
                txtMontoTotalPedido.Text = oPedido.montoTotalPedido.ToString("F");
                txtMontoAbono.Text = oPedido.montoAbono.ToString("F");
                txtDemora.Text = oPedido.tiempoDemora.ToString();

                calcularVuelto();
            }

            validarProductosAEditar(oDetalle);

        }


        /// <summary>
        /// Recorre la lista de productos y selecciona los que estan dentro del detalle de pendido en cuestion
        /// No se agrega la promocion a la lista de promos que lleva, asi se le permite modificar directamente en la 
        /// grilla el detalle de los productos
        /// </summary>
        /// <param name="pLista">Lista de detalle de pedido</param>
        private void validarProductosAEditar(DetallePedidoLista pLista)
        {
            // volver los datos a cero
            limpiarYCargarACero();

            // recorrer la lista de detalles de este pedido
            foreach (DetallePedido detalle in pLista)
            {
                // recorrer la grilla de productos para ver cual de ellos esta incluido en el pedido
                foreach (DataGridViewRow fila in dgvItemsPedido.Rows)
                {
                    // validar que el porducto este incluido en el detalle de pedido
                    if (Convert.ToInt32(fila.Cells["idProducto"].Value.ToString()) == detalle.idProducto)
                    {
                        fila.Cells["Seleccionado"].Value = 1;
                        fila.Cells["cantidadProducto"].Value = detalle.cantidadProductoDetallePedido;
                        fila.Cells["observacionDetallePedido"].Value = detalle.observacionDetallePedido;
                    }
                }
            }
        }
    }
}