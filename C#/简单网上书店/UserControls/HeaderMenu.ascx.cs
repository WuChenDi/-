using MyBookShop.BusinessLogicLayer;

namespace MyBookShop.UserControls
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
    
	public partial class HeaderMenu : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if(Session["user_id"]!=null)
			{
				User user=new User();
				user.LoadData(Convert.ToInt32(Session["user_id"]));
				LabelHello.Text="您好,<font color=red><b>"+user.LoginName+"</font></b>";

				LinkButtonLogin.Text="离开";
			}
			else
				LinkButtonLogin.Text="登录";

		}
		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		///		设计器支持所需的方法 - 不要使用代码编辑器
		///		修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{

		}
		#endregion

		protected void LinkButtonLogin_Click(object sender, System.EventArgs e)
		{
			if(LinkButtonLogin.Text=="登录")
			{
				Page.Response.Redirect("Login.aspx?in=1");
			}
			else
			{
				Session["user_id"]=null;
				Page.Response.Write("<Script Language=JavaScript>window.close();</Script>");
			}
		}
	}
}