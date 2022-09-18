<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Projekt_w64238.WebForm1" %>

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

<div id="content">
    <div id="mainc">
        <div id="maintext">We're a one of the best Car Rentals in Poland</div>
        <div><button type="button"><a href="/WebForm2.aspx">Search your dream car</a></button></div>
    </div>
    <div id="container">
         <div class="box" id="box1">
                <div class="boxtitle">Big choice.</div>
                <div class="boxcontent">
                    We have huge amount of available cars in our car rental. It makes You able to find a car you need.
                </div>
        </div>
        <div class="box" id="box2">
                <div class="boxtitle">Great prizes.</div>
                <div class="boxcontent">
                    In comparison to other car rentals our prizes are lower, so you can rent your dream car in dream prize.
                </div>
        </div>
        <div class="box" id="box3">
                <div class="boxtitle">Quick rents.</div>
                <div class="boxcontent">
                    Due to our site, You are able to rent a car within 5 minutes or even less. All you need is a account and a credit card connected.
                    </div>
        </div>
    </div>
        <div id="footercontent">
Projekt Szkolenie Techniczne 2 - Kamil Wierdak w64238
    </div>
</div>
</div>
</body>
</html>
