Imports Microsoft.Office.Interop.Excel


Public Class Month35Age
    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox
    Dim sqlConnect As SQLConnectClass

    Public Sub SetID(sqlConnect As SQLConnectClass)
        'クラス名を反映
        If sqlConnect.DBConnect("SELECT COUNT(main_id) FROM test_cluss") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If

        Dim count As String = sqlConnect.DBResult(0, 0)

        Dim j As Integer
        If sqlConnect.DBConnect("SELECT ClassName FROM test_cluss") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If
        For j = 0 To Integer.Parse(count) - 1 Step 1
            ComboBoxClassName.Items.Add(sqlConnect.DBResult(j, 0))
        Next
        '教員名を反映
        If sqlConnect.DBConnect("SELECT COUNT(userName) FROM test_id") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If
        count = sqlConnect.DBResult(0, 0)

        If sqlConnect.DBConnect("SELECT userName FROM test_id") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If
        For j = 0 To Integer.Parse(count) - 1 Step 1
            ComboBoxLeaderName.Items.Add(sqlConnect.DBResult(j, 0))
        Next

    End Sub

    Private Sub MonthHigh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        AddEventHandler()

        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
    End Sub
    Private Sub AddEventHandler()
        'イベントハンドラ受け入れ先作成
        Me.TextBoxChildrenNum = New System.Windows.Forms.TextBox(1) _
            {TextBoxBoysNumber, TextBoxGirlsNumber}
        'イベントハンドラの登録
        Dim i As Integer
        For i = 0 To Me.TextBoxChildrenNum.Length - 1
            AddHandler Me.TextBoxChildrenNum(i).KeyPress, _
                AddressOf Me.Num_KeyPress
            AddHandler Me.TextBoxChildrenNum(i).TextChanged, _
                AddressOf Me.AutoSum
            AddHandler Me.TextBoxChildrenNum(i).Enter, _
                AddressOf Me.AutoText_Enter
            AddHandler Me.TextBoxChildrenNum(i).Leave, _
                AddressOf Me.AutoText_Leave
        Next i
    End Sub
    Private Sub Num_KeyPress(ByVal sender As Object, _
            ByVal e As KeyPressEventArgs)
        ' テキストの長さ上限値
        Dim textLength = 2
        Dim tBox As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)

        '押されたキーが「0～9でない場合」かつ「BackSpaceでない場合」イベントをキャンセルする
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        tBox.MaxLength = textLength
    End Sub
    Private Sub AutoSum(ByVal sender As Object, ByVal e As EventArgs)
        'フォーム上のものからとってくる
        Dim strX As String = TextBoxBoysNumber.Text
        Dim strY As String = TextBoxGirlsNumber.Text


        '計算に使う変数
        Dim x As Integer = 0
        Dim y As Integer = 0

        'strXとstrYを数値に変換する
        If strX <> "" Then x = Integer.Parse(strX)
        If strY <> "" Then y = Integer.Parse(strY)

        If x = 0 And y = 0 Then
            LabelSum.Text = ""
        Else
            LabelSum.Text = x + y
        End If
    End Sub
    Private Sub AutoText_Enter(sender As Object, e As EventArgs)
        Dim tBox As TextBox = CType(sender, System.Windows.Forms.TextBox)
        If tBox.Text = "0" Then
            tBox.Clear()
        End If
    End Sub
    Private Sub AutoText_Leave(sender As Object, e As EventArgs)
        Dim tBox As TextBox = CType(sender, System.Windows.Forms.TextBox)
        If tBox.Text = "" Then
            tBox.Text = "0"
        End If
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs)


        Dim sqlString As String = Input_month_main_high()
        Dim sqlConnect As New SQLConnectClass

        If sqlConnect.DBConnect(sqlString) = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else

            sqlConnect.DBConnect("SELECT MAX(month_main_high_id) FROM child_monthplan_main_high;")
            Dim ds As DataSet = sqlConnect.DBResult()
            Dim dt As DataTable = ds.Tables.Item(0)
            Dim mainID As String = dt.Rows(0).Item(0)
            For i = 0 To 2
                Dim s As String = Input_month_table_high(i, mainID)
                sqlConnect.DBConnect(s)
            Next
        End If
        MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    '読解性上昇のために作成した関数
    Private Function Input_month_main_high() As String
        Dim sqlString As String

        sqlString = "INSERT INTO " _
                    & "`child_monthplan_main_3to5`" _
                        & "(" _
                            & "`ClassName`, `BoysNumber`, `GirlsNumber`," _
                            & "`CreatedDate`, `TargetYear`, `TargetMonth`," _
                            & "`StateMonth`, `Aim`," _
                            & "`LeaderName`, `EvaluationTeacher`, `CollaborationRegion`," _
                            & "`Event`, `CollaborationStaff`, `CooperationHome`," _
                            & "`SpecificChild`, `UpdateDate`" _
                        & ")" _
                    & "VALUES (" _
                               & "'" & ComboBoxClassName.Text & "'" _
                        & ", " & "'" & TextBoxBoysNumber.Text & "'" _
                        & ", " & "'" & TextBoxGirlsNumber.Text & "'" _
                        & ", NOW()" _
                        & ", " & "'" & ComboBoxTargetYear.Text & "'" _
                        & ", " & "'" & ComboBoxTargetMonth.Text & "'" _
                        & ", " & "'" & RichTextBoxStateMonth.Text & "'" _
                        & ", " & "'" & RichTextBoxAim.Text & "'" _
                        & ", " & "'" & ComboBoxLeaderName.Text & "'" _
                        & ", " & "'" & RichTextBoxEvaluationTeacher.Text & "'" _
                        & ", " & "'" & RichTextBoxCollaborationRegion.Text & "'" _
                        & ", " & "'" & RichTextBoxEvent.Text & "'" _
                        & ", " & "'" & RichTextBoxCollaborationStaff.Text & "'" _
                        & ", " & "'" & RichTextBoxCooperationHome.Text & "'" _
                        & ", " & "'" & RichTextBoxSpecificChild.Text & "'" _
                        & ", NOW()" _
                    & ");"
        Return sqlString
    End Function

    Private Function Input_month_table_high(i As Integer, main_id As String) As String
        '確実に三回のみ呼び出してください
        Dim sqlString As String
        Dim type = New String() {
            "Nursing", "Education", "Food"
            }
        Dim Contents = New RichTextBox() {
                RichTextBoxNursingContents,
                RichTextBoxEducationContents,
                RichTextBoxFoodContents
            }
        Dim EnvironmentalComposition = New RichTextBox() {
                RichTextBoxNursingConstitution,
                RichTextBoxEducationConstitution,
                RichTextBoxFoodConstitution
            }
        Dim ExpectedChild = New RichTextBox() {
                RichTextBoxNursingExpectedChild,
                RichTextBoxEducationExpectedChild,
                RichTextBoxFoodExpectedChild
            }
        Dim ChildcareAssistance = New RichTextBox() {
                RichTextBoxNursingAssistance,
                RichTextBoxEducationAssistance,
                RichTextBoxFoodAssistance
            }
        sqlString = "INSERT INTO " _
                    & "`child_monthplan_table_3to5`" _
                    & "(" _
                        & "`month_main_3to5_id`," _
                        & "`type`," _
                        & "`Contents`," _
                        & "`EnvironmentalComposition`," _
                        & "`ExpectedChild`," _
                        & "`ChildcareAssistance`" _
                    & ")" _
                    & " VALUES(" _
                        & " " & main_id & "," _
                        & "'" & type(i) & "'," _
                        & "'" & Contents(i).Text & "'," _
                        & "'" & EnvironmentalComposition(i).Text & "'," _
                        & "'" & ExpectedChild(i).Text & "'," _
                        & "'" & ChildcareAssistance(i).Text & "'" _
                    & ");"

        Return sqlString
    End Function


    Private Sub MonthHigh_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub Xend_Click(sender As Object, e As EventArgs)
        Owner.Enabled = True
        Me.Dispose()
    End Sub

    Public Sub closecheck()
        Dim fileName As String = "C:\test\month2age\保育指導月案（2歳用）" & _
              ComboBoxClassName.Text & ComboBoxTargetMonth.Text & "月.xlsm"
        If System.IO.File.Exists("C:\test\month2age\" & fileName.ToString) Then
            Dim xlApp As New Application()
            If xlApp IsNot Nothing Then
                xlApp.Visible = False
                xlApp.Workbooks.Open(fileName)
                CType(xlApp.ActiveWorkbook.Sheets(1), Worksheet).Select()
                Dim arrayData As String(,)
                Dim aRange As Range

                arrayData = addData()
                Dim j = 0, errflg = 0



                '入力されているものと差異があるかどうか確認する
                For i = 0 To 42

                    aRange = xlApp.Range(arrayData(i, 1))

                    If aRange.Value2 <> arrayData(j, 0) Then
                        errflg = 1
                    End If
                    j = j + 1
                Next
                xlApp.ActiveWorkbook.Close()
                xlApp.Quit()

                If errflg = 1 Then
                    Dim result As DialogResult = MessageBox.Show("保存していない変更箇所があります。ページを閉じれば保存されませんが本当にこのページを閉じますか？",
                                                  "質問",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Exclamation,
                                                  MessageBoxDefaultButton.Button2)
                    If result = DialogResult.Yes Then
                        Me.Close()
                    End If
                Else
                    Me.Close()
                End If

            End If
        Else
            Dim result As DialogResult = MessageBox.Show("このページの保存を行えていません。本当に閉じますか？",
                                                "質問",
                                                MessageBoxButtons.YesNoCancel,
                                                MessageBoxIcon.Exclamation,
                                                MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Me.Close()
            End If
        End If

    End Sub

    Private Sub 上書き保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim fileName As String
        fileName = "保育指導月案（2歳用）" & _
                       ComboBoxClassName.Text & ComboBoxLeaderName.Text & "月.xlsm"
        'Dim result As DialogResult = MessageBox.Show(fileName.ToString & "を上書きしますか？", _
        '                                       "質問", _
        '                                       MessageBoxButtons.YesNo, _
        '                                       MessageBoxIcon.Exclamation, _
        '                                       MessageBoxDefaultButton.Button2)

        If System.IO.File.Exists("C:\test\month2age\" & fileName.ToString) = False Then
            System.IO.File.Copy("C:\test\templ\2agetempl.xlsm", "C:\test\month2age\" & fileName.ToString)
        End If
        Dim xlApp As New Application()
        If xlApp IsNot Nothing Then
            xlApp.Visible = False
            xlApp.Workbooks.Open("C:\test\month2age\" & fileName)
            CType(xlApp.ActiveWorkbook.Sheets(1), Worksheet).Select()
            Dim arrayData As String(,)
            Dim aRange As Range

            arrayData = addData()
            Dim j = 0
            '入力されているものをexcelへ置き換える
            For i = 0 To 42

                aRange = xlApp.Range(arrayData(i, 1))
                If aRange IsNot Nothing Then
                    Console.WriteLine(aRange.Value2)
                    aRange.Value2 = arrayData(j, 0)
                    Console.WriteLine(aRange.Value2)
                End If
                j = j + 1
            Next
            xlApp.ActiveWorkbook.Close()
            xlApp.Quit()
        End If
        ' DBSave()
        MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        '印刷するファイルの参照
        Dim fileName As String = "C:\test\month2age\保育指導月案（2歳用）" & _
                        ComboBoxClassName.Text & ComboBoxTargetMonth.Text & "月.xlsm"

        'ファイルがあるか確認
        If System.IO.File.Exists("C:\test\month2age\" & fileName.ToString) Then
            Dim xlApp As New Application()
            If xlApp IsNot Nothing Then
                xlApp.Visible = False
                xlApp.Workbooks.Open(fileName)
                CType(xlApp.ActiveWorkbook.Sheets(1), Worksheet).Select()
                Dim arrayData As String(,)

                arrayData = addData()
                xlApp.Worksheets.PrintPreview(fileName)
                xlApp.ActiveWorkbook.Close()
                xlApp.Quit()
            End If
        Else
            MsgBox("保存をしてください")
        End If
        'Dim j = 0
        ''入力されているものをexselへ置き換える
        'For i = 0 To 42

        '    aRange = xlApp.Range(arrayData(i, 1))
        '    If aRange IsNot Nothing Then
        '        Console.WriteLine(aRange.Value2)
        '        aRange.Value2 = arrayData(j, 0)
        '        Console.WriteLine(aRange.Value2)
        '    End If
        '    j = j + 1
        'Next
        'プレビュー画面を呼び出す
    End Sub

    Public Function addData() As String(,)
        Dim arrayData(,) = {{RichTextBoxStateMonth.Text, "B5"}, _
                           {RichTextBoxAim.Text, "I5"}, _
                           {ComboBoxClassName.Text, "M2"}, _
                           {ComboBoxTargetYear.Text & "年" & ComboBoxTargetMonth.Text & "月", "R2"}, _
                           {LabelSum.Text & "人(男" & TextBoxBoysNumber.Text & "人,女" & TextBoxGirlsNumber.Text & "人)", "M3"}, _
                           {ComboBoxLeaderName.Text, "R3"}, _
                           {RichTextBoxNursingContents.Text, "C7"}, _
                           {RichTextBoxNursingConstitution.Text, "G7"}, _
                           {RichTextBoxNursingExpectedChild.Text, "J7"}, _
                           {RichTextBoxNursingAssistance.Text, "M7"}, _
                           {RichTextBoxEducationContents.Text, "C10"}, _
                           {RichTextBoxEducationConstitution.Text, "G10"}, _
                           {RichTextBoxEducationExpectedChild.Text, "J10"}, _
                           {RichTextBoxEducationAssistance.Text, "M10"}, _
                           {RichTextBoxFoodConstitution.Text, "C16"}, _
                           {RichTextBoxFoodExpectedChild.Text, "G16"}, _
                           {RichTextBoxFoodAssistance.Text, "J16"}, _
                           {RichTextBoxFoodContents.Text, "M16"}, _
                           {RichTextBoxEvaluationTeacher.Text, "C17"}, _
                           {RichTextBoxCollaborationRegion.Text, "L17"}, _
                           {RichTextBoxEvent.Text, "Q4"}, _
                           {RichTextBoxCollaborationStaff.Text, "Q8"}, _
                           {RichTextBoxCooperationHome.Text, "Q11"}, _
                           {RichTextBoxSpecificChild.Text, "Q14"}, _
                           {DateTimePickerCreatedDate.Text, "Q1"}}

        Return arrayData
    End Function

    Private Sub BnfImgBtn_Click(sender As Object, e As EventArgs) Handles BnfImgBtn.Click
        closecheck()
    End Sub
End Class