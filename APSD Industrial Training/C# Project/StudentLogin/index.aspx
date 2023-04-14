<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="StudentLogin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
        <form id="form1" runat="server">
            <table style="background-color:aqua;color:#333;padding:10px;margin-top:200px">
                <tr>
                    <td>
                        Name :
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Roll No :
                    </td>
                    <td>
                        <asp:TextBox ID="txtRoll" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Mobile No :
                    </td>
                    <td>
                        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email :
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr style="text-align:center">
                    <td colspan="2"><asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Text="Save"/></td>
                </tr>
            </table>
        </form>
        </center>
</body>
</html>
