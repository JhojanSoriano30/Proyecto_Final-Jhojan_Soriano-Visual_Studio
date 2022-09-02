using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jugador.Dominio;
using Jugador.Logic;


namespace Jugador.AppWind
{
    public partial class frmJugadores : Form
    {
        public frmJugadores()
        {
            InitializeComponent();
        }

        private void frmJugadores_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }


        private void cargarDatos()
        {
            var listado = JugadoresBL.Listar();
            dgvDatos.Rows.Clear();
            foreach (var jug in listado)
            {

                dgvDatos.Rows.Add(jug.ID, jug.Nombre, jug.Apellido, jug.Categoria, jug.Dni, jug.Profesor, jug.Equipo);

            }
        }


        private void btnNuev_Click(object sender, EventArgs e)
        {

            var nuevoJug = new Dominio.Jugadores();
            var frm = new frmJugadoresEdit(nuevoJug);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //this.Text = "Nuevo";
                var exito = JugadoresBL.Insertar(nuevoJug);
                if (exito)
                {

                    MessageBox.Show("El jugador se ha registrado correctamente", "Torneo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar al jugador", "Torneo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }





        }

        private void btnEdi_Click(object sender, EventArgs e)
        {

            if (dgvDatos.Rows.Count > 0)
            {

                int filaActual = dgvDatos.CurrentRow.Index;
                var idJug = int.Parse(dgvDatos.Rows[filaActual].Cells[0].Value.ToString());
                var JugEditar = JugadoresBL.BuscarPorId(idJug);
                var frm = new frmJugadoresEdit(JugEditar);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                   // this.Text = "ACtualizar";

                    var exito = JugadoresBL.Actualizar(JugEditar);

                    if (exito)
                    {

                        MessageBox.Show("El jugador fue actualizado con éxito", "Torneo",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido actualizar al jugador", "Torneo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }





        }

        private void btnElim_Click(object sender, EventArgs e)
        {


            if (dgvDatos.Rows.Count > 0)
            {

                int filaActual = dgvDatos.CurrentRow.Index;
                var idJug = int.Parse(dgvDatos.Rows[filaActual].Cells[0].Value.ToString());
                var nombreJug = dgvDatos.Rows[filaActual].Cells[1].Value.ToString();
                var rpta = MessageBox.Show("¿Realmente desea eliminar al jugador " + nombreJug + " ?",
                    "Torneo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {

                    var exito = JugadoresBL.Eliminar(idJug);
                    if (exito)
                    {
                        MessageBox.Show("El jugador ha sido eliminado", "Torneo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar al jugador", "Torneo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }



        }

    

        private void button1_Click(object sender, EventArgs e)
        {
    
        }
    }
}
