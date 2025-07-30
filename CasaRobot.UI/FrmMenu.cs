using CasaRobot.UI.Forms;
using FontAwesome.Sharp;
namespace CasaRobot.UI
{
    public partial class FrmMenu : Form
    {
        private IconButton currenBtn;
        private Panel leftBordBtn;
        private Form currentChildForm;
        public FrmMenu()
        {
            InitializeComponent();
            leftBordBtn = new Panel();
            leftBordBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBordBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(200, 170, 250);
            public static Color color2 = Color.FromArgb(255, 170, 200);
            public static Color color3 = Color.FromArgb(255, 180, 160);
            public static Color color4 = Color.FromArgb(160, 140, 255);
            public static Color color5 = Color.FromArgb(255, 160, 200);
            public static Color color6 = Color.FromArgb(180, 240, 200);

        }

        private void activatebutton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currenBtn = (IconButton)senderBtn;
                currenBtn.BackColor = Color.FromArgb(37, 36, 81);
                currenBtn.ForeColor = color;
                currenBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenBtn.IconColor = color;
                currenBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBordBtn.BackColor = color;
                leftBordBtn.Location = new Point(0, currenBtn.Location.Y);
                leftBordBtn.Visible = true;
                leftBordBtn.BringToFront();
                IconoCurrentChildForm.IconChar = currenBtn.IconChar;
                IconoCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currenBtn != null)
            {
                currenBtn.BackColor = Color.FromArgb(31, 30, 68);
                currenBtn.ForeColor = Color.Gainsboro;
                currenBtn.TextAlign = ContentAlignment.MiddleLeft;
                currenBtn.IconColor = Color.Gainsboro;
                currenBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {


        }



        private void btnBuscarEquipos_Click(object sender, EventArgs e)
        {

        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBordBtn.Visible = false;
            IconoCurrentChildForm.IconChar = IconChar.Home;
            IconoCurrentChildForm.IconColor = Color.DeepSkyBlue;
            lblTitleChildForm.Text = "Inicio";

        }
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            //  ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBarra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
        //ctivatebutton(sender, RGBColors.color6);
        //OpenChildForm(new FrmIngresarEquipos());
        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btMClientes_Click(object sender, EventArgs e)
        {
            activatebutton(sender, RGBColors.color6);
            OpenChildForm(new ClientesForm());
        }

        private void btMEquipos_Click(object sender, EventArgs e)
        {
            activatebutton(sender, RGBColors.color6);
            OpenChildForm(new EquiposForm());
        }

        private void btMOrdenServicio_Click(object sender, EventArgs e)
        {
            activatebutton(sender, RGBColors.color6);
            OpenChildForm(new OrdenesServicioForm());
        }

        private void btMEmpleados_Click(object sender, EventArgs e)
        {
            activatebutton(sender, RGBColors.color6);
            OpenChildForm(new EmpleadosForm());
        }

        private void btMEstados_Click(object sender, EventArgs e)
        {
            activatebutton(sender, RGBColors.color6);
            OpenChildForm(new EstadosForm());
        }

        private void btMCostos_Click(object sender, EventArgs e)
        {
            activatebutton(sender, RGBColors.color6);
            OpenChildForm(new CostosForm());
        }

        private void btMHistorial_Click(object sender, EventArgs e)
        {
            activatebutton(sender, RGBColors.color6);
            OpenChildForm(new HistorialForm());
        }

        private void btMMetodoPago_Click(object sender, EventArgs e)
        {
            activatebutton(sender, RGBColors.color6);
            OpenChildForm(new MetodosPagoForm());
        }
    }
}
