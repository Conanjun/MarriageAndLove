﻿<%@ Page Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<form id="form1" runat="server" class="form-horizontal">
		<fieldset>
			<legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 管理员登陆</legend>
			<table ID="Table1" runat="server" height="250px" width="500px">
			<tr><td width="200">&nbsp;&nbsp; &nbsp;用户名:</td><td width="300">
				<asp:TextBox ID="username" runat="server" OnTextChanged="username_TextChanged"></asp:TextBox>
				</td></tr>
			<tr><td width="200">&nbsp;&nbsp;&nbsp;&nbsp; 密 码:</td><td width="300">
				<asp:TextBox ID="password" runat="server" OnTextChanged="password_TextChanged" TextMode="Password"></asp:TextBox>
				</td></tr>
			<tr><td width="200">&nbsp;&nbsp;&nbsp;&nbsp; 验证码:</td><td width="300">
				<asp:Image ID="image_check" ImageUrl="validate_code.aspx" runat="server" />
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:TextBox ID="validate_code" runat="server" Width="73px" OnTextChanged="validate_code_TextChanged"></asp:TextBox>
				</td></tr>
			<tr><td width="200">&nbsp;&nbsp;<asp:Button ID="submit_button" runat="server" OnClick="Button1_Click" Text="登陆" />
				</td></tr>
			</table>
		</fieldset>
    </form>
</asp:Content>

