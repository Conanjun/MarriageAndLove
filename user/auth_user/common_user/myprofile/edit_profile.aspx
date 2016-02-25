<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="edit_profile.aspx.cs" Inherits="user_auth_user_common_user_myprofile_edit_profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
      #ContentPlaceHolder1_submit{
             
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
      <div class="div2" ><img src="/static/image/gerenxinxi.png" class="img2">&nbsp&nbsp;个人信息</div>
		<img src="/static/image/11.png">
        <form id="form1" runat="server" align="center">
         <p>个人资料：基本资料</p>
    <br/>
         <div class="table1" align="center">
    <asp:Table ID="Table1" runat="server" Height="270px" Width="45%"  GridLines="Vertical" HorizontalAlign="Center" BorderStyle="Outset" BorderWidth="1">
        <asp:TableRow>
            <asp:TableCell>姓名（必填）</asp:TableCell><asp:TableCell><asp:TextBox ID="namet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>性别（必填）</asp:TableCell><asp:TableCell><asp:TextBox ID="sext" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>年龄（必填，请输入数字，必须在18至60之间）</asp:TableCell><asp:TableCell><asp:TextBox ID="aget" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>身高（必填，请输入数字，单位cm，必须在150至200之间）</asp:TableCell><asp:TableCell><asp:TextBox ID="heightt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>学历（必填）</asp:TableCell><asp:TableCell><asp:TextBox ID="degreet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>月薪（必填，请输入数字，单位元）</asp:TableCell><asp:TableCell><asp:TextBox ID="salaryt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>现在办公地址</asp:TableCell><asp:TableCell><asp:DropDownList ID="Province" runat="server" AutoPostBack="True" onselectedindexchanged="Province_SelectedIndexChanged"></asp:DropDownList>
    <asp:DropDownList ID="City" runat="server" AutoPostBack="True" onselectedindexchanged="City_SelectedIndexChanged"></asp:DropDownList>
    <asp:DropDownList ID="District" runat="server"></asp:DropDownList>详细地址<asp:TextBox ID="AddressDetail" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>婚姻状况（必填）</asp:TableCell><asp:TableCell><asp:TextBox ID="marriaget" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>籍贯（必填）</asp:TableCell><asp:TableCell><asp:TextBox ID="nativeplacet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
             </div>
    <p>个人资料：详细资料</p>
    <br />
            <div class="table2"  align="center">
    <asp:Table ID="Table2" runat="server" Height="330px" Width="45%"  BorderWidth="1" BorderStyle="Outset">
        <asp:TableRow>
            <asp:TableCell>昵称（必填）</asp:TableCell><asp:TableCell><asp:TextBox ID="nicknamet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>体重（必填，单位公斤）</asp:TableCell><asp:TableCell><asp:TextBox ID="weightt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>血型</asp:TableCell><asp:TableCell><asp:TextBox ID="bloodt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>民族</asp:TableCell><asp:TableCell><asp:TextBox ID="nationt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>属相</asp:TableCell><asp:TableCell><asp:TextBox ID="animaltypet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>宗教信仰</asp:TableCell><asp:TableCell><asp:TextBox ID="religiont" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>星座</asp:TableCell><asp:TableCell><asp:TextBox ID="horoscopet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>发型</asp:TableCell><asp:TableCell><asp:TextBox ID="hairtypet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>脸型</asp:TableCell><asp:TableCell><asp:TextBox ID="facetypet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>居住状况</asp:TableCell><asp:TableCell><asp:TextBox ID="homeift" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>购车状况</asp:TableCell><asp:TableCell><asp:TextBox ID="cart" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
                 </div>
    <p>家庭背景</p>
    <br />
             <div class="table3"  align="center">
        <asp:Table ID="Table3" runat="server" Height="150px" Width="45%"  BorderWidth="1" BorderStyle="Outset">
        <asp:TableRow>
            <asp:TableCell>家庭地址</asp:TableCell><asp:TableCell><asp:TextBox ID="homeaddresst" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>父母情况</asp:TableCell><asp:TableCell><asp:TextBox ID="parentst" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>家中排行</asp:TableCell><asp:TableCell><asp:TextBox ID="homerankt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>有无子女</asp:TableCell><asp:TableCell><asp:TextBox ID="childrenift" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>子女监护人</asp:TableCell><asp:TableCell><asp:TextBox ID="childprotectort" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
                  </div>
        <p>婚姻期望</p>
        <br />
             <div class="table4"  align="center">
        <asp:Table ID="Table4" runat="server" Height="150px" Width="45%" BorderWidth="1" BorderStyle="Outset">
        <asp:TableRow>
            <asp:TableCell>结婚时间</asp:TableCell><asp:TableCell><asp:TextBox ID="marrytimet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>婚礼方式</asp:TableCell><asp:TableCell><asp:TextBox ID="marrytypet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否愿意与父母同住</asp:TableCell><asp:TableCell><asp:TextBox ID="parentsift" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否要小孩</asp:TableCell><asp:TableCell><asp:TextBox ID="childift" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>对婚姻的看法</asp:TableCell><asp:TableCell><asp:TextBox ID="tomarriaget" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
                 </div>
        <p>生活习惯</p>
        <br />
            <div class="table5"   align="center">
        <asp:Table ID="Table5" runat="server" Height="210px" Width="45%" BorderWidth="1" BorderStyle="Outset">
        <asp:TableRow>
            <asp:TableCell>是否抽烟</asp:TableCell><asp:TableCell><asp:TextBox ID="smokeift" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否喝酒</asp:TableCell><asp:TableCell><asp:TextBox ID="drinkift" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>生活作息</asp:TableCell><asp:TableCell><asp:TextBox ID="dailylifet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>家务能力</asp:TableCell><asp:TableCell><asp:TextBox ID="houseworkt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>做菜能力</asp:TableCell><asp:TableCell><asp:TextBox ID="cookt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>是否有养宠物的习惯</asp:TableCell><asp:TableCell><asp:TextBox ID="petift" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>存款习惯</asp:TableCell><asp:TableCell><asp:TextBox ID="depositt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
                </div>
        <p>情感状况</p>
        <br />
             <div class="table6"   align="center"    >
        <asp:Table ID="Table6" runat="server" Height="150px" Width="45%" BorderWidth="1" BorderStyle="Outset">
        <asp:TableRow>
            <asp:TableCell>单身时间</asp:TableCell><asp:TableCell><asp:TextBox ID="singletimet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>恋爱次数（请输入数字）</asp:TableCell><asp:TableCell><asp:TextBox ID="lovenumt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>你认为维系情感最重要的因素</asp:TableCell><asp:TableCell><asp:TextBox ID="keept" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>为什么想找恋人</asp:TableCell><asp:TableCell><asp:TextBox ID="whyt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>上次情感结束的原因</asp:TableCell><asp:TableCell><asp:TextBox ID="reasont" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
                 </div>
        <p>品味生活</p>
        <br />
            <div class="table7" align="center">
            <asp:Table ID="Table7" runat="server" Height="270px" Width="45%" BorderWidth="1" BorderStyle="Outset">
        <asp:TableRow>
            <asp:TableCell>喜欢的旅游方式</asp:TableCell><asp:TableCell><asp:TextBox ID="tript" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的体育活动</asp:TableCell><asp:TableCell><asp:TextBox ID="activityt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的书籍类型</asp:TableCell><asp:TableCell><asp:TextBox ID="booktypet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的电影</asp:TableCell><asp:TableCell><asp:TextBox ID="moviet" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的书</asp:TableCell><asp:TableCell><asp:TextBox ID="bookt" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>喜欢的音乐</asp:TableCell><asp:TableCell><asp:TextBox ID="musict" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>关注的媒体内容</asp:TableCell><asp:TableCell><asp:TextBox ID="mediat" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
                </div>
            <br />
            <br />
            <asp:Button ID="submit" runat="server" Text="提交" OnClick="submit_Click" />
    </form>
</asp:Content>

