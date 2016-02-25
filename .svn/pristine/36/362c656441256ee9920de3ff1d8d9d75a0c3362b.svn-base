<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="myissue.aspx.cs" Inherits="user_auth_user_common_user_myissue_myissue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	<style>
		.div2{
			font-size:50px;
		}
		.img2{
			width:100px;
			height:100px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	 <form id="form1" runat="server">
	<div class="div2"><img src="<%=ROOTPATH %>/static/image/longaisifangcai.png" class="img2"/>&nbsp&nbsp;龙爱私房菜</div><img src="<%=ROOTPATH %>/static/image/11.png"><br />
	<br />
    <div align="left">
			   
				
                            <asp:DataList ID="DataList1" runat="server" Style="position: relative" DataSourceID="SqlDataSourceTypeTo">
                                <ItemTemplate>
                                  <div align="center"><a href='show_by_type.aspx?type_name=<%# DataBinder.Eval(Container.DataItem, "type_name") %>'><%# DataBinder.Eval(Container.DataItem, "type_name")%><font style="FONT-SIZE: 14px"></font></a></div>
								  <br />
								 </ItemTemplate>
                            </asp:DataList>
                            <asp:SqlDataSource ID="SqlDataSourceTypeTo" runat="server" ConnectionString="<%$ ConnectionStrings:MarriageAndLoveConnectionString %>"
                               SelectCommand="SELECT DISTINCT [type_name] FROM [viewtype]">
                            </asp:SqlDataSource>
							<br />
        </div>
		
		
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="background" Runat="Server">
</asp:Content>