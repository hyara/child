Imports Microsoft.Office.Interop.Excel


Public Class Month2Age
    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox
    Dim sqlConnect As SQLConnectClass

    Public Sub SetID(s As SQLConnectClass)
        sqlConnect = s

        Me.Refresh()

        ReflectClassName()
        ReflectTeacherName()
        ReflectChildName()
    End Sub
    Private Sub ReflectClassName()
        Dim count As String
        'クラス名を反映
        If sqlConnect.DBConnect("SELECT COUNT(main_id) FROM class") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If

        count = sqlConnect.DBResult(0, 0)

        Dim j As Integer
        If sqlConnect.DBConnect("SELECT ClassName FROM class") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If
        For j = 0 To Integer.Parse(count) - 1 Step 1
            ClassName.Items.Add(sqlConnect.DBResult(j, 0))
        Next
    End Sub
    Private Sub ReflectTeacherName()
        Dim count As String
        '教員名を反映
        If sqlConnect.DBConnect("SELECT COUNT(`worker_main_id`) FROM worker") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If
        count = sqlConnect.DBResult(0, 0)

        If sqlConnect.DBConnect("SELECT worker_name FROM worker") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If
        For j = 0 To Integer.Parse(count) - 1 Step 1
            LeaderName.Items.Add(sqlConnect.DBResult(j, 0))
        Next
    End Sub
    Private Sub ReflectChildName()
        Dim count As String
        '児童名を反映
        If sqlConnect.DBConnect("SELECT COUNT(`children_main_id`) FROM children") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If
        count = sqlConnect.DBResult(0, 0)

        If sqlConnect.DBConnect("SELECT children_name FROM children") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If
        For j = 0 To Integer.Parse(count) - 1 Step 1
            ChildName1.Items.Add(sqlConnect.DBResult(j, 0))
            ChildName2.Items.Add(sqlConnect.DBResult(j, 0))
            ChildName3.Items.Add(sqlConnect.DBResult(j, 0))
            ChildName4.Items.Add(sqlConnect.DBResult(j, 0))
            ChildName5.Items.Add(sqlConnect.DBResult(j, 0))
            ChildName6.Items.Add(sqlConnect.DBResult(j, 0))
        Next
    End Sub

    ''' <summary>
    ''' 月案をDBから反映させる
    ''' </summary>
    ''' <param name="id">メイン主キーの値</param>
    ''' <remarks></remarks>
    Public Sub MonthDBDraw(id As String, s As SQLConnectClass)
        sqlConnect = s
        Dim pF As New ProgressStatesForm
        pF.Show() : pF.ProgressStatesMaxSet(8)
        pF.ProgressStatesLabelUpdate("メインデータ反映準備中...")
        If sqlConnect.DBConnect("SELECT * FROM child_monthplan_main_2to2 WHERE month_main_2to2_id = '" & id & "'") = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else
            pF.ProgressStatesLabelUpdate("メインデータ反映中")
            '表に反映させる
            Draw_main(sqlConnect.DBResult().Tables.Item(0))


            pF.ProgressStatesLabelUpdate("サブデータ反映準備中...")
            '表への反映確認
            Dim tableNum As String = MainDBReflectCheck(id)

            If tableNum = 5 Then
                pF.ProgressStatesLabelUpdate("サブデータ[ " & tableNum + 1 & " ]準備中")
                '表への反映
                TableDBReflect(id)
                Draw_table(sqlConnect.DBResult().Tables.Item(0))
            End If
        End If
        pF.ProgressStatesEnd()
        MsgBox("反映完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    Private Function MainDBReflectCheck(id As String) As String
        Dim sqlString As String = "SELECT COUNT(*) " _
        & "FROM `child_monthplan_table_2to2` " _
        & "WHERE " & id & " = month_main_2to2_id;"
        sqlConnect.DBConnect(sqlString)
        Return sqlConnect.DBResult(0)
    End Function
    Private Sub TableDBReflect(id As String)
        Dim sqlString As String
        sqlString = "SELECT * " _
                    & "FROM `child_monthplan_table_2to2` " _
                    & "WHERE " & id & " = month_main_2to2_id;"
        sqlConnect.DBConnect(sqlString)
    End Sub

    Private Sub Draw_table(dt As System.Data.DataTable)
        '確実に六回のみ呼び出してください
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
        For i = 0 To 5
            ChildName(i).Text = dt.Rows(i).Item("ChildName").ToString
            ChildAge(i).Text = dt.Rows(i).Item("ChildAge").ToString
            ChildAim(i).Text = dt.Rows(i).Item("ChildAim").ToString
            NurseryTeachers(i).Text = dt.Rows(i).Item("NurseryTeachers").ToString
            Contact(i).Text = dt.Rows(i).Item("Contact").ToString
        Next
    End Sub

    Private Sub Draw_main(dt As System.Data.DataTable)
        ClassName.Text = dt.Rows(0).Item("ClassName").ToString
        TextBoxBoysNumber.Text = dt.Rows(0).Item("BoysNumber").ToString
        TextBoxGirlsNumber.Text = dt.Rows(0).Item("GirlsNumber").ToString
        TargetYear.Text = dt.Rows(0).Item("TargetYear").ToString
        TargetMonth.Text = dt.Rows(0).Item("TargetMonth").ToString
        LeaderName.Text = dt.Rows(0).Item("LeaderName").ToString
        StateMonth.Text = dt.Rows(0).Item("StateMonth").ToString
        AimNursing.Text = dt.Rows(0).Item("AimNursing").ToString
        AimEducation.Text = dt.Rows(0).Item("AimEducation").ToString
        RichTextBox_Event.Text = dt.Rows(0).Item("Event").ToString
        Contents.Text = dt.Rows(0).Item("Contents").ToString
        HealthSafety.Text = dt.Rows(0).Item("HealthSafety").ToString
        EnvironmentalComposition.Text = dt.Rows(0).Item("EnvironmentalComposition").ToString
        Eat.Text = dt.Rows(0).Item("Eat").ToString
        EvaluationReflection.Text = dt.Rows(0).Item("EvaluationReflection").ToString
        NextPoint.Text = dt.Rows(0).Item("NextPoint").ToString
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
        Dim tBox As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)
        If tBox.Text = "0" Then
            tBox.Clear()
        End If
    End Sub
    Private Sub AutoText_Leave(sender As Object, e As EventArgs)
        Dim tBox As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)
        If tBox.Text = "" Then
            tBox.Text = "0"
        End If
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs)


        Dim sqlString As String = Input_month_main_2()
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
    Private Function Input_month_main_2() As String
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
        Dim AppDirPath As String = My.Application.Info.DirectoryPath
        Dim fileName As String = AppDirPath & "\month2age\保育指導月案（2歳用）" & _
              ClassName.Text & TargetMonth.Text & "月.xlsm"
        If System.IO.File.Exists(fileName.ToString) Then
            Dim xlApp As New Application()
            If xlApp IsNot Nothing Then
                xlApp.Visible = False
                xlApp.Workbooks.Open(fileName)
                CType(xlApp.ActiveWorkbook.Sheets(1), Worksheet).Select()
                Dim arrayData As String(,)
                Dim aRange As Range

                arrayData = addData()
                Dim j = 0, errflg = 0, nulltype = ""



                '入力されているものと差異があるかどうか確認する
                For i = 0 To 24

                    aRange = xlApp.Range(arrayData(i, 1))
                    If aRange.Value2 Is Nothing = True Then
                        If nulltype <> arrayData(j, 0) Then
                            errflg = 1
                        End If
                    ElseIf aRange.Text <> arrayData(j, 0) Then
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
        Dim AppDirPath As String = My.Application.Info.DirectoryPath
        Dim fileName As String
        fileName = "保育指導月案（2歳用）" & _
                       ClassName.Text & LeaderName.Text & "月.xlsm"
        'Dim result As DialogResult = MessageBox.Show(fileName.ToString & "を上書きしますか？", _
        '                                       "質問", _
        '                                       MessageBoxButtons.YesNo, _
        '                                       MessageBoxIcon.Exclamation, _
        '                                       MessageBoxDefaultButton.Button2)

        If System.IO.File.Exists(AppDirPath & "\month2age\" & fileName.ToString) = False Then
            System.IO.File.Copy(AppDirPath & "\template\2agetempl.xlsm", AppDirPath & "\month2age\" & fileName.ToString)
        End If
        Dim xlApp As New Application()
        If xlApp IsNot Nothing Then
            xlApp.Visible = True
            xlApp.Workbooks.Open(AppDirPath & "\month2age\" & fileName)
            CType(xlApp.ActiveWorkbook.Sheets(1), Worksheet).Select()
            Dim arrayData As String(,)
            Dim aRange As Range

            arrayData = addData()
            Dim j = 0
            '入力されているものをexcelへ置き換える
            For i = 0 To 43

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
        ' MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Dim AppDirPath As String = My.Application.Info.DirectoryPath
        Dim fileName As String = AppDirPath & "\template\2agetempl.xlsm"

        Dim xlApp As New Application()
        If xlApp IsNot Nothing Then
            xlApp.Visible = True
            xlApp.Workbooks.Open(fileName)
            CType(xlApp.ActiveWorkbook.Sheets(1), Worksheet).Select()
            Dim arrayData As String(,)
            Dim aRange As Range

            arrayData = addData()
            Dim j = 0
            '入力されているものをexcelへ置き換える
            For i = 0 To 43

                aRange = xlApp.Range(arrayData(i, 1))
                If aRange IsNot Nothing Then
                    Console.WriteLine(aRange.Value2)
                    aRange.Value2 = arrayData(j, 0)
                    Console.WriteLine(aRange.Value2)
                End If
                j = j + 1
            Next
            xlApp.ActiveWorkbook.Save()
            xlApp.Worksheets.PrintPreview(fileName)
            xlApp.Quit()
            MsgBox("test")
        Else
            MsgBox("ereer")
        End If

    End Sub

    Public Function addData() As String(,)
        Dim arrayData(,) = {{StateMonth.Text, "C4"}, _
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
                            {ChildAge1.Value & "ヵ月", "F10"}, _
                            {ChildAge2.Value & "ヵ月", "F12"}, _
                            {ChildAge3.Value & "ヵ月", "F14"}, _
                            {ChildAge4.Value & "ヵ月", "F16"}, _
                            {ChildAge5.Value & "ヵ月", "F18"}, _
                            {ChildAge6.Value & "ヵ月", "F20"}, _
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

    Private Sub BnfImgBtn_Click(sender As Object, e As EventArgs) Handles BnfuImgBtnClose.Click
        closecheck()
    End Sub

End Class

