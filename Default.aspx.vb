Public Class _Default
    Inherits Page
    Public Structure ans
        Public p As Integer '喜
        Public a As Integer '怒
        Public s As Integer '哀
        Public h As Integer '楽
    End Structure
    Dim a(11) As ans

    Protected Sub q1(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        If RadioButtonList1.SelectedValue = "春" Then
            a(1).p = 7
            a(1).a = 0
            a(1).s = 0
            a(1).h = 0
        End If
        If RadioButtonList1.SelectedValue = "夏" Then
            a(1).p = 7
            a(1).a = 0
            a(1).s = 0
            a(1).h = 13
        End If
        If RadioButtonList1.SelectedValue = "秋" Then
            a(1).p = 0
            a(1).a = 0
            a(1).s = 8
            a(1).h = 7
        End If
        If RadioButtonList1.SelectedValue = "冬" Then
            a(1).p = 0
            a(1).a = 0
            a(1).s = 15
            a(1).h = 0
        End If
    End Sub

    Protected Sub q2(sender As Object, e As EventArgs) Handles RadioButtonList2.SelectedIndexChanged
        If RadioButtonList2.SelectedValue = "友達" Then
            a(2).p = 7
            a(2).a = 0
            a(2).s = 0
            a(2).h = 0
        End If
        If RadioButtonList2.SelectedValue = "楽しむ" Then
            a(2).p = 0
            a(2).a = 0
            a(2).s = 0
            a(2).h = 7
        End If
        If RadioButtonList2.SelectedValue = "心配" Then
            a(2).p = 0
            a(2).a = 0
            a(2).s = 8
            a(2).h = 0
        End If
    End Sub

    Protected Sub q3(sender As Object, e As EventArgs) Handles RadioButtonList3.SelectedIndexChanged
        If RadioButtonList3.SelectedValue = "喜ぶ" Then
            a(3).p = 7
            a(3).a = 0
            a(3).s = 0
            a(3).h = 0
        End If
        If RadioButtonList3.SelectedValue = "責める" Then
            a(3).p = 0
            a(3).a = 15
            a(3).s = 0
            a(3).h = 0
        End If
        If RadioButtonList3.SelectedValue = "落ちこむ" Then
            a(3).p = 0
            a(3).a = 0
            a(3).s = 8
            a(3).h = 0
        End If
    End Sub

    Protected Sub q4(sender As Object, e As EventArgs) Handles RadioButtonList4.SelectedIndexChanged
        If RadioButtonList4.SelectedValue = "クラシック" Then
            a(4).p = 13
            a(4).a = 0
            a(4).s = 0
            a(4).h = 0
        End If
        If RadioButtonList4.SelectedValue = "ロック" Then
            a(4).p = 0
            a(4).a = 8
            a(4).s = 0
            a(4).h = 0
        End If
        If RadioButtonList4.SelectedValue = "ポップス" Then
            a(4).p = 7
            a(4).a = 0
            a(4).s = 0
            a(4).h = 7
        End If
        If RadioButtonList4.SelectedValue = "ジャズ" Then
            a(4).p = 7
            a(4).a = 0
            a(4).s = 8
            a(4).h = 0
        End If
    End Sub

    Protected Sub q5(sender As Object, e As EventArgs) Handles RadioButtonList5.SelectedIndexChanged
        If RadioButtonList5.SelectedValue = "ファミリーカー" Then
            a(5).p = 9
            a(5).a = 0
            a(5).s = 0
            a(5).h = 9
        End If
        If RadioButtonList5.SelectedValue = "トラック" Then
            a(5).p = 0
            a(5).a = 15
            a(5).s = 0
            a(5).h = 0
        End If
        If RadioButtonList5.SelectedValue = "スポーツカー" Then
            a(5).p = 9
            a(5).a = 8
            a(5).s = 0
            a(5).h = 17
        End If
        If RadioButtonList5.SelectedValue = "セダン" Then
            a(5).p = 9
            a(5).a = 0
            a(5).s = 8
            a(5).h = 0
        End If
    End Sub

    Protected Sub q6(sender As Object, e As EventArgs) Handles RadioButtonList6.SelectedIndexChanged
        If RadioButtonList6.SelectedValue = "反発" Then
            a(6).p = 0
            a(6).a = 15
            a(6).s = 0
            a(6).h = 0
        End If
        If RadioButtonList6.SelectedValue = "避ける" Then
            a(6).p = 0
            a(6).a = 8
            a(6).s = 8
            a(6).h = 0
        End If
        If RadioButtonList6.SelectedValue = "何もしない" Then
            a(6).p = 0
            a(6).a = 0
            a(6).s = 15
            a(6).h = 0
        End If
        If RadioButtonList6.SelectedValue = "がんばる" Then
            a(6).p = 0
            a(6).a = 0
            a(6).s = 0
            a(6).h = 7
        End If
    End Sub

    Protected Sub q7(sender As Object, e As EventArgs) Handles RadioButtonList7.SelectedIndexChanged
        If RadioButtonList7.SelectedValue = "続ける" Then
            a(7).p = 7
            a(7).a = 0
            a(7).s = 0
            a(7).h = 0
        End If
        If RadioButtonList7.SelectedValue = "やけくそ" Then
            a(7).p = 0
            a(7).a = 15
            a(7).s = 9
            a(7).h = 0
        End If
        If RadioButtonList7.SelectedValue = "自己嫌悪" Then
            a(7).p = 0
            a(7).a = 8
            a(7).s = 15
            a(7).h = 0
        End If
        If RadioButtonList7.SelectedValue = "休憩" Then
            a(7).p = 0
            a(7).a = 0
            a(7).s = 0
            a(7).h = 7
        End If
    End Sub

    Protected Sub q8(sender As Object, e As EventArgs) Handles CheckBoxList1.SelectedIndexChanged
        a(8).p = 0
        a(8).a = 0
        a(8).s = 0
        a(8).h = 0
        If CheckBoxList1.Items(0).Selected Then
            a(8).a += 8
        End If
        If CheckBoxList1.Items(1).Selected Then
            a(8).h += 13
            a(8).p += 7
        End If
        If CheckBoxList1.Items(2).Selected Then
            a(8).s += 8
        End If
        If CheckBoxList1.Items(3).Selected Then
            a(8).s += 8
            a(8).h += 7
            a(8).p += 7
        End If
        If CheckBoxList1.Items(4).Selected Then
            a(8).h += 7
            a(8).p += 13
        End If
        If CheckBoxList1.Items(5).Selected Then
            a(8).a += 8
            a(8).p += 7
        End If
    End Sub

    Protected Sub q9(sender As Object, e As EventArgs) Handles RadioButtonList8.SelectedIndexChanged
        If RadioButtonList8.SelectedValue = "今週" Then
            a(9).p = 0
            a(9).a = 14
            a(9).s = 0
            a(9).h = 0
        End If
        If RadioButtonList8.SelectedValue = "今月" Then
            a(9).p = 0
            a(9).a = 7
            a(9).s = 0
            a(9).h = 0
        End If
        If RadioButtonList8.SelectedValue = "今年" Then
            a(9).p = 0
            a(9).a = 0
            a(9).s = 0
            a(9).h = 0
        End If
        If RadioButtonList8.SelectedValue = "覚えていない" Then
            a(9).p = 0
            a(9).a = -7
            a(9).s = 0
            a(9).h = 0
        End If
    End Sub

    Protected Sub q10(sender As Object, e As EventArgs) Handles RadioButtonList9.SelectedIndexChanged
        If RadioButtonList9.SelectedValue = "今週" Then
            a(10).p = 0
            a(10).a = 0
            a(10).s = 14
            a(10).h = 0
        End If
        If RadioButtonList9.SelectedValue = "今月" Then
            a(10).p = 0
            a(10).a = 0
            a(10).s = 7
            a(10).h = 0
        End If
        If RadioButtonList9.SelectedValue = "今年" Then
            a(10).p = 0
            a(10).a = 0
            a(10).s = 0
            a(10).h = 0
        End If
        If RadioButtonList9.SelectedValue = "覚えていない" Then
            a(10).p = 0
            a(10).a = 0
            a(10).s = -7
            a(10).h = 0
        End If
    End Sub

    Protected Sub q11(sender As Object, e As EventArgs) Handles RadioButtonList10.SelectedIndexChanged
        If RadioButtonList10.SelectedValue = "たくさんある" Then
            a(11).p = 12
            a(11).a = 0
            a(11).s = 0
            a(11).h = 12
        End If
        If RadioButtonList10.SelectedValue = "覚えている" Then
            a(11).p = 6
            a(11).a = 0
            a(11).s = 0
            a(11).h = 0
        End If
        If RadioButtonList10.SelectedValue = "ない" Then
            a(11).p = -6
            a(11).a = 0
            a(11).s = 0
            a(11).h = -6
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, pleasure, anger, sadness, happiness As Integer
        pleasure = 0
        anger = 0
        sadness = 0
        happiness = 0
        For i = 1 To 11
            pleasure += a(i).p
            anger += a(i).a
            sadness += a(i).s
            happiness += a(i).h
        Next
        Session("please") = pleasure
        Session("angry") = anger
        Session("sad") = sadness
        Session("happy") = happiness
        Response.Redirect("WebForm1.aspx")
    End Sub

End Class

