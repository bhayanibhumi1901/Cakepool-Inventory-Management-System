namespace Cakepool_Inventory_System
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.CakepoolLogo = new System.Windows.Forms.PictureBox();
            this.AdminLogo = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.ForgotPass = new System.Windows.Forms.LinkLabel();
            this.SignIn = new System.Windows.Forms.Button();
            this.UserLogo = new System.Windows.Forms.PictureBox();
            this.PassLogo = new System.Windows.Forms.PictureBox();
            this.PassVisibilityCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CakepoolLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Maroon;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1237, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 39);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CakepoolLogo
            // 
            this.CakepoolLogo.BackColor = System.Drawing.Color.Transparent;
            this.CakepoolLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CakepoolLogo.BackgroundImage")));
            this.CakepoolLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CakepoolLogo.Location = new System.Drawing.Point(12, 12);
            this.CakepoolLogo.Name = "CakepoolLogo";
            this.CakepoolLogo.Size = new System.Drawing.Size(280, 84);
            this.CakepoolLogo.TabIndex = 1;
            this.CakepoolLogo.TabStop = false;
            // 
            // AdminLogo
            // 
            this.AdminLogo.BackColor = System.Drawing.Color.Transparent;
            this.AdminLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminLogo.BackgroundImage")));
            this.AdminLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdminLogo.Location = new System.Drawing.Point(911, 67);
            this.AdminLogo.Name = "AdminLogo";
            this.AdminLogo.Size = new System.Drawing.Size(134, 113);
            this.AdminLogo.TabIndex = 2;
            this.AdminLogo.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(778, 213);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(140, 27);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username :";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(778, 298);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(135, 27);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password :";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.Location = new System.Drawing.Point(783, 243);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(391, 33);
            this.UserTextBox.TabIndex = 5;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox.Location = new System.Drawing.Point(783, 328);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(391, 33);
            this.PassTextBox.TabIndex = 6;
            this.PassTextBox.UseSystemPasswordChar = true;
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            // 
            // ForgotPass
            // 
            this.ForgotPass.AutoSize = true;
            this.ForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPass.LinkColor = System.Drawing.Color.Yellow;
            this.ForgotPass.Location = new System.Drawing.Point(1029, 374);
            this.ForgotPass.Name = "ForgotPass";
            this.ForgotPass.Size = new System.Drawing.Size(145, 17);
            this.ForgotPass.TabIndex = 7;
            this.ForgotPass.TabStop = true;
            this.ForgotPass.Text = "Forgot Password ?";
            this.ForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPass_LinkClicked);
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Green;
            this.SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.Location = new System.Drawing.Point(783, 418);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(391, 38);
            this.SignIn.TabIndex = 9;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // UserLogo
            // 
            this.UserLogo.BackColor = System.Drawing.Color.Transparent;
            this.UserLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserLogo.BackgroundImage")));
            this.UserLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserLogo.Location = new System.Drawing.Point(739, 243);
            this.UserLogo.Name = "UserLogo";
            this.UserLogo.Size = new System.Drawing.Size(38, 33);
            this.UserLogo.TabIndex = 10;
            this.UserLogo.TabStop = false;
            // 
            // PassLogo
            // 
            this.PassLogo.BackColor = System.Drawing.Color.Transparent;
            this.PassLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PassLogo.BackgroundImage")));
            this.PassLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PassLogo.Location = new System.Drawing.Point(739, 328);
            this.PassLogo.Name = "PassLogo";
            this.PassLogo.Size = new System.Drawing.Size(38, 33);
            this.PassLogo.TabIndex = 11;
            this.PassLogo.TabStop = false;
            // 
            // PassVisibilityCheck
            // 
            this.PassVisibilityCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.PassVisibilityCheck.AutoSize = true;
            this.PassVisibilityCheck.BackColor = System.Drawing.Color.White;
            this.PassVisibilityCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PassVisibilityCheck.BackgroundImage")));
            this.PassVisibilityCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PassVisibilityCheck.FlatAppearance.BorderSize = 0;
            this.PassVisibilityCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassVisibilityCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassVisibilityCheck.Location = new System.Drawing.Point(1137, 328);
            this.PassVisibilityCheck.Name = "PassVisibilityCheck";
            this.PassVisibilityCheck.Size = new System.Drawing.Size(34, 30);
            this.PassVisibilityCheck.TabIndex = 12;
            this.PassVisibilityCheck.Text = "   ";
            this.PassVisibilityCheck.UseVisualStyleBackColor = false;
            this.PassVisibilityCheck.CheckedChanged += new System.EventHandler(this.PassVisibilityCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 668);
            this.Controls.Add(this.PassVisibilityCheck);
            this.Controls.Add(this.PassLogo);
            this.Controls.Add(this.UserLogo);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.ForgotPass);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.AdminLogo);
            this.Controls.Add(this.CakepoolLogo);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CakepoolLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox CakepoolLogo;
        private System.Windows.Forms.PictureBox AdminLogo;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.LinkLabel ForgotPass;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.PictureBox UserLogo;
        private System.Windows.Forms.PictureBox PassLogo;
        private System.Windows.Forms.CheckBox PassVisibilityCheck;
    }
}

