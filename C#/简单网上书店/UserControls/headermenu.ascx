<%@ Control Language="c#" Inherits="MyBookShop.UserControls.HeaderMenu" CodeFile="HeaderMenu.ascx.cs" %>
    <table id="Table1" cellspacing="1" cellpadding="1" width="100%" border="0">
        <tr>
            <td>
                <img src="Images/logo.jpg"/ alt="logo" />

            </td>
       </tr>
        <tr>
            <td valign="baseline">
                <asp:Label ID="LabelHello" runat="server"></asp:Label><br/>
                <asp:LinkButton ID="LinkButtonLogin" runat="server" OnClick="LinkButtonLogin_Click"></asp:LinkButton>&&<a
                    href="BookAdd.aspx">���ͼ��</a>&&<a href="BookList.aspx">���ͼ��</a>&&<a href="BookStatistics.aspx">ͼ��ͳ��</a>&&<a
                        href="CartView.aspx">�ҵĹ�����</a>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
    </table>