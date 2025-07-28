namespace CasaRobot.UI
{
    partial class FrmIngresarEquipos
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
            btnIngresar = new FontAwesome.Sharp.IconButton();
            panelIniciar = new Panel();
            groupBox2 = new GroupBox();
            dgvDatos = new DataGridView();
            groupBox1 = new GroupBox();
            cmbClientes = new ComboBox();
            txtNumeroS = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            btLimpiar = new Button();
            btEliminar = new Button();
            btEditar = new Button();
            btGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtNumeroSerie = new Label();
            label1 = new Label();
            panelIniciar.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Dock = DockStyle.Top;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            btnIngresar.IconColor = Color.MidnightBlue;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 40;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(0, 0);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Padding = new Padding(11, 0, 0, 0);
            btnIngresar.Size = new Size(237, 51);
            btnIngresar.TabIndex = 23;
            btnIngresar.Text = "Ingresar Equipos";
            btnIngresar.TextAlign = ContentAlignment.MiddleLeft;
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // panelIniciar
            // 
            panelIniciar.Anchor = AnchorStyles.None;
            panelIniciar.BackColor = Color.White;
            panelIniciar.BackgroundImageLayout = ImageLayout.None;
            panelIniciar.Controls.Add(btnIngresar);
            panelIniciar.Location = new Point(12, 6);
            panelIniciar.Margin = new Padding(3, 4, 3, 4);
            panelIniciar.Name = "panelIniciar";
            panelIniciar.Size = new Size(237, 64);
            panelIniciar.TabIndex = 15;
            panelIniciar.Paint += panelIniciar_Paint;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDatos);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1106, 658);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(3, 23);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(1100, 632);
            dgvDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(cmbClientes);
            groupBox1.Controls.Add(txtNumeroS);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(btLimpiar);
            groupBox1.Controls.Add(btEliminar);
            groupBox1.Controls.Add(btEditar);
            groupBox1.Controls.Add(btGuardar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNumeroSerie);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1106, 152);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(106, 30);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(293, 28);
            cmbClientes.TabIndex = 12;
            // 
            // txtNumeroS
            // 
            txtNumeroS.Location = new Point(567, 73);
            txtNumeroS.Name = "txtNumeroS";
            txtNumeroS.Size = new Size(293, 27);
            txtNumeroS.TabIndex = 11;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(567, 30);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(293, 27);
            txtModelo.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(106, 69);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(293, 27);
            txtMarca.TabIndex = 9;
            // 
            // btLimpiar
            // 
            btLimpiar.BackColor = Color.Lavender;
            btLimpiar.Location = new Point(431, 113);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(94, 29);
            btLimpiar.TabIndex = 7;
            btLimpiar.Text = "Limpiar";
            btLimpiar.UseVisualStyleBackColor = false;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = Color.Lavender;
            btEliminar.Location = new Point(318, 113);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(94, 29);
            btEliminar.TabIndex = 6;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Lavender;
            btEditar.Location = new Point(205, 113);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(94, 29);
            btEditar.TabIndex = 5;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.Lavender;
            btGuardar.Location = new Point(88, 113);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(94, 29);
            btGuardar.TabIndex = 4;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 66);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 37);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Modelo:";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.AutoSize = true;
            txtNumeroSerie.Location = new Point(444, 80);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(99, 20);
            txtNumeroSerie.TabIndex = 1;
            txtNumeroSerie.Text = "NumeroSerie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Clientes:";
            // 
            // FrmIngresarEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 810);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panelIniciar);
            Margin = new Padding(2);
            Name = "FrmIngresarEquipos";
            Text = "FrmIngresarEquipos";
            Load += FrmIngresarEquipos_Load;
            panelIniciar.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnIngresar;
        private Panel panelIniciar;
        private GroupBox groupBox2;
        private DataGridView dgvDatos;
        private GroupBox groupBox1;
        private ComboBox cmbClientes;
        private TextBox txtNumeroS;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Button btLimpiar;
        private Button btEliminar;
        private Button btEditar;
        private Button btGuardar;
        private Label label4;
        private Label label3;
        private Label txtNumeroSerie;
        private Label label1;
    }
}