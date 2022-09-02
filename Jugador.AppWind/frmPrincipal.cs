using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jugador.AppWind
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void abrirJugador(object sender, EventArgs e)
        {
            var frm = new frmJugadores();
            frm.MdiParent = this;
            frm.Show();


        }

        private void abrirEqui(object sender, EventArgs e)
        {
            var frm = new frmEquipos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void abrirProf(object sender, EventArgs e)
        {
            var frm = new frmProfesor();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
