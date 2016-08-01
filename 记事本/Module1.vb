Module Module1
    '烦人的变量声明
    Public oldfilename As String
    Public newfilename As String
    Public biaoti As String
    Public chuxian, you, dd As Integer
    Public kaishi, pos As Integer
    Public shou As String
    Public zhtai As Boolean
    Public change, qingkong, gaga, rtfbool As Boolean
    Public zhongzhifu, hang As Integer
    Public xuanzhong As Long
    '以下四个定义尤其重要,这样定义之后才可以跨窗体引用控件和事件
    Public f1 As New Form1
    Public f2 As New Form2
    Public f3 As New Form3
    Public f4 As New Form4
    '程序的启动对象 Sub main 就是这里了
    Sub main()
        Application.Run(f1)
    End Sub
End Module
