﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagerAdd.aspx.cs" Inherits="BookShop.Web.Admin.UserManagerAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" method="post">
        用户ID:<input type="text" name="uid"/><br />
        用户名:<input type="text" name="uname"/>
        <br />
        密码:<input type="password" name="upwd"/>
        <br />
        <input type="submit" value="添加" />
    </form>
</body>
</html>
