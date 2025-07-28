namespace CasaRobot.UI
{
    partial class FrmBuscarEquipos
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
            panelIniciar = new Panel();
            btnBuscar = new Button();
            dgvEquipos = new DataGridView();
            btnCancelar = new Button();
            txtNumeroSerie = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            cbxCliente = new ComboBox();
            btnBuscarEquipos = new FontAwesome.Sharp.IconButton();
            textIngresarUsuario = new TextBox();
            btnGuardar = new Button();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            btnnousar = new Button();
            BtnEntrarUsuario = new Button();
            txtUsuario = new TextBox();
            iconUsuario = new FontAwesome.Sharp.IconPictureBox();
            panelIniciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).BeginInit();
            SuspendLayout();
            // 
            // panelIniciar
            // 
            panelIniciar.Anchor = AnchorStyles.None;
            panelIniciar.BackColor = Color.White;
            panelIniciar.BackgroundImageLayout = ImageLayout.None;
            panelIniciar.Controls.Add(btnBuscar);
            panelIniciar.Controls.Add(dgvEquipos);
            panelIniciar.Controls.Add(btnCancelar);
            panelIniciar.Controls.Add(txtNumeroSerie);
            panelIniciar.Controls.Add(txtModelo);
            panelIniciar.Controls.Add(txtMarca);
            panelIniciar.Controls.Add(textBox4);
            panelIniciar.Controls.Add(textBox3);
            panelIniciar.Controls.Add(textBox2);
            panelIniciar.Controls.Add(cbxCliente);
            panelIniciar.Controls.Add(btnBuscarEquipos);
            panelIniciar.Controls.Add(textIngresarUsuario);
            panelIniciar.Controls.Add(btnGuardar);
            panelIniciar.Location = new Point(64, 95);
            panelIniciar.Margin = new Padding(4, 5, 4, 5);
            panelIniciar.Name = "panelIniciar";
            panelIniciar.Size = new Size(1217, 884);
            panelIniciar.TabIndex = 13;
            panelIniciar.Paint += panelIniciar_Paint;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.MidnightBlue;
            btnBuscar.Location = new Point(844, 117);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(210, 67);
            btnBuscar.TabIndex = 22;
            btnBuscar.TabStop = false;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.BackgroundColor = SystemColors.ControlLight;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(51, 465);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 62;
            dgvEquipos.Size = new Size(1097, 382);
            dgvEquipos.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.MidnightBlue;
            btnCancelar.Location = new Point(844, 354);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(210, 67);
            btnCancelar.TabIndex = 20;
            btnCancelar.TabStop = false;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(310, 390);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(255, 31);
            txtNumeroSerie.TabIndex = 19;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(310, 289);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(255, 31);
            txtModelo.TabIndex = 18;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(310, 219);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(255, 31);
            txtMarca.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.MidnightBlue;
            textBox4.Location = new Point(104, 374);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 64);
            textBox4.TabIndex = 16;
            textBox4.Text = "Número Serie";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.MidnightBlue;
            textBox3.Location = new Point(104, 289);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 64);
            textBox3.TabIndex = 15;
            textBox3.Text = "Modelo";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.MidnightBlue;
            textBox2.Location = new Point(104, 203);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 64);
            textBox2.TabIndex = 14;
            textBox2.Text = "Marca";
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(310, 133);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(255, 33);
            cbxCliente.TabIndex = 13;
            // 
            // btnBuscarEquipos
            // 
            btnBuscarEquipos.Dock = DockStyle.Top;
            btnBuscarEquipos.FlatAppearance.BorderSize = 0;
            btnBuscarEquipos.FlatStyle = FlatStyle.Flat;
            btnBuscarEquipos.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarEquipos.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarEquipos.IconColor = Color.MidnightBlue;
            btnBuscarEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarEquipos.IconSize = 40;
            btnBuscarEquipos.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarEquipos.Location = new Point(0, 0);
            btnBuscarEquipos.Margin = new Padding(4, 5, 4, 5);
            btnBuscarEquipos.Name = "btnBuscarEquipos";
            btnBuscarEquipos.Padding = new Padding(14, 0, 0, 0);
            btnBuscarEquipos.Size = new Size(1217, 100);
            btnBuscarEquipos.TabIndex = 12;
            btnBuscarEquipos.Text = "Buscar Equipos";
            btnBuscarEquipos.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarEquipos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarEquipos.UseVisualStyleBackColor = true;
            btnBuscarEquipos.Click += btnBuscarEquipos_Click;
            // 
            // textIngresarUsuario
            // 
            textIngresarUsuario.BackColor = Color.White;
            textIngresarUsuario.BorderStyle = BorderStyle.None;
            textIngresarUsuario.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textIngresarUsuario.ForeColor = Color.MidnightBlue;
            textIngresarUsuario.Location = new Point(104, 117);
            textIngresarUsuario.Margin = new Padding(4, 5, 4, 5);
            textIngresarUsuario.Name = "textIngresarUsuario";
            textIngresarUsuario.Size = new Size(106, 64);
            textIngresarUsuario.TabIndex = 1;
            textIngresarUsuario.Text = "Cliente";
            textIngresarUsuario.TextChanged += textIngresarUsuario_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.MidnightBlue;
            btnGuardar.Location = new Point(844, 230);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(210, 67);
            btnGuardar.TabIndex = 3;
            btnGuardar.TabStop = false;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnnousar);
            panel2.Controls.Add(BtnEntrarUsuario);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(iconUsuario);
            panel2.Enabled = false;
            panel2.ForeColor = Color.CornflowerBlue;
            panel2.Location = new Point(247, 108);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(193, 10);
            panel2.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Enabled = false;
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(91, 618);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(464, 3);
            button1.TabIndex = 47;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SkyBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.MidnightBlue;
            textBox1.Location = new Point(109, 550);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 64);
            textBox1.TabIndex = 46;
            textBox1.Text = "Contraseña";
            // 
            // btnnousar
            // 
            btnnousar.BackColor = Color.MidnightBlue;
            btnnousar.Enabled = false;
            btnnousar.ForeColor = Color.CornflowerBlue;
            btnnousar.Location = new Point(91, 508);
            btnnousar.Margin = new Padding(4, 5, 4, 5);
            btnnousar.Name = "btnnousar";
            btnnousar.Size = new Size(464, 3);
            btnnousar.TabIndex = 45;
            btnnousar.UseVisualStyleBackColor = false;
            // 
            // BtnEntrarUsuario
            // 
            BtnEntrarUsuario.BackColor = Color.SkyBlue;
            BtnEntrarUsuario.FlatStyle = FlatStyle.Flat;
            BtnEntrarUsuario.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEntrarUsuario.ForeColor = Color.MidnightBlue;
            BtnEntrarUsuario.Location = new Point(189, 700);
            BtnEntrarUsuario.Margin = new Padding(4, 5, 4, 5);
            BtnEntrarUsuario.Name = "BtnEntrarUsuario";
            BtnEntrarUsuario.Size = new Size(263, 73);
            BtnEntrarUsuario.TabIndex = 4;
            BtnEntrarUsuario.Text = "Iniciar";
            BtnEntrarUsuario.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.SkyBlue;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.MidnightBlue;
            txtUsuario.Location = new Point(109, 440);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(391, 64);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuario";
            // 
            // iconUsuario
            // 
            iconUsuario.BackColor = Color.SkyBlue;
            iconUsuario.ForeColor = Color.MidnightBlue;
            iconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconUsuario.IconColor = Color.MidnightBlue;
            iconUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsuario.IconSize = 263;
            iconUsuario.Location = new Point(210, 25);
            iconUsuario.Margin = new Padding(4, 5, 4, 5);
            iconUsuario.Name = "iconUsuario";
            iconUsuario.Size = new Size(263, 353);
            iconUsuario.TabIndex = 1;
            iconUsuario.TabStop = false;
            // 
            // FrmBuscarEquipos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 1010);
            Controls.Add(panelIniciar);
            Controls.Add(panel2);
            Name = "FrmBuscarEquipos";
            Text = "FrmBuscar";
            Load += FrmBuscarEquipos_Load;
            panelIniciar.ResumeLayout(false);
            panelIniciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIniciar;
        private TextBox textIngresarUsuario;
        private Button btnGuardar;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Button btnnousar;
        private Button BtnEntrarUsuario;
        private TextBox txtUsuario;
        private FontAwesome.Sharp.IconPictureBox iconUsuario;
        private FontAwesome.Sharp.IconButton btnBuscarEquipos;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox cbxCliente;
        private TextBox txtNumeroSerie;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Button btnCancelar;
        private DataGridView dgvEquipos;
        private Button btnBuscar;
    }
}