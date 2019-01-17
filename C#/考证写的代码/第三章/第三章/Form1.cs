using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第三章
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Size = new Size(600, 400);
            statusBarPanel1.Text = "大窗体";
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Size = new Size(300, 200);
            statusBarPanel1.Text = "中窗体";
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Size = new Size(150, 120);
            statusBarPanel1.Text = "小窗体";
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == toolBarButton1)
            {
                Size = new Size(600, 400);
                statusBarPanel1.Text = "大窗体";
            }
            if (e.Button == toolBarButton2)
            {
                Size = new Size(300, 200);
                statusBarPanel1.Text = "中窗体";
            }
            if (e.Button == toolBarButton3)
            {
                Size = new Size(150, 120);
                statusBarPanel1.Text = "小窗体";
            }
        }
    }
}
