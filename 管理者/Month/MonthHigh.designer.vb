<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthHigh
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthHigh))
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上書き保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.名前を付けて保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.閉じるToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DateTimePickerCreatedDate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxClassName = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLeaderName = New System.Windows.Forms.ComboBox()
        Me.RichTextBoxStateMonth = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxAim = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxNursingContents = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxEducationContents = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxNursingConstitution = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxEducationConstitution = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxNursingExpectedChild = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxEducationExpectedChild = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxNursingAssistance = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxEducationAssistance = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxFoodContents = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxFoodConstitution = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxFoodExpectedChild = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxFoodAssistance = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxEvent = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxCollaborationStaff = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxCooperationHome = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxSpecificChild = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxCollaborationRegion = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxEvaluationTeacher = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxTargetYear = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTargetMonth = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBoysNumber = New System.Windows.Forms.TextBox()
        Me.TextBoxGirlsNumber = New System.Windows.Forms.TextBox()
        Me.LabelSum = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackgroundImage = CType(resources.GetObject("header.BackgroundImage"), System.Drawing.Image)
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.header.Controls.Add(Me.BunifuImageButton4)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.header.Controls.Add(Me.MenuStrip2)
        Me.header.Controls.Add(Me.BunifuImageButton1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.header.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.header.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.header.Name = "header"
        Me.header.Quality = 10
        Me.header.Size = New System.Drawing.Size(831, 50)
        Me.header.TabIndex = 2
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(594, 5)
        Me.BunifuImageButton4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 13
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(780, 5)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 11
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(93, 26)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.上書き保存ToolStripMenuItem, Me.名前を付けて保存ToolStripMenuItem, Me.ToolStripSeparator1, Me.閉じるToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '上書き保存ToolStripMenuItem
        '
        Me.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem"
        Me.上書き保存ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.上書き保存ToolStripMenuItem.Text = "上書き保存(&S)"
        '
        '名前を付けて保存ToolStripMenuItem
        '
        Me.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem"
        Me.名前を付けて保存ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存(&A)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        '閉じるToolStripMenuItem
        '
        Me.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem"
        Me.閉じるToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.閉じるToolStripMenuItem.Text = "閉じる(&X)"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(688, 5)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 10
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'DateTimePickerCreatedDate
        '
        Me.DateTimePickerCreatedDate.Location = New System.Drawing.Point(677, -3)
        Me.DateTimePickerCreatedDate.MinDate = New Date(1754, 11, 13, 0, 0, 0, 0)
        Me.DateTimePickerCreatedDate.Name = "DateTimePickerCreatedDate"
        Me.DateTimePickerCreatedDate.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePickerCreatedDate.TabIndex = 76
        '
        'ComboBoxClassName
        '
        Me.ComboBoxClassName.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBoxClassName.FormattingEnabled = True
        Me.ComboBoxClassName.Location = New System.Drawing.Point(403, 19)
        Me.ComboBoxClassName.Name = "ComboBoxClassName"
        Me.ComboBoxClassName.Size = New System.Drawing.Size(180, 23)
        Me.ComboBoxClassName.TabIndex = 0
        Me.ComboBoxClassName.Text = "クラス名"
        '
        'ComboBoxLeaderName
        '
        Me.ComboBoxLeaderName.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBoxLeaderName.FormattingEnabled = True
        Me.ComboBoxLeaderName.Location = New System.Drawing.Point(647, 43)
        Me.ComboBoxLeaderName.Name = "ComboBoxLeaderName"
        Me.ComboBoxLeaderName.Size = New System.Drawing.Size(158, 23)
        Me.ComboBoxLeaderName.TabIndex = 3
        Me.ComboBoxLeaderName.Text = "指導者"
        '
        'RichTextBoxStateMonth
        '
        Me.RichTextBoxStateMonth.Location = New System.Drawing.Point(26, 84)
        Me.RichTextBoxStateMonth.Name = "RichTextBoxStateMonth"
        Me.RichTextBoxStateMonth.Size = New System.Drawing.Size(280, 47)
        Me.RichTextBoxStateMonth.TabIndex = 4
        Me.RichTextBoxStateMonth.Text = "前"
        '
        'RichTextBoxAim
        '
        Me.RichTextBoxAim.Location = New System.Drawing.Point(307, 84)
        Me.RichTextBoxAim.Name = "RichTextBoxAim"
        Me.RichTextBoxAim.Size = New System.Drawing.Size(316, 47)
        Me.RichTextBoxAim.TabIndex = 5
        Me.RichTextBoxAim.Text = "ねらい"
        '
        'RichTextBoxNursingContents
        '
        Me.RichTextBoxNursingContents.Location = New System.Drawing.Point(74, 145)
        Me.RichTextBoxNursingContents.Name = "RichTextBoxNursingContents"
        Me.RichTextBoxNursingContents.Size = New System.Drawing.Size(115, 130)
        Me.RichTextBoxNursingContents.TabIndex = 6
        Me.RichTextBoxNursingContents.Text = "養護-内容"
        '
        'RichTextBoxEducationContents
        '
        Me.RichTextBoxEducationContents.Location = New System.Drawing.Point(74, 276)
        Me.RichTextBoxEducationContents.Name = "RichTextBoxEducationContents"
        Me.RichTextBoxEducationContents.Size = New System.Drawing.Size(115, 242)
        Me.RichTextBoxEducationContents.TabIndex = 10
        Me.RichTextBoxEducationContents.Text = "教育-内容"
        '
        'RichTextBoxNursingConstitution
        '
        Me.RichTextBoxNursingConstitution.Location = New System.Drawing.Point(191, 145)
        Me.RichTextBoxNursingConstitution.Name = "RichTextBoxNursingConstitution"
        Me.RichTextBoxNursingConstitution.Size = New System.Drawing.Size(115, 130)
        Me.RichTextBoxNursingConstitution.TabIndex = 7
        Me.RichTextBoxNursingConstitution.Text = "養護-環境"
        '
        'RichTextBoxEducationConstitution
        '
        Me.RichTextBoxEducationConstitution.Location = New System.Drawing.Point(191, 276)
        Me.RichTextBoxEducationConstitution.Name = "RichTextBoxEducationConstitution"
        Me.RichTextBoxEducationConstitution.Size = New System.Drawing.Size(115, 242)
        Me.RichTextBoxEducationConstitution.TabIndex = 11
        Me.RichTextBoxEducationConstitution.Text = "教育-環境"
        '
        'RichTextBoxNursingExpectedChild
        '
        Me.RichTextBoxNursingExpectedChild.Location = New System.Drawing.Point(307, 145)
        Me.RichTextBoxNursingExpectedChild.Name = "RichTextBoxNursingExpectedChild"
        Me.RichTextBoxNursingExpectedChild.Size = New System.Drawing.Size(151, 130)
        Me.RichTextBoxNursingExpectedChild.TabIndex = 8
        Me.RichTextBoxNursingExpectedChild.Text = "養護-予想"
        '
        'RichTextBoxEducationExpectedChild
        '
        Me.RichTextBoxEducationExpectedChild.Location = New System.Drawing.Point(307, 276)
        Me.RichTextBoxEducationExpectedChild.Name = "RichTextBoxEducationExpectedChild"
        Me.RichTextBoxEducationExpectedChild.Size = New System.Drawing.Size(151, 242)
        Me.RichTextBoxEducationExpectedChild.TabIndex = 12
        Me.RichTextBoxEducationExpectedChild.Text = "教育-予想"
        '
        'RichTextBoxNursingAssistance
        '
        Me.RichTextBoxNursingAssistance.Location = New System.Drawing.Point(460, 145)
        Me.RichTextBoxNursingAssistance.Name = "RichTextBoxNursingAssistance"
        Me.RichTextBoxNursingAssistance.Size = New System.Drawing.Size(164, 130)
        Me.RichTextBoxNursingAssistance.TabIndex = 9
        Me.RichTextBoxNursingAssistance.Text = "養護-保育者"
        '
        'RichTextBoxEducationAssistance
        '
        Me.RichTextBoxEducationAssistance.Location = New System.Drawing.Point(460, 277)
        Me.RichTextBoxEducationAssistance.Name = "RichTextBoxEducationAssistance"
        Me.RichTextBoxEducationAssistance.Size = New System.Drawing.Size(164, 242)
        Me.RichTextBoxEducationAssistance.TabIndex = 13
        Me.RichTextBoxEducationAssistance.Text = "教育-保育者"
        '
        'RichTextBoxFoodContents
        '
        Me.RichTextBoxFoodContents.Location = New System.Drawing.Point(74, 519)
        Me.RichTextBoxFoodContents.Name = "RichTextBoxFoodContents"
        Me.RichTextBoxFoodContents.Size = New System.Drawing.Size(115, 49)
        Me.RichTextBoxFoodContents.TabIndex = 14
        Me.RichTextBoxFoodContents.Text = "食育-内容"
        '
        'RichTextBoxFoodConstitution
        '
        Me.RichTextBoxFoodConstitution.Location = New System.Drawing.Point(191, 519)
        Me.RichTextBoxFoodConstitution.Name = "RichTextBoxFoodConstitution"
        Me.RichTextBoxFoodConstitution.Size = New System.Drawing.Size(115, 49)
        Me.RichTextBoxFoodConstitution.TabIndex = 15
        Me.RichTextBoxFoodConstitution.Text = "食育-環境"
        '
        'RichTextBoxFoodExpectedChild
        '
        Me.RichTextBoxFoodExpectedChild.Location = New System.Drawing.Point(307, 519)
        Me.RichTextBoxFoodExpectedChild.Name = "RichTextBoxFoodExpectedChild"
        Me.RichTextBoxFoodExpectedChild.Size = New System.Drawing.Size(151, 49)
        Me.RichTextBoxFoodExpectedChild.TabIndex = 16
        Me.RichTextBoxFoodExpectedChild.Text = "食育-予想"
        '
        'RichTextBoxFoodAssistance
        '
        Me.RichTextBoxFoodAssistance.Location = New System.Drawing.Point(460, 519)
        Me.RichTextBoxFoodAssistance.Name = "RichTextBoxFoodAssistance"
        Me.RichTextBoxFoodAssistance.Size = New System.Drawing.Size(164, 49)
        Me.RichTextBoxFoodAssistance.TabIndex = 17
        Me.RichTextBoxFoodAssistance.Text = "食育-保育者"
        '
        'RichTextBoxEvent
        '
        Me.RichTextBoxEvent.Location = New System.Drawing.Point(647, 68)
        Me.RichTextBoxEvent.Name = "RichTextBoxEvent"
        Me.RichTextBoxEvent.Size = New System.Drawing.Size(158, 129)
        Me.RichTextBoxEvent.TabIndex = 18
        Me.RichTextBoxEvent.Text = "行事"
        '
        'RichTextBoxCollaborationStaff
        '
        Me.RichTextBoxCollaborationStaff.Location = New System.Drawing.Point(647, 196)
        Me.RichTextBoxCollaborationStaff.Name = "RichTextBoxCollaborationStaff"
        Me.RichTextBoxCollaborationStaff.Size = New System.Drawing.Size(158, 91)
        Me.RichTextBoxCollaborationStaff.TabIndex = 19
        Me.RichTextBoxCollaborationStaff.Text = "職員間の連携"
        '
        'RichTextBoxCooperationHome
        '
        Me.RichTextBoxCooperationHome.Location = New System.Drawing.Point(647, 288)
        Me.RichTextBoxCooperationHome.Name = "RichTextBoxCooperationHome"
        Me.RichTextBoxCooperationHome.Size = New System.Drawing.Size(158, 118)
        Me.RichTextBoxCooperationHome.TabIndex = 20
        Me.RichTextBoxCooperationHome.Text = "家庭連携"
        '
        'RichTextBoxSpecificChild
        '
        Me.RichTextBoxSpecificChild.Location = New System.Drawing.Point(647, 406)
        Me.RichTextBoxSpecificChild.Name = "RichTextBoxSpecificChild"
        Me.RichTextBoxSpecificChild.Size = New System.Drawing.Size(158, 240)
        Me.RichTextBoxSpecificChild.TabIndex = 21
        Me.RichTextBoxSpecificChild.Text = "特定児童"
        '
        'RichTextBoxCollaborationRegion
        '
        Me.RichTextBoxCollaborationRegion.Location = New System.Drawing.Point(372, 569)
        Me.RichTextBoxCollaborationRegion.Name = "RichTextBoxCollaborationRegion"
        Me.RichTextBoxCollaborationRegion.Size = New System.Drawing.Size(252, 77)
        Me.RichTextBoxCollaborationRegion.TabIndex = 23
        Me.RichTextBoxCollaborationRegion.Text = "地域との連携"
        '
        'RichTextBoxEvaluationTeacher
        '
        Me.RichTextBoxEvaluationTeacher.Location = New System.Drawing.Point(74, 569)
        Me.RichTextBoxEvaluationTeacher.Name = "RichTextBoxEvaluationTeacher"
        Me.RichTextBoxEvaluationTeacher.Size = New System.Drawing.Size(271, 77)
        Me.RichTextBoxEvaluationTeacher.TabIndex = 22
        Me.RichTextBoxEvaluationTeacher.Text = "保育士"
        '
        'ComboBoxTargetYear
        '
        Me.ComboBoxTargetYear.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        Me.ComboBoxTargetYear.FormattingEnabled = True
        Me.ComboBoxTargetYear.Location = New System.Drawing.Point(652, 20)
        Me.ComboBoxTargetYear.Name = "ComboBoxTargetYear"
        Me.ComboBoxTargetYear.Size = New System.Drawing.Size(62, 20)
        Me.ComboBoxTargetYear.TabIndex = 1
        Me.ComboBoxTargetYear.Text = "1999"
        '
        'ComboBoxTargetMonth
        '
        Me.ComboBoxTargetMonth.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        Me.ComboBoxTargetMonth.FormattingEnabled = True
        Me.ComboBoxTargetMonth.Location = New System.Drawing.Point(741, 20)
        Me.ComboBoxTargetMonth.Name = "ComboBoxTargetMonth"
        Me.ComboBoxTargetMonth.Size = New System.Drawing.Size(38, 20)
        Me.ComboBoxTargetMonth.TabIndex = 2
        Me.ComboBoxTargetMonth.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(720, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "年"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(785, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "月"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelSum)
        Me.Panel2.Controls.Add(Me.TextBoxGirlsNumber)
        Me.Panel2.Controls.Add(Me.TextBoxBoysNumber)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(403, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 23)
        Me.Panel2.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "    　人(男：　　人 , 女：　　人)"
        '
        'TextBoxBoysNumber
        '
        Me.TextBoxBoysNumber.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!)
        Me.TextBoxBoysNumber.Location = New System.Drawing.Point(65, 2)
        Me.TextBoxBoysNumber.MaxLength = 3
        Me.TextBoxBoysNumber.Name = "TextBoxBoysNumber"
        Me.TextBoxBoysNumber.Size = New System.Drawing.Size(22, 19)
        Me.TextBoxBoysNumber.TabIndex = 15
        Me.TextBoxBoysNumber.Text = "0"
        Me.TextBoxBoysNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxGirlsNumber
        '
        Me.TextBoxGirlsNumber.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxGirlsNumber.Location = New System.Drawing.Point(128, 2)
        Me.TextBoxGirlsNumber.MaxLength = 3
        Me.TextBoxGirlsNumber.Name = "TextBoxGirlsNumber"
        Me.TextBoxGirlsNumber.Size = New System.Drawing.Size(22, 19)
        Me.TextBoxGirlsNumber.TabIndex = 16
        Me.TextBoxGirlsNumber.Text = "0"
        Me.TextBoxGirlsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelSum
        '
        Me.LabelSum.AutoSize = True
        Me.LabelSum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSum.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelSum.Location = New System.Drawing.Point(7, 4)
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(0, 16)
        Me.LabelSum.TabIndex = 18
        Me.LabelSum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(40, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 39)
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 27)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "保育指導月案（2～5歳用）"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(626, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 132)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "気" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "に" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "な" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "る" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "子" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ど" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "も" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "へ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "の" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "配" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "慮"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBoxTargetMonth)
        Me.Panel1.Controls.Add(Me.ComboBoxTargetYear)
        Me.Panel1.Controls.Add(Me.RichTextBoxEvaluationTeacher)
        Me.Panel1.Controls.Add(Me.RichTextBoxCollaborationRegion)
        Me.Panel1.Controls.Add(Me.RichTextBoxSpecificChild)
        Me.Panel1.Controls.Add(Me.RichTextBoxCooperationHome)
        Me.Panel1.Controls.Add(Me.RichTextBoxCollaborationStaff)
        Me.Panel1.Controls.Add(Me.RichTextBoxEvent)
        Me.Panel1.Controls.Add(Me.RichTextBoxFoodAssistance)
        Me.Panel1.Controls.Add(Me.RichTextBoxFoodExpectedChild)
        Me.Panel1.Controls.Add(Me.RichTextBoxFoodConstitution)
        Me.Panel1.Controls.Add(Me.RichTextBoxFoodContents)
        Me.Panel1.Controls.Add(Me.RichTextBoxEducationAssistance)
        Me.Panel1.Controls.Add(Me.RichTextBoxNursingAssistance)
        Me.Panel1.Controls.Add(Me.RichTextBoxEducationExpectedChild)
        Me.Panel1.Controls.Add(Me.RichTextBoxNursingExpectedChild)
        Me.Panel1.Controls.Add(Me.RichTextBoxEducationConstitution)
        Me.Panel1.Controls.Add(Me.RichTextBoxNursingConstitution)
        Me.Panel1.Controls.Add(Me.RichTextBoxEducationContents)
        Me.Panel1.Controls.Add(Me.RichTextBoxNursingContents)
        Me.Panel1.Controls.Add(Me.RichTextBoxAim)
        Me.Panel1.Controls.Add(Me.RichTextBoxStateMonth)
        Me.Panel1.Controls.Add(Me.ComboBoxLeaderName)
        Me.Panel1.Controls.Add(Me.ComboBoxClassName)
        Me.Panel1.Controls.Add(Me.DateTimePickerCreatedDate)
        Me.Panel1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Panel1.Location = New System.Drawing.Point(2, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 643)
        Me.Panel1.TabIndex = 0
        '
        'MonthHigh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(831, 700)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MonthHigh"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "保育指導月案編集画面"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 上書き保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 名前を付けて保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 閉じるToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DateTimePickerCreatedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxClassName As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxLeaderName As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBoxStateMonth As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxAim As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxNursingContents As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxEducationContents As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxNursingConstitution As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxEducationConstitution As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxNursingExpectedChild As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxEducationExpectedChild As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxNursingAssistance As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxEducationAssistance As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxFoodContents As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxFoodConstitution As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxFoodExpectedChild As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxFoodAssistance As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxEvent As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxCollaborationStaff As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxCooperationHome As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxSpecificChild As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxCollaborationRegion As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxEvaluationTeacher As System.Windows.Forms.RichTextBox
    Friend WithEvents ComboBoxTargetYear As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTargetMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelSum As System.Windows.Forms.Label
    Friend WithEvents TextBoxGirlsNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBoysNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
