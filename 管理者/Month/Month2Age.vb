Imports Microsoft.Office.Interop.Excel

Public Class Month2Age

    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox
    Dim sqlConnect As SQLConnectClass

    Public Sub SetID(sql As SQLConnectClass)
        sqlConnect = sql
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
            ClassName.Items.Add(sqlConnect.DBResult(j, 0))
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
            LeaderName.Items.Add(sqlConnect.DBResult(j, 0))
        Next

    End Sub

    Private Sub MonthHigh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        AddEventHandler()
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
        Dim tBox As TextBox = CType(sender, System.Windows.Forms.TextBox)

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
        Dim result As Label = LabelSum

        '計算に使う変数
        Dim x As Integer = 0
        Dim y As Integer = 0

        'strXとstrYを数値に変換する
        If strX <> "" Then x = Integer.Parse(strX)
        If strY <> "" Then y = Integer.Parse(strY)

        If x = 0 And y = 0 Then
            result.Text = ""
        Else
            result.Text = x + y
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

    Private Sub 名前を付けて保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastToolStripMenuItem.Click

        Dim fileName As String
        fileName = "保育指導月案（2歳用）" & _
                        ClassName.Text & TargetMonth.Text & "月.xlsm"
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


        'hyara
        Dim sqlString As String = Input_month_main_high()

        'If sqlConnect.DBConnect(sqlString) = False Then
        'MsgBox(sqlConnect.ErrorMessage)
        'Else

        'sqlConnect.DBConnect("SELECT MAX(month_main_2to2_id) FROM child_monthplan_main_2to2;")
        'Dim ds As DataSet = sqlConnect.DBResult()
        'Dim dt As DataTable = ds.Tables.Item(0)
        'Dim mainID As String = dt.Rows(0).Item(0)
        'For i = 0 To 5
        '    Dim s As String = Input_month_table_high(i, mainID)
        '    If sqlConnect.DBConnect(s) = False Then
        '        MsgBox(sqlConnect.ErrorMessage)
        '    End If
        'Next
        'End If
        'MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    '読解性上昇のために作成した関数
    Private Function Input_month_main_high() As String
        Dim sqlString As String

        sqlString = "INSERT INTO " _
                        & "`child_monthplan_main_2to2`" _
                    & "(" _
                        & "`ClassName`,`BoysNumber`, `GirlsNumber`," _
                        & "`CreatedDate`, `TargetYear`, `TargetMonth`," _
                        & "`LeaderName`, `StateMonth`," _
                        & "`AimNursing`, `AimEducation`," _
                        & "`Event`, `Contents`, `HealthSafety`," _
                        & "`EnvironmentalComposition`, `Eat`," _
                        & "`EvaluationReflection`, `NextPoint`, `UpdateDate`" _
                    & ")" _
                    & "VALUES (" _
                               & "'" & ClassName.Text & "'" _
                        & ", " & "'" & TextBoxBoysNumber.Text & "'" _
                        & ", " & "'" & TextBoxGirlsNumber.Text & "'" _
                        & ", NOW()" _
                        & ", " & "'" & TargetYear.Text & "'" _
                        & ", " & "'" & TargetMonth.Text & "'" _
                        & ", " & "'" & LeaderName.Text & "'" _
                        & ", " & "'" & StateMonth.Text & "'" _
                        & ", " & "'" & AimNursing.Text & "'" _
                        & ", " & "'" & AimEducation.Text & "'" _
                        & ", " & "'" & RichTextBox_Event.Text & "'" _
                        & ", " & "'" & Contents.Text & "'" _
                        & ", " & "'" & HealthSafety.Text & "'" _
                        & ", " & "'" & EnvironmentalComposition.Text & "'" _
                        & ", " & "'" & Eat.Text & "'" _
                        & ", " & "'" & EvaluationReflection.Text & "'" _
                        & ", " & "'" & NextPoint.Text & "'" _
                        & ", NOW()" _
                    & ");"
        Return sqlString
    End Function

    Private Function Input_month_table_high(i As Integer, main_id As String) As String
        '確実に六回のみ呼び出してください
        Dim sqlString As String
        Dim ChildName = New ComboBox() {
                ChildName1,
                ChildName2,
                ChildName3,
                ChildName4,
                ChildName5,
                ChildName6
            }
        Dim ChildAge = New NumericUpDown() {
                ChildAge1,
                ChildAge2,
                ChildAge3,
                ChildAge4,
                ChildAge5,
                ChildAge6
            }
        Dim ChildAim = New RichTextBox() {
                ChildAim1,
                ChildAim2,
                ChildAim3,
                ChildAim4,
                ChildAim5,
                ChildAim6
            }
        Dim NurseryTeachers = New RichTextBox() {
                NurseryTeachers1,
                NurseryTeachers2,
                NurseryTeachers3,
                NurseryTeachers4,
                NurseryTeachers5,
                NurseryTeachers6
            }
        Dim Contact = New RichTextBox() {
                Contact1,
                Contact2,
                Contact3,
                Contact4,
                Contact5,
                Contact6
            }
        sqlString = "INSERT INTO " _
                        & "`child_monthplan_table_2to2`" _
                    & "(" _
                        & "`month_main_2to2_id`, " _
                        & "`ChildName`, " _
                        & "`ChildAge`, " _
                        & "`ChildAim`, " _
                        & "`NurseryTeachers`, " _
                        & "`Contact`" _
                    & ")" _
                    & " VALUES(" _
                        & " " & main_id & "," _
                        & "'" & ChildName(i).Text & "'," _
                        & "'" & ChildAge(i).Text & "'," _
                        & "'" & ChildAim(i).Text & "'," _
                        & "'" & NurseryTeachers(i).Text & "'," _
                        & "'" & Contact(i).Text & "'" _
                    & ");"

        Return sqlString
    End Function

    Public Function addData() As String(,)
        '印刷用の紐づけ
        Dim arrayData(,) As String = {{StateMonth.Text, "C4"}, _
                                    {AimNursing.Text, "K4"}, _
                                   {AimEducation.Text, "K6"}, _
                                    {RichTextBox_Event.Text, "Q4"}, _
                                    {Contents.Text, "B9"}, _
                                   {ChildName1.Text, "F9"}, _
                                   {ChildName2.Text, "F11"}, _
                                   {ChildName3.Text, "F13"}, _
                                    {ChildName4.Text, "F15"}, _
                                    {ChildName5.Text, "F17"}, _
                                    {ChildName6.Text, "F19"}, _
                                    {Integer.Parse(ChildAge1.Value) & "ヵ月", "F10"}, _
                                    {Integer.Parse(ChildAge2.Value) & "ヵ月", "F12"}, _
                                   {Integer.Parse(ChildAge3.Value) & "ヵ月", "F14"}, _
                                   {Integer.Parse(ChildAge4.Value) & "ヵ月", "F16"}, _
                                   {Integer.Parse(ChildAge5.Value) & "ヵ月", "F18"}, _
                                   {Integer.Parse(ChildAge6.Value) & "ヵ月", "F20"}, _
                                   {ChildAim1.Text, "I9"}, _
                                   {ChildAim2.Text, "I11"}, _
                                   {ChildAim3.Text, "I13"}, _
                                   {ChildAim4.Text, "I15"}, _
                                   {ChildAim5.Text, "I17"}, _
                                    {ChildAim6.Text, "I19"}, _
                                   {NurseryTeachers1.Text, "N9"}, _
                                   {NurseryTeachers2.Text, "N11"}, _
                                   {NurseryTeachers3.Text, "N13"}, _
                                   {NurseryTeachers4.Text, "N15"}, _
                                   {NurseryTeachers5.Text, "N17"}, _
                                   {NurseryTeachers6.Text, "N19"}, _
                                   {Contact1.Text, "R9"}, _
                                   {Contact2.Text, "R11"}, _
                                   {Contact3.Text, "R13"}, _
                                   {Contact4.Text, "R15"}, _
                                   {Contact5.Text, "R17"}, _
                                   {Contact6.Text, "R19"}, _
                                   {HealthSafety.Text, "C21"}, _
                                   {EnvironmentalComposition.Text, "M21"}, _
                                   {NextPoint.Text, "Q23"}, _
                                   {ClassName.Text, "L2"}, _
                                   {LabelSum.Text & "人(男" & TextBoxBoysNumber.Text & "人,女" & TextBoxGirlsNumber.Text & "人)", "L3"}, _
                                   {TargetYear.Text & "年" & TargetMonth.Text & "月", "R2"}, _
                                   {LeaderName.Text, "R3"}, _
                                   {Eat.Text, "C23"}, _
                                   {EvaluationReflection.Text, "J23"}}

        Return arrayData
    End Function

    Public Function DBSave() As String
        Dim sqlString As String = Input_month_main_high()
        Dim sqlConnect As New SQLConnectClass

        If sqlConnect.DBConnect(sqlString) = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else

            sqlConnect.DBConnect("SELECT MAX(month_main_2to2_id) FROM child_monthplan_main_2to2;")

            Dim mainID As String = sqlConnect.DBResult(0)
            For i = 0 To 5
                Dim s As String = Input_month_table_high(i, mainID)
                If sqlConnect.DBConnect(s) = False Then
                    MsgBox(sqlConnect.ErrorMessage)
                End If
            Next
        End If
        Return 0
    End Function

    Private Sub PastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastToolStripMenuItem.Click
        '印刷するファイルの参照
        Dim fileName As String = "C:\test\month2age\保育指導月案（2歳用）" & _
                        ClassName.Text & TargetMonth.Text & "月.xlsm"

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

    Private Sub 閉じるToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 閉じるToolStripMenuItem.Click
        closecheck()
    End Sub

    Public Sub closecheck()
        Dim fileName As String = "C:\test\month2age\保育指導月案（2歳用）" & _
              ClassName.Text & TargetMonth.Text & "月.xlsm"
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

    Private Sub MonthHigh_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub BunifuVTrackbar2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BnfuImgBtnClose.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

    End Sub
End Class