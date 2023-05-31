namespace SistemaEstudiantilWF
{
    partial class Inicio_Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sesion));
            label2 = new Label();
            txtIdUsuario = new TextBox();
            label3 = new Label();
            txtContrasena = new TextBox();
            btnAcceder = new Button();
            label4 = new Label();
            label1 = new Label();
            btnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 96);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.BackColor = Color.FromArgb(230, 231, 233);
            txtIdUsuario.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(38, 119);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(256, 29);
            txtIdUsuario.TabIndex = 2;
            txtIdUsuario.TextChanged += txtIdUsuario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(38, 166);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.FromArgb(230, 231, 233);
            txtContrasena.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(38, 189);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(256, 29);
            txtContrasena.TabIndex = 4;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.RoyalBlue;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(72, 241);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(198, 44);
            btnAcceder.TabIndex = 5;
            btnAcceder.Text = "Iniciar Sesión";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += button1_Click;
            // 
            // label4
            // 
            label4.Location = new Point(14, 314);
            label4.Name = "label4";
            label4.Size = new Size(281, 61);
            label4.TabIndex = 6;
            label4.Text = "Si no puede iniciar sesión, contacte al administrador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(171, 22);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesión";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(297, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 7;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Inicio_Sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(325, 404);
            Controls.Add(btnCerrar);
            Controls.Add(label4);
            Controls.Add(btnAcceder);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(txtIdUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio_Sesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtIdUsuario;
        private Label label3;
        private TextBox txtContrasena;
        private Button btnAcceder;
        private Label label4;
        private Label label1;
        private PictureBox btnCerrar;
    }
}