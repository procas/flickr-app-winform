using FlickrWFA.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickrWFA
{
    public partial class PhotoUI : Form
    {
        private readonly PhotoUIHelper photoUIHelper;
        int MAX_SIZE = 1500;

        public PhotoUI()
        {
            InitializeComponent();
            this.Width = MAX_SIZE;
            this.Height = MAX_SIZE;
            photoUIHelper = new PhotoUIHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Controls.Add(textBox1);
            Controls.Add(button1);
            TextBox tb = this.textBox1 as TextBox;
            Panel panel = new Panel();
            panel.BackColor = ColorTranslator.FromHtml("#99B4D1");
            panel.Width = MAX_SIZE/2;
            panel.Height = MAX_SIZE/2;
            panel.AutoScroll = false;
            /*Center align panel*/
            panel.Left = (this.Width - panel.Width) / 2;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                Label label = new Label();
                label.BackColor = ColorTranslator.FromHtml("#99B4D1");
                label.Text = "Pictures on " + tb.Text + ":";
                label.Location = new Point(10, button1.Location.Y+40);
                panel.Controls.Add(label);
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.ScrollBarsEnabled = false;
                webBrowser.DocumentText = photoUIHelper.getHtml(tb.Text);
                panel.Controls.Add(webBrowser);
                webBrowser.Width = panel.Width;
                webBrowser.Height = panel.Height;
                /*Reset text after each call*/
                tb.Text = "";
                int y_offset = label.Location.Y + 50;
                int x = 0; int y = y_offset;
                webBrowser.Location = new Point(x, y);
                Controls.Add(panel);
            }
            else
            {
                MessageBox.Show("Please enter tag");
            }
            
        }
    }
}
