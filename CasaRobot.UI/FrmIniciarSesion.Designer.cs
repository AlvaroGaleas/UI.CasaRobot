namespace CasaRobot.UI
{
    partial class FrmIniciarSesion
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
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            btnnousar = new Button();
            BtnEntrarUsuario = new Button();
            txtUsuario = new TextBox();
            iconUsuario = new FontAwesome.Sharp.IconPictureBox();
            panelIniciar = new Panel();
            iconUser = new FontAwesome.Sharp.IconPictureBox();
            btn2nousar = new Button();
            linkLabel1 = new LinkLabel();
            no = new Button();
            txtContraseña = new TextBox();
            textIngresarUsuario = new TextBox();
            btnIngresar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).BeginInit();
            panelIniciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnnousar);
            panel2.Controls.Add(BtnEntrarUsuario);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(iconUsuario);
            panel2.Enabled = false;
            panel2.ForeColor = Color.CornflowerBlue;
            panel2.Location = new Point(407, 202);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Enabled = false;
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(91, 618);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(464, 3);
            button1.TabIndex = 47;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SkyBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.MidnightBlue;
            textBox1.Location = new Point(109, 550);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 64);
            textBox1.TabIndex = 46;
            textBox1.Text = "Contraseña";
            // 
            // btnnousar
            // 
            btnnousar.BackColor = Color.MidnightBlue;
            btnnousar.Enabled = false;
            btnnousar.ForeColor = Color.CornflowerBlue;
            btnnousar.Location = new Point(91, 508);
            btnnousar.Margin = new Padding(4, 5, 4, 5);
            btnnousar.Name = "btnnousar";
            btnnousar.Size = new Size(464, 3);
            btnnousar.TabIndex = 45;
            btnnousar.UseVisualStyleBackColor = false;
            // 
            // BtnEntrarUsuario
            // 
            BtnEntrarUsuario.BackColor = Color.SkyBlue;
            BtnEntrarUsuario.FlatStyle = FlatStyle.Flat;
            BtnEntrarUsuario.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEntrarUsuario.ForeColor = Color.MidnightBlue;
            BtnEntrarUsuario.Location = new Point(189, 700);
            BtnEntrarUsuario.Margin = new Padding(4, 5, 4, 5);
            BtnEntrarUsuario.Name = "BtnEntrarUsuario";
            BtnEntrarUsuario.Size = new Size(263, 73);
            BtnEntrarUsuario.TabIndex = 4;
            BtnEntrarUsuario.Text = "Iniciar";
            BtnEntrarUsuario.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.SkyBlue;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.MidnightBlue;
            txtUsuario.Location = new Point(109, 440);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(391, 64);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuario";
            // 
            // iconUsuario
            // 
            iconUsuario.BackColor = Color.SkyBlue;
            iconUsuario.ForeColor = Color.MidnightBlue;
            iconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconUsuario.IconColor = Color.MidnightBlue;
            iconUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsuario.IconSize = 263;
            iconUsuario.Location = new Point(210, 25);
            iconUsuario.Margin = new Padding(4, 5, 4, 5);
            iconUsuario.Name = "iconUsuario";
            iconUsuario.Size = new Size(263, 353);
            iconUsuario.TabIndex = 1;
            iconUsuario.TabStop = false;
            // 
            // panelIniciar
            // 
            panelIniciar.Anchor = AnchorStyles.None;
            panelIniciar.BackColor = Color.White;
            panelIniciar.BackgroundImageLayout = ImageLayout.None;
            panelIniciar.Controls.Add(iconUser);
            panelIniciar.Controls.Add(btn2nousar);
            panelIniciar.Controls.Add(linkLabel1);
            panelIniciar.Controls.Add(no);
            panelIniciar.Controls.Add(txtContraseña);
            panelIniciar.Controls.Add(textIngresarUsuario);
            panelIniciar.Controls.Add(btnIngresar);
            panelIniciar.Location = new Point(390, 83);
            panelIniciar.Margin = new Padding(4, 5, 4, 5);
            panelIniciar.Name = "panelIniciar";
            panelIniciar.Size = new Size(607, 1012);
            panelIniciar.TabIndex = 11;
            // 
            // iconUser
            // 
            iconUser.BackColor = Color.White;
            iconUser.ForeColor = Color.MidnightBlue;
            iconUser.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconUser.IconColor = Color.MidnightBlue;
            iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUser.IconSize = 210;
            iconUser.Location = new Point(224, 63);
            iconUser.Margin = new Padding(4, 5, 4, 5);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(210, 240);
            iconUser.TabIndex = 12;
            iconUser.TabStop = false;
            // 
            // btn2nousar
            // 
            btn2nousar.BackColor = Color.MidnightBlue;
            btn2nousar.Enabled = false;
            btn2nousar.Location = new Point(86, 598);
            btn2nousar.Margin = new Padding(4, 5, 4, 5);
            btn2nousar.Name = "btn2nousar";
            btn2nousar.Size = new Size(464, 3);
            btn2nousar.TabIndex = 11;
            btn2nousar.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ControlText;
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(200, 853);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(244, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste la Contraseña?";
            // 
            // no
            // 
            no.BackColor = Color.MidnightBlue;
            no.Enabled = false;
            no.Location = new Point(86, 463);
            no.Margin = new Padding(4, 5, 4, 5);
            no.Name = "no";
            no.Size = new Size(464, 3);
            no.TabIndex = 8;
            no.Text = "button1";
            no.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.MidnightBlue;
            txtContraseña.Location = new Point(86, 530);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(496, 64);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "Contraseña";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // textIngresarUsuario
            // 
            textIngresarUsuario.BackColor = Color.White;
            textIngresarUsuario.BorderStyle = BorderStyle.None;
            textIngresarUsuario.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textIngresarUsuario.ForeColor = Color.MidnightBlue;
            textIngresarUsuario.Location = new Point(86, 395);
            textIngresarUsuario.Margin = new Padding(4, 5, 4, 5);
            textIngresarUsuario.Name = "textIngresarUsuario";
            textIngresarUsuario.Size = new Size(464, 64);
            textIngresarUsuario.TabIndex = 1;
            textIngresarUsuario.Text = "Usuario";
            textIngresarUsuario.Enter += textIngresarUsuario_Enter;
            textIngresarUsuario.Leave += textIngresarUsuario_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.MidnightBlue;
            btnIngresar.Location = new Point(200, 727);
            btnIngresar.Margin = new Padding(4, 5, 4, 5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(210, 67);
            btnIngresar.TabIndex = 3;
            btnIngresar.TabStop = false;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // FrmIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1413, 1270);
            Controls.Add(panelIniciar);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmIniciarSesion";
            Text = "FrmIniciarSesion";
            Load += FrmIniciarSesion_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).EndInit();
            panelIniciar.ResumeLayout(false);
            panelIniciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconUsuario;
        private Button BtnEntrarUsuario;
        private TextBox txtUsuario;
        private Button btnnousar;
        private Button button1;
        private TextBox textBox1;
        private Panel panelIniciar;
        private LinkLabel linkLabel1;
        private Button no;
        private TextBox txtContraseña;
        private TextBox textIngresarUsuario;
        private Button btnIngresar;
        private Button btn2nousar;
        private FontAwesome.Sharp.IconPictureBox iconUser;
    }
}