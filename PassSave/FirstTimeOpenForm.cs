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
    public partial class FirstTimeOpenForm : Form
    {
        private string _pw;
        public string GlobalPassword
        {
            get { return _pw; }
        }
        public FirstTimeOpenForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("Enter a password.");
                return;
            }
            _pw = textBox1.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FirstTimeOpenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
