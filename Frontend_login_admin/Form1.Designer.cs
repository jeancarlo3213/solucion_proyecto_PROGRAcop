namespace Frontend_login_admin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_pass_admin = new System.Windows.Forms.TextBox();
            this.txt_USUARIO_admin = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Label();
            this.btn_accederadmin = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Frontend_login_admin.Properties.Resources.umg;
            this.pictureBox1.Location = new System.Drawing.Point(55, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_pass_admin
            // 
            this.txt_pass_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_pass_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass_admin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_admin.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pass_admin.Location = new System.Drawing.Point(322, 189);
            this.txt_pass_admin.Name = "txt_pass_admin";
            this.txt_pass_admin.Size = new System.Drawing.Size(386, 30);
            this.txt_pass_admin.TabIndex = 3;
            this.txt_pass_admin.Text = "CONTRASEÑA";
            this.txt_pass_admin.Enter += new System.EventHandler(this.txt_pass_admin_Enter);
            this.txt_pass_admin.Leave += new System.EventHandler(this.txt_pass_admin_Leave);
            // 
            // txt_USUARIO_admin
            // 
            this.txt_USUARIO_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_USUARIO_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_USUARIO_admin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_USUARIO_admin.ForeColor = System.Drawing.Color.DimGray;
            this.txt_USUARIO_admin.Location = new System.Drawing.Point(322, 118);
            this.txt_USUARIO_admin.Name = "txt_USUARIO_admin";
            this.txt_USUARIO_admin.Size = new System.Drawing.Size(386, 30);
            this.txt_USUARIO_admin.TabIndex = 4;
            this.txt_USUARIO_admin.Text = "USUARIO";
            this.txt_USUARIO_admin.Enter += new System.EventHandler(this.txt_USUARIO_admin_Enter);
            this.txt_USUARIO_admin.Leave += new System.EventHandler(this.txt_USUARIO_admin_Leave);
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.ForeColor = System.Drawing.Color.DimGray;
            this.LOGIN.Location = new System.Drawing.Point(459, 9);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(151, 49);
            this.LOGIN.TabIndex = 5;
            this.LOGIN.Text = "LOGIN";
            // 
            // btn_accederadmin
            // 
            this.btn_accederadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_accederadmin.FlatAppearance.BorderSize = 0;
            this.btn_accederadmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_accederadmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_accederadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accederadmin.ForeColor = System.Drawing.Color.LightGray;
            this.btn_accederadmin.Location = new System.Drawing.Point(322, 245);
            this.btn_accederadmin.Name = "btn_accederadmin";
            this.btn_accederadmin.Size = new System.Drawing.Size(376, 40);
            this.btn_accederadmin.TabIndex = 6;
            this.btn_accederadmin.Text = "ACCEDER";
            this.btn_accederadmin.UseVisualStyleBackColor = false;
            this.btn_accederadmin.Click += new System.EventHandler(this.btn_accederadmin_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(743, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(36, 36);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(701, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(36, 36);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 8;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_accederadmin);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.txt_USUARIO_admin);
            this.Controls.Add(this.txt_pass_admin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pass_admin;
        private System.Windows.Forms.TextBox txt_USUARIO_admin;
        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_accederadmin;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox btn_minimizar;
    }
}