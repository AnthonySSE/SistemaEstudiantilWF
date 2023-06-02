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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHistoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuimica = new System.Windows.Forms.TextBox();
            this.txtFisica = new System.Windows.Forms.TextBox();
            this.txtMatemáticas = new System.Windows.Forms.TextBox();
            this.txtInglés = new System.Windows.Forms.TextBox();
            this.txtEspañol = new System.Windows.Forms.TextBox();
            this.txtGeografía = new System.Windows.Forms.TextBox();
            this.txtBiología = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(173, 109);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(107, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(28, 110);
            this.txt_Matricula.MaxLength = 40;
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(129, 23);
            this.txt_Matricula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Matricula";
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.Location = new System.Drawing.Point(12, 419);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.RowTemplate.Height = 25;
            this.dgvCalificaciones.Size = new System.Drawing.Size(240, 264);
            this.dgvCalificaciones.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 64);
            this.button1.TabIndex = 53;
            this.button1.Text = "Guardar Calificacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHistoria
            // 
            this.txtHistoria.Location = new System.Drawing.Point(25, 56);
            this.txtHistoria.MaxLength = 5;
            this.txtHistoria.Name = "txtHistoria";
            this.txtHistoria.Size = new System.Drawing.Size(152, 23);
            this.txtHistoria.TabIndex = 55;
            this.txtHistoria.TextChanged += new System.EventHandler(this.txt_calificacion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Historia";
            // 
            // txtQuimica
            // 
            this.txtQuimica.Location = new System.Drawing.Point(25, 97);
            this.txtQuimica.MaxLength = 5;
            this.txtQuimica.Name = "txtQuimica";
            this.txtQuimica.Size = new System.Drawing.Size(152, 23);
            this.txtQuimica.TabIndex = 57;
            // 
            // txtFisica
            // 
            this.txtFisica.Location = new System.Drawing.Point(25, 141);
            this.txtFisica.MaxLength = 5;
            this.txtFisica.Name = "txtFisica";
            this.txtFisica.Size = new System.Drawing.Size(152, 23);
            this.txtFisica.TabIndex = 58;
            // 
            // txtMatemáticas
            // 
            this.txtMatemáticas.Location = new System.Drawing.Point(25, 183);
            this.txtMatemáticas.MaxLength = 5;
            this.txtMatemáticas.Name = "txtMatemáticas";
            this.txtMatemáticas.Size = new System.Drawing.Size(152, 23);
            this.txtMatemáticas.TabIndex = 59;
            // 
            // txtInglés
            // 
            this.txtInglés.Location = new System.Drawing.Point(210, 56);
            this.txtInglés.MaxLength = 5;
            this.txtInglés.Name = "txtInglés";
            this.txtInglés.Size = new System.Drawing.Size(152, 23);
            this.txtInglés.TabIndex = 60;
            // 
            // txtEspañol
            // 
            this.txtEspañol.Location = new System.Drawing.Point(210, 97);
            this.txtEspañol.MaxLength = 5;
            this.txtEspañol.Name = "txtEspañol";
            this.txtEspañol.Size = new System.Drawing.Size(152, 23);
            this.txtEspañol.TabIndex = 61;
            // 
            // txtGeografía
            // 
            this.txtGeografía.Location = new System.Drawing.Point(210, 141);
            this.txtGeografía.MaxLength = 5;
            this.txtGeografía.Name = "txtGeografía";
            this.txtGeografía.Size = new System.Drawing.Size(152, 23);
            this.txtGeografía.TabIndex = 62;
            // 
            // txtBiología
            // 
            this.txtBiología.Location = new System.Drawing.Point(210, 183);
            this.txtBiología.MaxLength = 5;
            this.txtBiología.Name = "txtBiología";
            this.txtBiología.Size = new System.Drawing.Size(152, 23);
            this.txtBiología.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.txt_Matricula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(423, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 191);
            this.panel1.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Busqueda de Matricula";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtBiología);
            this.panel2.Controls.Add(this.txtHistoria);
            this.panel2.Controls.Add(this.txtGeografía);
            this.panel2.Controls.Add(this.txtQuimica);
            this.panel2.Controls.Add(this.txtEspañol);
            this.panel2.Controls.Add(this.txtFisica);
            this.panel2.Controls.Add(this.txtInglés);
            this.panel2.Controls.Add(this.txtMatemáticas);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 352);
            this.panel2.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(210, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 71;
            this.label11.Text = "Biología";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(210, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 70;
            this.label10.Text = "Geografía";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(210, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 69;
            this.label9.Text = "Español";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(210, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 68;
            this.label8.Text = "Inglés";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 67;
            this.label7.Text = "Matemáticas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "Fisica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 65;
            this.label5.Text = "Quimica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 15);
            this.label4.TabIndex = 64;
            this.label4.Text = "Calificaciones a ingresar segun corresponda";
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCalificaciones);
            this.Name = "Calificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Calificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel panel1;
        private Label label3;
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