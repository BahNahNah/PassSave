using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PassSave
{
    public partial class LoadVaultForm : Form
    {
        private PasswordData[] pwdList;
        private string gPassword;
        public string GlobalPassword
        {
            get { return gPassword; }
        }
        public PasswordData[] Passwords
        {
            get { return pwdList; }
        }
        private string valutFile;
        public LoadVaultForm(string vFile)
        {
            valutFile = vFile;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!File.Exists(valutFile))
            {
                MessageBox.Show("Vault file has been deleted!");
                Environment.Exit(0);
                return;
            }
            try
            {
                gPassword = textBox1.Text;
                byte[] VaultBytes = File.ReadAllBytes(valutFile);
                byte[] decryptedVault = SimpleCryptography.DecryptBytes(VaultBytes, gPassword);
                using (MemoryStream ms = new MemoryStream(decryptedVault))
                {
                    XDocument xDoc = XDocument.Load(ms);
                    List<PasswordData> pwList = new List<PasswordData>();
                    foreach (var el in xDoc.Descendants("vault").Descendants("dat"))
                    {
                        PasswordData pwd = new PasswordData(el.Element("username").Value, el.Element("password").Value, el.Element("website").Value);
                        pwList.Add(pwd);
                    }
                    pwdList = pwList.ToArray();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Bad password.");
            }
        }
    }
}
