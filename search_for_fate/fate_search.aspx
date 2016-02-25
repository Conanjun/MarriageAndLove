<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="fate_search.aspx.cs" Inherits="search_for_fate_fate_search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <style>
        #ContentPlaceHolder1_Button1{
             
    cursor: pointer;
    width: 120px;
    height: 44px;
    padding: 0;
    background:#de388f;
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
    font-size: 3px;
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
    	<div class="div2"><img src="/static/image/search.png" class="img2"/>&nbsp&nbsp姻缘搜索</div><img src="/static/image/11.png"><br />
    <div class="fate" align="center">
	 <form id="form1" runat="server">
        
         
		 <div >
             <asp:Image ID="Image1" src="/static/image/2.gif" runat="server" />
        
		  <br />
		<asp:Button ID="Button1" runat="server" Text="点击获取你的有缘人" OnClick="Button1_Click" />
		 &nbsp;&nbsp; <font  size="5" face="verdana" color="black"><asp:Label ID="Label1" runat="server"  Text="有缘人会员名:"></asp:Label></font>
    
    &nbsp;&nbsp;&nbsp;	
		<asp:Label ID="Label2" runat="server" Text=""></asp:Label>
          </div>
           
    <div>
		
    
    </div>
    </form>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="background" Runat="Server">
</asp:Content>

