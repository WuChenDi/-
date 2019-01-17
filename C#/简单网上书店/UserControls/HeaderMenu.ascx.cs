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
				LabelHello.Text="����,<font color=red><b>"+user.LoginName+"</font></b>";

				LinkButtonLogin.Text="�뿪";
			}
			else
				LinkButtonLogin.Text="��¼";

		}
		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		///		�����֧������ķ��� - ��Ҫʹ�ô���༭��
		///		�޸Ĵ˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{

		}
		#endregion

		protected void LinkButtonLogin_Click(object sender, System.EventArgs e)
		{
			if(LinkButtonLogin.Text=="��¼")
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