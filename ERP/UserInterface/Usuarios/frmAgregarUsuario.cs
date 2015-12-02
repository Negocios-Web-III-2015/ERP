using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblTituloAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            
            frmAgregarRol Nuevofrm = new frmAgregarRol();
            Nuevofrm.ShowDialog();
        }

        private void chkMostrarCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarCaracteres.Checked)
            {

                txtnueva2.Visible = true;
                txtconfirmar2.Visible = true;
            }
            else
            {
                txtnueva2.Visible = false;
                txtconfirmar2.Visible = false;
            }
                      
        }

        private void txtNueva_TextChanged(object sender, EventArgs e)
        {
            txtnueva2.Text = txtNueva.Text;
        }

        private void txtconfirmar_TextChanged(object sender, EventArgs e)
        {
            txtconfirmar2.Text = txtconfirmar.Text;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
  
            this.Close();
        }

        private void gbAgregarProducto_Enter(object sender, EventArgs e)
        {

        }

        private void txtnueva2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
