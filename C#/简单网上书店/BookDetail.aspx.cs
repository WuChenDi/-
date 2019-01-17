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
	public partial class BookDetail : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
				InitData();
		}
        
		private void InitData()
		{
			int bookId=Convert.ToInt32(Request.QueryString["book_id"]);
			Book book=new Book();
			book.LoadData(bookId);

			Category category=new Category();
			category.LoadData(book.CategoryID);
			LabelBookInfo.Text="�����"+category.CategoryName
								+"<hr>��������"+book.BookName
								+"<hr>�����ߡ�"+book.Author
								+"<hr>�������硿"+book.Publisher
								+"<hr>���������ڡ�"+book.PublishDate.ToLongDateString()
								+"<hr>���۸񡿣�"+book.Price.ToString()
								+"<hr>��ҳ����"+book.PageNum.ToString()
								+"<hr>����顿"+book.Description
								+"<hr>��������"+book.SaleCount.ToString()+"��";
			ImageBook.ImageUrl="BookPics\\"+book.PictureUrl;
		}
        
		protected void ButtonBack_Click(object sender, System.EventArgs e)
		{			
			Response.Write("<Script Language=JavaScript>history.go(-2);</Script>");
		}
	}
}
