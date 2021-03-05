<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webmontran.aspx.cs" Inherits="WebApplication1.Webmontran" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 310px" >
            <div style="height: 71px">
            <asp:Label ID="Label1" runat="server" Text="conversion"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" BorderColor="Black" Width="143px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="DollarS U.S en"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="23px" style="margin-left: 0px" Width="118px">
            </asp:DropDownList>

                <asp:Button ID="Button1" runat="server" CssClass="buttonok" OnClick="Button1_Click" Text="Button" />

            </div>
             <div style="height: 39px">
                 <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
            <div>
                 <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="modegrafique" />
            </div>
            <div style="height: 203px">

               
                <asp:Image ID="Image1" runat="server" Height="283px" style="margin-top: 35px" Visible="False" Width="843px" />

            </div>
        </div>
       
    </form>
</body>
</html>
