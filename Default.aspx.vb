Public Class _Default
    Inherits Page
    Public Structure ans
        Public p As Integer '喜
        Public a As Integer '怒
        Public s As Integer '哀
        Public h As Integer '楽
    End Structure
    Dim a(11) As ans

    Protected Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
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

    Protected Sub RadioButtonList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList2.SelectedIndexChanged
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

    Protected Sub RadioButtonList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList3.SelectedIndexChanged
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

    Protected Sub RadioButtonList4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList4.SelectedIndexChanged
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

    Protected Sub RadioButtonList5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList5.SelectedIndexChanged
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

    Protected Sub RadioButtonList6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList6.SelectedIndexChanged
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

    Protected Sub RadioButtonList7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList7.SelectedIndexChanged
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

    Protected Sub 炭酸飲料_CheckedChanged(sender As Object, e As EventArgs) Handles 炭酸飲料.CheckedChanged
        If 炭酸飲料.Checked Then
            a(8).a += 8
        Else
            a(8).a -= 8
        End If
    End Sub
    Protected Sub フルーツジュース_CheckedChanged(sender As Object, e As EventArgs) Handles フルーツジュース.CheckedChanged
        If フルーツジュース.Checked Then
            a(8).h += 13
            a(8).p += 7
        Else
            a(8).h -= 13
            a(8).p -= 7
        End If
    End Sub
    Protected Sub お茶_CheckedChanged(sender As Object, e As EventArgs) Handles お茶.CheckedChanged
        If お茶.Checked Then
            a(8).s += 8
        Else
            a(8).s -= 8
        End If
    End Sub
    Protected Sub コーヒー_CheckedChanged(sender As Object, e As EventArgs) Handles コーヒー.CheckedChanged
        If コーヒー.Checked Then
            a(8).s += 8
            a(8).h += 7
            a(8).p += 7
        Else
            a(8).s -= 8
            a(8).h -= 7
            a(8).p -= 7
        End If
    End Sub
    Protected Sub 乳飲料_CheckedChanged(sender As Object, e As EventArgs) Handles 乳飲料.CheckedChanged
        If 乳飲料.Checked Then
            a(8).h += 7
            a(8).p += 13
        Else
            a(8).h -= 7
            a(8).p -= 13
        End If
    End Sub
    Protected Sub スポーツドリンク_CheckedChanged(sender As Object, e As EventArgs) Handles スポーツドリンク.CheckedChanged
        If スポーツドリンク.Checked Then
            a(8).a += 8
            a(8).p += 7
        Else
            a(8).a -= 8
            a(8).p -= 7
        End If
    End Sub

    Protected Sub RadioButtonList8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList8.SelectedIndexChanged
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

    Protected Sub RadioButtonList9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList9.SelectedIndexChanged
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

    Protected Sub RadioButtonList10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList10.SelectedIndexChanged
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
        i = 1
        While (i <= 11)
            If a(i).p + a(i).s + a(i).a + a(i).h = 0 Then
                Me.Button1.OnClientClick = "alert('全部選択してください.');"
                Exit Sub
            Else
                i += 1
            End If
        End While
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