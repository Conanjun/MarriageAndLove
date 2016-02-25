<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forget_password_FindByEmail_ResetPassword.aspx.cs" Inherits="login_forget_password_FindByEmail_ResetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <script type="text/javascript">
		    
		    function IsPasswdSame() {
			    alert($("#<%=password.ClientID%>").val() +" "+ $("#<%=password_check.ClientID%>").val())
			    alert($("#<%=password.ClientID%>").val() == $("#<%=password_check.ClientID%>").val());
			    if ($("#<%=password.ClientID%>").val() == $("#<%=password_check.ClientID%>").val()) {
				    $("#check_password_result").text("密码一致");
			    } else {
				    $("#check_password_result").text("密码不一致");
			    }
		    }
	    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server" class="form-horizontal">
		<fieldset>
			<legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 重置密码</legend>
			<table ID="Table1" runat="server" height="250px" width="500px">
			
			
			<tr><td width="200">&nbsp;&nbsp;&nbsp;&nbsp; 请输入重置密码</td><td width="300">
				<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
				</td></tr>
			<tr><td width="200">&nbsp;&nbsp;&nbsp;&nbsp; 确认密码</td><td width="200">
				<asp:TextBox ID="password_check" runat="server" onchange="IsPasswdSame()" TextMode="Password" OnTextChanged="password_check_TextChanged"></asp:TextBox>
				</td><td width="100"><div id="check_password_result">test</div></td></tr>
			<tr><td width="200">&nbsp;&nbsp;&nbsp;&nbsp; 验证 码</td><td width="300">
				<asp:Image ID="image_check" ImageUrl="validate_code.aspx" runat="server" />
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:TextBox ID="validate_code" runat="server" Width="73px" OnTextChanged="validate_code_TextChanged"></asp:TextBox>
				</td></tr>
			<tr><td width="300">
				<asp:Button ID="reset_button" runat="server" Text="确认" OnClick="reset_button_Click" style="height: 21px" />
			</td></tr>
			</table>
		</fieldset>
    </form>

</asp:Content>

