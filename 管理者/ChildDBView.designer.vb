<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildDBView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChildDBView))
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BnfImgBtnHelp = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnLoad = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BnfFlatBtnLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BnfFlatBtnHelp = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BnfFlatBtnToppage = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BnfImgBtnNewCreate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BnfImgBtnDelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton9 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.header.SuspendLayout()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BnfImgBtnNewCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BnfImgBtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'header
        '
        Me.header.BackgroundImage = CType(resources.GetObject("header.BackgroundImage"), System.Drawing.Image)
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.header.Controls.Add(Me.BnfImgBtnHelp)
        Me.header.Controls.Add(Me.BnfImgBtnClose)
        Me.header.Controls.Add(Me.BnfImgBtnLoad)
        Me.header.Controls.Add(Me.Label1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.header.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.header.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.header.Name = "header"
        Me.header.Quality = 10
        Me.header.Size = New System.Drawing.Size(1362, 50)
        Me.header.TabIndex = 73
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 17.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(597, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "電子書類簡易入力システム"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1862, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 48)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1452, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 48)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(227, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(1123, 444)
        Me.DataGridView1.TabIndex = 70
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1655, 11)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 48)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BnfFlatBtnLogout)
        Me.BunifuGradientPanel1.Controls.Add(Me.BnfFlatBtnHelp)
        Me.BunifuGradientPanel1.Controls.Add(Me.BnfFlatBtnToppage)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel3)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 50)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(219, 700)
        Me.BunifuGradientPanel1.TabIndex = 74
        '
        'BnfFlatBtnLogout
        '
        Me.BnfFlatBtnLogout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BnfFlatBtnLogout.BackColor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnLogout.BorderRadius = 0
        Me.BnfFlatBtnLogout.ButtonText = "　ログアウト"
        Me.BnfFlatBtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnLogout.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnLogout.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnLogout.Iconimage = CType(resources.GetObject("BnfFlatBtnLogout.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnLogout.Iconimage_right = Nothing
        Me.BnfFlatBtnLogout.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnLogout.Iconimage_Selected = Nothing
        Me.BnfFlatBtnLogout.IconMarginLeft = 0
        Me.BnfFlatBtnLogout.IconMarginRight = 0
        Me.BnfFlatBtnLogout.IconRightVisible = True
        Me.BnfFlatBtnLogout.IconRightZoom = 0.0R
        Me.BnfFlatBtnLogout.IconVisible = True
        Me.BnfFlatBtnLogout.IconZoom = 70.0R
        Me.BnfFlatBtnLogout.IsTab = False
        Me.BnfFlatBtnLogout.Location = New System.Drawing.Point(10, 162)
        Me.BnfFlatBtnLogout.Name = "BnfFlatBtnLogout"
        Me.BnfFlatBtnLogout.Normalcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnLogout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnLogout.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnLogout.selected = False
        Me.BnfFlatBtnLogout.Size = New System.Drawing.Size(195, 70)
        Me.BnfFlatBtnLogout.TabIndex = 46
        Me.BnfFlatBtnLogout.Text = "　ログアウト"
        Me.BnfFlatBtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnLogout.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnLogout.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BnfFlatBtnHelp
        '
        Me.BnfFlatBtnHelp.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BnfFlatBtnHelp.BackColor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnHelp.BorderRadius = 0
        Me.BnfFlatBtnHelp.ButtonText = "　ヘルプ"
        Me.BnfFlatBtnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnHelp.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnHelp.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnHelp.Iconimage = CType(resources.GetObject("BnfFlatBtnHelp.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnHelp.Iconimage_right = Nothing
        Me.BnfFlatBtnHelp.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnHelp.Iconimage_Selected = Nothing
        Me.BnfFlatBtnHelp.IconMarginLeft = 0
        Me.BnfFlatBtnHelp.IconMarginRight = 0
        Me.BnfFlatBtnHelp.IconRightVisible = True
        Me.BnfFlatBtnHelp.IconRightZoom = 0.0R
        Me.BnfFlatBtnHelp.IconVisible = True
        Me.BnfFlatBtnHelp.IconZoom = 70.0R
        Me.BnfFlatBtnHelp.IsTab = False
        Me.BnfFlatBtnHelp.Location = New System.Drawing.Point(10, 86)
        Me.BnfFlatBtnHelp.Name = "BnfFlatBtnHelp"
        Me.BnfFlatBtnHelp.Normalcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnHelp.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnHelp.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnHelp.selected = False
        Me.BnfFlatBtnHelp.Size = New System.Drawing.Size(195, 70)
        Me.BnfFlatBtnHelp.TabIndex = 45
        Me.BnfFlatBtnHelp.Text = "　ヘルプ"
        Me.BnfFlatBtnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnHelp.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnHelp.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BnfFlatBtnToppage
        '
        Me.BnfFlatBtnToppage.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BnfFlatBtnToppage.BackColor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnToppage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnToppage.BorderRadius = 0
        Me.BnfFlatBtnToppage.ButtonText = "　トップページ"
        Me.BnfFlatBtnToppage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnToppage.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnToppage.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnToppage.Iconimage = CType(resources.GetObject("BnfFlatBtnToppage.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnToppage.Iconimage_right = Nothing
        Me.BnfFlatBtnToppage.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnToppage.Iconimage_Selected = Nothing
        Me.BnfFlatBtnToppage.IconMarginLeft = 0
        Me.BnfFlatBtnToppage.IconMarginRight = 0
        Me.BnfFlatBtnToppage.IconRightVisible = True
        Me.BnfFlatBtnToppage.IconRightZoom = 0.0R
        Me.BnfFlatBtnToppage.IconVisible = True
        Me.BnfFlatBtnToppage.IconZoom = 70.0R
        Me.BnfFlatBtnToppage.IsTab = False
        Me.BnfFlatBtnToppage.Location = New System.Drawing.Point(10, 8)
        Me.BnfFlatBtnToppage.Name = "BnfFlatBtnToppage"
        Me.BnfFlatBtnToppage.Normalcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnToppage.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnToppage.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnToppage.selected = False
        Me.BnfFlatBtnToppage.Size = New System.Drawing.Size(195, 70)
        Me.BnfFlatBtnToppage.TabIndex = 44
        Me.BnfFlatBtnToppage.Text = "　トップページ"
        Me.BnfFlatBtnToppage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnToppage.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnToppage.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BnfImgBtnNewCreate)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(7, 562)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(105, 118)
        Me.Panel2.TabIndex = 47
        '
        'BnfImgBtnNewCreate
        '
        Me.BnfImgBtnNewCreate.BackColor = System.Drawing.Color.Transparent
        Me.BnfImgBtnNewCreate.Image = CType(resources.GetObject("BnfImgBtnNewCreate.Image"), System.Drawing.Image)
        Me.BnfImgBtnNewCreate.ImageActive = Nothing
        Me.BnfImgBtnNewCreate.Location = New System.Drawing.Point(24, 20)
        Me.BnfImgBtnNewCreate.Name = "BnfImgBtnNewCreate"
        Me.BnfImgBtnNewCreate.Size = New System.Drawing.Size(60, 65)
        Me.BnfImgBtnNewCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BnfImgBtnNewCreate.TabIndex = 40
        Me.BnfImgBtnNewCreate.TabStop = False
        Me.BnfImgBtnNewCreate.Zoom = 5
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(11, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 28)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "新規追加"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.BnfImgBtnDelete)
        Me.Panel3.Location = New System.Drawing.Point(106, 562)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(105, 118)
        Me.Panel3.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(28, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 28)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "削除"
        '
        'BnfImgBtnDelete
        '
        Me.BnfImgBtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BnfImgBtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BnfImgBtnDelete.Image = CType(resources.GetObject("BnfImgBtnDelete.Image"), System.Drawing.Image)
        Me.BnfImgBtnDelete.ImageActive = Nothing
        Me.BnfImgBtnDelete.Location = New System.Drawing.Point(24, 20)
        Me.BnfImgBtnDelete.Name = "BnfImgBtnDelete"
        Me.BnfImgBtnDelete.Size = New System.Drawing.Size(60, 65)
        Me.BnfImgBtnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BnfImgBtnDelete.TabIndex = 41
        Me.BnfImgBtnDelete.TabStop = False
        Me.BnfImgBtnDelete.Zoom = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BunifuFlatButton7)
        Me.GroupBox3.Controls.Add(Me.BunifuFlatButton6)
        Me.GroupBox3.Controls.Add(Me.BunifuFlatButton5)
        Me.GroupBox3.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox3.Location = New System.Drawing.Point(1056, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 214)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ソートボタン"
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "　　入園年度順"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0.0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 60.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(15, 152)
        Me.BunifuFlatButton7.Margin = New System.Windows.Forms.Padding(7)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(269, 52)
        Me.BunifuFlatButton7.TabIndex = 44
        Me.BunifuFlatButton7.Text = "　　入園年度順"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "　　児童名順"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0.0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 70.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(15, 96)
        Me.BunifuFlatButton6.Margin = New System.Windows.Forms.Padding(7)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(269, 52)
        Me.BunifuFlatButton6.TabIndex = 43
        Me.BunifuFlatButton6.Text = "　　児童名順"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "　　児童番号順"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0.0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 70.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(15, 38)
        Me.BunifuFlatButton5.Margin = New System.Windows.Forms.Padding(7)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(269, 54)
        Me.BunifuFlatButton5.TabIndex = 42
        Me.BunifuFlatButton5.Text = "　　児童番号順"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton9)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton8)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(225, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 214)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "検索項目"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.56204!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.43796!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CheckBox3, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CheckBox4, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(8, 154)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(463, 50)
        Me.TableLayoutPanel3.TabIndex = 53
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(421, 18)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "退職フラグを含む"
        '
        'CheckBox4
        '
        Me.CheckBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(202, 18)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 1
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 28)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "削除済みを含む"
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 0
        Me.BunifuFlatButton9.ButtonText = "　検索項目クリア"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = CType(resources.GetObject("BunifuFlatButton9.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 0
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = True
        Me.BunifuFlatButton9.IconRightZoom = 0.0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 80.0R
        Me.BunifuFlatButton9.IsTab = False
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(656, 155)
        Me.BunifuFlatButton9.Margin = New System.Windows.Forms.Padding(7)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton9.selected = False
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(171, 49)
        Me.BunifuFlatButton9.TabIndex = 52
        Me.BunifuFlatButton9.Text = "　検索項目クリア"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "　検索実行"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = CType(resources.GetObject("BunifuFlatButton8.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0.0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 90.0R
        Me.BunifuFlatButton8.IsTab = False
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(481, 155)
        Me.BunifuFlatButton8.Margin = New System.Windows.Forms.Padding(7)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(167, 49)
        Me.BunifuFlatButton8.TabIndex = 51
        Me.BunifuFlatButton8.Text = "　検索実行"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 667.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 1)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("メイリオ", 14.0!)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 38)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(819, 105)
        Me.TableLayoutPanel1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(41, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "なんか"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(31, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "タイトル"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("メイリオ", 16.0!)
        Me.TextBox1.Location = New System.Drawing.Point(155, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(659, 39)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Font = New System.Drawing.Font("メイリオ", 16.0!)
        Me.TextBox2.Location = New System.Drawing.Point(155, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(659, 39)
        Me.TextBox2.TabIndex = 3
        '
        'ChildDBView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChildDBView"
        Me.Text = "x"
        Me.header.ResumeLayout(False)
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BnfImgBtnNewCreate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BnfImgBtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BnfImgBtnHelp As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfImgBtnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfImgBtnLoad As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BnfFlatBtnLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BnfFlatBtnHelp As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BnfFlatBtnToppage As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BnfImgBtnNewCreate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BnfImgBtnDelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BunifuFlatButton9 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
