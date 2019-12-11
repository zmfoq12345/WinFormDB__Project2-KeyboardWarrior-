namespace WinFormDB__Project2_KeyboardWarrior_
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.mode = new System.Windows.Forms.Label();
            this.btn_signin = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormDB__Project2_KeyboardWarrior_.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(571, 308);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(151, 21);
            this.tb_id.TabIndex = 2;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.SystemColors.Window;
            this.lb_id.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_id.Location = new System.Drawing.Point(519, 309);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(46, 20);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "ID : ";
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.BackColor = System.Drawing.SystemColors.Window;
            this.lb_pw.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_pw.Location = new System.Drawing.Point(507, 352);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(59, 20);
            this.lb_pw.TabIndex = 5;
            this.lb_pw.Text = "PW : ";
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(571, 351);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(151, 21);
            this.tb_pw.TabIndex = 4;
            this.tb_pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pw_KeyPress);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Gray;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_login.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(571, 408);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(151, 47);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.BackColor = System.Drawing.SystemColors.Window;
            this.mode.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mode.Location = new System.Drawing.Point(600, 270);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(90, 21);
            this.mode.TabIndex = 10;
            this.mode.Text = "로그인하기";
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.White;
            this.btn_signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_signin.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_signin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_signin.Location = new System.Drawing.Point(99, 352);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(151, 32);
            this.btn_signin.TabIndex = 8;
            this.btn_signin.Text = "회원가입";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.SystemColors.Window;
            this.lb_name.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_name.Location = new System.Drawing.Point(488, 391);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(78, 20);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Name : ";
            this.lb_name.Visible = false;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(571, 390);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(151, 21);
            this.tb_name.TabIndex = 7;
            this.tb_name.Visible = false;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 516);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_pw);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label mode;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
    }
}