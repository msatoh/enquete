<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication2.WebForm1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>結果発表</title>
    <style type="text/css">
        .auto-style1 {
            width: 28px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-busy="False">
            <center>
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF6600" Text="結果発表"></asp:Label>
            </center>
                  <br />
            あなたの感情の成分は以下の通りです。<br />
                    <table style="width: 18%;float:left" border="1">
                        <tr>
                            <td class="auto-style1">喜</td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">怒</td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">哀</td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">楽</td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                    </table>

        </div>

        <br />
                    <asp:Label ID="Label6" runat="server" Font-Names="HGP行書体" Font-Size="X-Large" Text="Label"></asp:Label>

        <br />
        <br />
        <br />

        <br />
        <br />
        <table><tr><td>
       <asp:Chart ID="Chart1" runat="server">
            <Series>
                <asp:Series Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
            </td><td>
        <asp:TextBox ID="TextBox1" runat="server" Height="78px" Width="418px"></asp:TextBox>
                </td></tr></table>
    </form>
</body>
</html>
