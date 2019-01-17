<%@ Register TagPrefix="MyBookShop" TagName="HeaderMenu" Src="UserControls/HeaderMenu.ascx" %>

<%@ Page Language="c#" Inherits="MyBookShop.Web.BookList" CodeFile="BookList.aspx.cs" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>���ͼ��</title>
    <link href="Styles/Style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #Table1 {
            background-image:url('Images/28.gif');
        }
        .auto-style1 {
            width: 45px;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table id="Table1" style="z-index: 101; left: 8px; width: 504px; position: absolute;
            top: 8px; height: 208px" cellspacing="0" cellpadding="0" width="504" border="0">
            <tr>
                <td align="center" colspan="4">
                    <MyBookShop:HeaderMenu ID="headerMenu" runat="server"></MyBookShop:HeaderMenu>
                </td>
            </tr>
            <tr>
                <td style="width: 99px">
                    &gt;&gt;���ͼ��</td>
                <td>
                </td>
                <td>
                </td>
                <td class="auto-style1">
                </td>
            </tr>
            <tr >
                <td colspan="1" rowspan="1">
                    &&������
                    <asp:TextBox ID="TextBoxBookName" runat="server" Width="66px"></asp:TextBox></td>
                <td style="height: 4px" colspan="1" rowspan="1">
                    &&���
                    <asp:DropDownList ID="DropDownListCategory" runat="server">
                    </asp:DropDownList></td>
                <td style="height: 4px">
                    &&  ����
                    <asp:DropDownList ID="DropDownListSortColumn" runat="server">
                        <asp:ListItem Value="SaleCount">����</asp:ListItem>
                        <asp:ListItem Value="PublishDate">��������</asp:ListItem>
                        <asp:ListItem Value="Price">�۸�</asp:ListItem>
                    </asp:DropDownList><asp:DropDownList ID="DropDownListSortType" runat="server">
                        <asp:ListItem Value="Desc">�ݼ�</asp:ListItem>
                        <asp:ListItem Value="Asc">����</asp:ListItem>
                    </asp:DropDownList></td>
                <td class="auto-style1">
                    <asp:Button ID="ButtonQuery" runat="server" Text="��ѯ" Width="48px" OnClick="ButtonQuery_Click">
                    </asp:Button></td>
            </tr>
            <tr>
                <td align="center" colspan="4">
                    <br>
                    &nbsp;<asp:GridView ID="GV" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                        PageSize="5" OnPageIndexChanging="GV_PageIndexChanging">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkSelected" Checked="False" Visible="True" GroupName="chk" runat="server">
                                    </asp:CheckBox></ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="BookId" HeaderText="���" />
                            <asp:BoundField DataField="BookName" HeaderText="ͼ����" />
                            <asp:BoundField DataField="Author" HeaderText="����" />
                            <asp:BoundField DataField="Publisher" HeaderText="������" />
                            <asp:BoundField DataField="PublishDate" HeaderText="��������" DataFormatString="{0:yyyy-MM-dd}" />
                            <asp:BoundField DataField="Price" HeaderText="�۸�" DataFormatString="{0:C}" />
                            <asp:HyperLinkField HeaderText="��ϸ��Ϣ" DataTextFormatString="��ϸ��Ϣ" Text="��ϸ��Ϣ" DataNavigateUrlFormatString="BookDetail.aspx?book_id={0}"
                                DataNavigateUrlFields="BookId" />
                        </Columns>
                    </asp:GridView>
                    <asp:Label ID="LabelPageInfo" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td align="left" colspan="2" rowspan="1">
                    <asp:Button ID="ButtonDelete" runat="server" Text="ɾ��" Width="48px" OnClick="ButtonDelete_Click">
                    </asp:Button></td>
                <td align="right"colspan="2" rowspan="1">
                    ��
                    <asp:TextBox ID="TextBoxAmount" runat="server" Width="26px">1</asp:TextBox>��ѡ�е�ͼ��<asp:Button
                        ID="ButtonAdd2Cart" runat="server" Text="���빺����" OnClick="ButtonAdd2Cart_Click"></asp:Button></td>
            </tr>
        </table>
    </form>
</body>
</html>
