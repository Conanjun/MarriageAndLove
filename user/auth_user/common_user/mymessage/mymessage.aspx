<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="mymessage.aspx.cs" Inherits="user_auth_user_common_user_mymessage_mymessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
		<link rel="stylesheet" type="text/css" href="css/component.css" /> 
		<script src="js/modernizr.custom.js"></script>
		<script type="text/javascript" src="http://www.codefans.net/ajaxjs/jquery-1.6.2.min.js"></script>
<script type="text/javascript">
    $(function () {
        $("table tr:nth-child(odd)").addClass("odd-row");
        $("table td:first-child, table th:first-child").addClass("first");
        $("table td:last-child, table th:last-child").addClass("last");
    });
</script>
<style type="text/css">
html, body, div, span, object, iframe,h1, h2, h3, h4, h5, h6, p, blockquote, pre,abbr, address, cite, code,del, dfn, em, img, ins, kbd, q, samp,
small, strong, sub, sup, var,b, i,dl, dt, dd, ol, ul, li,fieldset, form, label, legend,table, caption, tbody, tfoot, thead, tr, th, td {
	margin:0;
	padding:0;
	border:0;
	outline:0;
	font-size:100%;
	vertical-align:baseline;
	background:transparent;
}
a {color:#666;}
#content {width:65%; max-width:690px; margin:6% auto 0;}
table {
	overflow:hidden;
	border:1px solid #d3d3d3;
	background:#fefefe;
	width:70%;
	margin:0 auto 0;
	-moz-border-radius:5px; /* FF1+ */
	-webkit-border-radius:5px; /* Saf3-4 */
	border-radius:5px;
	-moz-box-shadow: 0 0 4px rgba(0, 0, 0, 0.2);
	-webkit-box-shadow: 0 0 4px rgba(0, 0, 0, 0.2);
}
th, td {padding:18px 28px 18px; text-align:center; }
th {padding-top:22px; text-shadow: 1px 1px 1px #fff; background:#e8eaeb;}
td {border-top:1px solid #e0e0e0; border-right:1px solid #e0e0e0;}
tr.odd-row td {background:#f6f6f6;}
td.first, th.first {text-align:center}
td.last {border-right:none;}
td {
	background: -moz-linear-gradient(100% 25% 90deg, #fefefe, #f9f9f9);
	background: -webkit-gradient(linear, 0% 0%, 0% 25%, from(#f9f9f9), to(#fefefe));
}
tr.odd-row td {
background: -moz-linear-gradient(100% 25% 90deg, #f6f6f6, #f1f1f1);
background: -webkit-gradient(linear, 0% 0%, 0% 25%, from(#f1f1f1), to(#f6f6f6));
}
th {
	background: -moz-linear-gradient(100% 20% 90deg, #e8eaeb, #ededed);
	background: -webkit-gradient(linear, 0% 0%, 0% 20%, from(#ededed), to(#e8eaeb));
}
tr:first-child th.first {
	-moz-border-radius-topleft:5px;
	-webkit-border-top-left-radius:5px; /* Saf3-4 */
}
tr:first-child th.last {
	-moz-border-radius-topright:5px;
	-webkit-border-top-right-radius:5px; /* Saf3-4 */
}
tr:last-child td.first {
	-moz-border-radius-bottomleft:5px;
	-webkit-border-bottom-left-radius:5px; /* Saf3-4 */
}
tr:last-child td.last {
	-moz-border-radius-bottomright:5px;
	-webkit-border-bottom-right-radius:5px; /* Saf3-4 */
}
.img2{
    width:100px;
    height:100px;
}
.img3{
    width:50px;
    height:50px;
}
  .div2{
	font-size: 50px;
}

</style>
    <script type="text/javascript">
        function getMessage() {
            $.getJSON("MessageDeal.ashx", { recv_username: "<%=Session["username"]%>" }, function (result) {
		        $("#<%=Label2.ClientID%>").text(result.message_unread_count);
			    $("#<%=Label4.ClientID%>").text(result.message_read_count);
			    $("#<%=Label6.ClientID%>").text(result.message_read_count + result.message_unread_count);
			}
			)
        }
        setInterval(getMessage, 10000);//每10秒更新一次数据
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="div2" ><img src="/static/image/touming.png" class="img2">&nbsp&nbsp我的消息</div>
		<img src="/static/image/11.png">
		<form id="form1" runat="server" align="center">
	<table border="2">
		<tr>
			<th>未读消息</th>
			<td><asp:Label ID="Label2" runat="server" Text="0"></asp:Label>&nbsp;&nbsp;&nbsp;</td>
			<td><a href="showmessage.aspx?kind=unread"><img class="img3" src="/static/image/002.png"/>查看未读消息</a></td>
		</tr>
		<tr>
			<th>已读消息</th>
			<td><asp:Label ID="Label4" runat="server" Text="0"></asp:Label> &nbsp;&nbsp;&nbsp;</td>
			<td><a href="showmessage.aspx?kind=read"><img class="img3" src="/static/image/001.png"/>查看已读消息</a></td>
		</tr>
		<tr>
			<th>所有消息</th>
			<td>
			<asp:Label ID="Label6" runat="server" Text="0"></asp:Label> &nbsp;&nbsp;&nbsp;
			</td>
			<td><a href="showmessage.aspx?kind=all"><img class="img3" src="/static/image/003.png"/>查看所有消息</a></td>
		</tr>
	</table>
    <br />
    <br />
    <br />
    <br />
    <br />
		
		<%--<asp:Label ID="Label1" runat="server" Text="未读消息"></asp:Label>--%> &nbsp;&nbsp;&nbsp;
		<%--<asp:Label ID="Label2" runat="server" Text="0"></asp:Label>--%>&nbsp;&nbsp;&nbsp;
		<%--<a href="showmessage.aspx?kind=unread">查看未读消息</a>--%>
		<br />
		<br />
		<%--<asp:Label ID="Label3" runat="server" Text="已读消息"></asp:Label> &nbsp;&nbsp;&nbsp;--%>
		<%--<asp:Label ID="Label4" runat="server" Text="0"></asp:Label>--%> &nbsp;&nbsp;&nbsp;
		<%--<a href="showmessage.aspx?kind=read">查看已读消息</a>--%>
		<br />
		<br />
		<%--<asp:Label ID="Label5" runat="server" Text="所有消息"></asp:Label>--%> &nbsp;&nbsp;&nbsp;
		<%--<asp:Label ID="Label6" runat="server" Text="0"></asp:Label>--%> &nbsp;&nbsp;&nbsp;
		<%--<a href="showmessage.aspx?kind=all">查看所有消息</a>--%>
	<br />
    <br />
    <br />
	<%--<button onclick="getMessage()">此处为ajax自动实时刷新消息功能，也可手动点击刷新</button>--%>
        </form>
</asp:Content>

