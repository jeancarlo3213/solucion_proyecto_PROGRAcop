using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Frontend_login_admin
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int iparam);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_USUARIO_admin_Enter(object sender, EventArgs e)
        {
            if (txt_USUARIO_admin.Text == "USUARIO")
            {
                txt_USUARIO_admin.Text = "";
                txt_USUARIO_admin.ForeColor = Color.LightGray;
            }
        }

        private void txt_USUARIO_admin_Leave(object sender, EventArgs e)
        {
            if (txt_USUARIO_admin.Text == "")
            {
                txt_USUARIO_admin.Text = "USUARIO";
                txt_USUARIO_admin.ForeColor = Color.DimGray;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_pass_admin_Enter(object sender, EventArgs e)
        {
            if (txt_pass_admin.Text == "CONTRASEÑA")
            {
                txt_pass_admin.Text = "";
                txt_pass_admin.ForeColor = Color.LightGray;
                txt_pass_admin.UseSystemPasswordChar = true;
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_pass_admin_Leave(object sender, EventArgs e)
        {
            if (txt_pass_admin.Text == "")
            {
                txt_pass_admin.Text = "CONTRASEÑA";
                txt_pass_admin.ForeColor = Color.DimGray;
                txt_pass_admin.UseSystemPasswordChar = false;
            }

        }

        private void btn_accederadmin_Click(object sender, EventArgs e)
        {
            string usuario = txt_USUARIO_admin.Text;
            string contrasena = txt_pass_admin.Text;

            // Validar campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingresa tanto el nombre de usuario como la contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario == "GRUPO 6" && contrasena == "4")
            {
                // Acceso autorizado, puedes abrir la siguiente ventana o realizar acciones necesarias.
                MessageBox.Show("Acceso autorizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_pass_admin.Text = "";
                txt_USUARIO_admin.Text = "";
                this.Hide();
                frontend_menu_admin.menuadmin menuadmin = new frontend_menu_admin.menuadmin();  
                menuadmin.FormClosed += (s, args) => this.Show();
                menuadmin.ShowDialog();
            }
            else
            {
                // Acceso no autorizado, muestra un mensaje de error.
                MessageBox.Show("Usuario o contraseña incorrectos. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
