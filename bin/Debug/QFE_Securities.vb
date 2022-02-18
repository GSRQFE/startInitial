Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Timers
Public Class QFE_Securities
    Public baseSecNo As Integer
    Public fstr As String, fstr1 As String, fstr2 As String
    Public totalQ As Single
    Public totalavgQ As Single
    Public totaliters As Long
    Public cntCl As Long
    Public totclval As Single
    Friend WithEvents TableLayout As TableLayoutPanel
    Public oleDBSymbols As OleDb.OleDbCommand
    Public oleDBLong As OleDb.OleDbCommand
    Public oleConnLong As System.Data.OleDb.OleDbConnection
    Public oleDBShort As OleDb.OleDbCommand
    Public oleConnShort As System.Data.OleDb.OleDbConnection
    Public oleDBtats As OleDb.OleDbCommand
    Public oleDBSignals As OleDb.OleDbCommand
    Public oleConnSignals As System.Data.OleDb.OleDbConnection
    Public oleDBTrades As OleDb.OleDbCommand
    Public oleConnTrades As System.Data.OleDb.OleDbConnection
    Public fStrBase As String, fStrCurrent As String
    Private Sub Securities_LoadList_Base(secno1 As Integer)
        Stop
        Static xNo As Integer
        Dim xx As Integer, xx1 As Integer, y As Integer
        xNo = 0
        Me.SecuritiesList.Items.Clear()
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(fStrBase)
            secno1 = 0
            xNo += 1
            Me.SecNo_.Text = Format$(xNo, "0000")
            Text = "Working " & foundFile & "  Sec#:" & Format(xNo, "0000")
            CounterDM(secno1).fn = foundFile
            xx = InStr(CounterDM(secno1).fn, fStrBase) + 38
            If xx = 0 Then Stop
            '     xx1 = InStr(SymbolData.fileString, "_SMART")
            CounterDM(secno1).secSymbol = CounterDM(secno1).fn.Substring(xx)
            xx1 = InStr(CounterDM(secno1).secSymbol, "_")
            CounterDM(secno1).secSymbol = Strings.Left(CounterDM(secno1).secSymbol, xx1 - 1)
            CounterDM(secno1).secSymbol = Strings.Left(CounterDM(secno1).secSymbol & "_____", 6)
            Me.txtSymbol.Text = CounterDM(secno1).secSymbol
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
            CounterDM(secno1).Records = CountRecordsDailySecurities(1, CounterDM(secno1).fn)
            CounterDM(secno1).Days = CounterDM(secno1).Records
            CounterDM(secno1).first_DayNo = 1
            CounterDM(secno1).first_DayNo = 1
            CounterDM(secno1).last_DayNo = CounterDM(secno1).Days
            CounterDM(secno1).last_DayNo = CounterDM(secno1).last_DayNo
            '    Dim task = New Task(AddressOf Process_Files)
            Call Process_Files(secno1)
            Call MovAvgDay.InitMovAvg(secno1)
            CounterDM(secno1).first_DayDate = DayDTstr2_(CounterDM(secno1).first_DayNo)
            CounterDM(secno1).last_DayDate = DayDTstr2_(CounterDM(secno1).last_DayNo)
            CounterDM(secno1).this_DayDate = CounterDM(secno1).last_DayDate
            Text = "Working " & foundFile &
                    "  Sec#:" & Format(xNo, "0000") & "records=" &
                     Format(CounterDM(secno1).Records, "00000")
            Call MovAvgDayUp1(secno1)
            '            RMain.SP.BandH.Text = "bh01A_" & .bEntryDay.Text & .sExitDay.Text
            '        SecuritiesList.Items.Add(CounterDM.secSymbol & DayDOWStr_(CounterDM.Days))
        Next
        Me.SecuritiesList.Update()
    End Sub
    Private Sub Prepare_DataBaseFiles()
        If longDBRecord.Checked Then
            If My.Computer.FileSystem.FileExists("c:\QFE_SignalsBaseKeyslong.mdb") Then
                File.Delete("c:\qfe_base\QFE_SignalsBasekeyslong.mdb")
            End If
            File.Copy("c:\qfe_base\qfe_signalsbasekeys_mblong.mdb",
                      "c:\qfe_base\QFE_SignalsBasekeyslong.mdb")
        End If

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
        '    oleDBBase = New OleDb.OleDbCommand
        '    oleConnBase = New OleDb.OleDbConnection
        '    oleConnBase.ConnectionString =
        '        "Provider=Microsoft.JET.OLEDB.4.0;" &
        '    '         "Data Source=c:\qfe_base\QFE_SignalsBaseKeys.mdb;"
        '    oleDBBase.Connection = oleConnBase
        '    oleConnBase.Open()
        '   oleDBBase.CommandText = "DELETE FROM Base"
        'oleDBBase.ExecuteNonQuery()
        REM
        If shortDBRecord.Checked Then
            If My.Computer.FileSystem.FileExists("c:\qfe_base\QFE_SignalsBaseKeysshort.mdb") Then
                File.Delete("c:\qfe_base\QFE_SignalsBasekeysshort.mdb")
            End If
            File.Copy("c:\qfe_base\qfe_signalsbasekeys_mbshort.mdb",
                      "c:\qfe_base\QFE_SignalsBasekeysshort.mdb")
            oleDBShort = New OleDb.OleDbCommand
            oleConnShort = New OleDb.OleDbConnection
            oleConnShort.ConnectionString =
                "Provider=Microsoft.JET.OLEDB.4.0;" &
                 "Data Source=c:\qfe_base\QFE_SignalsBaseKeysshort.mdb;"
            oleDBShort.Connection = oleConnShort
            oleConnShort.Open()
        End If
        REM
        'oleDBStats1 = New OleDb.OleDbCommand
        'oleConnStats1 = New OleDb.OleDbConnection
        'oleConnStats1.ConnectionString =
        '    "Provider=Microsoft.JET.OLEDB.4.0;" &
        '     "Data Source=c:\qfe_base\QFE_SignalsBaseKeys.mdb;"
        'oleDBStats1.Connection = oleConnStats
        'oleConnStats1.Open()
        'oleDBStats1.CommandText = "DELETE FROM Stats"
        'oleDBStats1.ExecuteNonQuery()
        REM
        'oleDBMovAvg = New OleDb.OleDbCommand
        'oleConnMovAvg = New OleDb.OleDbConnection
        'leConnMovAvg.ConnectionString =
        '     "Provider=Microsoft.JET.OLEDB.4.0;" &
        '     "Data Source=c:\qfe_base\QFE_SignalsBasekeys.mdb;"
        'oleDBMovAvg.Connection = oleConnMovAvg
        'oleConnMovAvg.Open()
        'oleDBMovAvg.CommandText = "DELETE FROM MovAvg"
        'oleDBMovAvg.ExecuteNonQuery()
        REM
        '    oleDBSignals = New OleDb.OleDbCommand
        '    oleConnSignals = New OleDb.OleDbConnection
        '    oleConnSignals.ConnectionString =
        '        "Provider=Microsoft.JET.OLEDB.4.0;" &
        '         "Data Source=c:\qfe_base\QFE_SignalsBaseKeys.mdb;"
        '    oleDBSignals.Connection = oleConnSignals
        '   oleConnSignals.Open()
        '    oleDBSignals.CommandText = "DELETE FROM Signals"
        '  oleDBSignals.ExecuteNonQuery()
        ' Application.DoEvents()
        REM
        'oleDBSparkLines = New OleDb.OleDbCommand
        'oleConnSparklines = New OleDb.OleDbConnection
        ' oleConnSparklines.ConnectionString =
        '     "Provider=Microsoft.JET.OLEDB.4.0;" &
        '      "Data Source=c:\qfe_base\QFE_SignalsBaseKeys.mdb;"
        'oleDBSparkLines.Connection = oleConnSparklines
        ' oleConnSparklines.Open()
        ' oleDBSparkLines.CommandText = "DELETE FROM SparkLines"
        ' oleDBSparkLines.ExecuteNonQuery()
