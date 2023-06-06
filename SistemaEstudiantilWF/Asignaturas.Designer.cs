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
            btn_asignar = new Button();
            cmb_asignaturas = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            txt_matriculaestudiante = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btn_asignar
            // 
            btn_asignar.BackColor = Color.RoyalBlue;
            btn_asignar.FlatStyle = FlatStyle.Flat;
            btn_asignar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_asignar.ForeColor = Color.White;
            btn_asignar.Location = new Point(867, 238);
            btn_asignar.Margin = new Padding(3, 4, 3, 4);
            btn_asignar.Name = "btn_asignar";
            btn_asignar.Size = new Size(539, 39);
            btn_asignar.TabIndex = 0;
            btn_asignar.Text = "Asignar";
            btn_asignar.UseVisualStyleBackColor = false;
            btn_asignar.Click += btn_asignar_Click;
            // 
            // cmb_asignaturas
            // 
            cmb_asignaturas.BackColor = Color.FromArgb(230, 231, 233);
            cmb_asignaturas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_asignaturas.FormattingEnabled = true;
            cmb_asignaturas.Location = new Point(15, 249);
            cmb_asignaturas.Margin = new Padding(3, 4, 3, 4);
            cmb_asignaturas.Name = "cmb_asignaturas";
            cmb_asignaturas.Size = new Size(371, 28);
            cmb_asignaturas.TabIndex = 1;
            cmb_asignaturas.SelectedIndexChanged += cmb_asignaturas_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 211);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 48;
            label7.Text = "Asignaturas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(421, 211);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 50;
            label1.Text = "Ingresar Matricula";
            // 
            // txt_matriculaestudiante
            // 
            txt_matriculaestudiante.BackColor = Color.FromArgb(230, 231, 233);
            txt_matriculaestudiante.Location = new Point(421, 250);
            txt_matriculaestudiante.Margin = new Padding(3, 4, 3, 4);
            txt_matriculaestudiante.MaxLength = 40;
            txt_matriculaestudiante.Name = "txt_matriculaestudiante";
            txt_matriculaestudiante.Size = new Size(371, 27);
            txt_matriculaestudiante.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(604, 443);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 202);
            panel1.TabIndex = 52;
            // 
            // Asignaturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1438, 853);
            Controls.Add(panel1);
            Controls.Add(txt_matriculaestudiante);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(cmb_asignaturas);
            Controls.Add(btn_asignar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Asignaturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignaturas";
            Load += Asignaturas_Load;
            ResumeLayout(false);
            PerformLayout();
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