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
            btnBuscarEquipos = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnCrearUsuario = new FontAwesome.Sharp.IconButton();
            btnIniciarSesion = new FontAwesome.Sharp.IconButton();
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
            panelMenu.Controls.Add(btnBuscarEquipos);
            panelMenu.Controls.Add(btnIngresar);
            panelMenu.Controls.Add(btnCrearUsuario);
            panelMenu.Controls.Add(btnIniciarSesion);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 844);
            panelMenu.TabIndex = 0;
            // 
            // btnBuscarEquipos
            // 
            btnBuscarEquipos.Dock = DockStyle.Top;
            btnBuscarEquipos.FlatAppearance.BorderSize = 0;
            btnBuscarEquipos.FlatStyle = FlatStyle.Flat;
            btnBuscarEquipos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarEquipos.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarEquipos.IconColor = Color.MidnightBlue;
            btnBuscarEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarEquipos.IconSize = 40;
            btnBuscarEquipos.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarEquipos.Location = new Point(0, 426);
            btnBuscarEquipos.Margin = new Padding(3, 4, 3, 4);
            btnBuscarEquipos.Name = "btnBuscarEquipos";
            btnBuscarEquipos.Padding = new Padding(11, 0, 0, 0);
            btnBuscarEquipos.Size = new Size(251, 80);
            btnBuscarEquipos.TabIndex = 4;
            btnBuscarEquipos.Text = "Buscar Equipos";
            btnBuscarEquipos.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarEquipos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarEquipos.UseVisualStyleBackColor = true;
            btnBuscarEquipos.Click += btnBuscarEquipos_Click;
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
            btnIngresar.Location = new Point(0, 346);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Padding = new Padding(11, 0, 0, 0);
            btnIngresar.Size = new Size(251, 80);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar Equipos";
            btnIngresar.TextAlign = ContentAlignment.MiddleLeft;
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Dock = DockStyle.Top;
            btnCrearUsuario.FlatAppearance.BorderSize = 0;
            btnCrearUsuario.FlatStyle = FlatStyle.Flat;
            btnCrearUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnCrearUsuario.IconColor = Color.MidnightBlue;
            btnCrearUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearUsuario.IconSize = 40;
            btnCrearUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearUsuario.Location = new Point(0, 266);
            btnCrearUsuario.Margin = new Padding(3, 4, 3, 4);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Padding = new Padding(11, 0, 0, 0);
            btnCrearUsuario.Size = new Size(251, 80);
            btnCrearUsuario.TabIndex = 2;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Dock = DockStyle.Top;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnIniciarSesion.IconColor = Color.MidnightBlue;
            btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIniciarSesion.IconSize = 40;
            btnIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnIniciarSesion.Location = new Point(0, 186);
            btnIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Padding = new Padding(11, 0, 0, 0);
            btnIniciarSesion.Size = new Size(251, 80);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnIniciarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
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
            lblTitleChildForm.Location = new Point(95, 30);
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
            IconoCurrentChildForm.IconSize = 37;
            IconoCurrentChildForm.Location = new Point(51, 30);
            IconoCurrentChildForm.Margin = new Padding(3, 4, 3, 4);
            IconoCurrentChildForm.Name = "IconoCurrentChildForm";
            IconoCurrentChildForm.Size = new Size(37, 42);
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
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnBuscarEquipos;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnCrearUsuario;
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
    }
}
