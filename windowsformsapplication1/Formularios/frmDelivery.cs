﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Validar;

namespace NoHay2Sin3
{
    public partial class frmDelivery : Form
    {
        public frmDelivery()
        {
            InitializeComponent();
        }

        private void frmDelivery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
                btnGuardarPrecioDelivery_Click(sender, e);
        }

        private void btnGuardarPrecioDelivery_Click(object sender, EventArgs e)
        {
            //guardar precio de delivery
            DialogResult resultado= MessageBox.Show("Está seguro que desea guardar el nuevo precio?", "Confirmación de precio de delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado.ToString() == "Yes")
            {
                DatosPedido d_ped = new DatosPedido();

                //verificar si existe algun precio
                //si no existe --> insertar
                //else --> actualizar
                if (d_ped.getPrecioDelivery() == -1)
                {
                    if (d_ped.insertarPrecioDelivery(Convert.ToDecimal(txtPrecioDelivery.Text.Replace(',', '.'))) == true)
                    {
                        MessageBox.Show("Se ha guardado el precio de delivery.\n El nuevo precio es: " + txtPrecioDelivery.Text, "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPrecioDelivery.Text = "";
                    }
                }
                else
                {
                    if (d_ped.actualizarPrecioDelivery(Convert.ToDecimal(txtPrecioDelivery.Text.Replace(',', '.'))) == true)
                    {
                        MessageBox.Show("Se ha actualizado el precio de delivery.\n El nuevo precio es: " + txtPrecioDelivery.Text, "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPrecioDelivery.Text = "";
                    }
                }
                
            }
            else { this.Close(); }
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            DatosPedido d_ped = new DatosPedido();
            txtPrecioDelivery.Text = d_ped.getPrecioDelivery().ToString();
            txtPrecioDelivery.Focus();
        }

        private void txtPrecioDelivery_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.ValidarDecimales(e, txtPrecioDelivery);
        }

        private void txtPrecioDelivery_Leave(object sender, EventArgs e)
        {
            Validaciones_y_Calculos val = new Validaciones_y_Calculos();
            val.CompletarDecimales(txtPrecioDelivery);
        }

        private void txtPrecioDelivery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