skipp:
        Application.DoEvents()
    End Sub
    REM
    Public Sub Securities_LoadList_Current()
        Dim fnn As String, cntt As Integer
        fnn = ""
        cntt = 0
        '  d = n.Value.Year & Format(ThisDate.Value.Month, "00") & Format(ThisDate.Value.Day, "00")
        cntt = 0
        '   CounterDM = New Coun
        For baseSecNo = 0 To SecuritiesList.Items.Count - 1
            '  If baseSecNo >= 240 Then Stop
            CounterDM(baseSecNo) = New Counter
            CounterDM(baseSecNo).secIterations = 0
            CounterDM(baseSecNo).fn = SecuritiesList.Items(baseSecNo).ToString
            CounterDM(baseSecNo).secSymbol = GetSymbol(CounterDM(baseSecNo).fn)
            CounterDM(baseSecNo).start_DayDate = Me.ThisDate.Text
            CounterDM(baseSecNo).startSeconds = Microsoft.VisualBasic.Timer
            rmain = New Results
            rmain.Symbol = CounterDM(baseSecNo).secSymbol
            RZA_ = New Results
            RZB_ = New Results
            Me.Symbol_.Text = CounterDM(baseSecNo).secSymbol & ":" & Format(baseSecNo, "0000")
            ' SecuritiesList.SelectedItem = CounterDM.secNo - 1
            ' Dim t1 As Thread = New Thread(New ThreadStart(AddressOf printinfo))
            ' t1.Start()
            Application.DoEvents()
            CounterDM(baseSecNo).onSecs = CounterDM(baseSecNo).onSecs + 1
            Call doLoopUniversal(baseSecNo)
            Application.DoEvents()
        Next basesecno
    End Sub
    REM
    Public Sub LoadList(secno1 As Integer)
        '   Static txt As String
        CounterDM(secno1).Days = 0
        CounterDM(secno1).onSecs = 0
        CounterDM(secno1).offSecs = 0
        If CounterDM(secno1).fn <> "" Then
            Call TypeDaily(secno1)
            CounterDM(baseSecNo).start_DayNo = 1
            CounterDM(baseSecNo).start_DayDate = DayDTStr2(baseSecNo, CounterDM(baseSecNo).start_DayNo)
            StartDayNo.Text = CounterDM(baseSecNo).start_DayNo
            StartDayDate.Text = CounterDM(baseSecNo).start_DayDate
            CounterDM(baseSecNo).end_DayNo = CounterDM(baseSecNo).last_DayNo
            CounterDM(baseSecNo).end_DayDate = DayDTStr2(baseSecNo, CounterDM(baseSecNo).end_DayNo)
            Me.EndDayNo.Text = Format$(CounterDM(baseSecNo).end_DayNo, "000000")
            Me.EndDayDate.Text = CounterDM(baseSecNo).end_DayDate
            '        CounterDM(secNo1).first_DayNo = CounterDM(secNo1).Records - Me.NumberofDays.Value
            If CounterDM(baseSecNo).first_DayNo < 90 Then
                CounterDM(baseSecNo).first_DayNo = 90
            End If
            FirstDayNo.Text = CounterDM(baseSecNo).first_DayNo
            If CounterDM(baseSecNo).first_DayNo = 0 Then Stop
            'CounterDM(secNo1).first_DayDate = DayDTStr2(secNo1, CounterDM(secNo1).first_DayNo)
            LastDayNo.Text = CounterDM(baseSecNo).last_DayNo
            CounterDM(baseSecNo).last_DayDate = DayDTStr2(baseSecNo, CounterDM(baseSecNo).last_DayNo)
            FirstDayDate.Text = CounterDM(baseSecNo).first_DayDate
            LastDayDate.Text = CounterDM(baseSecNo).last_DayDate
            CounterDM(baseSecNo).this_DayNo = CounterDM(baseSecNo).last_DayNo
            ThisDayNo.Text = CounterDM(baseSecNo).this_DayNo
            CounterDM(baseSecNo).this_DayDate = DayDTStr2(baseSecNo, CounterDM(baseSecNo).this_DayNo)
            ThisDayDate.Text = CounterDM(baseSecNo).this_DayDate
            CounterDM(secno1).last_DayDate = DayDTstr2_(CounterDM(secno1).last_DayNo)
            Me.Symbol1.Text = CounterDM(secno1).secSymbol & "::" & DayDOWStr_(CounterDM(secno1).last_DayNo) &
                               CounterDM(secno1).last_DayDate & ":" & Format(secno1)
            Call MovAvgDay.InitMovAvg(secno1)
            ' CounterDM(secno1).Records = CountRecordsDailySecurities(1, CounterDM(secno1).fn)
            If CounterDM(secno1).Records < Me.NumberofDays.Value Then
                CounterDM(secno1).Days = CounterDM(secno1).Days
            Else
                CounterDM(secno1).Days = Me.NumberofDays.Value
            End If
            If CounterDM(secno1).this_DayDate = CounterDM(secno1).last_DayDate Then
            End If
            CounterDM(secno1).offSecs = CounterDM(secno1).offSecs + 1
            Call XA(secno1)
        End If
    End Sub
    Private Sub XA(secno1 As Integer)
        '        Text = "Working " & CounterDM(secNo1).secSymbol & " Sec#:" & Format(SecNo, "0000") &
        '                           "records=" & Format(CounterDM(secNo1).Records, "00000")
        Cl0nOp.Text = Format("0.000")
        nOp0nCl.Text = Format("0.000")
        nOp0nnCl.Text = Format("0.000")
        Call DoDOW(secNo1)
        ' txt = Strings.Left(CounterDM(secNo1).secSymbol & " " & DayDOWStr_(CounterDM(secNo1).Days), 15)
    End Sub
    REM
    Private Sub Put_SymbolSecurities(ByRef SD As Symbol_Data)
        With SD
            thisIncr += 1
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
    Private Sub SecuritiesList_Click(sender As Object, e As EventArgs)
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

    Private Sub AddDataofSingleSecurity(secno1 As Integer)
        Dim r As New DataGridViewRow
        Dim rt As New DataGridViewTextBoxCell
        Dim rc As New DataGridViewCheckBoxCell
        Call Process_Files(secno1)
        '        CounterDM(secno1).secSymbol = GetSymbol(CounterDM(secno1).fn)
        rt = New DataGridViewTextBoxCell
        rt.Value = secno1
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM(secno1).this_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM(secno1).secSymbol
        r.Cells.Add(rt)
        rc = New DataGridViewCheckBoxCell
        rc.TrueValue = True
        If CounterDM(secno1).last_DayDate = CounterDM(secno1).this_DayDate Then
            CounterDM(secno1).end_DayNo = CounterDM(secno1).last_DayNo
            CounterDM(secno1).end_DayDate = DayDTStr2(secno1, CounterDM(secno1).end_DayNo)
        End If
        If CounterDM(secno1).last_DayDate > CounterDM(secno1).this_DayDate Then
            CounterDM(secno1).last_DayNo -= 1
            CounterDM(secno1).last_DayDate = DayDTStr2(secno1, CounterDM(secno1).last_DayNo)
            CounterDM(secno1).end_DayNo = CounterDM(secno1).last_DayNo
            CounterDM(secno1).end_DayDate = DayDTStr2(secno1, CounterDM(secno1).end_DayNo)
        End If
        rc.Value = 1
        r.Cells.Add(rc)
        rt = New DataGridViewTextBoxCell
        rt.Value = Format(CounterDM(secno1).Records, "0000")
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM(secno1).first_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM(secno1).first_DayDate
        rt.Value = CounterDM(secno1).last_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM(secno1).first_DayDate
        rt.Value = CounterDM(secno1)
        rt = New DataGridViewTextBoxCell
        rt.Value = Format(CounterDM(secno1).daysDown, "000")
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = DayDOWStr_(CounterDM(secno1).last_DayNo)
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        CounterDM(secno1).first_DayDate = DayDTstr2_(CounterDM(secno1).first_DayNo)
        rt.Value = CounterDM(secno1).first_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM(secno1).last_DayDate
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = SecNo
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.MaxInputLength = 99
        rt.Value = Now.TimeOfDay
        r.Cells.Add(rt)
        Me.SymbolGridViewCurrent.Rows.Add(r)
    End Sub

    Public Sub AddData1(secno1 As Integer, ByRef R1 As Results)
        Dim r As New DataGridViewRow
        Dim rt As New DataGridViewTextBoxCell
        Dim rc As New DataGridViewCheckBoxCell
        totaliters += 1
        totalQ += R1.SS.Q.avg
        totalavgQ = totalQ / totaliters
        rt = New DataGridViewTextBoxCell
        rt.Value = rmain.Symbol
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = rmain.maStr
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = rmain.SP.bDOW.Text
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = rmain.SP.bZScrModeDay.Text & ":" & rmain.SP.bZScrOffsetDay
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = rmain.SP.bInDay.Text
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = rmain.SP.bEntryDay.Text
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = Format(R1.SS.avgDH, "00.00")
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = rmain.SP.sExitDay.Text
        r.Cells.Add(rt)
        rt = New DataGridViewTextBoxCell
        rt.Value = CounterDM(secno1).secIterations
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
        Call Rdoparams08()
        ' CounterDM(secNo1).this_DayDate = Year(Now) & Format(Month(Now), "00") &
        ' Format(Microsoft.VisualBasic.DateAndTime.Day(Now), "00")
        'Me.startTime.Text = CounterDM(baseSecNo).this_DayDate
        'Me.txtItersPerSecond.Text = Format("000000", CounterDM(se.totIterations)
        'fStr = "C:\QFE_Base\Data\"
        '        fStrBase = "C:\jTWSdata_1401_inJh\SignalsBase\Data\"
        '       fStrBase = "C:\Users\grego\Dropbox\QFEData"
        '       fStrBase = "C:\Users\grego\Dropbox\QFEData"
        fStrBase = "C:\jTWSdata_1401_inJh\jTWSdata_1401\Data"
        Me.BaseDataFiles.Text = fStrBase
        ' Application.DoEvents()
        ' fStrCurrent = "C:\Data"
        fStrCurrent = fStrBase
        CurrentDataFiles.Text = fStrCurrent
        Me.txtSymbol.Text = fStrBase
        Call ReadData(fStrCurrent, 1)
        Application.DoEvents()
    End Sub
    Private Sub ReadData(dirStr As String, ByRef which As Integer)
        Dim tststr As String, x As Integer
        FileClose(1)
        Select Case which
            Case = 0
                Me.SymbolGridViewCurrent.Rows.Clear()
            Case = 1
                Me.SymbolGridViewCurrent.Rows.Clear()
                Dim rt As New DataGridViewTextBoxCell
                Dim rc As New DataGridViewCheckBoxCell
                Dim r As New DataGridViewRow
                rt.Value = "Symbol"
                r.Cells.Add(rt)
                '   rc.Value = is
                r.Cells.Add(rc)
                Me.SymbolGridViewCurrent.Rows.Clear()
                Me.SecuritiesList.Items.Clear()
                '               CounterDM = New Counter
                baseSecNo = -1
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(fStrCurrent)
                    baseSecNo += 1
                    SecuritiesList.Items.Add(foundFile)
                    CounterDM(baseSecNo).fn = foundFile
                    If InStr(CounterDM(baseSecNo).fn, ".txt") > 0 And InStr(CounterDM(baseSecNo).fn, ".tmp") = 0 Then
                        Me.Securities.Text = CounterDM(baseSecNo).fn
                        CounterDM(baseSecNo).secSymbol = GetSymbol(CounterDM(baseSecNo).fn)
                        Call TypeDaily(baseSecNo)
                        If qAdjustForAfterMidNight.Checked = True Then
                            If CounterDM(baseSecNo).end_DayDate < CounterDM(baseSecNo).end_DayDate Then
                                Stop
                                CounterDM(baseSecNo).last_DayDate = CounterDM(baseSecNo).end_DayDate
                                CounterDM(baseSecNo).last_DayNo = CounterDM(baseSecNo).last_DayNo
                            End If
                        End If
                        Call AddDataofSingleSecurity(1)
                        tststr = CounterDM(baseSecNo).secSymbol & ":" & CounterDM(baseSecNo).end_DayDate & ":" _
                                & CounterDM(baseSecNo).last_DayDate & ":" & DayDOWNo_(CounterDM(baseSecNo).last_DayNo)
                        SecuritiesListBox.Items.Add(tststr)
                        'CoSecuritiesListBox.Items.Add(tststr)
                        x = SecuritiesListBox.Items.Count
                        SecuritiesListBox.SelectedItem = x - 1
                        '                xststr = SecuritiesListBox.GetItemChecked(x - 1)
                        'SecuritiesListBox.SetItemChecked(x - 1, 0)
                        '                       SecuritiesList.Items.Add(foundFile)
                        '                     x = SecuritiesList.Items.Count
                        '                    SecuritiesList.SelectedItem = x - 1
                        '                    xststr = SecuritiesList.GetItemChecked(x - 1)
                        '                    SecuritiesList.SetItemChecked(x - 1, 1)
                    End If
                Next
                Me.SymbolGridViewBase.Update()
                Me.SymbolGridViewCurrent.Update()
                Me.Button1.Text = Me.SecuritiesListBox.Items.Count & vbCrLf &
                                   "Updated:  " & Now.TimeOfDay().ToString
                Application.DoEvents()
            Case Else
                Stop
        End Select
    End Sub

    Private Function GetSymbol(str As String) As String
        Static xx1 As Integer, xx As Integer, tmpstr As String
        xx = InStr(str, "_SMART")
        xx1 = InStr(str, "\Data\") + 6
        If xx1 > 0 Then
            tmpstr = Strings.Mid(str, xx1, xx - xx1)
            tmpstr = Strings.Left(tmpstr & "______", 6)
            GetSymbol = tmpstr
        Else
            xx1 = InStr(str, "Data\")
            tmpstr = Strings.Mid(str, xx1 + 5)
            xx = InStr(tmpstr, "_")
            tmpstr = Strings.Left(Strings.Mid(tmpstr, 1, xx - 1) & "______", 6)
            GetSymbol = tmpstr 'Strings.Left(Strings.Mid(tmpstr, 32, 6) & "_____", 6)
        End If
    End Function
    Private Function GetSymbol1(ByRef str As String) As String
        Static xx1 As Integer, tmpstr As String
        xx1 = InStr(str, "_")
        If xx1 = 0 Then Stop
        tmpstr = Strings.Left(str & "_____", xx1)
        'tmpstr = Strings.Left(Strings.Mid(tmpstr, 1, xx - 1) & "______", 6)
        GetSymbol1 = tmpstr
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

    Private Sub ReadFiles_Click(sender As Object, e As EventArgs) Handles ReadFiles.Click
        ReadFiles.ForeColor = Color.AliceBlue
        ReadFiles.BackColor = Color.Green
        Application.DoEvents()
        'Call ReadData(fStrCurrent, 1)
        Call Rdoparams08()
        ReadFiles.ForeColor = Color.White
        ReadFiles.BackColor = Color.Red
        Application.DoEvents()
    End Sub

    Private Sub Set_Symbol_Off_Click(sender As Object, e As EventArgs) Handles SetSymbolOff.Click
        Dim xx As Integer, xStr As String
        For xx = 0 To Me.SecuritiesList.Items.Count - 1
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
    Public Sub printinfo()
        Dim ocb As New System.Data.OleDb.OleDbConnection
        fstr1 = ""
        fstr2 = ""
        If shortDBRecord.Checked Then
            Call doLoopUniversal(baseSecNo)
        End If
    End Sub
    Private Sub doLoopUniversal(secno1 As Integer)
        fstr = "c:\qfe_base\QFE_SignalsBasekeysshort.mdb"
        fstr1 = "c:\qfe_base\QFE_SignalsBasekeysshort" & Format(secno1, "0000") & ".mdb"
        '                Me.Text = fnn
        'File.Copy("c:\qfe_base\qfe_signalsbasekeys_mbshort.mdb",
        'fstr1, True)
        'If My.Computer.FileSystem.FileExists _
        '   ("c:\qfe_base\QFE_SignalsBaseKeysshort.mdb") Then
        'File.Delete(fstr)
        '               fstr2 = fstr1 & Format(xxxx, "0000") & ";"
        ' oleDatabaseSymbols = New OleDb.OleDbCommand
        'oleConnSymbols = New OleDb.OleDbConnection
        'oleConnSymbols.ConnectionString =
        '    "Provider=Microsoft.JET.OLEDB.4.0;" &
        '     "Data Source=C:\QFE_Base\QFE_Signals1.mdb;"
        'oleDatabaseSymbols.Connection = oleConnSymbols
        'oleConnSymbols.Open()
        ' oleDBShort = New OleDb.OleDbCommand
        ' oleConnShort = New OleDb.OleDbConnection
        ' oleDBShort.Connection = oleConnShort
        '        oleDBBaseShort = New OleDb.OleDbConnection
        ' oleDBShort.ConnectionString =
        '                        "Provider=Microsoft.JET.OLEDB.4.0;" &
        '                       "Data Source=c:\qfe_base\QFE_SignalsBaseKeysShort.mdb;"
        ' ocb.ConnectionString =
        '           "Provider=Microsoft.JET.OLEDB.4.0;" &
        '            "Data Source=" & fstr1
        ' ocb.Open()
        ' Me.Text = CounterDM.secSymbol
        ' Symbol1.Text = CounterDM.secSymbol
        ' Me.SecNo_.Text = Format$(CounterDM.secNo, "0000")
        'FileClose(secno1)
        'If My.Computer.FileSystem.FileExists(xsec) Then Stop
        '        FileOpen(secno1, CounterDM(secno1).fn, OpenMode.Input, OpenAccess.Read)
        Call LoadList(secno1)
        '      fnn = "c:\signalsbase\" & CounterDM.secSymbol
        ' My.Computer.FileSystem.CopyFile(fstr, fnn, True)
        '  ocb.Close()
        ' Console.WriteLine("Main Thread Completed")
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Parameters_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GrpMaxDay_Enter(sender As Object, e As EventArgs) Handles GrpMaxDay.Enter

    End Sub

    Private Sub SymbolGridViewBase_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SymbolGridViewBase.CellContentClick

    End Sub

    Private Sub Execute_Current_Click(sender As Object, e As EventArgs) Handles Execute_Current.Click
        Me.Execute_Current.BackColor = Color.Blue
        '     Dim t1 As Thread = New Thread(New ThreadStart(AddressOf PrintInfo))
        Call Wdoparams08()
        '       Call ReadData(fStrCurrent, 1)
        Call Prepare_DataBaseFiles()
        Call Securities_LoadList_Current()
        Me.Execute_Current.BackColor = Color.Red
    End Sub


    Private Sub Set_Symbol_On_Click(sender As Object, e As EventArgs) Handles Set_Symbol_On.Click
        Dim xx As Integer, xStr As String
        For xx = 0 To Me.SecuritiesList.Items.Count - 1
            SecuritiesList.SelectedItem = xx
            xStr = SecuritiesList.GetItemChecked(xx)
            SecuritiesList.SetItemChecked(xx, 1)
        Next
    End Sub

    Private Sub SecuritiesListBox_DrawItem(sender As Object, e As DrawItemEventArgs)
        e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds)
        e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), e.Font, Brushes.Black, New System.Drawing.PointF(e.Bounds.X, e.Bounds.Y))
        e.DrawFocusRectangle()
        ' ListBox1.Items(e.Index).
        ' e.ForeColor = Color.DarkCyan
        '
    End Sub
End Class