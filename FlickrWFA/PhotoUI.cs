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
        List<string> urls;
        string testhtml = "<!DOCTYPE html><html><table><tr><td><img src=\"https://live.staticflickr.com/65535/52267351891_94cd9d708a_m.jpg\" alt=\"Nature\" style=\"width:200px\"></td><td><img src=\"https://live.staticflickr.com/65535/52255516545_8bb72dc3af_m.jpg\" alt=\"Nature\" style=\"width:200px\"></td></tr><tr><td><img src=\"https://live.staticflickr.com/65535/52267374290_4c53070206_m.jpg\" alt=\"Nature\" style=\"width:200px\"></td><td><img src=\"https://live.staticflickr.com/65535/52266129032_b1f04fabe1_b.jpg\" alt=\"Nature\" style=\"width:200px\"></td></tr></table></html>";
        public PhotoUI()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 500;
            photoUIHelper = new PhotoUIHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            Controls.Add(textBox1);
            Controls.Add(button1);
            TextBox tb = this.textBox1 as TextBox;
            Panel panel = new Panel();
            panel.Width = 1000;
            panel.Height = 500;
            //if (Controls.Contains(panel))
            //    Controls.Remove(panel);

            if (!string.IsNullOrEmpty(tb.Text))
            {
                Label label = new Label();
                label.Text = "Pictures on " + tb.Text + ":";
                label.Location = new Point(10, button1.Location.Y+40);

                panel.Controls.Add(label);
                WebBrowser webBrowser = new WebBrowser();
                //webBrowser.DocumentText = photoUIHelper.getHtml(tb.Text);
                //webBrowser.DocumentText = "<html><body class=\"red\">This is a test<body><style>.red{color: #FF3399;font-weight: 900;}</style></html>";
                webBrowser.DocumentText = testhtml;
                panel.Controls.Add(webBrowser);
                webBrowser.Width = 1000;
                webBrowser.MaximumSize = panel.Size;
                urls = photoUIHelper.getUrlList(tb.Text);
                tb.Text = "";
                int y_offset = label.Location.Y + 50;
                int x = 0; int y = y_offset;
                webBrowser.Location = new Point(x, y);
                //for (int i = 0; i < 10; i++)
                //{
                //    if (x > this.Width)
                //    {
                //        x = 0;
                //        y += 200;
                //    }

                //    PictureBox pictureBox = new PictureBox();
                //    panel.Controls.Add(pictureBox);
                    
                //    //Controls.Add(pictureBox);
                //    pictureBox.Location = new Point(x, y);
                    
                //    string url = urls[i];
                //    try
                //    {
                //        pictureBox.Load(url);
                //    }
                //    catch (Exception)
                //    {
                //        //pass
                //    }
                //    pictureBox.Width = 200;
                //    pictureBox.Height = 200;
                //    x += 200;

                //}
                Controls.Add(panel);
            }
            else
            {
                MessageBox.Show("Please enter tag");
            }

            
        }
        public HttpContent httpCall()
        {
            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
