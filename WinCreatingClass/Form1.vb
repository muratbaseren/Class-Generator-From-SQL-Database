#Region "Imports"
Imports System.Data.SqlClient
#End Region

Public Class Form1

#Region "Yerel Degiskenler"
    Private Conn As SqlConnection
    Private Cmd As SqlCommand
    Private ConnectionString As String = ""
#End Region

#Region "Olaylar"
    Private Sub cmbDatabases_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDatabases.Enter
        ConnectionString = ""

        If Me.txtSqlServer.Text = Nothing Then
            Me.txtSqlServer.Text = My.Computer.Name
        End If

        If Me.rdbWinAut.Checked Then
            ConnectionString = "Server=" & Me.txtSqlServer.Text & ";Database=master;Integrated Security=SSPI;"
        ElseIf Me.rdbSqlAut.Checked AndAlso Me.txtSqlServer.Text <> Nothing AndAlso Me.txtPassword.Text <> Nothing Then
            ConnectionString = "Server=" & Me.txtSqlServer.Text & ";Database=Master;User ID=" & Me.txtUserID.Text & ";Password=" & Me.txtPassword.Text & ";Trusted_Connection=False"
        End If

        Me.cmbDatabases.Items.Clear()

        Conn = New SqlConnection(ConnectionString)
        Cmd = New SqlCommand("select name from dbo.sysdatabases where dbid > 4 ", Conn)

        Dim Dr As SqlDataReader

        Try
            Conn.Open()
            Dr = Cmd.ExecuteReader

            Do While Dr.Read
                Me.cmbDatabases.Items.Add(Dr.Item(0).ToString)
            Loop

        Catch exSql As SqlException
            MessageBox.Show(exSql.Message.ToString, "SQL HATA !")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "GENEL HATA !")
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub rdbWinAut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbWinAut.CheckedChanged
        Me.pnlSqlAut.Enabled = False
    End Sub

    Private Sub rdbSqlAut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSqlAut.CheckedChanged
        Me.pnlSqlAut.Enabled = True
    End Sub

    Private Sub cmbDatabases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDatabases.SelectedIndexChanged

        If Me.rdbWinAut.Checked Then
            ConnectionString = "Server=" & Me.txtSqlServer.Text & ";Database=" & Me.cmbDatabases.SelectedItem.ToString & ";Integrated Security=SSPI;"
        ElseIf Me.rdbSqlAut.Checked Then
            ConnectionString = "Server=" & Me.txtSqlServer.Text & ";Database=" & Me.cmbDatabases.SelectedItem.ToString & ";User ID=" & Me.txtUserID.Text & ";Password=" & Me.txtPassword.Text & ";Trusted_Connection=False"
        End If

        If Not Me.cmbDatabases.SelectedIndex = -1 Then
            Conn = New SqlConnection(ConnectionString)
            Cmd = New SqlCommand("select name from " & Me.cmbDatabases.SelectedItem.ToString & ".dbo.sysobjects where xtype='U' and name<>'sysdiagrams'", Conn)

            Dim Dr As SqlDataReader
            Me.clbTables.Items.Clear()

            Try
                Conn.Open()
                Dr = Cmd.ExecuteReader

                Me.clbTables.Items.Add("All Tables")
                Do While Dr.Read
                    Me.clbTables.Items.Add(Dr.Item(0).ToString)
                Loop

            Catch exSql As SqlException
                MessageBox.Show(exSql.Message.ToString, "SQL HATA !")
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "GENEL HATA !")
            Finally
                Conn.Close()
            End Try
        End If

    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        Dim IsCreate As Boolean = False
        Dim TabPag As TabPage
        Dim txt As RichTextBox

        Try
            If Not Me.clbTables.Items.Count < 2 Then
                If Not Me.clbTables.CheckedItems.Count = 0 Then
                    For i As Integer = 0 To Me.clbTables.CheckedItems.Count - 1
                        If Not Me.clbTables.CheckedItems.Item(i).ToString = "All Tables" Then
                            IsCreate = False
                            For k As Integer = 0 To Me.TabControl1.TabPages.Count - 1
                                If Me.clbTables.CheckedItems.Item(i).ToString = Me.TabControl1.TabPages(k).Text Then
                                    IsCreate = True
                                End If
                            Next
                            If IsCreate = False Then
                                Dim DegiskenTipi As String = ""
                                Dim Degiskenler As String = ""
                                Dim strProperty As String = ""
                                Dim SubNewIsNullable As String = "Public Sub New( "
                                Dim SubNewIsNullableLine As String = ""
                                Dim SubNewAllColumns As String = "Public Sub New( "
                                Dim SubNewAllColumnsLine As String = ""
                                Dim AddSubNew As Boolean = True
                                Dim TableName As String = Me.clbTables.CheckedItems.Item(i).ToString

                                Conn = New SqlConnection(ConnectionString)
                                Cmd = New SqlCommand("select dbo.syscolumns.name,dbo.systypes.name,dbo.syscolumns.colstat,dbo.syscolumns.isnullable from dbo.syscolumns, dbo.systypes where id=object_id('" & TableName & "')and dbo.systypes.xtype=dbo.syscolumns.xtype and dbo.systypes.name<>'sysname' order by colorder", Conn)

                                Dim Dr As SqlDataReader

                                '
                                'TabPage ve Textbox olusumu...
                                '
                                TabPag = New TabPage
                                TabPag.Name = "tp" & TableName
                                TabPag.Text = TableName ' 'Me.clbTables.Items(1).ToString
                                txt = New RichTextBox
                                txt.Name = "txt" & TableName
                                txt.Multiline = True
                                txt.ScrollBars = ScrollBars.Both
                                txt.Dock = DockStyle.Fill

                                TabPag.Controls.Add(txt)

                                Me.TabControl1.TabPages.Add(TabPag)

                                '
                                'Textbox ilk degerleri giriþi..
                                '
                                txt.Text = "#Region " & Chr(34) & TableName & Chr(34) & vbCrLf & vbCrLf
                                txt.Text &= "Imports System.Data.SqlClient" & vbCrLf & vbCrLf
                                txt.Text &= "Public Class " & TableName & vbCrLf

                                Conn.Open()
                                Dr = Cmd.ExecuteReader

                                Do While Dr.Read
                                    If Not Dr.Item(2).ToString = 1 Then
                                        Select Case Dr.Item(1).ToString
                                            Case "Int"
                                                DegiskenTipi = "Integer"
                                            Case "bit"
                                                DegiskenTipi = "Boolean"
                                            Case "datetime", "smalldatetime"
                                                DegiskenTipi = "Date"
                                            Case Else
                                                DegiskenTipi = "String"
                                        End Select

                                        Degiskenler &= "    Private _" & Dr.Item(0).ToString & " As " & DegiskenTipi & vbCrLf

                                        If Dr.Item(3).ToString = 0 Then
                                            SubNewIsNullable &= "ByVal _" & Dr.Item(0).ToString & " As " & DegiskenTipi & ","
                                            SubNewIsNullableLine &= "       " & Dr.Item(0).ToString & " = _" & Dr.Item(0).ToString & vbCrLf
                                            AddSubNew = False
                                        End If

                                        strProperty &= "    Public Property " & Dr.Item(0).ToString & "() As " & DegiskenTipi & vbCrLf
                                        strProperty &= "        Get" & vbCrLf
                                        strProperty &= "            Return _" & Dr.Item(0).ToString & vbCrLf
                                        strProperty &= "        End Get" & vbCrLf
                                        strProperty &= "        Set(ByVal value As " & DegiskenTipi & ")" & vbCrLf
                                        strProperty &= "            _" & Dr.Item(0).ToString & " = value" & vbCrLf
                                        strProperty &= "        End Set" & vbCrLf
                                        strProperty &= "    End Property" & vbCrLf & vbCrLf

                                        SubNewAllColumns &= "ByVal _" & Dr.Item(0).ToString & " As " & DegiskenTipi & ","
                                        SubNewAllColumnsLine &= "       " & Dr.Item(0).ToString & " = _" & Dr.Item(0).ToString & vbCrLf
                                    End If
                                Loop

                                Degiskenler = vbCrLf & "#Region " & Chr(34) & "LocalVariables" & Chr(34) & vbCrLf & Degiskenler & vbCrLf & "# End Region" & vbCrLf
                                strProperty = vbCrLf & "#Region " & Chr(34) & "Properties" & Chr(34) & vbCrLf & strProperty & vbCrLf & "# End Region" & vbCrLf

                                If AddSubNew = False Then
                                    Dim EmptySubNew As String = ""
                                    EmptySubNew &= vbCrLf & "Public Sub New()" & vbCrLf & vbCrLf & "End Sub" & vbCrLf & vbCrLf
                                    strProperty &= EmptySubNew
                                End If

                                SubNewIsNullable = SubNewIsNullable.Remove(SubNewIsNullable.Length - 1, 1) & ")" & vbCrLf
                                SubNewIsNullable &= SubNewIsNullableLine
                                SubNewIsNullable &= "End Sub" & vbCrLf & vbCrLf

                                SubNewAllColumns = SubNewAllColumns.Remove(SubNewAllColumns.Length - 1, 1) & ")" & vbCrLf
                                SubNewAllColumns &= SubNewAllColumnsLine
                                SubNewAllColumns &= "End Sub" & vbCrLf & vbCrLf

                                txt.Text &= Degiskenler & strProperty & SubNewIsNullable & SubNewAllColumns
                                txt.Text &= "End Class" & vbCrLf & vbCrLf
                                txt.Text &= "#End Region"
                            End If
                        End If
                    Next

                    For i As Integer = 0 To 2
                        '
                        'TabPage ve RichTextBox olusumu...
                        'parameters,connection,DbOperation class larý için..
                        '
                       
                        Dim TabPageName As String = ""
                        Dim txtText As String = ""

                        Select Case i
                            Case 0
                                TabPageName = "Connection"
                            Case 1
                                TabPageName = "DbOperations"
                            Case 2
                                TabPageName = "parameters"
                            Case Else
                                TabPageName = ""
                        End Select

                        IsCreate = False
                        For k As Integer = 0 To Me.TabControl1.TabPages.Count - 1
                            If TabPageName = Me.TabControl1.TabPages(k).Text Then
                                IsCreate = True
                                Exit For
                            End If
                        Next
                        If IsCreate = False Then
                            TabPag = New TabPage
                            TabPag.Name = "tp" & TabPageName
                            TabPag.Text = TabPageName

                            txt = New RichTextBox
                            txt.Name = "txt" & TabPageName
                            txt.Multiline = True
                            txt.ScrollBars = ScrollBars.Both
                            txt.Dock = DockStyle.Fill
                            txtText = System.IO.File.ReadAllText(Application.StartupPath & "\" & TabPageName & ".txt")
                            txtText = txtText.Replace("@ConnectionString", ConnectionString)
                            txt.Text = txtText

                            'Richtextbox TabPage e eklenir..
                            TabPag.Controls.Add(txt)
                            'TabPage TabControl a eklenir..
                            Me.TabControl1.TabPages.Add(TabPag)
                        End If
                    Next
                End If
            End If

        Catch exSql As SqlException
            MessageBox.Show(exSql.Message.ToString, "SQL HATA !")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "GENEL HATA !")
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Me.txtSqlServer.Text = My.Computer.Name
        Me.rdbWinAut.Checked = True
        Me.cmbDatabases.Items.Clear()
        Me.clbTables.Items.Clear()
        Me.TabControl1.TabPages.Clear()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtSqlServer.Text = My.Computer.Name
    End Sub

    Private Sub clbTables_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clbTables.ItemCheck
        If e.Index = 0 Then
            If Me.clbTables.GetItemCheckState(0) = CheckState.Unchecked Then
                For i As Integer = 1 To Me.clbTables.Items.Count - 1
                    Me.clbTables.SetItemCheckState(i, CheckState.Checked)
                Next
            Else
                For i As Integer = 1 To Me.clbTables.Items.Count - 1
                    Me.clbTables.SetItemCheckState(i, CheckState.Unchecked)
                Next
            End If
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If Not Me.TabControl1.TabPages.Count = 0 Then
            'FolderBrowserDialog için baþlangýç path i veriliyor..
            Me.FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop
            'FolderBrowserDialog da ok butonuna basýlýrsa..
            If Me.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                'TabControl'deki herbir TabPage için dönülüyor..
                For i As Integer = 0 To Me.TabControl1.TabPages.Count - 1
                    'Bir RichTextBox deðiþkenine(rtb) o anki TabPage'deki RichTextBox kontrolü alýnýyor..
                    Dim rtb As RichTextBox = Me.TabControl1.TabPages(i).Controls(0)
                    'RichTextBox'ýn SaveFile metodundan yararlanýlarak RichTextBox'ýn içeriði kaydediliyor..
                    rtb.SaveFile(Me.FolderBrowserDialog1.SelectedPath & "\" & Me.TabControl1.TabPages(i).Text & ".vb", RichTextBoxStreamType.PlainText)
                Next
                MessageBox.Show("Tüm TabPage'ler Dosyalandý..", "Ýþlem Tamamlandý !", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("Kaydedilecek tablo class'ý oluþturulmamýþ..", "Ýþlem Baþarýsýz !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub cmnuCloseTabPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuCloseTabPage.Click
        Me.TabControl1.SelectedTab.Dispose()
    End Sub

    Private Sub cmnuOpenEmptyTabPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOpenEmptyTabPage.Click
        Dim EmptyTabPageName As String = InputBox("Yeni sekme için bir isim giriniz..", "Yeni Sekme Ýsmi", "Adsýz")

        Dim tp As TabPage = New TabPage
        Dim txt As RichTextBox = New RichTextBox
        txt.Dock = DockStyle.Fill

        tp.Name = "tp" & EmptyTabPageName
        tp.Text = EmptyTabPageName
        tp.Controls.Add(txt)
        Me.TabControl1.TabPages.Add(tp)
    End Sub
#End Region

End Class
