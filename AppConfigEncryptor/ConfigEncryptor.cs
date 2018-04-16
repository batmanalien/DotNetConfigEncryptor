using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppConfigEncryptor
{
    public partial class ConfigEncryptor : Form
    {
        public ConfigEncryptor()
        {
            InitializeComponent();
        }

        private void ConfigEncryptor_Load(object sender, EventArgs e)
        {
            LoadKeyContainers();
        }

        private void LoadKeyContainers()
        {
            cbxContanerKeys.DataSource = CmdHelper.GetKeyContainers();
        }

        private Configuration _currentConfiguration = null;
        private string _currentFileName;

        private void chgEncryptButtonStatus()
        {
            btnEncrypt.Enabled = false;
            if (_currentConfiguration == null) return;
            ConfigurationSection cnStrSec =
                _currentConfiguration.ConnectionStrings;
            if (cnStrSec != null)
            {
                btnEncrypt.Enabled = true;
                btnEncrypt.Text = cnStrSec.SectionInformation.IsProtected ?
                    "Decrypt" :
                    "Encrypt";
            }
        }

        private void cbxConfigSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbxConfigSections.SelectedItem.ToString());
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (_currentConfiguration == null) return;
            try
            {
                XElement xdoc = XElement.Load(_currentFileName);
                var configProtectedDataSection = xdoc.Elements().Where(x => x.Name == "configProtectedData");
                var providerName = configProtectedDataSection.Descendants("add").First().Attribute("name").Value;
                var keyContainerName = configProtectedDataSection.Descendants("add").First().Attribute("keyContainerName").Value;

                string res = CmdHelper.Shell(CmdHelper.GetAspNetRegIisPath(), $"-pef {cbxConfigSections.SelectedValue} {Path.GetDirectoryName(_currentFileName)} -prov {providerName}");
                txtOutput.Text += res + Environment.NewLine;

                //ConfigurationSection currSection = currConf.ConnectionStrings;
                //ConfigurationSection currSection = _currentConfiguration.GetSection(cbxConfigSections.SelectedItem.ToString());
                //string keyContainerName = txtKeyContainerName.Text;
                //if (string.IsNullOrEmpty(keyContainerName))
                //    keyContainerName = "RsaProtectedConfigurationProvider";
                //else
                //{
                //    //Create custom provider
                //    ProtectedConfigurationSection pdSec = _currentConfiguration.GetSection("configProtectedData") as ProtectedConfigurationSection;
                //    if (pdSec == null)
                //    {
                //        pdSec = new ProtectedConfigurationSection();
                //        _currentConfiguration.Sections.Add("configProtectedData", pdSec);
                //    }
                //    bool found = false;
                //    foreach (ProviderSettings p in pdSec.Providers)
                //        if (p.Name == keyContainerName) found = true;
                //    if (!found)
                //    {
                //        ProviderSettings ps = new ProviderSettings
                //        {
                //            Name = keyContainerName,
                //            Type = "System.Configuration.RsaProtectedConfigurationProvider"
                //        };
                //        ps.Parameters.Add("keyContainerName", keyContainerName);
                //        ps.Parameters.Add("useMachineContainer", "true");
                //        pdSec.Providers.Add(ps);
                //        //Note: A new key container will be created silently, if the key container name doesn't exist.
                //        //      But the auto created key container is not exportable and inappropriate for shared key among
                //        //      web farm servers.  Please use RSA key manager to create exportable key container for web farm
                //        //      scenarios.
                //    }
                //}

                //if (btnExecute.Text == "Encrypt")
                //    currSection.SectionInformation.ProtectSection(keyContainerName);
                //else
                //    currSection.SectionInformation.UnprotectSection();
                //_currentConfiguration.Save(ConfigurationSaveMode.Full);
                wbEditor.Navigate(_currentFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (_currentConfiguration == null) return;
            try
            {
                string res = CmdHelper.Shell(CmdHelper.GetAspNetRegIisPath(), $"-pdf {cbxConfigSections.SelectedValue} {Path.GetDirectoryName(_currentFileName)}");
                txtOutput.Text += res + Environment.NewLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnManageKeys_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager();
            km.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            wbEditor.Navigate(_currentFileName);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "notepad.exe";
            p.StartInfo.Arguments = _currentFileName;
            p.Start();
        }

        private void btnBrowseConfigFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CONFIG|*.config";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string openFileDialogFileName = openFileDialog.FileName;

                    //Rename it to 'web.config' if it is not named 'web.config'
                    if (!openFileDialogFileName.Equals("web.config", StringComparison.CurrentCultureIgnoreCase))
                    {

                        string destFileName = Path.Combine(Path.GetDirectoryName(openFileDialogFileName), "web.config");
                        if (File.Exists(destFileName))
                            File.Delete(destFileName);
                        File.Move(openFileDialogFileName, destFileName);
                        _currentFileName = destFileName;
                    }
                    else
                    {
                        _currentFileName = openFileDialogFileName;
                    }

                    lblConfigFilePath.Text = _currentFileName;

                    _currentConfiguration = ConfigurationManager.OpenExeConfiguration(_currentFileName);

                    //XDocument xdoc = XDocument.Load(fileName);
                    //var configSections = xdoc.Root.DescendantNodes()
                    //            .Where(x => x.Parent.Name.LocalName == "configuration")
                    //            .Select(x => ((XElement)x).Name.ToString()).ToList();

                    XElement xdoc = XElement.Load(_currentFileName);
                    var configSections = xdoc.Elements().Where(x => x.Parent.Name.LocalName == "configuration").Select(x => x.Name).ToList();
                    cbxConfigSections.DataSource = configSections;


                    wbEditor.Navigate(_currentFileName);

                    if (!configSections.Any(x => x.LocalName == "configProtectedData"))
                    {
                        MessageBox.Show("There is no configProtectedData in the config file");
                    }
                    else
                    {
                        var configProtectedDataSection = xdoc.Elements().Where(x => x.Name == "configProtectedData");
                        var providerName = configProtectedDataSection.Descendants("add").First().Attribute("name").Value;
                        var keyContainerName = configProtectedDataSection.Descendants("add").First().Attribute("keyContainerName").Value;
                        txtProviderName.Text = providerName;
                        txtKeyContainerName.Text = keyContainerName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbxKeyContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtKeyContainerName.Text = cbxContanerKeys.SelectedValue.ToString();
        }

        private void btnTestEncryptedConfig_Click(object sender, EventArgs e)
        {
            string email = ConfigurationManager.AppSettings["Email"];
            txtOutput.Text += "AppSetting Email = " + email + Environment.NewLine;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            txtOutput.Text += "Connection String = " + connectionString;
        }

        private void ConfigEncryptor_FormClosed(object sender, FormClosedEventArgs e)
        {
            string exePath = System.Reflection.Assembly.GetEntryAssembly().Location;
            string destFileName = exePath + ".config";
            if (_currentFileName != null && destFileName != null)
                File.Move(_currentFileName, destFileName);
        }
    }
}