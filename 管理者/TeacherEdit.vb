Imports System.Text.RegularExpressions

Public Class TeacherEdit

    Dim Sql As SQLConnectClass

    Public Sub SetID(s As SQLConnectClass)
        Sql = s
    End Sub

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        encsjis = System.Text.Encoding.GetEncoding("Shift_JIS")
        PositionComboBox.SelectedIndex = 1
        Year.Value = Now.Year
        Panel1.Location = New Point(12, 12)
    End Sub

    Private Sub RegistrationButton_Click_1(sender As Object, e As EventArgs) Handles RegistrationButton.Click

        Dim sqlUserInsert As String
        Dim sqlWorkerInsert As String
        Dim maxMainID As String

        ErrorMessageInvisible()
        If InputErrorCheck() = False Then

            ' user_idテーブルにINSERTするSQL文の取得・送信
            sqlUserInsert = userInsertSQLStringGetter()
            If Sql.DBConnect(sqlUserInsert) = False Then : MsgBox(Sql.ErrorMessage()) : End If 'エラー処理

            ' 上で自動登録されたIDを取得
            If Sql.DBConnect("SELECT MAX(mainID) FROM test_id") = False Then : MsgBox(Sql.ErrorMessage()) : End If 'エラー処理

            ' mainIDを取得してworkerテーブルにInsertするSQL文の取得・送信
            maxMainID = Sql.DBResult(0)
            sqlWorkerInsert = workerInsertSQLStringGetter(maxMainID)
            If Sql.DBConnect(sqlWorkerInsert) = False Then : MsgBox(Sql.ErrorMessage()) : End If 'エラー処理

            MsgBox("登録が完了しました。")
        Else
            MsgBox("登録出来ませんでした。赤字の箇所を修正してください。")
        End If

    End Sub

    Private Function userInsertSQLStringGetter() As String
        Dim user_atai, user_atai2, user_atai3
        'ユーザー登録
        user_atai = Me.UserIdTextbox.Text
        user_atai2 = Hash.GetStretchedPassword(Me.UserPassTextbox.Text, Me.UserIdTextbox.Text)
        user_atai3 = Me.ConfirmationUserPassTextbox.Text
        Return "INSERT INTO test_id(userID, userPassword, username)" _
                     & "VALUES ('" & user_atai & "','" & user_atai2 & "','" & user_atai3 & "')"
    End Function


    Private Function workerInsertSQLStringGetter(mainID As String) As String

        Dim user_atai, user_atai2, user_atai3
        Dim worker_atai, worker_atai2, worker_atai3, worker_atai4, worker_atai5, worker_atai6, worker_atai7, worker_atai8, worker_atai9, worker_atai10, worker_atai11

        'ユーザー登録
        user_atai = Me.UserIdTextbox.Text
        user_atai2 = Hash.GetStretchedPassword(Me.UserPassTextbox.Text, Me.UserIdTextbox.Text)
        user_atai3 = Me.ConfirmationUserPassTextbox.Text

        '保育士情報登録
        worker_atai = Me.LastName.Text + Me.FirstName.Text
        worker_atai2 = Me.Lastname2.Text + Me.FirstName2.Text
        worker_atai3 = Date.Parse(Me.BitrhYearComboBox.Text & "/" & Me.BitrhMonthComboBox.Text & "/" & Me.BitrhDayComboBox.Text)

        If WomenRadioButton.Checked = True Then
            worker_atai4 = Me.WomenRadioButton.Text
        ElseIf MenRadioButton.Checked = True Then
            worker_atai4 = Me.MenRadioButton.Text
        Else
            worker_atai4 = ""
        End If

        worker_atai5 = Me.PositionComboBox.Text
        worker_atai6 = Me.Year.Value
        worker_atai7 = Me.Tell1.Text + Me.Tell2.Text + Me.Tell3.Text
        worker_atai8 = Me.TellEmergency.Text + Me.TellEmergency2.Text + Me.TellEmergency3.Text
        worker_atai9 = Me.EmailTextBox1.Text & "@" & Me.EmailTextBox2.Text
        worker_atai10 = Integer.Parse(Me.PostalCode1.Text + PostalCode2.Text)
        worker_atai11 = Me.PrefectureComboBox.Text + Me.MunicipalityTextBox.Text + Me.AddressTextBox.Text + Me.BuildingNameTextBox.Text + RoomNumberTextBox.Text

        Return "INSERT INTO worker(test_id_mainID, worker_name, worker_katakana, birthday, sex, Position, employment_year, normal_contact, emergency_contact, mail_address, postal_code, address)" _
                          & "VALUES (" & mainID & ",'" & worker_atai & "','" & worker_atai2 & "','" & worker_atai3 & "','" & worker_atai4 & "','" & worker_atai5 & "'," & worker_atai6 & ",'" & worker_atai7 & "','" & worker_atai8 & "','" & worker_atai9 & "'," & worker_atai10 & ",'" & worker_atai11 & "')"

    End Function

    ''' <summary>
    ''' 入力値のエラーチェックとエラーメッセージの表示をする。
    ''' </summary>
    ''' <returns>True: エラー False: 正常終了</returns>
    ''' <remarks></remarks>
    Private Function InputErrorCheck() As Boolean
        Dim ErrFlg As Boolean = False
        '姓名チェック
        If Me.LastName.Text = "" Then
            LastNameError1.Visible = True
            ErrFlg = True
        End If

        If Me.Lastname2.Text = "" Then
            LastNameError2.Visible = True
            ErrFlg = True
        End If

        If Me.FirstName.Text = "" Then
            FirstNameError1.Visible = True
            ErrFlg = True
        End If

        If Me.FirstName2.Text = "" Then
            FirstNameError2.Visible = True
            ErrFlg = True
        End If

        '連絡先チェック
        If Me.Tell1.Text = "" Then
            DaytimeError.Visible = True
            ErrFlg = True
        End If

        If Me.Tell2.Text = "" Then
            DaytimeError.Visible = True
            ErrFlg = True
        End If

        If Me.Tell3.Text = "" Then
            DaytimeError.Visible = True
            ErrFlg = True
        End If

        If Me.TellEmergency.Text = "" Then
            EmergencyError.Visible = True
            ErrFlg = True
        End If

        If Me.TellEmergency2.Text = "" Then
            EmergencyError.Visible = True
            ErrFlg = True
        End If

        If Me.TellEmergency3.Text = "" Then
            EmergencyError.Visible = True
            ErrFlg = True
        End If

        If Me.EmailTextBox1.Text = "" Or Me.EmailTextBox2.Text = "" Then
            EmailError1.Visible = True
            ErrFlg = True
        End If

        If Me.EmailTextBox2.Text.IndexOf(",") >= 0 Then
            EmailError2.Visible = True
            ErrFlg = True
        End If

        '住所チェック
        If Me.PostalCode1.Text = "" Then
            PostalCodeError.Visible = True
            ErrFlg = True
        End If

        If Me.PostalCode2.Text = "" Then
            PostalCodeError.Visible = True
            ErrFlg = True
        End If

        If Me.PrefectureComboBox.Text = "" Then
            PrefectureError.Visible = True
            ErrFlg = True
        End If

        If Me.MunicipalityTextBox.Text = "" Then
            MunicipalityError.Visible = True
            ErrFlg = True
        End If

        If Me.AddressTextBox.Text = "" Or Me.AddressTextBox.ToString.IndexOf("--") >= 0 Then
            'Or Char.IsDigit(Me.AddressTextBox.ToString.Substring(Me.AddressTextBox.TextLength)) = False Then
            AddressError.Visible = True
            ErrFlg = True
        End If

        'ユーザー登録チェック
        If UserIdTextbox.TextLength < 4 Then
            UserIdError.ForeColor = Color.Red
            ErrFlg = True
        End If

        If UserPassTextbox.TextLength < 4 Then
            UserPassError1.ForeColor = Color.Red
            ErrFlg = True
        End If

        If System.Text.RegularExpressions.Regex.IsMatch( _
        Me.UserPassTextbox.Text, "([a-z]+\d)|(\d+[a-z])") = False Then
            UserPassError2.ForeColor = Color.Red
            ErrFlg = True
        End If

        If Me.UserPassTextbox.Text <> Me.ConfirmationUserPassTextbox.Text Then
            ConfirmationUserPassError.Visible = True
            ErrFlg += 1
            ErrFlg = True
        End If

        If Me.ConfirmationUserPassTextbox.Text = "" Then
            ConfirmationUserPassError.Visible = True
            ErrFlg = True
        End If
        Return ErrFlg
    End Function

    ''' <summary>
    ''' エラーメッセージ全てを隠す
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ErrorMessageInvisible()
        '姓名のエラーメッセージ
        LastNameError1.Visible = False
        LastNameError2.Visible = False
        FirstNameError1.Visible = False
        FirstNameError2.Visible = False

        '連絡先のエラーメッセージ
        DaytimeError.Visible = False
        EmergencyError.Visible = False
        EmailError1.Visible = False
        EmailError2.Visible = False

        '住所のエラーメッセージ
        PostalCodeError.Visible = False
        PrefectureError.Visible = False
        MunicipalityError.Visible = False
        AddressError.Visible = False

        'ユーザー登録のエラーメッセージ
        UserIdError.ForeColor = Color.Black
        ConfirmationUserPassError.Visible = False
        UserPassError1.ForeColor = Color.Black
        UserPassError2.ForeColor = Color.Black
    End Sub

    Private Sub CancelButton_Click_1(sender As Object, e As EventArgs) Handles CancelButton.Click

        'メッセージボックスを表示する 
        Dim result As DialogResult = MessageBox.Show("登録を中断しますか？", _
                                                     "質問", _
                                                     MessageBoxButtons.OKCancel, _
                                                     MessageBoxIcon.Warning)
        '何が選択されたか調べる 
        If result = DialogResult.OK Then
            '「はい」が選択された時 
            Me.Close()
        ElseIf result = DialogResult.No Then
            '「キャンセル」が選択された時 
        End If
    End Sub

    Private encsjis As System.Text.Encoding

    Private Sub Watermark1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LastName.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.LastName.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.LastName.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(LastName.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            LastName.Text = LastName.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    Private Sub Watermark2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FirstName.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.FirstName.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.FirstName.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(FirstName.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            FirstName.Text = FirstName.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    Private Sub Watermark3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lastname2.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.Lastname2.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.Lastname2.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(Lastname2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            Lastname2.Text = Lastname2.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    Private Sub Watermark4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FirstName2.TextChanged
        Dim z As String = String.Empty
        For Each s As String In Me.FirstName2.Text
            If encsjis.GetBytes(s).Length = 2 Then
                z = z & s
            End If
        Next
        Me.FirstName2.Text = z

        ' 見つけたい文字のパターンを全角の数字・全角の英大文字・全角の英小文字を指定
        Dim re As New Regex("(?<moji>[０-９Ａ-Ｚａ-ｚ])")

        ' テキストボックス内の文字でパターンに合う文字を取得
        Dim m As Match = re.Match(FirstName2.Text)

        ' 見つかった文字を順に取得
        While m.Success

            ' テキストボックス内の文字を置換
            ' 置換前の文字は取得した文字
            ' 置換後の文字は置換前の文字を半角に変換したもの
            FirstName2.Text = FirstName2.Text.Replace(m.Result("${moji}"), StrConv(m.Result("${moji}"), VbStrConv.Narrow))

            ' 次の文字に移動
            m = m.NextMatch()
        End While
    End Sub

    Private Sub PrefectureComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrefectureComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub PostalCodeSearchButton_Click(sender As Object, e As EventArgs) Handles PostalCodeSearchButton.Click
        '見つかったかどうかのフラグ
        Dim blnFlag As Boolean = False

        '郵便番号の上3ケタが入力されていないとき
        If (PostalCode1.Text = "") Then
            MessageBox.Show("郵便番号の上3桁が入力されていません。")
            Me.PostalCode1.Focus()
            Return
            '郵便番号の上4ケタが入力されていないとき
        ElseIf (PostalCode2.Text = "") Then
            MessageBox.Show("郵便番号の下4桁が入力されていません。")
            Me.PostalCode2.Focus()
            Return
        End If

        'マウスカーソルを砂時計にする
        Cursor.Current = Cursors.WaitCursor

        '郵便番号上3桁と下4桁を結合
        Dim sKey As String = PostalCode1.Text + PostalCode2.Text

        Try

            'StreamReaderオブジェクトの作成
            Dim sr As New System.IO.StreamReader(My.Application.Info.DirectoryPath & "\ken_all\KEN_ALL.CSV", System.Text.Encoding.Default)
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
                    '都道府県名テキストボックスに都道府県名を表示
                    PrefectureComboBox.Text = sbuf(6).Trim(ControlChars.Quote)
                    '入力された郵便番号の下4桁が全て0の場合
                    If (PostalCode2.Text = "0000") Then
                        '市区町村テキストボックスに市区町村名を表示
                        MunicipalityTextBox.Text = sbuf(7).Trim(ControlChars.Quote)
                    Else
                        '市区町村テキストボックスに市区町村名+町域名を表示
                        MunicipalityTextBox.Text = sbuf(7).Trim(ControlChars.Quote) + sbuf(8).Trim(ControlChars.Quote)
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

    Private Sub AddressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AddressTextBox.KeyPress
        '0～9、バックスペース、ハイフン以外のキーを押した場合はイベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso _
                e.KeyChar <> ControlChars.Back And e.KeyChar <> "-" Then
            e.Handled = True
        End If

    End Sub

    Private Sub RoomNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RoomNumberTextBox.KeyPress, PostalCode2.KeyPress, PostalCode1.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso _
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub Tell1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TellEmergency3.KeyPress, TellEmergency2.KeyPress, TellEmergency.KeyPress, Tell3.KeyPress, Tell2.KeyPress, Tell1.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso _
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    ' Private Sub Year_Move(sender As Object, e As EventArgs) Handles Year.Move
    '    If Year.ToString.Length > 4 Then
    '       Year = Year.ToString.Remove(3)
    '      Year = Year.ToString.Length
    '   End If
    'End Sub

    Private Sub TeacherEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub
End Class