/* 
 * AutoResxTranslator
 * by Salar Khalilzadeh
 * 
 * https://github.com/salarcode/AutoResxTranslator/
 * Mozilla Public License v2
 */
namespace AutoResxTranslator
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Windows.Forms;

    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            this.InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.lblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Icon = Application.OpenForms[0].Icon;
        }

        private void lnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var start = new ProcessStartInfo(this.lnkUpdate.Text);
            try
            {
                start.UseShellExecute = true;
                Process.Start(start);
            }
            catch
            {
            }
        }

        private void lnkWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var start = new ProcessStartInfo(this.lnkWebSite.Text);
            try
            {
                start.UseShellExecute = true;
                Process.Start(start);
            }
            catch
            {
            }
        }
    }
}
