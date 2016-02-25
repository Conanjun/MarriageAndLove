<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="show_friendinfo.aspx.cs" Inherits="user_auth_user_common_user_myfriend_show_friendinfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        #ContentPlaceHolder1_ChangeInfo{
             
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
   
    <form id="form1" runat="server"  align="center">
         <p>好友个人基本资料</p>
    <br/>
        <div class="table1" align="center">
    <asp:Table ID="Table1" runat="server" Height="270px"  Width="45%"   
        GridLines="Vertical" HorizontalAlign="Center" BorderStyle="Outset" BorderWidth="1" Font-Size="Larger">
         <asp:TableRow>
            <asp:TableCell>姓名:</asp:TableCell><asp:TableCell><asp:Label ID="namet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>性别:</asp:TableCell><asp:TableCell><asp:Label ID="sext" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>年龄:</asp:TableCell><asp:TableCell><asp:Label ID="aget" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>身高（单位cm）:</asp:TableCell><asp:TableCell><asp:Label ID="heightt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>学历:</asp:TableCell><asp:TableCell><asp:Label ID="degreet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>月薪（单位元）:</asp:TableCell><asp:TableCell><asp:Label ID="salaryt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>现在办公地址:</asp:TableCell><asp:TableCell><asp:Label ID="addresst" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>婚姻状况:</asp:TableCell><asp:TableCell><asp:Label ID="marriaget" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>籍贯:</asp:TableCell><asp:TableCell><asp:Label ID="nativeplacet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
        </div>
    
    </form>
       
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="background" Runat="Server">
</asp:Content>

