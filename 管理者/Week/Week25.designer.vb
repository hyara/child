<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week25
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week25))
        Me.RichRated = New System.Windows.Forms.RichTextBox()
        Me.RichHome = New System.Windows.Forms.RichTextBox()
        Me.RichContent = New System.Windows.Forms.RichTextBox()
        Me.LabelSum = New System.Windows.Forms.Label()
        Me.TextWomen = New System.Windows.Forms.TextBox()
        Me.TextMen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboTeacher = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboClass = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RichEnvironment = New System.Windows.Forms.RichTextBox()
        Me.RichAction = New System.Windows.Forms.RichTextBox()
        Me.RichAid = New System.Windows.Forms.RichTextBox()
        Me.RichEducation = New System.Windows.Forms.RichTextBox()
        Me.RichNursing = New System.Windows.Forms.RichTextBox()
        Me.RichLastWeek = New System.Windows.Forms.RichTextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.XEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichRated
        '
        Me.RichRated.Location = New System.Drawing.Point(571, 610)
        Me.RichRated.Name = "RichRated"
        Me.RichRated.Size = New System.Drawing.Size(485, 103)
        Me.RichRated.TabIndex = 37
        Me.RichRated.Text = ""
        '
        'RichHome
        '
        Me.RichHome.Location = New System.Drawing.Point(75, 610)
        Me.RichHome.Name = "RichHome"
        Me.RichHome.Size = New System.Drawing.Size(425, 102)
        Me.RichHome.TabIndex = 36
        Me.RichHome.Text = ""
        '
        'RichContent
        '
        Me.RichContent.Location = New System.Drawing.Point(8, 343)
        Me.RichContent.Name = "RichContent"
        Me.RichContent.Size = New System.Drawing.Size(275, 265)
        Me.RichContent.TabIndex = 10
        Me.RichContent.Text = ""
        '
        'LabelSum
        '
        Me.LabelSum.AutoSize = True
        Me.LabelSum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSum.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelSum.Location = New System.Drawing.Point(514, 96)
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(0, 16)
        Me.LabelSum.TabIndex = 13
        Me.LabelSum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextWomen
        '
        Me.TextWomen.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextWomen.Location = New System.Drawing.Point(658, 94)
        Me.TextWomen.MaxLength = 3
        Me.TextWomen.Name = "TextWomen"
        Me.TextWomen.Size = New System.Drawing.Size(22, 23)
        Me.TextWomen.TabIndex = 5
        Me.TextWomen.Text = "0"
        Me.TextWomen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextMen
        '
        Me.TextMen.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextMen.Location = New System.Drawing.Point(583, 94)
        Me.TextMen.MaxLength = 3
        Me.TextMen.Name = "TextMen"
        Me.TextMen.Size = New System.Drawing.Size(22, 23)
        Me.TextMen.TabIndex = 4
        Me.TextMen.Text = "0"
        Me.TextMen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(506, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "    　人(男：　　人 , 女：　　人)"
        '
        'DTP2
        '
        Me.DTP2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DTP2.Location = New System.Drawing.Point(937, 61)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(115, 20)
        Me.DTP2.TabIndex = 3
        '
        'DTP1
        '
        Me.DTP1.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.DTP1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DTP1.Location = New System.Drawing.Point(797, 62)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(113, 20)
        Me.DTP1.TabIndex = 2
        '
        'ComboTeacher
        '
        Me.ComboTeacher.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboTeacher.FormattingEnabled = True
        Me.ComboTeacher.Items.AddRange(New Object() {"森山 有機", "松原 はやお ", "印度 太郎", "近藤 兵介", "前田 ゑいと", "伊藤 桃果 "})
        Me.ComboTeacher.Location = New System.Drawing.Point(779, 90)
        Me.ComboTeacher.Name = "ComboTeacher"
        Me.ComboTeacher.Size = New System.Drawing.Size(277, 31)
        Me.ComboTeacher.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(897, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(149, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'ComboClass
        '
        Me.ComboClass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboClass.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboClass.FormattingEnabled = True
        Me.ComboClass.Items.AddRange(New Object() {"ひよこ組", "うさぎ組", "チューリップ組", "ひまわり組"})
        Me.ComboClass.Location = New System.Drawing.Point(501, 57)
        Me.ComboClass.Name = "ComboClass"
        Me.ComboClass.Size = New System.Drawing.Size(208, 31)
        Me.ComboClass.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.RichEnvironment)
        Me.Panel2.Controls.Add(Me.RichAction)
        Me.Panel2.Controls.Add(Me.RichRated)
        Me.Panel2.Controls.Add(Me.RichHome)
        Me.Panel2.Controls.Add(Me.RichAid)
        Me.Panel2.Controls.Add(Me.RichContent)
        Me.Panel2.Controls.Add(Me.RichEducation)
        Me.Panel2.Controls.Add(Me.RichNursing)
        Me.Panel2.Controls.Add(Me.RichLastWeek)
        Me.Panel2.Controls.Add(Me.LabelSum)
        Me.Panel2.Controls.Add(Me.TextWomen)
        Me.Panel2.Controls.Add(Me.TextMen)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DTP2)
        Me.Panel2.Controls.Add(Me.DTP1)
        Me.Panel2.Controls.Add(Me.ComboTeacher)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.ComboClass)
        Me.Panel2.Location = New System.Drawing.Point(-16, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1067, 726)
        Me.Panel2.TabIndex = 11
        '
        'RichEnvironment
        '
        Me.RichEnvironment.Location = New System.Drawing.Point(502, 343)
        Me.RichEnvironment.Name = "RichEnvironment"
        Me.RichEnvironment.Size = New System.Drawing.Size(275, 266)
        Me.RichEnvironment.TabIndex = 39
        Me.RichEnvironment.Text = ""
        '
        'RichAction
        '
        Me.RichAction.Location = New System.Drawing.Point(286, 343)
        Me.RichAction.Name = "RichAction"
        Me.RichAction.Size = New System.Drawing.Size(214, 266)
        Me.RichAction.TabIndex = 38
        Me.RichAction.Text = ""
        '
        'RichAid
        '
        Me.RichAid.Location = New System.Drawing.Point(780, 343)
        Me.RichAid.Name = "RichAid"
        Me.RichAid.Size = New System.Drawing.Size(275, 266)
        Me.RichAid.TabIndex = 35
        Me.RichAid.Text = ""
        '
        'RichEducation
        '
        Me.RichEducation.Location = New System.Drawing.Point(779, 189)
        Me.RichEducation.Name = "RichEducation"
        Me.RichEducation.Size = New System.Drawing.Size(277, 118)
        Me.RichEducation.TabIndex = 9
        Me.RichEducation.Text = ""
        '
        'RichNursing
        '
        Me.RichNursing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichNursing.Location = New System.Drawing.Point(502, 189)
        Me.RichNursing.Name = "RichNursing"
        Me.RichNursing.Size = New System.Drawing.Size(275, 119)
        Me.RichNursing.TabIndex = 8
        Me.RichNursing.Text = ""
        '
        'RichLastWeek
        '
        Me.RichLastWeek.Location = New System.Drawing.Point(8, 156)
        Me.RichLastWeek.Name = "RichLastWeek"
        Me.RichLastWeek.Size = New System.Drawing.Size(492, 152)
        Me.RichLastWeek.TabIndex = 7
        Me.RichLastWeek.Text = ""
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSave, Me.ASave, Me.ToolStripMenuItem1, Me.XEnd})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'SSave
        '
        Me.SSave.Name = "SSave"
        Me.SSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SSave.Size = New System.Drawing.Size(237, 22)
        Me.SSave.Text = "上書き保存(&S)"
        '
        'ASave
        '
        Me.ASave.Name = "ASave"
        Me.ASave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ASave.Size = New System.Drawing.Size(237, 22)
        Me.ASave.Text = "名前を付けて保存(&A)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(234, 6)
        '
        'XEnd
        '
        Me.XEnd.Name = "XEnd"
        Me.XEnd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.XEnd.Size = New System.Drawing.Size(237, 22)
        Me.XEnd.Text = "終了(&X)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(499, 24)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Week25
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(903, 614)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Name = "Week25"
        Me.Text = "週案編集画面"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichRated As System.Windows.Forms.RichTextBox
    Friend WithEvents RichHome As System.Windows.Forms.RichTextBox
    Friend WithEvents RichContent As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelSum As System.Windows.Forms.Label
    Friend WithEvents TextWomen As System.Windows.Forms.TextBox
    Friend WithEvents TextMen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboTeacher As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboClass As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RichAid As System.Windows.Forms.RichTextBox
    Friend WithEvents RichEducation As System.Windows.Forms.RichTextBox
    Friend WithEvents RichNursing As System.Windows.Forms.RichTextBox
    Friend WithEvents RichLastWeek As System.Windows.Forms.RichTextBox
    Friend WithEvents RichEnvironment As System.Windows.Forms.RichTextBox
    Friend WithEvents RichAction As System.Windows.Forms.RichTextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents XEnd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
