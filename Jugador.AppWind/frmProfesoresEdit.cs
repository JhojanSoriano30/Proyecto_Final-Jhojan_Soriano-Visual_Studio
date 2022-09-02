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
    public partial class frmProfesoresEdit : Form
    {

        Profesor profesor;
        public frmProfesoresEdit(Profesor profesores)
        {
            InitializeComponent();
            this.profesor = profesores;
        }

        private void frmProfesoresEdit_Load(object sender, EventArgs e)
        {

            lblPrinc.Text = "Insciba a un entrenador";
            // btnAcept.Enabled = false;

            cargarDatos();

            if (profesor.ID > 0)
            {
                lblPrinc.Text = "Editar al entrenador " + profesor.Entrenador;

                asignarControles();

            }



        }


        private void cargarDatos()
        {
            cboEquipo.DataSource = EquipoBL.Listarcbo();
            cboEquipo.DisplayMember = "Nombre";
            cboEquipo.ValueMember = "ID";

        }




        private void asignarAObjeto()
        {
            this.profesor.Entrenador = txtNombre.Text;
            this.profesor.Categorias_entrena = txtCateg.Text;
            this.profesor.NumAlumnos = int.Parse(txtNumAl.Text);
            this.profesor.IdEquipo = int.Parse(cboEquipo.SelectedValue.ToString());
    

        }


        private void asignarControles()
        {

            txtNombre.Text = profesor.Entrenador;
            txtCateg.Text = profesor.Categorias_entrena;
            txtNumAl.Text = profesor.NumAlumnos.ToString();
            cboEquipo.SelectedValue = profesor.IdEquipo;

        }

        private void guardarr(object sender, EventArgs e)
        {

            asignarAObjeto();

            this.DialogResult = DialogResult.OK;

        }
    }
}
