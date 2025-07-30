namespace CasaRobot.UI.Forms
{
    partial class EquiposForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquiposForm));
            GrupoBoxFormC = new GroupBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNumeroSerie = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            cmbCliente = new ComboBox();
            groupBox2 = new GroupBox();
            dgvEquipos = new DataGridView();
            lblUsuario = new Label();
            GrupoBoxFormC.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // GrupoBoxFormC
            // 
            GrupoBoxFormC.Controls.Add(lblUsuario);
            GrupoBoxFormC.Controls.Add(btnEliminar);
            GrupoBoxFormC.Controls.Add(btnActualizar);
            GrupoBoxFormC.Controls.Add(btnGuardar);
            GrupoBoxFormC.Controls.Add(label4);
            GrupoBoxFormC.Controls.Add(label3);
            GrupoBoxFormC.Controls.Add(label2);
            GrupoBoxFormC.Controls.Add(label1);
            GrupoBoxFormC.Controls.Add(txtNumeroSerie);
            GrupoBoxFormC.Controls.Add(txtModelo);
            GrupoBoxFormC.Controls.Add(txtMarca);
            GrupoBoxFormC.Controls.Add(cmbCliente);
            GrupoBoxFormC.Dock = DockStyle.Top;
            GrupoBoxFormC.Location = new Point(0, 0);
            GrupoBoxFormC.Name = "GrupoBoxFormC";
            GrupoBoxFormC.Size = new Size(800, 172);
            GrupoBoxFormC.TabIndex = 0;
            GrupoBoxFormC.TabStop = false;
            GrupoBoxFormC.Text = "Formulario Equipo";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 78);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 7;
            label4.Text = "NumeroSerie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 44);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(455, 79);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(261, 27);
            txtNumeroSerie.TabIndex = 3;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(455, 46);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(261, 27);
            txtModelo.TabIndex = 2;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(93, 75);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(258, 27);
            txtMarca.TabIndex = 1;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(93, 41);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(258, 28);
            cmbCliente.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvEquipos);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 278);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Dock = DockStyle.Fill;
            dgvEquipos.Location = new Point(3, 23);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.Size = new Size(794, 252);
            dgvEquipos.TabIndex = 0;
            dgvEquipos.CellClick += dgvEquipos_CellClick;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(455, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 17;
            lblUsuario.Text = "Usuario";
            // 
            // EquiposForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(GrupoBoxFormC);
            Name = "EquiposForm";
            Text = "EquiposForm";
            Load += EquiposForm_Load;
            GrupoBoxFormC.ResumeLayout(false);
            GrupoBoxFormC.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GrupoBoxFormC;
        private GroupBox groupBox2;
        private ComboBox cmbCliente;
        private DataGridView dgvEquipos;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNumeroSerie;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Label lblUsuario;
    }
}