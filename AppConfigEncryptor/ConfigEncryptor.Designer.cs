namespace AppConfigEncryptor
{
    partial class ConfigEncryptor
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblKeyContainers = new System.Windows.Forms.Label();
            this.cbxContanerKeys = new System.Windows.Forms.ComboBox();
            this.lblConfigSections = new System.Windows.Forms.Label();
            this.btnBrowseConfigFile = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyContainerName = new System.Windows.Forms.TextBox();
            this.btnManageKeys = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.wbEditor = new System.Windows.Forms.WebBrowser();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblConfigFilePath = new System.Windows.Forms.Label();
            this.cbxConfigSections = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.btnTestEncryptedConfig = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnTestEncryptedConfig);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtProviderName);
            this.pnlMain.Controls.Add(this.btnDecrypt);
            this.pnlMain.Controls.Add(this.txtOutput);
            this.pnlMain.Controls.Add(this.lblKeyContainers);
            this.pnlMain.Controls.Add(this.cbxContanerKeys);
            this.pnlMain.Controls.Add(this.lblConfigSections);
            this.pnlMain.Controls.Add(this.btnBrowseConfigFile);
            this.pnlMain.Controls.Add(this.btnReload);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtKeyContainerName);
            this.pnlMain.Controls.Add(this.btnManageKeys);
            this.pnlMain.Controls.Add(this.btnEdit);
            this.pnlMain.Controls.Add(this.wbEditor);
            this.pnlMain.Controls.Add(this.btnEncrypt);
            this.pnlMain.Controls.Add(this.lblConfigFilePath);
            this.pnlMain.Controls.Add(this.cbxConfigSections);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1319, 859);
            this.pnlMain.TabIndex = 6;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDecrypt.Location = new System.Drawing.Point(309, 51);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(88, 35);
            this.btnDecrypt.TabIndex = 18;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(18, 486);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1288, 361);
            this.txtOutput.TabIndex = 17;
            // 
            // lblKeyContainers
            // 
            this.lblKeyContainers.AutoSize = true;
            this.lblKeyContainers.Location = new System.Drawing.Point(14, 103);
            this.lblKeyContainers.Name = "lblKeyContainers";
            this.lblKeyContainers.Size = new System.Drawing.Size(238, 20);
            this.lblKeyContainers.TabIndex = 16;
            this.lblKeyContainers.Text = "Key Containers On This Machine";
            // 
            // cbxContanerKeys
            // 
            this.cbxContanerKeys.FormattingEnabled = true;
            this.cbxContanerKeys.Location = new System.Drawing.Point(258, 97);
            this.cbxContanerKeys.Name = "cbxContanerKeys";
            this.cbxContanerKeys.Size = new System.Drawing.Size(307, 28);
            this.cbxContanerKeys.TabIndex = 15;
            this.cbxContanerKeys.SelectedIndexChanged += new System.EventHandler(this.cbxKeyContainers_SelectedIndexChanged);
            // 
            // lblConfigSections
            // 
            this.lblConfigSections.AutoSize = true;
            this.lblConfigSections.Location = new System.Drawing.Point(839, 14);
            this.lblConfigSections.Name = "lblConfigSections";
            this.lblConfigSections.Size = new System.Drawing.Size(121, 20);
            this.lblConfigSections.TabIndex = 14;
            this.lblConfigSections.Text = "Config Sections";
            // 
            // btnBrowseConfigFile
            // 
            this.btnBrowseConfigFile.Location = new System.Drawing.Point(18, 11);
            this.btnBrowseConfigFile.Name = "btnBrowseConfigFile";
            this.btnBrowseConfigFile.Size = new System.Drawing.Size(193, 32);
            this.btnBrowseConfigFile.TabIndex = 13;
            this.btnBrowseConfigFile.Text = "Browse Config File";
            this.btnBrowseConfigFile.UseVisualStyleBackColor = true;
            this.btnBrowseConfigFile.Click += new System.EventHandler(this.btnBrowseConfigFile_Click);
            // 
            // btnReload
            // 
            this.btnReload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReload.Location = new System.Drawing.Point(116, 51);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(88, 35);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(839, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Key Container Name In Config";
            // 
            // txtKeyContainerName
            // 
            this.txtKeyContainerName.Location = new System.Drawing.Point(1060, 97);
            this.txtKeyContainerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeyContainerName.Name = "txtKeyContainerName";
            this.txtKeyContainerName.Size = new System.Drawing.Size(250, 26);
            this.txtKeyContainerName.TabIndex = 9;
            // 
            // btnManageKeys
            // 
            this.btnManageKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageKeys.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnManageKeys.Location = new System.Drawing.Point(591, 51);
            this.btnManageKeys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageKeys.Name = "btnManageKeys";
            this.btnManageKeys.Size = new System.Drawing.Size(194, 35);
            this.btnManageKeys.TabIndex = 8;
            this.btnManageKeys.Text = "Manage Key Containers";
            this.btnManageKeys.UseVisualStyleBackColor = true;
            this.btnManageKeys.Click += new System.EventHandler(this.btnManageKeys_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(18, 51);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 35);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // wbEditor
            // 
            this.wbEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbEditor.Location = new System.Drawing.Point(18, 128);
            this.wbEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wbEditor.MinimumSize = new System.Drawing.Size(30, 31);
            this.wbEditor.Name = "wbEditor";
            this.wbEditor.Size = new System.Drawing.Size(1288, 337);
            this.wbEditor.TabIndex = 6;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEncrypt.Location = new System.Drawing.Point(213, 51);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(88, 35);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblConfigFilePath
            // 
            this.lblConfigFilePath.AutoSize = true;
            this.lblConfigFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConfigFilePath.Location = new System.Drawing.Point(209, 17);
            this.lblConfigFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfigFilePath.Name = "lblConfigFilePath";
            this.lblConfigFilePath.Size = new System.Drawing.Size(292, 20);
            this.lblConfigFilePath.TabIndex = 1;
            this.lblConfigFilePath.Text = "Please select a App.config/Web.config...";
            // 
            // cbxConfigSections
            // 
            this.cbxConfigSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxConfigSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConfigSections.FormattingEnabled = true;
            this.cbxConfigSections.Location = new System.Drawing.Point(967, 9);
            this.cbxConfigSections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxConfigSections.Name = "cbxConfigSections";
            this.cbxConfigSections.Size = new System.Drawing.Size(339, 28);
            this.cbxConfigSections.TabIndex = 0;
            this.cbxConfigSections.SelectedIndexChanged += new System.EventHandler(this.cbxConfigSections_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(839, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Provider Name In Config";
            // 
            // txtProviderName
            // 
            this.txtProviderName.Location = new System.Drawing.Point(1060, 63);
            this.txtProviderName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(250, 26);
            this.txtProviderName.TabIndex = 19;
            // 
            // btnTestEncryptedConfig
            // 
            this.btnTestEncryptedConfig.Location = new System.Drawing.Point(404, 51);
            this.btnTestEncryptedConfig.Name = "btnTestEncryptedConfig";
            this.btnTestEncryptedConfig.Size = new System.Drawing.Size(180, 35);
            this.btnTestEncryptedConfig.TabIndex = 21;
            this.btnTestEncryptedConfig.Text = "Test Encrypted Config";
            this.btnTestEncryptedConfig.UseVisualStyleBackColor = true;
            this.btnTestEncryptedConfig.Click += new System.EventHandler(this.btnTestEncryptedConfig_Click);
            // 
            // ConfigEncryptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 859);
            this.Controls.Add(this.pnlMain);
            this.Name = "ConfigEncryptor";
            this.Text = "ConfigEncryptor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigEncryptor_FormClosed);
            this.Load += new System.EventHandler(this.ConfigEncryptor_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyContainerName;
        private System.Windows.Forms.Button btnManageKeys;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.WebBrowser wbEditor;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblConfigFilePath;
        private System.Windows.Forms.ComboBox cbxConfigSections;
        private System.Windows.Forms.Button btnBrowseConfigFile;
        private System.Windows.Forms.Label lblConfigSections;
        private System.Windows.Forms.Label lblKeyContainers;
        private System.Windows.Forms.ComboBox cbxContanerKeys;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Button btnTestEncryptedConfig;
    }
}