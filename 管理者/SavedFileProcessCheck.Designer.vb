<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavedFileProcessCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SavedFileProcessCheck))
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.LabelSQLStatus = New System.Windows.Forms.Label()
        Me.BnfImgBtnHelp = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnLoad = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LabelHeaderTitle = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.header.SuspendLayout()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.header.Size = New System.Drawing.Size(478, 50)
        Me.header.TabIndex = 66
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
        Me.LabelHeaderTitle.Size = New System.Drawing.Size(295, 31)
        Me.LabelHeaderTitle.TabIndex = 5
        Me.LabelHeaderTitle.Text = "電子書類簡易入力システム"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(322, 6)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 15
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(414, 6)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 14
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
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
        Me.ButtonCancel.Location = New System.Drawing.Point(352, 224)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(110, 50)
        Me.ButtonCancel.TabIndex = 80
        Me.ButtonCancel.Text = "キャンセル"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEdit.Location = New System.Drawing.Point(46, 138)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(154, 52)
        Me.ButtonEdit.TabIndex = 79
        Me.ButtonEdit.Text = "編集"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(286, 138)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(154, 52)
        Me.ButtonDelete.TabIndex = 82
        Me.ButtonDelete.Text = "削除"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(15, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 28)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "名前:"
        '
        'LabelName
        '
        Me.LabelName.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelName.Location = New System.Drawing.Point(79, 63)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(408, 61)
        Me.LabelName.TabIndex = 84
        Me.LabelName.Text = "ここに名前"
        '
        'SavedFileProcessCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 288)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SavedFileProcessCheck"
        Me.Text = "SavedFileProcessCheck"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents LabelSQLStatus As System.Windows.Forms.Label
    Friend WithEvents BnfImgBtnHelp As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfImgBtnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfImgBtnLoad As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents LabelHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelName As System.Windows.Forms.Label
End Class
