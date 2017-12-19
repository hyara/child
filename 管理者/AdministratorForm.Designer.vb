<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministratorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministratorForm))
        Me.GroupBoxSort = New System.Windows.Forms.GroupBox()
        Me.BnfFlatBtnSimpleSortCreateDate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BnfFlatBtnSimpleSortJapaneseOrder = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BnfFlatBtnSimpleSortAny = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BnfFlatBtnChildTable = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BnfFlatBtnAll = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.LabelSQLStatus = New System.Windows.Forms.Label()
        Me.BnfImgBtnHelp = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BnfImgBtnLoad = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LabelHeaderTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BnfImgBtnNewCreate = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BnfFlatBtnChildDiary = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BnfImgBtnDelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BnfFlatBtnMail = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBoxSearch = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkBoxDelete = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkBoxRetireFlg = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BnfFlatBtnSearchClear = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BnfFlatBtnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSearchAny = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchTitle = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ClassName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorkerSQLConnect = New System.ComponentModel.BackgroundWorker()
        Me.GroupBoxSort.SuspendLayout()
        Me.header.SuspendLayout()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BnfImgBtnNewCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BnfImgBtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.GroupBoxSearch.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxSort
        '
        Me.GroupBoxSort.Controls.Add(Me.BnfFlatBtnSimpleSortCreateDate)
        Me.GroupBoxSort.Controls.Add(Me.BnfFlatBtnSimpleSortJapaneseOrder)
        Me.GroupBoxSort.Controls.Add(Me.BnfFlatBtnSimpleSortAny)
        Me.GroupBoxSort.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSort.ForeColor = System.Drawing.Color.Gray
        Me.GroupBoxSort.Location = New System.Drawing.Point(1056, 70)
        Me.GroupBoxSort.Name = "GroupBoxSort"
        Me.GroupBoxSort.Size = New System.Drawing.Size(294, 214)
        Me.GroupBoxSort.TabIndex = 64
        Me.GroupBoxSort.TabStop = False
        Me.GroupBoxSort.Text = "ソートボタン"
        '
        'BnfFlatBtnSimpleSortCreateDate
        '
        Me.BnfFlatBtnSimpleSortCreateDate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BnfFlatBtnSimpleSortCreateDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSimpleSortCreateDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnSimpleSortCreateDate.BorderRadius = 0
        Me.BnfFlatBtnSimpleSortCreateDate.ButtonText = "　　作成日順"
        Me.BnfFlatBtnSimpleSortCreateDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnSimpleSortCreateDate.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnSimpleSortCreateDate.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnSimpleSortCreateDate.Iconimage = CType(resources.GetObject("BnfFlatBtnSimpleSortCreateDate.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnSimpleSortCreateDate.Iconimage_right = Nothing
        Me.BnfFlatBtnSimpleSortCreateDate.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnSimpleSortCreateDate.Iconimage_Selected = Nothing
        Me.BnfFlatBtnSimpleSortCreateDate.IconMarginLeft = 0
        Me.BnfFlatBtnSimpleSortCreateDate.IconMarginRight = 0
        Me.BnfFlatBtnSimpleSortCreateDate.IconRightVisible = True
        Me.BnfFlatBtnSimpleSortCreateDate.IconRightZoom = 0.0R
        Me.BnfFlatBtnSimpleSortCreateDate.IconVisible = True
        Me.BnfFlatBtnSimpleSortCreateDate.IconZoom = 70.0R
        Me.BnfFlatBtnSimpleSortCreateDate.IsTab = False
        Me.BnfFlatBtnSimpleSortCreateDate.Location = New System.Drawing.Point(15, 152)
        Me.BnfFlatBtnSimpleSortCreateDate.Margin = New System.Windows.Forms.Padding(7)
        Me.BnfFlatBtnSimpleSortCreateDate.Name = "BnfFlatBtnSimpleSortCreateDate"
        Me.BnfFlatBtnSimpleSortCreateDate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSimpleSortCreateDate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnSimpleSortCreateDate.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnSimpleSortCreateDate.selected = False
        Me.BnfFlatBtnSimpleSortCreateDate.Size = New System.Drawing.Size(269, 52)
        Me.BnfFlatBtnSimpleSortCreateDate.TabIndex = 44
        Me.BnfFlatBtnSimpleSortCreateDate.Text = "　　作成日順"
        Me.BnfFlatBtnSimpleSortCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnSimpleSortCreateDate.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnSimpleSortCreateDate.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BnfFlatBtnSimpleSortJapaneseOrder
        '
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BnfFlatBtnSimpleSortJapaneseOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSimpleSortJapaneseOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnSimpleSortJapaneseOrder.BorderRadius = 0
        Me.BnfFlatBtnSimpleSortJapaneseOrder.ButtonText = "　　あいうえお順"
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnSimpleSortJapaneseOrder.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Iconimage = CType(resources.GetObject("BnfFlatBtnSimpleSortJapaneseOrder.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Iconimage_right = Nothing
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Iconimage_Selected = Nothing
        Me.BnfFlatBtnSimpleSortJapaneseOrder.IconMarginLeft = 0
        Me.BnfFlatBtnSimpleSortJapaneseOrder.IconMarginRight = 0
        Me.BnfFlatBtnSimpleSortJapaneseOrder.IconRightVisible = True
        Me.BnfFlatBtnSimpleSortJapaneseOrder.IconRightZoom = 0.0R
        Me.BnfFlatBtnSimpleSortJapaneseOrder.IconVisible = True
        Me.BnfFlatBtnSimpleSortJapaneseOrder.IconZoom = 71.0R
        Me.BnfFlatBtnSimpleSortJapaneseOrder.IsTab = False
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Location = New System.Drawing.Point(15, 96)
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Margin = New System.Windows.Forms.Padding(7)
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Name = "BnfFlatBtnSimpleSortJapaneseOrder"
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSimpleSortJapaneseOrder.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnSimpleSortJapaneseOrder.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnSimpleSortJapaneseOrder.selected = False
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Size = New System.Drawing.Size(269, 52)
        Me.BnfFlatBtnSimpleSortJapaneseOrder.TabIndex = 43
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Text = "　　あいうえお順"
        Me.BnfFlatBtnSimpleSortJapaneseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnSimpleSortJapaneseOrder.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnSimpleSortJapaneseOrder.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BnfFlatBtnSimpleSortAny
        '
        Me.BnfFlatBtnSimpleSortAny.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BnfFlatBtnSimpleSortAny.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSimpleSortAny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnSimpleSortAny.BorderRadius = 0
        Me.BnfFlatBtnSimpleSortAny.ButtonText = "　　なんか"
        Me.BnfFlatBtnSimpleSortAny.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnSimpleSortAny.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnSimpleSortAny.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnSimpleSortAny.Iconimage = CType(resources.GetObject("BnfFlatBtnSimpleSortAny.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnSimpleSortAny.Iconimage_right = Nothing
        Me.BnfFlatBtnSimpleSortAny.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnSimpleSortAny.Iconimage_Selected = Nothing
        Me.BnfFlatBtnSimpleSortAny.IconMarginLeft = 0
        Me.BnfFlatBtnSimpleSortAny.IconMarginRight = 0
        Me.BnfFlatBtnSimpleSortAny.IconRightVisible = True
        Me.BnfFlatBtnSimpleSortAny.IconRightZoom = 0.0R
        Me.BnfFlatBtnSimpleSortAny.IconVisible = True
        Me.BnfFlatBtnSimpleSortAny.IconZoom = 70.0R
        Me.BnfFlatBtnSimpleSortAny.IsTab = False
        Me.BnfFlatBtnSimpleSortAny.Location = New System.Drawing.Point(15, 38)
        Me.BnfFlatBtnSimpleSortAny.Margin = New System.Windows.Forms.Padding(7)
        Me.BnfFlatBtnSimpleSortAny.Name = "BnfFlatBtnSimpleSortAny"
        Me.BnfFlatBtnSimpleSortAny.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSimpleSortAny.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnSimpleSortAny.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnSimpleSortAny.selected = False
        Me.BnfFlatBtnSimpleSortAny.Size = New System.Drawing.Size(269, 54)
        Me.BnfFlatBtnSimpleSortAny.TabIndex = 42
        Me.BnfFlatBtnSimpleSortAny.Text = "　　なんか"
        Me.BnfFlatBtnSimpleSortAny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnSimpleSortAny.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnSimpleSortAny.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BnfFlatBtnChildTable
        '
        Me.BnfFlatBtnChildTable.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BnfFlatBtnChildTable.BackColor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnChildTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnChildTable.BorderRadius = 0
        Me.BnfFlatBtnChildTable.ButtonText = "　児童表"
        Me.BnfFlatBtnChildTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnChildTable.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnChildTable.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnChildTable.Iconimage = CType(resources.GetObject("BnfFlatBtnChildTable.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnChildTable.Iconimage_right = Nothing
        Me.BnfFlatBtnChildTable.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnChildTable.Iconimage_Selected = Nothing
        Me.BnfFlatBtnChildTable.IconMarginLeft = 0
        Me.BnfFlatBtnChildTable.IconMarginRight = 0
        Me.BnfFlatBtnChildTable.IconRightVisible = True
        Me.BnfFlatBtnChildTable.IconRightZoom = 0.0R
        Me.BnfFlatBtnChildTable.IconVisible = True
        Me.BnfFlatBtnChildTable.IconZoom = 70.0R
        Me.BnfFlatBtnChildTable.IsTab = False
        Me.BnfFlatBtnChildTable.Location = New System.Drawing.Point(10, 124)
        Me.BnfFlatBtnChildTable.Margin = New System.Windows.Forms.Padding(4)
        Me.BnfFlatBtnChildTable.Name = "BnfFlatBtnChildTable"
        Me.BnfFlatBtnChildTable.Normalcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnChildTable.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnChildTable.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnChildTable.selected = False
        Me.BnfFlatBtnChildTable.Size = New System.Drawing.Size(195, 70)
        Me.BnfFlatBtnChildTable.TabIndex = 45
        Me.BnfFlatBtnChildTable.Text = "　児童表"
        Me.BnfFlatBtnChildTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnChildTable.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnChildTable.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BnfFlatBtnAll
        '
        Me.BnfFlatBtnAll.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BnfFlatBtnAll.BackColor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnAll.BorderRadius = 0
        Me.BnfFlatBtnAll.ButtonText = "　すべて"
        Me.BnfFlatBtnAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnAll.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnAll.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnAll.Iconimage = CType(resources.GetObject("BnfFlatBtnAll.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnAll.Iconimage_right = Nothing
        Me.BnfFlatBtnAll.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnAll.Iconimage_Selected = Nothing
        Me.BnfFlatBtnAll.IconMarginLeft = 0
        Me.BnfFlatBtnAll.IconMarginRight = 0
        Me.BnfFlatBtnAll.IconRightVisible = True
        Me.BnfFlatBtnAll.IconRightZoom = 0.0R
        Me.BnfFlatBtnAll.IconVisible = True
        Me.BnfFlatBtnAll.IconZoom = 70.0R
        Me.BnfFlatBtnAll.IsTab = False
        Me.BnfFlatBtnAll.Location = New System.Drawing.Point(10, 47)
        Me.BnfFlatBtnAll.Name = "BnfFlatBtnAll"
        Me.BnfFlatBtnAll.Normalcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnAll.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnAll.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnAll.selected = False
        Me.BnfFlatBtnAll.Size = New System.Drawing.Size(198, 70)
        Me.BnfFlatBtnAll.TabIndex = 44
        Me.BnfFlatBtnAll.Text = "　すべて"
        Me.BnfFlatBtnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnAll.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnAll.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.header.BackgroundImage = CType(resources.GetObject("header.BackgroundImage"), System.Drawing.Image)
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.header.Size = New System.Drawing.Size(1362, 50)
        Me.header.TabIndex = 65
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
        Me.LabelHeaderTitle.Size = New System.Drawing.Size(597, 31)
        Me.LabelHeaderTitle.TabIndex = 5
        Me.LabelHeaderTitle.Text = "電子書類簡易入力システム"
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
        'BnfFlatBtnChildDiary
        '
        Me.BnfFlatBtnChildDiary.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BnfFlatBtnChildDiary.BackColor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnChildDiary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnChildDiary.BorderRadius = 0
        Me.BnfFlatBtnChildDiary.ButtonText = "　児童日誌"
        Me.BnfFlatBtnChildDiary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnChildDiary.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnChildDiary.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnChildDiary.Iconimage = CType(resources.GetObject("BnfFlatBtnChildDiary.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnChildDiary.Iconimage_right = Nothing
        Me.BnfFlatBtnChildDiary.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnChildDiary.Iconimage_Selected = Nothing
        Me.BnfFlatBtnChildDiary.IconMarginLeft = 0
        Me.BnfFlatBtnChildDiary.IconMarginRight = 0
        Me.BnfFlatBtnChildDiary.IconRightVisible = True
        Me.BnfFlatBtnChildDiary.IconRightZoom = 0.0R
        Me.BnfFlatBtnChildDiary.IconVisible = True
        Me.BnfFlatBtnChildDiary.IconZoom = 70.0R
        Me.BnfFlatBtnChildDiary.IsTab = False
        Me.BnfFlatBtnChildDiary.Location = New System.Drawing.Point(10, 280)
        Me.BnfFlatBtnChildDiary.Margin = New System.Windows.Forms.Padding(4)
        Me.BnfFlatBtnChildDiary.Name = "BnfFlatBtnChildDiary"
        Me.BnfFlatBtnChildDiary.Normalcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnChildDiary.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnChildDiary.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnChildDiary.selected = False
        Me.BnfFlatBtnChildDiary.Size = New System.Drawing.Size(195, 70)
        Me.BnfFlatBtnChildDiary.TabIndex = 46
        Me.BnfFlatBtnChildDiary.Text = "　児童日誌"
        Me.BnfFlatBtnChildDiary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnChildDiary.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnChildDiary.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
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
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BnfFlatBtnMail)
        Me.BunifuGradientPanel1.Controls.Add(Me.BnfFlatBtnChildDiary)
        Me.BunifuGradientPanel1.Controls.Add(Me.BnfFlatBtnChildTable)
        Me.BunifuGradientPanel1.Controls.Add(Me.BnfFlatBtnAll)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel3)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 50)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(219, 727)
        Me.BunifuGradientPanel1.TabIndex = 66
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(47, 16)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(126, 28)
        Me.BunifuCustomLabel1.TabIndex = 50
        Me.BunifuCustomLabel1.Text = "表示書類選択"
        '
        'BnfFlatBtnMail
        '
        Me.BnfFlatBtnMail.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BnfFlatBtnMail.BackColor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnMail.BorderRadius = 0
        Me.BnfFlatBtnMail.ButtonText = "　おたより"
        Me.BnfFlatBtnMail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnMail.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnMail.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnMail.Iconimage = CType(resources.GetObject("BnfFlatBtnMail.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnMail.Iconimage_right = Nothing
        Me.BnfFlatBtnMail.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnMail.Iconimage_Selected = Nothing
        Me.BnfFlatBtnMail.IconMarginLeft = 0
        Me.BnfFlatBtnMail.IconMarginRight = 0
        Me.BnfFlatBtnMail.IconRightVisible = True
        Me.BnfFlatBtnMail.IconRightZoom = 0.0R
        Me.BnfFlatBtnMail.IconVisible = True
        Me.BnfFlatBtnMail.IconZoom = 70.0R
        Me.BnfFlatBtnMail.IsTab = False
        Me.BnfFlatBtnMail.Location = New System.Drawing.Point(10, 202)
        Me.BnfFlatBtnMail.Margin = New System.Windows.Forms.Padding(4)
        Me.BnfFlatBtnMail.Name = "BnfFlatBtnMail"
        Me.BnfFlatBtnMail.Normalcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnMail.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnMail.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnMail.selected = False
        Me.BnfFlatBtnMail.Size = New System.Drawing.Size(195, 70)
        Me.BnfFlatBtnMail.TabIndex = 49
        Me.BnfFlatBtnMail.Text = "　おたより"
        Me.BnfFlatBtnMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnMail.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnMail.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'GroupBoxSearch
        '
        Me.GroupBoxSearch.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBoxSearch.Controls.Add(Me.BnfFlatBtnSearchClear)
        Me.GroupBoxSearch.Controls.Add(Me.BnfFlatBtnSearch)
        Me.GroupBoxSearch.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBoxSearch.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSearch.ForeColor = System.Drawing.Color.Gray
        Me.GroupBoxSearch.Location = New System.Drawing.Point(225, 70)
        Me.GroupBoxSearch.Name = "GroupBoxSearch"
        Me.GroupBoxSearch.Size = New System.Drawing.Size(835, 214)
        Me.GroupBoxSearch.TabIndex = 63
        Me.GroupBoxSearch.TabStop = False
        Me.GroupBoxSearch.Text = "検索項目"
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
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ChkBoxDelete, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ChkBoxRetireFlg, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(8, 154)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(463, 50)
        Me.TableLayoutPanel3.TabIndex = 53
        '
        'ChkBoxDelete
        '
        Me.ChkBoxDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkBoxDelete.AutoSize = True
        Me.ChkBoxDelete.Location = New System.Drawing.Point(411, 18)
        Me.ChkBoxDelete.Name = "ChkBoxDelete"
        Me.ChkBoxDelete.Size = New System.Drawing.Size(15, 14)
        Me.ChkBoxDelete.TabIndex = 3
        Me.ChkBoxDelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "退職済みを含む"
        '
        'ChkBoxRetireFlg
        '
        Me.ChkBoxRetireFlg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkBoxRetireFlg.AutoSize = True
        Me.ChkBoxRetireFlg.Location = New System.Drawing.Point(184, 18)
        Me.ChkBoxRetireFlg.Name = "ChkBoxRetireFlg"
        Me.ChkBoxRetireFlg.Size = New System.Drawing.Size(15, 14)
        Me.ChkBoxRetireFlg.TabIndex = 1
        Me.ChkBoxRetireFlg.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 28)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "削除済みを含む"
        '
        'BnfFlatBtnSearchClear
        '
        Me.BnfFlatBtnSearchClear.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BnfFlatBtnSearchClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSearchClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnSearchClear.BorderRadius = 0
        Me.BnfFlatBtnSearchClear.ButtonText = "　検索項目クリア"
        Me.BnfFlatBtnSearchClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnSearchClear.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnSearchClear.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnSearchClear.Iconimage = CType(resources.GetObject("BnfFlatBtnSearchClear.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnSearchClear.Iconimage_right = Nothing
        Me.BnfFlatBtnSearchClear.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnSearchClear.Iconimage_Selected = Nothing
        Me.BnfFlatBtnSearchClear.IconMarginLeft = 0
        Me.BnfFlatBtnSearchClear.IconMarginRight = 0
        Me.BnfFlatBtnSearchClear.IconRightVisible = True
        Me.BnfFlatBtnSearchClear.IconRightZoom = 0.0R
        Me.BnfFlatBtnSearchClear.IconVisible = True
        Me.BnfFlatBtnSearchClear.IconZoom = 80.0R
        Me.BnfFlatBtnSearchClear.IsTab = False
        Me.BnfFlatBtnSearchClear.Location = New System.Drawing.Point(656, 155)
        Me.BnfFlatBtnSearchClear.Margin = New System.Windows.Forms.Padding(7)
        Me.BnfFlatBtnSearchClear.Name = "BnfFlatBtnSearchClear"
        Me.BnfFlatBtnSearchClear.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSearchClear.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnSearchClear.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnSearchClear.selected = False
        Me.BnfFlatBtnSearchClear.Size = New System.Drawing.Size(171, 49)
        Me.BnfFlatBtnSearchClear.TabIndex = 52
        Me.BnfFlatBtnSearchClear.Text = "　検索項目クリア"
        Me.BnfFlatBtnSearchClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnSearchClear.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnSearchClear.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'BnfFlatBtnSearch
        '
        Me.BnfFlatBtnSearch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BnfFlatBtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BnfFlatBtnSearch.BorderRadius = 0
        Me.BnfFlatBtnSearch.ButtonText = "　検索実行"
        Me.BnfFlatBtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BnfFlatBtnSearch.DisabledColor = System.Drawing.Color.Gray
        Me.BnfFlatBtnSearch.Iconcolor = System.Drawing.Color.Transparent
        Me.BnfFlatBtnSearch.Iconimage = CType(resources.GetObject("BnfFlatBtnSearch.Iconimage"), System.Drawing.Image)
        Me.BnfFlatBtnSearch.Iconimage_right = Nothing
        Me.BnfFlatBtnSearch.Iconimage_right_Selected = Nothing
        Me.BnfFlatBtnSearch.Iconimage_Selected = Nothing
        Me.BnfFlatBtnSearch.IconMarginLeft = 0
        Me.BnfFlatBtnSearch.IconMarginRight = 0
        Me.BnfFlatBtnSearch.IconRightVisible = True
        Me.BnfFlatBtnSearch.IconRightZoom = 0.0R
        Me.BnfFlatBtnSearch.IconVisible = True
        Me.BnfFlatBtnSearch.IconZoom = 90.0R
        Me.BnfFlatBtnSearch.IsTab = False
        Me.BnfFlatBtnSearch.Location = New System.Drawing.Point(481, 155)
        Me.BnfFlatBtnSearch.Margin = New System.Windows.Forms.Padding(7)
        Me.BnfFlatBtnSearch.Name = "BnfFlatBtnSearch"
        Me.BnfFlatBtnSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BnfFlatBtnSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BnfFlatBtnSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.BnfFlatBtnSearch.selected = False
        Me.BnfFlatBtnSearch.Size = New System.Drawing.Size(167, 49)
        Me.BnfFlatBtnSearch.TabIndex = 51
        Me.BnfFlatBtnSearch.Text = "　検索実行"
        Me.BnfFlatBtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BnfFlatBtnSearch.Textcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BnfFlatBtnSearch.TextFont = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 677.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxSearchAny, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxSearchTitle, 1, 1)
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
        Me.Label2.Location = New System.Drawing.Point(36, 12)
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
        Me.Label4.Location = New System.Drawing.Point(26, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "タイトル"
        '
        'TextBoxSearchAny
        '
        Me.TextBoxSearchAny.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxSearchAny.Font = New System.Drawing.Font("メイリオ", 16.0!)
        Me.TextBoxSearchAny.Location = New System.Drawing.Point(150, 7)
        Me.TextBoxSearchAny.Name = "TextBoxSearchAny"
        Me.TextBoxSearchAny.Size = New System.Drawing.Size(659, 39)
        Me.TextBoxSearchAny.TabIndex = 2
        '
        'TextBoxSearchTitle
        '
        Me.TextBoxSearchTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxSearchTitle.Font = New System.Drawing.Font("メイリオ", 16.0!)
        Me.TextBoxSearchTitle.Location = New System.Drawing.Point(150, 59)
        Me.TextBoxSearchTitle.Name = "TextBoxSearchTitle"
        Me.TextBoxSearchTitle.Size = New System.Drawing.Size(659, 39)
        Me.TextBoxSearchTitle.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1862, 12)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 48)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1452, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 48)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1655, 12)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 48)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.ClassName, Me.LeaderName, Me.CreatedDate, Me.UpdateDate, Me.Column1})
        Me.DataGridView.Location = New System.Drawing.Point(225, 284)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowTemplate.Height = 21
        Me.DataGridView.Size = New System.Drawing.Size(1125, 454)
        Me.DataGridView.TabIndex = 67
        '
        'id
        '
        Me.id.HeaderText = "書類番号"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ClassName
        '
        Me.ClassName.HeaderText = "クラス名"
        Me.ClassName.Name = "ClassName"
        Me.ClassName.ReadOnly = True
        Me.ClassName.Width = 200
        '
        'LeaderName
        '
        Me.LeaderName.HeaderText = "指導者名"
        Me.LeaderName.Name = "LeaderName"
        Me.LeaderName.ReadOnly = True
        Me.LeaderName.Width = 200
        '
        'CreatedDate
        '
        Me.CreatedDate.HeaderText = "作成日"
        Me.CreatedDate.Name = "CreatedDate"
        Me.CreatedDate.ReadOnly = True
        Me.CreatedDate.Width = 250
        '
        'UpdateDate
        '
        Me.UpdateDate.HeaderText = "更新日"
        Me.UpdateDate.Name = "UpdateDate"
        Me.UpdateDate.ReadOnly = True
        Me.UpdateDate.Width = 250
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 118
        '
        'BackgroundWorkerSQLConnect
        '
        '
        'AdministratorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.GroupBoxSort)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.GroupBoxSearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdministratorForm"
        Me.RightToLeftLayout = True
        Me.Text = "AdministratorForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxSort.ResumeLayout(False)
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BnfImgBtnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BnfImgBtnLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BnfImgBtnNewCreate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BnfImgBtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.GroupBoxSearch.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxSort As System.Windows.Forms.GroupBox
    Friend WithEvents BnfFlatBtnSimpleSortCreateDate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BnfFlatBtnSimpleSortJapaneseOrder As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BnfFlatBtnSimpleSortAny As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BnfFlatBtnChildTable As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BnfFlatBtnAll As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BnfImgBtnHelp As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfImgBtnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BnfImgBtnLoad As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents LabelHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BnfImgBtnNewCreate As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BnfFlatBtnChildDiary As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BnfImgBtnDelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents GroupBoxSearch As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ChkBoxDelete As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkBoxRetireFlg As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BnfFlatBtnSearchClear As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BnfFlatBtnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSearchAny As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSearchTitle As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BnfFlatBtnMail As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ClassName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeaderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorkerSQLConnect As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelSQLStatus As System.Windows.Forms.Label
End Class
