<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment2q2.aspx.cs" Inherits="AspAssignments.Assignment2q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        .auto-style1 {
            width: 24%;
            height: 68px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="This page shows visitors count"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <table class="auto-style1">
                <tr>
                    <td style="background-color: #99FFCC">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server" Text="Online Visitors"></asp:Label>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="background-color: #FFCCFF">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
