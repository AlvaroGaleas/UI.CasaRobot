namespace CasaRobot.UI.Forms
{
    partial class HistorialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialForm));
            groupBox2 = new GroupBox();
            dgvHistorial = new DataGridView();
            GrupoBoxFormC = new GroupBox();
            cmbEmpleado = new ComboBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescripcionTrabajo = new TextBox();
            cmbOrden = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            GrupoBoxFormC.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHistorial);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(826, 278);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(3, 23);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(820, 252);
            dgvHistorial.TabIndex = 0;
            dgvHistorial.CellClick += dgvHistorial_CellClick;
            // 
            // GrupoBoxFormC
            // 
            GrupoBoxFormC.Controls.Add(cmbEmpleado);
            GrupoBoxFormC.Controls.Add(btnEliminar);
            GrupoBoxFormC.Controls.Add(btnActualizar);
            GrupoBoxFormC.Controls.Add(btnGuardar);
            GrupoBoxFormC.Controls.Add(label3);
            GrupoBoxFormC.Controls.Add(label2);
            GrupoBoxFormC.Controls.Add(label1);
            GrupoBoxFormC.Controls.Add(txtDescripcionTrabajo);
            GrupoBoxFormC.Controls.Add(cmbOrden);
            GrupoBoxFormC.Dock = DockStyle.Top;
            GrupoBoxFormC.Location = new Point(0, 0);
            GrupoBoxFormC.Name = "GrupoBoxFormC";
            GrupoBoxFormC.Size = new Size(826, 172);
            GrupoBoxFormC.TabIndex = 4;
            GrupoBoxFormC.TabStop = false;
            GrupoBoxFormC.Text = "Formulario Equipo";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(539, 44);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(271, 28);
            cmbEmpleado.TabIndex = 9;
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
            label3.Size = new Size(137, 20);
            label3.TabIndex = 6;
            label3.Text = "DescripcionTrabajo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 47);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 5;
            label2.Text = "Empleado";
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
            // txtDescripcionTrabajo
            // 
            txtDescripcionTrabajo.Location = new Point(167, 87);
            txtDescripcionTrabajo.Name = "txtDescripcionTrabajo";
            txtDescripcionTrabajo.Size = new Size(643, 27);
            txtDescripcionTrabajo.TabIndex = 2;
            // 
            // cmbOrden
            // 
            cmbOrden.FormattingEnabled = true;
            cmbOrden.Location = new Point(93, 41);
            cmbOrden.Name = "cmbOrden";
            cmbOrden.Size = new Size(351, 28);
            cmbOrden.TabIndex = 0;
            // 
            // HistorialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(groupBox2);
            Controls.Add(GrupoBoxFormC);
            Name = "HistorialForm";
            Text = "HistorialForm";
            Load += HistorialForm_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            GrupoBoxFormC.ResumeLayout(false);
            GrupoBoxFormC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvHistorial;
        private GroupBox GrupoBoxFormC;
        private ComboBox cmbEmpleado;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcionTrabajo;
        private ComboBox cmbOrden;
    }
}