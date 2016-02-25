<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="myprofile.aspx.cs" Inherits="user_auth_user_common_user_myprofile_myprofile" %>

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
                   .img2{
            width:100px;
            height:100px;
        }
            .font{
                font-family:Vijaya;
                font-weight:500;
            }
            .div2{
	font-size: 50px;
}
    </style>
    <div class="font">
    <div class="div2" ><img src="/static/image/gerenxinxi.png" class="img2">&nbsp&nbsp;个人信息</div>
		<img src="/static/image/11.png">
   
    <form id="form1" runat="server"  align="center">
         <p>个人资料：基本资料</p>
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
    <p>个人资料：详细资料</p>
    <br />
        <div class="table2"  align="center">
    <asp:Table ID="Table2" runat="server" Height="330px" Width="45%" BorderWidth="1" BorderStyle="Outset" Font-Size="Larger">
        <asp:TableRow>
            <asp:TableCell>昵称:</asp:TableCell><asp:TableCell><asp:Label ID="nicknamet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>体重（单位公斤）:</asp:TableCell><asp:TableCell><asp:Label ID="weightt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>血型:</asp:TableCell><asp:TableCell><asp:Label ID="bloodt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>民族:</asp:TableCell><asp:TableCell><asp:Label ID="nationt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>属相:</asp:TableCell><asp:TableCell><asp:Label ID="animaltypet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>宗教信仰:</asp:TableCell><asp:TableCell><asp:Label ID="religiont" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>星座:</asp:TableCell><asp:TableCell><asp:Label ID="horoscopet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>发型:</asp:TableCell><asp:TableCell><asp:Label ID="hairtypet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>脸型:</asp:TableCell><asp:TableCell><asp:Label ID="facetypet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>居住状况:</asp:TableCell><asp:TableCell><asp:Label ID="homeift" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>购车状况:</asp:TableCell><asp:TableCell><asp:Label ID="cart" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
            </div>
    <p>家庭背景</p>
    <br />
        <div class="table3"  align="center">
        <asp:Table ID="Table3" runat="server" Height="150px" Width="45%" BorderWidth="1" BorderStyle="Outset" Font-Size="Larger"> 
        <asp:TableRow>
            <asp:TableCell>家庭地址:</asp:TableCell><asp:TableCell><asp:Label ID="homeaddresst" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>父母情况:</asp:TableCell><asp:TableCell><asp:Label ID="parentst" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>家中排行:</asp:TableCell><asp:TableCell><asp:Label ID="homerankt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>有无子女:</asp:TableCell><asp:TableCell><asp:Label ID="childrenift" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>子女监护人:</asp:TableCell><asp:TableCell><asp:Label ID="childprotectort" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
            </div>
        <p>婚姻期望</p>
        <br />
        <div class="table4"  align="center">
        <asp:Table ID="Table4" runat="server" Height="150px" Width="45%" BorderWidth="1" BorderStyle="Outset" Font-Size="Larger">
        <asp:TableRow>
            <asp:TableCell>结婚时间:</asp:TableCell><asp:TableCell><asp:Label ID="marrytimet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>婚礼方式:</asp:TableCell><asp:TableCell><asp:Label ID="marrytypet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否愿意与父母同住:</asp:TableCell><asp:TableCell><asp:Label ID="parentsift" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否要小孩:</asp:TableCell><asp:TableCell><asp:Label ID="childift" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>对婚姻的看法:</asp:TableCell><asp:TableCell><asp:Label ID="tomarriaget" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
            </div>
        <p>生活习惯</p>
        <br />
        <div class="table5"   align="center">
        <asp:Table ID="Table5" runat="server" Height="210px"  Width="45%" BorderWidth="1" BorderStyle="Outset" Font-Size="Larger">
        <asp:TableRow>
            <asp:TableCell>是否抽烟:</asp:TableCell><asp:TableCell><asp:Label ID="smokeift" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否喝酒:</asp:TableCell><asp:TableCell><asp:Label ID="drinkift" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>生活作息:</asp:TableCell><asp:TableCell><asp:Label ID="dailylifet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>家务能力:</asp:TableCell><asp:TableCell><asp:Label ID="houseworkt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>做菜能力:</asp:TableCell><asp:TableCell><asp:Label ID="cookt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否有养宠物的习惯:</asp:TableCell><asp:TableCell><asp:Label ID="petift" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>存款习惯:</asp:TableCell><asp:TableCell><asp:Label ID="depositt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
            </div>
        <p>情感状况</p>
        <br />
        <div class="table6"   align="center"    >
        <asp:Table ID="Table6" runat="server" Height="150px" Width="45%" BorderWidth="1" BorderStyle="Outset" Font-Size="Larger">
        <asp:TableRow>
            <asp:TableCell>单身时间:</asp:TableCell><asp:TableCell><asp:Label ID="singletimet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>恋爱次数（请输入数字）:</asp:TableCell><asp:TableCell><asp:Label ID="lovenumt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>你认为维系情感最重要的因素:</asp:TableCell><asp:TableCell><asp:Label ID="keept" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>为什么想找恋人:</asp:TableCell><asp:TableCell><asp:Label ID="whyt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>上次情感结束的原因:</asp:TableCell><asp:TableCell><asp:Label ID="reasont" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
            </div>
        <p>品味生活</p>
        <br />
        <div class="table7"  align="center">
            <asp:Table ID="Table7" runat="server" Height="270px"  Width="45%" BorderWidth="1" BorderStyle="Outset" Font-Size="Larger"> 
        <asp:TableRow>
            <asp:TableCell>喜欢的旅游方式:</asp:TableCell><asp:TableCell><asp:Label ID="tript" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的体育活动:</asp:TableCell><asp:TableCell><asp:Label ID="activityt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的书籍类型:</asp:TableCell><asp:TableCell><asp:Label ID="booktypet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的电影:</asp:TableCell><asp:TableCell><asp:Label ID="moviet" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的书:</asp:TableCell><asp:TableCell><asp:Label ID="bookt" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的音乐:</asp:TableCell><asp:TableCell><asp:Label ID="musict" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>关注的媒体内容:</asp:TableCell><asp:TableCell><asp:Label ID="mediat" runat="server"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
            </div>
        <br />
        <br />  
         <asp:Button ID="ChangeInfo" runat="server" Text="修改个人信息" OnClick="ChangeInfo_Click" />
    </form>
       </div>
</asp:Content>

