<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhToan.aspx.cs" Inherits="lab01.TinhToan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 31%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            font-size: xx-large;
            background-color: #33CCFF;
        }
        .auto-style4 {
            text-align: center;
            height: 23px;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
            width: 196px;
        }
        .auto-style7 {
            width: 196px;
        }
        .auto-style8 {
            height: 23px;
            width: 196px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style4" colspan="4"><strong><span class="auto-style3">Tính toán đơn giản</span></strong></td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nhập số 1:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtnum1" runat="server" BackColor="#FF9900"></asp:TextBox>
                    </td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nhập số 2:</td>
                    <td>
                        <asp:TextBox ID="txtnum2" runat="server" BackColor="#FF66FF"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Button ID="btCong" runat="server" Text="Cộng " OnClick="btCong_Click" BackColor="#CC00FF"/>
                        <asp:Button ID="btTru" runat="server" Text="Trừ" OnClick="btTru_Click" BackColor="#66CCFF" />
                        <asp:Button ID="btNhan" runat="server" Text="Nhân" OnClick="btNhan_Click" />
                        <asp:Button ID="btChia" runat="server" Text="Chia" OnClick="btChia_Click" />
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kết quả:</td>
                    <td>
                        <asp:TextBox ID="txtkq" runat="server" BackColor="#00FF99"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
