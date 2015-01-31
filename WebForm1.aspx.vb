Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected p, a, s, h As Integer
    Protected bp As Long
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        p = Session("please")
        a = Session("angry")
        s = Session("sad")
        h = Session("happy")
        bp = 5 - p + 2 * a + s - h
        Label1.Text = p
        Label2.Text = a
        Label3.Text = s
        Label4.Text = h
        Label6.Text = "戦闘力: " & bp
        TextBox1.Text = "おつかれさまでした。診断結果についてコメントいたします。"
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
        dtRow(1) = Label1.Text
        ds.Tables(0).Rows.Add(dtRow)
        dtRow = ds.Tables(0).NewRow
        dtRow(0) = "怒"
        dtRow(1) = Label2.Text
        ds.Tables(0).Rows.Add(dtRow)
        dtRow = ds.Tables(0).NewRow
        dtRow(0) = "哀"
        dtRow(1) = Label3.Text
        ds.Tables(0).Rows.Add(dtRow)
        dtRow = ds.Tables(0).NewRow
        dtRow(0) = "楽"
        dtRow(1) = Label4.Text
        ds.Tables(0).Rows.Add(dtRow)
        Return (ds)
    End Function

    ' フォームロード時の処理
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '初期化
        Chart1.Series.Clear()

        'データの取得
        Dim ds As DataSet = GetData()

        'Chartコントロールにデータソースを設定
        Chart1.DataSource = ds

        'Chartコントロールにタイトルを設定
        Chart1.Titles.Add("戦闘力レーダーチャート")

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