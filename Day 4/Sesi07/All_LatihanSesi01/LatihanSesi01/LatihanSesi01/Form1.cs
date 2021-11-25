using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanSesi01
{
    public partial class Form1 : Form
    {
        config db = new config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnForm1Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnForm1Login_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM 'user_info' where 'username='" + txtBoxForm1Username.Text + "' and password ='" + txtBoxForm1Password.Text + "'");

            if (db.Count()==1)
            {
                MessageBox.Show("Success You Will Login as" + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void btnForm1Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
