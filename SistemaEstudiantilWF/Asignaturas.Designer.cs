namespace SistemaEstudiantilWF
{
    partial class Asignaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asignaturas));
            this.btn_asignar = new System.Windows.Forms.Button();
            this.cmb_asignaturas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matriculaestudiante = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_asignar
            // 
            this.btn_asignar.Location = new System.Drawing.Point(756, 28);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(158, 73);
            this.btn_asignar.TabIndex = 0;
            this.btn_asignar.Text = "Asignar";
            this.btn_asignar.UseVisualStyleBackColor = true;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // cmb_asignaturas
            // 
            this.cmb_asignaturas.FormattingEnabled = true;
            this.cmb_asignaturas.Location = new System.Drawing.Point(8, 57);
            this.cmb_asignaturas.Name = "cmb_asignaturas";
            this.cmb_asignaturas.Size = new System.Drawing.Size(244, 23);
            this.cmb_asignaturas.TabIndex = 1;
            this.cmb_asignaturas.SelectedIndexChanged += new System.EventHandler(this.cmb_asignaturas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(78, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Asignaturas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(470, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ingresar Matricula";
            // 
            // txt_matriculaestudiante
            // 
            this.txt_matriculaestudiante.Location = new System.Drawing.Point(447, 57);
            this.txt_matriculaestudiante.MaxLength = 40;
            this.txt_matriculaestudiante.Name = "txt_matriculaestudiante";
            this.txt_matriculaestudiante.Size = new System.Drawing.Size(198, 23);
            this.txt_matriculaestudiante.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(2, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 460);
            this.panel1.TabIndex = 52;
            // 
            // Asignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1125, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_matriculaestudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_asignaturas);
            this.Controls.Add(this.btn_asignar);
            this.Name = "Asignaturas";
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.Asignaturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_asignar;
        private ComboBox cmb_asignaturas;
        private Label label7;
        private Label label1;
        private TextBox txt_matriculaestudiante;
        private Panel panel1;
    }
}