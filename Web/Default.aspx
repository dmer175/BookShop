<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookShop.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <table>
        <tr>
            <th>编号</th>
            <th>类型</th>
            <th>父级编号</th>
        </tr>
        <%foreach (BookShop.Model.BookType booktype in List)
          {%>
              <tr>
                  <td><%=booktype.TypeId %></td>
                  <td><%=booktype.TypeTitle %></td>
                  <td><%=booktype.TypeParentId %></td>
              </tr>
         <% } %>
    </table>
</body>
</html>
