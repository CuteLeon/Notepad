Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic
Public Class Form4
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
        Me.Label1.Text = "����(&L)��"
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
        Me.Button1.Text = "ȷ��"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ȡ��"
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
        Me.Text = "ת��������"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    '"ȡ��"��ť
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    '�����ر�,�ô�������,�Ա��´ε���
    Private Sub Form4_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    '�ж�ĳһ�ַ����Ƿ�ȫ��Ϊ���ֵ�Function
    Function haha(ByVal str As String) As String
        Dim i As Integer
        gaga = True
        For i = 1 To Len(str)
            If Not IsNumeric(Mid(str, i, 1)) Then
                gaga = False
            End If
        Next
    End Function
    '"ת��"��ť
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call zuandao()
    End Sub
    '�����س�ʱ,ִ��ת������
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim WM_KEYDOWN As Integer = 256
        Dim WM_SYSKEYDOWN As Integer = 260

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then

            Select Case keyData

                Case Keys.Enter
                    '�ػ񵽻س���
                    Call zuandao()
                    Return False


            End Select

        End If

    End Function
    'ʵ��"ת��"�Ĺ��̴���
    Public Sub zuandao()
        haha(TextBox1.Text)
        If gaga = False Then
            MsgBox("���ܰ����������ַ���", MsgBoxStyle.Critical) : Exit Sub
        End If
        If Val(TextBox1.Text) > hang Then
            MsgBox("����������Χ", , "���±� - ����") : Exit Sub
        End If

        Dim biaoqian, i, kk, in1 As Integer
        kk = 0
        biaoqian = 0
        For i = 1 To hang - 1            '˵��һ��:���"hang"���ǵ�ǰ���ݵ�������,��form1����ع��̻��ȡֵ
            biaoqian = InStr(biaoqian + 1, f1.RichTextBox1.Text, Chr(10))   '���һ��з�
            If biaoqian <> 0 Then kk = kk + 1 '���з�ÿ����һ��,����kk��ֵ��һ
            If kk = Val(TextBox1.Text) Then   '�����з�������(ʹ���������ֵ)�Ĵ���ʱ
                Exit For                    '�˳�ѭ��,ע���ʱ����biaoqian��ֵ�ǻ��з�����(ʹ���������ֵ)��ʱ���з���λ��
            End If
            in1 = biaoqian                 '����in1��ֵ���ǻ��з�����(ʹ���������ֵ-1)��ʱ���з���λ��
        Next i
        If biaoqian = 0 Then MsgBox("���в����ڻ�ǰֻ��һ��")
        f1.RichTextBox1.Select(in1, biaoqian - in1 - 1) '����궨λ��ָ����,����ѡ�и���
        f1.RichTextBox1.Focus()
    End Sub
End Class
