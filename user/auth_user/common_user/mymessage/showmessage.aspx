﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="showmessage.aspx.cs" Inherits="user_auth_user_common_user_mymessage_showmessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<%for(int i=0;i<MsgCount;i++){ %>
		<p>内容:&nbsp;&nbsp;<%=MsgList[i]%>&nbsp;&nbsp;&nbsp;发送人:&nbsp;&nbsp;<%=SendPeopleList[i] %>&nbsp;&nbsp;&nbsp发送时间:&nbsp;&nbsp;<%=TimeList[i]%></p>&nbsp;&nbsp;<a href="<%=SetReadStatusUrl[i]%>"><%=DisplayConten%></a>&nbsp;&nbsp;<a href="<%=DelMsgUrl[i]%>">删除消息</a>
		<br />
	<%} %>
</asp:Content>

