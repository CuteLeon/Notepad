Public Class Form3
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д dispose ����������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע��: ���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��������(&N):"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "�滻Ϊ(&P):"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 21)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(312, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "������һ��(&F)"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(312, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "�滻(&R)"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(312, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "ȫ���滻(&A)"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(312, 104)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 24)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "ȡ��"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(8, 104)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 24)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "���ִ�Сд(&C)"
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(424, 136)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�滻"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    '������һ��
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call xiayige()
    End Sub
    '"ȡ��"��ť
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub
    '�������
    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If shou <> "" Then
            TextBox1.Text = shou
        End If
    End Sub
    'ʵ��"�滻"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If f1.RichTextBox1.SelectedText <> "" Then
            f1.RichTextBox1.SelectedText = f1.RichTextBox1.SelectedText.Replace(f1.RichTextBox1.SelectedText, TextBox2.Text)
            kaishi = kaishi + Len(TextBox2.Text)
        End If
        '�滻�������һ��
        shou = TextBox1.Text
        If CheckBox1.Checked = True Then  '���ѡ����"���ִ�Сд"
            pos = InStr(kaishi, f1.RichTextBox1.Text, shou)
        Else                              '���û��ѡ��"���ִ�Сд"
            pos = InStr(kaishi, f1.RichTextBox1.Text.ToLower, shou.ToLower, CompareMethod.Text)
        End If
        If pos > 0 Then                   '����ҵ�����
            f1.RichTextBox1.Select(pos - 1, Len(shou))
        Else
            MsgBox("�Ҳ��� " & """" & shou & """", MsgBoxStyle.Information)
        End If
    End Sub
    'ʵ��"ȫ���滻"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        shou = TextBox1.Text
        f1.RichTextBox1.Text = f1.RichTextBox1.Text.Replace(shou, TextBox2.Text)
    End Sub
    '�����Ƿ����������ݾ�����ť�Ŀɲ�����
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        End If
    End Sub
    '�����ر�,�ô�������,�Ա��´ε���
    Private Sub Form3_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    '�����س�ʱ,ִ�в�����һ������
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim WM_KEYDOWN As Integer = 256
        Dim WM_SYSKEYDOWN As Integer = 260

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then

            Select Case keyData

                Case Keys.Enter
                    '�ػ񵽻س���
                    Call xiayige()
                    Return False


            End Select

        End If

    End Function
    'ʵ�ֲ�����һ���Ĺ��̴���
    Public Sub xiayige()
        kaishi = f1.RichTextBox1.SelectionStart + f1.RichTextBox1.SelectionLength + 1
        shou = TextBox1.Text
        If CheckBox1.Checked = True Then  '���ѡ����"���ִ�Сд"
            pos = InStr(kaishi, f1.RichTextBox1.Text, shou)
        Else                              '���û��ѡ��"���ִ�Сд"
            pos = InStr(kaishi, f1.RichTextBox1.Text.ToLower, shou.ToLower, CompareMethod.Text)
        End If
        If pos > 0 Then                   '����ҵ�����
            f1.RichTextBox1.Select(pos - 1, Len(shou))
        Else
            MsgBox("�Ҳ��� " & """" & shou & """", MsgBoxStyle.Information)
        End If
    End Sub
End Class
