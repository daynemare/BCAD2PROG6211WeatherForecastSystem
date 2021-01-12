<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LatestWeatherForecasts.aspx.cs" Inherits="WebAppExtensionPOE.LatestWeatherForecasts" %>

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
            text-align: center;
        }
        .auto-style2 {
            width: 64px;
            height: 64px;
        }
        .auto-style7 {
            font-size: small;
            margin-left: 0;
        }
        .auto-style14 {
            font-size: small;
            margin-left: 0;
            margin-bottom: 0;
        }
        .auto-style16 {
            font-size: small;
            margin-left: 0;
            margin-bottom: 0;
        }
        .auto-style19 {
            text-align: left;
        }
        .auto-style20 {
            width: 1050px;
            border: 1px solid #dee2e6;
        }
        .auto-style21 {
            text-align: right;
        }
        .auto-style22 {
            color: inherit;
            background-color: #343a40;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
    
      <h1 class="auto-style1">
        <asp:Label ID="Label2" runat="server" BackColor="Black" ForeColor="White" Text="Weather Forecast Web Application" Width="1110px"></asp:Label>
        </h1>
    <h1 class="auto-style1">Your Latest Weather Forecasts</h1>
        <div class="auto-style1">
            <img alt="" class="auto-style2" src="Content/Images/wf%20icon.png" /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table align="center" cellpadding="0" cellspacing="0" class="auto-style20" style="border-style: outset; border-width: medium; background-color: #A4A4A4;">
                <tr>
                    <td class="auto-style21">
                    <asp:Button ID="Button3" runat="server" BackColor="#3399FF" CssClass="auto-style16" Font-Bold="True" Height="25px" OnClick="btSignOut_Click" Text="SIGN OUT" Width="151px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                    <asp:DropDownList ID="DropDownListPreferences" runat="server" Width="150px" AppendDataBoundItems="True" DataTextField="CITY_NAME" DataValueField="CITY_NAME" ValidationGroup="valFilter" CssClass="auto-style14" Height="30px" >
                        <asp:ListItem Selected="True" Value="-1">--SELECT FILTER--</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="-1" ControlToValidate="DropDownListPreferences" CssClass="text-danger" ErrorMessage="No filter Selected" ValidationGroup="valFilter"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                    <asp:Button ID="btFilter" runat="server" OnClick="btViewSpecificFavCity_Click" Text="Filter" Width="148px" CssClass="btn btn-primary" ValidationGroup="valFilter" Height="35px" style="font-size: small" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">
                    <asp:Button ID="Button2" runat="server" BackColor="Yellow" BorderColor="Black" CssClass="auto-style7" OnClick="btViewAllRecords_Click" Text="VIEW ALL" Width="147px" Font-Bold="True" Height="25px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style22" Width="1033px">
                        </asp:GridView>
                        </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView2" runat="server" CssClass="auto-style22" Width="1033px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                    
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
        </div>
    </form>
</body>
</html>
