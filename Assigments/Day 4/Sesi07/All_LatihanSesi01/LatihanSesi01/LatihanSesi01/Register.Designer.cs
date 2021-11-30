
namespace LatihanSesi01
{
    partial class Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRegisterNama = new System.Windows.Forms.TextBox();
            this.txtBoxRegisterUsername = new System.Windows.Forms.TextBox();
            this.txtBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegisterExit = new System.Windows.Forms.Button();
            this.btnRegisterLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRegisterLogin);
            this.panel1.Controls.Add(this.btnRegisterExit);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txtBoxRegisterPassword);
            this.panel1.Controls.Add(this.txtBoxRegisterUsername);
            this.panel1.Controls.Add(this.txtBoxRegisterNama);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtBoxRegisterNama
            // 
            this.txtBoxRegisterNama.Location = new System.Drawing.Point(283, 49);
            this.txtBoxRegisterNama.Name = "txtBoxRegisterNama";
            this.txtBoxRegisterNama.Size = new System.Drawing.Size(265, 22);
            this.txtBoxRegisterNama.TabIndex = 3;
            // 
            // txtBoxRegisterUsername
            // 
            this.txtBoxRegisterUsername.Location = new System.Drawing.Point(283, 119);
            this.txtBoxRegisterUsername.Name = "txtBoxRegisterUsername";
            this.txtBoxRegisterUsername.Size = new System.Drawing.Size(265, 22);
            this.txtBoxRegisterUsername.TabIndex = 4;
            // 
            // txtBoxRegisterPassword
            // 
            this.txtBoxRegisterPassword.Location = new System.Drawing.Point(283, 188);
            this.txtBoxRegisterPassword.Name = "txtBoxRegisterPassword";
            this.txtBoxRegisterPassword.Size = new System.Drawing.Size(265, 22);
            this.txtBoxRegisterPassword.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(208, 275);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRegisterExit
            // 
            this.btnRegisterExit.Location = new System.Drawing.Point(375, 275);
            this.btnRegisterExit.Name = "btnRegisterExit";
            this.btnRegisterExit.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterExit.TabIndex = 7;
            this.btnRegisterExit.Text = "Exit";
            this.btnRegisterExit.UseVisualStyleBackColor = true;
            this.btnRegisterExit.Click += new System.EventHandler(this.btnRegisterExit_Click);
            // 
            // btnRegisterLogin
            // 
            this.btnRegisterLogin.Location = new System.Drawing.Point(402, 350);
            this.btnRegisterLogin.Name = "btnRegisterLogin";
            this.btnRegisterLogin.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterLogin.TabIndex = 8;
            this.btnRegisterLogin.Text = "Login";
            this.btnRegisterLogin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Do you have an account? Click";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxRegisterPassword;
        private System.Windows.Forms.TextBox txtBoxRegisterUsername;
        private System.Windows.Forms.TextBox txtBoxRegisterNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegisterLogin;
        private System.Windows.Forms.Button btnRegisterExit;
        private System.Windows.Forms.Button btnRegister;
    }
}