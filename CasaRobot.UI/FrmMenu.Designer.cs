namespace CasaRobot.UI
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panelMenu = new Panel();
            btMMetodoPago = new FontAwesome.Sharp.IconButton();
            btMHistorial = new FontAwesome.Sharp.IconButton();
            btMCostos = new FontAwesome.Sharp.IconButton();
            btMEstados = new FontAwesome.Sharp.IconButton();
            btMEmpleados = new FontAwesome.Sharp.IconButton();
            btMOrdenServicio = new FontAwesome.Sharp.IconButton();
            btMEquipos = new FontAwesome.Sharp.IconButton();
            btMClientes = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnLogo = new PictureBox();
            panelBarra = new Panel();
            iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            iconMaximizar = new FontAwesome.Sharp.IconPictureBox();
            iconMinimizar = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            IconoCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelSombra = new Panel();
            panelDesktop = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogo).BeginInit();
            panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconoCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.CornflowerBlue;
            panelMenu.Controls.Add(btMMetodoPago);
            panelMenu.Controls.Add(btMHistorial);
            panelMenu.Controls.Add(btMCostos);
            panelMenu.Controls.Add(btMEstados);
            panelMenu.Controls.Add(btMEmpleados);
            panelMenu.Controls.Add(btMOrdenServicio);
            panelMenu.Controls.Add(btMEquipos);
            panelMenu.Controls.Add(btMClientes);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 844);
            panelMenu.TabIndex = 0;
            // 
            // btMMetodoPago
            // 
            btMMetodoPago.Dock = DockStyle.Top;
            btMMetodoPago.FlatAppearance.BorderSize = 0;
            btMMetodoPago.FlatStyle = FlatStyle.Flat;
            btMMetodoPago.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMMetodoPago.IconChar = FontAwesome.Sharp.IconChar.Pager;
            btMMetodoPago.IconColor = Color.MidnightBlue;
            btMMetodoPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btMMetodoPago.IconSize = 40;
            btMMetodoPago.ImageAlign = ContentAlignment.MiddleLeft;
            btMMetodoPago.Location = new Point(0, 487);
            btMMetodoPago.Margin = new Padding(3, 4, 3, 4);
            btMMetodoPago.Name = "btMMetodoPago";
            btMMetodoPago.Padding = new Padding(11, 0, 0, 0);
            btMMetodoPago.Size = new Size(251, 43);
            btMMetodoPago.TabIndex = 12;
            btMMetodoPago.Text = "Métodos de Pago";
            btMMetodoPago.TextAlign = ContentAlignment.MiddleLeft;
            btMMetodoPago.TextImageRelation = TextImageRelation.ImageBeforeText;
            btMMetodoPago.UseVisualStyleBackColor = true;
            btMMetodoPago.Click += btMMetodoPago_Click;
            // 
            // btMHistorial
            // 
            btMHistorial.Dock = DockStyle.Top;
            btMHistorial.FlatAppearance.BorderSize = 0;
            btMHistorial.FlatStyle = FlatStyle.Flat;
            btMHistorial.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMHistorial.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            btMHistorial.IconColor = Color.MidnightBlue;
            btMHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btMHistorial.IconSize = 40;
            btMHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btMHistorial.Location = new Point(0, 444);
            btMHistorial.Margin = new Padding(3, 4, 3, 4);
            btMHistorial.Name = "btMHistorial";
            btMHistorial.Padding = new Padding(11, 0, 0, 0);
            btMHistorial.Size = new Size(251, 43);
            btMHistorial.TabIndex = 11;
            btMHistorial.Text = "Historial";
            btMHistorial.TextAlign = ContentAlignment.MiddleLeft;
            btMHistorial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btMHistorial.UseVisualStyleBackColor = true;
            btMHistorial.Click += btMHistorial_Click;
            // 
            // btMCostos
            // 
            btMCostos.Dock = DockStyle.Top;
            btMCostos.FlatAppearance.BorderSize = 0;
            btMCostos.FlatStyle = FlatStyle.Flat;
            btMCostos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMCostos.IconChar = FontAwesome.Sharp.IconChar.DollyBox;
            btMCostos.IconColor = Color.MidnightBlue;
            btMCostos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btMCostos.IconSize = 40;
            btMCostos.ImageAlign = ContentAlignment.MiddleLeft;
            btMCostos.Location = new Point(0, 401);
            btMCostos.Margin = new Padding(3, 4, 3, 4);
            btMCostos.Name = "btMCostos";
            btMCostos.Padding = new Padding(11, 0, 0, 0);
            btMCostos.Size = new Size(251, 43);
            btMCostos.TabIndex = 10;
            btMCostos.Text = "Costos";
            btMCostos.TextAlign = ContentAlignment.MiddleLeft;
            btMCostos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btMCostos.UseVisualStyleBackColor = true;
            btMCostos.Click += btMCostos_Click;
            // 
            // btMEstados
            // 
            btMEstados.Dock = DockStyle.Top;
            btMEstados.FlatAppearance.BorderSize = 0;
            btMEstados.FlatStyle = FlatStyle.Flat;
            btMEstados.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMEstados.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btMEstados.IconColor = Color.MidnightBlue;
            btMEstados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btMEstados.IconSize = 40;
            btMEstados.ImageAlign = ContentAlignment.MiddleLeft;
            btMEstados.Location = new Point(0, 358);
            btMEstados.Margin = new Padding(3, 4, 3, 4);
            btMEstados.Name = "btMEstados";
            btMEstados.Padding = new Padding(11, 0, 0, 0);
            btMEstados.Size = new Size(251, 43);
            btMEstados.TabIndex = 9;
            btMEstados.Text = "Estados";
            btMEstados.TextAlign = ContentAlignment.MiddleLeft;
            btMEstados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btMEstados.UseVisualStyleBackColor = true;
            btMEstados.Click += btMEstados_Click;
            // 
            // btMEmpleados
            // 
            btMEmpleados.Dock = DockStyle.Top;
            btMEmpleados.FlatAppearance.BorderSize = 0;
            btMEmpleados.FlatStyle = FlatStyle.Flat;
            btMEmpleados.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btMEmpleados.IconColor = Color.MidnightBlue;
            btMEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btMEmpleados.IconSize = 40;
            btMEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btMEmpleados.Location = new Point(0, 315);
            btMEmpleados.Margin = new Padding(3, 4, 3, 4);
            btMEmpleados.Name = "btMEmpleados";
            btMEmpleados.Padding = new Padding(11, 0, 0, 0);
            btMEmpleados.Size = new Size(251, 43);
            btMEmpleados.TabIndex = 8;
            btMEmpleados.Text = "Empleados";
            btMEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btMEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btMEmpleados.UseVisualStyleBackColor = true;
            btMEmpleados.Click += btMEmpleados_Click;
            // 
            // btMOrdenServicio
            // 
            btMOrdenServicio.Dock = DockStyle.Top;
            btMOrdenServicio.FlatAppearance.BorderSize = 0;
            btMOrdenServicio.FlatStyle = FlatStyle.Flat;
            btMOrdenServicio.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMOrdenServicio.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btMOrdenServicio.IconColor = Color.MidnightBlue;
            btMOrdenServicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btMOrdenServicio.IconSize = 40;
            btMOrdenServicio.ImageAlign = ContentAlignment.MiddleLeft;
            btMOrdenServicio.Location = new Point(0, 272);
            btMOrdenServicio.Margin = new Padding(3, 4, 3, 4);
            btMOrdenServicio.Name = "btMOrdenServicio";
            btMOrdenServicio.Padding = new Padding(11, 0, 0, 0);
            btMOrdenServicio.Size = new Size(251, 43);
            btMOrdenServicio.TabIndex = 7;
            btMOrdenServicio.Text = "Órdenes de Servicio";
            btMOrdenServicio.TextAlign = ContentAlignment.MiddleLeft;
            btMOrdenServicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btMOrdenServicio.UseVisualStyleBackColor = true;
            btMOrdenServicio.Click += btMOrdenServicio_Click;
            // 
            // btMEquipos
            // 
            btMEquipos.Dock = DockStyle.Top;
            btMEquipos.FlatAppearance.BorderSize = 0;
            btMEquipos.FlatStyle = FlatStyle.Flat;
            btMEquipos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMEquipos.IconChar = FontAwesome.Sharp.IconChar.Computer;
            btMEquipos.IconColor = Color.MidnightBlue;
            btMEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btMEquipos.IconSize = 40;
            btMEquipos.ImageAlign = ContentAlignment.MiddleLeft;
            btMEquipos.Location = new Point(0, 229);
            btMEquipos.Margin = new Padding(3, 4, 3, 4);
            btMEquipos.Name = "btMEquipos";
            btMEquipos.Padding = new Padding(11, 0, 0, 0);
            btMEquipos.Size = new Size(251, 43);
            btMEquipos.TabIndex = 6;
            btMEquipos.Text = "Equipos";
            btMEquipos.TextAlign = ContentAlignment.MiddleLeft;
            btMEquipos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btMEquipos.UseVisualStyleBackColor = true;
            btMEquipos.Click += btMEquipos_Click;
            // 
            // btMClientes
            // 
            btMClientes.Dock = DockStyle.Top;
            btMClientes.FlatAppearance.BorderSize = 0;
            btMClientes.FlatStyle = FlatStyle.Flat;
            btMClientes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMClientes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btMClientes.IconColor = Color.MidnightBlue;
            btMClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btMClientes.IconSize = 40;
            btMClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btMClientes.Location = new Point(0, 186);
            btMClientes.Margin = new Padding(3, 4, 3, 4);
            btMClientes.Name = "btMClientes";
            btMClientes.Padding = new Padding(11, 0, 0, 0);
            btMClientes.Size = new Size(251, 43);
            btMClientes.TabIndex = 5;
            btMClientes.Text = "Clientes";
            btMClientes.TextAlign = ContentAlignment.MiddleLeft;
            btMClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btMClientes.UseVisualStyleBackColor = true;
            btMClientes.Click += btMClientes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(251, 186);
            panelLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            btnLogo.Image = (Image)resources.GetObject("btnLogo.Image");
            btnLogo.Location = new Point(59, 30);
            btnLogo.Margin = new Padding(3, 4, 3, 4);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(113, 106);
            btnLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogo.TabIndex = 0;
            btnLogo.TabStop = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.LightSteelBlue;
            panelBarra.Controls.Add(iconCerrar);
            panelBarra.Controls.Add(iconMaximizar);
            panelBarra.Controls.Add(iconMinimizar);
            panelBarra.Controls.Add(lblTitleChildForm);
            panelBarra.Controls.Add(IconoCurrentChildForm);
            panelBarra.Dock = DockStyle.Top;
            panelBarra.Location = new Point(251, 0);
            panelBarra.Margin = new Padding(3, 4, 3, 4);
            panelBarra.Name = "panelBarra";
            panelBarra.Size = new Size(802, 94);
            panelBarra.TabIndex = 1;
            panelBarra.Paint += panelBarra_Paint;
            panelBarra.MouseDown += panelBarra_MouseDown;
            // 
            // iconCerrar
            // 
            iconCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconCerrar.BackColor = Color.FromArgb(100, 139, 230);
            iconCerrar.ForeColor = SystemColors.ControlText;
            iconCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            iconCerrar.IconColor = SystemColors.ControlText;
            iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCerrar.IconSize = 25;
            iconCerrar.Location = new Point(777, 0);
            iconCerrar.Margin = new Padding(0);
            iconCerrar.Name = "iconCerrar";
            iconCerrar.Size = new Size(25, 30);
            iconCerrar.TabIndex = 4;
            iconCerrar.TabStop = false;
            iconCerrar.Click += iconCerrar_Click;
            // 
            // iconMaximizar
            // 
            iconMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMaximizar.BackColor = Color.FromArgb(100, 139, 230);
            iconMaximizar.ForeColor = SystemColors.ControlText;
            iconMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            iconMaximizar.IconColor = SystemColors.ControlText;
            iconMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMaximizar.IconSize = 25;
            iconMaximizar.Location = new Point(750, 0);
            iconMaximizar.Margin = new Padding(0);
            iconMaximizar.Name = "iconMaximizar";
            iconMaximizar.Size = new Size(25, 30);
            iconMaximizar.TabIndex = 3;
            iconMaximizar.TabStop = false;
            iconMaximizar.Click += iconMaximizar_Click;
            // 
            // iconMinimizar
            // 
            iconMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimizar.BackColor = Color.FromArgb(100, 139, 230);
            iconMinimizar.ForeColor = SystemColors.InfoText;
            iconMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconMinimizar.IconColor = SystemColors.InfoText;
            iconMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinimizar.IconSize = 25;
            iconMinimizar.Location = new Point(723, 0);
            iconMinimizar.Margin = new Padding(0);
            iconMinimizar.Name = "iconMinimizar";
            iconMinimizar.Size = new Size(25, 30);
            iconMinimizar.TabIndex = 2;
            iconMinimizar.TabStop = false;
            iconMinimizar.Click += iconMinimizar_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleChildForm.Location = new Point(94, 30);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(48, 20);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Inicio";
            // 
            // IconoCurrentChildForm
            // 
            IconoCurrentChildForm.BackColor = Color.FromArgb(100, 139, 230);
            IconoCurrentChildForm.ForeColor = Color.MidnightBlue;
            IconoCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            IconoCurrentChildForm.IconColor = Color.MidnightBlue;
            IconoCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconoCurrentChildForm.IconSize = 68;
            IconoCurrentChildForm.Location = new Point(20, 4);
            IconoCurrentChildForm.Margin = new Padding(3, 4, 3, 4);
            IconoCurrentChildForm.Name = "IconoCurrentChildForm";
            IconoCurrentChildForm.Size = new Size(68, 68);
            IconoCurrentChildForm.TabIndex = 0;
            IconoCurrentChildForm.TabStop = false;
            // 
            // panelSombra
            // 
            panelSombra.BackColor = Color.FromArgb(100, 139, 220);
            panelSombra.Dock = DockStyle.Top;
            panelSombra.Location = new Point(251, 94);
            panelSombra.Margin = new Padding(3, 4, 3, 4);
            panelSombra.Name = "panelSombra";
            panelSombra.Size = new Size(802, 12);
            panelSombra.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.BackColor = Color.LightSteelBlue;
            panelDesktop.Controls.Add(label1);
            panelDesktop.Location = new Point(251, 106);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(801, 774);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 190);
            label1.Name = "label1";
            label1.Size = new Size(405, 50);
            label1.TabIndex = 2;
            label1.Text = "Somos una empresa que se dedica al arreglo\r\n y servicio tecnico de equipos tecnogicos";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1053, 844);
            Controls.Add(panelDesktop);
            Controls.Add(panelSombra);
            Controls.Add(panelBarra);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenu";
            Text = "Menu";
            Load += FrmMenu_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnLogo).EndInit();
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconoCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Panel panelBarra;
        private FontAwesome.Sharp.IconPictureBox IconoCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelLogo;
        private PictureBox btnLogo;
        private Panel panelSombra;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private FontAwesome.Sharp.IconPictureBox iconMaximizar;
        private Label label1;
        private FontAwesome.Sharp.IconButton btMClientes;
        private FontAwesome.Sharp.IconButton btMMetodoPago;
        private FontAwesome.Sharp.IconButton btMHistorial;
        private FontAwesome.Sharp.IconButton btMCostos;
        private FontAwesome.Sharp.IconButton btMEstados;
        private FontAwesome.Sharp.IconButton btMEmpleados;
        private FontAwesome.Sharp.IconButton btMOrdenServicio;
        private FontAwesome.Sharp.IconButton btMEquipos;
    }
}
