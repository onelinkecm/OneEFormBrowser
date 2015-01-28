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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFormBrowser
{
    public partial class frmWebBrowser : Form
    {

        public const string title = "StinkyPete";
        private const string fmtTitle = "{0} - {1}";
        private const string urlAbout = "resources/about.html";
        private const string urlStart = "resources/home.html";

        public frmWebBrowser()
        {
            InitializeComponent();
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            Go(txtUrl.Text);
        }

        private void frmWebBrowser_Load(object sender, EventArgs e)
        {
            
            lblAlert.Text = "";
            Go(GetHomePage());
           
        }

        private string GetHomePage()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string ret = Path.Combine(baseDirectory, urlStart);
            if (!File.Exists(ret))
            {
                ret = Path.Combine(baseDirectory, urlAbout);
            }
            if (!File.Exists(ret))
            {
                ret = "";
            }
            return ret;
        }

        private void Go(string Url)
        {
            string originalUrl = Url;
            try
            {
                if (Url != string.Empty)
                {
                    if (!(Url.Contains(":/") || Url.Contains(":\\")))
                    {
                        // try prepending protocol
                        Url = "http://" + Url;
                    }
                    wb.Url = new Uri(Url);
                }
            }
            catch (Exception ex)
            {
                string msg = string.Format("{0}\n\n{1}\n\n{2}", "Did you enter the correct protocol (e.g. http://)?", originalUrl, ex.Message);
                MessageBox.Show(msg, "Problem with URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtUrl.Text = wb.Url.ToString();
            wb.Focus();
        }

        private void wb_DocumentTitleChanged(object sender, EventArgs e)
        {
            string documentTitle = wb.DocumentTitle;
            if (documentTitle == String.Empty) {
                documentTitle = Path.GetFileName(wb.Url.ToString());
            }
            this.Text = string.Format(fmtTitle, documentTitle, title);
        }

        private void wb_StatusTextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = wb.StatusText;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            wb.GoBack();
        }

        private void cmdForward_Click(object sender, EventArgs e)
        {
            wb.GoForward();
        }

        //private void actionKeys(object sender, KeyEventArgs e)
        //{
        //    string fmt = "keycode({0}); keydata({1}); keyvalue({2}); modifiers({3})";
        //    lblAlert.Text = string.Format(fmt, e.KeyCode, e.KeyData, e.KeyValue, e.Modifiers);

        //    switch (e.Modifiers)
        //    {
        //        case Keys.Control:
        //            switch (e.KeyCode)
        //            {
        //                case Keys.R:
        //                    wb.Refresh();
        //                    lblAlert.Text += " Refresh();";
        //                    break;
        //            }
        //            break;
        //        case Keys.Alt:
        //            switch (e.KeyCode)
        //            {
        //                case Keys.Left:
        //                    wb.GoBack();
        //                    break;
        //                case Keys.Right:
        //                    wb.GoForward();
        //                    break;
        //            }
        //            break;
        //        case Keys.Escape:
        //            wb.Stop();
        //            lblAlert.Text += " Stop();";
        //            break;
        //    }
        //}

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
                wb.Refresh();
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Go(txtUrl.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            wb.Stop();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            Go(GetHomePage());
        }

    }
}
