<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webcolor.aspx.cs" Inherits="WebApplication1.Webcolor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 161px">
            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Width="137px" />
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="color de la zone: "></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="cordoné:  "></asp:Label>
        </p>
        <div style="width: 284px">
            <asp:CheckBox ID="CheckBox1" runat="server" Text="choisie un color" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
        &nbsp;
        </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" BorderStyle="None" TextAlign="Left" Width="83px" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="0">rouge</asp:ListItem>
            <asp:ListItem Value="1">vert</asp:ListItem>
            <asp:ListItem Value="2">gris</asp:ListItem>
            <asp:ListItem Value="3">blue</asp:ListItem>
        </asp:RadioButtonList>
        <div style="width: 287px">
              <asp:CheckBox ID="CheckBox2" runat="server" Text="taille" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" />
        </div>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
            <asp:ListItem Value="0">grand</asp:ListItem>
            <asp:ListItem Value="1">petite</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Panel ID="Panel1" runat="server" Height="54px" style="margin-left: 437px" Width="73px">
        </asp:Panel>
    </form>
</body>
</html>
