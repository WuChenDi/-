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
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitData();
                Query();
            }
        }
        
        private void InitData()
        {
            DataTable dt = Category.Query(new Hashtable());
            DropDownListCategory.Items.Clear();
            DropDownListCategory.Items.Add(new ListItem("全部", ""));
            foreach (DataRow dr in dt.Rows)
            {
                DropDownListCategory.Items.Add(new ListItem(dr["CategoryName"].ToString(), dr["CategoryId"].ToString()));
            }
        }
        private void Query()
        {
            Hashtable queryItems = new Hashtable();
            queryItems.Add("BookName", TextBoxBookName.Text);
            queryItems.Add("CategoryId", DropDownListCategory.SelectedValue);
            DataTable dt = Book.QueryBooks(queryItems, DropDownListSortColumn.SelectedValue, DropDownListSortType.SelectedValue);

            GV.DataSource = dt;
            GV.DataBind();
            
            ViewState.Add("DropDownListCategory", DropDownListCategory.SelectedValue);
            ViewState.Add("DropDownListSortColumn", DropDownListSortColumn.SelectedValue);
            ViewState.Add("DropDownListSortType", DropDownListSortType.SelectedValue);

            LabelPageInfo.Text = "查询结果（第" + (GV.PageIndex + 1).ToString() + "页 共" + GV.PageCount.ToString() + "页）";
        }
        
        protected void ButtonQuery_Click(object sender, System.EventArgs e)
        {
            Query();			
            ResetQueryValue();	
        }
        
        private void ResetQueryValue()
        {
           
            foreach (ListItem Item in DropDownListCategory.Items)
            {
                if (Item.Value == ViewState["DropDownListCategory"].ToString())
                    Item.Selected = true;
                else
                    Item.Selected = false;
            }
            foreach (ListItem Item in DropDownListSortColumn.Items)
            {
                if (Item.Value == ViewState["DropDownListSortColumn"].ToString())
                    Item.Selected = true;
                else
                    Item.Selected = false;
            }
            foreach (ListItem Item in DropDownListSortType.Items)
            {
                if (Item.Value == ViewState["DropDownListSortType"].ToString())
                    Item.Selected = true;
                else
                    Item.Selected = false;
            }
        }    
        
        private ArrayList GetSelected()
        {
            ArrayList selectedItems = new ArrayList();
            foreach (GridViewRow row in GV.Rows)
            {
                if (((CheckBox)row.FindControl("chkSelected")).Checked)
                {
                    selectedItems.Add(Convert.ToInt32(row.Cells[1].Text));
                }
            }
            return selectedItems;
        }
        
        protected void ButtonAdd2Cart_Click(object sender, System.EventArgs e)
        {
            if (Session["user_id"] == null)
                Page.Response.Redirect("Login.aspx?in=1");

            Cart cart = new Cart();
            Hashtable ht = new Hashtable();
            ArrayList selectedBooks = this.GetSelected();
            
            if (selectedBooks.Count == 0)
            {
                Response.Write("<Script Language=JavaScript>alert('请选择图书!');</Script>");
                return;
            }

            foreach (int bookId in selectedBooks)
            {
                ht.Clear();
                ht.Add("UserId", Session["user_id"].ToString());
                ht.Add("BookId", bookId);
                ht.Add("Amount", TextBoxAmount.Text.Trim());
                cart.Add(ht);
            }
            Response.Redirect("CartView.aspx");
        }
        
        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            ArrayList selectedBooks = this.GetSelected();
            Book book = new Book();

            if (selectedBooks.Count == 0)
            {
                Response.Write("<Script Language=JavaScript>alert('请首先选择图书!');</Script>");
                return;
            }

            foreach (int bookId in selectedBooks)
            {
                book.LoadData(bookId);
                book.Delete();
            }
            Query();
        }
        
        protected void GV_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV.PageIndex = e.NewPageIndex;
            InitData();
            Query();
        }
    }
}