using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jugador.Logic;
using Jugador.Dominio;


namespace Jugador.AppWind
{
    public partial class frmEquipos : Form
    {
        public frmEquipos()
        {
            InitializeComponent();
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }



        private void cargarDatos()
        {
            var listado = EquipoBL.Listar();
            dgvDatos.Rows.Clear();
            foreach (var equ in listado)
            {

                dgvDatos.Rows.Add(equ.ID, equ.Nombre, equ.FechaInscip, equ.DescripcionT);

            }
        }

        private void nuevoo(object sender, EventArgs e)
        {

            var nuevoEqui = new Equipo();
            var frm = new frmEquipoEdit(nuevoEqui);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var exito = EquipoBL.Insertar(nuevoEqui);
                if (exito)
                {

                    MessageBox.Show("El equipo fue registrado", "Equipos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar el equipo", "Equipos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }





        }

        private void editar(object sender, EventArgs e)
        {

            if (dgvDatos.Rows.Count > 0)
            {

                int filaActual = dgvDatos.CurrentRow.Index;
                var idEqui = int.Parse(dgvDatos.Rows[filaActual].Cells[0].Value.ToString());
                var equipoEditar = EquipoBL.BuscarPorId2(idEqui);
                var frm = new frmEquipoEdit(equipoEditar);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    var exito = EquipoBL.Actualizar(equipoEditar);

                    if (exito)
                    {

                        MessageBox.Show("El equipo fue actualizado", "Equipos",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido actualizar el equpo", "Equipos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }






        }

        private void eliminar(object sender, EventArgs e)
        {



            if (dgvDatos.Rows.Count > 0)
            {

                int filaActual = dgvDatos.CurrentRow.Index;
                var idEqui = int.Parse(dgvDatos.Rows[filaActual].Cells[0].Value.ToString());
                var nombreEqui = dgvDatos.Rows[filaActual].Cells[1].Value.ToString();
                var rpta = MessageBox.Show("¿Realmente desea eliminar al cliente " + nombreEqui + "?",
                    "Equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {

                    var exito = EquipoBL.Eliminar(idEqui);
                    if (exito)
                    {
                        MessageBox.Show("El equipo ha sido eliminado", "Equipo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el equipo", "Equipo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }



        }
    }
}
