
namespace Jugadores.App
{
    partial class frmJugadores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJugadores));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuev = new System.Windows.Forms.ToolStripButton();
            this.btnEdi = new System.Windows.Forms.ToolStripButton();
            this.btnElim = new System.Windows.Forms.ToolStripButton();
            this.btnProf = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDatos.Location = new System.Drawing.Point(32, 119);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(670, 300);
            this.dgvDatos.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoría";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DNI";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Profesor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Equipo que pertenece";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuev,
            this.btnEdi,
            this.btnElim,
            this.btnProf});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuev
            // 
            this.btnNuev.Image = ((System.Drawing.Image)(resources.GetObject("btnNuev.Image")));
            this.btnNuev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuev.Name = "btnNuev";
            this.btnNuev.Size = new System.Drawing.Size(62, 22);
            this.btnNuev.Text = "Nuevo";
            // 
            // btnEdi
            // 
            this.btnEdi.Image = ((System.Drawing.Image)(resources.GetObject("btnEdi.Image")));
            this.btnEdi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdi.Name = "btnEdi";
            this.btnEdi.Size = new System.Drawing.Size(57, 22);
            this.btnEdi.Text = "Editar";
            // 
            // btnElim
            // 
            this.btnElim.Image = ((System.Drawing.Image)(resources.GetObject("btnElim.Image")));
            this.btnElim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(70, 22);
            this.btnElim.Text = "Eliminar";
            // 
            // btnProf
            // 
            this.btnProf.Image = ((System.Drawing.Image)(resources.GetObject("btnProf.Image")));
            this.btnProf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(139, 22);
            this.btnProf.Text = "Listado de profesores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTADO DE JUGADORES DEL TORNEO";
            // 
            // frmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmJugadores";
            this.Text = "Listado de jugadores";
            this.Load += new System.EventHandler(this.frmJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuev;
        private System.Windows.Forms.ToolStripButton btnEdi;
        private System.Windows.Forms.ToolStripButton btnElim;
        private System.Windows.Forms.ToolStripButton btnProf;
        private System.Windows.Forms.Label label1;
    }
}

