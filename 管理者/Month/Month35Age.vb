Imports Microsoft.Office.Interop.Excel


Public Class Month35Age
    Private TextBoxChildrenNum() As System.Windows.Forms.TextBox
    Dim sqlConnect As SQLConnectClass

#Region "  初期Load関連  "
#Region "  SetID関連  "
    Public Sub SetID(s As SQLConnectClass)
        'これが最初にないとすごく重く見える
        Me.Refresh()

        sqlConnect = s

        ReflectClassName()
        ReflectTeacherName()
    End Sub

    Private Sub ReflectClassName()

        'クラス名を反映
        If sqlConnect.DBConnect("SELECT COUNT(main_id) FROM class") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If

        Dim count As String = sqlConnect.DBResult(0, 0)

        Dim j As Integer
        If sqlConnect.DBConnect("SELECT ClassName FROM class") = False Then
            MsgBox(sqlConnect.ErrorMessage())
        End If
        For j = 0 To Integer.Parse(count) - 1 Step 1
            ComboBoxClassName.Items.Add(sqlConnect.DBResult(j, 0))
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
#End Region

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
        If sqlConnect.DBConnect("SELECT * FROM child_monthplan_main_3to5 WHERE month_main_3to5_id = '" & id & "'") = False Then
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
        & "FROM `child_monthplan_table_3to5` " _
        & "WHERE " & id & " = month_main_3to5_id;"
        sqlConnect.DBConnect(sqlString)
        Return sqlConnect.DBResult(0)
    End Function
    Private Sub TableDBReflect(id As String)
        Dim sqlString As String
        sqlString = "SELECT * " _
                    & "FROM `child_monthplan_table_3to5` " _
                    & "WHERE " & id & " = month_main_3to5_id;"
        sqlConnect.DBConnect(sqlString)
    End Sub

    Private Sub Draw_table(dt As System.Data.DataTable)
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
        For i As Integer = 0 To 2
            Contents(i).Text = dt.Rows(i).Item("Contents").ToString
            EnvironmentalComposition(i).Text = dt.Rows(i).Item("EnvironmentalComposition").ToString
            ExpectedChild(i).Text = dt.Rows(i).Item("ExpectedChild").ToString
            ChildcareAssistance(i).Text = dt.Rows(i).Item("ChildcareAssistance").ToString
        Next
    End Sub

    Private Sub Draw_main(dt As System.Data.DataTable)
        ComboBoxClassName.Text = dt.Rows(0).Item("ClassName").ToString
        TextBoxBoysNumber.Text = dt.Rows(0).Item("BoysNumber").ToString
        TextBoxGirlsNumber.Text = dt.Rows(0).Item("GirlsNumber").ToString
        ComboBoxTargetYear.Text = dt.Rows(0).Item("TargetYear").ToString
        ComboBoxTargetMonth.Text = dt.Rows(0).Item("TargetMonth").ToString
        ComboBoxLeaderName.Text = dt.Rows(0).Item("LeaderName").ToString

        RichTextBoxStateMonth.Text = dt.Rows(0).Item("StateMonth").ToString
        RichTextBoxAim.Text = dt.Rows(0).Item("Aim").ToString
        RichTextBoxEvaluationTeacher.Text = dt.Rows(0).Item("EvaluationTeacher").ToString

        RichTextBoxCollaborationRegion.Text = dt.Rows(0).Item("CollaborationRegion").ToString
        RichTextBoxEvent.Text = dt.Rows(0).Item("Event").ToString
        RichTextBoxCollaborationStaff.Text = dt.Rows(0).Item("CollaborationStaff").ToString
        RichTextBoxCooperationHome.Text = dt.Rows(0).Item("CooperationHome").ToString
        RichTextBoxSpecificChild.Text = dt.Rows(0).Item("SpecificChild").ToString
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

#End Region

#Region "  DBへの保存関連  "
    Private Sub ToolStripMenuItemDBSave_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemDBSave.Click
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

#End Region

    Private Sub MonthHigh_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Public Sub closecheck()
        Dim fileName As String = My.Application.Info.DirectoryPath & "\month35age\保育指導月案（3～5歳用）" & _
              ComboBoxClassName.Text & ComboBoxTargetMonth.Text & "月.xlsm"
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
                    Dim result As DialogResult = MessageBox.Show("保存されていない変更箇所は保存されません。このページを閉じますか？",
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

    Private Sub ToolStripMenuItemFileSave_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemFileSave.Click
        Dim fileName As String
        fileName = "保育指導月案（3～5歳用）" & _
                       ComboBoxClassName.Text & ComboBoxTargetMonth.Text & "月.xlsm"
        'Dim result As DialogResult = MessageBox.Show(fileName.ToString & "を上書きしますか？", _
        '                                       "質問", _
        '                                       MessageBoxButtons.YesNo, _
        '                                       MessageBoxIcon.Exclamation, _
        '                                       MessageBoxDefaultButton.Button2)
        Dim AppDirPath As String = My.Application.Info.DirectoryPath

        If System.IO.File.Exists(AppDirPath & "\month35age\" & fileName.ToString) = False Then
            System.IO.File.Copy(AppDirPath & "\template\35agetempl.xlsm", AppDirPath & "\month35age\" & fileName.ToString)
        End If
        Dim xlApp As New Application()
        If xlApp IsNot Nothing Then
            xlApp.Visible = False
            xlApp.Workbooks.Open(AppDirPath & "\month35age\" & fileName)
            CType(xlApp.ActiveWorkbook.Sheets(1), Worksheet).Select()
            Dim arrayData As String(,)
            Dim aRange As Range

            arrayData = addData()
            Dim j = 0
            '入力されているものをexcelへ置き換える
            For i = 0 To 24

                aRange = xlApp.Range(arrayData(i, 1))
                If aRange IsNot Nothing Then
                    Console.WriteLine(aRange.Value2)
                    aRange.Value2 = arrayData(j, 0)
                    Console.WriteLine(aRange.Value2)
                End If
                j = j + 1
            Next
            xlApp.ActiveWorkbook.Save()
            xlApp.ActiveWorkbook.Close()
            xlApp.Quit()
            MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
        End If
        ' DBSave()
        'MsgBox("保存完了!!", MsgBoxStyle.OkOnly, "確認画面")
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Dim AppDirPath As String = My.Application.Info.DirectoryPath
        Dim fileName As String = AppDirPath & "\template\35agetempl.xlsm"

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
            For i = 0 To 24

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

    Private Sub BnfImgBtnClose_Click(sender As Object, e As EventArgs) Handles BnfImgBtnClose.Click
        closecheck()
    End Sub



End Class