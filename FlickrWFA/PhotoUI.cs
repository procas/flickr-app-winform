using FlickrWFA.Helpers;
using FlickrWFA.Interfaces;
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
    public partial class PhotoUI : Form, IView
    {
        private readonly PhotoUIHelper photoUIHelper;
        int MAX_SIZE = 1500;
        string COLOR = "#99B4D1";
        WebBrowser webBrowser;
        Presenter presenter;
        Label label;

        public PhotoUI()
        {
            InitializeComponent();
            this.Width = MAX_SIZE;
            this.Height = MAX_SIZE;
            photoUIHelper = new PhotoUIHelper();
            this.webBrowser = webBrowser1;
            this.label = label1;
            presenter = new Presenter(this);
        }


        public string htmlString
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                webBrowser.ScrollBarsEnabled = false;
                label1.Text = "Default images on Red:\n";
                webBrowser.DocumentText = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Controls.Add(textBox1);
            Controls.Add(button1);
            TextBox tb = this.textBox1 as TextBox;
            Panel panel = new Panel();
            panel.BackColor = ColorTranslator.FromHtml(COLOR);
            panel.Width = MAX_SIZE/2;
            panel.Height = MAX_SIZE/2;
            panel.AutoScroll = false;
            /*Center align panel*/
            panel.Left = (this.Width - panel.Width) / 2;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                
                label1.BackColor = ColorTranslator.FromHtml(COLOR);
                label1.Text = "Pictures on " + tb.Text + ":";
                label1.Location = new Point(10, button1.Location.Y+40);
                panel.Controls.Add(label1);
                webBrowser.DocumentText = photoUIHelper.getHtml(tb.Text);
                panel.Controls.Add(webBrowser1);
                webBrowser1.Width = panel.Width;
                webBrowser1.Height = panel.Height;
                /*Reset text after each call*/
                tb.Text = "";
                int y_offset = label1.Location.Y + 50;
                int x = 0; int y = y_offset;
                webBrowser1.Location = new Point(x, y);
                Controls.Add(panel);
            }
            else
            {
                MessageBox.Show("Please enter tag");
            }
            
        }
    }
}
