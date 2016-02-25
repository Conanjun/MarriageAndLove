<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login_by_phone.aspx.cs" Inherits="login_login_by_phone" %>
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
    .login-bottom input[type="text1"] {
    width: 160px;
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
 
      .auto-style1{
          height:60px;
          font-weight:600;
      }


    </style>
 
    
<div class="login-bottom" align="center">
	<form id="form1" runat="server" class="form-horizontal" >
		<fieldset>
			<legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <font  size="5" face="verdana" color="white">手机登录</font></legend>
			<br />
            <br /> 
            <table ID="Table1" runat="server" height="250px" width="500px" align="center">
			<tr><td class="auto-style1" >手机号:</td><td >
				<asp:TextBox ID="phone" runat="server" align="right" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
				</td></tr>
			<tr><td class="auto-style1"> 密 码:</td><td >
				<asp:TextBox ID="password" runat="server" align="right" OnTextChanged="password_TextChanged" TextMode="Password"></asp:TextBox>
				</td></tr>
			<tr><td  class="auto-style1">验证码:</td>
                <td >
				<input type="text" id="code2" style="display:inline-block;width:100px;outline:none;position:relative;top:-20px;" maxlength="4" />
				 <div id="vCode2" style="width:100px; height: 40px; border: 1px solid #ccc; display: inline-block;"></div>
				<%--<asp:Image ID="image_check" ImageUrl="validate_code.aspx" runat="server" />	--%>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<%--<asp:TextBox ID="validate_code" runat="server"  type="text1"    OnTextChanged="validate_code_TextChanged"></asp:TextBox>--%>
				</td></tr>
                <tr><td class="auto-style2" align="center"><asp:Button ID="submit_button" runat="server"   width="120px" OnClick="Button1_Click" Text="登录" CssClass="submit" />&nbsp;&nbsp;
				 <td class="auto-style2" align="right"><asp:Button ID="Button1" runat="server"   width="120px" OnClick="Button1_Click" Text="注册" CssClass="submit" />
                </td>
                </td>
                </tr>
       </table>
			    
		</fieldset>
    </form>
        </div>

</asp:Content>