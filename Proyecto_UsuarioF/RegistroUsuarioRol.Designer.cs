
namespace Proyecto_UsuarioF
{
    partial class RegistroUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            this.label8 = new System.Windows.Forms.Label();
            this.comboboxRoles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ClaveTexbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texboxEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CostoXHoraTexbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ConfirmarClaveTexbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BottonBuscar = new System.Windows.Forms.Button();
            this.idNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.texboxAlias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texboxUsuario = new System.Windows.Forms.TextBox();
            this.texboxNombre = new System.Windows.Forms.TextBox();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ButtonNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Rol ";
            // 
            // comboboxRoles
            // 
            this.comboboxRoles.FormattingEnabled = true;
            this.comboboxRoles.Items.AddRange(new object[] {
            "Carpintero",
            "Doctor",
            "Ingenierto",
            "Artista",
            "Youtuber",
            "Gamer"});
            this.comboboxRoles.Location = new System.Drawing.Point(494, 49);
            this.comboboxRoles.Name = "comboboxRoles";
            this.comboboxRoles.Size = new System.Drawing.Size(137, 23);
            this.comboboxRoles.TabIndex = 34;
            this.comboboxRoles.SelectedIndexChanged += new System.EventHandler(this.cb_rol_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fecha Ingreso:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(480, 80);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 23);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // ClaveTexbox
            // 
            this.ClaveTexbox.Location = new System.Drawing.Point(90, 165);
            this.ClaveTexbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClaveTexbox.Name = "ClaveTexbox";
            this.ClaveTexbox.PasswordChar = '*';
            this.ClaveTexbox.Size = new System.Drawing.Size(101, 23);
            this.ClaveTexbox.TabIndex = 27;
            this.ClaveTexbox.TextChanged += new System.EventHandler(this.ClaveTexbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Clave:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email:";
            // 
            // texboxEmail
            // 
            this.texboxEmail.Location = new System.Drawing.Point(396, 117);
            this.texboxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texboxEmail.Name = "texboxEmail";
            this.texboxEmail.Size = new System.Drawing.Size(235, 23);
            this.texboxEmail.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.texboxEmail);
            this.groupBox1.Controls.Add(this.comboboxRoles);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.CostoXHoraTexbox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ConfirmarClaveTexbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BottonBuscar);
            this.groupBox1.Controls.Add(this.idNumericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.texboxAlias);
            this.groupBox1.Controls.Add(this.ClaveTexbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.texboxUsuario);
            this.groupBox1.Controls.Add(this.texboxNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 202);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(571, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 19);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CostoXHoraTexbox
            // 
            this.CostoXHoraTexbox.Location = new System.Drawing.Point(505, 165);
            this.CostoXHoraTexbox.Name = "CostoXHoraTexbox";
            this.CostoXHoraTexbox.Size = new System.Drawing.Size(112, 23);
            this.CostoXHoraTexbox.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Costo X Hora";
            // 
            // ConfirmarClaveTexbox
            // 
            this.ConfirmarClaveTexbox.Location = new System.Drawing.Point(296, 165);
            this.ConfirmarClaveTexbox.Name = "ConfirmarClaveTexbox";
            this.ConfirmarClaveTexbox.PasswordChar = '*';
            this.ConfirmarClaveTexbox.Size = new System.Drawing.Size(112, 23);
            this.ConfirmarClaveTexbox.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Confirmar Clave";
            // 
            // BottonBuscar
            // 
            this.BottonBuscar.Location = new System.Drawing.Point(109, 11);
            this.BottonBuscar.Name = "BottonBuscar";
            this.BottonBuscar.Size = new System.Drawing.Size(31, 28);
            this.BottonBuscar.TabIndex = 34;
            this.BottonBuscar.UseVisualStyleBackColor = true;
            this.BottonBuscar.Click += new System.EventHandler(this.BottonBuscar_Click);
            // 
            // idNumericUpDown1
            // 
            this.idNumericUpDown1.Location = new System.Drawing.Point(65, 16);
            this.idNumericUpDown1.Name = "idNumericUpDown1";
            this.idNumericUpDown1.Size = new System.Drawing.Size(38, 23);
            this.idNumericUpDown1.TabIndex = 33;
            this.idNumericUpDown1.ValueChanged += new System.EventHandler(this.idNumericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // texboxAlias
            // 
            this.texboxAlias.Location = new System.Drawing.Point(65, 49);
            this.texboxAlias.Name = "texboxAlias";
            this.texboxAlias.Size = new System.Drawing.Size(150, 23);
            this.texboxAlias.TabIndex = 31;
            this.texboxAlias.TextChanged += new System.EventHandler(this.txt_alias_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Alias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre:";
            // 
            // texboxUsuario
            // 
            this.texboxUsuario.Location = new System.Drawing.Point(65, 122);
            this.texboxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texboxUsuario.Name = "texboxUsuario";
            this.texboxUsuario.Size = new System.Drawing.Size(211, 23);
            this.texboxUsuario.TabIndex = 22;
            // 
            // texboxNombre
            // 
            this.texboxNombre.Location = new System.Drawing.Point(65, 85);
            this.texboxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texboxNombre.Name = "texboxNombre";
            this.texboxNombre.Size = new System.Drawing.Size(182, 23);
            this.texboxNombre.TabIndex = 20;
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEliminar.Image")));
            this.ButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEliminar.Location = new System.Drawing.Point(292, 202);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(93, 44);
            this.ButtonEliminar.TabIndex = 47;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(195, 202);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(91, 44);
            this.GuardarButton.TabIndex = 45;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ButtonNuevo
            // 
            this.ButtonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNuevo.Image")));
            this.ButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNuevo.Location = new System.Drawing.Point(391, 202);
            this.ButtonNuevo.Name = "ButtonNuevo";
            this.ButtonNuevo.Size = new System.Drawing.Size(93, 44);
            this.ButtonNuevo.TabIndex = 48;
            this.ButtonNuevo.Text = "Nuevo";
            this.ButtonNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNuevo.UseVisualStyleBackColor = true;
            this.ButtonNuevo.Click += new System.EventHandler(this.ButtonNuevo_Click);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(668, 254);
            this.Controls.Add(this.ButtonNuevo);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroUsuario";
            this.Text = "Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboboxRoles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox ClaveTexbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texboxEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown idNumericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texboxAlias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texboxUsuario;
        private System.Windows.Forms.TextBox texboxNombre;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BottonBuscar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox CostoXHoraTexbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ConfirmarClaveTexbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonNuevo;
    }
}
