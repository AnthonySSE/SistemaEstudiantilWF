namespace ModernGUI_V3
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelContenedor = new Panel();
            panelformularios = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            btn_menu5 = new Button();
            btn_menu4 = new Button();
            btn_menu8 = new Button();
            btn_menu3 = new Button();
            btn_menu2 = new Button();
            btn_menu1 = new Button();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelContenedor.SuspendLayout();
            panelformularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(panelformularios);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Controls.Add(panelBarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(2, 3, 2, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1811, 1102);
            panelContenedor.TabIndex = 0;
            // 
            // panelformularios
            // 
            panelformularios.BackColor = SystemColors.Control;
            panelformularios.Controls.Add(pictureBox1);
            panelformularios.Dock = DockStyle.Fill;
            panelformularios.Location = new Point(250, 49);
            panelformularios.Margin = new Padding(2, 3, 2, 3);
            panelformularios.Name = "panelformularios";
            panelformularios.Size = new Size(1561, 1053);
            panelformularios.TabIndex = 2;
            panelformularios.Paint += panelformularios_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1561, 1050);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(4, 41, 68);
            panelMenu.Controls.Add(btn_menu5);
            panelMenu.Controls.Add(btn_menu4);
            panelMenu.Controls.Add(btn_menu8);
            panelMenu.Controls.Add(btn_menu3);
            panelMenu.Controls.Add(btn_menu2);
            panelMenu.Controls.Add(btn_menu1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 49);
            panelMenu.Margin = new Padding(2, 3, 2, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 1053);
            panelMenu.TabIndex = 1;
            // 
            // btn_menu5
            // 
            btn_menu5.FlatAppearance.BorderSize = 0;
            btn_menu5.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btn_menu5.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btn_menu5.FlatStyle = FlatStyle.Flat;
            btn_menu5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_menu5.ForeColor = Color.Gainsboro;
            btn_menu5.Image = (Image)resources.GetObject("btn_menu5.Image");
            btn_menu5.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menu5.Location = new Point(2, 440);
            btn_menu5.Margin = new Padding(2, 3, 2, 3);
            btn_menu5.Name = "btn_menu5";
            btn_menu5.Size = new Size(250, 61);
            btn_menu5.TabIndex = 5;
            btn_menu5.Text = "Asignar Calificaciones";
            btn_menu5.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_menu5.UseVisualStyleBackColor = true;
            btn_menu5.Click += btn_menu5_Click;
            // 
            // btn_menu4
            // 
            btn_menu4.FlatAppearance.BorderSize = 0;
            btn_menu4.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btn_menu4.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btn_menu4.FlatStyle = FlatStyle.Flat;
            btn_menu4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_menu4.ForeColor = Color.Gainsboro;
            btn_menu4.Image = (Image)resources.GetObject("btn_menu4.Image");
            btn_menu4.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menu4.Location = new Point(2, 363);
            btn_menu4.Margin = new Padding(2, 3, 2, 3);
            btn_menu4.Name = "btn_menu4";
            btn_menu4.Size = new Size(250, 61);
            btn_menu4.TabIndex = 4;
            btn_menu4.Text = "Asignar asignaturas";
            btn_menu4.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_menu4.UseVisualStyleBackColor = true;
            btn_menu4.Click += button1_Click_1;
            // 
            // btn_menu8
            // 
            btn_menu8.FlatAppearance.BorderSize = 0;
            btn_menu8.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btn_menu8.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btn_menu8.FlatStyle = FlatStyle.Flat;
            btn_menu8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_menu8.ForeColor = Color.Gainsboro;
            btn_menu8.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menu8.Location = new Point(-5, 713);
            btn_menu8.Margin = new Padding(2, 3, 2, 3);
            btn_menu8.Name = "btn_menu8";
            btn_menu8.Size = new Size(250, 61);
            btn_menu8.TabIndex = 3;
            btn_menu8.Text = "Salir del sistema";
            btn_menu8.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_menu8.UseVisualStyleBackColor = true;
            btn_menu8.Click += button4_Click;
            // 
            // btn_menu3
            // 
            btn_menu3.FlatAppearance.BorderSize = 0;
            btn_menu3.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btn_menu3.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btn_menu3.FlatStyle = FlatStyle.Flat;
            btn_menu3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_menu3.ForeColor = Color.Gainsboro;
            btn_menu3.Image = (Image)resources.GetObject("btn_menu3.Image");
            btn_menu3.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menu3.Location = new Point(2, 288);
            btn_menu3.Margin = new Padding(2, 3, 2, 3);
            btn_menu3.Name = "btn_menu3";
            btn_menu3.Size = new Size(250, 61);
            btn_menu3.TabIndex = 2;
            btn_menu3.Text = "Creacion de usuario";
            btn_menu3.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_menu3.UseVisualStyleBackColor = true;
            btn_menu3.Click += button3_Click;
            // 
            // btn_menu2
            // 
            btn_menu2.FlatAppearance.BorderSize = 0;
            btn_menu2.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btn_menu2.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btn_menu2.FlatStyle = FlatStyle.Flat;
            btn_menu2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_menu2.ForeColor = Color.Gainsboro;
            btn_menu2.Image = (Image)resources.GetObject("btn_menu2.Image");
            btn_menu2.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menu2.Location = new Point(2, 220);
            btn_menu2.Margin = new Padding(2, 3, 2, 3);
            btn_menu2.Name = "btn_menu2";
            btn_menu2.Size = new Size(250, 61);
            btn_menu2.TabIndex = 1;
            btn_menu2.Text = "Creacion de Estudiantes";
            btn_menu2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_menu2.UseVisualStyleBackColor = true;
            btn_menu2.Click += button2_Click;
            // 
            // btn_menu1
            // 
            btn_menu1.FlatAppearance.BorderSize = 0;
            btn_menu1.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btn_menu1.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btn_menu1.FlatStyle = FlatStyle.Flat;
            btn_menu1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_menu1.ForeColor = Color.Gainsboro;
            btn_menu1.Image = (Image)resources.GetObject("btn_menu1.Image");
            btn_menu1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menu1.Location = new Point(0, 152);
            btn_menu1.Margin = new Padding(2, 3, 2, 3);
            btn_menu1.Name = "btn_menu1";
            btn_menu1.Size = new Size(250, 61);
            btn_menu1.TabIndex = 0;
            btn_menu1.Text = "Reportes de Estudiantes";
            btn_menu1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_menu1.UseVisualStyleBackColor = true;
            btn_menu1.Click += button1_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            panelBarraTitulo.Controls.Add(btnRestaurar);
            panelBarraTitulo.Controls.Add(btnMinimizar);
            panelBarraTitulo.Controls.Add(btnMaximizar);
            panelBarraTitulo.Controls.Add(btnCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Margin = new Padding(2, 3, 2, 3);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1811, 49);
            panelBarraTitulo.TabIndex = 0;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1761, 13);
            btnRestaurar.Margin = new Padding(2, 3, 2, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(16, 20);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1739, 13);
            btnMinimizar.Margin = new Padding(2, 3, 2, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(16, 20);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1761, 13);
            btnMaximizar.Margin = new Padding(2, 3, 2, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(16, 20);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1783, 13);
            btnCerrar.Margin = new Padding(2, 3, 2, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(16, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1811, 1102);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(650, 500);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormPrincipal_Load;
            panelContenedor.ResumeLayout(false);
            panelformularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelformularios;
        private Panel panelMenu;
        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private Button btn_menu3;
        private Button btn_menu2;
        private Button btn_menu1;
        private PictureBox pictureBox1;
        private Button btn_menu8;
        private Button btn_menu5;
        private Button btn_menu4;
    }
}

