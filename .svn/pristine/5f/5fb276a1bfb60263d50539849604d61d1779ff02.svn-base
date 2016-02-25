<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="register_by_phone.aspx.cs" Inherits="register_register_by_phone" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<%-- Ajax 实时判断用户名是否存在--%>
	
	<script type="text/javascript">
	    function IsExistUser() {
	        $.ajax({
	            type: "GET",
	            url: "IsExistUser.aspx",
	            data: "check_username=" + $("#<%=username.ClientID%>").val(),
				success: function (msg) {
				    $("#check_user_result").text(msg);
				}

			});
        }
        function IsPasswdSame() {
            alert($("#<%=password.ClientID%>").val() + " " + $("#<%=password_check.ClientID%>").val())
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

        <style>
        #ContentPlaceHolder1_phone,#ContentPlaceHolder1_username,#ContentPlaceHolder1_password,#ContentPlaceHolder1_password_check,#ContentPlaceHolder1_validate_code{
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
  
      #ContentPlaceHolder1_submit_button,#ContentPlaceHolder1_register_button{
    cursor: pointer;
    width: 120px;
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
      .auto-style{
          height:60px;
          font-weight:600;
      }

            </style>
    <div class="register_by_phone" align="center">
<form id="form1" runat="server" class="form-horizontal"  >
		<fieldset>
			<legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font  size="5" face="verdana" color="white">手机注册</font></legend>
            <br />
            <br />
			<table ID="Table1" runat="server" height="250px" width="500px" align="center">
			<tr><td class="auto-style">手机号:</td><td>
				<asp:TextBox ID="phone" runat="server" OnTextChanged="phone_TextChanged"></asp:TextBox>
				</td>
				<%--
					验证邮箱处有bug，暂时搁置
					<td width="100">
				<asp:RegularExpressionValidator EnableClientScript="false" ID="check_email" runat="server" ControlToValidate="TextBox2" ErrorMessage="邮件格式不正确" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                Font-Size="12px"></asp:RegularExpressionValidator></td>
				 --%>
				</tr>
			
	
			
			<tr><td class="auto-style" >用户名:</td><td >
				<asp:TextBox ID="username" runat="server" onchange="IsExistUser()"></asp:TextBox>
				</td><td><div id="check_user_result"></div></td></tr>
			<tr><td class="auto-style">密 码:</td><td >
				<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
				</td></tr>
			<tr><td class="auto-style" >确认密码:</td><td>
				<asp:TextBox ID="password_check" runat="server" onchange="IsPasswdSame()" TextMode="Password" OnTextChanged="password_check_TextChanged"></asp:TextBox>
				</td><td><div id="check_password_result"></div></td></tr>
			<tr><td class="auto-style">验证码:</td><td>
				<asp:Image ID="image_check" ImageUrl="validate_code.aspx" runat="server" />
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:TextBox ID="validate_code" runat="server" Width="160px" OnTextChanged="validate_code_TextChanged"></asp:TextBox>
				</td></tr>
			<tr ><td ><asp:Button ID="submit_button" runat="server" OnClick="Button1_Click" Text="登陆" />
				</td><td align="right">
					<asp:Button ID="register_button" Width="120px" runat="server" Text="注册" OnClick="register_button_Click"  />
				</td></tr>
			</table>
		</fieldset>
    </form>
        </div>

</asp:Content>

