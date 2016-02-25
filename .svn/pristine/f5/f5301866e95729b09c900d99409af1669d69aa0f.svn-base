<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="activity_release.aspx.cs" Inherits="admin_activity_release" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label" runat="server" Text="活动发布"></asp:Label>
		<br />
	<form id="form1" runat="server">
        <fieldset>
			<legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 活动发布</legend>
			<table ID="Table1" runat="server" height="250px" width="500px">
			<tr><td width="200">&nbsp;&nbsp; &nbsp;活动名</td><td width="200">
				<asp:TextBox ID="activityname" runat="server"></asp:TextBox>
				</td>
				</tr>
			
	
			
			<tr><td width="200">&nbsp;&nbsp; &nbsp;活动时间</td><td width="200">
                <asp:TextBox ID="activitytime" runat="server"></asp:TextBox>
				</td><td width="100"><div id="check_user_result"></div></td></tr>
			<tr><td width="200">&nbsp;&nbsp;&nbsp;&nbsp; 活动地点</td><td width="300">
                <asp:DropDownList ID="Province" runat="server" AutoPostBack="True" onselectedindexchanged="Province_SelectedIndexChanged"></asp:DropDownList>
    <asp:DropDownList ID="City" runat="server" AutoPostBack="True" onselectedindexchanged="City_SelectedIndexChanged"></asp:DropDownList>
    <asp:DropDownList ID="District" runat="server"></asp:DropDownList>
				<p>详细地址</p><asp:TextBox ID="activityplace" runat="server"></asp:TextBox>
				</td></tr>
			<tr><td width="200">&nbsp;&nbsp;&nbsp;&nbsp; 活动内容简介</td><td width="200">
				<asp:TextBox ID="activityintroduction" runat="server"></asp:TextBox>
				</td><td width="100"><div id="check_password_result">test</div></td></tr>
			<tr><td width="300">

                <asp:Button ID="release_button" runat="server" Text="发布活动" OnClick="release_button_Click" style="height: 21px" />
				</td></tr>
			</table>
            <table>
                <tr>
                    <td>活动名</td><td>活动时间</td><td>活动地点</td><td>参与人数</td><td>活动状态</td>
                </tr>
                <%for(int i=0;i<activitycount;i++){ %>
                <tr>
                    <td><p><%=activitylist[i]%></p></td>
                    <td><p><%=activitytimelist[i]%></p></td>
                    <td><p><%=activityplacelist[i]%></p></td>
                    <td><p><%=activityjoinnumlist[i]%></p></td>
                    <td><p><%=activitystatuslist[i]%></p></td>
                </tr>
                    <%} %>
            </table>
	</form>

		
		<br />		


</asp:Content>

