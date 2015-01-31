<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    Q1. あなたはどの季節が一番好きですか？気分でお答えください。（スキーが好きだから冬、というのはなし）あなたを季節で表すとどれになりますか？</p>
<p>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>春</asp:ListItem>
        <asp:ListItem>夏</asp:ListItem>
        <asp:ListItem>秋</asp:ListItem>
        <asp:ListItem>冬</asp:ListItem>
    </asp:RadioButtonList>
</p>
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
    <asp:ListItem>クラシック</asp:ListItem>
    <asp:ListItem>ロック</asp:ListItem>
    <asp:ListItem>ポップス</asp:ListItem>
    <asp:ListItem>ジャズ</asp:ListItem>
</asp:RadioButtonList>
<br />
<br />
Q5. クルマの見た目は値段などではなく、性能のみで選ぶならどれを買いますか？<br />
<asp:RadioButtonList ID="RadioButtonList5" runat="server">
    <asp:ListItem>ファミリーカー</asp:ListItem>
    <asp:ListItem>トラック</asp:ListItem>
    <asp:ListItem>スポーツカー</asp:ListItem>
    <asp:ListItem>セダン</asp:ListItem>
    <asp:ListItem>軽自動車</asp:ListItem>
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
    <asp:ListItem>自己嫌悪</asp:ListItem>
    <asp:ListItem Value="休憩">休憩して気分転換する</asp:ListItem>
</asp:RadioButtonList>
<br />
<br />
Q8. 次の中で好きな飲み物をすべて選んでください。<br />
<br />
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
<asp:Button ID="Button1" runat="server" Text="提出submit" />

</asp:Content>
