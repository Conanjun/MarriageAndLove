﻿
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="comment.aspx.cs" Inherits="user_auth_user_common_user_myissue_comment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	 <form id="form1" runat="server">
    <div>
		<table>			
				<tr>
					<td>
						<table width="960px">
						    <tr>
						        <td>
						            <%get_News(); %>							        
						        </td>
						    </tr>
						    <tr>
						        <td>
						            <%get_Replay();%>
						        </td>
						    </tr>
						</table>
						<table width="100%" border="3" align="center">
							<tr>
								<td  height="20" align="center"><div>用户名：</div>
								</td>
								<td width="82%">
									<asp:TextBox id="r_nick" runat="server"></asp:TextBox>
								</td>
							</tr>
							
							<tr>
							    <td align=center>留言对象</td>
							    <td><%getList();%></td>
							</tr>
							
							<tr>
								<td height="20"><div align="center">标题：</div>
								</td>
								<td>
									<asp:TextBox id="r_title" runat="server" Width="260px"></asp:TextBox>
								</td>
							</tr>
							<tr>
								<td style="height: 23px"><div align="center">内容：</div>
								</td>
								<td style="height: 23px">
                                    <textarea id="r_content" style="position: relative; width: 500px; height: 50px;" runat=server></textarea>
                                </td>
							</tr>
							<tr>
								<td height="20">
								</td>
							    <td>
						        	<asp:Button id="replay" runat="server" Text="评论" OnClientClick="return confirm('确认要评论吗？');" OnClick="replay_Click"></asp:Button></td>
							</tr>
						</table>
					</td>
				</tr>
		</table>
    </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="background" Runat="Server">
</asp:Content>

