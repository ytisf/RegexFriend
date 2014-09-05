namespace RegexFriend
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.richInput = new System.Windows.Forms.RichTextBox();
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64EncodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64DecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRLEncodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRLDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preMadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mACAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRegex
            // 
            this.txtRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegex.Location = new System.Drawing.Point(3, 3);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(811, 30);
            this.txtRegex.TabIndex = 2;
            this.txtRegex.TextChanged += new System.EventHandler(this.txtRegex_TextChanged_1);
            // 
            // richInput
            // 
            this.richInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richInput.Location = new System.Drawing.Point(3, 3);
            this.richInput.Name = "richInput";
            this.richInput.Size = new System.Drawing.Size(402, 466);
            this.richInput.TabIndex = 3;
            this.richInput.Text = "";
            this.richInput.TextChanged += new System.EventHandler(this.richInput_TextChanged);
            // 
            // richOutput
            // 
            this.richOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richOutput.Location = new System.Drawing.Point(411, 3);
            this.richOutput.Name = "richOutput";
            this.richOutput.Size = new System.Drawing.Size(403, 466);
            this.richOutput.TabIndex = 4;
            this.richOutput.Text = "";
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStatus.Location = new System.Drawing.Point(3, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(811, 20);
            this.txtStatus.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.richInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richOutput, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 472);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtStatus, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 512);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(817, 28);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtRegex, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(817, 25);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.090374F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.90963F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(823, 543);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encodingToolStripMenuItem,
            this.preMadeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadInputToolStripMenuItem,
            this.saveOutputToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadInputToolStripMenuItem
            // 
            this.loadInputToolStripMenuItem.Name = "loadInputToolStripMenuItem";
            this.loadInputToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadInputToolStripMenuItem.Text = "Load Input";
            this.loadInputToolStripMenuItem.Click += new System.EventHandler(this.loadInputToolStripMenuItem_Click);
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveOutputToolStripMenuItem.Text = "Save Output";
            this.saveOutputToolStripMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.base64EncodeToolStripMenuItem,
            this.base64DecodeToolStripMenuItem,
            this.uRLEncodeToolStripMenuItem,
            this.uRLDecodeToolStripMenuItem});
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.encodingToolStripMenuItem.Text = "Encoding";
            // 
            // base64EncodeToolStripMenuItem
            // 
            this.base64EncodeToolStripMenuItem.Name = "base64EncodeToolStripMenuItem";
            this.base64EncodeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.base64EncodeToolStripMenuItem.Text = "Base64 Encode";
            this.base64EncodeToolStripMenuItem.Click += new System.EventHandler(this.base64EncodeToolStripMenuItem_Click);
            // 
            // base64DecodeToolStripMenuItem
            // 
            this.base64DecodeToolStripMenuItem.Name = "base64DecodeToolStripMenuItem";
            this.base64DecodeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.base64DecodeToolStripMenuItem.Text = "Base64 Decode";
            this.base64DecodeToolStripMenuItem.Click += new System.EventHandler(this.base64DecodeToolStripMenuItem_Click);
            // 
            // uRLEncodeToolStripMenuItem
            // 
            this.uRLEncodeToolStripMenuItem.Name = "uRLEncodeToolStripMenuItem";
            this.uRLEncodeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.uRLEncodeToolStripMenuItem.Text = "URL Encode";
            this.uRLEncodeToolStripMenuItem.Click += new System.EventHandler(this.uRLEncodeToolStripMenuItem_Click);
            // 
            // uRLDecodeToolStripMenuItem
            // 
            this.uRLDecodeToolStripMenuItem.Name = "uRLDecodeToolStripMenuItem";
            this.uRLDecodeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.uRLDecodeToolStripMenuItem.Text = "URL Decode";
            this.uRLDecodeToolStripMenuItem.Click += new System.EventHandler(this.uRLDecodeToolStripMenuItem_Click);
            // 
            // preMadeToolStripMenuItem
            // 
            this.preMadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPToolStripMenuItem,
            this.mACAddressesToolStripMenuItem,
            this.domainNamesToolStripMenuItem,
            this.eMailsToolStripMenuItem,
            this.fullNamesToolStripMenuItem,
            this.cheatSheetToolStripMenuItem});
            this.preMadeToolStripMenuItem.Name = "preMadeToolStripMenuItem";
            this.preMadeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.preMadeToolStripMenuItem.Text = "PreMade";
            // 
            // iPToolStripMenuItem
            // 
            this.iPToolStripMenuItem.Name = "iPToolStripMenuItem";
            this.iPToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.iPToolStripMenuItem.Text = "IP Addresses";
            this.iPToolStripMenuItem.Click += new System.EventHandler(this.iPToolStripMenuItem_Click);
            // 
            // mACAddressesToolStripMenuItem
            // 
            this.mACAddressesToolStripMenuItem.Name = "mACAddressesToolStripMenuItem";
            this.mACAddressesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.mACAddressesToolStripMenuItem.Text = "MAC Addresses";
            this.mACAddressesToolStripMenuItem.Click += new System.EventHandler(this.mACAddressesToolStripMenuItem_Click);
            // 
            // domainNamesToolStripMenuItem
            // 
            this.domainNamesToolStripMenuItem.Name = "domainNamesToolStripMenuItem";
            this.domainNamesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.domainNamesToolStripMenuItem.Text = "Domain Names";
            this.domainNamesToolStripMenuItem.Click += new System.EventHandler(this.domainNamesToolStripMenuItem_Click);
            // 
            // eMailsToolStripMenuItem
            // 
            this.eMailsToolStripMenuItem.Name = "eMailsToolStripMenuItem";
            this.eMailsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eMailsToolStripMenuItem.Text = "eMails";
            this.eMailsToolStripMenuItem.Click += new System.EventHandler(this.eMailsToolStripMenuItem_Click);
            // 
            // fullNamesToolStripMenuItem
            // 
            this.fullNamesToolStripMenuItem.Name = "fullNamesToolStripMenuItem";
            this.fullNamesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fullNamesToolStripMenuItem.Text = "Full Names";
            this.fullNamesToolStripMenuItem.Click += new System.EventHandler(this.fullNamesToolStripMenuItem_Click);
            // 
            // cheatSheetToolStripMenuItem
            // 
            this.cheatSheetToolStripMenuItem.Name = "cheatSheetToolStripMenuItem";
            this.cheatSheetToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cheatSheetToolStripMenuItem.Text = "Cheat Sheet";
            this.cheatSheetToolStripMenuItem.Click += new System.EventHandler(this.cheatSheetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 567);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "RegexFriend";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.RichTextBox richInput;
        private System.Windows.Forms.RichTextBox richOutput;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preMadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mACAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domainNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base64EncodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base64DecodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uRLEncodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uRLDecodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatSheetToolStripMenuItem;
    }
}

