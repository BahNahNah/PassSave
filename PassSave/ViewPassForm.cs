using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassSave
{
    public partial class ViewPassForm : Form
    {
        private PasswordData pwd;
        public ViewPassForm(PasswordData p)
        {
            pwd = p;
            InitializeComponent();
        }

        private void ViewPassForm_Load(object sender, EventArgs e)
        {
            uTxtBox.Text = pwd.Username;
            pTxtbox.Text = pwd.Password;
            wTxtBox.Text = pwd.Website;
        }

        private void wTxtBox_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pTxtbox_MouseEnter(object sender, EventArgs e)
        {
            pTxtbox.UseSystemPasswordChar = false;
        }

        private void pTxtbox_MouseLeave(object sender, EventArgs e)
        {
            pTxtbox.UseSystemPasswordChar = true;
        }
    }
}
