<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Spring_Web_1.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1><asp:Label runat="server" ID="lblFramework"></asp:Label></h1>
    </div>
    <div>
        <a href="Customer/index.aspx">查询客户信息</a>
    </div>
   <%-- <div>
        <a href="ContextMonitor.ashx">查询当前应用程序的上下文</a>
    </div>
    <div>
        <a href="sessionTestDemo.aspx">Hibernate Session 测试</a>
    </div>--%>
    </form>
</body>
</html>
