<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="6HW.aspx.cs" Inherits="_6HW._6HW" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <asp:TextBox ID="tb_Name" runat="server" ></asp:TextBox><br />
            <asp:Button ID="btn_Del" runat="server" Text="刪除" OnClick="btn_Del_Click" />
    </form>
</body>
</html>
