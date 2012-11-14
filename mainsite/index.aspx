<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fishfood Website</title>
    <link href="fishfood.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="fishfood">
        <div class="top">
            <div class="login">
                <label for="username">Username</label><input type="text" value="Username" name="username" id="username"/>
                <label for="password">Password</label><input type="password" value="" name="password" id="password"/>
                <div class="loginbutton">Login</div>
            </div>
        </div>
        <div class="menu">
            <ul>
                <li><a href="#">Home</a></li>
                <li><a href="#">About</a></li>
                <li><a href="#">FAQs</a></li>
            </ul>
        </div>
        <div class="main">
            <div class="maintop">
                <a href="#" class="download">Download Fishfood Plugin Here</a>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
