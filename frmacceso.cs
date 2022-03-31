using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class frmacceso : Form
    {
        public frmacceso()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            CLASES.clusuarios oingresar = new CLASES.clusuarios(txtusuario.Text, txtcontraseña.Text);
            oingresar.ingresar();
            if ("le atinó" == "le atinó")
            {
                FORMULARIOS.frmmenu fusuario = new FORMULARIOS.frmmenu();
                fusuario.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Acceso Erroneo!!");
        }
    }
}
