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
using MyBookShop.BusinessLogicHelper;

namespace MyBookShop.Web
{
	
	public partial class BookAdd : System.Web.UI.Page
	{
       
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				InitData();
			}
		}

		private void InitData()
		{
			DataTable dt= Category.Query(new Hashtable());
			foreach(DataRow dr in dt.Rows)
			{
				DropDownListCategory.Items.Add(new ListItem(dr["CategoryName"].ToString(),dr["CategoryId"].ToString()));
			}
		}
        
		protected void ButtonOK_Click(object sender, System.EventArgs e)//Ã·Ωª
		{
			Hashtable ht=new Hashtable();
			ht.Add("BookName",TextBoxBookName.Text.Trim());
			ht.Add("CategoryId",DropDownListCategory.SelectedValue);
			ht.Add("Price",TextBoxPrice.Text.Trim());
			ht.Add("Publisher",TextBoxPublisher.Text.Trim());
			ht.Add("PublishDate",TextBoxPublishDate.Text.Trim());
			ht.Add("Author",TextBoxAuthor.Text.Trim());
			ht.Add("PageNum",TextBoxPageNum.Text.Trim());
			ht.Add("Description",TextBoxDescription.Text.Trim());
			
			string uploadName=InputPictureFile.Value.Trim();
			string pictureName="";
			if(uploadName!="")
			{
				int idx=uploadName.LastIndexOf(".");
				string suffix=uploadName.Substring(idx);
				pictureName=System.DateTime.Now.Ticks.ToString()+suffix;
				ht.Add("PictureUrl",pictureName);
			}

			ht.Add("SaleCount",1);
			
			ArrayList WarningMessageList=new ArrayList();
			LabelWarningMessage.Text="";
			if(BookHelper.Add(ht,ref WarningMessageList)==false)
			{
				LabelWarningMessage.Text="<font color=red>";
				foreach(string item in WarningMessageList)
				{
					LabelWarningMessage.Text+=item+"<br>";
				}
				LabelWarningMessage.Text+="</font>";
			}
			
			else
			{
				if(uploadName!="")
				{
					string path=Server.MapPath(".\\BookPics\\");
					InputPictureFile.PostedFile.SaveAs(path+pictureName);
				}
				Response.Redirect("BookList.aspx");
			}
			
		}
	}
}
