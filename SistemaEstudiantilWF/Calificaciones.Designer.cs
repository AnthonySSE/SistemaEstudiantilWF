namespace SistemaEstudiantilWF
{
    partial class Calificaciones
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
            btn_buscar = new Button();
            txt_Matricula = new TextBox();
            label1 = new Label();
            dgvCalificaciones = new DataGridView();
            button1 = new Button();
            txtHistoria = new TextBox();
            label2 = new Label();
            txtQuimica = new TextBox();
            txtFisica = new TextBox();
            txtMatemáticas = new TextBox();
            txtInglés = new TextBox();
            txtEspañol = new TextBox();
            txtGeografía = new TextBox();
            txtBiología = new TextBox();
            panel2 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.RoyalBlue;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Location = new Point(632, 514);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(122, 31);
            btn_buscar.TabIndex = 0;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(95, 514);
            txt_Matricula.Margin = new Padding(3, 4, 3, 4);
            txt_Matricula.MaxLength = 40;
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(498, 27);
            txt_Matricula.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 517);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 51;
            label1.Text = "Matricula";
            // 
            // dgvCalificaciones
            // 
            dgvCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificaciones.Location = new Point(14, 559);
            dgvCalificaciones.Margin = new Padding(3, 4, 3, 4);
            dgvCalificaciones.Name = "dgvCalificaciones";
            dgvCalificaciones.RowHeadersWidth = 51;
            dgvCalificaciones.RowTemplate.Height = 25;
            dgvCalificaciones.Size = new Size(1427, 352);
            dgvCalificaciones.TabIndex = 52;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(505, 372);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(384, 41);
            button1.TabIndex = 53;
            button1.Text = "Guardar Calificacion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtHistoria
            // 
            txtHistoria.BackColor = Color.FromArgb(230, 231, 233);
            txtHistoria.Location = new Point(29, 75);
            txtHistoria.Margin = new Padding(3, 4, 3, 4);
            txtHistoria.MaxLength = 5;
            txtHistoria.Name = "txtHistoria";
            txtHistoria.Size = new Size(173, 27);
            txtHistoria.TabIndex = 55;
            txtHistoria.TextChanged += txt_calificacion_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 51);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 56;
            label2.Text = "Historia";
            // 
            // txtQuimica
            // 
            txtQuimica.BackColor = Color.FromArgb(230, 231, 233);
            txtQuimica.Location = new Point(406, 71);
            txtQuimica.Margin = new Padding(3, 4, 3, 4);
            txtQuimica.MaxLength = 5;
            txtQuimica.Name = "txtQuimica";
            txtQuimica.Size = new Size(173, 27);
            txtQuimica.TabIndex = 57;
            // 
            // txtFisica
            // 
            txtFisica.BackColor = Color.FromArgb(230, 231, 233);
            txtFisica.Location = new Point(842, 75);
            txtFisica.Margin = new Padding(3, 4, 3, 4);
            txtFisica.MaxLength = 5;
            txtFisica.Name = "txtFisica";
            txtFisica.Size = new Size(173, 27);
            txtFisica.TabIndex = 58;
            // 
            // txtMatemáticas
            // 
            txtMatemáticas.BackColor = Color.FromArgb(230, 231, 233);
            txtMatemáticas.Location = new Point(1239, 75);
            txtMatemáticas.Margin = new Padding(3, 4, 3, 4);
            txtMatemáticas.MaxLength = 5;
            txtMatemáticas.Name = "txtMatemáticas";
            txtMatemáticas.Size = new Size(173, 27);
            txtMatemáticas.TabIndex = 59;
            // 
            // txtInglés
            // 
            txtInglés.BackColor = Color.FromArgb(230, 231, 233);
            txtInglés.Location = new Point(408, 256);
            txtInglés.Margin = new Padding(3, 4, 3, 4);
            txtInglés.MaxLength = 5;
            txtInglés.Name = "txtInglés";
            txtInglés.Size = new Size(173, 27);
            txtInglés.TabIndex = 60;
            // 
            // txtEspañol
            // 
            txtEspañol.BackColor = Color.FromArgb(230, 231, 233);
            txtEspañol.Location = new Point(29, 254);
            txtEspañol.Margin = new Padding(3, 4, 3, 4);
            txtEspañol.MaxLength = 5;
            txtEspañol.Name = "txtEspañol";
            txtEspañol.Size = new Size(173, 27);
            txtEspañol.TabIndex = 61;
            // 
            // txtGeografía
            // 
            txtGeografía.BackColor = Color.FromArgb(230, 231, 233);
            txtGeografía.Location = new Point(842, 278);
            txtGeografía.Margin = new Padding(3, 4, 3, 4);
            txtGeografía.MaxLength = 5;
            txtGeografía.Name = "txtGeografía";
            txtGeografía.Size = new Size(173, 27);
            txtGeografía.TabIndex = 62;
            // 
            // txtBiología
            // 
            txtBiología.BackColor = Color.FromArgb(230, 231, 233);
            txtBiología.Location = new Point(1239, 280);
            txtBiología.Margin = new Padding(3, 4, 3, 4);
            txtBiología.MaxLength = 5;
            txtBiología.Name = "txtBiología";
            txtBiología.Size = new Size(173, 27);
            txtBiología.TabIndex = 63;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtBiología);
            panel2.Controls.Add(txtHistoria);
            panel2.Controls.Add(txtGeografía);
            panel2.Controls.Add(txtQuimica);
            panel2.Controls.Add(txtEspañol);
            panel2.Controls.Add(txtFisica);
            panel2.Controls.Add(txtInglés);
            panel2.Controls.Add(txtMatemáticas);
            panel2.Location = new Point(14, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1427, 469);
            panel2.TabIndex = 65;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(1239, 256);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 71;
            label11.Text = "Biología";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(842, 254);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 70;
            label10.Text = "Geografía";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(29, 232);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 69;
            label9.Text = "Español";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(408, 232);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 68;
            label8.Text = "Inglés";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(1239, 51);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 67;
            label7.Text = "Matemáticas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(842, 51);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 66;
            label6.Text = "Fisica";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(408, 51);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 65;
            label5.Text = "Quimica";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(313, 20);
            label4.TabIndex = 64;
            label4.Text = "Calificaciones a ingresar segun corresponda";
            // 
            // Calificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1453, 923);
            Controls.Add(btn_buscar);
            Controls.Add(panel2);
            Controls.Add(txt_Matricula);
            Controls.Add(label1);
            Controls.Add(dgvCalificaciones);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Calificaciones";
            Text = "Calificaciones";
            Load += Calificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Matricula;
        private Button btn_buscar;
        private Label label1;
        private DataGridView dgvCalificaciones;
        private Button button1;
        private TextBox txtHistoria;
        private Label label2;
        private TextBox txtQuimica;
        private TextBox txtFisica;
        private TextBox txtMatemáticas;
        private TextBox txtInglés;
        private TextBox txtEspañol;
        private TextBox txtGeografía;
        private TextBox txtBiología;
        private Panel panel2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}