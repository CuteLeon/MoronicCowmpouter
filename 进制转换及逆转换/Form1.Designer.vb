<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConversionTool
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NudJinZhiSet = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OctValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnConversion = New System.Windows.Forms.Button()
        Me.BtnUnConversion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NudJinZhiSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NudJinZhiSet)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.OctValue)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "请输入十进制数值："
        '
        'NudJinZhiSet
        '
        Me.NudJinZhiSet.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NudJinZhiSet.Location = New System.Drawing.Point(72, 44)
        Me.NudJinZhiSet.Name = "NudJinZhiSet"
        Me.NudJinZhiSet.Size = New System.Drawing.Size(88, 23)
        Me.NudJinZhiSet.TabIndex = 5
        Me.NudJinZhiSet.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "设置进制："
        '
        'OctValue
        '
        Me.OctValue.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.OctValue.Location = New System.Drawing.Point(72, 20)
        Me.OctValue.Name = "OctValue"
        Me.OctValue.Size = New System.Drawing.Size(88, 23)
        Me.OctValue.TabIndex = 1
        Me.OctValue.Text = "5211314"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "十进制："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtResult)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 48)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "输出结果："
        '
        'TxtResult
        '
        Me.TxtResult.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtResult.Location = New System.Drawing.Point(72, 20)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(88, 23)
        Me.TxtResult.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "结果："
        '
        'BtnConversion
        '
        Me.BtnConversion.Location = New System.Drawing.Point(8, 144)
        Me.BtnConversion.Name = "BtnConversion"
        Me.BtnConversion.Size = New System.Drawing.Size(88, 32)
        Me.BtnConversion.TabIndex = 3
        Me.BtnConversion.Text = "转换进制"
        Me.BtnConversion.UseVisualStyleBackColor = True
        '
        'BtnUnConversion
        '
        Me.BtnUnConversion.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnUnConversion.Location = New System.Drawing.Point(96, 144)
        Me.BtnUnConversion.Name = "BtnUnConversion"
        Me.BtnUnConversion.Size = New System.Drawing.Size(88, 32)
        Me.BtnUnConversion.TabIndex = 4
        Me.BtnUnConversion.Text = "逆转换"
        Me.BtnUnConversion.UseVisualStyleBackColor = True
        '
        'ConversionTool
        '
        Me.AcceptButton = Me.BtnConversion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnUnConversion
        Me.ClientSize = New System.Drawing.Size(193, 185)
        Me.Controls.Add(Me.BtnUnConversion)
        Me.Controls.Add(Me.BtnConversion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ConversionTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "进制转换及逆转换"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NudJinZhiSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OctValue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnConversion As System.Windows.Forms.Button
    Friend WithEvents BtnUnConversion As System.Windows.Forms.Button
    Friend WithEvents NudJinZhiSet As System.Windows.Forms.NumericUpDown

End Class
