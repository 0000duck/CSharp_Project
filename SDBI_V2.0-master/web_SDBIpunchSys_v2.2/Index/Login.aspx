<%@ Page Language="C#" AutoEventWireup="true" CodeFile="/Index/Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="../Style/StyleSheet.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
<script src="http://www.modernizr.com/downloads/modernizr-latest.js"></script>
<script type="text/javascript" src="JavaScript.js"></script>
<script type="text/javascript" src="../Script/JavaScript.js"></script>
    <title>山东商务职业学院考勤系统</title>
</head>
<body>
    <div id="bgimg">
        <img src="../Images/Index_image.jpg" />
    </div>
    <form id="slick_login" runat="server" method="post" > 
             
        <table>
            <tr>
                <td><asp:TextBox ID="TextBox1" runat="server" CssClass="placeholder"  placeholder="用户名" Height="50px" Width="225px"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" CssClass="RegularExpressionValidator" Display="Dynamic" ErrorMessage="!!!" ValidationExpression="(\d)*"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td><asp:TextBox ID="TextBox2" runat="server" CssClass="placeholder"  placeholder="密码" Height="50px" Width="225px" TextMode="Password"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" CssClass="RegularExpressionValidator" Display="Dynamic" ErrorMessage="!!!" ValidationExpression="(\d)*"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td><asp:TextBox ID="TextBox3" runat="server" CssClass="placeholder"  placeholder="验证码" Height="50px" Width="225px"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" CssClass="RegularExpressionValidator" ErrorMessage="!!!" ValidationExpression="(\d){4}"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td><img  src="ValidatorCode.aspx" onclick="this.src=this.src+'?'" width:"15px"; height="50px"/> </td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="登陆" OnClick="Button1_Click" /></td>
            </tr>
        </table>         
    </form>
</body>
</html>
