namespace GestorMedico
{
    partial class Login
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
            label1 = new Label();
            txtuser = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtpass = new TextBox();
            linkLabel1 = new LinkLabel();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(161, 191);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 1;
            label1.Text = "Acceso";
            // 
            // txtuser
            // 
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtuser.ForeColor = Color.Silver;
            txtuser.Location = new Point(70, 253);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(303, 24);
            txtuser.TabIndex = 2;
            txtuser.Text = "Usuario";
            txtuser.Enter += textBox1_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close_window;
            pictureBox1.Location = new Point(409, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.minimize_window;
            pictureBox2.Location = new Point(383, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtpass
            // 
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.ForeColor = Color.Silver;
            txtpass.Location = new Point(70, 283);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(303, 24);
            txtpass.TabIndex = 5;
            txtpass.Text = "Contraseña";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(175, 310);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 14);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Crear usuario";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logos;
            pictureBox3.Location = new Point(70, 61);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(303, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 68, 52);
            button1.FlatAppearance.BorderColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(168, 361);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 7;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 114, 63);
            ClientSize = new Size(439, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(txtpass);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtuser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtuser;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtpass;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox3;
        private Button button1;
    }
}