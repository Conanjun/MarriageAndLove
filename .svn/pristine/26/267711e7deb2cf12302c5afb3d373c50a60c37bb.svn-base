<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="show_by_type.aspx.cs" Inherits="user_auth_user_common_user_myissue_myissue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	<style type="text/css">
		.img2{
			width:100px;
			height:100px;
		}
		.div2 {
			font-size: 70px;
		}
		.div4{
			font-size:20px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	
	<form id="form1" runat="server">
    <div>
	    <table border=3>
	        <tr>
	            <td>
            	   <asp:datagrid id="NewsList" runat="server" PageSize="20" AutoGenerateColumns="False" HorizontalAlign="Center" AllowPaging="True" Width="100%" DataSourceID="SqlDataSourceTypename">
						<Columns>
							<asp:TemplateColumn>
								<ItemTemplate>
									
										<div class="div4" align="center">
																									   
												<a href='comment.aspx?article_id=<%# DataBinder.Eval(Container.DataItem, "article_id") %>'><%# DataBinder.Eval(Container.DataItem, "article_title") %></a>
											
										

										
											&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
											    <a href='comment.aspx?article_id=<%# DataBinder.Eval(Container.DataItem, "article_id") %>'>阅读全文</a>&nbsp;&nbsp;
											    <font color="#003399">文章类属</font>:<%# DataBinder.Eval(Container.DataItem, "type_name") %>&nbsp;&nbsp;&nbsp;<font color="#003399">发表时间</font>:<%# DataBinder.Eval(Container.DataItem, "article_date") %></div>
									
									<br />
								</ItemTemplate>
							</asp:TemplateColumn>
						</Columns>
						<PagerStyle NextPageText="next&gt;&gt;" PrevPageText="&lt;&lt;prev" PageButtonCount="20" Mode="NumericPages"></PagerStyle>
					</asp:datagrid>
					<asp:SqlDataSource ID="SqlDataSourceTypename" runat="server" ConnectionString="<%$ ConnectionStrings:MarriageAndLoveConnectionString %>"
                       SelectCommand="SELECT * FROM [article] WHERE (([username] = @username) AND ([type_name] = @type_name))">
						<SelectParameters>
							<asp:SessionParameter Name="username" SessionField="username" Type="String" />
							<asp:QueryStringParameter Name="type_name" QueryStringField="type_name" Type="String" />
						</SelectParameters>
                   </asp:SqlDataSource>
	            </td>
	        </tr>
			<div class="div2"><img src="/static/image/9.png" class="img2"/>&nbsp&nbsp<a href="Write.aspx">发表文章</a></div><img src="/static/image/11.png">
	    </table>
    </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="background" Runat="Server">
</asp:Content>

