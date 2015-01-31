<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication2._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <meta http-equiv="Cache-Control" content="no-cache">
<meta http-equiv="Pragma" content="no-cache">

    <p>
    Q1. あなたはどの季節が一番好きですか？気分でお答えください。あなたを季節で表すとどれになりますか？<asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem Value="春">春</asp:ListItem>
        <asp:ListItem Value="夏">夏</asp:ListItem>
        <asp:ListItem Value="秋">秋</asp:ListItem>
        <asp:ListItem Value="冬">冬</asp:ListItem>
    </asp:RadioButtonList>
    </p>
<p>
    &nbsp;</p>
<br />
Q2. 新しい職場につきました。どうする？<br />
<asp:RadioButtonList ID="RadioButtonList2" runat="server">
    <asp:ListItem Value="友達">まずは友達を作ろう。誰かに話しかける</asp:ListItem>
    <asp:ListItem Value="楽しむ">とりあえず楽しむ。仕事自体に正面から向き合って真剣になる。そして純粋に楽しむ。</asp:ListItem>
    <asp:ListItem Value="心配">これからうまくやっていけるのかと心配になる</asp:ListItem>
</asp:RadioButtonList>
<br />
<br />
Q3. 身に覚えがないのに彼女に赤ちゃんができました。<br />
<asp:RadioButtonList ID="RadioButtonList3" runat="server">
    <asp:ListItem Value="喜ぶ">命が誕生したのでまず喜ぶ</asp:ListItem>
    <asp:ListItem Value="責める">他に男がいるんじゃないかと責める</asp:ListItem>
    <asp:ListItem Value="落ちこむ">自分は相手にされてないのか…落ちこむ</asp:ListItem>
</asp:RadioButtonList>
<br />
<br />
Q4. 以下の中で一番好きな音楽のジャンルはどれですか？<br />
<asp:RadioButtonList ID="RadioButtonList4" runat="server">
    <asp:ListItem Value="クラシック">クラシック</asp:ListItem>
    <asp:ListItem Value="ロック">ロック</asp:ListItem>
    <asp:ListItem Value="ポップス">ポップス</asp:ListItem>
    <asp:ListItem Value="ジャズ">ジャズ</asp:ListItem>
</asp:RadioButtonList>
<br />
<br />
Q5. クルマの見た目や値段などではなく、性能のみで選ぶならどれを買いますか？<br />
<asp:RadioButtonList ID="RadioButtonList5" runat="server">
    <asp:ListItem Value="ファミリーカー">ファミリーカー</asp:ListItem>
    <asp:ListItem Value="トラック">トラック</asp:ListItem>
    <asp:ListItem Value="スポーツカー">スポーツカー</asp:ListItem>
    <asp:ListItem Value="セダン">セダン</asp:ListItem>
    <asp:ListItem Value="軽自動車">軽自動車</asp:ListItem>
</asp:RadioButtonList>
<br />
<br />
Q6. 同じコミュニティの中で気の合わない人がいます。どうしますか<br />
<asp:RadioButtonList ID="RadioButtonList6" runat="server">
    <asp:ListItem Value="反発">さりげなく反発する</asp:ListItem>
    <asp:ListItem Value="避ける">あからさまに避ける</asp:ListItem>
    <asp:ListItem Value="何もしない">あきらめて何もしない</asp:ListItem>
    <asp:ListItem Value="がんばる">いつか仲良くなれるはず。がんばる</asp:ListItem>
</asp:RadioButtonList>
<br />
<br />
Q7. 何度も同じこと繰り返しているのになかなか成果が出ません。どうする？<br />
<asp:RadioButtonList ID="RadioButtonList7" runat="server">
    <asp:ListItem Value="続ける">あきらめずに続ける</asp:ListItem>
    <asp:ListItem Value="やけくそ">やけくそになる</asp:ListItem>
    <asp:ListItem Value="自己嫌悪">自己嫌悪</asp:ListItem>
    <asp:ListItem Value="休憩">休憩して気分転換する</asp:ListItem>
</asp:RadioButtonList>
<br />
<br />
Q8. 次の中で好きな飲み物をすべて選んでください。<br />
<asp:CheckBox ID="炭酸飲料" runat="server" />
炭酸飲料<br />
<asp:CheckBox ID="フルーツジュース" runat="server" />
フルーツジュース<br />
<asp:CheckBox ID="お茶" runat="server" />
お茶<br />
<asp:CheckBox ID="コーヒー" runat="server" />
コーヒー<br />
<asp:CheckBox ID="乳飲料" runat="server" />
乳飲料<br />
<asp:CheckBox ID="スポーツドリンク" runat="server" />
スポーツドリンク<br />
    <br />
    Q9. あなたが最近いらっとしたのはいつごろですか？<br />
    <asp:RadioButtonList ID="RadioButtonList8" runat="server">
        <asp:ListItem Value="今週"></asp:ListItem>
        <asp:ListItem Value="今月"></asp:ListItem>
        <asp:ListItem Value="今年"></asp:ListItem>
        <asp:ListItem Value="覚えていない"></asp:ListItem>
    </asp:RadioButtonList>
    <br />
    Q10. あなたが最近悲しんだのはいつごろですか？<asp:RadioButtonList ID="RadioButtonList9" runat="server">
        <asp:ListItem Value="今週"></asp:ListItem>
        <asp:ListItem Value="今月"></asp:ListItem>
        <asp:ListItem Value="今年"></asp:ListItem>
        <asp:ListItem Value="覚えていない"></asp:ListItem>
    </asp:RadioButtonList>
    <br />
    Q11. 最近楽しいことはありましたか？<asp:RadioButtonList ID="RadioButtonList10" runat="server">
        <asp:ListItem Value="たくさんある"></asp:ListItem>
        <asp:ListItem Value="覚えている"></asp:ListItem>
        <asp:ListItem Value="ない">覚えていない・もしくはない</asp:ListItem>
    </asp:RadioButtonList>
    <br />
<br />
<asp:Button ID="Button1" runat="server" Text="提出submit" />

</asp:Content>
