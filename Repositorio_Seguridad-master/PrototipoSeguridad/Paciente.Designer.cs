namespace PrototipoSeguridad
{
    partial class Paciente
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
            this.nit = new System.Windows.Forms.TextBox();
            this.Lbl_des = new System.Windows.Forms.Label();
            this.Lbl_accion = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.primarykey = new System.Windows.Forms.TextBox();
            this.ciu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ape = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ale = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pais = new System.Windows.Forms.ComboBox();
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
            // nit
            // 
            this.nit.Location = new System.Drawing.Point(724, 451);
            this.nit.Name = "nit";
            this.nit.Size = new System.Drawing.Size(142, 22);
            this.nit.TabIndex = 25;
            this.nit.Tag = "nit_cliente";
            this.nit.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // Lbl_des
            // 
            this.Lbl_des.AutoSize = true;
            this.Lbl_des.Location = new System.Drawing.Point(658, 451);
            this.Lbl_des.Name = "Lbl_des";
            this.Lbl_des.Size = new System.Drawing.Size(34, 17);
            this.Lbl_des.TabIndex = 1;
            this.Lbl_des.Text = "NIT:";
            this.Lbl_des.Click += new System.EventHandler(this.Lbl_des_Click);
            // 
            // Lbl_accion
            // 
            this.Lbl_accion.AutoSize = true;
            this.Lbl_accion.Location = new System.Drawing.Point(1057, 503);
            this.Lbl_accion.Name = "Lbl_accion";
            this.Lbl_accion.Size = new System.Drawing.Size(45, 17);
            this.Lbl_accion.TabIndex = 3;
            this.Lbl_accion.Text = "Edad:";
            this.Lbl_accion.Click += new System.EventHandler(this.Lbl_accion_Click);
            // 
            // edad
            // 
            this.edad.DisplayMember = "-Seleccionar-";
            this.edad.FormattingEnabled = true;
            this.edad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.edad.Location = new System.Drawing.Point(1145, 503);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(142, 24);
            this.edad.TabIndex = 24;
            this.edad.Tag = "edad_cliente";
            this.edad.Text = "-Seleccionar-";
            this.edad.SelectedIndexChanged += new System.EventHandler(this.accion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID:";
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
            this.navegador1.sNombreTabla = "paciente";
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
            this.primarykey.Location = new System.Drawing.Point(724, 402);
            this.primarykey.Name = "primarykey";
            this.primarykey.Size = new System.Drawing.Size(142, 22);
            this.primarykey.TabIndex = 27;
            this.primarykey.Tag = "id_cliente";
            // 
            // ciu
            // 
            this.ciu.DisplayMember = "-Seleccionar-";
            this.ciu.FormattingEnabled = true;
            this.ciu.Items.AddRange(new object[] {
            "Guatemala",
            "Bogota",
            "Medellin",
            "Monterey",
            "Brasilia",
            "Mexico"});
            this.ciu.Location = new System.Drawing.Point(724, 656);
            this.ciu.Name = "ciu";
            this.ciu.Size = new System.Drawing.Size(142, 24);
            this.ciu.TabIndex = 37;
            this.ciu.Tag = "ciudad_cliente";
            this.ciu.Text = "-Seleccionar-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ciudad:";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(724, 503);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(252, 22);
            this.nom.TabIndex = 39;
            this.nom.Tag = "nombre_cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nombre:";
            // 
            // ape
            // 
            this.ape.Location = new System.Drawing.Point(724, 557);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(252, 22);
            this.ape.TabIndex = 41;
            this.ape.Tag = "apellido_cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1027, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Pais:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(724, 604);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(563, 22);
            this.dir.TabIndex = 45;
            this.dir.Tag = "direccion_cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Dirección:";
            // 
            // cor
            // 
            this.cor.Location = new System.Drawing.Point(724, 709);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(563, 22);
            this.cor.TabIndex = 47;
            this.cor.Tag = "correo";
            this.cor.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 709);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Correo:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ale
            // 
            this.ale.DisplayMember = "-Seleccionar-";
            this.ale.FormattingEnabled = true;
            this.ale.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ale.Location = new System.Drawing.Point(1143, 451);
            this.ale.Name = "ale";
            this.ale.Size = new System.Drawing.Size(142, 24);
            this.ale.TabIndex = 49;
            this.ale.Tag = "id_alergia";
            this.ale.Text = "-Seleccionar-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1055, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Alergia:";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(1143, 402);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(142, 22);
            this.tel.TabIndex = 51;
            this.tel.Tag = "telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1055, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Telefono:";
            // 
            // pais
            // 
            this.pais.DisplayMember = "-Seleccionar-";
            this.pais.FormattingEnabled = true;
            this.pais.Items.AddRange(new object[] {
            "Guatemala",
            "Bogota",
            "Medellin",
            "Monterey",
            "Brasilia",
            "Mexico"});
            this.pais.Location = new System.Drawing.Point(1143, 656);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(142, 24);
            this.pais.TabIndex = 52;
            this.pais.Tag = "pais_cliente";
            this.pais.Text = "-Seleccionar-";
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 933);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ape);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ciu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.primarykey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nit);
            this.Controls.Add(this.Lbl_des);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.Lbl_accion);
            this.Name = "Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Transacciones Paciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Trans_cliente_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox nit;
        private System.Windows.Forms.Label Lbl_des;
        private System.Windows.Forms.Label Lbl_accion;
        public System.Windows.Forms.ComboBox edad;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox primarykey;
        public System.Windows.Forms.ComboBox ciu;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox ape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox cor;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox ale;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox pais;
    }
}