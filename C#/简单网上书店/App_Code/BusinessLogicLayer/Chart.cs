using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

using MyBookShop.DataAccessHelper;

namespace MyBookShop.BusinessLogicLayer
{
	/// <summary>
	/// һ��ͨ�õĻ���ͼ����
	/// </summary>
	public class Chart
	{
		private const int SIDE_LENGTH=400;
		private const int PIE_DIAMETER=200;

		/// <summary>
		/// ����ͼ����
		/// </summary>
		/// <param name="title">��ͼ����</param>
		/// <param name="subTitle">�ӱ���</param>
		/// <param name="width">��</param>
		/// <param name="height">��</param>
		/// <param name="dt">������Դ��</param>
		/// <param name="targetFile">���ɵ�ͼ�α���Ŀ���ļ�</param>
		/// <param name="descColumn">����˵����</param>
		/// <param name="dataColumn">��ʾ��ͳ��ͼ�ϵ���������</param>
		public static void DrawPie(string title,string subTitle,int width,int height,DataTable dt,string targetFile,string descColumn,string dataColumn)
		{
			//����һ��λͼ����
			Bitmap bm=new Bitmap(width,height);
			Graphics g=Graphics.FromImage(bm);
 
			//��ͼ��"����"��ָ�����
			g.ScaleTransform(Convert.ToSingle(width)/SIDE_LENGTH,Convert.ToSingle(height)/SIDE_LENGTH);
 
			//����ͼ���ڵ��߿�
			g.Clear(Color.White);
			g.DrawRectangle(Pens.Black,0,0,SIDE_LENGTH-1,SIDE_LENGTH-1);
 
			//������title,������subTitle
			g.DrawString(title,new Font("����",14),Brushes.Black,new PointF(5,5)); 
			g.DrawString(subTitle,new Font("����",12),Brushes.Black,new PointF(7,35));
 
			//����ͼ
			float curAngle=0;		//��ǰ�������ĽǶ�
			float totalAngle=0;		//�ܵĽǶ�
			float sumData=0;		//������Ҫͳ�Ƶ�����֮��
			
			//������Ҫͳ�Ƶ�����֮��
			foreach(DataRow dr in dt.Rows)
			{
				if(dr[dataColumn]!=DBNull.Value)
					sumData+=Convert.ToSingle(dr[dataColumn]);
			}

			//ѭ������ÿһ������,�Լ���˵��
			int colorIndex=0;		//��ɫ
			float percent=0;		//ÿһ������İٷֱ�
			g.DrawRectangle(Pens.Black,100,270,300,130);	//˵���߿�
			PointF boxOrigin=new PointF(110,275);			//˵����ǩ��ʼλ��
			PointF textOrigin=new PointF(135,275);			//˵��������ʼλ��

			//ѭ������ÿһ������
			foreach(DataRow row in dt.Rows)
			{
				if(row[dataColumn]!=System.DBNull.Value)
				{
					colorIndex++;

					//����
					curAngle=Convert.ToSingle(row[dataColumn])/sumData*360;
					g.FillPie(new SolidBrush(GetColor(colorIndex)),100,60,PIE_DIAMETER,PIE_DIAMETER,totalAngle,curAngle);
					g.DrawPie(Pens.Black,100,60,PIE_DIAMETER,PIE_DIAMETER,totalAngle,curAngle);
					totalAngle+=curAngle;

					//��ǩ
					g.FillRectangle(new SolidBrush(GetColor(colorIndex)),boxOrigin.X,boxOrigin.Y,20,10);
					g.DrawRectangle(Pens.Black,boxOrigin.X,boxOrigin.Y,20,10);
 
					//˵��
					percent=Convert.ToSingle(row[dataColumn])/sumData*100;
					g.DrawString(
						row[descColumn].ToString()+"��"+percent.ToString("0.0")+"%��",
						new Font("����",12),Brushes.Black,textOrigin
						);

					boxOrigin.Y+=20;
					textOrigin.Y+=20;
				}
			}
	
			//�����ɵ�ͼ���浽target
			bm.Save(targetFile,ImageFormat.Gif);
 
			//�ͷ���Դ
			bm.Dispose();
			g.Dispose();
		}

		/// <summary>
		/// ������ɫ�ķ���
		/// </summary>
		/// <param name="itemIndex"></param>
		/// <returns></returns>
		public static Color GetColor(int idx)
		{
			idx*=60;
			int r=idx%255;
			int g=((255/3)+idx)%255;
			int b=((255*2/3)+idx)%255;
			return Color.FromArgb(r,g,b);
		}
	}
}