<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="lab01.demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nhập Họ Tên
            <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
            <asp:Button ID="btGui" runat="server" Text="Gửi" OnClick="btGui_Click"/>
            <br />
            <asp:Label ID="lbChao" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
