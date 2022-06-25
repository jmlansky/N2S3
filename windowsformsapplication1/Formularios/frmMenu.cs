using System;
using System.Windows.Forms;

namespace NoHay2Sin3
{
    public partial class frmMenu : Form
    {
        private int childFormNumber = 0;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Datos.DatosSeguridad oDalSeg = new Datos.DatosSeguridad();
            Entidades.Seguridad oSeg = new Entidades.Seguridad();

            oSeg = oDalSeg.confirmarConstraseña();

            DateTime oFechaHoy = DateTime.Today;
            DateTime oFechaVto = Convert.ToDateTime(oSeg.fchVto);
            TimeSpan oCantDias = oFechaVto - oFechaHoy;
            if (oCantDias.Days <=5)
                MessageBox.Show("Su licencia expira en: "+oCantDias.Days + " días.\nPor favor actualícelo antes del "+oSeg.fchVto,"AVISO DE ACTUALIZACION",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            if (!(oSeg.estado))
            {
                //Si el "estado" = false --> no esta registrado o esta vencido
                DialogResult resultado = MessageBox.Show("Por favor registre o actualice el sistema\n" + "Comuníquese con su programador.\n" + "Desea Registrar el Sistema?", "ERROR DE VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    Seguridad formulario = new Seguridad();
                    formulario.ShowDialog();
                }
                this.Close();

            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmPedido formulario = new frmPedido();
            formulario.MdiParent = this;
            formulario.Show();
            tsslEstado.Text = "Gestión de Pedidos";
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmProducto formulario = new frmProducto();
            formulario.MdiParent = this;
            formulario.Show();
            tsslEstado.Text = "Gestión de Productos";
        }

        private void btnPrecioDelivery_Click(object sender, EventArgs e)
        {
            frmDelivery formulario = new frmDelivery();
            formulario.ShowDialog();
        }

        private void frmMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control & e.Alt & (e.KeyCode == Keys.J))
            {
                Seguridad formulario = new Seguridad();
                formulario.ShowDialog();
            }

            if ((e.KeyCode == Keys.P) & e.Control)
            {
                btnPedido_Click(sender, e);
            }

            if ((e.KeyCode == Keys.R) & e.Control)
            {
                btnProducto_Click(sender, e);
            }

            if ((e.KeyCode == Keys.D) & e.Control)
            {
                btnPrecioDelivery_Click(sender, e);
            }

            if ((e.KeyCode == Keys.I) & e.Control)
            {
                btnInformes_Click(sender, e);
            }
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmReporte formulario = new frmReporte();
            formulario.MdiParent = this;
            formulario.Show();
            tsslEstado.Text = "Gestión de Informes";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }

        private void tsslEstado_Click(object sender, EventArgs e)
        { }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software de delivery." + "\n\nDesarrollado por: \n- Javier Lansky" + "\n(+54) 351 6819583" + "\njmlansky@gmail.com" +
            "\n- Marcos Nuñez" +"\n(+54) 351 2679477" + "\narcorojo@gmail.com", "ABOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            NoHay2Sin3.Formularios.frmCliente formulario = new Formularios.frmCliente();
            formulario.MdiParent = this;
            formulario.Show();
            tsslEstado.Text = "Listado de Clientes";
        }

    }
}
