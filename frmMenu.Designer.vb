﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSTyu = New System.Windows.Forms.Button()
        Me.cmdSScan = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdNTyu = New System.Windows.Forms.Button()
        Me.cmdNScan = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdOTyu = New System.Windows.Forms.Button()
        Me.cmdOScan = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdKotei = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSTyu)
        Me.GroupBox1.Controls.Add(Me.cmdSScan)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 49)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "仕訳伝票"
        '
        'cmdSTyu
        '
        Me.cmdSTyu.Location = New System.Drawing.Point(153, 15)
        Me.cmdSTyu.Name = "cmdSTyu"
        Me.cmdSTyu.Size = New System.Drawing.Size(111, 28)
        Me.cmdSTyu.TabIndex = 1
        Me.cmdSTyu.Text = "作業中断伝票(&C)"
        Me.cmdSTyu.UseVisualStyleBackColor = True
        '
        'cmdSScan
        '
        Me.cmdSScan.Location = New System.Drawing.Point(22, 15)
        Me.cmdSScan.Name = "cmdSScan"
        Me.cmdSScan.Size = New System.Drawing.Size(110, 28)
        Me.cmdSScan.TabIndex = 0
        Me.cmdSScan.Text = "伝票スキャン（&S)"
        Me.cmdSScan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdNTyu)
        Me.GroupBox2.Controls.Add(Me.cmdNScan)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 49)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "入金伝票"
        '
        'cmdNTyu
        '
        Me.cmdNTyu.Location = New System.Drawing.Point(153, 15)
        Me.cmdNTyu.Name = "cmdNTyu"
        Me.cmdNTyu.Size = New System.Drawing.Size(111, 28)
        Me.cmdNTyu.TabIndex = 1
        Me.cmdNTyu.Text = "作業中断伝票(&L)"
        Me.cmdNTyu.UseVisualStyleBackColor = True
        '
        'cmdNScan
        '
        Me.cmdNScan.Location = New System.Drawing.Point(22, 15)
        Me.cmdNScan.Name = "cmdNScan"
        Me.cmdNScan.Size = New System.Drawing.Size(110, 28)
        Me.cmdNScan.TabIndex = 0
        Me.cmdNScan.Text = "伝票スキャン(&N)"
        Me.cmdNScan.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdOTyu)
        Me.GroupBox3.Controls.Add(Me.cmdOScan)
        Me.GroupBox3.Location = New System.Drawing.Point(34, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 49)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "出金伝票"
        '
        'cmdOTyu
        '
        Me.cmdOTyu.Location = New System.Drawing.Point(153, 17)
        Me.cmdOTyu.Name = "cmdOTyu"
        Me.cmdOTyu.Size = New System.Drawing.Size(111, 26)
        Me.cmdOTyu.TabIndex = 1
        Me.cmdOTyu.Text = "中断伝票(&J)"
        Me.cmdOTyu.UseVisualStyleBackColor = True
        '
        'cmdOScan
        '
        Me.cmdOScan.Location = New System.Drawing.Point(22, 17)
        Me.cmdOScan.Name = "cmdOScan"
        Me.cmdOScan.Size = New System.Drawing.Size(107, 26)
        Me.cmdOScan.TabIndex = 0
        Me.cmdOScan.Text = "伝票スキャン(&D)"
        Me.cmdOScan.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdKotei)
        Me.GroupBox4.Location = New System.Drawing.Point(34, 186)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(289, 49)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "その他"
        '
        'cmdKotei
        '
        Me.cmdKotei.Location = New System.Drawing.Point(22, 18)
        Me.cmdKotei.Name = "cmdKotei"
        Me.cmdKotei.Size = New System.Drawing.Size(242, 25)
        Me.cmdKotei.TabIndex = 0
        Me.cmdKotei.Text = "入出金伝票固定項目設定(&V)"
        Me.cmdKotei.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 256)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "勘定奉行OCR変換プログラム"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSTyu As System.Windows.Forms.Button
    Friend WithEvents cmdSScan As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNScan As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNTyu As System.Windows.Forms.Button
    Friend WithEvents cmdOTyu As System.Windows.Forms.Button
    Friend WithEvents cmdOScan As System.Windows.Forms.Button
    Friend WithEvents cmdKotei As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
