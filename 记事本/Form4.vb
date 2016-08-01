Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic
Public Class Form4
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "行数(&L)："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "确定"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "取消"
        '
        'Form4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(234, 96)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "转到下列行"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    '"取消"按钮
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    '不给关闭,让窗体隐藏,以便下次调用
    Private Sub Form4_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    '判断某一字符串是否全部为数字的Function
    Function haha(ByVal str As String) As String
        Dim i As Integer
        gaga = True
        For i = 1 To Len(str)
            If Not IsNumeric(Mid(str, i, 1)) Then
                gaga = False
            End If
        Next
    End Function
    '"转到"按钮
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call zuandao()
    End Sub
    '当按回车时,执行转到功能
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim WM_KEYDOWN As Integer = 256
        Dim WM_SYSKEYDOWN As Integer = 260

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then

            Select Case keyData

                Case Keys.Enter
                    '截获到回车键
                    Call zuandao()
                    Return False


            End Select

        End If

    End Function
    '实现"转到"的过程代码
    Public Sub zuandao()
        haha(TextBox1.Text)
        If gaga = False Then
            MsgBox("不能包含非数字字符！", MsgBoxStyle.Critical) : Exit Sub
        End If
        If Val(TextBox1.Text) > hang Then
            MsgBox("行数超过范围", , "记事本 - 跳行") : Exit Sub
        End If

        Dim biaoqian, i, kk, in1 As Integer
        kk = 0
        biaoqian = 0
        For i = 1 To hang - 1            '说明一下:这个"hang"就是当前内容的总行数,由form1的相关过程获得取值
            biaoqian = InStr(biaoqian + 1, f1.RichTextBox1.Text, Chr(10))   '查找换行符
            If biaoqian <> 0 Then kk = kk + 1 '换行符每出现一次,变量kk的值加一
            If kk = Val(TextBox1.Text) Then   '当换行符出现了(使用者输入的值)的次数时
                Exit For                    '退出循环,注意此时变量biaoqian的值是换行符出现(使用者输入的值)次时换行符的位置
            End If
            in1 = biaoqian                 '变量in1的值就是换行符出现(使用者输入的值-1)次时换行符的位置
        Next i
        If biaoqian = 0 Then MsgBox("该行不存在或当前只有一行")
        f1.RichTextBox1.Select(in1, biaoqian - in1 - 1) '将光标定位在指定行,并且选中该行
        f1.RichTextBox1.Focus()
    End Sub
End Class
