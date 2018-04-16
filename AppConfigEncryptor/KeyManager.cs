using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace AppConfigEncryptor
{
    public partial class KeyManager : Form
    {
        public KeyManager()
        {
            InitializeComponent();
        }

        private void KeyManager_Load(object sender, EventArgs e)
        {
            PopulateAspNetRegIisRuntimes();

            LoadKeyContainers();
        }

        private void PopulateAspNetRegIisRuntimes()
        {
            //Detect runtime version
            //REF http://west-wind.com/weblog/posts/1646.aspx
            RegistryKey reg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\ASP.NET");
            string[] versions = reg.GetSubKeyNames();
            foreach (string ver in versions)
            {
                //Skip v1.1
                if (ver.StartsWith("1.1")) continue;
                RadioButton rb = new RadioButton();
                rb.Text = ver;
                string path = Convert.ToString(reg.OpenSubKey(ver).GetValue("Path"));
                if (string.IsNullOrEmpty(path)) continue;
                rb.Tag = path;
                if (File.Exists(Path.Combine(path, "aspnet_regiis.exe")))
                    flpVersions.Controls.Add(rb);
            }
                    (flpVersions.Controls[versions.Length - 1] as RadioButton).Checked = true;
        }

        private void LoadKeyContainers()
        {
            cbxContanerKeys.DataSource = CmdHelper.GetKeyContainers();
        }

        private string getAspNetRegIisPath()
        {
            foreach (RadioButton rb in flpVersions.Controls)
            {
                if (rb.Checked)
                    return Path.Combine(rb.Tag.ToString(), "aspnet_regiis.exe");
            }
            throw new ApplicationException("No aspnet_regiis.exe is available!");
        }

        private bool containerNameValid()
        {
            if (string.IsNullOrEmpty(txtContainerName.Text))
            {
                MessageBox.Show("Please input container name!");
                return false;
            }
            else return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!containerNameValid()) return;
            string res = CmdHelper.Shell(getAspNetRegIisPath(), string.Format("-pc \"{0}\" -exp", txtContainerName.Text));
            txtResult.Text = res;
        }

        private void btbDelete_Click(object sender, EventArgs e)
        {
            if (!containerNameValid()) return;
            if (MessageBox.Show(string.Format(
                "Deleting key container may cause web.config unable to be decrypted, \nAre you sure to delete '{0}'?",
                txtContainerName.Text),
                "Delete Confirmation", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.No) return;
            string res = CmdHelper.Shell(getAspNetRegIisPath(), string.Format("-pz \"{0}\"", txtContainerName.Text));
            txtResult.Text = res;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!containerNameValid()) return;
            saveFileDialog1.Filter = "XML|*.xml";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string res = CmdHelper.Shell(getAspNetRegIisPath(), string.Format("-px \"{0}\" \"{1}\" -pri",
                    txtContainerName.Text, saveFileDialog1.FileName));
                txtResult.Text = res;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!containerNameValid()) return;
            openFileDialog1.Filter = "XML|*.xml";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string res = CmdHelper.Shell(getAspNetRegIisPath(), string.Format("-pi \"{0}\" \"{1}\"",
                    txtContainerName.Text, openFileDialog1.FileName));
                txtResult.Text = res;
            }
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            if (!containerNameValid()) return;
            string res = CmdHelper.Shell(getAspNetRegIisPath(), string.Format("-pa \"{0}\" \"{1}\"",
                txtContainerName.Text, txtIdentity.Text));
            txtResult.Text = res;
        }
    }
}