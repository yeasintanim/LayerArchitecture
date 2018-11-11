<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntryUI.aspx.cs" Inherits="StudentWebApp.UI.StudentEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Reg No"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox></td>
            </tr>
            
             <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
            </tr>
            
             <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label></td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
            </tr>
            
             <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label></td>
                <td>
                    <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox></td>
            </tr>
            
             <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label></td>
                <td>
                    <asp:TextBox ID="departmentTextBox" runat="server"></asp:TextBox></td>
            </tr>
            
             <tr>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" /></td>
                <td>
                    <asp:Label ID="outputLabel" runat="server"></asp:Label>
                 </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
