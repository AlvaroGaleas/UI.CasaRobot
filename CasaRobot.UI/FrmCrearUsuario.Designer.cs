namespace CasaRobot.UI
{
    partial class FrmCrearUsuario
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
            groupBox1 = new GroupBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            btLimpiar = new Button();
            btEliminar = new Button();
            btEditar = new Button();
            btGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvDatos = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(btLimpiar);
            groupBox1.Controls.Add(btEliminar);
            groupBox1.Controls.Add(btEditar);
            groupBox1.Controls.Add(btGuardar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1055, 152);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(482, 69);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(293, 27);
            txtDireccion.TabIndex = 11;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(482, 26);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(293, 27);
            txtCorreo.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(106, 69);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(293, 27);
            txtTelefono.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(293, 27);
            txtNombre.TabIndex = 8;
            // 
            // btLimpiar
            // 
            btLimpiar.BackColor = Color.Lavender;
            btLimpiar.Location = new Point(431, 102);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(94, 29);
            btLimpiar.TabIndex = 7;
            btLimpiar.Text = "Limpiar";
            btLimpiar.UseVisualStyleBackColor = false;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = Color.Lavender;
            btEliminar.Location = new Point(318, 102);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(94, 29);
            btEliminar.TabIndex = 6;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Lavender;
            btEditar.Location = new Point(205, 102);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(94, 29);
            btEditar.TabIndex = 5;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.Lavender;
            btGuardar.Location = new Point(88, 102);
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
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 33);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 72);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Direccion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDatos);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1055, 677);
            groupBox2.TabIndex = 16;
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
            dgvDatos.Size = new Size(1049, 651);
            dgvDatos.TabIndex = 0;
            // 
            // FrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 829);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCrearUsuario";
            Text = "FrmCrearUsuario";
            Load += FrmCrearUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btLimpiar;
        private Button btEliminar;
        private Button btEditar;
        private Button btGuardar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDatos;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
    }
}