Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports Microsoft.VisualBasic

Public Class Form1
    Inherits System.Windows.Forms.Form


    Implements IMessageFilter

    ' API申明

    Const WM_DROPFILES = &H233  '拖放文件消息

    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)

    End Sub

    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)

    End Sub

    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer

    End Function


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
        Me.MenuItem1.Text = "文件(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MenuItem2.Text = "新建(&N)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MenuItem3.Text = "打开(&O)..."
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItem4.Text = "保存(&S)"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "另存为(&A)..."
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Text = "页面设置(&U)..."
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "打印(&P)..."
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 7
        Me.MenuItem9.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 8
        Me.MenuItem10.Text = "退出(&X)"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem35, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem53, Me.MenuItem18, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25})
        Me.MenuItem11.Text = "编辑(&E)"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem12.Text = "撤销(&U)"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 1
        Me.MenuItem35.Shortcut = System.Windows.Forms.Shortcut.CtrlY
        Me.MenuItem35.Text = "重复"
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
        Me.MenuItem14.Text = "剪切(&T)"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.MenuItem15.Text = "复制(&C)"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 5
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.MenuItem16.Text = "粘贴(&P)"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 6
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.Del
        Me.MenuItem17.Text = "删除(&L)"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 7
        Me.MenuItem53.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.MenuItem53.Text = "清空(&Q)"
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
        Me.MenuItem19.Text = "查找(&F)..."
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 10
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem20.Text = "查找下一个(&N)"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 11
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.MenuItem21.Text = "替换(&R)..."
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 12
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.CtrlG
        Me.MenuItem22.Text = "转到(&G)..."
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
        Me.MenuItem24.Text = "全选(&A)"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 15
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem25.Text = "时间/日期(&D)"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem27, Me.MenuItem28, Me.MenuItem50, Me.MenuItem51})
        Me.MenuItem26.Text = "格式(&O)"
        '
        'MenuItem27
        '
        Me.MenuItem27.Checked = True
        Me.MenuItem27.Index = 0
        Me.MenuItem27.Text = "自动换行(&W)"
        '
        'MenuItem28
        '
        Me.MenuItem28.Enabled = False
        Me.MenuItem28.Index = 1
        Me.MenuItem28.Text = "字体(&F)..."
        '
        'MenuItem50
        '
        Me.MenuItem50.Enabled = False
        Me.MenuItem50.Index = 2
        Me.MenuItem50.Text = "文字颜色..."
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 3
        Me.MenuItem51.Text = "背景颜色..."
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 3
        Me.MenuItem29.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem30, Me.MenuItem55, Me.MenuItem56, Me.MenuItem57})
        Me.MenuItem29.Text = "查看(&V)"
        '
        'MenuItem30
        '
        Me.MenuItem30.Enabled = False
        Me.MenuItem30.Index = 0
        Me.MenuItem30.Text = "状态栏(&S)"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 1
        Me.MenuItem55.Text = "关联TXT文件"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 2
        Me.MenuItem56.Text = "在右键添加菜单"
        '
        'MenuItem57
        '
        Me.MenuItem57.Checked = True
        Me.MenuItem57.Index = 3
        Me.MenuItem57.Text = "是否突出显示URL"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 4
        Me.MenuItem31.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem32, Me.MenuItem33, Me.MenuItem34})
        Me.MenuItem31.Text = "帮助(&H)"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 0
        Me.MenuItem32.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem32.Text = "帮助主题(&H)"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 1
        Me.MenuItem33.Text = "-"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 2
        Me.MenuItem34.Text = "关于记事本(&A)"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AllowDrop = True
        Me.RichTextBox1.AutoSize = True
        Me.RichTextBox1.ContextMenu = Me.ContextMenu1
        Me.RichTextBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
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
        Me.MenuItem36.Text = "撤销(&U)"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.Shortcut = System.Windows.Forms.Shortcut.CtrlY
        Me.MenuItem42.Text = "重复"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 2
        Me.MenuItem46.Text = "-"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 3
        Me.MenuItem52.Text = "字体..."
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 4
        Me.MenuItem54.Text = "文字颜色..."
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
        Me.MenuItem38.Text = "剪切(&T)"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 7
        Me.MenuItem39.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.MenuItem39.Text = "复制(&C)"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 8
        Me.MenuItem40.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.MenuItem40.Text = "粘贴(&P)"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 9
        Me.MenuItem41.Shortcut = System.Windows.Forms.Shortcut.Del
        Me.MenuItem41.Text = "删除(&L)"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 10
        Me.MenuItem43.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.MenuItem43.Text = "清空(&Q)"
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
        Me.MenuItem48.Text = "全选(&A)"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 13
        Me.MenuItem49.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem49.Text = "时间/日期(&D)"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 14
        Me.MenuItem44.Text = "-"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 15
        Me.MenuItem45.Text = "背景颜色..."
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckPathExists = False
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
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
        Me.zhong.Text = "总字符数:"
        Me.zhong.Width = 150
        '
        'xuanzhongde
        '
        Me.xuanzhongde.Name = "xuanzhongde"
        Me.xuanzhongde.Text = "当前选中:"
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
        Me.Text = "无标题 - 记事本"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zhong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xuanzhongde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    '文件拖放过程
    Overridable Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements IMessageFilter.PreFilterMessage
        Dim h1, h2 As Label
        On Error GoTo h1
        Dim i As Int16
        Dim sb As New System.Text.StringBuilder(256)
        DragQueryFile(m.WParam.ToInt32, i, sb, 256)
        If sb.ToString <> "" Then      '如果存在文件拖放操作
            If change = True Then    '如果当前内容被更改过
                Dim ret As Integer
                ret = (MsgBox("文件 " & biaoti & " 的文字已经改变。" & vbCrLf & " " & vbCrLf & "想保存文件吗?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel))
                If ret = 6 Then
                    Dim KeyDownHandler As EventHandler = AddressOf MenuItem4_Click  '此三行为调用事件MenuItem4_Click
                    AddHandler MenuItem4.Click, KeyDownHandler
                    KeyDownHandler.Invoke(Nothing, Nothing)

                ElseIf ret = 7 Then  '选了否
                    GoTo h2
                ElseIf ret = 2 Then  '选了否
                    DragFinish(m.WParam.ToInt32) '终止当前文件拖放过程
                    Exit Function
                End If
            End If
h2:
            oldfilename = sb.ToString  '将文件路径赋给变量oldfilename

            Dim shu1 As Integer
            Dim zhi1 As String
            shu1 = Len(oldfilename)
            zhi1 = Mid(oldfilename, shu1 - 2, 3)
            Call shebiaoti()            '设置窗体form1标题
            RichTextBox1.Clear()       '清空文本

            If zhi1 = "rtf" Then          '如果文件扩展名是rtf
                RichTextBox1.LoadFile(oldfilename)
                rtfbool = False
            Else                             '除了rtf以外的文件用以下方式打开
                DragFinish(m.WParam.ToInt32) '当文件类型不是rtf时,终止当前文件拖放过程,使用自己的方式打开文件
                Dim fs As New System.IO.FileStream(oldfilename, IO.FileMode.Open, IO.FileAccess.Read)

                Dim sr As New System.IO.StreamReader(fs, System.Text.Encoding.GetEncoding("gb2312"))
                RichTextBox1.AppendText(sr.ReadToEnd().ToString & ControlChars.CrLf)
                fs.Close()
                sr.Close()
            End If
            Call dakai()
        End If
        '以下实现Del键的后删除功能
        If m.WParam.ToInt32 = Keys.Delete Then  '注意:这个事件上包括了keydown和keyup.所以会执行两次,我用公用变量dd过滤了其中一次
            If RichTextBox1.SelectionLength = 0 And RichTextBox1.Text <> "" Then
                Dim abc As Integer
                dd = dd + 1
                If dd = 2 Then
                    abc = RichTextBox1.SelectionStart
                    RichTextBox1.Text = RichTextBox1.Text.Remove(abc, 1)
                    RichTextBox1.Select(abc, 0)  '删除之后定位光标在原处,否则会回到文档开头
                    dd = 0
                End If
            End If
        End If
        Exit Function
h1:     MsgBox(Err.Description)
    End Function
    '让richtextbox和状态栏随窗体大小改变而改变
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

        If change = True Then    '如果文件内容被更改过
            Dim ret As Integer
            ret = (MsgBox("文件 " & biaoti & " 的文字已经改变。" & vbCrLf & " " & vbCrLf & "想保存文件吗?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel))
            If ret = 6 Then
                Dim KeyDownHandler As EventHandler = AddressOf MenuItem4_Click  '此三行调用事件MenuItem4_Click
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
            OpenFileDialog1.Filter = "文本文件(*.txt),写字板文件(*.rtf)|*.txt;*.rtf|所有文件|*.*"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Title = "打开文件"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName = "" Then Exit Sub
            oldfilename = OpenFileDialog1.FileName
            Call shebiaoti()                             '设置窗体form1标题
            RichTextBox1.Clear()
            Dim shu1 As Integer
            Dim zhi1 As String
            shu1 = Len(oldfilename)
            zhi1 = Mid(oldfilename, shu1 - 2, 3)
            If zhi1 = "rtf" Then                        '如果文件扩展名是rtf
                RichTextBox1.LoadFile(oldfilename)
            Else                                        '除了rtf以外的文件用以下方式打开
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
    '另存文件
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim h1 As Label
        On Error GoTo h1
        If oldfilename <> "" Then                       '如果当前文档有路径(打开的文档)
            Dim shu2 As Integer
            Dim zhi2 As String
            shu2 = Len(oldfilename)
            zhi2 = Mid(oldfilename, shu2 - 2, 3)
            If zhi2 = "rtf" Then                       '根据已经打开的文件的类型,设置筛选器
                SaveFileDialog1.FilterIndex = 1
                SaveFileDialog1.FileName = ""
                SaveFileDialog1.Filter = "写字板文件(*.rtf)|*.rtf|文本文件(*.txt)|*.txt|所有文件|*.*"
                SaveFileDialog1.DefaultExt = "trf"
            ElseIf zhi2 = "txt" Then                  '根据已经打开的文件的类型,设置筛选器
                SaveFileDialog1.FilterIndex = 1
                SaveFileDialog1.FileName = ""
                SaveFileDialog1.Filter = "文本文件(*.txt)|*.txt|写字板文件(*.rtf)|*.rtf|所有文件|*.*"
                SaveFileDialog1.DefaultExt = "txt"
            End If
        Else                                        '如果当前文档没有路径(新建的文档)
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.FileName = ""
            SaveFileDialog1.Filter = "文本文件(*.txt)|*.txt|写字板文件(*.rtf)|*.rtf|所有文件|*.*"
            SaveFileDialog1.DefaultExt = ""
        End If
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.InitialDirectory = "c:\"
        SaveFileDialog1.Title = "保存文件"
        SaveFileDialog1.ShowDialog()
        '如果使用者选择了"所有文件"筛选项,将不再自动添加扩展名
        If SaveFileDialog1.FilterIndex = 3 Then SaveFileDialog1.AddExtension = False Else SaveFileDialog1.AddExtension = True
        If SaveFileDialog1.FileName = "" Then Exit Sub
        Dim shu1 As Integer
        Dim zhi1 As String
        shu1 = Len(SaveFileDialog1.FileName)
        zhi1 = Mid(SaveFileDialog1.FileName, shu1 - 2, 3)
        If zhi1 = "rtf" Then            '根据选择或输入的文件类型,用不同的方式另存文件
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText.RichText)
            oldfilename = SaveFileDialog1.FileName
            Call shebiaoti()
            change = False
        ElseIf zhi1 = "txt" Then        '根据选择或输入的文件类型,用不同的方式另存文件
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.TextTextOleObjs)
            oldfilename = SaveFileDialog1.FileName
            Call shebiaoti()
            change = False
        Else                             '根据选择或输入的文件类型,用不同的方式另存文件
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            oldfilename = SaveFileDialog1.FileName
            Call shebiaoti()
            change = False
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '设置字体
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub
    '退出
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Close()
    End Sub
    '复制
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        RichTextBox1.Copy()
    End Sub
    '撤销
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        RichTextBox1.Undo()
    End Sub
    '根据是否有选中,设置字体菜单和颜色菜单的允许状态
    Private Sub MenuItem26_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem26.Select
        If RichTextBox1.SelectionLength > 0 Then
            MenuItem28.Enabled = True
            MenuItem50.Enabled = True
        Else
            MenuItem28.Enabled = False
            MenuItem50.Enabled = False
        End If
    End Sub
    '全选
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        RichTextBox1.SelectAll()
    End Sub
    '在当前光标处插入日期/时间
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Dim st As String
        Dim ii As Integer
        ii = RichTextBox1.SelectionStart
        st = Now
        RichTextBox1.Focus()
        RichTextBox1.Text = RichTextBox1.Text.Insert(ii, st)
        RichTextBox1.Select(ii + st.Length, 0)
    End Sub
    '粘贴
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        RichTextBox1.Paste()
    End Sub
    '重复
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        RichTextBox1.Redo()
    End Sub
    '保存文件
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim h1 As Label
        On Error GoTo h1
        If oldfilename <> "" Then                      '如果原始路径存在
            Dim fi As New IO.FileInfo(oldfilename)
            If (IO.FileAttributes.ReadOnly And fi.Attributes) <> IO.FileAttributes.ReadOnly Then  '判断文件是否为只读文件,<>则表示不是只读
                Dim shu1 As Integer
                Dim zhi1 As String
                shu1 = Len(oldfilename)
                zhi1 = Mid(oldfilename, shu1 - 2, 3)
                If zhi1 = "rtf" Then                '根据已经打开的文件的类型,设置保存方法
                    RichTextBox1.SaveFile(oldfilename, RichTextBoxStreamType.RichText.RichText)
                    change = False
                ElseIf zhi1 = "txt" Then            '根据已经打开的文件的类型,设置保存方法
                    RichTextBox1.SaveFile(oldfilename, RichTextBoxStreamType.TextTextOleObjs)
                    change = False
                Else                                '根据已经打开的文件的类型,设置保存方法
                    RichTextBox1.SaveFile(oldfilename, RichTextBoxStreamType.PlainText)
                    change = False
                End If
            Else                                   '如果文件是只读文件
                If (MsgBox("文件 " & biaoti & " 为只读属性,是否另存?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                    Dim KeyDownHandler As EventHandler = AddressOf MenuItem5_Click  '另存为
                    AddHandler MenuItem5.Click, KeyDownHandler
                    KeyDownHandler.Invoke(Nothing, Nothing)
                Else
                    Exit Sub
                End If
            End If
        Else                               '如果原始路径不存在
            Dim KeyDownHandler As EventHandler = AddressOf MenuItem5_Click  '另存为
            AddHandler MenuItem5.Click, KeyDownHandler
            KeyDownHandler.Invoke(Nothing, Nothing)
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '剪切
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        RichTextBox1.Cut()
    End Sub
    '点击显示查找对话框
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        f2.Show()
    End Sub
    '关于
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        MsgBox("这是我用vb.net 2003写的一个高度仿真windows记事本程序." & vbCrLf & "并增加了支持rtf格式的功能:字体\文字颜色\图片显示\背景颜色" & vbCrLf & "添加 重复、清空、计算总字数和当前选中字数 功能" & vbCrLf & "可以关联TXT文件、添加到右键菜单、文件拖放操作", MsgBoxStyle.Information)
    End Sub

    '对内容进行编辑时,相关参数的动态更改
    Private Sub RichTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        If rtfbool = True Then
            change = True
        Else
            change = False
            rtfbool = True
        End If
        If RichTextBox1.Text <> "" Then qingkong = False
        '取得总字符数
        zhongzhifu = Len(RichTextBox1.Text)
        zhong.Text = "总字符数: " & zhongzhifu
        Dim int_ln As Integer                   '以下为取得总行数
        With RichTextBox1
            int_ln = .GetLineFromCharIndex(.TextLength)
        End With
        hang = int_ln + 1

    End Sub
    '窗体加载
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim h1 As Label
        On Error GoTo h1
        change = False
        qingkong = False
        biaoti = "无标题"
        Panel1.Width = Me.Width * 7 / 20
        Panel2.Width = Me.Width * 5 / 20
        zhong.Width = Me.Width * 4 / 20
        xuanzhongde.Width = Me.Width * 4 / 20
        zhtai = False
        rtfbool = True
        Application.AddMessageFilter(Me)

        DragAcceptFiles(RichTextBox1.Handle.ToInt32, True)
        kaishi = 1
        Panel2.Text = "行: " + "," + " 列: "
        hang = 1
        '以上为设置各参数的初始值
        Dim sty As String
        sty = Registry.Users.GetSubKeyNames(6)
        sty = Mid(sty, 1, Len(sty) - 8)
        Dim Reg, reg2 As RegistryKey
        Reg = Registry.Users.CreateSubKey(sty & "\Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.txt")
        Dim a, b As String
        a = Mid(Application.ExecutablePath, Len(Application.StartupPath) + 2)
        b = Reg.GetValue("Application")
        If b = a Then                    '如果条件一满足,进行下一个条件的判断
            reg2 = Registry.ClassesRoot.CreateSubKey("txtfile\shell\open\command")
            Dim a2, b2, c2, d2, e2 As String
            a2 = Application.ExecutablePath & " %1"
            b2 = reg2.GetValue("")
            If b2 = a2 Then             '如果条件二也满足
                MenuItem55.Checked = True
            Else
                MenuItem55.Checked = False
            End If
        End If
        '以上判断是否已经设置过文件关联,进而设置菜单MenuItem55的初始checked
        Dim Reg1 As RegistryKey
        Reg1 = Registry.ClassesRoot.CreateSubKey("*\shell")
        Dim a1, b1, c1 As String
        c1 = "记事本"
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
        '以上判断是否已经设置过右键菜单,进而设置菜单MenuItem56的初始checked

        Dim ss As String '定义一个字符变量    以下是文件关联的文件打开方法
        ss = Command() '获取双击的文件的路径
        If ss <> "" Then
            If InStr(1, ss, """", CompareMethod.Text) > 0 Then '如果路径中有双引号
                oldfilename = Mid(ss, 2, Len(ss) - 2) '去掉字符串两边的双引号
            Else
                oldfilename = ss
                MenuItem55.Checked = True
            End If
            Call shebiaoti()   '设置标题
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
        e.Cancel = True   '取消退出
        If change = True Then  '如果文件内容被更改过
            Dim ret As Integer
            ret = (MsgBox("文件 " & biaoti & " 的文字已经改变。" & vbCrLf & " " & vbCrLf & "想保存文件吗?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel))
            If ret = 6 Then   '如果选"是"
                If oldfilename <> "" Then   '如果原始路径存在
                    Dim KeyDownHandler As EventHandler = AddressOf MenuItem4_Click  ''此三行为调用事件MenuItem4_Click
                    AddHandler MenuItem4.Click, KeyDownHandler
                    KeyDownHandler.Invoke(Nothing, Nothing)
                    Application.RemoveMessageFilter(Me)
                    End
                    Exit Sub
                Else                       '如果原始路径不存在
                    Dim KeyDownHandler As EventHandler = AddressOf MenuItem5_Click  ''此三行为调用事件MenuItem5_Click
                    AddHandler MenuItem5.Click, KeyDownHandler
                    KeyDownHandler.Invoke(Nothing, Nothing)
                    Application.RemoveMessageFilter(Me)
                    End
                End If
            ElseIf ret = 7 Then  '如果选"否"
                Application.RemoveMessageFilter(Me)
                End
                Exit Sub
            ElseIf ret = 2 Then   '如果选"取消"
                Exit Sub
            End If
        Else
            End
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    Public Sub shebiaoti()
        newfilename = StrReverse(oldfilename) '反转字符
        chuxian = InStr(newfilename, "\") '查找字符"\"最后出现的位置
        chuxian = Len(oldfilename) + 1 - chuxian
        you = Len(oldfilename) - chuxian
        biaoti = Mid(oldfilename, chuxian + 1, you)
        Me.Text = biaoti & " - 记事本"  '设置标题
        change = False
    End Sub
    '新建文件
    Public Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim h1 As Label
        On Error GoTo h1
        If change = True Then    '如果文件内容被更改过
            Dim ret As Integer
            ret = (MsgBox("文件 " & biaoti & " 的文字已经改变。" & vbCrLf & " " & vbCrLf & "想保存文件吗?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel))
            If ret = 6 Then
                Dim KeyDownHandler As EventHandler = AddressOf MenuItem4_Click  '此三行为调用事件MenuItem4_Click
                AddHandler MenuItem4.Click, KeyDownHandler
                KeyDownHandler.Invoke(Nothing, Nothing)
                RichTextBox1.Clear()
                Me.Text = "无标题 - 记事本"
                oldfilename = ""
                change = False
                Exit Sub
            ElseIf ret = 7 Then
                RichTextBox1.Clear()
                Me.Text = "无标题 - 记事本"
                oldfilename = ""
                change = False
                Exit Sub
            ElseIf ret = 2 Then
                Exit Sub
            End If
        Else
            RichTextBox1.Clear()
            Me.Text = "无标题 - 记事本"
            oldfilename = ""
            change = False
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '删除(选定的内容)
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        RichTextBox1.SelectedText = ""
    End Sub
    '打印(该功能不知道能不能用)
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
    '页面设置(该功能不知道能不能用)
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim h1 As Label
        On Error GoTo h1
        Dim Doc As New System.Drawing.Printing.PrintDocument
        Doc.DocumentName = oldfilename
        PSDlg.Document = Doc  '页面设置对话框中需要设置调整的文档
        PSDlg.AllowOrientation = False  '不允许设置文档方向
        PSDlg.ShowDialog()   '显示页面设置对话框
        Exit Sub
h1:     MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
    '查找下一个
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
                        MsgBox("找不到 " & """" & shou & """", MsgBoxStyle.Information)
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
                        MsgBox("找不到 " & """" & shou & """", MsgBoxStyle.Information)
                    End If
                End If
            Else
                f2.Show()
            End If
        Else
            MsgBox("文本内容为空!无法查找!")
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '文字颜色
    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub
    '根据是否自动换行,判断查看状态栏是否可用
    Private Sub MenuItem29_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem29.Select
        If MenuItem27.Checked = False Then
            MenuItem30.Enabled = True
        Else
            MenuItem30.Enabled = False
        End If
    End Sub
    '显示\隐藏状态栏
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

    '获取鼠标点击处的行数和列数
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

            Panel2.Text = "行: " & (int_ln + 1).ToString & "," + " 列: " & int_col.ToString
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '设置背景颜色
    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub
    '清空
    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        RichTextBox1.Clear()
        qingkong = True
    End Sub
    '右键菜单>>撤销
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        RichTextBox1.Undo()
    End Sub
    '右键菜单>>重做
    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        RichTextBox1.Redo()
    End Sub
    '右键菜单>>剪切
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        RichTextBox1.Cut()
    End Sub
    '右键菜单>>复制
    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        RichTextBox1.Copy()
    End Sub
    '右键菜单>>粘贴
    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        RichTextBox1.Paste()
    End Sub
    '右键菜单>>删除
    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        RichTextBox1.SelectedText = ""
    End Sub
    '右键菜单>>清空
    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        RichTextBox1.Clear()
        qingkong = True
    End Sub
    '右键菜单>>全选
    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        RichTextBox1.SelectAll()
    End Sub
    '右键菜单>>日期/时间
    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Dim st As String
        Dim ii As Integer
        ii = RichTextBox1.SelectionStart
        st = Now
        RichTextBox1.Focus()
        RichTextBox1.Text = RichTextBox1.Text.Insert(ii, st)
        RichTextBox1.Select(ii + st.Length, 0)
    End Sub
    '右键菜单>>背景颜色
    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub
    '当点击右键时,先进行的判断
    Private Sub ContextMenu1_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenu1.Popup
        If RichTextBox1.SelectionLength > 0 Then   '如果有选中的内容
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
        If change = True And qingkong = False Then  '如果内容被更改,但没有清空
            MenuItem36.Enabled = True
            MenuItem42.Enabled = True
        Else
            MenuItem36.Enabled = False
            MenuItem42.Enabled = False
        End If
    End Sub
    '编辑菜单的下拉菜单的Enabled判断
    Private Sub MenuItem11_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem11.Select
        If RichTextBox1.SelectionLength > 0 Then     '如果有选中的内容
            MenuItem14.Enabled = True
            MenuItem15.Enabled = True
            MenuItem17.Enabled = True
        Else
            MenuItem14.Enabled = False
            MenuItem15.Enabled = False
            MenuItem17.Enabled = False
        End If
        If change = True And qingkong = False Then    '如果内容被更改,但没有清空
            MenuItem12.Enabled = True
            MenuItem35.Enabled = True
        Else
            MenuItem12.Enabled = False
            MenuItem35.Enabled = False
        End If
        If RichTextBox1.Text <> "" Then               '如果内容不为空
            MenuItem19.Enabled = True
            MenuItem20.Enabled = True
            MenuItem53.Enabled = True
        Else
            MenuItem19.Enabled = False
            MenuItem20.Enabled = False
            MenuItem53.Enabled = False
        End If
        If MenuItem27.Checked = False Then     '判断"自动换行"的选中状态
            MenuItem22.Enabled = True
        Else
            MenuItem22.Enabled = False
        End If
    End Sub

    Private Sub RichTextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyUp
        Dim h1 As Label
        On Error GoTo h1
        If StatusBar1.ShowPanels = True Then   '当用上、下、左、右键移动光标时,获取当前光标所在的行号和列号
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

                Panel2.Text = "行: " & (int_ln + 1).ToString & "," + " 列: " & int_col.ToString

            End If
        End If
        Exit Sub
h1:     MsgBox(Err.Description)
    End Sub
    '右键菜单>>字体
    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub
    '右键菜单>>文字颜色
    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    '打开"替换"对话框
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        f3.Show()
    End Sub
    '打开"转到"对话框
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        f4.Show()
    End Sub
    '获取当前选中的字符个数
    Private Sub RichTextBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseUp
        If StatusBar1.ShowPanels = True Then
            xuanzhong = RichTextBox1.SelectionLength
            xuanzhongde.Text = "当前选中: " & xuanzhong
        End If
    End Sub
    '设置\取消自动换行
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
    '关联TXT文件,通过WritteRgedit1—WritteRgedit2的修改注册表实现
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

    '添加/删除右键菜单,通过WritteRgedit3—WritteRgedit4的修改注册表实现
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
            Reg = Registry.ClassesRoot.CreateSubKey("*\shell\记事本\command")
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
            Reg = Registry.ClassesRoot.CreateSubKey("*\shell\记事本")
            If flag = True Then
                Reg.SetValue("", "用记事本打开")
            Else
                Reg = Registry.ClassesRoot.CreateSubKey("*\shell")
                Reg.DeleteSubKeyTree("记事本")
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '设置\取消突出显示URL
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
    '帮助主题
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        MsgBox("本软件是共享软件，不设版权，欢迎使用。" & vbCrLf & "但请不要用作商业目的，否则由此引起的一切后果自负" & vbCrLf & "本软件简单易用，相信您不会需要什么帮助文件的，呵呵" & vbCrLf & "软件名称：记事本", MsgBoxStyle.Information)
    End Sub

End Class
