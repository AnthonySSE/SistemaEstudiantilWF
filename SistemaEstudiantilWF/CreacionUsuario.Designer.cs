namespace SistemaEstudiantilWF
{
    partial class CreacionUsuario
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
            btn_limpiar = new Button();
            btn_crearusuario = new Button();
            label1 = new Label();
            txt_id = new TextBox();
            label7 = new Label();
            txt_nombre = new TextBox();
            txt_IdUsuario = new TextBox();
            txt_apellido = new TextBox();
            txt_contraseña = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            cmb_rol = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(289, 445);
            btn_limpiar.Margin = new Padding(3, 4, 3, 4);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(205, 73);
            btn_limpiar.TabIndex = 54;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_crearusuario
            // 
            btn_crearusuario.Location = new Point(18, 445);
            btn_crearusuario.Margin = new Padding(3, 4, 3, 4);
            btn_crearusuario.Name = "btn_crearusuario";
            btn_crearusuario.Size = new Size(205, 73);
            btn_crearusuario.TabIndex = 55;
            btn_crearusuario.Text = "Crear Usuario";
            btn_crearusuario.UseVisualStyleBackColor = true;
            btn_crearusuario.Click += btn_crearusuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 12);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 57;
            label1.Text = "ID";
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.FromArgb(230, 231, 233);
            txt_id.Location = new Point(18, 44);
            txt_id.Margin = new Padding(3, 4, 3, 4);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(226, 27);
            txt_id.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(289, 12);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 59;
            label7.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FromArgb(230, 231, 233);
            txt_nombre.Location = new Point(289, 43);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.MaxLength = 30;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(226, 27);
            txt_nombre.TabIndex = 58;
            // 
            // txt_IdUsuario
            // 
            txt_IdUsuario.BackColor = Color.FromArgb(230, 231, 233);
            txt_IdUsuario.Location = new Point(289, 164);
            txt_IdUsuario.Margin = new Padding(3, 4, 3, 4);
            txt_IdUsuario.MaxLength = 15;
            txt_IdUsuario.Name = "txt_IdUsuario";
            txt_IdUsuario.Size = new Size(226, 27);
            txt_IdUsuario.TabIndex = 61;
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.FromArgb(230, 231, 233);
            txt_apellido.Location = new Point(18, 165);
            txt_apellido.Margin = new Padding(3, 4, 3, 4);
            txt_apellido.MaxLength = 30;
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(226, 27);
            txt_apellido.TabIndex = 60;
            // 
            // txt_contraseña
            // 
            txt_contraseña.BackColor = Color.FromArgb(230, 231, 233);
            txt_contraseña.Location = new Point(18, 295);
            txt_contraseña.Margin = new Padding(3, 4, 3, 4);
            txt_contraseña.MaxLength = 64;
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.PasswordChar = '*';
            txt_contraseña.Size = new Size(226, 27);
            txt_contraseña.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(328, 124);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 65;
            label2.Text = "IdUsuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(71, 124);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 64;
            label3.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(71, 256);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 66;
            label5.Text = "Contraseña";
            // 
            // cmb_rol
            // 
            cmb_rol.FormattingEnabled = true;
            cmb_rol.Items.AddRange(new object[] { "Administrador", "Maestro", "Estudiante" });
            cmb_rol.Location = new Point(328, 295);
            cmb_rol.Margin = new Padding(3, 4, 3, 4);
            cmb_rol.Name = "cmb_rol";
            cmb_rol.Size = new Size(142, 28);
            cmb_rol.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(357, 256);
            label8.Name = "label8";
            label8.Size = new Size(32, 20);
            label8.TabIndex = 67;
            label8.Text = "Rol";
            // 
            // button1
            // 
            button1.Location = new Point(541, 517);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 87);
            button1.TabIndex = 69;
            button1.Text = "Eliminar Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreacionUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(699, 604);
            Controls.Add(button1);
            Controls.Add(cmb_rol);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txt_contraseña);
            Controls.Add(txt_IdUsuario);
            Controls.Add(txt_apellido);
            Controls.Add(label7);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(txt_id);
            Controls.Add(btn_crearusuario);
            Controls.Add(btn_limpiar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreacionUsuario";
            Text = "Form4";
            Load += CreacionUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_limpiar;
        private Button btn_crearusuario;
        private Label label1;
        private TextBox txt_id;
        private Label label7;
        private TextBox txt_nombre;
        private TextBox txt_IdUsuario;
        private TextBox txt_apellido;
        private TextBox txt_contraseña;
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox cmb_rol;
        private Label label8;
        private Button button1;
    }
}