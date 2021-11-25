
namespace LatihanSesi01
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnForm1Register = new System.Windows.Forms.Button();
            this.btnForm1Exit = new System.Windows.Forms.Button();
            this.btnForm1Login = new System.Windows.Forms.Button();
            this.txtBoxForm1Password = new System.Windows.Forms.TextBox();
            this.txtBoxForm1Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnForm1Register);
            this.panel1.Controls.Add(this.btnForm1Exit);
            this.panel1.Controls.Add(this.btnForm1Login);
            this.panel1.Controls.Add(this.txtBoxForm1Password);
            this.panel1.Controls.Add(this.txtBoxForm1Username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Create an account with us? Click";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnForm1Register
            // 
            this.btnForm1Register.Location = new System.Drawing.Point(427, 352);
            this.btnForm1Register.Name = "btnForm1Register";
            this.btnForm1Register.Size = new System.Drawing.Size(75, 23);
            this.btnForm1Register.TabIndex = 6;
            this.btnForm1Register.Text = "Register";
            this.btnForm1Register.UseVisualStyleBackColor = true;
            this.btnForm1Register.Click += new System.EventHandler(this.btnForm1Register_Click);
            // 
            // btnForm1Exit
            // 
            this.btnForm1Exit.Location = new System.Drawing.Point(392, 264);
            this.btnForm1Exit.Name = "btnForm1Exit";
            this.btnForm1Exit.Size = new System.Drawing.Size(75, 23);
            this.btnForm1Exit.TabIndex = 5;
            this.btnForm1Exit.Text = "Exit";
            this.btnForm1Exit.UseVisualStyleBackColor = true;
            this.btnForm1Exit.Click += new System.EventHandler(this.btnForm1Exit_Click);
            // 
            // btnForm1Login
            // 
            this.btnForm1Login.Location = new System.Drawing.Point(227, 264);
            this.btnForm1Login.Name = "btnForm1Login";
            this.btnForm1Login.Size = new System.Drawing.Size(75, 23);
            this.btnForm1Login.TabIndex = 4;
            this.btnForm1Login.Text = "Login";
            this.btnForm1Login.UseVisualStyleBackColor = true;
            this.btnForm1Login.Click += new System.EventHandler(this.btnForm1Login_Click);
            // 
            // txtBoxForm1Password
            // 
            this.txtBoxForm1Password.Location = new System.Drawing.Point(288, 143);
            this.txtBoxForm1Password.Name = "txtBoxForm1Password";
            this.txtBoxForm1Password.Size = new System.Drawing.Size(238, 22);
            this.txtBoxForm1Password.TabIndex = 3;
            // 
            // txtBoxForm1Username
            // 
            this.txtBoxForm1Username.Location = new System.Drawing.Point(288, 74);
            this.txtBoxForm1Username.Name = "txtBoxForm1Username";
            this.txtBoxForm1Username.Size = new System.Drawing.Size(238, 22);
            this.txtBoxForm1Username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxForm1Password;
        private System.Windows.Forms.TextBox txtBoxForm1Username;
        private System.Windows.Forms.Button btnForm1Exit;
        private System.Windows.Forms.Button btnForm1Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnForm1Register;
    }
}

