<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectAddDocument
    Inherits BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectAddDocument))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BnfImgBtnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnHelp = New Bunifu.Framework.UI.BunifuImageButton()
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BnfDragCntHeader = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ButtonWeek = New System.Windows.Forms.Button()
        Me.ButtonDay = New System.Windows.Forms.Button()
        Me.Button3to5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button0to1 = New System.Windows.Forms.Button()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 17.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "電子書類簡易入力システム"
        '
        'BnfImgBtnClose
        '
        Me.BnfImgBtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BnfImgBtnClose.Image = CType(resources.GetObject("BnfImgBtnClose.Image"), System.Drawing.Image)
        Me.BnfImgBtnClose.ImageActive = Nothing
        Me.BnfImgBtnClose.Location = New System.Drawing.Point(583, 4)
        Me.BnfImgBtnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BnfImgBtnClose.Name = "BnfImgBtnClose"
        Me.BnfImgBtnClose.Size = New System.Drawing.Size(40, 39)
        Me.BnfImgBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BnfImgBtnClose.TabIndex = 11
        Me.BnfImgBtnClose.TabStop = False
        Me.BnfImgBtnClose.Zoom = 10
        '
        'BnfImgBtnHelp
        '
        Me.BnfImgBtnHelp.BackColor = System.Drawing.Color.Transparent
        Me.BnfImgBtnHelp.Image = CType(resources.GetObject("BnfImgBtnHelp.Image"), System.Drawing.Image)
        Me.BnfImgBtnHelp.ImageActive = Nothing
        Me.BnfImgBtnHelp.Location = New System.Drawing.Point(522, 4)
        Me.BnfImgBtnHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BnfImgBtnHelp.Name = "BnfImgBtnHelp"
        Me.BnfImgBtnHelp.Size = New System.Drawing.Size(40, 39)
        Me.BnfImgBtnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BnfImgBtnHelp.TabIndex = 12
        Me.BnfImgBtnHelp.TabStop = False
        Me.BnfImgBtnHelp.Zoom = 10
        '
        'header
        '
        Me.header.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.header.BackgroundImage = CType(resources.GetObject("header.BackgroundImage"), System.Drawing.Image)
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.header.Controls.Add(Me.BnfImgBtnHelp)
        Me.header.Controls.Add(Me.BnfImgBtnClose)
        Me.header.Controls.Add(Me.Label1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.header.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.header.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.header.Name = "header"
        Me.header.Quality = 10
        Me.header.Size = New System.Drawing.Size(626, 50)
        Me.header.TabIndex = 57
        '
        'BnfDragCntHeader
        '
        Me.BnfDragCntHeader.Fixed = True
        Me.BnfDragCntHeader.Horizontal = True
        Me.BnfDragCntHeader.TargetControl = Me.header
        Me.BnfDragCntHeader.Vertical = True
        '
        'ButtonWeek
        '
        Me.ButtonWeek.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonWeek.FlatAppearance.BorderSize = 0
        Me.ButtonWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ButtonWeek.Location = New System.Drawing.Point(48, 78)
        Me.ButtonWeek.Name = "ButtonWeek"
        Me.ButtonWeek.Size = New System.Drawing.Size(171, 44)
        Me.ButtonWeek.TabIndex = 68
        Me.ButtonWeek.Text = "　週案"
        Me.ButtonWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonWeek.UseVisualStyleBackColor = False
        '
        'ButtonDay
        '
        Me.ButtonDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonDay.FlatAppearance.BorderSize = 0
        Me.ButtonDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ButtonDay.Location = New System.Drawing.Point(48, 153)
        Me.ButtonDay.Name = "ButtonDay"
        Me.ButtonDay.Size = New System.Drawing.Size(171, 44)
        Me.ButtonDay.TabIndex = 69
        Me.ButtonDay.Text = "　日案"
        Me.ButtonDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDay.UseVisualStyleBackColor = False
        '
        'Button3to5
        '
        Me.Button3to5.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3to5.FlatAppearance.BorderSize = 0
        Me.Button3to5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3to5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button3to5.Location = New System.Drawing.Point(372, 78)
        Me.Button3to5.Name = "Button3to5"
        Me.Button3to5.Size = New System.Drawing.Size(171, 44)
        Me.Button3to5.TabIndex = 70
        Me.Button3to5.Text = "3～5歳"
        Me.Button3to5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3to5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(372, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 44)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "2歳"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button0to1
        '
        Me.Button0to1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button0to1.FlatAppearance.BorderSize = 0
        Me.Button0to1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button0to1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button0to1.Location = New System.Drawing.Point(372, 228)
        Me.Button0to1.Name = "Button0to1"
        Me.Button0to1.Size = New System.Drawing.Size(171, 44)
        Me.Button0to1.TabIndex = 72
        Me.Button0to1.Text = "0～1歳"
        Me.Button0to1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button0to1.UseVisualStyleBackColor = False
        '
        'SelectAddDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(626, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Button0to1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3to5)
        Me.Controls.Add(Me.ButtonWeek)
        Me.Controls.Add(Me.ButtonDay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectAddDocument"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "追加資料選択画面"
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BnfImgBtnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfImgBtnHelp As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BnfDragCntHeader As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents ButtonWeek As System.Windows.Forms.Button
    Friend WithEvents ButtonDay As System.Windows.Forms.Button
    Friend WithEvents Button3to5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button0to1 As System.Windows.Forms.Button
End Class
