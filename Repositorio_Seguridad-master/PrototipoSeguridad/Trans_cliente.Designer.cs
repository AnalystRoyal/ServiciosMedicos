namespace PrototipoSeguridad
{
    partial class Trans_cliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_des = new System.Windows.Forms.Label();
            this.Lbl_accion = new System.Windows.Forms.Label();
            this.accion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.primarykey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mantenimiento de Transacciones";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(971, 467);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(142, 22);
            this.descripcion.TabIndex = 25;
            this.descripcion.Tag = "descripcion";
            this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // Lbl_des
            // 
            this.Lbl_des.AutoSize = true;
            this.Lbl_des.Location = new System.Drawing.Point(853, 467);
            this.Lbl_des.Name = "Lbl_des";
            this.Lbl_des.Size = new System.Drawing.Size(86, 17);
            this.Lbl_des.TabIndex = 1;
            this.Lbl_des.Text = "Descripcion:";
            this.Lbl_des.Click += new System.EventHandler(this.Lbl_des_Click);
            // 
            // Lbl_accion
            // 
            this.Lbl_accion.AutoSize = true;
            this.Lbl_accion.Location = new System.Drawing.Point(883, 518);
            this.Lbl_accion.Name = "Lbl_accion";
            this.Lbl_accion.Size = new System.Drawing.Size(58, 17);
            this.Lbl_accion.TabIndex = 3;
            this.Lbl_accion.Text = "Accion: ";
            this.Lbl_accion.Click += new System.EventHandler(this.Lbl_accion_Click);
            // 
            // accion
            // 
            this.accion.DisplayMember = "-Seleccionar-";
            this.accion.FormattingEnabled = true;
            this.accion.Items.AddRange(new object[] {
            "+",
            "-"});
            this.accion.Location = new System.Drawing.Point(971, 518);
            this.accion.Name = "accion";
            this.accion.Size = new System.Drawing.Size(142, 24);
            this.accion.TabIndex = 24;
            this.accion.Tag = "accion";
            this.accion.Text = "-Seleccionar-";
            this.accion.SelectedIndexChanged += new System.EventHandler(this.accion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Codigo:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Gainsboro;
            this.navegador1.Location = new System.Drawing.Point(523, 265);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.sAppNumero = "6";
            this.navegador1.Size = new System.Drawing.Size(900, 82);
            this.navegador1.sNom_Usuario = "3";
            this.navegador1.sNombreBD = "bd_seguridad";
            this.navegador1.sNombreTabla = "transaccional_cliente";
            this.navegador1.sPass = null;
            this.navegador1.sServidor = "localhost";
            this.navegador1.sUsuario = "root";
            this.navegador1.TabIndex = 35;
            this.navegador1.NavInsertar += new System.EventHandler(this.navegador1_NavInsertar);
            this.navegador1.NavActualizar += new System.EventHandler(this.navegador1_NavActualizar);
            this.navegador1.NavEliminar += new System.EventHandler(this.navegador1_NavEliminar);
            this.navegador1.NavGuardar += new System.EventHandler(this.navegador1_NavGuardar);
            this.navegador1.NavInicio += new System.EventHandler(this.navegador1_NavInicio);
            this.navegador1.NavAnterior += new System.EventHandler(this.navegador1_NavAnterior);
            this.navegador1.NavSiguiente += new System.EventHandler(this.navegador1_NavSiguiente);
            this.navegador1.NavFin += new System.EventHandler(this.navegador1_NavFin);
            this.navegador1.NavSalir += new System.EventHandler(this.navegador1_NavSalir);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // primarykey
            // 
            this.primarykey.Location = new System.Drawing.Point(971, 418);
            this.primarykey.Name = "primarykey";
            this.primarykey.Size = new System.Drawing.Size(142, 22);
            this.primarykey.TabIndex = 27;
            this.primarykey.Tag = "cod_transaccion";
            // 
            // Trans_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 933);
            this.Controls.Add(this.primarykey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.Lbl_des);
            this.Controls.Add(this.accion);
            this.Controls.Add(this.Lbl_accion);
            this.Name = "Trans_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Transacciones Paciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Trans_cliente_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label Lbl_des;
        private System.Windows.Forms.Label Lbl_accion;
        public System.Windows.Forms.ComboBox accion;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox primarykey;
    }
}