<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GeneralUserLogin.aspx.cs" Inherits="WebAppExtensionPOE.GeneralUserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

 
    <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/css/bootstrap.css" rel="stylesheet" />
    <script src="Content/js/bootstrap.bundle.js"></script>
    <script src="Content/js/bootstrap.js"></script>
    <link href="Content/css/lux.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            width: 555px;
        }
        .auto-style3 {
            width: 555px;
            text-align: right;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            width: 96px;
            height: 96px;
        }
        .auto-style6 {
            width: 555px;
            text-align: right;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1 class="auto-style4">
        <asp:Label ID="Label2" runat="server" BackColor="Black" ForeColor="White" Text="Weather Forecast Web Application" Width="1110px"></asp:Label>
        </h1>
        <h1 class="auto-style4">General user login</h1>
        <p class="auto-style4">
            <img alt="" class="auto-style5" src="Content/Images/icons8-customer-96.png" /></p>
        <div>

            <table align="center" class="auto-style1" style="border-width: thick; border-style: outset; background-color: #A4A4A4;">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <h3>Username</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="tbUsername" runat="server" CssClass="auto-style8" Width="235px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <h3>Password</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="tbPassword" runat="server" CssClass="auto-style8" Width="235px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btSubmit" runat="server" OnClick="btSave_Click" Text="Submit" Width="235px" CssClass="btn btn-primary" style="margin-left: 0px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btClearAll" runat="server" OnClick="btClearAll_Click" Text="Clear All" Width="235px" CssClass="btn btn-primary" style="margin-left: 0px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
