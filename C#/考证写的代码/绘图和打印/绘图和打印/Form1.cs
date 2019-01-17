using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 绘图和打印
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组实心扇形", f, b, 10, 20);
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Green);
            Brush b3 = new SolidBrush(Color.Blue);
            g.FillPie(b1, 40, 40, 160, 160, 20, 100);
            g.FillPie(b2, 40, 40, 160, 160, 140, 100);
            g.FillPie(b3, 40, 40, 160, 160, 260, 100);

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组扇形", f, b, 10, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Green);
            Pen p3 = new Pen(Color.Blue);
            g.DrawPie(p1, 40, 40, 160, 160, 20, 100);
            g.DrawPie(p2, 40, 40, 160, 160, 140, 100);
            g.DrawPie(p3, 40, 40, 160, 160, 260, 100);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组圆弧", f, b, 10, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Green);
            Pen p3 = new Pen(Color.Blue);
            g.DrawArc(p1, 40, 40, 160, 160, 20, 100);
            g.DrawArc(p2, 40, 40, 160, 160, 140, 100);
            g.DrawArc(p3, 40, 40, 160, 160, 260, 100);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("封闭锯齿线", f, b, 10, 20);
            Pen p1 = new Pen(Color.Blue);
            g.DrawPolygon(p1, new Point[] { new Point(20, 100), new Point(60, 60), new Point(100, 100), new Point(140, 60), new Point(180, 100), new Point(220, 60), new Point(260, 100) });*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组平行锯齿线", f, b, 10, 20);
            Pen p1 = new Pen(Color.Blue);
            Pen p2 = new Pen(Color.Red);
            Pen p3 = new Pen(Color.Green);
            g.DrawLines(p1, new Point[] { new Point(20, 100), new Point(60, 60), new Point(100, 100), new Point(140, 60), new Point(180, 100), new Point(220, 60), new Point(260, 100) });
            g.DrawLines(p2, new Point[] { new Point(20, 120), new Point(60, 80), new Point(100, 120), new Point(140, 80), new Point(180, 120), new Point(220, 80), new Point(260, 120) });
            g.DrawLines(p3, new Point[] { new Point(20, 140), new Point(60, 100), new Point(100, 140), new Point(140, 100), new Point(180, 140), new Point(220, 100), new Point(260, 140) });*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("锯齿线", f, b, 10, 20);
            Pen p1 = new Pen(Color.Blue);
            g.DrawLines(p1, new Point[] { new Point(20, 100), new Point(60, 60), new Point(100, 100), new Point(140, 60), new Point(180, 100), new Point(220, 60), new Point(260, 100) });*/


            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组实心矩形", f, b, 10, 20);
            Brush b1 = new SolidBrush(Color.Purple);
            Brush b2 = new SolidBrush(Color.Blue);
            Brush b3 = new SolidBrush(Color.Green);
            g.FillRectangle(b1, 20, 80, 40, 100);
            g.FillRectangle(b2, 80, 100, 100, 40);
            g.FillRectangle(b3, 200, 100, 60, 60);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组矩形", f, b, 10, 20);
            Pen p1 = new Pen(Color.Purple);
            Pen p2 = new Pen(Color.Blue);
            Pen p3 = new Pen(Color.Green);
            g.DrawRectangle (p1, 20, 80, 40, 100);
            g.DrawRectangle (p2, 80, 100, 100, 40);
            g.DrawRectangle (p3, 200, 100, 60, 60);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组实心多边形", f, b, 10, 20);
            Brush  b1 = new SolidBrush (Color.Red);
            Brush  b2 = new SolidBrush (Color.Blue);
            Brush  b3 = new SolidBrush (Color.Green);
            g.FillPolygon (b1, new Point[] { new Point(50, 100), new Point(20, 150), new Point(80, 150) });
            g.FillPolygon (b2, new Point[] { new Point(100, 100), new Point(100, 150), new Point(150, 150), new Point(150, 100) });
            g.FillPolygon (b3, new Point[] { new Point(220, 100), new Point(190, 120), new Point(200, 150), new Point(240, 150), new Point(250, 120) });*/

            /* Graphics g = e.Graphics;
             Font f = new Font("宋体", 9, FontStyle.Regular);
             Brush b = new SolidBrush(Color.Black);
             g.DrawString("这是一组多边形", f, b, 10, 20);
             Pen  p1 = new Pen (Color.Red);
             Pen  p2 = new Pen (Color.Blue);
             Pen  p3 = new Pen (Color.Green);
             g.DrawPolygon(p1, new Point[] { new Point(50, 100), new Point(20, 150), new Point(80, 150) });
             g.DrawPolygon(p2, new Point[] { new Point(100, 100), new Point(100, 150), new Point(150, 150),new Point (150,100) });
             g.DrawPolygon(p3, new Point[] { new Point(220, 100), new Point(190, 120), new Point(200, 150), new Point(240, 150),new Point (250,120) });*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组同心圆环", f, b, 10, 20);
            Brush b1 = new SolidBrush (Color.Red);
            Brush b2 = new SolidBrush(Color.Purple);
            Brush b3 = new SolidBrush(Color.Blue);
            Brush b4 = new SolidBrush(Color.Green);
            g.FillEllipse(b1, 40, 40, 160, 160);
            g.FillEllipse(b2, 60, 60, 120, 120);
            g.FillEllipse(b3, 80, 80, 80, 80);
            g.FillEllipse(b4, 100, 100, 40, 40);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组同心圆", f, b, 10, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Purple);
            Pen p3 = new Pen(Color.Blue);
            Pen p4 = new Pen(Color.Green);
            g.DrawEllipse(p1, 40, 40, 160, 160);
            g.DrawEllipse(p2, 60, 60, 120, 120);
            g.DrawEllipse(p3, 80, 80, 80, 80);
            g.DrawEllipse(p4, 100, 100, 40, 40);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组平行线", f, b, 10, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Blue);
            Pen p3 = new Pen(Color.Black);           
            g.DrawLine(p1, 20, 180, 160, 40);
            g.DrawLine(p2, 60, 180, 200, 40);
            g.DrawLine(p3, 100, 180, 240, 40);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组网格线", f, b, 90, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Purple );
            Pen p3 = new Pen(Color.Blue );
            Pen p4 = new Pen(Color.Green );
            g.DrawLine(p1, 0, 80, 300, 80);
            g.DrawLine(p2, 0, 160, 300, 160);
            g.DrawLine(p3, 80, 0, 80, 240);
            g.DrawLine(p4, 200, 0, 200, 240);*/

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组实心扇形", f, b, 10, 20);
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Green);
            Brush b3 = new SolidBrush(Color.Blue);
            g.FillPie(b1, 40, 40, 160, 160, 20, 100);
            g.FillPie(b2, 40, 40, 160, 160, 140, 100);
            g.FillPie(b3, 40, 40, 160, 160, 260, 100);

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组扇形", f, b, 10, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Green);
            Pen p3 = new Pen(Color.Blue);
            g.DrawPie(p1, 40, 40, 160, 160, 20, 100);
            g.DrawPie(p2, 40, 40, 160, 160, 140, 100);
            g.DrawPie(p3, 40, 40, 160, 160, 260, 100);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组圆弧", f, b, 10, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Green);
            Pen p3 = new Pen(Color.Blue);
            g.DrawArc(p1, 40, 40, 160, 160, 20, 100);
            g.DrawArc(p2, 40, 40, 160, 160, 140, 100);
            g.DrawArc(p3, 40, 40, 160, 160, 260, 100);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("封闭锯齿线", f, b, 10, 20);
            Pen p1 = new Pen(Color.Blue);
            g.DrawPolygon(p1, new Point[] { new Point(20, 100), new Point(60, 60), new Point(100, 100), new Point(140, 60), new Point(180, 100), new Point(220, 60), new Point(260, 100) });*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组平行锯齿线", f, b, 10, 20);
            Pen p1 = new Pen(Color.Blue);
            Pen p2 = new Pen(Color.Red);
            Pen p3 = new Pen(Color.Green);
            g.DrawLines(p1, new Point[] { new Point(20, 100), new Point(60, 60), new Point(100, 100), new Point(140, 60), new Point(180, 100), new Point(220, 60), new Point(260, 100) });
            g.DrawLines(p2, new Point[] { new Point(20, 120), new Point(60, 80), new Point(100, 120), new Point(140, 80), new Point(180, 120), new Point(220, 80), new Point(260, 120) });
            g.DrawLines(p3, new Point[] { new Point(20, 140), new Point(60, 100), new Point(100, 140), new Point(140, 100), new Point(180, 140), new Point(220, 100), new Point(260, 140) });*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("锯齿线", f, b, 10, 20);
            Pen p1 = new Pen(Color.Blue);
            g.DrawLines(p1, new Point[] { new Point(20, 100), new Point(60, 60), new Point(100, 100), new Point(140, 60), new Point(180, 100), new Point(220, 60), new Point(260, 100) });*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组实心矩形", f, b, 10, 20);
            Brush b1 = new SolidBrush(Color.Purple);
            Brush b2 = new SolidBrush(Color.Blue);
            Brush b3 = new SolidBrush(Color.Green);
            g.FillRectangle(b1, 20, 80, 40, 100);
            g.FillRectangle(b2, 80, 100, 100, 40);
            g.FillRectangle(b3, 200, 100, 60, 60);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组矩形", f, b, 10, 20);
            Pen p1 = new Pen(Color.Purple);
            Pen p2 = new Pen(Color.Blue);
            Pen p3 = new Pen(Color.Green);
            g.DrawRectangle(p1, 20, 80, 40, 100);
            g.DrawRectangle(p2, 80, 100, 100, 40);
            g.DrawRectangle(p3, 200, 100, 60, 60);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组实心多边形", f, b, 10, 20);
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Blue);
            Brush b3 = new SolidBrush(Color.Green);
            g.FillPolygon(b1, new Point[] { new Point(50, 100), new Point(20, 150), new Point(80, 150) });
            g.FillPolygon(b2, new Point[] { new Point(100, 100), new Point(100, 150), new Point(150, 150), new Point(150, 100) });
            g.FillPolygon(b3, new Point[] { new Point(220, 100), new Point(190, 120), new Point(200, 150), new Point(240, 150), new Point(250, 120) });*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组多边形", f, b, 10, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Blue);
            Pen p3 = new Pen(Color.Green);
            g.DrawPolygon(p1, new Point[] { new Point(50, 100), new Point(20, 150), new Point(80, 150) });
            g.DrawPolygon(p2, new Point[] { new Point(100, 100), new Point(100, 150), new Point(150, 150), new Point(150, 100) });
            g.DrawPolygon(p3, new Point[] { new Point(220, 100), new Point(190, 120), new Point(200, 150), new Point(240, 150), new Point(250, 120) });*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组同心圆环", f, b, 10, 20);
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Purple);
            Brush b3 = new SolidBrush(Color.Blue);
            Brush b4 = new SolidBrush(Color.Green);
            g.FillEllipse(b1, 40, 40, 160, 160);
            g.FillEllipse(b2, 60, 60, 120, 120);
            g.FillEllipse(b3, 80, 80, 80, 80);
            g.FillEllipse(b4, 100, 100, 40, 40);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组同心圆", f, b, 10, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Purple);
            Pen p3 = new Pen(Color.Blue);
            Pen p4 = new Pen(Color.Green);
            g.DrawEllipse(p1, 40, 40, 160, 160);
            g.DrawEllipse(p2, 60, 60, 120, 120);
            g.DrawEllipse(p3, 80, 80, 80, 80);
            g.DrawEllipse(p4, 100, 100, 40, 40);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组平行线", f, b, 10, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Blue);
            Pen p3 = new Pen(Color.Black);
            g.DrawLine(p1, 20, 180, 160, 40);
            g.DrawLine(p2, 60, 180, 200, 40);
            g.DrawLine(p3, 100, 180, 240, 40);*/

            /*Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("这是一组网格线", f, b, 90, 20);
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Purple);
            Pen p3 = new Pen(Color.Blue);
            Pen p4 = new Pen(Color.Green);
            g.DrawLine(p1, 0, 80, 300, 80);
            g.DrawLine(p2, 0, 160, 300, 160);
            g.DrawLine(p3, 80, 0, 80, 240);
            g.DrawLine(p4, 200, 0, 200, 240);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }
    }
}
