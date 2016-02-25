<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="actionevaluate.aspx.cs" Inherits="actionevaluate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	<%-- Ajax 实时判断用户名是否存在--%>
	
	<script type="text/javascript">

	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<form id="form1" runat="server" class="form-horizontal">
		<fieldset>
			<legend>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 活动评价</legend>
			<asp:DropDownList ID="activity" runat="server" AutoPostBack="True"></asp:DropDownList>
            <p>请输入您对本次活动的评价（200字以内）</p>
           <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="60%" Height="60"></asp:TextBox>
            <br/><br/>
            <asp:Button ID="submit_button" runat="server" Text="提交" OnClick="submit_button_Click" />
		</fieldset>
    </form>
	
</asp:Content>

 
