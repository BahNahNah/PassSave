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
    public partial class AddNewPasswordForm : Form
    {
        private PasswordData _pwd;
        public PasswordData PassData
        {
            get { return _pwd; }
        }
        public AddNewPasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(unTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Enter a username!");
                return;
            }
            _pwd = new PasswordData(unTxtBox.Text, psTxtBox.Text, wbTxtBox.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
