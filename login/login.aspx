<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <style>
        #ContentPlaceHolder1_LinkButton1,#ContentPlaceHolder1_LinkButton2,#ContentPlaceHolder1_LinkButton3,#ContentPlaceHolder1_LinkButton4{
    width:200px;
    background-color:#3bb3e0;
	padding:10px;
	position:relative;
	font-family: 'Open Sans', sans-serif;
	font-size:12px;
	text-decoration:none;
	color:#fff;
	border: solid 1px #186f8f;
	background-image: linear-gradient(bottom, rgb(44,160,202) 0%, rgb(62,184,229) 100%);
	background-image: -o-linear-gradient(bottom, rgb(44,160,202) 0%, rgb(62,184,229) 100%);
	background-image: -moz-linear-gradient(bottom, rgb(44,160,202) 0%, rgb(62,184,229) 100%);
	background-image: -webkit-linear-gradient(bottom, rgb(44,160,202) 0%, rgb(62,184,229) 100%);
	background-image: -ms-linear-gradient(bottom, rgb(44,160,202) 0%, rgb(62,184,229) 100%);
	background-image: -webkit-gradient(
	linear,
	left bottom,
	left top,
	color-stop(0, rgb(44,160,202)),
	color-stop(1, rgb(62,184,229))
	);
	-webkit-box-shadow: inset 0px 1px 0px #7fd2f1, 0px 1px 0px #fff;
	-moz-box-shadow: inset 0px 1px 0px #7fd2f1, 0px 1px 0px #fff;
	box-shadow: inset 0px 1px 0px #7fd2f1, 0px 1px 0px #fff;
	-webkit-border-radius: 5px;
	-moz-border-radius: 5px;
	-o-border-radius: 5px;
	border-radius: 5px;
        }
      </style>
            <br />
			<br />
			<br />
		<form id="form1" runat="server" class="form-horizontal" align="center">
    	<div>
			<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" BorderStyle="Outset" BorderWidth="1" Font-Size="Larger">账号登陆</asp:LinkButton>
			<br />
			<br />
			<br />
			<asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Font-Size="Larger" BorderStyle="Outset" BorderWidth="1">邮箱登陆</asp:LinkButton>
			<br />
			<br />
			<br />
			<asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" BorderWidth="1" BorderStyle="Outset" Font-Size="Larger">手机登陆</asp:LinkButton>
			<br />
			<br />
			<br />
			<asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" Font-Size="Larger" BorderWidth="1" BorderStyle="Outset">忘记密码</asp:LinkButton>
    	</div>
		</form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="background" runat="server">

</asp:Content>
