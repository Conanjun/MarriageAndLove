﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="admin_manage.aspx.cs" Inherits="admin_admin_manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label" align="center"  runat="server" Text="会员管理"></asp:Label>
		<br />
	<form id="form1" runat="server" >

		
		<br />
		<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="183px" Width="1000px" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" PageSize="4" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged2" OnRowDeleting="GridView1_RowDeleting" onrowupdating="GridView1_RowUpdating"
             onrowcancelingedit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing1">
			<AlternatingRowStyle BackColor="White" />
			
			<Columns>
				<asp:BoundField DataField="username" HeaderText="会员名" SortExpression="username" />
				<asp:BoundField DataField="useremail" HeaderText="邮箱" SortExpression="useremail" />
				<asp:BoundField DataField="userphone" HeaderText="手机" SortExpression="userphone" />
				<asp:BoundField DataField="tempstatus" HeaderText="状态" SortExpression="tempstatus" />
				<asp:BoundField DataField="temprank" HeaderText="等级" SortExpression="temprank" />
				<asp:CommandField ShowDeleteButton="True" />
				<asp:CommandField ShowEditButton="True" />
			</Columns>
			


			<EditRowStyle BackColor="#7C6F57" />
			<FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
			<HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
			<RowStyle BackColor="#E3EAEB" />
			<SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
			<SortedAscendingCellStyle BackColor="#F8FAFA" />
			<SortedAscendingHeaderStyle BackColor="#246B61" />
			<SortedDescendingCellStyle BackColor="#D4DFE1" />
			<SortedDescendingHeaderStyle BackColor="#15524A" />
		</asp:GridView>
	</form>

		
		<br />		

</asp:Content>

