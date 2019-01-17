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
	public partial class Login : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			
		}

		protected void ButtonLogin_Click(object sender, System.EventArgs e)
		{
			
			string userLoginName=TextBoxLoginName.Text;		//�û���¼��
			string password=TextBoxPassword.Text;			//����

			User user=new User();					
			user.LoadData(userLoginName);			
			Session.Add("user_id",user.UserID);		
			
			if(user.Exist)	//�ж��û��Ƿ����
			{
				if(user.Password==password)
				{
					if (Request.QueryString["in"]==null)
					{
						Response.Redirect("BookList.aspx");
					}
					else
					{
						Response.Write("<Script Language=JavaScript>history.go(-2);</Script>");
					}					
				}
				else
				{
					Response.Write("<Script Language=JavaScript>alert(\"��������������������룡\")</Script>");
				}
			}
			else
			{
				Response.Write("<Script Language=JavaScript>alert(\"�Բ����û������ڣ�\")</Script>");
			}
		}
	}
}
