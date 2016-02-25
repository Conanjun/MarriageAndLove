<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="actionapply.aspx.cs" Inherits="actionapply" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	<%-- Ajax 实时判断用户名是否存在--%>
	
	<script type="text/javascript">

	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
          #ContentPlaceHolder1_activity,#ContentPlaceHolder1_name,#ContentPlaceHolder1_telephone,#ContentPlaceHolder1_email,#ContentPlaceHolder1_validate_code{
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
          #ContentPlaceHolder1_apply_button{
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
           .font{
          width:100px;
          height:60px;
          font-weight:600;
      }
  .img2{
            width:100px;
            height:100px;
        }
    .div2{
	font-size: 50px;
}
    </style>
    <div class="div2" ><img src="/static/image/longaiyixianqian.png" class="img2">&nbsp&nbsp;龙爱一线牵</div>
		<img src="/static/image/11.png">

    <div class="act" align="center">
	<form id="form1" runat="server" class="form-horizontal">
		<fieldset>
			<legend>&nbsp;&nbsp;<font  size="5" face="verdana" color="white">活动报名</font></legend>
            <br />
            <br />
			<table ID="Table1" runat="server" height="250px" width="500px">
                <tr><td class="font" >活动:</td><td >
                <asp:DropDownList ID="activity" runat="server" AutoPostBack="True" onselectedindexchanged="Activity_SelectedIndexChanged"></asp:DropDownList>
				</td>
				</tr>
                <tr><td class="font">姓名:</td><td >
				<asp:TextBox ID="name" runat="server"></asp:TextBox>
				</td>
				</tr>
			<tr><td class="font" >性别:</td><td >
				<asp:RadioButton ID="male" Text="男" runat="server" GroupName="Sex" /> <asp:RadioButton ID="female" Text="女" runat="server" GroupName="Sex"/> 
				</td><td ><div id="check_user_result"></div></td></tr>
			<tr><td class="font" >手机号码:</td><td >
				<asp:TextBox ID="telephone" runat="server"></asp:TextBox>
				</td></tr>
			<tr><td class="font" >邮箱:</td><td >
				<asp:TextBox ID="email" runat="server"></asp:TextBox>
				</td><td width="100"><div id="check_password_result"></div></td></tr>
			
			<tr><td>
			    </td>
                <td  align="center">
				<asp:Button ID="apply_button" runat="server" Text="报名" OnClick="apply_button_Click"/>
				</td></tr>
			</table>
		</fieldset>
    </form>
        <br />
        <br />
	</div>
</asp:Content>

 
