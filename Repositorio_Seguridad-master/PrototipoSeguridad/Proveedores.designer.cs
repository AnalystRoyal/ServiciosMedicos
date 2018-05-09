namespace PrototipoSeguridad
{
    partial class Proveedores
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
            this.Dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.navegador1 = new Navegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_proveedores
            // 
            this.Dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_proveedores.Location = new System.Drawing.Point(112, 183);
            this.Dgv_proveedores.Name = "Dgv_proveedores";
            this.Dgv_proveedores.Size = new System.Drawing.Size(452, 199);
            this.Dgv_proveedores.TabIndex = 0;
            this.Dgv_proveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_proveedores_CellDoubleClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.BackgroundImage = global::PrototipoSeguridad.Properties.Resources.icons8_Exit_48px_2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.CausesValidation = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(631, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 46);
            this.button4.TabIndex = 59;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.BackgroundImage = global::PrototipoSeguridad.Properties.Resources.icons8_Fast_Forward_48px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.CausesValidation = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(426, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 46);
            this.button3.TabIndex = 58;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.BackgroundImage = global::PrototipoSeguridad.Properties.Resources.icons8_Rewind_48px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.CausesValidation = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(276, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 46);
            this.button2.TabIndex = 57;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.BackgroundImage = global::PrototipoSeguridad.Properties.Resources.icons8_Add_File_48px1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.CausesValidation = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(22, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 46);
            this.button5.TabIndex = 56;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Gainsboro;
            this.navegador1.Location = new System.Drawing.Point(10, 55);
            this.navegador1.Name = "navegador1";
            this.navegador1.sAppNumero = null;
            this.navegador1.Size = new System.Drawing.Size(675, 67);
            this.navegador1.sNom_Usuario = null;
            this.navegador1.sNombreBD = null;
            this.navegador1.sNombreTabla = null;
            this.navegador1.sPass = null;
            this.navegador1.sServidor = null;
            this.navegador1.sUsuario = null;
            this.navegador1.TabIndex = 55;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(726, 441);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Dgv_proveedores);
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.Click += new System.EventHandler(this.Proveedores_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_proveedores;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private Navegador.Navegador navegador1;
    }
}