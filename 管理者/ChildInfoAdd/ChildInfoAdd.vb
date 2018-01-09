Imports System.Text.RegularExpressions

Public Class ChildInfoAdd
    Dim Sql As New SQLConnectClass

    Private encsjis As System.Text.Encoding
    Private yearSave As String
    Private monthSave As String
    Private daySave As String
    Private daysInMonth As Integer
    Private calculateAgeAct As Boolean = False

    ' 年月日が正しい形式であることを確認。
    Private Sub DateDecision()
        If cmb_BirthYear.Text <> "" And cmb_BirthMonth.Text <> "" Then
            Dim year As Integer = Integer.Parse(cmb_BirthYear.Text)
            Dim month As Integer = Integer.Parse(cmb_BirthMonth.Text)

            If (year >= 1950 And year <= Today.Year) Then
                If (year < Today.Year) Then
                    daysInMonth = DateTime.DaysInMonth(year, month)
                    BirthDayListAdd(daysInMonth - 1)
                ElseIf (year = Today.Year) Then
                    If (month < Today.Month) Then
                        daysInMonth = DateTime.DaysInMonth(year, month)
                        BirthDayListAdd(daysInMonth - 1)
                    Else
                        MessageBox.Show("1～" + Today.Month.ToString + "の数字を入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cmb_BirthMonth.Text = ""
                        cmb_BirthMonth.Focus()
                    End If
                Else
                    MessageBox.Show("1950～" + Today.Year.ToString + "の数字を入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cmb_BirthYear.Text = ""
                    cmb_BirthYear.Focus()
                End If
            End If

        End If
    End Sub

    ' 年月に合わせた日数を生成。
    Private Sub BirthDayListAdd(ByVal day_count As Integer)
        Dim day_array(day_count) As Object

        cmb_BirthDay.Items.Clear()

        Dim i As Integer
        For i = 0 To day_count
            day_array(i) = i + 1
        Next i

        cmb_BirthDay.Items.AddRange(day_array)
    End Sub

    ' 年齢計算。
    Private Sub CalculateAge()
        If (calculateAgeAct = False And cmb_BirthYear.Text <> "" And cmb_BirthMonth.Text <> "" And cmb_BirthDay.Text <> "") Then

            Dim today As DateTime = DateTime.Today
            Dim year As Integer = Integer.Parse(cmb_BirthYear.Text)
            Dim month As Integer = Integer.Parse(cmb_BirthMonth.Text)
            Dim day As Integer = Integer.Parse(cmb_BirthDay.Text)

            Try
                Dim birthday As New Date(year, month, day)
                Dim ageYear As Long = DateDiff("yyyy", birthday, today)
                Dim ageMonth As Long = DateDiff("m", birthday, today) - (ageYear * 12)

                lbl_Age.Text = ageYear.ToString
                lbl_AgeMonth.Text = ageMonth.ToString

            Catch ex As ArgumentOutOfRangeException
                Dim result As DialogResult = MessageBox.Show("選択した月にその日にちは存在していません。" + vbCrLf + "日にちを選択した月の末日に変更しますか？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If (result = DialogResult.Yes) Then
                    DateDecision()
                    cmb_BirthDay.Text = daysInMonth.ToString()

                Else
                    If (cmb_BirthYear.Text <> yearSave) Then
                        cmb_BirthYear.Text = yearSave
                        calculateAgeAct = True
                    ElseIf (cmb_BirthMonth.Text <> monthSave) Then
                        cmb_BirthMonth.Text = monthSave
                        calculateAgeAct = True
                    Else
                        cmb_BirthDay.Text = daySave
                        calculateAgeAct = True
                    End If
                End If
            End Try

            If (calculateAgeAct = False) Then
                yearSave = cmb_BirthYear.Text
                monthSave = cmb_BirthMonth.Text
                daySave = cmb_BirthDay.Text
            End If
        End If
    End Sub

    Private Sub ChildInfoAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        encsjis = System.Text.Encoding.GetEncoding("Shift_JIS")

        Dim year_array(250) As Object
        Dim i As Integer

        ' クラス名を反映
        If Sql.DBConnect("SELECT COUNT(main_id) FROM test_cluss") = False Then
            MsgBox(Sql.ErrorMessage())
        End If

        Dim count As String = Sql.DBResult(0, 0)

        Dim j As Integer
        If Sql.DBConnect("SELECT main_id, ClassName FROM test_cluss") = False Then
            MsgBox(Sql.ErrorMessage())
        End If
        For j = 0 To Integer.Parse(count) - 1 Step 1
            cmb_ClassName.Items.Add(Sql.DBResult(j, 1))
        Next

        ' 生年月日の年に今年を表示。
        cmb_BirthYear.Text = Today.Year.ToString

        ' 生年月日の年のリストを生成。
        cmb_BirthYear.Items.Clear()

        For i = 1950 To Today.Year
            year_array(i - 1950) = i
        Next i

        cmb_BirthYear.Items.AddRange(year_array)

    End Sub

    Private Sub cmb_BirthYear_TextChanged(sender As Object, e As EventArgs) Handles cmb_BirthYear.TextChanged

        If (calculateAgeAct = False) Then
            lbl_Age.Text = ""
            lbl_AgeMonth.Text = ""

            If cmb_BirthYear.Text <> "" And cmb_BirthMonth.Text <> "" Then
                Dim year As Integer = Integer.Parse(cmb_BirthYear.Text)
                cmb_BirthDay.Enabled = True

                If (year >= 1950 And year <= Today.Year) Then
                    DateDecision()
                Else
                    MessageBox.Show("1950～" + Today.Year.ToString + "の数字を入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cmb_BirthYear.Text = ""
                    cmb_BirthYear.Focus()
                End If
            Else
                cmb_BirthDay.Enabled = False
            End If

            ' 現在の誕生年が変更前の誕生年と違う場合、年齢計算。
            If (cmb_BirthYear.Text <> yearSave) Then
                CalculateAge()
            End If

        Else
            calculateAgeAct = False
            cmb_BirthYear.Text = yearSave

        End If
    End Sub

    Private Sub cmb_BirthMonth_TextChanged(sender As Object, e As EventArgs) Handles cmb_BirthMonth.TextChanged

        If (calculateAgeAct = False) Then
            lbl_Age.Text = ""
            lbl_AgeMonth.Text = ""

            If cmb_BirthYear.Text <> "" And cmb_BirthMonth.Text <> "" Then
                Dim month As Integer = Integer.Parse(cmb_BirthMonth.Text)
                cmb_BirthDay.Enabled = True

                If (month >= 1 And month <= 12) Then
                    DateDecision()
                Else
                    MessageBox.Show("1～12の数字を入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cmb_BirthMonth.Text = ""
                    cmb_BirthMonth.Focus()
                End If
            Else
                cmb_BirthDay.Enabled = False
            End If

            ' 現在の誕生月が変更前の誕生月と違う場合、年齢計算。
            If (cmb_BirthMonth.Text <> monthSave) Then
                CalculateAge()
            End If
        Else
            calculateAgeAct = False
            cmb_BirthMonth.Text = monthSave
        End If
    End Sub

    Private Sub cmb_BirthDay_TextChanged(sender As Object, e As EventArgs) Handles cmb_BirthDay.TextChanged

        If (calculateAgeAct = False) Then
            lbl_Age.Text = ""
            lbl_AgeMonth.Text = ""

            ' 現在の誕生日が変更前の誕生日と違う場合、年齢計算。
            If (cmb_BirthDay.Text <> daySave) Then
                CalculateAge()
            End If
        Else
            calculateAgeAct = False
            cmb_BirthDay.Text = daySave
        End If

    End Sub

    Private Sub btn_PostalCodeSearch_Click(sender As Object, e As EventArgs) Handles btn_PostalCodeSearch.Click
        '見つかったかどうかのフラグ
        Dim blnFlag As Boolean = False

        '郵便番号の上3ケタが入力されていないとき
        If (txt_PostalCode1.Text = "") Then
            MessageBox.Show("郵便番号の上3桁が入力されていません。")
            Me.txt_PostalCode1.Focus()
            Return
            '郵便番号の上4ケタが入力されていないとき
        ElseIf (txt_PostalCode2.Text = "") Then
            MessageBox.Show("郵便番号の下4桁が入力されていません。")
            Me.txt_PostalCode2.Focus()
            Return
        End If

        'マウスカーソルを砂時計にする
        Cursor.Current = Cursors.WaitCursor

        '郵便番号上3桁と下4桁を結合
        Dim sKey As String = txt_PostalCode1.Text + txt_PostalCode2.Text

        Try
            'StreamReaderオブジェクトの作成
            Dim sr As New System.IO.StreamReader("C:\Users\15110025\Documents\学校\卒業研究\書類電子化システム\KEN_ALL\KEN_ALL.CSV", System.Text.Encoding.Default)
            '1行ずつ読み込み
            Dim dat As String = sr.ReadLine()

            '郵便番号データから読み取った行がNullでない限りループする
            While (String.IsNullOrEmpty(dat) = False)

                'CSVファイルの郵便番号格納用変数
                Dim tmpZip As String
                'カンマで区切られた文字列を取得
                Dim sbuf As String() = dat.Split(",")

                'CSVファイル配列の3番目が郵便番号
                tmpZip = sbuf(2).Trim(ControlChars.Quote)

                'sbuf(8)...町域名に「（ 」が含まれているか調べる
                sbuf(8) = sbuf(8).Trim(ControlChars.Quote)
                Dim StrCheck As Integer = sbuf(8).IndexOf("（")
                If 0 <= StrCheck Then
                    ' 町域名に「（ 」が含まれていたら、「（ 」以降の文字を削除
                    sbuf(8) = sbuf(8).Remove(StrCheck, (sbuf(8).Length - StrCheck))
                End If

                '入力された郵便番号と比較
                If (sKey = tmpZip) Then
                    '入力された郵便番号の下4桁が全て0の場合
                    If (txt_PostalCode2.Text = "0000") Then
                        '市区町村テキストボックスに市区町村名を表示
                        txt_Address.Text = sbuf(6).Trim(ControlChars.Quote) + sbuf(7).Trim(ControlChars.Quote)
                    Else
                        '市区町村テキストボックスに市区町村名+町域名を表示
                        txt_Address.Text = sbuf(6).Trim(ControlChars.Quote) + sbuf(7).Trim(ControlChars.Quote) + sbuf(8).Trim(ControlChars.Quote)
                    End If
                    'フラグをTrueにし、ループを抜ける
                    blnFlag = True
                    Exit While
                End If

                Application.DoEvents()
                dat = sr.ReadLine()
            End While

            'ファイルを閉じる
            sr.Close()

        Catch ex As Exception
            'ファイルエラーが発生
            MessageBox.Show(ex.Message, "ファイルエラー",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            '処理を抜ける
            Return

        Finally
            'マウスカーソルをデフォルトにする
            Cursor.Current = Cursors.Default

            If (blnFlag = False) Then
                MessageBox.Show("該当の郵便番号は見つかりませんでした。",
                                "郵便番号検索",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    ' 全角文字しか入力できないように制限する関数。（住所のみに適用。）
    Private Sub EmInput_Address(ByVal txtcontrol As Object)
        Dim z As String = String.Empty
        For Each s As String In txtcontrol.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        txtcontrol.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(txtcontrol.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            txtcontrol.Text = txtcontrol.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    ' 全角文字しか入力できないように制限。（住所以外に適用。）
    Private Sub EmInput_AddressExcept(ByVal Str As Object)

        Static Encode_JIS As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
        Dim Str_Count As Integer = Str.Text.Length
        Dim ByteCount = Encode_JIS.GetByteCount(Str.Text)

        If Str_Count * 2 <> ByteCount Then
            MessageBox.Show("全角文字で入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Str.Text = ""
            Str.Focus()
        End If

    End Sub

    ' 数字しか入力できないように制限。
    Private Sub NumInput(ByRef e As Object)

        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    Private Sub txt_Tempereture_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Temperature.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack And e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Address_TextChanged(sender As Object, e As EventArgs) Handles txt_Address.TextChanged
        EmInput_AddressExcept(txt_Address)
    End Sub

    Private Sub cmb_Author_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Author.LostFocus
        EmInput_AddressExcept(cmb_Author)
    End Sub

    Private Sub txt_ChildName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildName.LostFocus
        EmInput_AddressExcept(txt_ChildName)
    End Sub

    Private Sub txt_NickName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NickName.LostFocus
        EmInput_AddressExcept(txt_NickName)
    End Sub

    Private Sub txt_ChildNameKana_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildNameKana.LostFocus
        txt_ChildNameKana.Text = StrConv(txt_ChildNameKana.Text, VbStrConv.Katakana)
        EmInput_AddressExcept(txt_ChildNameKana)
    End Sub

    Private Sub txt_Address_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Address.LostFocus
        txt_Address.Text = StrConv(txt_Address.Text, VbStrConv.Narrow)
    End Sub

    Private Sub txt_BuildingName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BuildingName.LostFocus
        txt_BuildingName.Text = StrConv(txt_BuildingName.Text, VbStrConv.Narrow)
    End Sub

    Private Sub txt_DoctorName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DoctorName.LostFocus
        EmInput_AddressExcept(txt_DoctorName)
    End Sub

    Private Sub txt_FamilyName1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName1.LostFocus
        EmInput_AddressExcept(txt_FamilyName1)
    End Sub

    Private Sub txt_RelationFamily1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily1.LostFocus
        EmInput_AddressExcept(txt_RelationFamily1)
    End Sub

    Private Sub rtb_WorkPlace1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace1.LostFocus
        EmInput_AddressExcept(rtb_WorkPlace1)
    End Sub

    Private Sub txt_FamilyName2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName2.LostFocus
        EmInput_AddressExcept(txt_FamilyName2)
    End Sub

    Private Sub txt_RelationFamily2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily2.LostFocus
        EmInput_AddressExcept(txt_RelationFamily2)
    End Sub

    Private Sub rtb_WorkPlace2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace2.LostFocus
        EmInput_AddressExcept(rtb_WorkPlace2)
    End Sub

    Private Sub txt_FamilyName3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName3.LostFocus
        EmInput_AddressExcept(txt_FamilyName3)
    End Sub

    Private Sub txt_RelationFamily3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily3.LostFocus
        EmInput_AddressExcept(txt_RelationFamily3)
    End Sub

    Private Sub rtb_WorkPlace3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace3.LostFocus
        EmInput_AddressExcept(rtb_WorkPlace3)
    End Sub

    Private Sub txt_FamilyName4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName4.LostFocus
        EmInput_AddressExcept(txt_FamilyName4)
    End Sub

    Private Sub txt_RelationFamily4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily4.LostFocus
        EmInput_AddressExcept(txt_RelationFamily4)
    End Sub

    Private Sub rtb_WorkPlace4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace4.LostFocus
        EmInput_AddressExcept(rtb_WorkPlace4)
    End Sub

    Private Sub txt_FamilyName5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName5.LostFocus
        EmInput_AddressExcept(txt_FamilyName5)
    End Sub

    Private Sub txt_RelationFamily5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily5.LostFocus
        EmInput_AddressExcept(txt_RelationFamily5)
    End Sub

    Private Sub rtb_WorkPlace5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace5.LostFocus
        EmInput_AddressExcept(rtb_WorkPlace5)
    End Sub

    Private Sub txt_FamilyName6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName6.LostFocus
        EmInput_AddressExcept(txt_FamilyName6)
    End Sub

    Private Sub txt_RelationFamily6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily6.LostFocus
        EmInput_AddressExcept(txt_RelationFamily6)
    End Sub

    Private Sub rtb_WorkPlace6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace6.LostFocus
        EmInput_AddressExcept(rtb_WorkPlace6)
    End Sub

    Private Sub txt_FamilyName7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName7.LostFocus
        EmInput_AddressExcept(txt_FamilyName7)
    End Sub

    Private Sub txt_RelationFamily7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily7.LostFocus
        EmInput_AddressExcept(txt_RelationFamily7)
    End Sub

    Private Sub rtb_WorkPlace7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace7.LostFocus
        EmInput_AddressExcept(rtb_WorkPlace7)
    End Sub

    Private Sub txt_FamilyName8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName8.LostFocus
        EmInput_AddressExcept(txt_FamilyName8)
    End Sub

    Private Sub txt_RelationFamily8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily8.LostFocus
        EmInput_AddressExcept(txt_RelationFamily8)
    End Sub

    Private Sub rtb_WorkPlace8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace8.LostFocus
        EmInput_AddressExcept(rtb_WorkPlace8)
    End Sub

    Private Sub txt_FamilyName9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName9.LostFocus
        EmInput_AddressExcept(txt_FamilyName9)
    End Sub

    Private Sub txt_RelationFamily9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily9.LostFocus
        EmInput_AddressExcept(txt_RelationFamily9)
    End Sub

    Private Sub rtb_WorkPlace9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace9.LostFocus
        EmInput_AddressExcept(rtb_WorkPlace9)
    End Sub

    Private Sub txt_EmergencyName1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EmergencyName1.LostFocus
        EmInput_AddressExcept(txt_EmergencyName1)
    End Sub

    Private Sub txt_EmergencyName2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EmergencyName2.LostFocus
        EmInput_AddressExcept(txt_EmergencyName2)
    End Sub

    Private Sub txt_RelationEmergency1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationEmergency1.LostFocus
        EmInput_AddressExcept(txt_RelationEmergency1)
    End Sub

    Private Sub txt_RelationEmergency2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationEmergency2.LostFocus
        EmInput_AddressExcept(txt_RelationEmergency2)
    End Sub

    Private Sub rtb_CommutingMethod_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_CommutingMethod.LostFocus
        EmInput_AddressExcept(rtb_CommutingMethod)
    End Sub

    Private Sub txt_AllergyDetails_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_AllergyDetails.LostFocus
        EmInput_AddressExcept(txt_AllergyDetails)
    End Sub

    Private Sub txt_IllnessEtc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IllnessEtc.LostFocus
        EmInput_AddressExcept(txt_IllnessEtc)
    End Sub

    Private Sub txt_Operation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Operation.LostFocus
        EmInput_AddressExcept(txt_Operation)
    End Sub

    Private Sub txt_SusceptibleIllness_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SusceptibleIllness.LostFocus
        EmInput_AddressExcept(txt_SusceptibleIllness)
    End Sub

    Private Sub rtb_AnxietyAndAttention_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_AnxietyAndAttention.LostFocus
        EmInput_AddressExcept(rtb_AnxietyAndAttention)
    End Sub

    Private Sub cmb_BirthYear_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BirthYear.KeyPress
        NumInput(e)
    End Sub

    Private Sub cmb_BirthMonth_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BirthMonth.KeyPress
        NumInput(e)
    End Sub

    Private Sub cmb_BirthDay_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BirthDay.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_PostalCode1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PostalCode1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_PostalCode2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PostalCode2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_ChildTEL1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ChildTEL1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_ChildTEL2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ChildTEL2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_ChildTEL3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ChildTEL3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_DoctorTEL1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DoctorTEL1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_DoctorTEL2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DoctorTEL2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_DoctorTEL3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DoctorTEL3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge4.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge5.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge6.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge7.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge8_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge8.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyAge9_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyAge9.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL1_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL1_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL1_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL1_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL1_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL1_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL2_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL2_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL2_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL2_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL2_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL2_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL3_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL3_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL3_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL3_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL3_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL3_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL4_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL4_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL4_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL4_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL4_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL4_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL5_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL5_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL5_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL5_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL5_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL5_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL6_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL6_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL6_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL6_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL6_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL6_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL7_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL7_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL7_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL7_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL7_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL7_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL8_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL8_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL8_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL8_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL8_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL8_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL9_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL9_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL9_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL9_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_FamilyTEL9_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FamilyTEL9_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL1_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL1_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL1_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL1_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL1_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL1_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL2_1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL2_1.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL2_2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL2_2.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_EmergencyTEL2_3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EmergencyTEL2_3.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_CommutingHour_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CommutingHour.KeyPress
        NumInput(e)
    End Sub

    Private Sub txt_CommutingMin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CommutingMin.KeyPress
        NumInput(e)
    End Sub

    Private Sub btn_SaveAsFile_Click(sender As Object, e As EventArgs) Handles btn_SaveAsFile.Click
        Dim sqlUserInsert As String
        Dim sqlWorkerInsert As String
        Dim mainID As Integer = 0
        Dim maxMainID As String
        Dim sql_Sex As String = 0
        Dim sql_ChildName, sql_ChildNameKana, sql_Nickname, sql_EntranceDay, sql_Birthday, sql_PostalCode, sql_Address, sql_ChildTEL, sql_Temperature, sql_Mail, sql_DoctorName, sql_DoctorTEL

        ' お子様情報登録
        sql_ChildName = Me.txt_ChildName.Text
        sql_ChildNameKana = Me.txt_ChildNameKana.Text

        sql_Nickname = Me.txt_NickName.Text

        sql_EntranceDay = Date.Parse(Me.dtp_EntranceDay.Value.Year & "/" & Me.dtp_EntranceDay.Value.Month & "/" & Me.dtp_EntranceDay.Value.Day)

        sql_Birthday = Date.Parse(Me.cmb_BirthYear.Text & "/" & Me.cmb_BirthMonth.Text & "/" & Me.cmb_BirthDay.Text)

        If rdb_man.Checked = True Then
            sql_Sex = "男"
        ElseIf rdb_woman.Checked = True Then
            sql_Sex = "女"
        End If

        sql_PostalCode = Integer.Parse(Me.txt_PostalCode1.Text + txt_PostalCode2.Text)
        sql_Address = Me.txt_Address.Text + Me.txt_BuildingName.Text
        sql_ChildTEL = Me.txt_ChildTEL1.Text + Me.txt_ChildTEL2.Text + Me.txt_ChildTEL3.Text

        sql_Temperature = Me.txt_Temperature.Text

        sql_Mail = Me.txt_MailLocal.Text & "@" & Me.txt_MailDomain.Text

        sql_DoctorName = txt_DoctorName.Text
        sql_DoctorTEL = txt_DoctorTEL1.Text + txt_DoctorTEL2.Text + txt_DoctorTEL3.Text

        ' クラス名を反映
        If Sql.DBConnect("SELECT COUNT(main_id) FROM test_cluss") = False Then
            MsgBox(Sql.ErrorMessage())
        End If

        Dim count As String = Sql.DBResult(0, 0)

        Dim j As Integer
        If Sql.DBConnect("SELECT main_id, ClassName FROM test_cluss") = False Then
            MsgBox(Sql.ErrorMessage())
        End If

        For j = 0 To Integer.Parse(count) - 1 Step 1
            If (cmb_ClassName.Text = Sql.DBResult(j, 1)) Then
                mainID = Sql.DBResult(j, 0)
                Exit For
            End If
        Next

        Sql.DBConnect("INSERT INTO children(class_table_id, children_name, children_katakana, children_nickname, children_sex, birthday, admission_day, postal_code, address, average_temperature, contact, mail_address, primary_doctor_name, primary_doctor_contact)" _
                          & "VALUES (" & mainID & ",'" & sql_ChildName & "','" & sql_ChildNameKana & "','" & sql_Nickname & "','" & sql_Sex & "','" & sql_Birthday & "','" & sql_EntranceDay & "','" & sql_PostalCode & "','" & sql_Address & "','" & sql_Temperature & "'," & sql_ChildTEL & ",'" & sql_Mail & "','" & sql_DoctorName & "','" & sql_DoctorTEL & "')")


        MsgBox("登録が完了しました。")
        'Else
        'MsgBox("登録出来ませんでした。")
        'End If
    End Sub

End Class
