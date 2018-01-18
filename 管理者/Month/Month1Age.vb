Imports Microsoft.Office.Interop.Excel

Public Class Month1Age
    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox
    Dim ht_eventbox As Hashtable = New Hashtable
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
            ComboBox_ClassName.Items.Add(sqlConnect.DBResult(j, 0))
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
            ComboBoxLeaderName.Items.Add(sqlConnect.DBResult(j, 0))
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
            ComboBoxChildName1.Items.Add(sqlConnect.DBResult(j, 0))
            ComboBoxChildName2.Items.Add(sqlConnect.DBResult(j, 0))

            ComboBoxChildName3.Items.Add(sqlConnect.DBResult(j, 0))
            ComboBoxChildName4.Items.Add(sqlConnect.DBResult(j, 0))
            ComboBoxChildName5.Items.Add(sqlConnect.DBResult(j, 0))
            ComboBoxChildName6.Items.Add(sqlConnect.DBResult(j, 0))
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
        If sqlConnect.DBConnect("SELECT * FROM child_monthplan_main_0to1 WHERE month_main_0to1_id = '" & id & "'") = False Then
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
        & "FROM `child_monthplan_table_0to1` " _
        & "WHERE " & id & " = month_main_0to1_id;"
        sqlConnect.DBConnect(sqlString)
        Return sqlConnect.DBResult(0)
    End Function
    Private Sub TableDBReflect(id As String)
        Dim sqlString As String
        sqlString = "SELECT * " _
                    & "FROM `child_monthplan_table_0to1` " _
                    & "WHERE " & id & " = month_main_0to1_id;"
        sqlConnect.DBConnect(sqlString)
    End Sub

    Private Sub Draw_table(dt As System.Data.DataTable)
        Dim 児童名 = New ComboBox() {
               ComboBoxChildName1, ComboBoxChildName2, ComboBoxChildName3, _
               ComboBoxChildName4, ComboBoxChildName5, ComboBoxChildName6 _
            }
        Dim 児童年齢 = New NumericUpDown() {
                NumericUpDownChildAge1, NumericUpDownChildAge2, _
                NumericUpDownChildAge3, NumericUpDownChildAge4, _
                NumericUpDownChildAge5, NumericUpDownChildAge6
            }
        Dim 予想子ども = New RichTextBox() {
                RichTextBoxExpectesChild1, RichTextBoxChildActivities2, _
                RichTextBoxChildActivities3, RichTextBoxChildActivities4, _
                RichTextBoxChildActivities5, RichTextBoxChildActivities6
            }
        Dim 保育士 = New RichTextBox() {
                RichTextBoxNurseryTeachers1, RichTextBoxNurseryTeachers2, _
                RichTextBoxNurseryTeachers3, RichTextBoxNurseryTeachers4, _
                RichTextBoxNurseryTeachers5, RichTextBoxNurseryTeachers6
            }
        Dim 連絡 = New RichTextBox() {
            RichTextBox6, RichTextBox5, RichTextBox4, _
            RichTextBox3, RichTextBox2, RichTextBox1 _
        }
        For i = 0 To 5
            児童名(i).Text = dt.Rows(i).Item("ChildName").ToString
            児童年齢(i).Text = dt.Rows(i).Item("ChildAge").ToString
            予想子ども(i).Text = dt.Rows(i).Item("ChildActivities").ToString
            保育士(i).Text = dt.Rows(i).Item("NurseryTeachers").ToString
            連絡(i).Text = dt.Rows(i).Item("Contact").ToString
        Next
    End Sub

    Private Sub Draw_main(dt As System.Data.DataTable)
        ComboBox_ClassName.Text = dt.Rows(0).Item("ClassName").ToString
        TextBoxBoysNumber.Text = dt.Rows(0).Item("BoysNumber").ToString
        TextBoxGirlsNumber.Text = dt.Rows(0).Item("GirlsNumber").ToString
        ComboBoxTargetYear.Text = dt.Rows(0).Item("TargetYear").ToString
        ComboBoxTargetMonth.Text = dt.Rows(0).Item("TargetMonth").ToString
        ComboBoxLeaderName.Text = dt.Rows(0).Item("LeaderName").ToString
        RichTextBoxStateMonth.Text = dt.Rows(0).Item("StateMonth").ToString
        RichTextBoxAimNursing.Text = dt.Rows(0).Item("AimNursing").ToString
        RichTextBoxAimEducation.Text = dt.Rows(0).Item("AimEducation").ToString
        RichTextBoxEvent.Text = dt.Rows(0).Item("Event").ToString
        RichTextBoxContents.Text = dt.Rows(0).Item("Contents").ToString
        RichTextBoxEnvironmentalComposition.Text = dt.Rows(0).Item("EnvironmentalComposition").ToString
        RichTextBoxHealthSafety.Text = dt.Rows(0).Item("HealthSafety").ToString
        RichTextBoxNextPoint.Text = dt.Rows(0).Item("NextPoint").ToString
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

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click


        Dim prgsForm As New ProgressStatesForm
        prgsForm.Show()
        prgsForm.ProgressStatesMaxSet(100)
        prgsForm.ProgressStatesLabelUpdate(1)
        prgsForm.ProcessContentsSet("SQL接続確認中...")
        hashTableAdd()

        Dim sqlString As String = Input_month_main_low()
        Dim sqlConnect As New SQLConnectClass

        prgsForm.ProgressStatesLabelUpdate(20)
        prgsForm.ProcessContentsSet("SQL接続確認終了")

        If sqlConnect.DBConnect(sqlString) = False Then
            MsgBox(sqlConnect.ErrorMessage)
        Else
            sqlConnect.DBConnect("SELECT MAX(month_main_0to1_id) FROM child_monthplan_main_0to1;")
            prgsForm.ProgressStatesLabelUpdate(10)
            prgsForm.ProcessContentsSet("メインデータ保存終了")

            Dim mainID As String = sqlConnect.DBResult(0)

            For i = 0 To 5
                Dim s As String = Input_month_table_low(i, mainID)
                sqlConnect.DBConnect(s)
                prgsForm.ProgressStatesLabelUpdate(10)
                prgsForm.ProcessContentsSet("サブデータ[ " & (i + 1) & " ]保存中")
            Next
        End If

        Dim msg As MsgBoxResult = MsgBox("今回の内容を次の月案に反映させますか？", MsgBoxStyle.YesNoCancel, "反映確認")

        If msg = vbYes Then
            If sqlConnect.DBConnect(Input_out_nextmonth()) = False Then
                MsgBox(sqlConnect.ErrorMessage)
            End If
        End If
        prgsForm.ProgressStatesLabelUpdate(100)
        prgsForm.ProcessContentsSet("終了")
        prgsForm.ProgressStatesEnd()
        MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    Private Sub hashTableAdd()
        ht_eventbox.Clear()
        ht_eventbox.Add("ClassName", ComboBox_ClassName.Text)
        ht_eventbox.Add("BoysNumber", TextBoxBoysNumber.Text)
        ht_eventbox.Add("GirlsNumber", TextBoxGirlsNumber.Text)
        ht_eventbox.Add("TargetYear", ComboBoxTargetYear.Text)
        ht_eventbox.Add("TargetMonth", ComboBoxTargetMonth.Text)
        ht_eventbox.Add("LeaderName", ComboBoxLeaderName.Text)
        ht_eventbox.Add("StateMonth", RichTextBoxStateMonth.Text)
        ht_eventbox.Add("AimNursing", RichTextBoxAimNursing.Text)
        ht_eventbox.Add("AimEducation", RichTextBoxAimEducation.Text)
        ht_eventbox.Add("Event", RichTextBoxEvent.Text)
        ht_eventbox.Add("Contents", RichTextBoxContents.Text)
        ht_eventbox.Add("HealthSafety", RichTextBoxHealthSafety.Text)
        ht_eventbox.Add("EnvironmentalComposition", RichTextBoxEnvironmentalComposition.Text)
        ht_eventbox.Add("NextPoint", RichTextBoxNextPoint.Text)
    End Sub


    '読解性上昇のために作成した関数
    Private Function Input_month_main_low() As String
        Dim sqlString As String

        sqlString = "INSERT INTO " _
                    & "`child_monthplan_main_0to1`" _
                        & "(" _
                            & "`ClassName`, `BoysNumber`, `GirlsNumber`," _
                            & "`CreatedDate`, `TargetYear`, `TargetMonth`," _
                            & "`LeaderName`, `StateMonth`," _
                            & "`AimNursing`, `AimEducation`," _
                            & "`Event`, `Contents`, `HealthSafety`," _
                            & "`EnvironmentalComposition`, `NextPoint`, `UpdateDate`" _
                        & ")" _
                    & "VALUES (" _
                        & "'" & CStr(ht_eventbox("ClassName")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("BoysNumber")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("GirlsNumber")) & "'" _
                        & ", NOW()" _
                        & ", " & "'" & CStr(ht_eventbox("TargetYear")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("TargetMonth")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("LeaderName")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("StateMonth")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("AimNursing")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("AimEducation")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("Event")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("Contents")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("HealthSafety")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("EnvironmentalComposition")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("NextPoint")) & "'" _
                        & ", NOW()" _
                    & ");"
        Return sqlString
    End Function

    Private Function Input_out_nextmonth() As String

        'クラス名・人数・作成日・対象年月
        '指導者名・更新日をつけつつ、
        '"内容"を前月の様子にいれる

        Dim TargetYear As Integer = Integer.Parse(CStr(ht_eventbox("TargetYear")))
        Dim TargetMonth As Integer = Integer.Parse(CStr(ht_eventbox("TargetMonth")))
        Dim dt As DateTime = DateTime.Parse(TargetYear & "/" & TargetMonth & "/1")

        dt = dt.AddMonths(1)

        TargetYear = dt.Year
        TargetMonth = dt.Month

        Dim sqlString As String = "INSERT INTO " _
                    & "`child_monthplan_main_0to1`" _
                        & "(" _
                            & "`ClassName`, `BoysNumber`, `GirlsNumber`," _
                            & "`CreatedDate`, `TargetYear`, `TargetMonth`," _
                            & "`LeaderName`, `StateMonth`, `UpdateDate`" _
                        & ")" _
                    & "VALUES (" _
                        & "'" & CStr(ht_eventbox("ClassName")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("BoysNumber")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("GirlsNumber")) & "'" _
                        & ", NOW()" _
                        & ", " & "'" & TargetYear.ToString & "'" _
                        & ", " & "'" & TargetMonth.ToString & "'" _
                        & ", " & "'" & CStr(ht_eventbox("LeaderName")) & "'" _
                        & ", " & "'" & CStr(ht_eventbox("Contents")) & "'" _
                        & ", NOW()" _
                    & ");"

        Return sqlString
    End Function


    Private Function Input_month_table_low(i As Integer, main_id As String) As String
        Dim sqlString As String
        Dim 児童名 = New ComboBox() {
               ComboBoxChildName1, ComboBoxChildName2, ComboBoxChildName3, _
               ComboBoxChildName4, ComboBoxChildName5, ComboBoxChildName6 _
            }
        Dim 児童年齢 = New NumericUpDown() {
                NumericUpDownChildAge1, NumericUpDownChildAge2, _
                NumericUpDownChildAge3, NumericUpDownChildAge4, _
                NumericUpDownChildAge5, NumericUpDownChildAge6
            }
        Dim 予想子ども = New RichTextBox() {
                RichTextBoxExpectesChild1, RichTextBoxChildActivities2, _
                RichTextBoxChildActivities3, RichTextBoxChildActivities4, _
                RichTextBoxChildActivities5, RichTextBoxChildActivities6
            }
        Dim 保育士 = New RichTextBox() {
                RichTextBoxNurseryTeachers1, RichTextBoxNurseryTeachers2, _
                RichTextBoxNurseryTeachers3, RichTextBoxNurseryTeachers4, _
                RichTextBoxNurseryTeachers5, RichTextBoxNurseryTeachers6
            }
        Dim 連絡 = New RichTextBox() {
            RichTextBox6, RichTextBox5, RichTextBox4, _
            RichTextBox3, RichTextBox2, RichTextBox1 _
        }
        sqlString = "INSERT INTO " _
                    & "`child_monthplan_table_0to1`" _
                    & "(" _
                        & "`month_main_0to1_id`," _
                        & "`ChildName`," _
                        & "`ChildAge`," _
                        & "`ChildActivities`," _
                        & "`NurseryTeachers`," _
                        & "`Contact`" _
                    & ")" _
                    & " VALUES(" _
                        & " " & main_id & "," _
                        & "'" & 児童名(i).Text & "'," _
                        & "'" & 児童年齢(i).Text & "'," _
                        & "'" & 予想子ども(i).Text & "'," _
                        & "'" & 保育士(i).Text & "'," _
                        & "'" & 連絡(i).Text & "'" _
                    & ");"

        Return sqlString
    End Function

    Public Function addData() As String(,)
        Dim arrayData(,) = {{ComboBox_ClassName.Text, "L2"}, _
                           {ComboBoxTargetYear.Text & "年" & ComboBoxTargetMonth.Text & "月", "R2"}, _
                           {LabelSum.Text & "人(男" & TextBoxBoysNumber.Text & "人,女" & TextBoxGirlsNumber.Text & "人)", "L3"}, _
                           {ComboBoxLeaderName.Text, "R3"}, _
                           {RichTextBoxStateMonth.Text, "C4"}, _
                           {RichTextBoxAimNursing.Text, "K4"}, _
                           {RichTextBoxAimEducation.Text, "K6"}, _
                           {RichTextBoxEvent.Text, "Q4"}, _
                            {RichTextBoxContents.Text, "B9"}, _
                           {ComboBoxChildName1.Text, "F9"}, _
                           {ComboBoxChildName2.Text, "F11"}, _
                           {ComboBoxChildName3.Text, "F13"}, _
                           {ComboBoxChildName4.Text, "F15"}, _
                           {ComboBoxChildName5.Text, "F17"}, _
                           {ComboBoxChildName6.Text, "F19"}, _
                           {NumericUpDownChildAge1.Text & "ヶ月", "F10"}, _
                           {NumericUpDownChildAge2.Text & "ヶ月", "F12"}, _
                           {NumericUpDownChildAge3.Text & "ヶ月", "F14"}, _
                           {NumericUpDownChildAge4.Text & "ヶ月", "F16"}, _
                           {NumericUpDownChildAge5.Text & "ヶ月", "F18"}, _
                           {NumericUpDownChildAge6.Text & "ヶ月", "F20"}, _
                           {RichTextBoxExpectesChild1.Text, "I9"}, _
                           {RichTextBoxChildActivities2.Text, "I11"}, _
                           {RichTextBoxChildActivities3.Text, "I13"}, _
                           {RichTextBoxChildActivities4.Text, "I15"}, _
                           {RichTextBoxChildActivities5.Text, "I17"}, _
                           {RichTextBoxChildActivities6.Text, "I19"}, _
                           {RichTextBoxNurseryTeachers1.Text, "N9"}, _
                           {RichTextBoxNurseryTeachers2.Text, "N11"}, _
                           {RichTextBoxNurseryTeachers3.Text, "N13"}, _
                           {RichTextBoxNurseryTeachers4.Text, "N15"}, _
                           {RichTextBoxNurseryTeachers5.Text, "N17"}, _
                           {RichTextBoxNurseryTeachers6.Text, "N19"}, _
                           {RichTextBox6.Text, "R9"}, _
                           {RichTextBox5.Text, "R11"}, _
                           {RichTextBox4.Text, "R13"}, _
                           {RichTextBox3.Text, "R15"}, _
                           {RichTextBox2.Text, "R17"}, _
                           {RichTextBox1.Text, "R19"}, _
                           {RichTextBoxHealthSafety.Text, "C21"}, _
                           {RichTextBoxEnvironmentalComposition.Text, "K21"}, _
                           {RichTextBoxNextPoint.Text, "P21"}, _
                           {DateTimePickerCreatedDate.Text, "Q1"}}
        Return arrayData
    End Function

    Private Sub MonthLow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BnfImgBtnClose.Click
        Me.Close()
    End Sub


    Private Sub PastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastToolStripMenuItem.Click

        Dim AppDirPath As String = My.Application.Info.DirectoryPath
        Dim fileName As String = AppDirPath & "\template\01agetempl.xlsm"

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
            For i = 0 To 42

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
End Class

