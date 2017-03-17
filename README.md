# 版本

1.1.1
  1.支持地区级联选择，部门级联选择，菜单分类级联选择等无限极分类操作
  2.自动创建多个下拉选择框

# 使用说明

$("#divArea").CascadeSelect({
	ajaxUrl: "/tools/CascadeSelect.ashx",
	isAutoAssignValue: true,
	selectDataList: $("#hidAreaId").val(),
	selectSplitChar: ','
});
1、需要将AJAXUrl切换成你服务器后台的URL,用于接收当前select元素选择的数据
2、页面需要引用Jquery库
3、相应的插件参数请看WIKI

# 技术支持

QQ:727692901
