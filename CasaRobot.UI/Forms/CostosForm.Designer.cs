namespace CasaRobot.UI.Forms
{
    partial class CostosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostosForm));
            dgvCostos = new DataGridView();
            GrupoBoxFormC = new GroupBox();
            cmbOrden = new ComboBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMonto = new TextBox();
            txtDetalleCosto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCostos).BeginInit();
            GrupoBoxFormC.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCostos
            // 
            dgvCostos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCostos.Dock = DockStyle.Fill;
            dgvCostos.Location = new Point(0, 172);
            dgvCostos.Name = "dgvCostos";
            dgvCostos.RowHeadersWidth = 51;
            dgvCostos.Size = new Size(746, 278);
            dgvCostos.TabIndex = 3;
            dgvCostos.CellClick += dgvCostos_CellClick;
            // 
            // GrupoBoxFormC
            // 
            GrupoBoxFormC.Controls.Add(cmbOrden);
            GrupoBoxFormC.Controls.Add(btnEliminar);
            GrupoBoxFormC.Controls.Add(btnActualizar);
            GrupoBoxFormC.Controls.Add(btnGuardar);
            GrupoBoxFormC.Controls.Add(label4);
            GrupoBoxFormC.Controls.Add(label3);
            GrupoBoxFormC.Controls.Add(label2);
            GrupoBoxFormC.Controls.Add(txtMonto);
            GrupoBoxFormC.Controls.Add(txtDetalleCosto);
            GrupoBoxFormC.Dock = DockStyle.Top;
            GrupoBoxFormC.Location = new Point(0, 0);
            GrupoBoxFormC.Name = "GrupoBoxFormC";
            GrupoBoxFormC.Size = new Size(746, 172);
            GrupoBoxFormC.TabIndex = 4;
            GrupoBoxFormC.TabStop = false;
            GrupoBoxFormC.Text = "Formulario";
            GrupoBoxFormC.Enter += GrupoBoxFormC_Enter;
            // 
            // cmbOrden
            // 
            cmbOrden.FormattingEnabled = true;
            cmbOrden.Location = new Point(114, 31);
            cmbOrden.Name = "cmbOrden";
            cmbOrden.Size = new Size(540, 28);
            cmbOrden.TabIndex = 9;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(409, 107);
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
            btnActualizar.Location = new Point(264, 107);
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
            btnGuardar.Location = new Point(114, 107);
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
            label4.Location = new Point(377, 74);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Monto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 6;
            label3.Text = "DetalleCosto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Orden";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(455, 67);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(199, 27);
            txtMonto.TabIndex = 3;
            // 
            // txtDetalleCosto
            // 
            txtDetalleCosto.Location = new Point(114, 71);
            txtDetalleCosto.Name = "txtDetalleCosto";
            txtDetalleCosto.Size = new Size(247, 27);
            txtDetalleCosto.TabIndex = 2;
            // 
            // CostosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(746, 450);
            Controls.Add(dgvCostos);
            Controls.Add(GrupoBoxFormC);
            Name = "CostosForm";
            Text = "CostosForm";
            Load += CostosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCostos).EndInit();
            GrupoBoxFormC.ResumeLayout(false);
            GrupoBoxFormC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCostos;
        private GroupBox GrupoBoxFormC;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMonto;
        private TextBox txtDetalleCosto;
        private ComboBox cmbOrden;
    }
}