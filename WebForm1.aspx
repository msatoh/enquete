<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication2.WebForm1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>
<meta http-equiv="Cache-Control" content="no-cache">
<meta http-equiv="Pragma" content="no-cache">

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
            <table style="width: 18%; float: left" border="1">
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
        <table>
            <tr>
                <td>
                    <asp:Chart ID="Chart1" runat="server">
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                                <AxisY Maximum="100">
                                </AxisY>
                            </asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </td>
                <td>
                    診断の結果…あなたはです！<br />
                    <asp:TextBox ID="TextBox1" runat="server" Height="78px" Width="418px"></asp:TextBox>
                    <br />
                   診断結果をツイートする→<script>
                        var p = '<%=p%>',
                            a = '<%=a%>',
                            s = '<%=s%>',
                            h = '<%=h%>',
                            bp = '<%=bp%>',
                        result = "性格診断をしました。喜:" + p + ",怒:" + a + ",哀:" + s + ",楽:" + h + ",戦闘力は" + bp + "でした。";
                        document.write("<a href=\"https://twitter.com/share\" class=\"twitter-share-button\" data-url=\"http://msatoh.clear-net.jp/\" data-text=\"" + result + "\" data-lang=\"ja\" data-size=\"large\" data-count=\"none\">ツイート</a>");
                        !function (d, s, id) {
                            var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https';
                            if (!d.getElementById(id)) {
                                js = d.createElement(s);
                                js.id = id;
                                js.src = p + '://platform.twitter.com/widgets.js';
                                fjs.parentNode.insertBefore(js, fjs);
                            }
                        }(document, 'script', 'twitter-wjs');
                    </script>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
