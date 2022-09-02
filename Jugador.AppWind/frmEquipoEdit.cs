using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jugador.Dominio;
using Jugador.Logic;

namespace Jugador.AppWind
{
    public partial class frmEquipoEdit : Form
    {
        Equipo equipo;
        
        public frmEquipoEdit(Equipo equipos)
        {
            InitializeComponent();

            this.equipo = equipos;
        }

        private void frmEquipoEdit_Load(object sender, EventArgs e)
        {
            lblPrinc.Text = "Insciba a un equipo";
            // btnAcept.Enabled = false;

       

            if (equipo.ID > 0)
            {
                lblPrinc.Text = "Editar al equipo " + equipo.Nombre;

                asignarControles();

            }

        }

        private void asignarAObjeto()
        {
            this.equipo.Nombre = txtNombre.Text;
            this.equipo.FechaInscip = txtFecha.Text;
            this.equipo.DescripcionT = txtDescri.Text;


        }


        private void asignarControles()
        {


            txtNombre.Text = equipo.Nombre;
            txtFecha.Text = equipo.FechaInscip;
            txtDescri.Text = equipo.DescripcionT;
   

        }

        private void agregar(object sender, EventArgs e)
        {

            asignarAObjeto();

            this.DialogResult = DialogResult.OK;


        }
    }
}
