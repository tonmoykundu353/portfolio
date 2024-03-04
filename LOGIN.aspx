<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN.aspx.cs" Inherits="portfolio_assignmemt.LOGIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body{
            font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
            background-color:crimson;
        }
        .auto-style2 {
            height: 34px;
            text-align: center;
            font-family:'Times New Roman', Times, serif;
        }
        .auto-style3 {
            height: 34px;
            width: 267px;
        }
        .auto-style4 {
            
            width: 267px;
            text-align: center;
            font-family:'Times New Roman', Times, serif;
        }
        table{
            background-color:bisque;
            margin:auto;
            width:400px;
            border: 5px black double;
        }
        .auto{
            font-size:30px;
            font-family:Arial;
            text-align:center;
            font-style:italic;
        }
               
       
        .auto-style5 {
            margin-bottom: 52px;
        }
               
       
    </style>
</head>
<body>
    <form id="form1" runat="server">


        <div>

            <table cellpadding="4" cellspacing="4" class="auto-style5">
                <tr>
                    <td class="auto" colspan="2">&nbsp;ADMIN PANEL&nbsp;</td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style3">USERNAME :</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="UserTextBox" runat="server" Height="39px" Width="204px" BorderStyle="Dashed"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserTextBox" Display="Dynamic" ErrorMessage="Please Enter Username" ForeColor="Black" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style4">PASSWORD :</td>
                    <td>
                        <asp:TextBox ID="PassTextBox" runat="server" Height="39px" Width="204px" BorderStyle="Dashed" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PassTextBox" Display="Dynamic" ErrorMessage="Please Enter password" ForeColor="Black" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Button class="button" ID="LoginButton" runat="server" Height="49px" Text="LOGIN" Width="99px" BackColor="#CC0099" BorderStyle="Solid" OnClick="LoginButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
