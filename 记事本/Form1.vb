Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports Microsoft.VisualBasic

Public Class Form1
    Inherits System.Windows.Forms.Form


    Implements IMessageFilter

    ' API����

    Const WM_DROPFILES = &H233  '�Ϸ��ļ���Ϣ

    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)

    End Sub

    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)

    End Sub

    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer

    End Function


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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDlg As System.Windows.Forms.PrintDialog
    Friend WithEvents PSDlg As System.Windows.Forms.PageSetupDialog
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents Panel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents zhong As System.Windows.Forms.StatusBarPanel
    Friend WithEvents xuanzhongde As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintDlg = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PSDlg = New System.Windows.Forms.PageSetupDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.Panel1 = New System.Windows.Forms.StatusBarPanel()
        Me.zhong = New System.Windows.Forms.StatusBarPanel()
        Me.xuanzhongde = New System.Windows.Forms.StatusBarPanel()
        Me.Panel2 = New System.Windows.Forms.StatusBarPanel()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zhong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xuanzhongde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem11, Me.MenuItem26, Me.MenuItem29, Me.MenuItem31})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem10})
        Me.MenuItem1.Text = "�ļ�(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MenuItem2.Text = "�½�(&N)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MenuItem3.Text = "��(&O)..."
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItem4.Text = "����(&S)"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "���Ϊ(&A)..."
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Text = "ҳ������(&U)..."
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "��ӡ(&P)..."
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 7
        Me.MenuItem9.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 8
        Me.MenuItem10.Text = "�˳�(&X)"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem35, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem53, Me.MenuItem18, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25})
        Me.MenuItem11.Text = "�༭(&E)"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem12.Text = "����(&U)"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 1
        Me.MenuItem35.Shortcut = System.Windows.Forms.Shortcut.CtrlY
        Me.MenuItem35.Text = "�ظ�"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItem14.Text = "����(&T)"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.MenuItem15.Text = "����(&C)"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 5
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.MenuItem16.Text = "ճ��(&P)"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 6
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.Del
        Me.MenuItem17.Text = "ɾ��(&L)"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 7
        Me.MenuItem53.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.MenuItem53.Text = "���(&Q)"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 8
        Me.MenuItem18.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 9
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem19.Text = "����(&F)..."
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 10
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem20.Text = "������һ��(&N)"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 11
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.MenuItem21.Text = "�滻(&R)..."
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 12
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.CtrlG
        Me.MenuItem22.Text = "ת��(&G)..."
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 13
        Me.MenuItem23.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 14
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.MenuItem24.Text = "ȫѡ(&A)"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 15
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem25.Text = "ʱ��/����(&D)"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem27, Me.MenuItem28, Me.MenuItem50, Me.MenuItem51})
        Me.MenuItem26.Text = "��ʽ(&O)"
        '
        'MenuItem27
        '
        Me.MenuItem27.Checked = True
        Me.MenuItem27.Index = 0
        Me.MenuItem27.Text = "�Զ�����(&W)"
        '
        'MenuItem28
        '
        Me.MenuItem28.Enabled = False
        Me.MenuItem28.Index = 1
        Me.MenuItem28.Text = "����(&F)..."
        '
        'MenuItem50
        '
        Me.MenuItem50.Enabled = False
        Me.MenuItem50.Index = 2
        Me.MenuItem50.Text = "������ɫ..."
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 3
        Me.MenuItem51.Text = "������ɫ..."
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 3
        Me.MenuItem29.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem30, Me.MenuItem55, Me.MenuItem56, Me.MenuItem57})
        Me.MenuItem29.Text = "�鿴(&V)"
        '
        'MenuItem30
        '
        Me.MenuItem30.Enabled = False
        Me.MenuItem30.Index = 0
        Me.MenuItem30.Text = "״̬��(&S)"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 1
        Me.MenuItem55.Text = "����TXT�ļ�"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 2
        Me.MenuItem56.Text = "���Ҽ���Ӳ˵�"
        '
        'MenuItem57
        '
        Me.MenuItem57.Checked = True
        Me.MenuItem57.Index = 3
        Me.MenuItem57.Text = "�Ƿ�ͻ����ʾURL"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 4
        Me.MenuItem31.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem32, Me.MenuItem33, Me.MenuItem34})
        Me.MenuItem31.Text = "����(&H)"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 0
        Me.MenuItem32.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem32.Text = "��������(&H)"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 1
        Me.MenuItem33.Text = "-"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 2
        Me.MenuItem34.Text = "���ڼ��±�(&A)"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AllowDrop = True
        Me.RichTextBox1.AutoSize = True
        Me.RichTextBox1.ContextMenu = Me.ContextMenu1
        Me.RichTextBox1.Font = New System.Drawing.Font("����", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(600, 416)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem36, Me.MenuItem42, Me.MenuItem46, Me.MenuItem52, Me.MenuItem54, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40, Me.MenuItem41, Me.MenuItem43, Me.MenuItem47, Me.MenuItem48, Me.MenuItem49, Me.MenuItem44, Me.MenuItem45})
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 0
        Me.MenuItem36.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem36.Text = "����(&U)"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.Shortcut = System.Windows.Forms.Shortcut.CtrlY
        Me.MenuItem42.Text = "�ظ�"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 2
        Me.MenuItem46.Text = "-"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 3
        Me.MenuItem52.Text = "����..."
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 4
        Me.MenuItem54.Text = "������ɫ..."
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 5
        Me.MenuItem37.Text = "-"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 6
        Me.MenuItem38.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItem38.Text = "����(&T)"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 7
        Me.MenuItem39.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.MenuItem39.Text = "����(&C)"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 8
        Me.MenuItem40.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.MenuItem40.Text = "ճ��(&P)"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 9
        Me.MenuItem41.Shortcut = System.Windows.Forms.Shortcut.Del
        Me.MenuItem41.Text = "ɾ��(&L)"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 10
        Me.MenuItem43.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.MenuItem43.Text = "���(&Q)"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 11
        Me.MenuItem47.Text = "-"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 12
        Me.MenuItem48.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.MenuItem48.Text = "ȫѡ(&A)"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 13
        Me.MenuItem49.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem49.Text = "ʱ��/����(&D)"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 14
        Me.MenuItem44.Text = "-"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 15
        Me.MenuItem45.Text = "������ɫ..."
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckPathExists = False
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("����", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 395)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.Panel1, Me.zhong, Me.xuanzhongde, Me.Panel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(600, 22)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 1
        Me.StatusBar1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        '
        'zhong
        '
        Me.zhong.Name = "zhong"
        Me.zhong.Text = "���ַ���:"
        Me.zhong.Width = 150
        '
        'xuanzhongde
        '
        Me.xuanzhongde.Name = "xuanzhongde"
        Me.xuanzhongde.Text = "��ǰѡ��:"
        Me.xuanzhongde.Width = 150
        '
        'Panel2
        '
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Width = 150
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(600, 417)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�ޱ��� - ���±�"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zhong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xuanzhongde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    '�ļ��ϷŹ���
    Overridable Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements IMessageFilter.PreFilterMessage
        Dim h1, h2 As Label
        On Error GoTo h1
        Dim i As Int16
        Dim sb As New System.Text.StringBuilder(256)
        DragQueryFile(m.WParam.ToInt32, i, sb, 256)
        If sb.ToString <> "" Then      '��������ļ��ϷŲ���
            If change = True Then    '�����ǰ���ݱ����Ĺ�
                Dim ret As Integer
                ret = (MsgBox("�ļ� " & biaoti & " �������Ѿ��ı䡣" & vbCrLf & " " & vbCrLf & "�뱣���ļ���?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel))
                If ret = 6 Then
                    Dim KeyDownHandler As EventHandler = AddressOf MenuItem4_Click  '������Ϊ�����¼�MenuItem4_Click
                    AddHandler MenuItem4.Click, KeyDownHandler
                    KeyDownHandler.Invoke(Nothing, Nothing)

                ElseIf ret = 7 Then  'ѡ�˷�
                    GoTo h2
                ElseIf ret = 2 Then  'ѡ�˷�
                    DragFinish(m.WParam.ToInt32) '��ֹ��ǰ�ļ��ϷŹ���
                    Exit Function
                End If
            End If
h2:
            oldfilename = sb.ToString  '���ļ�·����������oldfilename

            Dim shu1 As Integer
            Dim zhi1 As String
            shu1 = Len(oldfilename)
            zhi1 = Mid(oldfilename, shu1 - 2, 3)
            Call shebiaoti()            '���ô���form1����
            RichTextBox1.Clear()       '����ı�

            If zhi1 = "rtf" Then          '����ļ���չ����rtf
                RichTextBox1.LoadFile(oldfilename)
                rtfbool = False
            Else                             '����rtf������ļ������·�ʽ��
                DragFinish(m.WParam.ToInt32) '���ļ����Ͳ���rtfʱ,��ֹ��ǰ�ļ��ϷŹ���,ʹ���Լ��ķ�ʽ���ļ�
                Dim fs As New System.IO.FileStream(oldfilename, IO.FileMode.Open, IO.FileAccess.Read)

                Dim sr As New System.IO.StreamReader(fs, System.Text.Encoding.GetEncoding("gb2312"))
                RichTextBox1.AppendText(sr.ReadToEnd().ToString & ControlChars.CrLf)
                fs.Close()
                sr.Close()
            End If
            Call dakai()
        End If
        '����ʵ��Del���ĺ�ɾ������
        If m.WParam.ToInt32 = Keys.Delete Then  'ע��:����¼��ϰ�����keydown��keyup.���Ի�ִ������,���ù��ñ���dd����������һ��
            If RichTextBox1.SelectionLength = 0 And RichTextBox1.Text <> "" Then
                Dim abc As Integer
                dd = dd + 1
                If dd = 2 Then
                    abc = RichTextBox1.SelectionStart
                    RichTextBox1.Text = RichTextBox1.Text.Remove(abc, 1)
                    RichTextBox1.Select(abc, 0)  'ɾ��֮��λ�����ԭ��,�����ص��ĵ���ͷ
                    dd = 0
                End If
            End If
        End If
        Exit Function
h1:     MsgBox(Err.Description)
    End Function
    '��richtextbox��״̬���洰���С�ı���ı�
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If zhtai = False Then
            RichTextBox1.Width = Me.Width - 8
            RichTextBox1.Height = Me.Height - 53
        Else
            RichTextBox1.Width = Me.Width - 8
            RichTextBox1.Height = Me.Height - 75
        End If
        Panel1.Width = Me.Width * 7 / 20
        Panel2.Width = Me.Width * 5 / 20
        zhong.Width = Me.Width * 4 / 20
        xuanzhongde.Width = Me.Width * 4 / 20
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim h1, h2 As Label
        On Error GoTo h1

        If change = True Then    '����ļ����ݱ����Ĺ�
            Dim ret As Integer
            ret = (MsgBox("�ļ� " & biaoti & " �������Ѿ��ı䡣" & vbCrLf & " " & vbCrLf & "�뱣���ļ���?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel))
            If ret = 6 Then
                Dim KeyDownHandler As EventHandler = AddressOf MenuItem4_Click  '�����е����¼�MenuItem4_Click
                AddHandler MenuItem4.Click, KeyDownHandler
                KeyDownHandler.Invoke(Nothing, Nothing)
                GoTo h2
            ElseIf ret = 7 Then
                GoTo h2
            ElseIf ret = 2 Then
                Exit Sub
            End If
        Else
h2:
            OpenFileDialog1.DefaultExt = ""
            OpenFileDialog1.Filter = "�ı��ļ�(*.txt),д�ְ��ļ�(*.rtf)|*.txt;*.rtf|�����ļ�|*.*"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Title = "���ļ�"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName = "" Then Exit Sub
            oldfilename = OpenFileDialog1.FileName
            Call shebiaoti()                             '���ô���form1����
            RichTextBox1.Clear()
            Dim shu1 As Integer
            Dim zhi1 As String
            shu1 = Len(oldfilename)
            zhi1 = Mid(oldfilename, shu1 - 2, 3)
            If zhi1 = "rtf" Then                        '����ļ���չ����rtf
                RichTextBox1.LoadFile(oldfilename)
            Else                                        '����rtf������ļ������·�ʽ��
                Dim fs As New System.IO.FileStream(oldfilename, IO.FileMode.Open, IO.FileAccess.Read)

                Dim sr As New System.IO.StreamReader(fs, System.Text.Encoding.GetEncoding("gb2312"))
                RichTextBox1.AppendText(sr.ReadToEnd.ToString & ControlChars.CrLf)
                fs.Close()
                sr.Close()

            End If
            Call dakai()
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '����ļ�
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim h1 As Label
        On Error GoTo h1
        If oldfilename <> "" Then                       '�����ǰ�ĵ���·��(�򿪵��ĵ�)
            Dim shu2 As Integer
            Dim zhi2 As String
            shu2 = Len(oldfilename)
            zhi2 = Mid(oldfilename, shu2 - 2, 3)
            If zhi2 = "rtf" Then                       '�����Ѿ��򿪵��ļ�������,����ɸѡ��
                SaveFileDialog1.FilterIndex = 1
                SaveFileDialog1.FileName = ""
                SaveFileDialog1.Filter = "д�ְ��ļ�(*.rtf)|*.rtf|�ı��ļ�(*.txt)|*.txt|�����ļ�|*.*"
                SaveFileDialog1.DefaultExt = "trf"
            ElseIf zhi2 = "txt" Then                  '�����Ѿ��򿪵��ļ�������,����ɸѡ��
                SaveFileDialog1.FilterIndex = 1
                SaveFileDialog1.FileName = ""
                SaveFileDialog1.Filter = "�ı��ļ�(*.txt)|*.txt|д�ְ��ļ�(*.rtf)|*.rtf|�����ļ�|*.*"
                SaveFileDialog1.DefaultExt = "txt"
            End If
        Else                                        '�����ǰ�ĵ�û��·��(�½����ĵ�)
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.FileName = ""
            SaveFileDialog1.Filter = "�ı��ļ�(*.txt)|*.txt|д�ְ��ļ�(*.rtf)|*.rtf|�����ļ�|*.*"
            SaveFileDialog1.DefaultExt = ""
        End If
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.InitialDirectory = "c:\"
        SaveFileDialog1.Title = "�����ļ�"
        SaveFileDialog1.ShowDialog()
        '���ʹ����ѡ����"�����ļ�"ɸѡ��,�������Զ������չ��
        If SaveFileDialog1.FilterIndex = 3 Then SaveFileDialog1.AddExtension = False Else SaveFileDialog1.AddExtension = True
        If SaveFileDialog1.FileName = "" Then Exit Sub
        Dim shu1 As Integer
        Dim zhi1 As String
        shu1 = Len(SaveFileDialog1.FileName)
        zhi1 = Mid(SaveFileDialog1.FileName, shu1 - 2, 3)
        If zhi1 = "rtf" Then            '����ѡ���������ļ�����,�ò�ͬ�ķ�ʽ����ļ�
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText.RichText)
            oldfilename = SaveFileDialog1.FileName
            Call shebiaoti()
            change = False
        ElseIf zhi1 = "txt" Then        '����ѡ���������ļ�����,�ò�ͬ�ķ�ʽ����ļ�
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.TextTextOleObjs)
            oldfilename = SaveFileDialog1.FileName
            Call shebiaoti()
            change = False
        Else                             '����ѡ���������ļ�����,�ò�ͬ�ķ�ʽ����ļ�
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            oldfilename = SaveFileDialog1.FileName
            Call shebiaoti()
            change = False
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '��������
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub
    '�˳�
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Close()
    End Sub
    '����
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        RichTextBox1.Copy()
    End Sub
    '����
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        RichTextBox1.Undo()
    End Sub
    '�����Ƿ���ѡ��,��������˵�����ɫ�˵�������״̬
    Private Sub MenuItem26_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem26.Select
        If RichTextBox1.SelectionLength > 0 Then
            MenuItem28.Enabled = True
            MenuItem50.Enabled = True
        Else
            MenuItem28.Enabled = False
            MenuItem50.Enabled = False
        End If
    End Sub
    'ȫѡ
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        RichTextBox1.SelectAll()
    End Sub
    '�ڵ�ǰ��괦��������/ʱ��
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Dim st As String
        Dim ii As Integer
        ii = RichTextBox1.SelectionStart
        st = Now
        RichTextBox1.Focus()
        RichTextBox1.Text = RichTextBox1.Text.Insert(ii, st)
        RichTextBox1.Select(ii + st.Length, 0)
    End Sub
    'ճ��
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        RichTextBox1.Paste()
    End Sub
    '�ظ�
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        RichTextBox1.Redo()
    End Sub
    '�����ļ�
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim h1 As Label
        On Error GoTo h1
        If oldfilename <> "" Then                      '���ԭʼ·������
            Dim fi As New IO.FileInfo(oldfilename)
            If (IO.FileAttributes.ReadOnly And fi.Attributes) <> IO.FileAttributes.ReadOnly Then  '�ж��ļ��Ƿ�Ϊֻ���ļ�,<>���ʾ����ֻ��
                Dim shu1 As Integer
                Dim zhi1 As String
                shu1 = Len(oldfilename)
                zhi1 = Mid(oldfilename, shu1 - 2, 3)
                If zhi1 = "rtf" Then                '�����Ѿ��򿪵��ļ�������,���ñ��淽��
                    RichTextBox1.SaveFile(oldfilename, RichTextBoxStreamType.RichText.RichText)
                    change = False
                ElseIf zhi1 = "txt" Then            '�����Ѿ��򿪵��ļ�������,���ñ��淽��
                    RichTextBox1.SaveFile(oldfilename, RichTextBoxStreamType.TextTextOleObjs)
                    change = False
                Else                                '�����Ѿ��򿪵��ļ�������,���ñ��淽��
                    RichTextBox1.SaveFile(oldfilename, RichTextBoxStreamType.PlainText)
                    change = False
                End If
            Else                                   '����ļ���ֻ���ļ�
                If (MsgBox("�ļ� " & biaoti & " Ϊֻ������,�Ƿ����?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                    Dim KeyDownHandler As EventHandler = AddressOf MenuItem5_Click  '���Ϊ
                    AddHandler MenuItem5.Click, KeyDownHandler
                    KeyDownHandler.Invoke(Nothing, Nothing)
                Else
                    Exit Sub
                End If
            End If
        Else                               '���ԭʼ·��������
            Dim KeyDownHandler As EventHandler = AddressOf MenuItem5_Click  '���Ϊ
            AddHandler MenuItem5.Click, KeyDownHandler
            KeyDownHandler.Invoke(Nothing, Nothing)
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '����
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        RichTextBox1.Cut()
    End Sub
    '�����ʾ���ҶԻ���
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        f2.Show()
    End Sub
    '����
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        MsgBox("��������vb.net 2003д��һ���߶ȷ���windows���±�����." & vbCrLf & "��������֧��rtf��ʽ�Ĺ���:����\������ɫ\ͼƬ��ʾ\������ɫ" & vbCrLf & "��� �ظ�����ա������������͵�ǰѡ������ ����" & vbCrLf & "���Թ���TXT�ļ�����ӵ��Ҽ��˵����ļ��ϷŲ���", MsgBoxStyle.Information)
    End Sub

    '�����ݽ��б༭ʱ,��ز����Ķ�̬����
    Private Sub RichTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        If rtfbool = True Then
            change = True
        Else
            change = False
            rtfbool = True
        End If
        If RichTextBox1.Text <> "" Then qingkong = False
        'ȡ�����ַ���
        zhongzhifu = Len(RichTextBox1.Text)
        zhong.Text = "���ַ���: " & zhongzhifu
        Dim int_ln As Integer                   '����Ϊȡ��������
        With RichTextBox1
            int_ln = .GetLineFromCharIndex(.TextLength)
        End With
        hang = int_ln + 1

    End Sub
    '�������
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim h1 As Label
        On Error GoTo h1
        change = False
        qingkong = False
        biaoti = "�ޱ���"
        Panel1.Width = Me.Width * 7 / 20
        Panel2.Width = Me.Width * 5 / 20
        zhong.Width = Me.Width * 4 / 20
        xuanzhongde.Width = Me.Width * 4 / 20
        zhtai = False
        rtfbool = True
        Application.AddMessageFilter(Me)

        DragAcceptFiles(RichTextBox1.Handle.ToInt32, True)
        kaishi = 1
        Panel2.Text = "��: " + "," + " ��: "
        hang = 1
        '����Ϊ���ø������ĳ�ʼֵ
        Dim sty As String
        sty = Registry.Users.GetSubKeyNames(6)
        sty = Mid(sty, 1, Len(sty) - 8)
        Dim Reg, reg2 As RegistryKey
        Reg = Registry.Users.CreateSubKey(sty & "\Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.txt")
        Dim a, b As String
        a = Mid(Application.ExecutablePath, Len(Application.StartupPath) + 2)
        b = Reg.GetValue("Application")
        If b = a Then                    '�������һ����,������һ���������ж�
            reg2 = Registry.ClassesRoot.CreateSubKey("txtfile\shell\open\command")
            Dim a2, b2, c2, d2, e2 As String
            a2 = Application.ExecutablePath & " %1"
            b2 = reg2.GetValue("")
            If b2 = a2 Then             '���������Ҳ����
                MenuItem55.Checked = True
            Else
                MenuItem55.Checked = False
            End If
        End If
        '�����ж��Ƿ��Ѿ����ù��ļ�����,�������ò˵�MenuItem55�ĳ�ʼchecked
        Dim Reg1 As RegistryKey
        Reg1 = Registry.ClassesRoot.CreateSubKey("*\shell")
        Dim a1, b1, c1 As String
        c1 = "���±�"
        a1 = Reg1.GetSubKeyNames.Length
        If a1 >= 1 Then
            Dim j As Integer, you As Boolean
            you = False
            For j = 1 To a1
                b1 = Reg1.GetSubKeyNames(j - 1)
                If b1 = c1 Then you = True
            Next
            If you = True Then MenuItem56.Checked = True Else MenuItem56.Checked = False
        End If
        '�����ж��Ƿ��Ѿ����ù��Ҽ��˵�,�������ò˵�MenuItem56�ĳ�ʼchecked

        Dim ss As String '����һ���ַ�����    �������ļ��������ļ��򿪷���
        ss = Command() '��ȡ˫�����ļ���·��
        If ss <> "" Then
            If InStr(1, ss, """", CompareMethod.Text) > 0 Then '���·������˫����
                oldfilename = Mid(ss, 2, Len(ss) - 2) 'ȥ���ַ������ߵ�˫����
            Else
                oldfilename = ss
                MenuItem55.Checked = True
            End If
            Call shebiaoti()   '���ñ���
            RichTextBox1.Clear()
            Dim shu1 As Integer
            Dim zhi1 As String
            shu1 = Len(oldfilename)
            zhi1 = Mid(oldfilename, shu1 - 2, 3)
            If zhi1 = "rtf" Then
                RichTextBox1.LoadFile(oldfilename)
            Else
                Dim fs As New System.IO.FileStream(oldfilename, IO.FileMode.Open, IO.FileAccess.Read)

                Dim sr As New System.IO.StreamReader(fs, System.Text.Encoding.GetEncoding("gb2312"))
                RichTextBox1.AppendText(sr.ReadToEnd().ToString & ControlChars.CrLf)
                fs.Close()
                sr.Close()
            End If
            Call dakai()
        End If
            Exit Sub
h1:         MsgBox(Err.Description)
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim h1 As Label
        On Error GoTo h1
        e.Cancel = True   'ȡ���˳�
        If change = True Then  '����ļ����ݱ����Ĺ�
            Dim ret As Integer
            ret = (MsgBox("�ļ� " & biaoti & " �������Ѿ��ı䡣" & vbCrLf & " " & vbCrLf & "�뱣���ļ���?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel))
            If ret = 6 Then   '���ѡ"��"
                If oldfilename <> "" Then   '���ԭʼ·������
                    Dim KeyDownHandler As EventHandler = AddressOf MenuItem4_Click  ''������Ϊ�����¼�MenuItem4_Click
                    AddHandler MenuItem4.Click, KeyDownHandler
                    KeyDownHandler.Invoke(Nothing, Nothing)
                    Application.RemoveMessageFilter(Me)
                    End
                    Exit Sub
                Else                       '���ԭʼ·��������
                    Dim KeyDownHandler As EventHandler = AddressOf MenuItem5_Click  ''������Ϊ�����¼�MenuItem5_Click
                    AddHandler MenuItem5.Click, KeyDownHandler
                    KeyDownHandler.Invoke(Nothing, Nothing)
                    Application.RemoveMessageFilter(Me)
                    End
                End If
            ElseIf ret = 7 Then  '���ѡ"��"
                Application.RemoveMessageFilter(Me)
                End
                Exit Sub
            ElseIf ret = 2 Then   '���ѡ"ȡ��"
                Exit Sub
            End If
        Else
            End
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    Public Sub shebiaoti()
        newfilename = StrReverse(oldfilename) '��ת�ַ�
        chuxian = InStr(newfilename, "\") '�����ַ�"\"�����ֵ�λ��
        chuxian = Len(oldfilename) + 1 - chuxian
        you = Len(oldfilename) - chuxian
        biaoti = Mid(oldfilename, chuxian + 1, you)
        Me.Text = biaoti & " - ���±�"  '���ñ���
        change = False
    End Sub
    '�½��ļ�
    Public Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim h1 As Label
        On Error GoTo h1
        If change = True Then    '����ļ����ݱ����Ĺ�
            Dim ret As Integer
            ret = (MsgBox("�ļ� " & biaoti & " �������Ѿ��ı䡣" & vbCrLf & " " & vbCrLf & "�뱣���ļ���?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel))
            If ret = 6 Then
                Dim KeyDownHandler As EventHandler = AddressOf MenuItem4_Click  '������Ϊ�����¼�MenuItem4_Click
                AddHandler MenuItem4.Click, KeyDownHandler
                KeyDownHandler.Invoke(Nothing, Nothing)
                RichTextBox1.Clear()
                Me.Text = "�ޱ��� - ���±�"
                oldfilename = ""
                change = False
                Exit Sub
            ElseIf ret = 7 Then
                RichTextBox1.Clear()
                Me.Text = "�ޱ��� - ���±�"
                oldfilename = ""
                change = False
                Exit Sub
            ElseIf ret = 2 Then
                Exit Sub
            End If
        Else
            RichTextBox1.Clear()
            Me.Text = "�ޱ��� - ���±�"
            oldfilename = ""
            change = False
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    'ɾ��(ѡ��������)
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        RichTextBox1.SelectedText = ""
    End Sub
    '��ӡ(�ù��ܲ�֪���ܲ�����)
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim h1 As Label
        On Error GoTo h1
        Dim DocName As New Drawing.Printing.PrintDocument
        DocName.DocumentName = oldfilename
        PrintDlg.Document = DocName
        PrintDlg.AllowSelection = True
        PrintDlg.AllowSomePages = True
        PrintDlg.ShowDialog()
        Exit Sub
h1:     MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
    'ҳ������(�ù��ܲ�֪���ܲ�����)
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim h1 As Label
        On Error GoTo h1
        Dim Doc As New System.Drawing.Printing.PrintDocument
        Doc.DocumentName = oldfilename
        PSDlg.Document = Doc  'ҳ�����öԻ�������Ҫ���õ������ĵ�
        PSDlg.AllowOrientation = False  '�����������ĵ�����
        PSDlg.ShowDialog()   '��ʾҳ�����öԻ���
        Exit Sub
h1:     MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
    '������һ��
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Dim h1 As Label
        On Error GoTo h1
        If RichTextBox1.Text <> "" Then
            If f2.TextBox1.Text <> "" Then
                If f2.RadioButton1.Checked = False Then
                    kaishi = f1.RichTextBox1.SelectionStart + f1.RichTextBox1.SelectionLength
                    If f2.CheckBox1.Checked = True Then
                        pos = InStr(kaishi, f1.RichTextBox1.Text, shou, CompareMethod.Text)
                    Else
                        pos = InStr(kaishi, f1.RichTextBox1.Text.ToLower(), shou.ToLower, CompareMethod.Text)
                    End If
                    If pos > 0 Then
                        f1.RichTextBox1.Select(pos - 1, Len(shou))

                    Else
                        MsgBox("�Ҳ��� " & """" & shou & """", MsgBoxStyle.Information)
                    End If
                Else
                    kaishi = f1.RichTextBox1.SelectionStart
                    If f2.CheckBox1.Checked = True Then
                        pos = InStrRev(f1.RichTextBox1.Text, shou, kaishi)
                    Else
                        pos = InStrRev(f1.RichTextBox1.Text.ToLower, shou.ToLower, kaishi)
                    End If
                    If pos > 0 Then
                        f1.RichTextBox1.Select(pos - 1, Len(shou))
                    Else
                        MsgBox("�Ҳ��� " & """" & shou & """", MsgBoxStyle.Information)
                    End If
                End If
            Else
                f2.Show()
            End If
        Else
            MsgBox("�ı�����Ϊ��!�޷�����!")
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '������ɫ
    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub
    '�����Ƿ��Զ�����,�жϲ鿴״̬���Ƿ����
    Private Sub MenuItem29_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem29.Select
        If MenuItem27.Checked = False Then
            MenuItem30.Enabled = True
        Else
            MenuItem30.Enabled = False
        End If
    End Sub
    '��ʾ\����״̬��
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        If MenuItem30.Checked = True Then
            MenuItem30.Checked = False
        Else
            MenuItem30.Checked = True
        End If
        If MenuItem30.Checked = True Then

            StatusBar1.ShowPanels = True
            StatusBar1.Visible = True
            RichTextBox1.Height = RichTextBox1.Height - 22
            zhtai = True
        Else
            StatusBar1.ShowPanels = False
            StatusBar1.Visible = False

            RichTextBox1.Height = RichTextBox1.Height + 22
            zhtai = False
        End If
    End Sub

    '��ȡ�������������������
    Private Sub RichTextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseDown
        Dim h1 As Label
        On Error GoTo h1
        If StatusBar1.ShowPanels = True Then
            Dim int_ln As Integer
            Dim int_col As Integer
            Dim offset As Integer
            With RichTextBox1
                int_ln = .GetLineFromCharIndex(.SelectionStart)
                offset = 1
                If int_ln > 0 Then
                    While AscW(.Text.Chars(.SelectionStart - offset)) <> 10
                        offset += 1
                    End While
                    int_col = offset
                Else
                    int_col = .SelectionStart
                End If
            End With

            Panel2.Text = "��: " & (int_ln + 1).ToString & "," + " ��: " & int_col.ToString
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '���ñ�����ɫ
    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub
    '���
    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        RichTextBox1.Clear()
        qingkong = True
    End Sub
    '�Ҽ��˵�>>����
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        RichTextBox1.Undo()
    End Sub
    '�Ҽ��˵�>>����
    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        RichTextBox1.Redo()
    End Sub
    '�Ҽ��˵�>>����
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        RichTextBox1.Cut()
    End Sub
    '�Ҽ��˵�>>����
    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        RichTextBox1.Copy()
    End Sub
    '�Ҽ��˵�>>ճ��
    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        RichTextBox1.Paste()
    End Sub
    '�Ҽ��˵�>>ɾ��
    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        RichTextBox1.SelectedText = ""
    End Sub
    '�Ҽ��˵�>>���
    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        RichTextBox1.Clear()
        qingkong = True
    End Sub
    '�Ҽ��˵�>>ȫѡ
    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        RichTextBox1.SelectAll()
    End Sub
    '�Ҽ��˵�>>����/ʱ��
    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Dim st As String
        Dim ii As Integer
        ii = RichTextBox1.SelectionStart
        st = Now
        RichTextBox1.Focus()
        RichTextBox1.Text = RichTextBox1.Text.Insert(ii, st)
        RichTextBox1.Select(ii + st.Length, 0)
    End Sub
    '�Ҽ��˵�>>������ɫ
    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub
    '������Ҽ�ʱ,�Ƚ��е��ж�
    Private Sub ContextMenu1_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenu1.Popup
        If RichTextBox1.SelectionLength > 0 Then   '�����ѡ�е�����
            MenuItem38.Enabled = True
            MenuItem39.Enabled = True
            MenuItem41.Enabled = True
            MenuItem52.Enabled = True
            MenuItem54.Enabled = True
        Else
            MenuItem38.Enabled = False
            MenuItem39.Enabled = False
            MenuItem41.Enabled = False
            MenuItem52.Enabled = False
            MenuItem54.Enabled = False
        End If
        If change = True And qingkong = False Then  '������ݱ�����,��û�����
            MenuItem36.Enabled = True
            MenuItem42.Enabled = True
        Else
            MenuItem36.Enabled = False
            MenuItem42.Enabled = False
        End If
    End Sub
    '�༭�˵��������˵���Enabled�ж�
    Private Sub MenuItem11_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem11.Select
        If RichTextBox1.SelectionLength > 0 Then     '�����ѡ�е�����
            MenuItem14.Enabled = True
            MenuItem15.Enabled = True
            MenuItem17.Enabled = True
        Else
            MenuItem14.Enabled = False
            MenuItem15.Enabled = False
            MenuItem17.Enabled = False
        End If
        If change = True And qingkong = False Then    '������ݱ�����,��û�����
            MenuItem12.Enabled = True
            MenuItem35.Enabled = True
        Else
            MenuItem12.Enabled = False
            MenuItem35.Enabled = False
        End If
        If RichTextBox1.Text <> "" Then               '������ݲ�Ϊ��
            MenuItem19.Enabled = True
            MenuItem20.Enabled = True
            MenuItem53.Enabled = True
        Else
            MenuItem19.Enabled = False
            MenuItem20.Enabled = False
            MenuItem53.Enabled = False
        End If
        If MenuItem27.Checked = False Then     '�ж�"�Զ�����"��ѡ��״̬
            MenuItem22.Enabled = True
        Else
            MenuItem22.Enabled = False
        End If
    End Sub

    Private Sub RichTextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyUp
        Dim h1 As Label
        On Error GoTo h1
        If StatusBar1.ShowPanels = True Then   '�����ϡ��¡����Ҽ��ƶ����ʱ,��ȡ��ǰ������ڵ��кź��к�
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
                Dim int_ln As Integer
                Dim int_col As Integer
                Dim offset As Integer
                With RichTextBox1
                    int_ln = .GetLineFromCharIndex(.SelectionStart)
                    offset = 1
                    If int_ln > 0 Then
                        While AscW(.Text.Chars(.SelectionStart - offset)) <> 10
                            offset += 1
                        End While
                        int_col = offset
                    Else
                        int_col = .SelectionStart
                    End If
                End With

                Panel2.Text = "��: " & (int_ln + 1).ToString & "," + " ��: " & int_col.ToString

            End If
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '�Ҽ��˵�>>����
    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub
    '�Ҽ��˵�>>������ɫ
    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    '��"�滻"�Ի���
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        f3.Show()
    End Sub
    '��"ת��"�Ի���
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        f4.Show()
    End Sub
    '��ȡ��ǰѡ�е��ַ�����
    Private Sub RichTextBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseUp
        If StatusBar1.ShowPanels = True Then
            xuanzhong = RichTextBox1.SelectionLength
            xuanzhongde.Text = "��ǰѡ��: " & xuanzhong
        End If
    End Sub
    '����\ȡ���Զ�����
    Private Sub MenuItem27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        If MenuItem27.Checked = True Then
            MenuItem27.Checked = False
        Else
            MenuItem27.Checked = True
        End If
        If MenuItem27.Checked = True Then RichTextBox1.WordWrap = True
        If MenuItem27.Checked = False Then RichTextBox1.WordWrap = False

        DragAcceptFiles(RichTextBox1.Handle.ToInt32, True)
    End Sub
    '����TXT�ļ�,ͨ��WritteRgedit1��WritteRgedit2���޸�ע���ʵ��
    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        If MenuItem55.Checked = True Then
            MenuItem55.Checked = False
        Else
            MenuItem55.Checked = True
        End If
        Dim regbiao As Boolean
        regbiao = MenuItem55.Checked
        Call WritteRgedit1(regbiao)
        Call WritteRgedit2(regbiao)
    End Sub

    Public Function WritteRgedit1(ByVal flag As Boolean) As Boolean
        Dim Reg As RegistryKey
        Try
            Reg = Registry.ClassesRoot.CreateSubKey("txtfile\shell\open\command")
            If flag = True Then
                Reg.SetValue("", Application.ExecutablePath & " %1")
            Else
                Reg.SetValue("", "%SystemRoot%\system32\NOTEPAD.EXE %1")
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function WritteRgedit2(ByVal flag As Boolean) As Boolean
        Dim sty As String
        sty = Registry.Users.GetSubKeyNames(6)
        sty = Mid(sty, 1, Len(sty) - 8)
        Dim Reg As RegistryKey
        Try
            Reg = Registry.Users.CreateSubKey(sty & "\Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.txt")
            If flag = True Then
                Dim a As String
                a = Mid(Application.ExecutablePath, Len(Application.StartupPath) + 2)
                Reg.SetValue("Application", a)
            Else
                Reg.SetValue("Application", "NOTEPAD.EXE")
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '���/ɾ���Ҽ��˵�,ͨ��WritteRgedit3��WritteRgedit4���޸�ע���ʵ��
    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        If MenuItem56.Checked = True Then
            MenuItem56.Checked = False
        Else
            MenuItem56.Checked = True
        End If
        Dim regbiao As Boolean
        regbiao = MenuItem56.Checked
        Call WritteRgedit3(regbiao)
        Call WritteRgedit4(regbiao)
    End Sub
    Public Function WritteRgedit3(ByVal flag As Boolean) As Boolean
        Dim Reg As RegistryKey
        Try
            Reg = Registry.ClassesRoot.CreateSubKey("*\shell\���±�\command")
            If flag = True Then
                Reg.SetValue("", Application.ExecutablePath & " %1")
            Else
                Reg.SetValue("", "")
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function WritteRgedit4(ByVal flag As Boolean) As Boolean
        Dim Reg As RegistryKey
        Try
            Reg = Registry.ClassesRoot.CreateSubKey("*\shell\���±�")
            If flag = True Then
                Reg.SetValue("", "�ü��±���")
            Else
                Reg = Registry.ClassesRoot.CreateSubKey("*\shell")
                Reg.DeleteSubKeyTree("���±�")
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '����\ȡ��ͻ����ʾURL
    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        If MenuItem57.Checked = True Then
            MenuItem57.Checked = False
        Else
            MenuItem57.Checked = True
        End If
        If MenuItem57.Checked = True Then RichTextBox1.DetectUrls = True Else RichTextBox1.DetectUrls = False
    End Sub

    Public Sub dakai()
        zhongzhifu = Len(RichTextBox1.Text)
        RichTextBox1.Select(0, 0)
        change = False
        Dim int_ln As Integer
        With RichTextBox1
            int_ln = .GetLineFromCharIndex(.TextLength)
        End With
        hang = int_ln + 1
    End Sub
    '��������
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        MsgBox("������ǹ�������������Ȩ����ӭʹ�á�" & vbCrLf & "���벻Ҫ������ҵĿ�ģ������ɴ������һ�к���Ը�" & vbCrLf & "����������ã�������������Ҫʲô�����ļ��ģ��Ǻ�" & vbCrLf & "������ƣ����±�", MsgBoxStyle.Information)
    End Sub

End Class
