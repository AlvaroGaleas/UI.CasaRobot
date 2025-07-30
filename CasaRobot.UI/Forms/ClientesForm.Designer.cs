namespace CasaRobot.UI.Forms
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            dgvClientes = new DataGridView();
            label1 = new Label();
            txtNombre = new TextBox();
            groupBox1 = new GroupBox();
            lblUsuario = new Label();
            btnBuscar = new Button();
            label5 = new Label();
            txtBuscarNombre = new TextBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(3, 23);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(794, 208);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 27);
            txtNombre.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBuscarNombre);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 216);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario de Clientes";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(393, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 16;
            lblUsuario.Text = "Usuario";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(523, 183);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 183);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 14;
            label5.Text = "Buscar por Nombre";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(250, 183);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(267, 27);
            txtBuscarNombre.TabIndex = 13;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(473, 120);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 39);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(328, 120);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 39);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Properties.Resources.guardar21;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(178, 120);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 39);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 85);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 8;
            label3.Text = "Direccion ";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(487, 82);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(257, 27);
            txtDireccion.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 42);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(487, 39);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(257, 27);
            txtTelefono.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(106, 82);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(255, 27);
            txtCorreo.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvClientes);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 234);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ClientesForm";
            Text = "ClientesForm";
            Load += ClientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvClientes;
        private Label label1;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtCorreo;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnBuscar;
        private Label label5;
        private TextBox txtBuscarNombre;
        private Label lblUsuario;
    }
}