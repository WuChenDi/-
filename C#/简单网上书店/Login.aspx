<%@ Page language="c#" Inherits="MyBookShop.Web.Login" CodeFile="Login.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>�û���¼</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<link href="Styles/Style.css" type="text/css" rel="stylesheet">
	</head>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 32px; WIDTH: 240px; POSITION: absolute; TOP: 8px; HEIGHT: 158px"
					cellSpacing="0" cellPadding="0" width="240" border="0">
					<TR>
						<TD style="WIDTH: 69px"></TD>
						<TD style="WIDTH: 164px" align="center"><FONT face="����"><IMG alt="" src="Images/logo.JPG" width="130"></FONT></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 69px">&nbsp;<asp:label id="Label1" runat="server">��¼��*</asp:label></TD>
						<TD style="WIDTH: 164px"><asp:textbox id="TextBoxLoginName" runat="server" Width="160px"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 69px">&nbsp;<asp:label id="Label2" runat="server">����*</asp:label></TD>
						<TD style="WIDTH: 164px"><asp:textbox id="TextBoxPassword" runat="server" Width="160px" TextMode="Password"></asp:textbox></TD>
					</TR>
					<TR>
						<TD align="center" colSpan="3"><asp:button id="ButtonLogin" runat="server" Width="56px" Text="��¼" onclick="ButtonLogin_Click"></asp:button>&nbsp;&nbsp;
							<asp:hyperlink id="HyperLinkRegister" runat="server" NavigateUrl="Register.aspx">ע��</asp:hyperlink></TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</html>
