<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Projekt_w64238.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Styles/sheet.css"/>
    <title></title>
</head>
<body>
       <div id="containermain">
<header>
    <div id="logo">Car Rental.</div>
    <nav>
        <ul>
            <li><a href="/WebForm1.aspx">Home</a></li>
            <li><a href="/WebForm2.aspx">Cars</a></li>
            <li><a href="/WebForm4.aspx">Rents</a></li>
        </ul>
    </nav>
    <div class="menu-toggle"></div>
</header>
    <form id="form1" runat="server">
        <div id="maincontainer">
            <asp:Image ID="ImageCar"  CssClass="carImage" runat="server" />
            <div id="container2">
                <div id="container7">
                <div id="container3">
                        <asp:Label ID="BrandLb" CssClass="label" runat="server"></asp:Label>
                        <asp:Label ID="ModelLb" CssClass="label" runat="server"></asp:Label>
                 </div>
                <div id="container4">
                        <asp:Label ID="CapacityLb" CssClass="label" runat="server"></asp:Label>
                        <asp:Label ID="ProductionYearLb" CssClass="label" runat="server"></asp:Label>
                        <asp:Label ID="HPLb" CssClass="label" runat="server"></asp:Label>
                </div>
                    </div>
                <div id="container8">
                <div id="container5">
                    <asp:Calendar ID="Calendar1" runat="server"  ForeColor="white" OnSelectionChanged="OutDateChange"></asp:Calendar>
                    <asp:TextBox ID="OutDateDP" runat="server" Width="250px" ReadOnly="true"  AutoPostBack="True" placeholder="When rent starts"  Height="32px" ></asp:TextBox>
                   
                </div>
                <div id="container6">
                     <asp:Calendar ID="Calendar2" runat="server" ForeColor="white" OnSelectionChanged="InDateChange" ></asp:Calendar>
                    <asp:TextBox ID="InDateDP" runat="server" Width="250px" ReadOnly="true"  placeholder="When rent ends"  AutoPostBack="True" Height="32px" ></asp:TextBox>
                </div>
                <asp:TextBox ID="PrizeTbx" CssClass="txtb" runat="server" placeholder="total prize"></asp:TextBox>
                <asp:Button ID ="RentBt" CssClass="button" runat="server" Text="Rent" OnClick="RentBT_Click" />
                    </div>
            </div>
        </div>

    </form>

   <div id="footercontent">Projekt Szkolenie Techniczne 2 - Kamil Wierdak w64238</div>
</body>
</html>
