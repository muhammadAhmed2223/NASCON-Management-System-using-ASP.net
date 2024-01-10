﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Admin Login</title>
    <link  rel="stylesheet" href="StyleSheet.css" />
</head>

<body style="text-align:center">

    <div class="navbar" style="box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);">
        <a class="active" href="Home.aspx"><b>Home</b></a>
        <div class="dropdown">
            <button class="dropbtn"><b>Login</b></button>
            <div class="dropdown-content">
                <a href="StudentLogin.aspx">Executive Student</a>
                <a href="MentorLogin.aspx">Faculty Mentor</a>
            </div>
        </div>
        <a href="Home.aspx#Events"><b>Events</b></a>
        <a href="Home.aspx#Contact"><b>Contact</b></a>
        <a href="Home.aspx#About"><b>About</b></a>
        <img src="HeadImage.jpeg" alt="logo" style="height:50px; width:50px; float: right; padding-right:30px"/>
    </div>

    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>

    <div style="text-align:center">
        <img src="Logo.png" alt ="logo"/>
        <br />
        <p style="font-size:x-large; font-family:Garamond; color:#262626">
            <b>WHERE TALENT MEETS OPPORTUNITY</b>
        </p>
    </div>
    <br />
    <br />

    <form id="form1" runat="server">

    <!--Welcome text -->
    <h1>Admin Login</h1>
       
    <h5>Email ID</h5>
        <asp:TextBox ID="TextBox1" runat="server" required="required"></asp:TextBox>
        <h5>Password</h5>
        <asp:TextBox ID="TextBox2" runat="server" required="required"></asp:TextBox>
        <p style="font-size:x-small; color:red"><%= msg %> </p>
        <asp:Button ID="Button2" Class="BtnClass" runat="server" Text="Login" OnClick="Button2_Click"  />
       
    </form>
</body>
</html>
