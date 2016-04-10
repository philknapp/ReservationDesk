<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservations.aspx.cs" Inherits="ReservationDesk.Reservations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


    <div>
            <asp:Label ID="Label7" runat="server" Text="Arrival Date:"></asp:Label>
            <asp:Label ID="arrivalError" runat="server" Text=""></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Number of Nights:"></asp:Label>
        <asp:TextBox ID="numberText" runat="server"></asp:TextBox>
            <asp:Label ID="numberError" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Room Type:  "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>King</asp:ListItem>
            <asp:ListItem>Queen</asp:ListItem>
            <asp:ListItem>2 Twins</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Guest First Name:"></asp:Label>
        <asp:TextBox ID="firstText" runat="server"></asp:TextBox>
            <asp:Label ID="firstError" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Guest Last Name:"></asp:Label>
        <asp:TextBox ID="lastText" runat="server"></asp:TextBox>
            <asp:Label ID="lastError" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Guest Email:"></asp:Label>
        <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
            <asp:Label ID="emailError" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Special Notes:"></asp:Label>
    
        <asp:TextBox ID="notesText" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Admin" />
    </div>
    </form>
</body>
</html>
