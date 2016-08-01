Public Class Form2
    Inherits System.Windows.Forms.Form


#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "查找内容：(&N)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(296, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "查找下一个(&F)"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "取消"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(16, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "区分大小写(&C)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(136, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 48)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "方向"
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(80, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(56, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "向下"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(8, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(56, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "向上"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(416, 104)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查找"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '根据是否输入了内容决定按钮的可不可用
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then Button1.Enabled = True Else Button1.Enabled = False
    End Sub
    '"取消"按钮,不用close而用hide是因为close之后下次就无法show了
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    '查找下一个
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call chazhaoxiayige()
    End Sub
    '窗体加载
    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If shou <> "" Then
            TextBox1.Text = shou
        End If
        kaishi = f1.RichTextBox1.SelectionStart + f1.RichTextBox1.SelectionLength
    End Sub
    '选中"向上"时
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Text = "查找上一个(&F)"
    End Sub
    '选中"向下"时
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Text = "查找下一个(&F)"
    End Sub
    '不给关闭,让窗体隐藏,以便下次调用
    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    '当按回车时,执行查找功能
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim WM_KEYDOWN As Integer = 256
        Dim WM_SYSKEYDOWN As Integer = 260

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then

            Select Case keyData

                Case Keys.Enter
                    '截获到回车键
                    Call chazhaoxiayige()
                    Return False


            End Select

        End If

    End Function
    '实现查找的过程代码
    Public Sub chazhaoxiayige()
        If RadioButton1.Checked = False Then   '如果选中了"向下"
            kaishi = f1.RichTextBox1.SelectionStart + f1.RichTextBox1.SelectionLength + 1
            shou = TextBox1.Text
            If CheckBox1.Checked = True Then  '如果选中了"区分大小写"
                pos = InStr(kaishi, f1.RichTextBox1.Text, shou)
            Else                              '如果没有选中"区分大小写"
                pos = InStr(kaishi, f1.RichTextBox1.Text.ToLower, shou.ToLower, CompareMethod.Text)
            End If
            If pos > 0 Then                   '如果找到内容
                f1.RichTextBox1.Select(pos - 1, Len(shou))

            Else
                MsgBox("找不到 " & """" & shou & """", MsgBoxStyle.Information)
            End If
        Else                                 '如果选中了"向上"
            kaishi = f1.RichTextBox1.SelectionStart + 1
            shou = TextBox1.Text
            If CheckBox1.Checked = True Then  '如果选中了"区分大小写"
                pos = InStrRev(f1.RichTextBox1.Text, shou, kaishi)
            Else                              '如果没有选中"区分大小写"
                pos = InStrRev(f1.RichTextBox1.Text.ToLower, shou.ToLower, kaishi)
            End If
            If pos > 0 Then                  '如果找到内容
                f1.RichTextBox1.Select(pos - 1, Len(shou))
            Else
                MsgBox("找不到 " & """" & shou & """", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class
