Public Class Form2
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
        Me.Label1.Text = "�������ݣ�(&N)"
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
        Me.Button1.Text = "������һ��(&F)"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ȡ��"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(16, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "���ִ�Сд(&C)"
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
        Me.GroupBox1.Text = "����"
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(80, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(56, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "����"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(8, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(56, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "����"
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
        Me.Text = "����"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '�����Ƿ����������ݾ�����ť�Ŀɲ�����
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then Button1.Enabled = True Else Button1.Enabled = False
    End Sub
    '"ȡ��"��ť,����close����hide����Ϊclose֮���´ξ��޷�show��
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    '������һ��
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call chazhaoxiayige()
    End Sub
    '�������
    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If shou <> "" Then
            TextBox1.Text = shou
        End If
        kaishi = f1.RichTextBox1.SelectionStart + f1.RichTextBox1.SelectionLength
    End Sub
    'ѡ��"����"ʱ
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Text = "������һ��(&F)"
    End Sub
    'ѡ��"����"ʱ
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Text = "������һ��(&F)"
    End Sub
    '�����ر�,�ô�������,�Ա��´ε���
    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    '�����س�ʱ,ִ�в��ҹ���
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim WM_KEYDOWN As Integer = 256
        Dim WM_SYSKEYDOWN As Integer = 260

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then

            Select Case keyData

                Case Keys.Enter
                    '�ػ񵽻س���
                    Call chazhaoxiayige()
                    Return False


            End Select

        End If

    End Function
    'ʵ�ֲ��ҵĹ��̴���
    Public Sub chazhaoxiayige()
        If RadioButton1.Checked = False Then   '���ѡ����"����"
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
        Else                                 '���ѡ����"����"
            kaishi = f1.RichTextBox1.SelectionStart + 1
            shou = TextBox1.Text
            If CheckBox1.Checked = True Then  '���ѡ����"���ִ�Сд"
                pos = InStrRev(f1.RichTextBox1.Text, shou, kaishi)
            Else                              '���û��ѡ��"���ִ�Сд"
                pos = InStrRev(f1.RichTextBox1.Text.ToLower, shou.ToLower, kaishi)
            End If
            If pos > 0 Then                  '����ҵ�����
                f1.RichTextBox1.Select(pos - 1, Len(shou))
            Else
                MsgBox("�Ҳ��� " & """" & shou & """", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class
