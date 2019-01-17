using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using MyBookShop.BusinessLogicLayer;

namespace MyBookShop.Web
{
	public partial class BookStatistics : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
				DrawChartByCategory();
		}
        
		private void DrawChartByCategory()
		{
			DataTable dt=Book.GetSaleCountByCategory();
			string title="ͼ��������ͳ��";			
			string subTitle="����ͼ������";			
            string targetFile = Server.MapPath(".\\Images\\") + "Category.gif";
			Chart.DrawPie(title,subTitle,300,300,dt,targetFile,"CategoryName","SaleCount");

            Image.ImageUrl=targetFile;
		}
		private void DrawChartByPublisher()
		{
			DataTable dt=Book.GetSaleCountByPublisher();
			string title="ͼ��������ͳ��";			
			string subTitle="���ڳ�����";			
            string targetFile = Server.MapPath(".") + "\\Images\\Publiser.gif";	
  
			Chart.DrawPie(title,subTitle,300,300,dt,targetFile,"Publisher","SaleCount");

			Image.ImageUrl=targetFile;
		}
		private void DrawChartByPrice()
		{
			DataTable dt=Book.GetSaleCountByPrice();
			string title="ͼ��������ͳ��";			
			string subTitle="����ͼ��۸�";			

            string targetFile = HttpContext.Current.Server.MapPath(".\\Images\\") + "Price.gif";
			Chart.DrawPie(title,subTitle,300,300,dt,targetFile,"PriceGrade","SaleCount");

			Image.ImageUrl=targetFile;
		}
		protected void DropDownListType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(DropDownListType.SelectedValue)
			{
				case "ͼ�����":
					DrawChartByCategory();
					break;
				case "������":
					DrawChartByPublisher();
					break;
				case "�۸�":
					DrawChartByPrice();
					break;

			}
		}
	}
}
