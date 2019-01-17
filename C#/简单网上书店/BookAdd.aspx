<%@ Page Language="c#" Inherits="MyBookShop.Web.BookAdd" CodeFile="BookAdd.aspx.cs" %>

<%@ Register TagPrefix="MyBookShop" TagName="HeaderMenu" Src="UserControls/HeaderMenu.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>���ͼ��</title>
    <link href="Styles/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="Form1" method="post" enctype="multipart/form-data" runat="server">
        <table id="Table1" style="z-index: 101; left: 8px; width: 504px; position: absolute;
            top: 8px; height: 288px" cellspacing="0" cellpadding="0" width="504" border="0">
            <tr>
                <td align="center" colspan="2">
                    <MyBookShop:HeaderMenu ID="headerMenu" runat="server"></MyBookShop:HeaderMenu>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &gt;&gt;���ͼ��
                    <hr />
                </td>
            </tr>
            <tr>
                <td style="width: 90px">
                    ͼ����*</td>
                <td style="width: 232px">
                    <asp:TextBox ID="TextBoxBookName" runat="server" Width="120px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 90px">
                    ���*</td>
                <td style="width: 232px">
                    <asp:DropDownList ID="DropDownListCategory" runat="server">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 90px">
                    �۸�*</td>
                <td style="width: 232px">
                    <asp:TextBox ID="TextBoxPrice" runat="server" Width="80px"></asp:TextBox>Ԫ</td>
            </tr>
            <tr>
                <td style="width: 90px">
                    ������*</td>
                <td style="width: 232px">
                    <asp:TextBox ID="TextBoxPublisher" runat="server" Width="192px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 90px">
                    ��������*</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBoxPublishDate" runat="server" Width="110px"></asp:TextBox>(����:2006-07-01)</td>
            </tr>
            <tr>
                <td style="width: 90px">
                    ����*</td>
                <td style="width: 232px">
                    <asp:TextBox ID="TextBoxAuthor" runat="server" Width="112px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 90px">
                    ҳ��*</td>
                <td style="width: 232px">
                    <asp:TextBox ID="TextBoxPageNum" runat="server" Width="48px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 90px">
                    ���</td>
                <td style="width: 232px">
                    <asp:TextBox ID="TextBoxDescription" runat="server" Width="352px" TextMode="MultiLine"
                        Height="56px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 90px">
                    �ϴ�ͼƬ</td>
                <td style="width: 232px">
                    <input id="InputPictureFile" style="width: 344px; height: 19px" type="file" size="38"
                        runat="server" /></td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <hr />
                    <asp:Button ID="ButtonOK" runat="server" Width="56px" Text="�ύ" OnClick="ButtonOK_Click">
                    </asp:Button></td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:Label ID="LabelWarningMessage" runat="server"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
