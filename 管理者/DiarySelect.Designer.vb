<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiarySelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiarySelect))
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LabelSQLStatus = New System.Windows.Forms.Label()
        Me.BnfImgBtnHelp = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnLoad = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LabelHeaderTitle = New System.Windows.Forms.Label()
        Me.BnfChkboxMonth0to1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BnfChkboxMonth2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BnfChkboxMonth3to5 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BnfChkboxWeek0to5 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BtnMonth0to1 = New System.Windows.Forms.Button()
        Me.BtnMonth2 = New System.Windows.Forms.Button()
        Me.BtnMonth3to5 = New System.Windows.Forms.Button()
        Me.BtnWeek0to5 = New System.Windows.Forms.Button()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.header.BackgroundImage = CType(resources.GetObject("header.BackgroundImage"), System.Drawing.Image)
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.header.Controls.Add(Me.BunifuImageButton1)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.header.Controls.Add(Me.LabelSQLStatus)
        Me.header.Controls.Add(Me.BnfImgBtnHelp)
        Me.header.Controls.Add(Me.BnfImgBtnClose)
        Me.header.Controls.Add(Me.BnfImgBtnLoad)
        Me.header.Controls.Add(Me.LabelHeaderTitle)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.header.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.header.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.header.Name = "header"
        Me.header.Quality = 10
        Me.header.Size = New System.Drawing.Size(570, 50)
        Me.header.TabIndex = 66
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(437, 4)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 16
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(521, 4)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 15
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'LabelSQLStatus
        '
        Me.LabelSQLStatus.AutoSize = True
        Me.LabelSQLStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelSQLStatus.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSQLStatus.Location = New System.Drawing.Point(1005, 27)
        Me.LabelSQLStatus.Name = "LabelSQLStatus"
        Me.LabelSQLStatus.Size = New System.Drawing.Size(104, 16)
        Me.LabelSQLStatus.TabIndex = 13
        Me.LabelSQLStatus.Text = "SQL接続中..."
        '
        'BnfImgBtnHelp
        '
        Me.BnfImgBtnHelp.BackColor = System.Drawing.Color.Transparent
        Me.BnfImgBtnHelp.Image = CType(resources.GetObject("BnfImgBtnHelp.Image"), System.Drawing.Image)
        Me.BnfImgBtnHelp.ImageActive = Nothing
        Me.BnfImgBtnHelp.Location = New System.Drawing.Point(1218, 4)
        Me.BnfImgBtnHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BnfImgBtnHelp.Name = "BnfImgBtnHelp"
        Me.BnfImgBtnHelp.Size = New System.Drawing.Size(40, 39)
        Me.BnfImgBtnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BnfImgBtnHelp.TabIndex = 12
        Me.BnfImgBtnHelp.TabStop = False
        Me.BnfImgBtnHelp.Zoom = 10
        '
        'BnfImgBtnClose
        '
        Me.BnfImgBtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BnfImgBtnClose.Image = CType(resources.GetObject("BnfImgBtnClose.Image"), System.Drawing.Image)
        Me.BnfImgBtnClose.ImageActive = Nothing
        Me.BnfImgBtnClose.Location = New System.Drawing.Point(1310, 4)
        Me.BnfImgBtnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BnfImgBtnClose.Name = "BnfImgBtnClose"
        Me.BnfImgBtnClose.Size = New System.Drawing.Size(40, 39)
        Me.BnfImgBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BnfImgBtnClose.TabIndex = 11
        Me.BnfImgBtnClose.TabStop = False
        Me.BnfImgBtnClose.Zoom = 10
        '
        'BnfImgBtnLoad
        '
        Me.BnfImgBtnLoad.BackColor = System.Drawing.Color.Transparent
        Me.BnfImgBtnLoad.Image = CType(resources.GetObject("BnfImgBtnLoad.Image"), System.Drawing.Image)
        Me.BnfImgBtnLoad.ImageActive = Nothing
        Me.BnfImgBtnLoad.Location = New System.Drawing.Point(1126, 4)
        Me.BnfImgBtnLoad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BnfImgBtnLoad.Name = "BnfImgBtnLoad"
        Me.BnfImgBtnLoad.Size = New System.Drawing.Size(40, 39)
        Me.BnfImgBtnLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BnfImgBtnLoad.TabIndex = 10
        Me.BnfImgBtnLoad.TabStop = False
        Me.BnfImgBtnLoad.Zoom = 10
        '
        'LabelHeaderTitle
        '
        Me.LabelHeaderTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelHeaderTitle.Font = New System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 17.0!)
        Me.LabelHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LabelHeaderTitle.Location = New System.Drawing.Point(13, 12)
        Me.LabelHeaderTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelHeaderTitle.Name = "LabelHeaderTitle"
        Me.LabelHeaderTitle.Size = New System.Drawing.Size(287, 31)
        Me.LabelHeaderTitle.TabIndex = 5
        Me.LabelHeaderTitle.Text = "電子書類簡易入力システム"
        '
        'BnfChkboxMonth0to1
        '
        Me.BnfChkboxMonth0to1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BnfChkboxMonth0to1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BnfChkboxMonth0to1.Checked = True
        Me.BnfChkboxMonth0to1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BnfChkboxMonth0to1.ForeColor = System.Drawing.Color.White
        Me.BnfChkboxMonth0to1.Location = New System.Drawing.Point(50, 69)
        Me.BnfChkboxMonth0to1.Margin = New System.Windows.Forms.Padding(7)
        Me.BnfChkboxMonth0to1.Name = "BnfChkboxMonth0to1"
        Me.BnfChkboxMonth0to1.Size = New System.Drawing.Size(20, 20)
        Me.BnfChkboxMonth0to1.TabIndex = 67
        '
        'BnfChkboxMonth2
        '
        Me.BnfChkboxMonth2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BnfChkboxMonth2.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BnfChkboxMonth2.Checked = True
        Me.BnfChkboxMonth2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BnfChkboxMonth2.ForeColor = System.Drawing.Color.White
        Me.BnfChkboxMonth2.Location = New System.Drawing.Point(50, 137)
        Me.BnfChkboxMonth2.Margin = New System.Windows.Forms.Padding(9)
        Me.BnfChkboxMonth2.Name = "BnfChkboxMonth2"
        Me.BnfChkboxMonth2.Size = New System.Drawing.Size(20, 20)
        Me.BnfChkboxMonth2.TabIndex = 68
        '
        'BnfChkboxMonth3to5
        '
        Me.BnfChkboxMonth3to5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BnfChkboxMonth3to5.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BnfChkboxMonth3to5.Checked = True
        Me.BnfChkboxMonth3to5.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BnfChkboxMonth3to5.ForeColor = System.Drawing.Color.White
        Me.BnfChkboxMonth3to5.Location = New System.Drawing.Point(50, 204)
        Me.BnfChkboxMonth3to5.Margin = New System.Windows.Forms.Padding(9)
        Me.BnfChkboxMonth3to5.Name = "BnfChkboxMonth3to5"
        Me.BnfChkboxMonth3to5.Size = New System.Drawing.Size(20, 20)
        Me.BnfChkboxMonth3to5.TabIndex = 69
        '
        'BnfChkboxWeek0to5
        '
        Me.BnfChkboxWeek0to5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BnfChkboxWeek0to5.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BnfChkboxWeek0to5.Checked = True
        Me.BnfChkboxWeek0to5.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BnfChkboxWeek0to5.ForeColor = System.Drawing.Color.White
        Me.BnfChkboxWeek0to5.Location = New System.Drawing.Point(353, 67)
        Me.BnfChkboxWeek0to5.Margin = New System.Windows.Forms.Padding(9)
        Me.BnfChkboxWeek0to5.Name = "BnfChkboxWeek0to5"
        Me.BnfChkboxWeek0to5.Size = New System.Drawing.Size(20, 20)
        Me.BnfChkboxWeek0to5.TabIndex = 71
        '
        'BtnMonth0to1
        '
        Me.BtnMonth0to1.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BtnMonth0to1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMonth0to1.Font = New System.Drawing.Font("メイリオ", 14.0!)
        Me.BtnMonth0to1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMonth0to1.Location = New System.Drawing.Point(42, 52)
        Me.BtnMonth0to1.Name = "BtnMonth0to1"
        Me.BtnMonth0to1.Size = New System.Drawing.Size(154, 52)
        Me.BtnMonth0to1.TabIndex = 72
        Me.BtnMonth0to1.Text = "　 月案0～1歳"
        Me.BtnMonth0to1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMonth0to1.UseVisualStyleBackColor = False
        '
        'BtnMonth2
        '
        Me.BtnMonth2.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BtnMonth2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMonth2.Font = New System.Drawing.Font("メイリオ", 14.0!)
        Me.BtnMonth2.Location = New System.Drawing.Point(42, 120)
        Me.BtnMonth2.Name = "BtnMonth2"
        Me.BtnMonth2.Size = New System.Drawing.Size(154, 52)
        Me.BtnMonth2.TabIndex = 73
        Me.BtnMonth2.Text = "　 月案2歳"
        Me.BtnMonth2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMonth2.UseVisualStyleBackColor = False
        '
        'BtnMonth3to5
        '
        Me.BtnMonth3to5.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BtnMonth3to5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMonth3to5.Font = New System.Drawing.Font("メイリオ", 14.0!)
        Me.BtnMonth3to5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMonth3to5.Location = New System.Drawing.Point(42, 188)
        Me.BtnMonth3to5.Name = "BtnMonth3to5"
        Me.BtnMonth3to5.Size = New System.Drawing.Size(154, 52)
        Me.BtnMonth3to5.TabIndex = 74
        Me.BtnMonth3to5.Text = "　 月案3～5歳"
        Me.BtnMonth3to5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMonth3to5.UseVisualStyleBackColor = False
        '
        'BtnWeek0to5
        '
        Me.BtnWeek0to5.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BtnWeek0to5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWeek0to5.Font = New System.Drawing.Font("メイリオ", 14.0!)
        Me.BtnWeek0to5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnWeek0to5.Location = New System.Drawing.Point(344, 52)
        Me.BtnWeek0to5.Name = "BtnWeek0to5"
        Me.BtnWeek0to5.Size = New System.Drawing.Size(154, 52)
        Me.BtnWeek0to5.TabIndex = 75
        Me.BtnWeek0to5.Text = "　 週案0～5歳"
        Me.BtnWeek0to5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnWeek0to5.UseVisualStyleBackColor = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.LabelHeaderTitle
        Me.BunifuDragControl2.Vertical = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonCancel.Location = New System.Drawing.Point(410, 226)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(130, 50)
        Me.ButtonCancel.TabIndex = 77
        Me.ButtonCancel.Text = "キャンセル"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonOK
        '
        Me.ButtonOK.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonOK.Location = New System.Drawing.Point(274, 226)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(130, 50)
        Me.ButtonOK.TabIndex = 78
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BnfChkboxWeek0to5)
        Me.GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.GroupBox1.Controls.Add(Me.ButtonOK)
        Me.GroupBox1.Controls.Add(Me.BtnWeek0to5)
        Me.GroupBox1.Controls.Add(Me.BnfChkboxMonth3to5)
        Me.GroupBox1.Controls.Add(Me.BnfChkboxMonth2)
        Me.GroupBox1.Controls.Add(Me.BnfChkboxMonth0to1)
        Me.GroupBox1.Controls.Add(Me.BtnMonth2)
        Me.GroupBox1.Controls.Add(Me.BtnMonth0to1)
        Me.GroupBox1.Controls.Add(Me.BtnMonth3to5)
        Me.GroupBox1.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 282)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "検索したい児童表を選択"
        '
        'DiarySelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 349)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.header)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DiarySelect"
        Me.Text = "DiarySelect"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents LabelSQLStatus As System.Windows.Forms.Label
    Friend WithEvents BnfImgBtnHelp As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfImgBtnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfImgBtnLoad As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents LabelHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfChkboxMonth0to1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BnfChkboxMonth2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BnfChkboxMonth3to5 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BnfChkboxWeek0to5 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BtnMonth0to1 As System.Windows.Forms.Button
    Friend WithEvents BtnMonth2 As System.Windows.Forms.Button
    Friend WithEvents BtnMonth3to5 As System.Windows.Forms.Button
    Friend WithEvents BtnWeek0to5 As System.Windows.Forms.Button
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
