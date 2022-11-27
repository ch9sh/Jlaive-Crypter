using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jalive
{
    public partial class Jlaive : Form
    {
        public Jlaive()
        {
            InitializeComponent();
        }

        private void OpenSubForms(Form form)
        {
            binderPNL.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            binderPNL.Controls.Add(form);
            form.Show();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {

        }

        private async void ClosingFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                ClosingFade.Stop();
                await Task.Delay(TimeSpan.FromSeconds(1));
                Application.Exit();
            }
        }

        private void Jalive_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            binderPNL.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            close.ShowBalloonTip(1000);
            ClosingFade.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ch2sh/Jlaive");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            binderPNL.Show();
            SubForms.Binder encryption = new SubForms.Binder();
            OpenSubForms(encryption);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            binderPNL.Hide();
            outputPNL.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            outputPNL.Show();
            SubForms.Output output = new SubForms.Output();
            OpenSubForms(output);
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
