namespace CasaRobot.UI.Forms
{
    partial class MetodosPagoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodosPagoForm));
            groupBox2 = new GroupBox();
            dgvPagos = new DataGridView();
            GrupoBoxFormC = new GroupBox();
            label4 = new Label();
            dtpFechaPago = new DateTimePicker();
            txtMonto = new TextBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMetodo = new TextBox();
            cmbOrden = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            GrupoBoxFormC.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPagos);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(821, 278);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Dock = DockStyle.Fill;
            dgvPagos.Location = new Point(3, 23);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowHeadersWidth = 51;
            dgvPagos.Size = new Size(815, 252);
            dgvPagos.TabIndex = 0;
            dgvPagos.CellClick += dgvPagos_CellClick;
            // 
            // GrupoBoxFormC
            // 
            GrupoBoxFormC.Controls.Add(label4);
            GrupoBoxFormC.Controls.Add(dtpFechaPago);
            GrupoBoxFormC.Controls.Add(txtMonto);
            GrupoBoxFormC.Controls.Add(btnEliminar);
            GrupoBoxFormC.Controls.Add(btnActualizar);
            GrupoBoxFormC.Controls.Add(btnGuardar);
            GrupoBoxFormC.Controls.Add(label3);
            GrupoBoxFormC.Controls.Add(label2);
            GrupoBoxFormC.Controls.Add(label1);
            GrupoBoxFormC.Controls.Add(txtMetodo);
            GrupoBoxFormC.Controls.Add(cmbOrden);
            GrupoBoxFormC.Dock = DockStyle.Top;
            GrupoBoxFormC.Location = new Point(0, 0);
            GrupoBoxFormC.Name = "GrupoBoxFormC";
            GrupoBoxFormC.Size = new Size(821, 172);
            GrupoBoxFormC.TabIndex = 6;
            GrupoBoxFormC.TabStop = false;
            GrupoBoxFormC.Text = "Formulario Pagos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 87);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 12;
            label4.Text = "FechaPago";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(548, 85);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(138, 27);
            dtpFechaPago.TabIndex = 11;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(548, 44);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(246, 27);
            txtMonto.TabIndex = 10;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(469, 119);
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
            btnActualizar.Location = new Point(324, 119);
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
            btnGuardar.Location = new Point(174, 119);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 39);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Metodo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 49);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 5;
            label2.Text = "Monto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Orden";
            // 
            // txtMetodo
            // 
            txtMetodo.Location = new Point(93, 87);
            txtMetodo.Name = "txtMetodo";
            txtMetodo.Size = new Size(351, 27);
            txtMetodo.TabIndex = 2;
            // 
            // cmbOrden
            // 
            cmbOrden.FormattingEnabled = true;
            cmbOrden.Location = new Point(93, 41);
            cmbOrden.Name = "cmbOrden";
            cmbOrden.Size = new Size(351, 28);
            cmbOrden.TabIndex = 0;
            // 
            // MetodosPagoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 450);
            Controls.Add(groupBox2);
            Controls.Add(GrupoBoxFormC);
            Name = "MetodosPagoForm";
            Text = "MetodosPagoForm";
            Load += MetodosPagoForm_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            GrupoBoxFormC.ResumeLayout(false);
            GrupoBoxFormC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvPagos;
        private GroupBox GrupoBoxFormC;
        private Label label4;
        private DateTimePicker dtpFechaPago;
        private TextBox txtMonto;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMetodo;
        private ComboBox cmbOrden;
    }
}