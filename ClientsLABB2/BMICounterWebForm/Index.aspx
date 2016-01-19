<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BMICounterWebForm.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Weight in kilos:"></asp:Label>
        <br />
        <asp:TextBox ID="WeightBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Height in cm:"></asp:Label>
        <br />
        <asp:TextBox ID="HeightBox" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="BMIButton" runat="server" OnClick="BMIButton_Click" Text="Click it!" />
        <br />
        <asp:Label ID="ResultLabel" runat="server" Text="Result:"></asp:Label>
    
    </div>
    </form>
</body>
</html>
