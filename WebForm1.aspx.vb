Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected p, a, s, h As Integer
    Protected ftype As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        p = Session("please")
        a = Session("angry")
        s = Session("sad")
        h = Session("happy")
        Label1.Text = p
        Label2.Text = a
        Label3.Text = s
        Label4.Text = h
        If p > 30 And a > 30 And s > 30 And h > 30 Then
            ftype = "情緒不安定"
        ElseIf p < 30 And a < 30 And s < 30 And h < 30 Then
            ftype = "ロボット"
        ElseIf a > 60 Then
            ftype = "おこりんぼう"
        ElseIf s > 60 Then
            ftype = "センチメンタル"
        ElseIf p > a And p > s And h > a And h > s Then
            ftype = "能天気"
        Else
            ftype = "ふつう"
        End If
        TextBox1.Text = "おつかれさまでした。診断結果についてコメントいたします。"
        Select Case ftype
            Case "情緒不安定"
                TextBox1.Text += "あなたは「情緒不安定」タイプです。あらゆる感情が強く出ています。"
            Case "ロボット"
                TextBox1.Text += "あなたは「ロボット」タイプです。何事にも冷静でいることができます。"
            Case "おこりんぼう"
                TextBox1.Text += "あなたは「おこりんぼう」タイプです。「怒」の成分が高いです。"
            Case "能天気"
                TextBox1.Text += "あなたは「能天気」タイプです。いつものんきでストレスを感じることがありません。"
            Case "ふつう"
                TextBox1.Text += "あなたは「ふつう」です。喜怒哀楽の分析では特徴は特にありません。"
        End Select
        If a > 50 Or s > 50 Then
            If a > 50 Then
                TextBox1.Text += "ストレス溜まっていませんか？怒りすぎは体に毒です。"
            End If
            If s > 50 Then
                TextBox1.Text += "マイナス思考になっていませんか？楽しく生きるには気持ちが大事です。"
            End If
        Else
            TextBox1.Text += "ストレスについては特に問題ないようです。"
        End If
        If h > 50 Then
            TextBox1.Text += "そしてあなたの生活は幸福度が高いです。人生楽しんでいますね！"
        End If
        If p > 50 Then
            TextBox1.Text += "最近楽しかったことはなんですか？その感情が強く表れています。"
        End If

        GraphDraw(sender, e)

    End Sub

    Private Function GetData() As DataSet
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dtRow As DataRow
        '列の作成 
        dt.Columns.Add("", Type.GetType("System.String"))
        dt.Columns.Add("", Type.GetType("System.Int32"))
        ds.Tables.Add(dt)
        'データの追加 
        dtRow = ds.Tables(0).NewRow
        dtRow(0) = "喜"
        dtRow(1) = p
        ds.Tables(0).Rows.Add(dtRow)
        dtRow = ds.Tables(0).NewRow
        dtRow(0) = "怒"
        dtRow(1) = a
        ds.Tables(0).Rows.Add(dtRow)
        dtRow = ds.Tables(0).NewRow
        dtRow(0) = "哀"
        dtRow(1) = s
        ds.Tables(0).Rows.Add(dtRow)
        dtRow = ds.Tables(0).NewRow
        dtRow(0) = "楽"
        dtRow(1) = h
        ds.Tables(0).Rows.Add(dtRow)
        Return (ds)
    End Function

    ' フォームロード時の処理
    Private Sub GraphDraw(sender As System.Object, e As System.EventArgs) 'Handles MyBase.Load
        '初期化
        Chart1.Series.Clear()

        'データの取得
        Dim ds As DataSet = GetData()

        'Chartコントロールにデータソースを設定
        Chart1.DataSource = ds

        'Chartコントロールにタイトルを設定
        Chart1.Titles.Add("レーダーチャート")

        'グラフの種類,系列,軸の設定
        For I As Integer = 1 To ds.Tables(0).Columns.Count - 1
            '列名の取得
            Dim columnName As String = ds.Tables(0).Columns(I).ColumnName

            '系列の設定
            Chart1.Series.Add(columnName)

            'グラフの種類
            Chart1.Series(columnName).ChartType = DataVisualization.Charting.SeriesChartType.Radar

            'X軸
            Chart1.Series(columnName).XValueMember = ds.Tables(0).Columns(0).ColumnName.ToString
            Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
            Chart1.ChartAreas(0).AxisX.MinorGrid.Enabled = False

            'Y軸
            Chart1.Series(columnName).YValueMembers = columnName
            Chart1.ChartAreas(0).AxisY.Maximum = 100
        Next

        'X軸タイトル
        Chart1.ChartAreas(0).AxisX.Title = "感情emotions"

        Chart1.DataBind()

    End Sub

End Class