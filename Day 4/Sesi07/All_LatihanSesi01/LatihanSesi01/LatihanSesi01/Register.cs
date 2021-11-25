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
    public partial class Register : Form
    {
        config db = new config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db.Execute("insert into user_info(names,username,password) values('" + txtBoxRegisterNama.Text + "','" + txtBoxRegisterUsername.Text + "','" + txtBoxRegisterPassword.Text + "');");
        }
    }
}
