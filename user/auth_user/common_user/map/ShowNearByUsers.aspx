﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowNearByUsers.aspx.cs" Inherits="user_auth_user_common_user_map_ShowNearByUsers2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	<meta http-equiv="Content-Type" content="text/html; charset=gbk">
	 <script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=yqYfrk8ClmehOV743RST9c8Z"></script>
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <style>
        #button{
             
    cursor: pointer;
    width: 100px;
    height: 44px;
    padding: 0;
    background:#80bbd5;
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
    font-size: 14px;
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
      <div class="div2" ><img src="/static/image/map.png" class="img2">&nbsp&nbsp;附近会员</div>
		<img src="/static/image/11.png">
	<div style="width:730px;margin:auto;">   
		<input type="button" id="button" value="查询附近会员" onclick="searchByStationName();"/>
        <div id="container" 
            style="position: absolute;
                margin-top:30px; 
                width: 800px; 
                height: 600px; 
                top: 50; 
                border: 1px solid gray;
                overflow:hidden;">
        </div>
    </div>
	<div style="visibility:hidden">
		<asp:Label runat="server" Text="test" ID="user_position"></asp:Label>
	</div>
	

<script type="text/javascript">

	var map = new BMap.Map("container");
	var user_pos = $("#<%=user_position.ClientID%>").val()
	//var user_pos = "广州";
	map.centerAndZoom(user_pos, 12); //将中心设置为该用户的地址，然后默认显示附近12范围内的人
	map.enableScrollWheelZoom();    //启用滚轮放大缩小，默认禁用
	map.enableContinuousZoom();    //启用地图惯性拖拽，默认禁用
	map.addControl(new BMap.NavigationControl());  //添加默认缩放平移控件
	map.addControl(new BMap.OverviewMapControl()); //添加默认缩略地图控件
	map.addControl(new BMap.OverviewMapControl({ isOpen: true, anchor: BMAP_ANCHOR_BOTTOM_RIGHT }));   //右下角，打开


	var localSearch = new BMap.LocalSearch(map);
	localSearch.enableAutoViewport(); //允许自动调节窗体大小
	searchByStationName();
	function searchByStationName() {
		map.clearOverlays();//清空原来的标注
		localSearch.setSearchCompleteCallback(function (searchResult) {
			var poi = searchResult.getPoi(0);
			map.centerAndZoom(poi.point, 13);
			var marker = new BMap.Marker(new BMap.Point(poi.point.lng, poi.point.lat));  // 创建标注，为要查询的地方对应的经纬度
			map.addOverlay(marker);
			//var content = document.getElementById("text_").value + "<br/><br/>经度：" + poi.point.lng + "<br/>纬度：" + poi.point.lat;
			//var infoWindow = new BMap.InfoWindow("<p style='font-size:14px;'>" + content + "</p>");
			//marker.addEventListener("click", function () { this.openInfoWindow(infoWindow); });
			marker.setAnimation(BMAP_ANIMATION_BOUNCE); //跳动的动画
		});

		
		//var nearbyAddr = new Array("广州火车站", "广州塔（赤岗塔）", "广州动物园", "天河公园");

		//利用ajax Json获取后台传过来的对象:附近的人地址列表
		var NearbyPeoplePosList;
		var NearbyPeoplePosCount;
		$.getJSON("GetNearbyUsers.ashx", { username: "<%=Session["username"]%>" }, function (result) {
			NearbyPeoplePosList = result.nearby_users;
			NearbyPeoplePosCount = result.nearby_users_count;
			for (i = 0; i < NearbyPeoplePosCount; i++) {
				localSearch.search(NearbyPeoplePosList[i]);//使用ajax传送对象才行
			}
		});
		//alert("enter the ajax");
		
	}
	//searchByStationName(nearbyAddr);
</script>
</asp:Content>

