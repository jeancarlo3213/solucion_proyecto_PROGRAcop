using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Frontend_tipo_usuario
{
    public partial class tipo_usuario : Form
    {


        public tipo_usuario()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int iparam);

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

        }

        private void HORAFECHA_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();  
        }

        private void tipo_usuario_Load(object sender, EventArgs e)
        {

        }

        private void tipo_usuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_estudiante_Click(object sender, EventArgs e)
        {

        }

        private void btn_estudiante_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Frontend_menu_estudiante.Menu_estudiante menu_Estudiante =new Frontend_menu_estudiante.Menu_estudiante();
            menu_Estudiante.FormClosed += (s, args) => this.Show();
            menu_Estudiante.ShowDialog();
        }

        private void btn_ADMINISTRADOR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontend_login_admin.Form1 form = new Frontend_login_admin.Form1();
            form.FormClosed += (s, args) => this.Show();
            form.ShowDialog();

        }

        private void maximizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_maximizar.Visible = true;
            btn_restaurar.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restaurar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
