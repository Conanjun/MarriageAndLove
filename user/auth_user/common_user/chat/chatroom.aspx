<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="chatroom.aspx.cs" Inherits="user_auth_user_common_user_chat_chatroom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
     #ContentPlaceHolder1_Button1,#ContentPlaceHolder1_Button2{
             width:100px;
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
    <div align="center">
	<form id="form1" runat="server">
    <div id="box2">
        <div id="a1"></div>
        <div id="a2">
            <table width="650" height="278" border="0">
                <tr>
                    <td width="8" height="16">&nbsp;</td>
                    <td width="430">&nbsp;</td>
                    <td width="16">&nbsp;</td>
                    <td width="165">&nbsp;</td>
                    <td width="9">&nbsp;</td>
                </tr>
                <tr>
                    <td height="244">&nbsp;</td>
                    <td>
                        <iframe id="I1" src="Content.aspx" runat="server" scrolling="no" 
            noresize="noResize" frameborder="0" style="width: 421px; height: 228px" 
            name="I1" ></iframe>
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <iframe id="I2" src="List.aspx" runat="server" frameborder="no" 
            noresize="noResize" scrolling="no" style="width: 151px; height: 220px" 
            name="I2"></iframe>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td height="16">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div id="a3">
            <table width="639" height="36" border="0">
                <tr >
                    <td width="34" height="29">&nbsp;</td>
                    <td width="420">
                        <asp:TextBox ID="txtMessage" runat="server" Width="316px"></asp:TextBox>
                    </td>
                    <td width="250px">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" text="发送"/>
            
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" text="退出"/>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
        </div>
</asp:Content>

