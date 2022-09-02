
namespace Jugador.AppWind
{
    partial class frmJugadoresEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrinc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.txtApell = new System.Windows.Forms.TextBox();
            this.txtCateg = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cboProf = new System.Windows.Forms.ComboBox();
            this.cboEqui = new System.Windows.Forms.ComboBox();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría:";
            // 
            // lblPrinc
            // 
            this.lblPrinc.AutoSize = true;
            this.lblPrinc.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrinc.Location = new System.Drawing.Point(173, 19);
            this.lblPrinc.Name = "lblPrinc";
            this.lblPrinc.Size = new System.Drawing.Size(20, 27);
            this.lblPrinc.TabIndex = 3;
            this.lblPrinc.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero DNI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Profesor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Equipo en el que juega:";
            // 
            // txtNomb
            // 
            this.txtNomb.Location = new System.Drawing.Point(122, 76);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(124, 23);
            this.txtNomb.TabIndex = 7;
            // 
            // txtApell
            // 
            this.txtApell.Location = new System.Drawing.Point(129, 141);
            this.txtApell.Name = "txtApell";
            this.txtApell.Size = new System.Drawing.Size(124, 23);
            this.txtApell.TabIndex = 8;
            // 
            // txtCateg
            // 
            this.txtCateg.Location = new System.Drawing.Point(129, 208);
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.Size = new System.Drawing.Size(76, 23);
            this.txtCateg.TabIndex = 9;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(129, 273);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(110, 23);
            this.txtDni.TabIndex = 10;
            // 
            // cboProf
            // 
            this.cboProf.FormattingEnabled = true;
            this.cboProf.Location = new System.Drawing.Point(322, 107);
            this.cboProf.Name = "cboProf";
            this.cboProf.Size = new System.Drawing.Size(155, 23);
            this.cboProf.TabIndex = 11;
            // 
            // cboEqui
            // 
            this.cboEqui.FormattingEnabled = true;
            this.cboEqui.Location = new System.Drawing.Point(313, 208);
            this.cboEqui.Name = "cboEqui";
            this.cboEqui.Size = new System.Drawing.Size(155, 23);
            this.cboEqui.TabIndex = 12;
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(332, 350);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(115, 51);
            this.btnAcept.TabIndex = 13;
            this.btnAcept.Text = "Guardar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.grabJ);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(104, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 51);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmJugadoresEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 442);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.cboEqui);
            this.Controls.Add(this.cboProf);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCateg);
            this.Controls.Add(this.txtApell);
            this.Controls.Add(this.txtNomb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrinc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmJugadoresEdit";
            this.Text = "Jugadores";
            this.Load += new System.EventHandler(this.frmJugadoresEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrinc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.TextBox txtApell;
        private System.Windows.Forms.TextBox txtCateg;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cboProf;
        private System.Windows.Forms.ComboBox cboEqui;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnCancel;
    }
}