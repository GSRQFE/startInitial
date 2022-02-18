Imports System.IO
Public Class QFE_Securities
    Public totalQ As Single
    Public totalavgQ As Single
    Public totaliters As Long
    Public cntCl As Long
    Public totclval As Single
    Friend WithEvents TableLayout As TableLayoutPanel
    Public oleDBSymbols As OleDb.OleDbCommand
    Public oleDBBase As OleDb.OleDbCommand
    Public oleDBZScore As OleDb.OleDbCommand
    Public oleDBStats As OleDb.OleDbCommand
    Public oleDBStats1 As OleDb.OleDbCommand
    Public oleDBMovAvg As OleDb.OleDbCommand
    Public oleDBSparkLines As OleDb.OleDbCommand
    Public oleDBSignals As OleDb.OleDbCommand
    Public oleDBTrades As OleDb.OleDbCommand
    Public oleConnBase As System.Data.OleDb.OleDbConnection
    Public oleConnZScore As System.Data.OleDb.OleDbConnection
    Public oleConnStats As System.Data.OleDb.OleDbConnection
    Public oleConnStats1 As System.Data.OleDb.OleDbConnection
    Public oleConnMovAvg As System.Data.OleDb.OleDbConnection
    Public oleConnSparklines As System.Data.OleDb.OleDbConnection
    Public oleConnSignals As System.Data.OleDb.OleDbConnection
    Public oleConnTrades As System.Data.OleDb.OleDbConnection
    Public fStrBase As String, fStrCurrent As String
    Public coFStrBase As String, coFStrCurrent As String
    Private Sub Securities_LoadList_Base()
        Static xNo As Integer
        Dim xx As Integer, xx1 As Integer, y As Integer
        xNo = 0
        Me.SecuritiesList.Items.Clear()
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(fStrBase)
            CounterDM.SecNo = 0
            CounterDM.startSecs = DateAndTime.Timer
            xNo += 1
            Me.SecNo_.Text = Format$(xNo, "0000")
            Text = "Working " & foundFile & "  Sec#:" & Format(xNo, "0000")
            CounterDM.fn = foundFile
            xx = InStr(CounterDM.fn, fStrBase) + 38
            If xx = 0 Then Stop
            '     xx1 = InStr(SymbolData.fileString, "_SMART")
            CounterDM.secSymbol = CounterDM.fn.Substring(xx)
            xx1 = InStr(CounterDM.secSymbol, "_")
            CounterDM.secSymbol = Strings.Left(CounterDM.secSymbol, xx1 - 1)
            CounterDM.secSymbol = Strings.Left(CounterDM.secSymbol & "_____", 6)
            Me.txtSymbol.Text = CounterDM.secSymbol
            '     SecuritiesArray(xNo, 1) = CounterDM.secSymbol
            Dim lbl = New Label
            With lbl
                .Name = "lbl" & y
                .TextAlign = ContentAlignment.MiddleCenter
                lbl.Text = "bbb" '"Value: " & SecuritiesArray.GetValue(y, 1) & y
                .Dock = DockStyle.Fill
                .AutoSize = True
            End With
            '      Me.securitiespanel.Controls.Add(lbl)
            '      Me.securitiespanel.Rows.Add()
            CounterDM.Records = CountRecordsDailySecurities(1, CounterDM.fn)
            CounterDM.Days = CounterDM.Records
            CounterDM.first_DayNo = 1
            CounterDM.first_DayNo = 1
            CounterDM.last_DayNo = CounterDM.Days
            CounterDM.last_DayNo = CounterDM.last_DayNo
            '    Dim task = New Task(AddressOf Process_Files)
            Call Process_Files(1, CounterDM.fn)
            Call MovAvgDay.InitMovAvg()
            CounterDM.first_DayDate = DayDTstr2_(CounterDM.first_DayNo)
            CounterDM.last_DayDate = DayDTstr2_(CounterDM.last_DayNo)
            CounterDM.this_DayDate = CounterDM.last_DayDate
            Text = "Working " & foundFile &
                    "  Sec#:" & Format(xNo, "0000") & "records=" &
                     Format(CounterDM.Records, "00000")
            Call MovAvgDayUp1(True)
            '            RMain.SP.BandH.Text = "bh01A_" & .bEntryDay.Text & .sExitDay.Text
            SecuritiesList.Items.Add(CounterDM.secSymbol & DayDOWStr_(CounterDM.Days))
        Next
        Me.SecuritiesList.Update()
    End Sub
    Private Sub Prepare_DataBaseFiles()
        FileClose(1)
        FileClose(2)
        Application.DoEvents()
        'If My.Computer.FileSystem.FileExists("z:\QFE_Table.mdb") Then
        'File.Delete("D:\QFE_Table.mdb")
        'End If
        ' File.Copy("z:\qfe_signalsbase.mdb",
        '               "D:\Signalsbase\QFE_SignalsBase.mdb")
        If My.Computer.FileSystem.FileExists("d:\QFE_SignalsBaseKeys.mdb") Then
            File.Delete("d:\QFE_SignalsBasekeys.mdb")
        End If
        File.Copy("d:\qfe_signalsbasekeys_be.mdb",
                      "d:\QFE_SignalsBasekeys.mdb")
        REM--symbols
        ' oleDatabaseSymbols = New OleDb.OleDbCommand
        'oleConnSymbols = New OleDb.OleDbConnection
        'oleConnSymbols.ConnectionString =
        '    "Provider=Microsoft.JET.OLEDB.4.0;" &
        '     "Data Source=C:\QFE_Base\QFE_Signals1.mdb;"
        'oleDatabaseSymbols.Connection = oleConnSymbols
        'oleConnSymbols.Open()
        'dbSymbols.Text = oleDatabaseSymbols.Connection.ConnectionString
        'dbSymbols.ForeColor = Color.Wheat
        'dbSymbols.BackColor = Color.BurlyWood
        '        Text = "Deleting Symbols . . ." & Now
        '       oleConnSymbols.Close()
        '      oleDatabaseSymbols.CommandText = "DELETE FROM Symbols"
        '     oleConnSymbols.Open()
        '    oleDatabaseSymbols.ExecuteNonQuery()
        ' My.Computer.FileSystem.GetFiles("c:\Data")
        '        ReDim SecuritiesArray(SymbolData.secNumber + 1, 2)
        oleDBBase = New OleDb.OleDbCommand
        oleConnBase = New OleDb.OleDbConnection
        oleConnBase.ConnectionString =
            "Provider=Microsoft.JET.OLEDB.4.0;" &
             "Data Source=d:\QFE_SignalsBaseKeys.mdb;"
        oleDBBase.Connection = oleConnBase
        oleConnBase.Open()
        oleDBBase.CommandText = "DELETE FROM Base"
        oleDBBase.ExecuteNonQuery()
        REM
        oleDBZScore = New OleDb.OleDbCommand
        oleConnZScore = New OleDb.OleDbConnection
        oleConnZScore.ConnectionString =
            "Provider=Microsoft.JET.OLEDB.4.0;" &
             "Data Source=d:\QFE_SignalsBaseKeys.mdb;"
        oleDBZScore.Connection = oleConnZScore
        oleConnZScore.Open()
        oleDBZScore.CommandText = "DELETE FROM ZScore"
        oleDBZScore.ExecuteNonQuery()
        REM
        oleDBStats = New OleDb.OleDbCommand
        oleConnStats = New OleDb.OleDbConnection
        oleConnStats.ConnectionString =
            "Provider=Microsoft.JET.OLEDB.4.0;" &
             "Data Source=d:\QFE_SignalsBaseKeys.mdb;"
        oleDBStats.Connection = oleConnStats
        oleConnStats.Open()
        oleDBStats.CommandText = "DELETE FROM Stats"
        oleDBStats.ExecuteNonQuery()
        REM
        oleDBStats1 = New OleDb.OleDbCommand
        oleConnStats1 = New OleDb.OleDbConnection
        oleConnStats1.ConnectionString =
            "Provider=Microsoft.JET.OLEDB.4.0;" &
             "Data Source=d:\QFE_SignalsBaseKeys.mdb;"
        oleDBStats1.Connection = oleConnStats
        oleConnStats1.Open()
        oleDBStats1.CommandText = "DELETE FROM Stats"
        oleDBStats1.ExecuteNonQuery()
        REM
        oleDBMovAvg = New OleDb.OleDbCommand
        oleConnMovAvg = New OleDb.OleDbConnection
        oleConnMovAvg.ConnectionString =
            "Provider=Microsoft.JET.OLEDB.4.0;" &
             "Data Source=d:\QFE_SignalsBasekeys.mdb;"
        oleDBMovAvg.Connection = oleConnMovAvg
        oleConnMovAvg.Open()
        oleDBMovAvg.CommandText = "DELETE FROM MovAvg"
        oleDBMovAvg.ExecuteNonQuery()
        REM
        oleDBSignals = New OleDb.OleDbCommand
        oleConnSignals = New OleDb.OleDbConnection
        oleConnSignals.ConnectionString =
            "Provider=Microsoft.JET.OLEDB.4.0;" &
             "Data Source=d:\QFE_SignalsBaseKeys.mdb;"
        oleDBSignals.Connection = oleConnSignals
        oleConnSignals.Open()
        oleDBSignals.CommandText = "DELETE FROM Signals"
        oleDBSignals.ExecuteNonQuery()
        Application.DoEvents()
        REM
        oleDBSparkLines = New OleDb.OleDbCommand
        oleConnSparklines = New OleDb.OleDbConnection
        oleConnSparklines.ConnectionString =
            "Provider=Microsoft.JET.OLEDB.4.0;" &
             "Data Source=d:\QFE_SignalsBaseKeys.mdb;"
        oleDBSparkLines.Connection = oleConnSparklines
        oleConnSparklines.Open()
        oleDBSparkLines.CommandText = "DELETE FROM SparkLines"
        oleDBSparkLines.ExecuteNonQuery()
        Application.DoEvents()
    End Sub
    REM
    Private Sub Securities_LoadList_Current(ByRef q As Boolean)
        Dim td As String
        CounterDM.startSecs = DateAndTime.Timer
        Call Prepare_DataBaseFiles()
        CounterDM.runTime = TimeOfDay()
        Me.SecuritiesList.Items.Clear()
        CounterDM.SecNo = 0
        td = ThisDate.Value.Year & Format(ThisDate.Value.Month, "00") & Format(ThisDate.Value.Day, "00")
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(fStrCurrent)
            If InStr(foundFile, ".txt") > 0 Then
                CounterDM.fn = foundFile
                CounterDM.SecNo = CounterDM.SecNo + 1
                '           On Error GoTo skipfile
                Me.txtSymbol.Text = foundFile
                CounterDM.secIterations = 0
                If SecuritiesListBox.GetItemChecked(CounterDM.SecNo - 1) Then
                    Call LoadList(q)
