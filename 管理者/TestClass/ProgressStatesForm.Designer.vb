<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressStatesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgressStatesForm))
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressStatesLabel = New System.Windows.Forms.Label()
        Me.ProcessContentsRTB = New System.Windows.Forms.RichTextBox()
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuProgressBar1 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar.Location = New System.Drawing.Point(12, 39)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(233, 18)
        Me.ProgressBar.TabIndex = 4
        Me.ProgressBar.Value = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "進行状況"
        '
        'ProgressStatesLabel
        '
        Me.ProgressStatesLabel.AutoSize = True
        Me.ProgressStatesLabel.Location = New System.Drawing.Point(93, 13)
        Me.ProgressStatesLabel.Name = "ProgressStatesLabel"
        Me.ProgressStatesLabel.Size = New System.Drawing.Size(63, 12)
        Me.ProgressStatesLabel.TabIndex = 6
        Me.ProgressStatesLabel.Text = "( 100/100 )"
        '
        'ProcessContentsRTB
        '
        Me.ProcessContentsRTB.Location = New System.Drawing.Point(12, 92)
        Me.ProcessContentsRTB.Name = "ProcessContentsRTB"
        Me.ProcessContentsRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.ProcessContentsRTB.Size = New System.Drawing.Size(233, 126)
        Me.ProcessContentsRTB.TabIndex = 7
        Me.ProcessContentsRTB.Text = ""
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = True
        Me.BunifuCircleProgressbar1.animationIterval = 1
        Me.BunifuCircleProgressbar1.animationSpeed = 5
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.White
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineProgressThickness = 10
        Me.BunifuCircleProgressbar1.LineThickness = 5
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(343, 39)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(201, 201)
        Me.BunifuCircleProgressbar1.TabIndex = 8
        Me.BunifuCircleProgressbar1.Value = 50
        '
        'BunifuProgressBar1
        '
        Me.BunifuProgressBar1.BackColor = System.Drawing.Color.Silver
        Me.BunifuProgressBar1.BorderRadius = 5
        Me.BunifuProgressBar1.Location = New System.Drawing.Point(25, 289)
        Me.BunifuProgressBar1.MaximumValue = 100
        Me.BunifuProgressBar1.Name = "BunifuProgressBar1"
        Me.BunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal
        Me.BunifuProgressBar1.Size = New System.Drawing.Size(220, 32)
        Me.BunifuProgressBar1.TabIndex = 9
        Me.BunifuProgressBar1.Value = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 30.0!)
        Me.Label2.Location = New System.Drawing.Point(410, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 40)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "テスト中('-')"
        '
        'ProgressStatesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 480)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuProgressBar1)
        Me.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.Controls.Add(Me.ProcessContentsRTB)
        Me.Controls.Add(Me.ProgressStatesLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar)
        Me.Name = "ProgressStatesForm"
        Me.Text = "ProgressStatesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressStatesLabel As System.Windows.Forms.Label
    Friend WithEvents ProcessContentsRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents BunifuProgressBar1 As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
