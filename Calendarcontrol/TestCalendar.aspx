<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestCalendar.aspx.cs" Inherits="Calendarcontrol.TestCalendar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Calendar ID="testcalendar" runat="server" Height="526px" Width="1004px" Visible="false"></asp:Calendar>
    <br />
    <div>
        <asp:Label ID="lblStatus" runat="server"></asp:Label><br />
        <asp:TextBox ID="txtConnString" runat="server" TextMode="MultiLine" Rows="3" Columns="100"></asp:TextBox><br />
        <asp:Button ID="btnTestConnection" runat="server" Text="Test Connection to MSSQL" OnClick="btnTestConnection_Click" />
    </div>
    </form>
</body>
</html>
