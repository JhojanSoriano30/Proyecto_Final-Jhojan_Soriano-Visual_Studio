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
    public partial class frmProfesor : Form
    {
        public frmProfesor()
        {
            InitializeComponent();
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }


        private void cargarDatos()
        {
            var listado = ProfesorBL.Listar();
            dgvDatos.Rows.Clear();
            foreach (var pro in listado)
            {

                dgvDatos.Rows.Add(pro.ID, pro.Entrenador, pro.Categorias_entrena, pro.NumAlumnos, pro.Equipo);

            }
        }

        private void nuevo(object sender, EventArgs e)
        {

            var nuevoPro = new Profesor();
            var frm = new frmProfesoresEdit(nuevoPro);
            if (frm.ShowDialog() == DialogResult.OK)
            {

                var exito = ProfesorBL.Insertar(nuevoPro);
                if (exito)
                {

                    MessageBox.Show("El entrenador se ha registrado correctamente", "Profesores",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar al entrenador", "Profesores",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }


        private void edit(object sender, EventArgs e)
        {

            if (dgvDatos.Rows.Count > 0)
            {

                int filaActual = dgvDatos.CurrentRow.Index;
                var idPro = int.Parse(dgvDatos.Rows[filaActual].Cells[0].Value.ToString());
                var profEditar = ProfesorBL.BuscarPorId(idPro);
                var frm = new frmProfesoresEdit(profEditar);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    var exito = ProfesorBL.Actualizar(profEditar);

                    if (exito)
                    {

                        MessageBox.Show("El entrenador fue actualizado", "Profesores",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido actualizar al entrenador", "Profesores",
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
                var idPro = int.Parse(dgvDatos.Rows[filaActual].Cells[0].Value.ToString());
                var nombrePro = dgvDatos.Rows[filaActual].Cells[1].Value.ToString();
                var rpta = MessageBox.Show("¿Realmente desea eliminar al entrenador " + nombrePro + "?",
                    "Profesores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {

                    var exito = ProfesorBL.Eliminar(idPro);
                    if (exito)
                    {
                        MessageBox.Show("El entrenador ha sido eliminado", "Profesores",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar al entrenador", "Profesores",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }


          }



        }
    }
