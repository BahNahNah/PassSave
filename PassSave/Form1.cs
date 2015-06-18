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
using System.Xml;

namespace PassSave
{
    public partial class Form1 : Form
    {
        private string globalPassword;
        private string valutFileName = "vault.dat";
        PasswordData[] pwl = new PasswordData[]{};
        public Form1()
        {
            if (!File.Exists(valutFileName))
            {
                using(FirstTimeOpenForm ft = new FirstTimeOpenForm())
                {
                    if(ft.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    {
                        Environment.Exit(0);
                        return;
                    }
                    globalPassword = ft.GlobalPassword;
                }
            }
            else
            {
                using(LoadVaultForm lv = new LoadVaultForm(valutFileName))
                {
                    if(lv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        globalPassword = lv.GlobalPassword;
                        pwl = lv.Passwords;
                    }
                    else
                    {
                        Environment.Exit(0);
                        return;
                    }
                }
            }
            InitializeComponent();
            foreach(PasswordData pw in pwl)
            {
                ListViewItem i = new ListViewItem(pw.Username);
                i.Tag = pw;
                i.SubItems.Add(pw.Website);
                pwList.Items.Add(i);
            }
            pwl = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddNewPasswordForm pwf = new AddNewPasswordForm())
            {
                if(pwf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ListViewItem i = new ListViewItem(pwf.PassData.Username);
                    i.Tag = pwf.PassData;
                    i.SubItems.Add(pwf.PassData.Website);
                    pwList.Items.Add(i);
                    Save();
                }
            }
        }

        private void pwList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void pwList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pwList.SelectedItems.Count < 1)
                return;
            using(ViewPassForm vpf = new ViewPassForm((PasswordData)pwList.SelectedItems[0].Tag))
            {
                vpf.ShowDialog();
            }
        }


        void Save()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (XmlTextWriter xml = new XmlTextWriter(ms, Encoding.UTF8))
                {
                    xml.WriteStartDocument();

                    xml.WriteStartElement("vault");

                    foreach(ListViewItem i in pwList.Items)
                    {
                        PasswordData pwd = (PasswordData)i.Tag;
                        xml.WriteStartElement("dat");

                        xml.WriteStartElement("username");
                        xml.WriteCData(pwd.Username);
                        xml.WriteEndElement(); 

                        xml.WriteStartElement("password");
                        xml.WriteCData(pwd.Password);
                        xml.WriteEndElement(); 

                        xml.WriteStartElement("website");
                        xml.WriteCData(pwd.Website);
                        xml.WriteEndElement(); 

                        xml.WriteEndElement(); //dat
                    }

                    xml.WriteEndElement(); //vault
                    xml.WriteEndDocument();
                    xml.Flush();
                    xml.Close();
                }
                byte[] saveFileEncrypted = SimpleCryptography.EncryptBytes(ms.ToArray(), globalPassword);
                File.WriteAllBytes(valutFileName, saveFileEncrypted);
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = pwList.SelectedItems.Count < 1;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem i = pwList.SelectedItems[0];
            PasswordData pwd = (PasswordData)i.Tag;
            if(MessageBox.Show(string.Format("Username: {0}\nWebsite: {1}", pwd.Username, pwd.Website) , "Delete this password?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                pwList.Items.Remove(i);
                Save();
            }
        }
    }
}
