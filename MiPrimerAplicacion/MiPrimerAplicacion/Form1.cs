using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }     

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau chau...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento click.", "¡Atención!");
            //cambia entre los dos colores por cada click
            if(this.BackColor== Color.DarkSalmon)
            {
                this.BackColor = Color.Blue;
            }
            else if(this.BackColor == Color.Blue)
            {
                this.BackColor = Color.DarkSalmon;
            }

            //Cambia el color del txt
            if (txtCaja.Text == "")
            {
                txtCaja.BackColor = Color.Red;
            }
            else
            {
                txtCaja.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            MouseEventArgs Click= (MouseEventArgs) e;
            if(Click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Presiono el botón Izquierdo.", "¡Atención!");
            }
            else if(Click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Presiono el botón derecho.", "¡Atención!");
            }
            if(Click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Presiono el botón del medio.", "¡Atención!");
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor=Color.Cyan; //cambia el color de fondo
            lblEtiqueta.Cursor=Cursors.Hand;//Cambia el puntero
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control; //cambia el color de fondo
            lblEtiqueta.Cursor = Cursors.Arrow;//Cambia el puntero
        }

        private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48 || e.KeyChar>58) && e.KeyChar != (char) Keys.Back)
            {
                e.Handled = true;//Borra el contenido
            }            
        }

        private void txtCaja2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene "+ txtCaja2.Text.Length+" caracteres");
        }
    }
}