skipfile:
                End If
            End If
        Next
    End Sub
    REM
    Public Sub LoadList(q As Boolean)
        Static txt As String
        CounterDM.Days = 0
        SecuritiesListBox.SelectedItem = CounterDM.SecNo - 1
        Me.SecNo_.Text = Format$(CounterDM.SecNo, "0000")
        Call Process_Files(1, CounterDM.fn)
        CounterDM.secSymbol = GetSymbol(CounterDM.fn)
        Symbol1.Text = CounterDM.secSymbol
        RMain.Symbol = CounterDM.secSymbol
        Call MovAvgDay.InitMovAvg()
        '  SecuritiesArray(CounterDM.SecNo, 1) = CounterDM.secSymbol
        CounterDM.Records = CountRecordsDailySecurities(1, CounterDM.fn)
        If CounterDM.Records > 100 Then
            CounterDM.last_DayDate = DayDTstr2_(CounterDM.last_DayNo)
            If CounterDM.Records < Me.NumberofDays.Value Then
                CounterDM.Days = CounterDM.Records
            Else
                CounterDM.Days = Me.NumberofDays.Value
            End If
            CounterDM.start_DayNo = 1
            CounterDM.start_DayDate = DayDTStr2(CounterDM.start_DayNo)
            StartDayNo.Text = CounterDM.start_DayNo
            StartDayDate.Text = CounterDM.start_DayDate
            CounterDM.end_DayNo = CounterDM.last_DayNo
            CounterDM.end_DayDate = DayDTStr2(CounterDM.end_DayNo)
            Me.EndDayNo.Text = Format$(CounterDM.end_DayNo, "000000")
            Me.EndDayDate.Text = CounterDM.end_DayDate
            CounterDM.first_DayNo = CounterDM.Records - Me.NumberofDays.Value
            If CounterDM.first_DayNo < 90 Then
                CounterDM.first_DayNo = 90
            End If
            FirstDayNo.Text = CounterDM.first_DayNo
            CounterDM.first_DayDate = DayDTStr2(CounterDM.first_DayNo)
            LastDayNo.Text = CounterDM.last_DayNo
            CounterDM.last_DayDate = DayDTStr2(CounterDM.last_DayNo)
            FirstDayDate.Text = CounterDM.first_DayDate
            LastDayDate.Text = CounterDM.last_DayDate
            CounterDM.this_DayNo = CounterDM.last_DayNo
            ThisDayNo.Text = CounterDM.this_DayNo
            CounterDM.this_DayDate = DayDTStr2(CounterDM.this_DayNo)
            ThisDayDate.Text = CounterDM.this_DayDate
            Text = "Working " & CounterDM.secSymbol & " Sec#:" & Format(CounterDM.SecNo, "0000") &
                        "records=" & Format(CounterDM.Records, "00000")
            Cl0nOp.Text = Format("0.000")
            nOp0nCl.Text = Format("0.000")
            nOp0nnCl.Text = Format("0.000")
            Call DoDOW(q)
            'Call xxx
            txt = Strings.Left(CounterDM.secSymbol & ":" & DayDOWStr_(CounterDM.Days), 15)
            SecuritiesList.Items.Add(txt)
        End If
    End Sub


    Private Sub Put_SymbolSecurities(ByRef SD As Symbol_Data)
        With SD
            thisIncr = thisIncr + 1
            oleDBSymbols.CommandText =
  "Insert Into symbols VALUES (
    '" & thisIncr &
    "','" & .secNumber &
    "','" & .Symbol &
     "','" & .SymDOW &
     "','" & .DOW &
   "','" & .Days &
    "','" & .Records &
    "','" & .totRecords &
    "','" & .lClnCld &
    "','" & .lClnnOpd &
    "','" & .lClnnCld &
    "','" & .lOpnClZ0d &
    "','" & .lOpnnOpZ0d &
    "','" & .nOpnClZ0d &
    "','" & .nOpnnOpZ0d &
    "','" & .nOpnnCld &
    "','" & .nOpnnnOpd &
    "','" & .nOpnnnCld &
    "','" & .nnOpnnCld &
    "','" & .nnOpnnnOpd &
    "','" & .nnOpnnnCld &
    "','" & .nClnnOpZ0d &
    "','" & .nClnnClZ0d &
    "','" & .nnClnnnOpd &
    "','" & .nnClnnnCld &
    "','" & .firstDay &
    "','" & .firstDate &
    "','" & .lastDay &
    "','" & .lastDate &
   "','" & .fileString &
   "','" & Now() & "')"
        End With
    End Sub
    Private Sub SecuritiesList_Click(sender As Object, e As EventArgs) Handles SecuritiesList.Click
        'Stop
    End Sub
    Public Sub NewSecuritiesPanel()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoSize = True
        '        SecuritiesPanel1 = New TableLayoutPanel
        With TableLayout
            .Name = "SecuritiesPanel"
            .Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
            .ColumnCount = 0
            .RowCount = 0
            .Dock = DockStyle.Fill
            .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            .AutoSize = True
        End With
        Me.Controls.Add(TableLayout)
    End Sub

    Private Sub AddData(logck As Integer)
        Dim r As New DataGridViewRow
        Dim rt As New DataGridViewTextBoxCell
        Dim rc As New DataGridViewCheckBoxCell
        Call Process_Files(1, CounterDM.fn)
        CounterDM.secSymbol = getSymbol(CounterDM.fn)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM.SecNo
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM.this_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM.secSymbol
        r.Cells.Add(rt)
        rc = New DataGridViewCheckBoxCell
        rc.TrueValue = True
        logck = 0
        If CounterDM.last_DayDate = CounterDM.this_DayDate Then
            logck = 1
            CounterDM.end_DayNo = CounterDM.last_DayNo
            CounterDM.end_DayDate = DayDTStr2(CounterDM.end_DayNo)
        End If
        If CounterDM.last_DayDate > CounterDM.this_DayDate Then
            CounterDM.last_DayNo = CounterDM.last_DayNo - 1
            CounterDM.last_DayDate = DayDTStr2(CounterDM.last_DayNo)
            CounterDM.end_DayNo = CounterDM.last_DayNo
            CounterDM.end_DayDate = DayDTStr2(CounterDM.end_DayNo)
            logck = 1
        End If
        rc.Value = logck
        r.Cells.Add(rc)
        rt = New DataGridViewTextBoxCell
        rt.Value = Format(CounterDM.Records, "0000")
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM.first_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM.last_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = Format(CounterDM.daysUp, "0000")
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = Format(CounterDM.daysDown, "0000")
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = DayDOWStr_(CounterDM.last_DayNo)
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        CounterDM.first_DayDate = DayDTstr2_(CounterDM.first_DayNo)
        rt.Value = CounterDM.first_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM.last_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM.secSymbol
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.MaxInputLength = 99
        rt.Value = Now.TimeOfDay
        r.Cells.Add(rt)
        Me.SymbolGridViewCurrent.Rows.Add(r)
    End Sub

    Public Sub AddData1(ByRef R1 As Results)
        Dim r As New DataGridViewRow
        Dim rt As New DataGridViewTextBoxCell
        Dim rc As New DataGridViewCheckBoxCell
        totaliters = totaliters + 1
        totalQ = totalQ + R1.SS.Q.avg
        totalavgQ = totalQ / totaliters
        rt = New DataGridViewTextBoxCell
        rt.Value = RMain.Symbol
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = RMain.maStr
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = RMain.SP.bDOW.Text
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = RMain.SP.bZScrModeDay.Text & ":" & RMain.SP.bZScrOffsetDay
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = RMain.SP.bInDay.Text
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = RMain.SP.bEntryDay.Text
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = Format(R1.SS.avgDH, "00.00")
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = RMain.SP.sExitDay.Text
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM.secIterations
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = totaliters
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = StrSign3(R1.SS.Q.avg)
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = StrSign3(totalQ)
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = StrSign3(totalavgQ)
        r.Cells.Add(rt)
        DGSignalsByEntry.Rows.Add(r)
    End Sub
    Private Sub SecuritiesPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'QFE_SignalsBaseDataSet1.Base' table. You can move, or remove it, as needed.
        'Me.BaseTableAdapter.Fill(Me.QFE_SignalsBaseDataSet1.Base)
        Call Rdoparameters()
        CounterDM.this_DayDate = Year(Now) & Format(Month(Now), "00") &
            Format(Microsoft.VisualBasic.DateAndTime.Day(Now), "00")
        'fStr = "C:\QFE_Base\Data\"
        '        fStrBase = "C:\jTWSdata_1401_inJh\SignalsBase\Data\"
        '       fStrBase = "C:\Users\grego\Dropbox\QFEData"
        '       fStrBase = "C:\Users\grego\Dropbox\QFEData"
        fStrBase = "C:\jTWSdata_1401_inJh\jTWSdata_1401\Data"
        Me.BaseDataFiles.Text = fStrBase
        Application.DoEvents()
        ' fStrCurrent = "C:\Data"
        fStrCurrent = fStrBase
        CurrentDataFiles.Text = fStrCurrent
        coFStrCurrent = fStrCurrent
        Me.txtSymbol.Text = fStrBase
        Call readData(fStrCurrent, 1)
        Application.DoEvents()
    End Sub
    Private Sub ReadData(dirStr As String, ByRef which As Integer)
        Static x As Integer
        Dim tststr As String
        FileClose(1)
        Application.DoEvents()
        Select Case which
            Case = 0
                Me.SymbolGridViewBase.Rows.Clear()
            Case = 1
                Me.SymbolGridViewCurrent.Rows.Clear()
            Case Else
                Stop
        End Select
        Dim rt As New DataGridViewTextBoxCell
        Dim rc As New DataGridViewCheckBoxCell
        Dim r As New DataGridViewRow
        rt.Value = "Symbol"
        r.Cells.Add(rt)
        '   rc.Value = is
        r.Cells.Add(rc)
        Me.SymbolGridViewCurrent.Rows.Clear()
        Me.SecuritiesListBox.Items.Clear()
        Me.CoSecuritiesListBox.Items.Clear()
        CounterDM.SecNo = 0
        For Each foundFile As String In
            My.Computer.FileSystem.GetFiles(dirStr)
            CounterDM.fn = foundFile
            CounterDM.SecNo = CounterDM.SecNo + 1
            If InStr(foundFile, ".txt") > 0 Then
                Call Process_Files(1, foundFile)
                If qAdjustForAfterMidNight.Checked = True Then
                    If CounterDM.end_DayDate < CounterDM.end_DayDate Then
                        Stop
                        CounterDM.last_DayDate = CounterDM.end_DayDate
                        CounterDM.last_DayNo = CounterDM.last_DayNo
                    End If
                End If
                Call AddData(1)
                tststr = CounterDM.secSymbol & ":" & CounterDM.end_DayDate & ":" _
                        & CounterDM.last_DayDate & ":" & DayDOWNo_(CounterDM.last_DayNo)
                SecuritiesListBox.Items.Add(tststr)
                CoSecuritiesListBox.Items.Add(tststr)
                x = SecuritiesListBox.Items.Count
                SecuritiesListBox.SelectedItem = x - 1
                '                xststr = SecuritiesListBox.GetItemChecked(x - 1)
                SecuritiesListBox.SetItemChecked(x - 1, 0)
            End If
        Next
        Me.SymbolGridViewBase.Update()
        Me.SymbolGridViewCurrent.Update()
        Me.Button1.Text = Me.SecuritiesListBox.Items.Count & vbCrLf &
                           "Updated:  " & Now.TimeOfDay().ToString
        Call Rdoparams08()
        Application.DoEvents()
    End Sub
    Private Function GetSymbol(ByRef str As String) As String
        Static xx1 As Integer, xx As Integer, tmpstr As String
        xx1 = InStr(str, "\Data\")
        If xx1 > 0 Then
            tmpstr = Strings.Mid(str, xx1 + 6)
            xx = InStr(tmpstr, "_")
            tmpstr = Strings.Left(Strings.Mid(tmpstr, 1, xx - 1) & "______", 6)
            GetSymbol = tmpstr
        Else
            xx1 = InStr(str, "Data\")
            tmpstr = Strings.Mid(str, xx1 + 5)
            xx = InStr(tmpstr, "_")
            tmpstr = Strings.Left(Strings.Mid(tmpstr, 1, xx - 1) & "______", 6)
            GetSymbol = tmpstr 'Strings.Left(Strings.Mid(tmpstr, 32, 6) & "_____", 6)
        End If
    End Function
    Private Function GetDate(ByRef Str As String) As String
        GetDate = Strings.Left(Str, 8)
    End Function
    Private Function GetOpen(ByRef Str As String) As Single
        Dim m As Integer, m1 As Integer, str1 As String, str2 As String
        m = Strings.InStr(Str, ",")
        str1 = Strings.Right(Str, Len(Str) - 9)
        m1 = Strings.InStr(str1, ",")
        str2 = Strings.Left(str1, m1 - 1)
        GetOpen = Val(str2)
    End Function
    Private Function GetClose(ByRef str As String) As Single
        Dim ss1 As String, ss2 As String, ss3 As String, ss4 As String
        Dim comma1 As Integer, comma2 As Integer
        Dim comma3 As Integer, comma4 As Integer
        Dim lop As Single, lhi As Single, llo As Single, lcl As Single
        '        GetClose = 0.0
        ss1 = Strings.Right(str, Len(str) - 9)
        '       ss1 = str.Substring(comma0)
        comma1 = InStr(ss1, ",") - 1
        lop = Val(ss1.Substring(0, comma1))
        ss2 = ss1.Substring(comma1 + 1, ss1.Length - comma1 - 1)
        comma2 = InStr(ss2, ",") - 1
        lhi = Val(ss2.Substring(0, comma2))
        ss3 = ss2.Substring(comma2 + 1, ss2.Length - comma2 - 1)
        comma3 = InStr(ss3, ",") - 1
        If comma3 = -1 Then GoTo nextt : 
        llo = Val(ss3.Substring(0, comma3))
        ss4 = ss3.Substring(comma3 + 1, ss3.Length - comma3 - 1)
        comma4 = InStr(ss4, ",") - 1
        lcl = Val(ss4.Substring(0, comma4))
nextt:
        GetClose = lcl
    End Function
    Private Function GetDOW(ByRef str As String) As String
        Dim ss1 As String, ss2 As String
        Dim xDay As Integer, xDayDOWStr As String, xstr1 As String
        Dim lyr As String, lmo As String, ldy As String
        lyr = Strings.Left(str, 4)
        ss1 = Strings.Right(str, Len(str) - 4)
        lmo = Strings.Left(ss1, 2)
        ss2 = Strings.Right(str, Len(ss1) - 2)
        ldy = Strings.Left(ss2, 2)
        xDayDOWStr = lyr & "/" & lmo & "/" & ldy
        xDay = Weekday(xDayDOWStr)
        xstr1 = WeekdayName(xDay)
        GetDOW = xstr1
    End Function
    Private Function Getstartdate(ByRef Str As String) As String
        Getstartdate = Strings.Left(Str, 8)
    End Function

    Private Sub ReloadData_Click(sender As Object, e As EventArgs) Handles ReloadBaseData.Click
        Call readData(fStrBase, 0)
    End Sub

    Private Sub Execute_Current_Click(sender As Object, e As EventArgs) Handles Execute_Current.Click
        RMain = New Results
        RMain.qBase = False
        Call Wdoparameters()
        Execute_Current.Text = Now()
        Execute_Current.BackColor = Color.LightSeaGreen
        timerdm.startSeconds = Microsoft.VisualBasic.Timer
        Application.DoEvents()
        CounterDM.WrittenTo = 0
        CounterDM.totIterations = 0
        DGSignalsByEntry.Rows.Clear()
        totalavgQ = 0.0
        totalQ = 0
        totaliters = 0
        Call Securities_LoadList_Current(True)
        Execute_Current.BackColor = Color.Red
        Application.DoEvents()
        oleConnBase.Close()
        oleConnZScore.Close()
        oleConnStats.Close()
        oleConnStats1.Close()
        oleConnMovAvg.Close()
        oleConnSignals.Close()
        oleConnSparklines.Close()
        Execute_Current.BackColor = Color.Red
    End Sub

    Private Sub Execute_Base_Click(sender As Object, e As EventArgs) Handles Execute_Base.Click
        RMain = New Results
        RMain.qBase = True
        Call Wdoparameters()
        Execute_Base.Text = Now()
        Execute_Base.BackColor = Color.Green
        timerdm.startSeconds = Microsoft.VisualBasic.Timer
        Application.DoEvents()
        Call Securities_LoadList_Base()
        Execute_Base.BackColor = Color.Red
        Application.DoEvents()
        FileClose(1)
        FileClose(2)
    End Sub

    Private Sub SymbolGridViewCurrent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'Dim rc As New DataGridViewCheckBoxCell
        '  Dim x = SymbolGridViewCurrent.Rows[0].cells[0].value
        '        rc = SymbolGridViewCurrent.Rows.
        '       Stop
    End Sub

   
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Application.DoEvents()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ReadData(fStrCurrent, 1)
    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub

    Private Sub ReadFiles_Click(sender As Object, e As EventArgs) Handles ReadFiles.Click
        ReadFiles.ForeColor = Color.AliceBlue
        ReadFiles.BackColor = Color.Green
        Application.DoEvents()
        Call ReadData(fStrCurrent, 1)
        ReadFiles.ForeColor = Color.White
        ReadFiles.BackColor = Color.Red
        Application.DoEvents()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xx As Integer, xStr As String
        For xx = 0 To Me.SecuritiesListBox.Items.Count - 1
            SecuritiesListBox.SelectedItem = xx
            xStr = SecuritiesListBox.GetItemChecked(xx)
            SecuritiesListBox.SetItemChecked(xx, 0)
        Next
    End Sub

    Private Sub Set_All_Click(sender As Object, e As EventArgs) Handles Set_All.Click
        Static x As Integer
        For x = 0 To Me.SecuritiesListBox.Items.Count - 1
            SecuritiesListBox.SetItemChecked(x, 0)
        Next
    End Sub

    Private Sub Symbol1_TextChanged(sender As Object, e As EventArgs) Handles Symbol1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim xx As Integer, xStr As String
        For xx = 0 To Me.SecuritiesListBox.Items.Count - 1
            SecuritiesListBox.SelectedItem = xx
            xStr = SecuritiesListBox.GetItemChecked(xx)
            SecuritiesListBox.SetItemChecked(xx, 1)

        Next
    End Sub

    Private Sub TxtSymbol_TextChanged(sender As Object, e As EventArgs) Handles txtSymbol.TextChanged

    End Sub

    Private Sub SecuritiesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SecuritiesList.SelectedIndexChanged

    End Sub

    Private Sub totSeconds_TextChanged(sender As Object, e As EventArgs) Handles totSeconds.TextChanged

    End Sub

    Private Sub ReloadCurrentData_Click(sender As Object, e As EventArgs) Handles ReloadCurrentData.Click
        Call ReadData(fStrCurrent, 1)
    End Sub

    Private Sub SecuritiesListBox_DrawItem(sender As Object, e As DrawItemEventArgs) Handles SecuritiesListBox.DrawItem
        e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds)
        e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), e.Font, Brushes.Black, New System.Drawing.PointF(e.Bounds.X, e.Bounds.Y))
        e.DrawFocusRectangle()
        ' ListBox1.Items(e.Index).
        ' e.ForeColor = Color.DarkCyan
        '
    End Sub
End Class