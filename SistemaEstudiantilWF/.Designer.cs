namespace SistemaEstudiantilWF
{
    partial class Reporte_Estudiantes_Profesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Estudiantes_Profesores));
            Barra_Seleccion = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrar = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnSalir = new Button();
            listView1 = new ListView();
            buttonBuscar = new Button();
            Barra_Seleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
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
            Barra_Seleccion.TabIndex = 45;
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
            // textBox1
            // 
            textBox1.Location = new Point(436, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(353, 88);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 49;
            label1.Text = "Matricula";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Listado General de Estudiantes", "Listado de Estudiantes Masculinos", "Listado de Estudiantes Femeninos", "Listado de Estudiantes Aprobados", "Listado de Estudiantes  Reprobados" });
            comboBox1.Location = new Point(34, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 23);
            comboBox1.TabIndex = 51;
            comboBox1.Text = "Seleccione eltipo de listado que desee";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RoyalBlue;
            btnSalir.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(12, 398);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(247, 30);
            btnSalir.TabIndex = 52;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(353, 134);
            listView1.Name = "listView1";
            listView1.Size = new Size(650, 318);
            listView1.TabIndex = 53;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.RoyalBlue;
            buttonBuscar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(708, 76);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(142, 31);
            buttonBuscar.TabIndex = 54;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // Reporte_Estudiantes_Profesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 486);
            Controls.Add(buttonBuscar);
            Controls.Add(listView1);
            Controls.Add(btnSalir);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Barra_Seleccion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reporte_Estudiantes_Profesores";
            Text = "Reporte_Estudiantes_Profesores";
            Barra_Seleccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Barra_Seleccion;
        private PictureBox pictureBox1;
        private PictureBox btnCerrar;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnSalir;
        private ListView listView1;
        private Button buttonBuscar;
    }
}