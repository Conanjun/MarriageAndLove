<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="passwd_change.aspx.cs" Inherits="admin_passwd_change" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	
      <style>
        .login-bottom input[type="text"] {
    width: 350px;
    height: 42px;   
    padding: 0 15px;
    background: #2d2d2d; /* browsers that don't support rgba */
    background: rgba(45,45,45,.15);
    -moz-border-radius: 6px;
    -webkit-border-radius: 6px;
    border-radius: 6px;
    border: 1px solid #3d3d3d; /* browsers that don't support rgba */
    border: 1px solid rgba(255,255,255,.15);
    -moz-box-shadow: 0 2px 3px 0 rgba(0,0,0,.1) inset;
    -webkit-box-shadow: 0 2px 3px 0 rgba(0,0,0,.1) inset;
    box-shadow: 0 2px 3px 0 rgba(0,0,0,.1) inset;
    font-family: 'PT Sans', Helvetica, Arial, sans-serif;
    font-size: 14px;
    color: #fff;
    text-shadow: 0 1px 2px rgba(0,0,0,.1);
    -o-transition: all .2s;
    -moz-transition: all .2s;
    -webkit-transition: all .2s;
    -ms-transition: all .2s;
  
}
   .login-bottom input[type="password"]{
    width: 350px;
    height: 42px;
    padding: 0 15px;
    background: #2d2d2d; /* browsers that don't support rgba */
    background: rgba(45,45,45,.15);
    -moz-border-radius: 6px;
    -webkit-border-radius: 6px;
    border-radius: 6px;
    border: 1px solid #3d3d3d; /* browsers that don't support rgba */
    border: 1px solid rgba(255,255,255,.15);
    -moz-box-shadow: 0 2px 3px 0 rgba(0,0,0,.1) inset;
    -webkit-box-shadow: 0 2px 3px 0 rgba(0,0,0,.1) inset;
    box-shadow: 0 2px 3px 0 rgba(0,0,0,.1) inset;
    font-family: 'PT Sans', Helvetica, Arial, sans-serif;
    font-size: 14px;
    color: #fff;
    text-shadow: 0 1px 2px rgba(0,0,0,.1);
    -o-transition: all .2s;
    -moz-transition: all .2s;
    -webkit-transition: all .2s;
    -ms-transition: all .2s;
         
   }
    .submit{
         cursor: pointer;
    width: 300px;
    height: 44px;
    padding: 0;
    background:#80bbd5;
    -moz-border-radius: 6px;
    -webkit-border-radius: 6px;
    border-radius: 6px;
    border: 1px solid #87438f;
    -moz-box-shadow:
        0 15px 30px 0 rgba(255,255,255,.25) inset,
        0 2px 7px 0 rgba(0,0,0,.2);
    -webkit-box-shadow:
        0 15px 30px 0 rgba(255,255,255,.25) inset,
        0 2px 7px 0 rgba(0,0,0,.2);
    box-shadow:
        0 15px 30px 0 rgba(255,255,255,.25) inset,
        0 2px 7px 0 rgba(0,0,0,.2);
    font-family: 'PT Sans', Helvetica, Arial, sans-serif;
    font-size: 14px;
    font-weight: 700;
    color: #fff;
    text-shadow: 0 1px 2px rgba(0,0,0,.1);
    -o-transition: all .2s;
    -moz-transition: all .2s;
    -webkit-transition: all .2s;
    -ms-transition: all .2s;
    }
          </style>
    
   <div class="login-bottom" align="center">
    <form id="form1" runat="server" class="form-horizontal">
		<fieldset>
			<legend>&nbsp;&nbsp;<font  size="5" face="verdana" color="black">修改密码</font></legend>
			<br />
            <br />
            <table ID="Table1" runat="server" height="250px" width="500px" align="center">
			<tr><td >&nbsp;&nbsp;&nbsp;&nbsp;用户名:</td><td >
				<asp:TextBox ID="username" runat="server"></asp:TextBox>
				</td></tr>
			<tr><td >&nbsp;&nbsp;&nbsp;&nbsp;旧密码:</td><td >
				<asp:TextBox ID="old_password" runat="server" TextMode="Password"></asp:TextBox>
				</td></tr>
			<tr><td >&nbsp;&nbsp;&nbsp;&nbsp;新密码:</td><td >
				<asp:TextBox ID="new_password" runat="server" TextMode="Password"></asp:TextBox>
				</td></tr>
			<tr><td >&nbsp;&nbsp;&nbsp;确认密码:</td><td >
				<asp:TextBox ID="new_password_again" runat="server" TextMode="Password"></asp:TextBox>
				</td></tr>
			<tr><td align="center" colspan="2">&nbsp;&nbsp;<asp:Button ID="submit_button" width="120px" runat="server" OnClick="Button1_Click" Text="确认修改" CssClass="submit" />
				</td></tr>
			</table>
		</fieldset>
    </form>
       </div>
</asp:Content>

