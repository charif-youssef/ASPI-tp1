<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="monweeb.aspx.cs" Inherits="WebApplication1.monweeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <div style="height: 30px">
                <asp:Label ID="Label1" runat="server" Text="donner votre nom"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged" Width="151px" style="margin-top: 1px" ></asp:TextBox>
                
            </div>
            <div style="height: 39px">
                  <asp:Label ID="Label2" runat="server" Text="indice" ></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged" Width="159px" style="margin-top: 1px" ></asp:TextBox>
                
            </div>
            <div style="height: 67px">
                  <asp:Label ID="Label3" runat="server"  Text="longeur"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" Height="24px" OnTextChanged="TextBox1_TextChanged" Width="159px" style="margin-top: 1px" ></asp:TextBox>
                
                  <asp:Button ID="Button1" runat="server" ForeColor="Maroon" OnClick="Button1_Click1" Text="Button" Width="88px" />
                
            </div>
            <div>
             <asp:Label ID="Label4" runat="server" ForeColor="Black" BackColor="#0033CC"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
