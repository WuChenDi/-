using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == toolBarButton1)
            {
                label1.Location = new Point(10, 100);
                this.statusBarPanel1.Text = "左";

            }
            if (e.Button == toolBarButton2)
            {
                label1.Location = new Point(50, 100);
                this.statusBarPanel1.Text = "中";

            }
            if (e.Button == toolBarButton3)
            {
                label1.Location = new Point(90, 100);
                this.statusBarPanel1.Text = "右";

            }

        }

        /*private void menuItem2_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(10, 100);
            this.statusBarPanel1.Text = "左";

            this.BackgroundImage = Image.FromFile("1.jpg");
            this.statusBarPanel1.Text = "左";

            this .Icon =new Icon ("1.ICO");
            this.statusBarPanel1.Text = "左";

        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(50, 100);
            this.statusBarPanel1.Text = "中";

            this.BackgroundImage = Image.FromFile("2.jpg");
            this.statusBarPanel1.Text = "左";

            this.Icon = new Icon("2.ICO");
            this.statusBarPanel1.Text = "左";

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(90, 100);
            this.statusBarPanel1.Text = "右";

            this.BackgroundImage = Image.FromFile("3.jpg");
            this.statusBarPanel1.Text = "A";

            this.Icon = new Icon("3.ICO");
            this.statusBarPanel1.Text = "A";
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 左ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(10, 100);
            this.statusBarPanel1.Text = "左";

            this.BackgroundImage = Image.FromFile("1.jpg");
            this.statusBarPanel1.Text = "左";

            this.Icon = new Icon("1.ICO");
            this.statusBarPanel1.Text = "左";
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(50, 100);
            this.statusBarPanel1.Text = "中";

            this.BackgroundImage = Image.FromFile("2.jpg");
            this.statusBarPanel1.Text = "左";

            this.Icon = new Icon("2.ICO");
            this.statusBarPanel1.Text = "左";
        }

        private void 右ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(90, 100);
            this.statusBarPanel1.Text = "右";

            this.BackgroundImage = Image.FromFile("3.jpg");
            this.statusBarPanel1.Text = "A";

            this.Icon = new Icon("3.ICO");
            this.statusBarPanel1.Text = "A";
        }
    }
}
