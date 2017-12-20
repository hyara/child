<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddClass))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextCluss = New System.Windows.Forms.TextBox()
        Me.Man = New System.Windows.Forms.TextBox()
        Me.Girl = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrerMessage1 = New System.Windows.Forms.Label()
        Me.ErrerMessage2 = New System.Windows.Forms.Label()
        Me.ErrerMessage3 = New System.Windows.Forms.Label()
        Me.ErrerMessage4 = New System.Windows.Forms.Label()
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(124, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "神がかりなボタン"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextCluss
        '
        Me.TextCluss.Location = New System.Drawing.Point(125, 79)
        Me.TextCluss.Name = "TextCluss"
        Me.TextCluss.Size = New System.Drawing.Size(100, 19)
        Me.TextCluss.TabIndex = 1
        '
        'Man
        '
        Me.Man.Location = New System.Drawing.Point(151, 137)
        Me.Man.Name = "Man"
        Me.Man.Size = New System.Drawing.Size(31, 19)
        Me.Man.TabIndex = 2
        '
        'Girl
        '
        Me.Girl.Location = New System.Drawing.Point(151, 164)
        Me.Girl.Name = "Girl"
        Me.Girl.Size = New System.Drawing.Size(31, 19)
        Me.Girl.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(125, 236)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(59, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "クラス名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(59, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "クラス人数"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(128, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "男"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(59, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "担当"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(128, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "女"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(188, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "人"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(188, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "人"
        '
        'ErrerMessage1
        '
        Me.ErrerMessage1.AutoSize = True
        Me.ErrerMessage1.ForeColor = System.Drawing.Color.Red
        Me.ErrerMessage1.Location = New System.Drawing.Point(122, 110)
        Me.ErrerMessage1.Name = "ErrerMessage1"
        Me.ErrerMessage1.Size = New System.Drawing.Size(126, 12)
        Me.ErrerMessage1.TabIndex = 16
        Me.ErrerMessage1.Text = "クラス名を入力してください"
        Me.ErrerMessage1.Visible = False
        '
        'ErrerMessage2
        '
        Me.ErrerMessage2.AutoSize = True
        Me.ErrerMessage2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ErrerMessage2.ForeColor = System.Drawing.Color.Red
        Me.ErrerMessage2.Location = New System.Drawing.Point(59, 186)
        Me.ErrerMessage2.Name = "ErrerMessage2"
        Me.ErrerMessage2.Size = New System.Drawing.Size(279, 18)
        Me.ErrerMessage2.TabIndex = 17
        Me.ErrerMessage2.Text = "男女の合計が1以上になるように入力してください"
        Me.ErrerMessage2.Visible = False
        '
        'ErrerMessage3
        '
        Me.ErrerMessage3.AutoSize = True
        Me.ErrerMessage3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ErrerMessage3.ForeColor = System.Drawing.Color.Red
        Me.ErrerMessage3.Location = New System.Drawing.Point(121, 269)
        Me.ErrerMessage3.Name = "ErrerMessage3"
        Me.ErrerMessage3.Size = New System.Drawing.Size(176, 18)
        Me.ErrerMessage3.TabIndex = 18
        Me.ErrerMessage3.Text = "担当保育士を選択してください"
        Me.ErrerMessage3.Visible = False
        '
        'ErrerMessage4
        '
        Me.ErrerMessage4.AutoSize = True
        Me.ErrerMessage4.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ErrerMessage4.ForeColor = System.Drawing.Color.Red
        Me.ErrerMessage4.Location = New System.Drawing.Point(121, 107)
        Me.ErrerMessage4.Name = "ErrerMessage4"
        Me.ErrerMessage4.Size = New System.Drawing.Size(152, 18)
        Me.ErrerMessage4.TabIndex = 19
        Me.ErrerMessage4.Text = "そのクラス名は存在します"
        Me.ErrerMessage4.Visible = False
        '
        'header
        '
        Me.header.BackgroundImage = CType(resources.GetObject("header.BackgroundImage"), System.Drawing.Image)
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.header.Controls.Add(Me.BunifuImageButton3)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.header.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.header.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.header.Name = "header"
        Me.header.Quality = 10
        Me.header.Size = New System.Drawing.Size(364, 50)
        Me.header.TabIndex = 58
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(218, 9)
        Me.BunifuImageButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 12
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(312, 9)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 39)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 11
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'AddClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(364, 384)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.ErrerMessage4)
        Me.Controls.Add(Me.ErrerMessage3)
        Me.Controls.Add(Me.ErrerMessage2)
        Me.Controls.Add(Me.ErrerMessage1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Girl)
        Me.Controls.Add(Me.Man)
        Me.Controls.Add(Me.TextCluss)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddClass"
        Me.Text = "AddClass"
        Me.header.ResumeLayout(False)
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextCluss As System.Windows.Forms.TextBox
    Friend WithEvents Man As System.Windows.Forms.TextBox
    Friend WithEvents Girl As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrerMessage1 As System.Windows.Forms.Label
    Friend WithEvents ErrerMessage2 As System.Windows.Forms.Label
    Friend WithEvents ErrerMessage3 As System.Windows.Forms.Label
    Friend WithEvents ErrerMessage4 As System.Windows.Forms.Label
    Friend WithEvents header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
End Class
