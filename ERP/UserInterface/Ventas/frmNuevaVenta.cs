using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UserInterface.Ventas
{
    public partial class frmNuevaVenta : Form
    {
        decimal total = 0; // Variable que acumulara el total de cada registro del gvDetalle
        decimal subTotal = 0;
        bool gridActivo = false; // Variable encargada de saber cuando se desea modificar o eliminar el registro actual del gvDetalle
        public frmNuevaVenta()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Función encargada de sumar los totales unitarios de cada producto en el gvDetalle
        /// y reflejar el resultado en el lblValorTotal
        /// </summary>
        private void SumarTotalGrid()
        {
            total = 0;
            for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
            {
                total += decimal.Parse(gvDetalleVenta[4, i].Value.ToString());
                lblValorTotal.Text = total.ToString();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text!="" && txtPrecio.Text !="" && nudCantidad.Value>0 && txtIdCliente.Text!="")
            {
                // Estructura de control encargada de verificar si el producto a ingresar ya se encuentra
                // en el registro del gvDetalleVenta
                if (gvDetalleVenta.Rows.Count > 0)
                {
                    for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
                    {
                        if (gvDetalleVenta[0, i].Value.ToString() == txtCodigoProducto.Text)
                        {
                            gvDetalleVenta[2, i].Value = Int16.Parse(gvDetalleVenta[2, i].Value.ToString()) + Int16.Parse(nudCantidad.Value.ToString());
                            gvDetalleVenta[4, i].Value = Int16.Parse(gvDetalleVenta[2, i].Value.ToString()) * Decimal.Parse(gvDetalleVenta[3, i].Value.ToString());
                            SumarTotalGrid();
                            Limpiar();
                            gridActivo = false;
                            return;
                        }
                    }
                    gvDetalleVenta.Rows.Add(txtCodigoProducto.Text, "Descripcion producto", nudCantidad.Value.ToString(), txtPrecio.Text, decimal.Parse(txtPrecio.Text) * nudCantidad.Value);
                }
                else
                {
                    gvDetalleVenta.Rows.Add(txtCodigoProducto.Text, "Descripcion producto", nudCantidad.Value.ToString(), txtPrecio.Text, decimal.Parse(txtPrecio.Text) * nudCantidad.Value);
                }
                SumarTotalGrid();
                gridActivo = false;
                Limpiar();

            }
            else
            {
                MessageBox.Show("Hay campos no validos","Ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Función encargada de limpiar los textbox del frmNuevaVenta
        /// </summary>
        private void Limpiar()
        {
            txtCodigoProducto.Focus();
            txtCodigoProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 0;
        }

        private void gvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// estructura de control encargada de asignar ciertos valores del gvDetalle en los textbox correspondientes
            if (gvDetalleVenta.Rows.Count>0)
            {
                txtCodigoProducto.Text = gvDetalleVenta[0, gvDetalleVenta.CurrentRow.Index].Value.ToString();
                nudCantidad.Value = decimal.Parse(gvDetalleVenta[2, gvDetalleVenta.CurrentRow.Index].Value.ToString());
                txtPrecio.Text = gvDetalleVenta[3, gvDetalleVenta.CurrentRow.Index].Value.ToString();
                txtCodigoProducto.Focus();
                gridActivo = true;
            }
            
        }

        private bool ExisteValor()
        {
            for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
            {
                if (txtCodigoProducto.Text == gvDetalleVenta[0,i].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridActivo || ExisteValor())
            {
                for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
                    {
                        if (gvDetalleVenta[0, i].Value.ToString() == txtCodigoProducto.Text)
                        {
                            gvDetalleVenta[2, i].Value = nudCantidad.Value.ToString();
                            gvDetalleVenta[4, i].Value = Int16.Parse(gvDetalleVenta[2, i].Value.ToString()) * Decimal.Parse(txtPrecio.Text);
                            gvDetalleVenta[3, i].Value = txtPrecio.Text;
                            SumarTotalGrid();
                            Limpiar();
                        }
                    }
                gridActivo = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro que desea modificar","Ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gridActivo)
            {
                gvDetalleVenta.Rows.RemoveAt(gvDetalleVenta.CurrentRow.Index);
                SumarTotalGrid();
                Limpiar();
                gridActivo = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro que desea eliminar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar) | e.KeyChar=='.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
