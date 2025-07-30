namespace CasaRobot.UI.Forms
{
    partial class OrdenesServicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesServicioForm));
            groupBox2 = new GroupBox();
            dgvOrdenes = new DataGridView();
            GrupoBoxFormC = new GroupBox();
            label5 = new Label();
            lblUsuario = new Label();
            dtpFechaSalida = new DateTimePicker();
            cmbEstado = new ComboBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            cmbEquipo = new ComboBox();
            dtpFechaIngreso = new DateTimePicker();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            GrupoBoxFormC.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvOrdenes);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(894, 279);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Dock = DockStyle.Fill;
            dgvOrdenes.Location = new Point(3, 23);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.RowHeadersWidth = 51;
            dgvOrdenes.Size = new Size(888, 253);
            dgvOrdenes.TabIndex = 0;
            dgvOrdenes.CellClick += dgvOrdenes_CellClick;
            // 
            // GrupoBoxFormC
            // 
            GrupoBoxFormC.Controls.Add(dtpFechaIngreso);
            GrupoBoxFormC.Controls.Add(label5);
            GrupoBoxFormC.Controls.Add(lblUsuario);
            GrupoBoxFormC.Controls.Add(dtpFechaSalida);
            GrupoBoxFormC.Controls.Add(cmbEstado);
            GrupoBoxFormC.Controls.Add(btnEliminar);
            GrupoBoxFormC.Controls.Add(btnActualizar);
            GrupoBoxFormC.Controls.Add(btnGuardar);
            GrupoBoxFormC.Controls.Add(label4);
            GrupoBoxFormC.Controls.Add(label3);
            GrupoBoxFormC.Controls.Add(label2);
            GrupoBoxFormC.Controls.Add(label1);
            GrupoBoxFormC.Controls.Add(txtDescripcion);
            GrupoBoxFormC.Controls.Add(cmbEquipo);
            GrupoBoxFormC.Dock = DockStyle.Top;
            GrupoBoxFormC.Location = new Point(0, 0);
            GrupoBoxFormC.Name = "GrupoBoxFormC";
            GrupoBoxFormC.Size = new Size(894, 202);
            GrupoBoxFormC.TabIndex = 2;
            GrupoBoxFormC.TabStop = false;
            GrupoBoxFormC.Text = "Formulario Equipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 49);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 18;
            label5.Text = "Fecha Ingreso";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(357, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 17;
            lblUsuario.Text = "Usuario";
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Format = DateTimePickerFormat.Short;
            dtpFechaSalida.Location = new Point(522, 82);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(113, 27);
            dtpFechaSalida.TabIndex = 10;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(93, 78);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(258, 28);
            cmbEstado.TabIndex = 9;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(469, 151);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 39);
            btnEliminar.TabIndex = 8;
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
            btnActualizar.Location = new Point(324, 151);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 39);
            btnActualizar.TabIndex = 8;
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
            btnGuardar.Location = new Point(174, 151);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 39);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 87);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha Salida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 120);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 4;
            label1.Text = "Equipo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(93, 120);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(651, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // cmbEquipo
            // 
            cmbEquipo.FormattingEnabled = true;
            cmbEquipo.Location = new Point(93, 41);
            cmbEquipo.Name = "cmbEquipo";
            cmbEquipo.Size = new Size(258, 28);
            cmbEquipo.TabIndex = 0;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(522, 44);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(113, 27);
            dtpFechaIngreso.TabIndex = 19;
            // 
            // OrdenesServicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(894, 481);
            Controls.Add(groupBox2);
            Controls.Add(GrupoBoxFormC);
            Name = "OrdenesServicioForm";
            Text = "OrdenesServicioForm";
            Load += OrdenesServicioForm_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            GrupoBoxFormC.ResumeLayout(false);
            GrupoBoxFormC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvOrdenes;
        private GroupBox GrupoBoxFormC;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcion;
        private ComboBox cmbEquipo;
        private ComboBox cmbEstado;
        private DateTimePicker dtpFechaSalida;
        private Label lblUsuario;
        private Label label5;
        private DateTimePicker dtpFechaIngreso;
    }
}