using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体__大小
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            /*this .Icon =new Icon( "1,Ico");
            this.statusBarPanel1.Text = "A";*/

            /*this.BackgroundImage = Image.FromFile("1.jpg");
            this.statusBarPanel1.Text = "A";*/   //背景图片，图片在文件bin--Debug中

            /*this.Cursor = Cursors.Default;
            this.statusBarPanel1.Text = "默认";*/   //改变光标形状，WaitCursor为等待，Cross为十字架

            /*label1.Text = "I am a college student";
            this.statusBarPanel1.Text = "A";*/   //改变文本内容

            /*label1.BackColor = Color.Red;
            this.statusBarPanel1.Text = "红色";*/   //字体背景

            /*label1.Location = new Point(50, 60);
            this.statusBarPanel1.Text = "上";*/   //位置(左中右)

            /*label1.Location = new Point(10, 100);
             this.statusBarPanel1.Text = "左";*/  //位置(上中下)

            /* this.ForeColor = Color.Black ;
             this.this.statusBarPanel1.Text = "黑色";*/   //前景色

            /*this.ForeColor  = Color.Red;
            this.statusBarPanel1.Text = "红色";*/   //背景色

            /*this.Size = new Size(600, 300);
            this.statusBarPanel1.Text = "大窗体";*/   //窗体大小

        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 200);
            statusBarPanel1.Text = "中窗体";
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            this.Size = new Size(150, 120);
            statusBarPanel1.Text = "小窗体";
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == toolBarButton1)
            {
                this.Size = new Size(600, 400);
                statusBarPanel1.Text = "大窗体";
            }
            if (e.Button == toolBarButton2)
            {
                this.Size = new Size(300, 200);
                statusBarPanel1.Text = "中窗体";
            }
            if (e.Button == toolBarButton3)
            {
                this.Size = new Size(150, 120);
                statusBarPanel1.Text = "小窗体";
            }
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
