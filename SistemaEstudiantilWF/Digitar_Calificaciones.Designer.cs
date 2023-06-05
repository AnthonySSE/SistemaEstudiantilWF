namespace SistemaEstudiantilWF
{
    partial class Digitar_Calificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Digitar_Calificaciones));
            Barra_Seleccion = new Panel();
            btnCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            Panel = new Panel();
            btnCrear = new Button();
            btnActulizar = new Button();
            btnEliminar = new Button();
            btnReporte = new Button();
            btnSalir = new Button();
            btnDigitar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            buttonActualizar = new Button();
            buttonLimpiar = new Button();
            Barra_Seleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Barra_Seleccion
            // 
            Barra_Seleccion.BackColor = Color.RoyalBlue;
            Barra_Seleccion.Controls.Add(pictureBox1);
            Barra_Seleccion.Controls.Add(btnCerrar);
            Barra_Seleccion.Dock = DockStyle.Top;
            Barra_Seleccion.Location = new Point(0, 0);
            Barra_Seleccion.Name = "Barra_Seleccion";
            Barra_Seleccion.Size = new Size(1055, 37);
            Barra_Seleccion.TabIndex = 44;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.RoyalBlue;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1027, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 8;
            btnCerrar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1027, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Panel
            // 
            Panel.BackColor = Color.WhiteSmoke;
            Panel.Controls.Add(btnCrear);
            Panel.Controls.Add(btnActulizar);
            Panel.Controls.Add(btnEliminar);
            Panel.Controls.Add(btnReporte);
            Panel.Controls.Add(btnSalir);
            Panel.Controls.Add(btnDigitar);
            Panel.Dock = DockStyle.Left;
            Panel.Location = new Point(0, 37);
            Panel.Name = "Panel";
            Panel.Size = new Size(261, 449);
            Panel.TabIndex = 46;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.RoyalBlue;
            btnCrear.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(3, 23);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(248, 35);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear Estudiante";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActulizar
            // 
            btnActulizar.BackColor = Color.RoyalBlue;
            btnActulizar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActulizar.ForeColor = Color.White;
            btnActulizar.Location = new Point(3, 79);
            btnActulizar.Name = "btnActulizar";
            btnActulizar.Size = new Size(248, 35);
            btnActulizar.TabIndex = 15;
            btnActulizar.Text = "Actualizar Estudiante";
            btnActulizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RoyalBlue;
            btnEliminar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(3, 137);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(248, 35);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar Estudiante";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.RoyalBlue;
            btnReporte.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporte.ForeColor = Color.White;
            btnReporte.Location = new Point(3, 253);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(248, 35);
            btnReporte.TabIndex = 18;
            btnReporte.Text = "Reporte de Estidiante";
            btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RoyalBlue;
            btnSalir.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(12, 398);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(177, 30);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnDigitar
            // 
            btnDigitar.BackColor = Color.RoyalBlue;
            btnDigitar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDigitar.ForeColor = Color.White;
            btnDigitar.Location = new Point(3, 193);
            btnDigitar.Name = "btnDigitar";
            btnDigitar.Size = new Size(248, 35);
            btnDigitar.TabIndex = 17;
            btnDigitar.Text = "Digitar Calificaciones de Estudiante";
            btnDigitar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(306, 70);
            label1.Name = "label1";
            label1.Size = new Size(215, 19);
            label1.TabIndex = 47;
            label1.Text = "Ingrese la matrícula del estudiante.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 48;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 186);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "   Asignatura";
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(306, 164);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 49;
            label2.Text = "Asignatura 1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(527, 186);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "   Asignatura";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(527, 164);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 51;
            label3.Text = "Asignatura 2";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(748, 186);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "   Asignatura";
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(748, 164);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 53;
            label4.Text = "Asignatura 3";
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.RoyalBlue;
            buttonActualizar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonActualizar.ForeColor = Color.White;
            buttonActualizar.Location = new Point(293, 435);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(140, 30);
            buttonActualizar.TabIndex = 19;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.RoyalBlue;
            buttonLimpiar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimpiar.ForeColor = Color.White;
            buttonLimpiar.Location = new Point(835, 435);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(140, 30);
            buttonLimpiar.TabIndex = 55;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // Digitar_Calificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 486);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonActualizar);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Panel);
            Controls.Add(Barra_Seleccion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Digitar_Calificaciones";
            Text = "Digitar_Calificaciones";
            Barra_Seleccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Barra_Seleccion;
        private PictureBox btnCerrar;
        private PictureBox pictureBox1;
        private Panel Panel;
        private Button btnCrear;
        private Button btnActulizar;
        private Button btnEliminar;
        private Button btnReporte;
        private Button btnSalir;
        private Button btnDigitar;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button buttonActualizar;
        private Button buttonLimpiar;
    }
}