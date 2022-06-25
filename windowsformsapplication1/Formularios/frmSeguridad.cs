using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace NoHay2Sin3
{
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
        }

        private void btnGuardarPassword_Click(object sender, EventArgs e)
        {
            DatosSeguridad seguridad = new DatosSeguridad();

            if (seguridad.confirmarExistenciaConstraseña() == true)
            {
                Entidades.Seguridad oSeg = new Entidades.Seguridad();
                oSeg.psw = txtPassowrd.Text;
                oSeg.fRegistro = DateTime.Today.ToShortDateString();
                oSeg.fDesde = DateTime.Today.ToShortDateString();

                string mes, año;
                if (DateTime.Today.Month < 12)
                {
                    mes = (DateTime.Today.Month + 1).ToString();
                    año = DateTime.Today.Year.ToString();
                }
                else
                {
                    mes = "1";
                    año = (DateTime.Today.Year + 1).ToString();
                }              
                oSeg.fchVto = "12/" + mes +"/" + año;

                //si existe una contraseña guardada, se actualiza
                if (seguridad.actualizarPassword(oSeg) == true)
                {
                    //si se actualiza correctamente
                    MessageBox.Show("Se ha registrado el sistema, por favor reinicielo para validarlo.", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    //si hay un error a la hora de actualizar
                    MessageBox.Show("Ha ocurrido un error en el registro del sistema.\nPor favor inténtelo nuevamente.", "ERROR DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else 
            {
                Entidades.Seguridad oSeg = new Entidades.Seguridad();
                oSeg.psw = txtPassowrd.Text;
                oSeg.fRegistro = DateTime.Today.ToShortDateString();
                oSeg.fDesde = DateTime.Today.ToShortDateString();

                string mes, año;
                if (DateTime.Today.Month < 12)
                {
                    mes = (DateTime.Today.Month + 1).ToString();
                    año = DateTime.Today.Year.ToString();
                }
                else
                {
                    mes = "1";
                    año = (DateTime.Today.Year + 1).ToString();
                }
                oSeg.fchVto = "12/" + mes + "/" + año;
                //si no existe contraseña guardada
                if (seguridad.insertarPassword(oSeg) == true)
                {
                    //si se guarda correctamente
                    MessageBox.Show("Se ha registrado el sistema, por favor reinicielo para validarlo.", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    //si hay un error a la hora de guardar
                    MessageBox.Show("Ha ocurrido un error en el registro del sistema.\nPor favor inténtelo nuevamente.", "ERROR DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtPassowrd.Text = "";
            }            
        }

        private void Seguridad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.Enter)
                btnGuardarPassword_Click(sender, e);
        }
    }
}
