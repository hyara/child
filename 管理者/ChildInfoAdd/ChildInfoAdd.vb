Imports System.Text.RegularExpressions

Public Class ChildInfoAdd
    Dim Sql As New SQLConnectClass

    Private encsjis As System.Text.Encoding
    Private yearSave As String
    Private monthSave As String
    Private daySave As String
    Private daysInMonth As Integer
    Private calculateAgeAct As Boolean = False

    Private _txt_FamilyName As New List(Of TextBox)
    Private _txt_RelationFamily As New List(Of TextBox)
    Private _txt_FamilyAge As New List(Of TextBox)
    Private _txt_FamilyTEL1 As New List(Of TextBox)
    Private _txt_FamilyTEL2 As New List(Of TextBox)
    Private _txt_FamilyTEL3 As New List(Of TextBox)
    Dim _rtb_WorkPlace(9) As String

    Dim _txt_EmergencyName(2) As String
    Dim _txt_RelationEmergency(2) As String
    Dim _txt_EmergencyTEL(2) As String

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

                If (ageMonth < 0) Then
                    ageMonth = (ageYear * 12) - DateDiff("m", birthday, today)
                End If

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
        If Sql.DBConnect("SELECT COUNT(main_id) FROM class") = False Then
            MsgBox(Sql.ErrorMessage())
        End If

        Dim count As String = Sql.DBResult(0, 0)

        Dim j As Integer
        If Sql.DBConnect("SELECT main_id, ClassName FROM class") = False Then
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

    ' 全角文字しか入力できないように制限。
    Private Sub EmInput(ByVal Str As Object)

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

    Private Sub RegistData()
        Dim maxMainID As String = "0"
        Dim count As Integer
        Dim sqlChildrenInsert As String
        Dim sqlFamilyTableInsert As String
        Dim sqlFamilyEmergencyInsert As String
        Dim sqlFamilyMainInsert As String
        Dim sqlHealthInsert As String

        Me._txt_FamilyName.Add(Me.txt_FamilyName1)
        Me._txt_FamilyName.Add(Me.txt_FamilyName2)
        Me._txt_FamilyName.Add(Me.txt_FamilyName3)
        Me._txt_FamilyName.Add(Me.txt_FamilyName4)
        Me._txt_FamilyName.Add(Me.txt_FamilyName5)
        Me._txt_FamilyName.Add(Me.txt_FamilyName6)
        Me._txt_FamilyName.Add(Me.txt_FamilyName7)
        Me._txt_FamilyName.Add(Me.txt_FamilyName8)
        Me._txt_FamilyName.Add(Me.txt_FamilyName9)

        Me._txt_RelationFamily.Add(Me.txt_RelationFamily1)
        Me._txt_RelationFamily.Add(Me.txt_RelationFamily2)
        Me._txt_RelationFamily.Add(Me.txt_RelationFamily3)
        Me._txt_RelationFamily.Add(Me.txt_RelationFamily4)
        Me._txt_RelationFamily.Add(Me.txt_RelationFamily5)
        Me._txt_RelationFamily.Add(Me.txt_RelationFamily6)
        Me._txt_RelationFamily.Add(Me.txt_RelationFamily7)
        Me._txt_RelationFamily.Add(Me.txt_RelationFamily8)
        Me._txt_RelationFamily.Add(Me.txt_RelationFamily9)

        Me._txt_FamilyAge.Add(Me.txt_FamilyAge1)
        Me._txt_FamilyAge.Add(Me.txt_FamilyAge2)
        Me._txt_FamilyAge.Add(Me.txt_FamilyAge3)
        Me._txt_FamilyAge.Add(Me.txt_FamilyAge4)
        Me._txt_FamilyAge.Add(Me.txt_FamilyAge5)
        Me._txt_FamilyAge.Add(Me.txt_FamilyAge6)
        Me._txt_FamilyAge.Add(Me.txt_FamilyAge7)
        Me._txt_FamilyAge.Add(Me.txt_FamilyAge8)
        Me._txt_FamilyAge.Add(Me.txt_FamilyAge9)

        Me._txt_FamilyTEL1.Add(Me.txt_FamilyTEL1_1)
        Me._txt_FamilyTEL1.Add(Me.txt_FamilyTEL2_1)
        Me._txt_FamilyTEL1.Add(Me.txt_FamilyTEL3_1)
        Me._txt_FamilyTEL1.Add(Me.txt_FamilyTEL4_1)
        Me._txt_FamilyTEL1.Add(Me.txt_FamilyTEL5_1)
        Me._txt_FamilyTEL1.Add(Me.txt_FamilyTEL6_1)
        Me._txt_FamilyTEL1.Add(Me.txt_FamilyTEL7_1)
        Me._txt_FamilyTEL1.Add(Me.txt_FamilyTEL8_1)
        Me._txt_FamilyTEL1.Add(Me.txt_FamilyTEL9_1)

        Me._txt_FamilyTEL2.Add(Me.txt_FamilyTEL1_2)
        Me._txt_FamilyTEL2.Add(Me.txt_FamilyTEL2_2)
        Me._txt_FamilyTEL2.Add(Me.txt_FamilyTEL3_2)
        Me._txt_FamilyTEL2.Add(Me.txt_FamilyTEL4_2)
        Me._txt_FamilyTEL2.Add(Me.txt_FamilyTEL5_2)
        Me._txt_FamilyTEL2.Add(Me.txt_FamilyTEL6_2)
        Me._txt_FamilyTEL2.Add(Me.txt_FamilyTEL7_2)
        Me._txt_FamilyTEL2.Add(Me.txt_FamilyTEL8_2)
        Me._txt_FamilyTEL2.Add(Me.txt_FamilyTEL9_2)

        Me._txt_FamilyTEL3.Add(Me.txt_FamilyTEL1_3)
        Me._txt_FamilyTEL3.Add(Me.txt_FamilyTEL2_3)
        Me._txt_FamilyTEL3.Add(Me.txt_FamilyTEL3_3)
        Me._txt_FamilyTEL3.Add(Me.txt_FamilyTEL4_3)
        Me._txt_FamilyTEL3.Add(Me.txt_FamilyTEL5_3)
        Me._txt_FamilyTEL3.Add(Me.txt_FamilyTEL6_3)
        Me._txt_FamilyTEL3.Add(Me.txt_FamilyTEL7_3)
        Me._txt_FamilyTEL3.Add(Me.txt_FamilyTEL8_3)
        Me._txt_FamilyTEL3.Add(Me.txt_FamilyTEL9_3)

        _rtb_WorkPlace(0) = rtb_WorkPlace1.Text
        _rtb_WorkPlace(1) = rtb_WorkPlace2.Text
        _rtb_WorkPlace(2) = rtb_WorkPlace3.Text
        _rtb_WorkPlace(3) = rtb_WorkPlace4.Text
        _rtb_WorkPlace(4) = rtb_WorkPlace5.Text
        _rtb_WorkPlace(5) = rtb_WorkPlace6.Text
        _rtb_WorkPlace(6) = rtb_WorkPlace7.Text
        _rtb_WorkPlace(7) = rtb_WorkPlace8.Text
        _rtb_WorkPlace(8) = rtb_WorkPlace9.Text

        ' お子様情報登録
        ' mainIDを取得してchildrenテーブルにInsertするSQL文の取得・送信
        sqlChildrenInsert = childrenInsertSQLStringGetter()
        If Sql.DBConnect(sqlChildrenInsert) = False Then : MsgBox(Sql.ErrorMessage()) : End If 'エラー処理

        ' 家族構成情報登録
        ' mainIDを取得してchildren_family_tableテーブルにInsertするSQL文の取得・送信
        If Sql.DBConnect("SELECT MAX(children_main_id) FROM children") = False Then
            MsgBox(Sql.ErrorMessage())
        End If

        maxMainID = Sql.DBResult(0)

        Dim i As Integer = 0

        While i < 8
            If (Me._txt_FamilyName(i).Text = "") Then
                count = i - 1
                Exit While
            End If
            i += 1
        End While

        i = 0

        While i <= count
            sqlFamilyTableInsert = familyTableInsertSQLStringGetter(maxMainID, i)
            If Sql.DBConnect(sqlFamilyTableInsert) = False Then : MsgBox(Sql.ErrorMessage()) : End If 'エラー処理
            i += 1
        End While

        ' 緊急連絡先情報登録
        ' mainIDを取得してchildren_family_emergencyテーブルにInsertするSQL文の取得・送信
        _txt_EmergencyName(0) = txt_EmergencyName1.Text
        _txt_EmergencyName(1) = txt_EmergencyName2.Text
        _txt_RelationEmergency(0) = txt_RelationEmergency1.Text
        _txt_RelationEmergency(1) = txt_RelationEmergency2.Text
        _txt_EmergencyTEL(0) = txt_EmergencyTEL1_1.Text + txt_EmergencyTEL1_2.Text + txt_EmergencyTEL1_3.Text
        _txt_EmergencyTEL(1) = txt_EmergencyTEL2_1.Text + txt_EmergencyTEL2_2.Text + txt_EmergencyTEL2_3.Text

        i = 0

        While i <= 1
            sqlFamilyEmergencyInsert = familyEmergencyInsertSQLStringGetter(maxMainID, i)
            If Sql.DBConnect(sqlFamilyEmergencyInsert) = False Then : MsgBox(Sql.ErrorMessage()) : End If 'エラー処理
            i += 1
        End While

        ' 通園情報登録
        ' mainIDを取得してchildren_family_mainテーブルにInsertするSQL文の取得・送信
        sqlFamilyMainInsert = familyMainInsertSQLStringGetter(maxMainID)
        If Sql.DBConnect(sqlFamilyMainInsert) = False Then : MsgBox(Sql.ErrorMessage()) : End If 'エラー処理

        ' 健康情報登録
        ' mainIDを取得してchildren_healthテーブルにInsertするSQL文の取得・送信
        sqlHealthInsert = healthInsertSQLStringGetter(maxMainID)
        If Sql.DBConnect(sqlHealthInsert) = False Then : MsgBox(Sql.ErrorMessage()) : End If 'エラー処理

        MsgBox("登録が完了しました。")
    End Sub

    Private Function childrenInsertSQLStringGetter() As String
        ' お子様情報登録
        Dim mainID As String = 0
        Dim sql_Sex As String = 0
        Dim sql_ChildName, sql_ChildNameKana, sql_Nickname, sql_EntranceDay, sql_Birthday, sql_PostalCode, sql_Address, sql_ChildTEL, sql_Temperature, sql_Mail, sql_DoctorName, sql_DoctorTEL

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

        ' classテーブルと関連付け
        If Sql.DBConnect("SELECT COUNT(main_id) FROM class") = False Then
            MsgBox(Sql.ErrorMessage())
        End If

        Dim count As String = Sql.DBResult(0, 0)

        Dim j As Integer
        If Sql.DBConnect("SELECT main_id, ClassName FROM class") = False Then
            MsgBox(Sql.ErrorMessage())
        End If

        For j = 0 To Integer.Parse(count) - 1 Step 1
            If (cmb_ClassName.Text = Sql.DBResult(j, 1)) Then
                mainID = Sql.DBResult(j, 0)
                Exit For
            End If
        Next

        ' SQLを返す。
        Return "INSERT INTO children(class_table_id, children_name, children_katakana, children_nickname, children_sex, birthday, admission_day, postal_code, address, average_temperature, contact, mail_address, primary_doctor_name, primary_doctor_contact)" _
                          & "VALUES (" & mainID & ",'" & sql_ChildName & "','" & sql_ChildNameKana & "','" & sql_Nickname & "','" & sql_Sex & "','" & sql_Birthday & "','" & sql_EntranceDay & "','" & sql_PostalCode & "','" & sql_Address & "','" & sql_Temperature & "'," & sql_ChildTEL & ",'" & sql_Mail & "','" & sql_DoctorName & "','" & sql_DoctorTEL & "')"
    End Function

    Private Function familyTableInsertSQLStringGetter(ByVal mainID As String, ByVal k As Integer) As String
        ' 家族構成タブの同居家族を情報登録
        Dim sql_FamilyName, sql_RelationFamily, sql_FamilyAge, sql_WorkPlace, sql_FamilyTEL

        sql_FamilyName = _txt_FamilyName(k).Text
        sql_RelationFamily = _txt_RelationFamily(k).Text
        sql_FamilyAge = _txt_FamilyAge(k).Text
        sql_WorkPlace = _rtb_WorkPlace(k)
        sql_FamilyTEL = _txt_FamilyTEL1(k).Text + _txt_FamilyTEL2(k).Text + _txt_FamilyTEL3(k).Text

        ' SQLを返す。
        Return "INSERT INTO children_family_table(children_main_id, name, relationship, age, office, contact)" _
                          & "VALUES (" & mainID & ",'" & sql_FamilyName & "','" & sql_RelationFamily & "','" & sql_FamilyAge & "','" & sql_WorkPlace & "','" & sql_FamilyTEL & "')"
    End Function

    Private Function familyEmergencyInsertSQLStringGetter(ByVal mainID As String, ByVal count As Integer) As String
        ' 家族構成タブの緊急連絡先を情報登録
        Dim sql_EmergencyName, sql_RelationEmergency, sql_EmergencyTEL

        sql_EmergencyName = _txt_EmergencyName(count)
        sql_RelationEmergency = _txt_RelationEmergency(count)
        sql_EmergencyTEL = _txt_EmergencyTEL(count)

        ' SQLを返す。
        Return "INSERT INTO children_family_emergency(children_main_id, emergency_name, emergency_relationship, emergency_contact)" _
                          & "VALUES (" & mainID & ",'" & sql_EmergencyName & "','" & sql_RelationEmergency & "','" & sql_EmergencyTEL & "')"
    End Function

    Private Function familyMainInsertSQLStringGetter(ByVal mainID As String) As String
        ' 家族構成タブの通園情報を登録
        Dim sql_CommutingMethod, sql_CommutingTime

        sql_CommutingMethod = rtb_CommutingMethod.Text
        sql_CommutingTime = txt_CommutingHour.Text + ":" + txt_CommutingMin.Text

        ' SQLを返す。
        Return "INSERT INTO children_family_main(children_main_id, transportation, transit_time)" _
                          & "VALUES (" & mainID & ",'" & sql_CommutingMethod & "','" & sql_CommutingTime & "')"
    End Function

    Private Function healthInsertSQLStringGetter(ByVal mainID As String) As String
        ' 家族構成タブの通園情報を登録
        Dim sql_AllergyDetails, sql_Operation, sql_SusceptibleIllness, sql_AnxietyAndAttention
        Dim sql_AllergyCheck As String = ""
        Dim sql_IllnessMeasles As String = ""
        Dim sql_IllnessMumps As String = ""
        Dim sql_IllnessChickenPox As String = ""
        Dim sql_IllnessRubella As String = ""
        Dim sql_IllnessEtc As String = ""
        Dim sql_VaccinationBCG As String = ""
        Dim sql_VaccinationPolio As String = ""
        Dim sql_VaccinationCombined As String = ""
        Dim sql_VaccinationMumps As String = ""
        Dim sql_VaccinationEncephalitis As String = ""

        sql_AllergyDetails = txt_AllergyDetails.Text
        sql_Operation = txt_Operation.Text
        sql_SusceptibleIllness = txt_SusceptibleIllness.Text
        sql_AnxietyAndAttention = rtb_AnxietyAndAttention.Text

        If (rdb_AllergyExist.Checked = True) Then
            sql_AllergyCheck = "○"
        End If

        If (chb_IllnessMeasles.Checked = True) Then
            sql_IllnessMeasles = "○"
        End If

        If (chb_IllnessMumps.Checked = True) Then
            sql_IllnessMumps = "○"
        End If

        If (chb_IllnessChickenPox.Checked = True) Then
            sql_IllnessChickenPox = "○"
        End If

        If (chb_IllnessRubella.Checked = True) Then
            sql_IllnessRubella = "○"
        End If

        If (chb_IllnessEtc.Checked = True) Then
            sql_IllnessEtc = txt_IllnessEtc.Text
        End If

        If (chb_IllnessEtc.Checked = True) Then
            sql_IllnessEtc = txt_IllnessEtc.Text
        End If

        If (chb_VaccinationBCG.Checked = True) Then
            sql_VaccinationBCG = "○"
        End If

        If (chb_VaccinationPolio.Checked = True) Then
            sql_VaccinationPolio = "○"
        End If

        If (chb_CombinedVaccination.Checked = True) Then
            sql_VaccinationCombined = "○"
        End If

        If (chb_VaccinationMumps.Checked = True) Then
            sql_VaccinationMumps = "○"
        End If

        If (chb_VaccinationEncephalitis.Checked = True) Then
            sql_VaccinationEncephalitis = "○"
        End If

        ' SQLを返す。
        Return "INSERT INTO children_health(children_main_id, allergies_check, allergies_details, sick_measles, sick_mumps, sick_chicken_pox, sick_rubella, sick_etc, surgery, vaccination_bcg, vaccination_polio, vaccination_combined, vaccination_mumps, vaccination_encephalitis, sick_vulnerable, notices)" _
                          & "VALUES (" & mainID & ",'" & sql_AllergyCheck & "','" & sql_AllergyDetails & "','" & sql_IllnessMeasles & "','" & sql_IllnessMumps & "','" & sql_IllnessChickenPox & "','" & sql_IllnessRubella & "','" & sql_IllnessEtc & "','" & sql_Operation & "','" & sql_VaccinationBCG & "','" & sql_VaccinationPolio & "','" & sql_VaccinationCombined & "','" & sql_VaccinationMumps & "','" & sql_VaccinationEncephalitis & "','" & sql_SusceptibleIllness & "','" & sql_AnxietyAndAttention & "')"
    End Function

    Private Sub cmb_Author_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Author.LostFocus
        EmInput(cmb_Author)
    End Sub

    Private Sub txt_ChildName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildName.LostFocus
        EmInput(txt_ChildName)
    End Sub

    Private Sub txt_NickName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NickName.LostFocus
        EmInput(txt_NickName)
    End Sub

    Private Sub txt_ChildNameKana_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ChildNameKana.LostFocus
        txt_ChildNameKana.Text = StrConv(txt_ChildNameKana.Text, VbStrConv.Katakana)
        EmInput(txt_ChildNameKana)
    End Sub

    Private Sub txt_Address_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Address.LostFocus
        txt_Address.Text = StrConv(txt_Address.Text, VbStrConv.Narrow)
    End Sub

    Private Sub txt_BuildingName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BuildingName.LostFocus
        txt_BuildingName.Text = StrConv(txt_BuildingName.Text, VbStrConv.Narrow)
    End Sub

    Private Sub txt_DoctorName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DoctorName.LostFocus
        EmInput(txt_DoctorName)
    End Sub

    Private Sub txt_FamilyName1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName1.LostFocus
        EmInput(txt_FamilyName1)
    End Sub

    Private Sub txt_RelationFamily1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily1.LostFocus
        EmInput(txt_RelationFamily1)
    End Sub

    Private Sub rtb_WorkPlace1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace1.LostFocus
        EmInput(rtb_WorkPlace1)
    End Sub

    Private Sub txt_FamilyName2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName2.LostFocus
        EmInput(txt_FamilyName2)
    End Sub

    Private Sub txt_RelationFamily2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily2.LostFocus
        EmInput(txt_RelationFamily2)
    End Sub

    Private Sub rtb_WorkPlace2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace2.LostFocus
        EmInput(rtb_WorkPlace2)
    End Sub

    Private Sub txt_FamilyName3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName3.LostFocus
        EmInput(txt_FamilyName3)
    End Sub

    Private Sub txt_RelationFamily3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily3.LostFocus
        EmInput(txt_RelationFamily3)
    End Sub

    Private Sub rtb_WorkPlace3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace3.LostFocus
        EmInput(rtb_WorkPlace3)
    End Sub

    Private Sub txt_FamilyName4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName4.LostFocus
        EmInput(txt_FamilyName4)
    End Sub

    Private Sub txt_RelationFamily4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily4.LostFocus
        EmInput(txt_RelationFamily4)
    End Sub

    Private Sub rtb_WorkPlace4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace4.LostFocus
        EmInput(rtb_WorkPlace4)
    End Sub

    Private Sub txt_FamilyName5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName5.LostFocus
        EmInput(txt_FamilyName5)
    End Sub

    Private Sub txt_RelationFamily5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily5.LostFocus
        EmInput(txt_RelationFamily5)
    End Sub

    Private Sub rtb_WorkPlace5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace5.LostFocus
        EmInput(rtb_WorkPlace5)
    End Sub

    Private Sub txt_FamilyName6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName6.LostFocus
        EmInput(txt_FamilyName6)
    End Sub

    Private Sub txt_RelationFamily6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily6.LostFocus
        EmInput(txt_RelationFamily6)
    End Sub

    Private Sub rtb_WorkPlace6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace6.LostFocus
        EmInput(rtb_WorkPlace6)
    End Sub

    Private Sub txt_FamilyName7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName7.LostFocus
        EmInput(txt_FamilyName7)
    End Sub

    Private Sub txt_RelationFamily7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily7.LostFocus
        EmInput(txt_RelationFamily7)
    End Sub

    Private Sub rtb_WorkPlace7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace7.LostFocus
        EmInput(rtb_WorkPlace7)
    End Sub

    Private Sub txt_FamilyName8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName8.LostFocus
        EmInput(txt_FamilyName8)
    End Sub

    Private Sub txt_RelationFamily8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily8.LostFocus
        EmInput(txt_RelationFamily8)
    End Sub

    Private Sub rtb_WorkPlace8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace8.LostFocus
        EmInput(rtb_WorkPlace8)
    End Sub

    Private Sub txt_FamilyName9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FamilyName9.LostFocus
        EmInput(txt_FamilyName9)
    End Sub

    Private Sub txt_RelationFamily9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationFamily9.LostFocus
        EmInput(txt_RelationFamily9)
    End Sub

    Private Sub rtb_WorkPlace9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_WorkPlace9.LostFocus
        EmInput(rtb_WorkPlace9)
    End Sub

    Private Sub txt_EmergencyName1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EmergencyName1.LostFocus
        EmInput(txt_EmergencyName1)
    End Sub

    Private Sub txt_EmergencyName2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EmergencyName2.LostFocus
        EmInput(txt_EmergencyName2)
    End Sub

    Private Sub txt_RelationEmergency1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationEmergency1.LostFocus
        EmInput(txt_RelationEmergency1)
    End Sub

    Private Sub txt_RelationEmergency2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_RelationEmergency2.LostFocus
        EmInput(txt_RelationEmergency2)
    End Sub

    Private Sub rtb_CommutingMethod_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_CommutingMethod.LostFocus
        EmInput(rtb_CommutingMethod)
    End Sub

    Private Sub txt_AllergyDetails_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_AllergyDetails.LostFocus
        EmInput(txt_AllergyDetails)
    End Sub

    Private Sub txt_IllnessEtc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IllnessEtc.LostFocus
        EmInput(txt_IllnessEtc)
    End Sub

    Private Sub txt_Operation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Operation.LostFocus
        EmInput(txt_Operation)
    End Sub

    Private Sub txt_SusceptibleIllness_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SusceptibleIllness.LostFocus
        EmInput(txt_SusceptibleIllness)
    End Sub

    Private Sub rtb_AnxietyAndAttention_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb_AnxietyAndAttention.LostFocus
        EmInput(rtb_AnxietyAndAttention)
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
        RegistData()
    End Sub

    Private Sub btn_ChildNext_Click(sender As Object, e As EventArgs) Handles btn_ChildNext.Click, Button1.Click
        TabControl1.SelectedTab = tab_Family
    End Sub

    Private Sub btn_FamilyNext_Click(sender As Object, e As EventArgs) Handles btn_FamilyNext.Click
        TabControl1.SelectedTab = tab_Health
    End Sub

    Private Sub btn_FamilyBack_Click(sender As Object, e As EventArgs) Handles btn_FamilyBack.Click
        TabControl1.SelectedTab = tab_Child
    End Sub

    Private Sub btn_HealthBack_Click(sender As Object, e As EventArgs) Handles btn_HealthBack.Click
        TabControl1.SelectedTab = tab_Family
    End Sub

    Private Sub chb_IllnessEtc_CheckedChanged(sender As Object, e As EventArgs) Handles chb_IllnessEtc.CheckedChanged
        If (chb_IllnessEtc.Checked = True) Then
            txt_IllnessEtc.Enabled = True
        Else
            txt_IllnessEtc.Enabled = False
        End If
    End Sub

    Private Sub menu_SaveAsFile_Click(sender As Object, e As EventArgs) Handles menu_SaveAsFile.Click
        RegistData()
    End Sub

    Private Sub menu_Finish_Click(sender As Object, e As EventArgs) Handles menu_Finish.Click
        Me.Close()
    End Sub
End Class
