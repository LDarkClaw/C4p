using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri("https://www.dndbeyond.com/avatars/thumbnails/6/365/420/618/636272701937419552.png");
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string url = Clipboard.GetText();
            pictureBox1.Load(url);








        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
