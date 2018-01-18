<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildInfoSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChildInfoSelect))
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LabelSQLStatus = New System.Windows.Forms.Label()
        Me.BnfImgBtnHelp = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnLoad = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LabelHeaderTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelInfoType = New System.Windows.Forms.Label()
        Me.LabelInfoName = New System.Windows.Forms.Label()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.header.BackgroundImage = CType(resources.GetObject("header.BackgroundImage"), System.Drawing.Image)
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.header.Controls.Add(Me.BunifuImageButton1)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.header.Controls.Add(Me.BunifuImageButton3)
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
        Me.header.Size = New System.Drawing.Size(562, 50)
        Me.header.TabIndex = 66
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(416, 4)
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
        Me.BunifuImageButton2.Location = New System.Drawing.Point(508, 4)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 15
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(324, 4)
        Me.BunifuImageButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 14
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
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
        Me.LabelHeaderTitle.Size = New System.Drawing.Size(282, 31)
        Me.LabelHeaderTitle.TabIndex = 5
        Me.LabelHeaderTitle.Text = "電子書類簡易入力システム"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "書類の種類:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(44, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "書類名:"
        '
        'LabelInfoType
        '
        Me.LabelInfoType.AutoSize = True
        Me.LabelInfoType.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelInfoType.Location = New System.Drawing.Point(113, 63)
        Me.LabelInfoType.Name = "LabelInfoType"
        Me.LabelInfoType.Size = New System.Drawing.Size(89, 16)
        Me.LabelInfoType.TabIndex = 69
        Me.LabelInfoType.Text = "読み込み中"
        '
        'LabelInfoName
        '
        Me.LabelInfoName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelInfoName.Location = New System.Drawing.Point(113, 108)
        Me.LabelInfoName.Name = "LabelInfoName"
        Me.LabelInfoName.Size = New System.Drawing.Size(398, 45)
        Me.LabelInfoName.TabIndex = 70
        Me.LabelInfoName.Text = "読み込み中"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(47, 171)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(187, 61)
        Me.ButtonEdit.TabIndex = 71
        Me.ButtonEdit.Text = "編集"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(324, 171)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(187, 61)
        Me.ButtonDelete.TabIndex = 72
        Me.ButtonDelete.Text = "削除"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(361, 291)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(187, 61)
        Me.ButtonCancel.TabIndex = 73
        Me.ButtonCancel.Text = "キャンセル"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ChildInfoSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 364)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.LabelInfoName)
        Me.Controls.Add(Me.LabelInfoType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChildInfoSelect"
        Me.Text = "ChildInfoSelect"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelInfoType As System.Windows.Forms.Label
    Friend WithEvents LabelInfoName As System.Windows.Forms.Label
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
