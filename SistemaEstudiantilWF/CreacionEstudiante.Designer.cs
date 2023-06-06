namespace SistemaEstudiantilWF
{
    partial class CreacionEstudiante
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
            components = new System.ComponentModel.Container();
            btn_CrearEstudiante = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_cantidadmaterias = new TextBox();
            txt_nombre = new TextBox();
            txt_curso = new TextBox();
            txt_edad = new TextBox();
            txt_matricula = new TextBox();
            txt_apellido = new TextBox();
            txt_id = new TextBox();
            dtp_fechanacimiento = new DateTimePicker();
            txt_usuarioid = new TextBox();
            label10 = new Label();
            btn_limpiar = new Button();
            cmb_sexo = new ComboBox();
            btn_actualizar = new Button();
            btn_eliminar = new Button();
            txt_buscar = new TextBox();
            cmb_buscar = new ComboBox();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            btn_mostrar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btn_CrearEstudiante
            // 
            btn_CrearEstudiante.BackColor = Color.RoyalBlue;
            btn_CrearEstudiante.FlatStyle = FlatStyle.Flat;
            btn_CrearEstudiante.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CrearEstudiante.ForeColor = Color.White;
            btn_CrearEstudiante.Location = new Point(152, 410);
            btn_CrearEstudiante.Margin = new Padding(3, 4, 3, 4);
            btn_CrearEstudiante.Name = "btn_CrearEstudiante";
            btn_CrearEstudiante.Size = new Size(186, 44);
            btn_CrearEstudiante.TabIndex = 0;
            btn_CrearEstudiante.Text = "Crear";
            btn_CrearEstudiante.UseVisualStyleBackColor = false;
            btn_CrearEstudiante.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(18, 251);
            label9.Name = "label9";
            label9.Size = new Size(157, 20);
            label9.TabIndex = 49;
            label9.Text = "Cantidad de Materias";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(359, 137);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 48;
            label8.Text = "Sexo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(699, 13);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 47;
            label7.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1086, 137);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 46;
            label6.Text = "Curso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(18, 137);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 45;
            label5.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(359, 12);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 44;
            label4.Text = "Matricula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(699, 137);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 43;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1086, 13);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 42;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 41;
            label1.Text = "ID";
            // 
            // txt_cantidadmaterias
            // 
            txt_cantidadmaterias.BackColor = Color.FromArgb(230, 231, 233);
            txt_cantidadmaterias.Location = new Point(18, 283);
            txt_cantidadmaterias.Margin = new Padding(3, 4, 3, 4);
            txt_cantidadmaterias.MaxLength = 2;
            txt_cantidadmaterias.Name = "txt_cantidadmaterias";
            txt_cantidadmaterias.Size = new Size(226, 27);
            txt_cantidadmaterias.TabIndex = 40;
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FromArgb(230, 231, 233);
            txt_nombre.Location = new Point(699, 44);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.MaxLength = 30;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(226, 27);
            txt_nombre.TabIndex = 38;
            // 
            // txt_curso
            // 
            txt_curso.BackColor = Color.FromArgb(230, 231, 233);
            txt_curso.Location = new Point(1086, 169);
            txt_curso.Margin = new Padding(3, 4, 3, 4);
            txt_curso.MaxLength = 25;
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(226, 27);
            txt_curso.TabIndex = 37;
            // 
            // txt_edad
            // 
            txt_edad.BackColor = Color.FromArgb(230, 231, 233);
            txt_edad.Location = new Point(18, 161);
            txt_edad.Margin = new Padding(3, 4, 3, 4);
            txt_edad.MaxLength = 3;
            txt_edad.Name = "txt_edad";
            txt_edad.Size = new Size(226, 27);
            txt_edad.TabIndex = 36;
            // 
            // txt_matricula
            // 
            txt_matricula.BackColor = Color.FromArgb(230, 231, 233);
            txt_matricula.Location = new Point(359, 44);
            txt_matricula.Margin = new Padding(3, 4, 3, 4);
            txt_matricula.MaxLength = 15;
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(226, 27);
            txt_matricula.TabIndex = 35;
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.FromArgb(230, 231, 233);
            txt_apellido.Location = new Point(1086, 37);
            txt_apellido.Margin = new Padding(3, 4, 3, 4);
            txt_apellido.MaxLength = 30;
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(226, 27);
            txt_apellido.TabIndex = 33;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.FromArgb(230, 231, 233);
            txt_id.Location = new Point(11, 44);
            txt_id.Margin = new Padding(3, 4, 3, 4);
            txt_id.MaxLength = 3;
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(226, 27);
            txt_id.TabIndex = 32;
            // 
            // dtp_fechanacimiento
            // 
            dtp_fechanacimiento.Location = new Point(699, 173);
            dtp_fechanacimiento.Margin = new Padding(3, 4, 3, 4);
            dtp_fechanacimiento.Name = "dtp_fechanacimiento";
            dtp_fechanacimiento.Size = new Size(223, 27);
            dtp_fechanacimiento.TabIndex = 50;
            // 
            // txt_usuarioid
            // 
            txt_usuarioid.BackColor = Color.FromArgb(230, 231, 233);
            txt_usuarioid.Location = new Point(345, 287);
            txt_usuarioid.Margin = new Padding(3, 4, 3, 4);
            txt_usuarioid.MaxLength = 15;
            txt_usuarioid.Name = "txt_usuarioid";
            txt_usuarioid.Size = new Size(226, 27);
            txt_usuarioid.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(359, 251);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 52;
            label10.Text = "Usuario ID";
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.RoyalBlue;
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(981, 410);
            btn_limpiar.Margin = new Padding(3, 4, 3, 4);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(186, 44);
            btn_limpiar.TabIndex = 53;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // cmb_sexo
            // 
            cmb_sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_sexo.FormattingEnabled = true;
            cmb_sexo.Items.AddRange(new object[] { "M", "F" });
            cmb_sexo.Location = new Point(359, 161);
            cmb_sexo.Margin = new Padding(3, 4, 3, 4);
            cmb_sexo.Name = "cmb_sexo";
            cmb_sexo.Size = new Size(226, 28);
            cmb_sexo.TabIndex = 54;
            cmb_sexo.SelectedIndexChanged += cmb_sexo_SelectedIndexChanged;
            // 
            // btn_actualizar
            // 
            btn_actualizar.BackColor = Color.RoyalBlue;
            btn_actualizar.FlatStyle = FlatStyle.Flat;
            btn_actualizar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_actualizar.ForeColor = Color.White;
            btn_actualizar.Location = new Point(432, 410);
            btn_actualizar.Margin = new Padding(3, 4, 3, 4);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(186, 44);
            btn_actualizar.TabIndex = 55;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = false;
            btn_actualizar.Click += button1_Click_1;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.RoyalBlue;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(699, 410);
            btn_eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(186, 44);
            btn_eliminar.TabIndex = 56;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(163, 551);
            txt_buscar.Margin = new Padding(3, 4, 3, 4);
            txt_buscar.MaxLength = 50;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(271, 27);
            txt_buscar.TabIndex = 58;
            txt_buscar.TextChanged += textBox1_TextChanged;
            // 
            // cmb_buscar
            // 
            cmb_buscar.FormattingEnabled = true;
            cmb_buscar.Items.AddRange(new object[] { "Matricula", "Nombre", "Apellidos", "UsuarioId" });
            cmb_buscar.Location = new Point(470, 551);
            cmb_buscar.Margin = new Padding(3, 4, 3, 4);
            cmb_buscar.Name = "cmb_buscar";
            cmb_buscar.Size = new Size(303, 28);
            cmb_buscar.TabIndex = 59;
            cmb_buscar.Text = "Matricula";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(14, 554);
            label11.Name = "label11";
            label11.Size = new Size(134, 20);
            label11.TabIndex = 60;
            label11.Text = "Buscar Estudiante";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 630);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1432, 227);
            dataGridView1.TabIndex = 61;
            // 
            // btn_mostrar
            // 
            btn_mostrar.BackColor = Color.RoyalBlue;
            btn_mostrar.FlatStyle = FlatStyle.Flat;
            btn_mostrar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mostrar.ForeColor = Color.White;
            btn_mostrar.Location = new Point(11, 900);
            btn_mostrar.Margin = new Padding(3, 4, 3, 4);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(186, 47);
            btn_mostrar.TabIndex = 62;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = false;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // CreacionEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1511, 960);
            Controls.Add(btn_mostrar);
            Controls.Add(dataGridView1);
            Controls.Add(label11);
            Controls.Add(cmb_buscar);
            Controls.Add(txt_buscar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_actualizar);
            Controls.Add(cmb_sexo);
            Controls.Add(btn_limpiar);
            Controls.Add(label10);
            Controls.Add(txt_usuarioid);
            Controls.Add(dtp_fechanacimiento);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_cantidadmaterias);
            Controls.Add(txt_nombre);
            Controls.Add(txt_curso);
            Controls.Add(txt_edad);
            Controls.Add(txt_matricula);
            Controls.Add(txt_apellido);
            Controls.Add(txt_id);
            Controls.Add(btn_CrearEstudiante);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreacionEstudiante";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CrearEstudiante;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_cantidadmaterias;
        private TextBox txt_nombre;
        private TextBox txt_curso;
        private TextBox txt_edad;
        private TextBox txt_matricula;
        private TextBox txt_apellido;
        private TextBox txt_id;
        private DateTimePicker dtp_fechanacimiento;
        private TextBox txt_usuarioid;
        private Label label10;
        private Button btn_limpiar;
        private ComboBox cmb_sexo;
        private Button btn_actualizar;
        private Button btn_eliminar;
        private TextBox txt_buscar;
        private ComboBox cmb_buscar;
        private Label label11;
        private DataGridView dataGridView1;
        private Button btn_mostrar;
        private ErrorProvider errorProvider;
    }
}