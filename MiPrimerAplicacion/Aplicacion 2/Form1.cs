using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Funcion para validarel texto
        public bool ValidarCampo(TextBox txt)
        {
            if(txt.Text=="")
            {
                txt.BackColor = Color.Red;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            //valida que no esten vacios y si no lo estan copia los valores
            if(ValidarCampo(txtApellido) && ValidarCampo(txtNombre) && ValidarCampo(txtEdad) && ValidarCampo(txtDireccion) )
            {
                txtResultado.Text = "Nombre y Apellido: "+txtNombre.Text+" "+txtApellido.Text + "\r\n"
                    + "Edad: "+txtEdad.Text +"\r\n"
                    +"Dirección: "+ txtDireccion.Text;
            }
            else
            {
                txtResultado.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48 || e.KeyChar>58) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
    }
}
