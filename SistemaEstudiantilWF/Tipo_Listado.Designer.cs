namespace SistemaEstudiantilWF
{
    partial class Tipo_Listado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipo_Listado));
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnBuscarSeleccion = new Button();
            btnSalirSeleccion = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Barra_Seleccion = new Panel();
            btnCerrar = new PictureBox();
            Panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Barra_Seleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Listado General de Estudiantes", "Listado de Estudiantes Masculinos", "Listado de Estudiantes Femeninos", "Listado de Estudiantes Aprobados", "Listado de Estudiantes Reprobados" });
            comboBox1.Location = new Point(12, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Seleccione el tipo que desea";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.Location = new Point(483, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscarSeleccion
            // 
            btnBuscarSeleccion.BackColor = Color.RoyalBlue;
            btnBuscarSeleccion.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarSeleccion.ForeColor = Color.White;
            btnBuscarSeleccion.Location = new Point(723, 72);
            btnBuscarSeleccion.Name = "btnBuscarSeleccion";
            btnBuscarSeleccion.Size = new Size(91, 26);
            btnBuscarSeleccion.TabIndex = 3;
            btnBuscarSeleccion.Text = "Buscar";
            btnBuscarSeleccion.UseVisualStyleBackColor = false;
            btnBuscarSeleccion.Click += button1_Click;
            // 
            // btnSalirSeleccion
            // 
            btnSalirSeleccion.BackColor = Color.RoyalBlue;
            btnSalirSeleccion.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalirSeleccion.ForeColor = Color.White;
            btnSalirSeleccion.Location = new Point(9, 397);
            btnSalirSeleccion.Name = "btnSalirSeleccion";
            btnSalirSeleccion.Size = new Size(213, 40);
            btnSalirSeleccion.TabIndex = 4;
            btnSalirSeleccion.Text = "Salir";
            btnSalirSeleccion.UseVisualStyleBackColor = false;
            btnSalirSeleccion.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(230, 231, 233);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(703, 321);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(418, 75);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 41;
            label1.Text = "Matricula";
            // 
            // Barra_Seleccion
            // 
            Barra_Seleccion.BackColor = Color.RoyalBlue;
            Barra_Seleccion.Controls.Add(btnCerrar);
            Barra_Seleccion.Dock = DockStyle.Top;
            Barra_Seleccion.Location = new Point(0, 0);
            Barra_Seleccion.Name = "Barra_Seleccion";
            Barra_Seleccion.Size = new Size(1055, 37);
            Barra_Seleccion.TabIndex = 43;
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
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Panel
            // 
            Panel.BackColor = Color.WhiteSmoke;
            Panel.Controls.Add(comboBox1);
            Panel.Controls.Add(btnSalirSeleccion);
            Panel.Dock = DockStyle.Left;
            Panel.Location = new Point(0, 37);
            Panel.Name = "Panel";
            Panel.Size = new Size(261, 449);
            Panel.TabIndex = 44;
            // 
            // Tipo_Listado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 486);
            Controls.Add(Panel);
            Controls.Add(Barra_Seleccion);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscarSeleccion);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tipo_Listado";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Barra_Seleccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            Panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnBuscarSeleccion;
        private Button btnSalirSeleccion;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel Barra_Seleccion;
        private Panel Panel;
        private PictureBox btnCerrar;
    }
}