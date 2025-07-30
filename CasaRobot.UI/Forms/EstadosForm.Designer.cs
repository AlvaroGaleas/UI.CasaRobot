namespace CasaRobot.UI.Forms
{
    partial class EstadosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadosForm));
            groupBox2 = new GroupBox();
            dgvEstados = new DataGridView();
            GrupoBoxFormC = new GroupBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            label2 = new Label();
            txtNombreEstado = new TextBox();
            lblUsuario = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstados).BeginInit();
            GrupoBoxFormC.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvEstados);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(523, 313);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // dgvEstados
            // 
            dgvEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstados.Dock = DockStyle.Fill;
            dgvEstados.Location = new Point(3, 23);
            dgvEstados.Name = "dgvEstados";
            dgvEstados.RowHeadersWidth = 51;
            dgvEstados.Size = new Size(517, 287);
            dgvEstados.TabIndex = 0;
            dgvEstados.CellClick += dgvEstados_CellClick;
            // 
            // GrupoBoxFormC
            // 
            GrupoBoxFormC.Controls.Add(lblUsuario);
            GrupoBoxFormC.Controls.Add(btnEliminar);
            GrupoBoxFormC.Controls.Add(btnActualizar);
            GrupoBoxFormC.Controls.Add(btnGuardar);
            GrupoBoxFormC.Controls.Add(label2);
            GrupoBoxFormC.Controls.Add(txtNombreEstado);
            GrupoBoxFormC.Dock = DockStyle.Top;
            GrupoBoxFormC.Location = new Point(0, 0);
            GrupoBoxFormC.Name = "GrupoBoxFormC";
            GrupoBoxFormC.Size = new Size(523, 137);
            GrupoBoxFormC.TabIndex = 2;
            GrupoBoxFormC.TabStop = false;
            GrupoBoxFormC.Text = "Formulario Estados";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(353, 72);
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
            btnActualizar.Location = new Point(208, 72);
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
            btnGuardar.Location = new Point(58, 72);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 39);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 5;
            label2.Text = "NombreEstado";
            // 
            // txtNombreEstado
            // 
            txtNombreEstado.Location = new Point(152, 26);
            txtNombreEstado.Name = "txtNombreEstado";
            txtNombreEstado.Size = new Size(324, 27);
            txtNombreEstado.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(0, 114);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 18;
            lblUsuario.Text = "Usuario";
            // 
            // EstadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(523, 450);
            Controls.Add(groupBox2);
            Controls.Add(GrupoBoxFormC);
            Name = "EstadosForm";
            Text = "EstadosForm";
            Load += EstadosForm_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstados).EndInit();
            GrupoBoxFormC.ResumeLayout(false);
            GrupoBoxFormC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvEstados;
        private GroupBox GrupoBoxFormC;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNumeroSerie;
        private TextBox txtModelo;
        private TextBox txtNombreEstado;
        private ComboBox cmbCliente;
        private Label lblUsuario;
    }
}