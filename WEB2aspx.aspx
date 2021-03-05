<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WEB2aspx.aspx.cs" Inherits="WebApplication1.WEB2aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            formailaire des radiobutton  n asp.net
        </div>
        <div style="height: 81px" id="bac">
            <asp:Panel ID="Panel1" runat="server" BackColor="#669999" Height="119px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>rouge</asp:ListItem>
                    <asp:ListItem>blue</asp:ListItem>
                    <asp:ListItem>vert</asp:ListItem>
                </asp:RadioButtonList>
                </asp:Panel>
         
        </div>
        <div>

        </div>
        <p>
   <asp:Button ID="Button1" runat="server" Text="Button" BackColor="#003300"  Font-Bold="True" Font-Italic="True" ForeColor="White" OnClick="Button1_Click"    />

        </p>
    </form>
</body>
</html>
