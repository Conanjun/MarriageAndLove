<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="update_choose.aspx.cs" Inherits="search_for_fate_update_choose" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <style>
          #ContentPlaceHolder1_Update{
             
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
             .img2{
            width:100px;
            height:100px;
        }
               .div2{
	font-size: 50px;
}
    </style>
     <div class="div2" align="left" ><img src="/static/image/longaiyixianqian.png" class="img2">&nbsp&nbsp;我的择偶
             <br />
		<img src="/static/image/11.png"></div>

    <form id="form1" runat="server" align="center">
         <p>基本择偶要求</p>
    <br/>
        <div class="table1"align="center">
    <asp:Table ID="Table1" runat="server" Height="270px" Width="45%" BorderWidth="1" BorderStyle="Outset" Font-Size="Larger">
        <asp:TableRow>
            <asp:TableCell>对方性别</asp:TableCell><asp:TableCell><asp:TextBox ID="csext" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>要求年龄</asp:TableCell><asp:TableCell><asp:TextBox ID="aget" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>要求身高（单位cm）</asp:TableCell><asp:TableCell><asp:TextBox ID="heightt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>要求婚姻状况</asp:TableCell><asp:TableCell><asp:TextBox ID="marriagestatust" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>要求学历</asp:TableCell><asp:TableCell><asp:TextBox ID="degreet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>要求地区</asp:TableCell><asp:TableCell><asp:DropDownList ID="Province" runat="server" AutoPostBack="True" onselectedindexchanged="Province_SelectedIndexChanged"></asp:DropDownList>
    <asp:DropDownList ID="City" runat="server" AutoPostBack="True" onselectedindexchanged="City_SelectedIndexChanged"></asp:DropDownList>
    <asp:DropDownList ID="District" runat="server"></asp:DropDownList>详细地址<asp:TextBox ID="AddressDetail" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>要求有无照片</asp:TableCell><asp:TableCell><asp:TextBox ID="ishasimaget" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>要求月薪（单位元）</asp:TableCell><asp:TableCell><asp:TextBox ID="salaryt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
            </div>
        <p>详细择偶要求</p>
        <br />
        <div class="table2" align="center">
        <asp:Table ID="Table2" runat="server" Height="210px" Width="45%" BorderWidth="1" BorderStyle="Outset"  Font-Size="Larger">
        <asp:TableRow>
            <asp:TableCell>要求家庭背景</asp:TableCell><asp:TableCell><asp:TextBox ID="option1t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否介意婚前公证财产</asp:TableCell><asp:TableCell><asp:TextBox ID="option2t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否介意经常跟好朋友出去玩</asp:TableCell><asp:TableCell><asp:TextBox ID="option3t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>最关注对方什么条件</asp:TableCell><asp:TableCell><asp:TextBox ID="option4t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>最不能忍受对方的缺点</asp:TableCell><asp:TableCell><asp:TextBox ID="option5t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否介意抽烟喝酒</asp:TableCell><asp:TableCell><asp:TextBox ID="option6t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否要小孩</asp:TableCell><asp:TableCell><asp:TextBox ID="option7t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否希望对方浪漫</asp:TableCell><asp:TableCell><asp:TextBox ID="option8t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>婚后理财规划</asp:TableCell><asp:TableCell><asp:TextBox ID="option9t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>家务如何分配</asp:TableCell><asp:TableCell><asp:TextBox ID="option10t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>消费观</asp:TableCell><asp:TableCell><asp:TextBox ID="option11t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>如果有外遇</asp:TableCell><asp:TableCell><asp:TextBox ID="option12t" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
            </div>
        <br />
        <br />
        <asp:Button ID="Update" runat="server" Text="修改择偶要求" OnClick="Update_Click" />
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="background" Runat="Server">
</asp:Content>

