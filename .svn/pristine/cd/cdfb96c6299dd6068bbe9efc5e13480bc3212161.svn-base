<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Write.aspx.cs" Inherits="Write"%>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<form id="form1" runat="server">
    <table align=center border=3>
        <tr>
            <td colspan="2">
                <center><strong><font color="#aa2222">添加文章</font></strong></center></td>
        </tr>
        <tr>
            <td style="width: 100px">
                标题</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBoxTitle" runat="server" Style="position: relative"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td style="width: 100px">
                作者</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBoxAuthor" runat="server" Style="position: relative"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 100px">
                类别</td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownListType" runat="server" Style="position: relative" DataSourceID="SqlDataSourceTypeSelect" DataTextField="type_name" DataValueField="type_id">
                </asp:DropDownList><asp:SqlDataSource ID="SqlDataSourceTypeSelect" runat="server" ConnectionString="<%$ ConnectionStrings:MarriageAndLoveConnectionString %>" SelectCommand="SELECT [type_id], [type_name] FROM [viewtype]">
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 48px;">
                内容</td>
            <td style="width: 100px; height: 48px;">
                <textarea id="TextareaContent" style="position: relative; width: 360px; height: 100px;" runat=server></textarea>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
               <asp:Button ID="ButtonAdd" runat="server" Style="position: relative" Text="添加" OnClientClick="return confirm('确定要添加吗?')" OnClick="ButtonAdd_Click"/>
            </td>
        </tr>
    </table>
		</form>
</asp:Content>

