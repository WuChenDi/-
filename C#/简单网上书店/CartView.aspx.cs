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
	public partial class CartView : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
				InitData();
		}
        
		private void InitData()
		{
			int userId=0;
			if(Session["user_id"]!=null)
				userId=Convert.ToInt32(Session["user_id"].ToString());
			DataTable dt=Cart.Query(userId);
			GV.DataSource=dt;
			GV.DataBind();		
		}
        
		protected void ButtonBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("BookList.aspx");
		}
        
		private void DG_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			GV.EditIndex= (int)e.Item.ItemIndex;
			InitData(); 		
		}
        
		private void DG_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			GV.EditIndex = -1; 
			InitData();	
		}
        
		protected void ButtonBuy_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Bill.aspx");
		}

		protected void DG_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
        
        protected void GV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument); 
            int cartId = -1;
            Cart cart = new Cart();

            switch (e.CommandName)
            {
                   
                case "Edit":
                    GV.EditIndex = index;
                    break;
                case "Update":
                    cartId = Convert.ToInt32(GV.Rows[index].Cells[0].Text);
                    Hashtable ht = new Hashtable();
                    ht.Add("Amount", ((TextBox)GV.Rows[index].Cells[2].Controls[0]).Text.ToString());                    
                    cart.Update(ht, cartId);
                    GV.EditIndex = -1;
                    break;
                case "Cancel":
                    GV.EditIndex = -1;
                    break;
                case "Delete":
                    cartId = Convert.ToInt32(GV.Rows[index].Cells[0].Text);
                    cart.RemoveBook(cartId);
                    break;
                default:
                    break;
            }
            InitData();
        }

        protected void GV_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        protected void GV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
        protected void GV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void GV_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
}
}
