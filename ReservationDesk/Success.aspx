<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="ReservationDesk.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="successLabel" runat="server" Text="You have successfully created the following Reservation: "></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="515px" Width="365px"></asp:TextBox>
        <br />
    
    </div>
    </form>
</body>
</html>
