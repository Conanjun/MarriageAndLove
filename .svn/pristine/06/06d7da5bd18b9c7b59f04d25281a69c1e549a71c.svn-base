<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forget_password_FindByEmail.aspx.cs" Inherits="login_forget_password_FindByEmail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	<script>
        onload = function () {
            var container2 = document.getElementById("vCode2");
            var code2 = new vCode(container2, {
                len: 4,
                bgColor: "#444444",
                colors: [
                    "#DDDDDD",
                    "#DDFF77",
                    "#77DDFF",
                    "#99BBFF",
                    "#EEEE00"
                ]
            });
            document.getElementById("code2").addEventListener("blur", function () {
            	if (!code2.verify(document.getElementById("code2").value)) { alert("验证码错误"); document.getElementById("code2").value =""};
            }, false);
        };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
              #ContentPlaceHolder1_email,#code2{
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
         #ContentPlaceHolder1_findpassword_button{
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
               .auto-style1{
         width:200px;
                    height:60px;
          font-weight:600;
      }
    </style>
    <div align="center">

<form id="form1" runat="server" class="form-horizontal">
		<fieldset>
			<legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font  size="5" face="verdana" color="white">发送邮件找回密码</font></legend>
			<br />
            <br />
            <br />
            <table ID="Table1" runat="server" height="250px" width="500px">
			<tr><td  class="auto-style1"  >邮箱地址:</td><td >
				<asp:TextBox ID="email" runat="server" OnTextChanged="email_TextChanged"></asp:TextBox>
				</td>
				<%--
					验证邮箱处有bug，暂时搁置
					<td width="100">
				<asp:RegularExpressionValidator EnableClientScript="false" ID="check_email" runat="server" ControlToValidate="TextBox2" ErrorMessage="邮件格式不正确" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                Font-Size="12px"></asp:RegularExpressionValidator></td>
				 --%>
			</tr>
			
	
			<tr><td  class="auto-style1"  >验证码:</td><td >
                
				<input type="text" id="code2" style="display:inline-block;width:100px;outline:none;position:relative;top:-20px;" maxlength="4" />
				 <div id="vCode2" style="width:100px; height: 40px; border: 1px solid #ccc; display: inline-block;"></div>
				<%--<asp:Image ID="image_check" ImageUrl="validate_code.aspx" runat="server" />--%>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<%--<asp:TextBox IkD="validate_code" runat="server" Width="73px" OnTextChanged="validate_code_TextChanged"></asp:TextBox>--%>
				</td></tr>
                <tr>
                    <td>

                    </td>
                    <td align="center" >
                    <asp:Button ID="findpassword_button" runat="server" Text="发送" OnClick="findpassword_button_Click"  />
				</td></tr>
			</table>
		</fieldset>
    </form>
	
        </div>
</asp:Content>

