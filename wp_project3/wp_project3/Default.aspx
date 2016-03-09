
<head>
    <style type="text/css">
        #form1 {
            height: 525px;
        }
    </style>
</head>
<form id="form1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="SimpleCalc"></asp:Label>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="91px">
        <asp:ListItem>add</asp:ListItem>
        <asp:ListItem>subtract</asp:ListItem>
        <asp:ListItem>multiply</asp:ListItem>
        <asp:ListItem>divide</asp:ListItem>
    </asp:CheckBoxList>
    <asp:Label ID="Label1" runat="server" Text="ComplexCalc"></asp:Label>
    <asp:CheckBoxList ID="CheckBoxList2" runat="server" Height="107px" Width="90px">
        <asp:ListItem>add</asp:ListItem>
        <asp:ListItem>subtract</asp:ListItem>
        <asp:ListItem>multiply</asp:ListItem>
        <asp:ListItem>divide</asp:ListItem>
    </asp:CheckBoxList>
    <asp:Button ID="Button1" runat="server" Text="makeCalc" />
</form>

