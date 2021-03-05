<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wab3ville.aspx.cs" Inherits="WebApplication1.wab3ville" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <div>
            <asp:Label ID="Label1" runat="server" Text="choisie la ville"></asp:Label><asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
                </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="affiche ville" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="affiche tout" />
            </div>
            <div>
                <asp:Label ID="affiche" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
