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
    public partial class frmJugadoresEdit : Form
    {

        Jugadores jugador;

        public frmJugadoresEdit(Jugadores jugadores)
        {
            InitializeComponent();
            this.jugador = jugadores;
        }

        private void frmJugadoresEdit_Load(object sender, EventArgs e)
        {

            lblPrinc.Text = "Insciba a un jugador";
           // btnAcept.Enabled = false;

            cargarDatos();

            if (jugador.ID > 0)
            {
                lblPrinc.Text = "Editar al jugador " +jugador.Nombre;

                asignarControles();

            }

        }

        private void cargarDatos()
        {
            cboProf.DataSource = ProfesorBL.ListarCbo();
            cboProf.DisplayMember = "Entrenador";
            cboProf.ValueMember = "ID";


            cboEqui.DataSource = EquipoBL.Listarcbo();
            cboEqui.DisplayMember = "Nombre";
            cboEqui.ValueMember = "ID";


        }



        private void asignarAObjeto()
        {
            this.jugador.Nombre = txtNomb.Text;
            this.jugador.Apellido = txtApell.Text;
            this.jugador.Categoria = int.Parse(txtCateg.Text);
            this.jugador.Dni = int.Parse(txtDni.Text);
            this.jugador.IdProfe = int.Parse(cboProf.SelectedValue.ToString());
            this.jugador.IdEquip = int.Parse(cboEqui.SelectedValue.ToString());

        }


        private void asignarControles()
        {


            txtNomb.Text = jugador.Nombre;
            txtApell.Text = jugador.Apellido;
            txtCateg.Text = jugador.Categoria.ToString();
            txtDni.Text = jugador.Dni.ToString();
            cboProf.SelectedValue = jugador.IdProfe;
            cboEqui.SelectedValue = jugador.IdEquip;

        }

        private void grabJ(object sender, EventArgs e)
        {

            int cat = int.Parse(txtCateg.Text);
        


            //if (cat <= 2002)
            //{
            //    MessageBox.Show("La categoría " + cat + ", no hay en este torneo", "Error",
            //              MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return;
            //}



            //if (cat > 2018 && cat <=2021)
            //{
            //    MessageBox.Show("Las categorías como " + cat + ", son muy jóvenes para este torneo", "Error",
            //              MessageBoxButtons.OK, MessageBoxIcon.Error);



            //    return;
            //}

            //if (cat >= 2022)
            //{
            //    MessageBox.Show("Por favor ingrese una categoría válida", "Error",
            //              MessageBoxButtons.OK, MessageBoxIcon.Error);



            //    return;
            //}

            if (cat > 2002 && cat <2019)
            {

                asignarAObjeto();

                this.DialogResult = DialogResult.OK;

            }
            else
            {

                MessageBox.Show("Por favor ingrese una categoría válida", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}
