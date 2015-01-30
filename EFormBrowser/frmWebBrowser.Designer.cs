/*
    StinkyPete - IE7-based Web Browser
 
    Copyright (C) 2014  OneLink

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace EFormBrowser
{
    partial class frmWebBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebBrowser));
            this.wb = new System.Windows.Forms.WebBrowser();
            this.panelWb = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdForward = new System.Windows.Forms.Button();
            this.lblAlert = new System.Windows.Forms.Label();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdHome = new System.Windows.Forms.Button();
            this.chkWatch = new System.Windows.Forms.CheckBox();
            this.txtWatchPath = new System.Windows.Forms.TextBox();
            this.panelWb.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.Location = new System.Drawing.Point(0, 0);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(782, 497);
            this.wb.TabIndex = 0;
            this.wb.DocumentTitleChanged += new System.EventHandler(this.wb_DocumentTitleChanged);
            this.wb.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wb_Navigated);
            this.wb.StatusTextChanged += new System.EventHandler(this.wb_StatusTextChanged);
            // 
            // panelWb
            // 
            this.panelWb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWb.Controls.Add(this.wb);
            this.panelWb.Location = new System.Drawing.Point(1, 60);
            this.panelWb.Name = "panelWb";
            this.panelWb.Size = new System.Drawing.Size(782, 497);
            this.panelWb.TabIndex = 7;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(95, 8);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(533, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // cmdGo
            // 
            this.cmdGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGo.Location = new System.Drawing.Point(634, 6);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(30, 23);
            this.cmdGo.TabIndex = 2;
            this.cmdGo.TabStop = false;
            this.cmdGo.Text = "&Go";
            this.toolTip1.SetToolTip(this.cmdGo, "Go to URL");
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 568);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(38, 13);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Ready";
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(1, 2);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(39, 30);
            this.cmdBack.TabIndex = 4;
            this.cmdBack.TabStop = false;
            this.cmdBack.Text = "B";
            this.toolTip1.SetToolTip(this.cmdBack, "Back");
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdForward
            // 
            this.cmdForward.Location = new System.Drawing.Point(43, 6);
            this.cmdForward.Name = "cmdForward";
            this.cmdForward.Size = new System.Drawing.Size(30, 23);
            this.cmdForward.TabIndex = 5;
            this.cmdForward.TabStop = false;
            this.cmdForward.Text = "F";
            this.toolTip1.SetToolTip(this.cmdForward, "Forward");
            this.cmdForward.UseVisualStyleBackColor = true;
            this.cmdForward.Click += new System.EventHandler(this.cmdForward_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlert.AutoSize = true;
            this.lblAlert.Location = new System.Drawing.Point(-95, 16);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(38, 13);
            this.lblAlert.TabIndex = 6;
            this.lblAlert.Text = "lblAlert";
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefresh.Location = new System.Drawing.Point(672, 6);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(30, 23);
            this.cmdRefresh.TabIndex = 3;
            this.cmdRefresh.TabStop = false;
            this.cmdRefresh.Text = "&R";
            this.toolTip1.SetToolTip(this.cmdRefresh, "Refresh");
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(79, 11);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(15, 13);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "&D";
            this.toolTip1.SetToolTip(this.lbAddress, "Address");
            // 
            // cmdStop
            // 
            this.cmdStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdStop.Location = new System.Drawing.Point(744, 6);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(30, 23);
            this.cmdStop.TabIndex = 9;
            this.cmdStop.TabStop = false;
            this.cmdStop.Tag = "";
            this.cmdStop.Text = "&S";
            this.toolTip1.SetToolTip(this.cmdStop, "Stop");
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Location = new System.Drawing.Point(708, 6);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(30, 23);
            this.cmdHome.TabIndex = 10;
            this.cmdHome.TabStop = false;
            this.cmdHome.Tag = "";
            this.cmdHome.Text = "&H";
            this.toolTip1.SetToolTip(this.cmdHome, "Home");
            this.cmdHome.UseVisualStyleBackColor = true;
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // chkWatch
            // 
            this.chkWatch.AutoSize = true;
            this.chkWatch.Enabled = false;
            this.chkWatch.Location = new System.Drawing.Point(12, 37);
            this.chkWatch.Name = "chkWatch";
            this.chkWatch.Size = new System.Drawing.Size(58, 17);
            this.chkWatch.TabIndex = 12;
            this.chkWatch.Text = "&Watch";
            this.chkWatch.UseVisualStyleBackColor = true;
            this.chkWatch.CheckedChanged += new System.EventHandler(this.chkWatch_CheckedChanged);
            // 
            // txtWatchPath
            // 
            this.txtWatchPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWatchPath.Location = new System.Drawing.Point(67, 34);
            this.txtWatchPath.Name = "txtWatchPath";
            this.txtWatchPath.Size = new System.Drawing.Size(561, 20);
            this.txtWatchPath.TabIndex = 13;
            this.txtWatchPath.TextChanged += new System.EventHandler(this.txtWatchPath_TextChanged);
            // 
            // frmWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 590);
            this.Controls.Add(this.txtWatchPath);
            this.Controls.Add(this.chkWatch);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.cmdForward);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.panelWb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(270, 150);
            this.Name = "frmWebBrowser";
            this.Text = "StinkyPete - EForm Browser";
            this.Load += new System.EventHandler(this.frmWebBrowser_Load);
            this.panelWb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Panel panelWb;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button cmdForward;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdHome;
        private System.Windows.Forms.CheckBox chkWatch;
        private System.Windows.Forms.TextBox txtWatchPath;
    }
}

