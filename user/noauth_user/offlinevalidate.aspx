<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="offlinevalidate.aspx.cs" Inherits="offlinevalidate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server" class="form-horizontal">
		<fieldset>
			<legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 线下认证</legend>
			<table ID="Table1" runat="server" height="250px" width="500px">
			<tr><td width="200">&nbsp;&nbsp; &nbsp;姓名</td><td width="200">
				<asp:TextBox ID="name" runat="server"></asp:TextBox>
				</td>
				</tr>
			
	
			
			<tr><td width="200">&nbsp;&nbsp; &nbsp;手机号码</td><td width="200">
				<asp:TextBox ID="telephone" runat="server"></asp:TextBox>
				</td><td width="100"><div id="check_user_result"></div></td></tr>
			<tr><td width="200">&nbsp;&nbsp;&nbsp;&nbsp;邮箱</td><td width="300">
				<asp:TextBox ID="email" runat="server"></asp:TextBox>
				</td></tr>
			<tr><td width="200">&nbsp;&nbsp;&nbsp;&nbsp;认证地址</td><td width="200">
				<asp:TextBox ID="validateaddress" runat="server"></asp:TextBox>
				</td><td width="100"><div id="check_password_result"></div></td></tr>
			<tr><td width="200"></td><td width="300">
					<asp:Button ID="submit_button" runat="server" Text="提交" OnClick="submit_button_Click" style="height: 21px" />
				</td></tr>
			</table>
		</fieldset>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="background" Runat="Server">
</asp:Content>

