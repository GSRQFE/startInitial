<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QFE_Securities
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QFE_Securities))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Written = New System.Windows.Forms.TextBox()
        Me.errorCnt = New System.Windows.Forms.TextBox()
        Me.ReadFiles = New System.Windows.Forms.Button()
        Me.adjDate = New System.Windows.Forms.DateTimePicker()
        Me.Records = New System.Windows.Forms.TextBox()
        Me.Qavg = New System.Windows.Forms.TextBox()
        Me.Symbol1 = New System.Windows.Forms.RichTextBox()
        Me.NumberofDays = New System.Windows.Forms.NumericUpDown()
        Me.Average = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Execute_Current = New System.Windows.Forms.Button()
        Me.SecNo_ = New System.Windows.Forms.TextBox()
        Me.NoSecs = New System.Windows.Forms.TextBox()
        Me.txtSymbol = New System.Windows.Forms.RichTextBox()
        Me.totSeconds = New System.Windows.Forms.TextBox()
        Me.txtItersPerSecond = New System.Windows.Forms.TextBox()
        Me.totIterations = New System.Windows.Forms.TextBox()
        Me.ThisDate = New System.Windows.Forms.DateTimePicker()
        Me.Result = New System.Windows.Forms.Button()
        Me.TAB_Securities = New System.Windows.Forms.TabControl()
        Me.Securities = New System.Windows.Forms.TabPage()
        Me.Set_All = New System.Windows.Forms.Button()
        Me.SecuritiesList = New System.Windows.Forms.CheckedListBox()
        Me.SymbolParams_ = New System.Windows.Forms.TabPage()
        Me.saveOnlyBaseKeys = New System.Windows.Forms.CheckBox()
        Me.Execute_Base = New System.Windows.Forms.Button()
        Me.ReloadBaseData = New System.Windows.Forms.Button()
        Me.DataFiles = New System.Windows.Forms.TextBox()
        Me.SymbolGridViewBase = New System.Windows.Forms.DataGridView()
        Me.SecNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Symbol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Checked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Recs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DDn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastDOW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParamFiles_ = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CoSecuritiesListBox = New System.Windows.Forms.CheckedListBox()
        Me.SecuritiesListBox = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CurrentDataFiles = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabelData = New System.Windows.Forms.LinkLabel()
        Me.BaseDataFiles = New System.Windows.Forms.RichTextBox()
        Me.dbSymbols = New System.Windows.Forms.RichTextBox()
        Me.dbSignals = New System.Windows.Forms.RichTextBox()
        Me.dbTrades = New System.Windows.Forms.RichTextBox()
        Me.Current = New System.Windows.Forms.TabPage()
        Me.CoThisDayDOW = New System.Windows.Forms.TextBox()
        Me.coEndDayDate = New System.Windows.Forms.TextBox()
        Me.coFirstDayDate = New System.Windows.Forms.TextBox()
        Me.coLastDayDate = New System.Windows.Forms.TextBox()
        Me.coThisDayDate = New System.Windows.Forms.TextBox()
        Me.coThisDayNo = New System.Windows.Forms.TextBox()
        Me.coLastDayNo = New System.Windows.Forms.TextBox()
        Me.coFirstDayNo = New System.Windows.Forms.TextBox()
        Me.coEndDayNo = New System.Windows.Forms.TextBox()
        Me.coStartDayDate = New System.Windows.Forms.TextBox()
        Me.coStartDayNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CoSymbolTxt = New System.Windows.Forms.TextBox()
        Me.thisDayDOW = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.symbolTxt = New System.Windows.Forms.TextBox()
        Me.EndDayDate = New System.Windows.Forms.TextBox()
        Me.EndDayNo = New System.Windows.Forms.TextBox()
        Me.ThisDayNo = New System.Windows.Forms.TextBox()
        Me.ThisDayDate = New System.Windows.Forms.TextBox()
        Me.LastDayDate = New System.Windows.Forms.TextBox()
        Me.LastDayNo = New System.Windows.Forms.TextBox()
        Me.FirstDayDate = New System.Windows.Forms.TextBox()
        Me.FirstDayNo = New System.Windows.Forms.TextBox()
        Me.StartDayDate = New System.Windows.Forms.TextBox()
        Me.StartDayNo = New System.Windows.Forms.TextBox()
        Me.ReloadCurrentData = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.selectSecurities = New System.Windows.Forms.TabPage()
        Me.Cl0nnCl = New System.Windows.Forms.TextBox()
        Me.Cl0nnOp = New System.Windows.Forms.TextBox()
        Me.Cl0nCl = New System.Windows.Forms.TextBox()
        Me.nOp0nnOp = New System.Windows.Forms.TextBox()
        Me.nOp0nnCl = New System.Windows.Forms.TextBox()
        Me.nCl0nnCl = New System.Windows.Forms.TextBox()
        Me.nCl0nnOp = New System.Windows.Forms.TextBox()
        Me.qShowDG = New System.Windows.Forms.CheckBox()
        Me.qshowByEntryData = New System.Windows.Forms.CheckBox()
        Me.DGSignalsByEntry = New System.Windows.Forms.DataGridView()
        Me.Symb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movAvg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZScrMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bInDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maxDH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sExit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totIters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Q = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avgQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Cl0nOp = New System.Windows.Forms.TextBox()
        Me.thisClose = New System.Windows.Forms.CheckBox()
        Me.nOp0nCl = New System.Windows.Forms.TextBox()
        Me.nextClose = New System.Windows.Forms.CheckBox()
        Me.nextOpen = New System.Windows.Forms.CheckBox()
        Me.Parameters = New System.Windows.Forms.TabPage()
        Me.sTargetProfit50 = New System.Windows.Forms.CheckBox()
        Me.sTargetProfit40 = New System.Windows.Forms.CheckBox()
        Me.sTargetProfit30 = New System.Windows.Forms.CheckBox()
        Me.sTargetProfit20 = New System.Windows.Forms.CheckBox()
        Me.sTargetProfit10 = New System.Windows.Forms.CheckBox()
        Me.sTargetProfit00 = New System.Windows.Forms.CheckBox()
        Me.MApbUp4 = New System.Windows.Forms.ProgressBar()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.adjQThreshHold = New System.Windows.Forms.NumericUpDown()
        Me.QThreshhold = New System.Windows.Forms.NumericUpDown()
        Me.Model09 = New System.Windows.Forms.CheckBox()
        Me.Model08 = New System.Windows.Forms.CheckBox()
        Me.Model07 = New System.Windows.Forms.CheckBox()
        Me.Model06 = New System.Windows.Forms.CheckBox()
        Me.Model05 = New System.Windows.Forms.CheckBox()
        Me.Model04 = New System.Windows.Forms.CheckBox()
        Me.Model03 = New System.Windows.Forms.CheckBox()
        Me.Model02 = New System.Windows.Forms.CheckBox()
        Me.Model01 = New System.Windows.Forms.CheckBox()
        Me.Model00 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank9 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank8 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank7 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank6 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank5 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank4 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank3 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank2 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank1 = New System.Windows.Forms.CheckBox()
        Me.ZScrRank0 = New System.Windows.Forms.CheckBox()
        Me.qZOffSet1 = New System.Windows.Forms.CheckBox()
        Me.qZOffSet5 = New System.Windows.Forms.CheckBox()
        Me.qZOffSet4 = New System.Windows.Forms.CheckBox()
        Me.qZOffSet3 = New System.Windows.Forms.CheckBox()
        Me.qZOffSet2 = New System.Windows.Forms.CheckBox()
        Me.qZOffSet0 = New System.Windows.Forms.CheckBox()
        Me.qZPP = New System.Windows.Forms.CheckBox()
        Me.qZP_ = New System.Windows.Forms.CheckBox()
        Me.qZNN = New System.Windows.Forms.CheckBox()
        Me.qZN_ = New System.Windows.Forms.CheckBox()
        Me.qZBase = New System.Windows.Forms.CheckBox()
        Me.qInDay10 = New System.Windows.Forms.CheckBox()
        Me.qInDay09 = New System.Windows.Forms.CheckBox()
        Me.qMovAvgDn0 = New System.Windows.Forms.CheckBox()
        Me.qMaxDay10 = New System.Windows.Forms.CheckBox()
        Me.qMaxDay9 = New System.Windows.Forms.CheckBox()
        Me.mapbdn1 = New System.Windows.Forms.ProgressBar()
        Me.qMaxDay8 = New System.Windows.Forms.CheckBox()
        Me.mapbdn2 = New System.Windows.Forms.ProgressBar()
        Me.qMaxDay7 = New System.Windows.Forms.CheckBox()
        Me.mapbdn3 = New System.Windows.Forms.ProgressBar()
        Me.qMaxDay6 = New System.Windows.Forms.CheckBox()
        Me.qMovAvgUp0 = New System.Windows.Forms.CheckBox()
        Me.qInDay08 = New System.Windows.Forms.CheckBox()
        Me.bindaypb = New System.Windows.Forms.ProgressBar()
        Me.qInDay07 = New System.Windows.Forms.CheckBox()
        Me.mapbup3 = New System.Windows.Forms.ProgressBar()
        Me.qInDay06 = New System.Windows.Forms.CheckBox()
        Me.mapbup2 = New System.Windows.Forms.ProgressBar()
        Me.qInDay05 = New System.Windows.Forms.CheckBox()
        Me.mapbup1 = New System.Windows.Forms.ProgressBar()
        Me.qInDay04 = New System.Windows.Forms.CheckBox()
        Me.qInDay03 = New System.Windows.Forms.CheckBox()
        Me.qSparkLine = New System.Windows.Forms.CheckBox()
        Me.qCreateSignals = New System.Windows.Forms.CheckBox()
        Me.qCreateKeys = New System.Windows.Forms.CheckBox()
        Me.qUseCurrentData = New System.Windows.Forms.CheckBox()
        Me.qInDay02 = New System.Windows.Forms.CheckBox()
        Me.qInDay01 = New System.Windows.Forms.CheckBox()
        Me.qInDay00 = New System.Windows.Forms.CheckBox()
        Me.qtoThisDay = New System.Windows.Forms.CheckBox()
        Me.qMaxDay5 = New System.Windows.Forms.CheckBox()
        Me.SaveAllSignals = New System.Windows.Forms.CheckBox()
        Me.qEveryDay = New System.Windows.Forms.CheckBox()
        Me.qMaxDay4 = New System.Windows.Forms.CheckBox()
        Me.qMaxDay3 = New System.Windows.Forms.CheckBox()
        Me.qMaxDay2 = New System.Windows.Forms.CheckBox()
        Me.qMaxDay1 = New System.Windows.Forms.CheckBox()
        Me.qMaxDay0 = New System.Windows.Forms.CheckBox()
        Me.qNFrid = New System.Windows.Forms.CheckBox()
        Me.qFrid = New System.Windows.Forms.CheckBox()
        Me.qThurs = New System.Windows.Forms.CheckBox()
        Me.qNThurs = New System.Windows.Forms.CheckBox()
        Me.qNWens = New System.Windows.Forms.CheckBox()
        Me.qMon = New System.Windows.Forms.CheckBox()
        Me.qNMon = New System.Windows.Forms.CheckBox()
        Me.qTues = New System.Windows.Forms.CheckBox()
        Me.qNTues = New System.Windows.Forms.CheckBox()
        Me.qWens = New System.Windows.Forms.CheckBox()
        Me.qCalcCov = New System.Windows.Forms.CheckBox()
        Me.qCalcSparklines = New System.Windows.Forms.CheckBox()
        Me.signalsGrid = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.qAdjustForAfterMidNight = New System.Windows.Forms.CheckBox()
        Me.SymbolGridViewCurrent = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.thisDate1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Updated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.NumberofDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_Securities.SuspendLayout()
        Me.Securities.SuspendLayout()
        Me.SymbolParams_.SuspendLayout()
        CType(Me.SymbolGridViewBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParamFiles_.SuspendLayout()
        Me.Current.SuspendLayout()
        Me.selectSecurities.SuspendLayout()
        CType(Me.DGSignalsByEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Parameters.SuspendLayout()
        CType(Me.adjQThreshHold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QThreshhold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.SymbolGridViewCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Written)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.errorCnt)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ReadFiles)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.adjDate)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Records)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Qavg)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Symbol1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.NumberofDays)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Average)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.NumericUpDown1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Execute_Current)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SecNo_)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.NoSecs)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtSymbol)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.totSeconds)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtItersPerSecond)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.totIterations)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ThisDate)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Result)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TAB_Securities)
        resources.ApplyResources(Me.ToolStripContainer1.ContentPanel, "ToolStripContainer1.ContentPanel")
        resources.ApplyResources(Me.ToolStripContainer1, "ToolStripContainer1")
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'Written
        '
        resources.ApplyResources(Me.Written, "Written")
        Me.Written.Name = "Written"
        '
        'errorCnt
        '
        resources.ApplyResources(Me.errorCnt, "errorCnt")
        Me.errorCnt.Name = "errorCnt"
        '
        'ReadFiles
        '
        resources.ApplyResources(Me.ReadFiles, "ReadFiles")
        Me.ReadFiles.Name = "ReadFiles"
        Me.ReadFiles.UseVisualStyleBackColor = True
        '
        'adjDate
        '
        resources.ApplyResources(Me.adjDate, "adjDate")
        Me.adjDate.Name = "adjDate"
        Me.adjDate.ShowCheckBox = True
        '
        'Records
        '
        resources.ApplyResources(Me.Records, "Records")
        Me.Records.Name = "Records"
        '
        'Qavg
        '
        resources.ApplyResources(Me.Qavg, "Qavg")
        Me.Qavg.Name = "Qavg"
        '
        'Symbol1
        '
        resources.ApplyResources(Me.Symbol1, "Symbol1")
        Me.Symbol1.Name = "Symbol1"
        '
        'NumberofDays
        '
        Me.NumberofDays.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        resources.ApplyResources(Me.NumberofDays, "NumberofDays")
        Me.NumberofDays.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumberofDays.Name = "NumberofDays"
        Me.NumberofDays.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Average
        '
        resources.ApplyResources(Me.Average, "Average")
        Me.Average.Name = "Average"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        resources.ApplyResources(Me.NumericUpDown1, "NumericUpDown1")
        Me.NumericUpDown1.Name = "NumericUpDown1"
        '
        'Execute_Current
        '
        resources.ApplyResources(Me.Execute_Current, "Execute_Current")
        Me.Execute_Current.Name = "Execute_Current"
        Me.Execute_Current.UseVisualStyleBackColor = True
        '
        'SecNo_
        '
        resources.ApplyResources(Me.SecNo_, "SecNo_")
        Me.SecNo_.Name = "SecNo_"
        '
        'NoSecs
        '
        resources.ApplyResources(Me.NoSecs, "NoSecs")
        Me.NoSecs.Name = "NoSecs"
        '
        'txtSymbol
        '
        resources.ApplyResources(Me.txtSymbol, "txtSymbol")
        Me.txtSymbol.Name = "txtSymbol"
        '
        'totSeconds
        '
        resources.ApplyResources(Me.totSeconds, "totSeconds")
        Me.totSeconds.Name = "totSeconds"
        '
        'txtItersPerSecond
        '
        resources.ApplyResources(Me.txtItersPerSecond, "txtItersPerSecond")
        Me.txtItersPerSecond.Name = "txtItersPerSecond"
        '
        'totIterations
        '
        resources.ApplyResources(Me.totIterations, "totIterations")
        Me.totIterations.Name = "totIterations"
        '
        'ThisDate
        '
        resources.ApplyResources(Me.ThisDate, "ThisDate")
        Me.ThisDate.Name = "ThisDate"
        Me.ThisDate.ShowCheckBox = True
        '
        'Result
        '
        resources.ApplyResources(Me.Result, "Result")
        Me.Result.Name = "Result"
        Me.Result.UseVisualStyleBackColor = True
        '
        'TAB_Securities
        '
        Me.TAB_Securities.Controls.Add(Me.Securities)
        Me.TAB_Securities.Controls.Add(Me.SymbolParams_)
        Me.TAB_Securities.Controls.Add(Me.ParamFiles_)
        Me.TAB_Securities.Controls.Add(Me.Current)
        Me.TAB_Securities.Controls.Add(Me.selectSecurities)
        Me.TAB_Securities.Controls.Add(Me.Parameters)
        Me.TAB_Securities.Controls.Add(Me.signalsGrid)
        Me.TAB_Securities.Controls.Add(Me.TabPage1)
        resources.ApplyResources(Me.TAB_Securities, "TAB_Securities")
        Me.TAB_Securities.Name = "TAB_Securities"
        Me.TAB_Securities.SelectedIndex = 0
        '
        'Securities
        '
        Me.Securities.Controls.Add(Me.Set_All)
        Me.Securities.Controls.Add(Me.SecuritiesList)
        resources.ApplyResources(Me.Securities, "Securities")
        Me.Securities.Name = "Securities"
        Me.Securities.UseVisualStyleBackColor = True
        '
        'Set_All
        '
        resources.ApplyResources(Me.Set_All, "Set_All")
        Me.Set_All.Name = "Set_All"
        Me.Set_All.UseVisualStyleBackColor = True
        '
        'SecuritiesList
        '
        Me.SecuritiesList.BackColor = System.Drawing.SystemColors.ScrollBar
        resources.ApplyResources(Me.SecuritiesList, "SecuritiesList")
        Me.SecuritiesList.FormattingEnabled = True
        Me.SecuritiesList.MultiColumn = True
        Me.SecuritiesList.Name = "SecuritiesList"
        Me.SecuritiesList.Sorted = True
        Me.SecuritiesList.ThreeDCheckBoxes = True
        '
        'SymbolParams_
        '
        Me.SymbolParams_.Controls.Add(Me.saveOnlyBaseKeys)
        Me.SymbolParams_.Controls.Add(Me.Execute_Base)
        Me.SymbolParams_.Controls.Add(Me.ReloadBaseData)
        Me.SymbolParams_.Controls.Add(Me.DataFiles)
        Me.SymbolParams_.Controls.Add(Me.SymbolGridViewBase)
        resources.ApplyResources(Me.SymbolParams_, "SymbolParams_")
        Me.SymbolParams_.Name = "SymbolParams_"
        Me.SymbolParams_.UseVisualStyleBackColor = True
        '
        'saveOnlyBaseKeys
        '
        resources.ApplyResources(Me.saveOnlyBaseKeys, "saveOnlyBaseKeys")
        Me.saveOnlyBaseKeys.Checked = True
        Me.saveOnlyBaseKeys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.saveOnlyBaseKeys.Name = "saveOnlyBaseKeys"
        Me.saveOnlyBaseKeys.UseVisualStyleBackColor = True
        '
        'Execute_Base
        '
        resources.ApplyResources(Me.Execute_Base, "Execute_Base")
        Me.Execute_Base.Name = "Execute_Base"
        Me.Execute_Base.UseVisualStyleBackColor = True
        '
        'ReloadBaseData
        '
        resources.ApplyResources(Me.ReloadBaseData, "ReloadBaseData")
        Me.ReloadBaseData.Name = "ReloadBaseData"
        Me.ReloadBaseData.UseVisualStyleBackColor = True
        '
        'DataFiles
        '
        resources.ApplyResources(Me.DataFiles, "DataFiles")
        Me.DataFiles.Name = "DataFiles"
        '
        'SymbolGridViewBase
        '
        Me.SymbolGridViewBase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.SymbolGridViewBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SymbolGridViewBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SecNo, Me.Symbol, Me.Checked, Me.Recs, Me.startDt, Me.endDt, Me.dUp, Me.DDn, Me.LastDOW, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        resources.ApplyResources(Me.SymbolGridViewBase, "SymbolGridViewBase")
        Me.SymbolGridViewBase.MultiSelect = False
        Me.SymbolGridViewBase.Name = "SymbolGridViewBase"
        Me.SymbolGridViewBase.RowTemplate.Height = 28
        '
        'SecNo
        '
        Me.SecNo.DividerWidth = 4
        Me.SecNo.FillWeight = 111.0!
        Me.SecNo.Frozen = True
        resources.ApplyResources(Me.SecNo, "SecNo")
        Me.SecNo.MaxInputLength = 9
        Me.SecNo.Name = "SecNo"
        Me.SecNo.ReadOnly = True
        '
        'Symbol
        '
        resources.ApplyResources(Me.Symbol, "Symbol")
        Me.Symbol.MaxInputLength = 25
        Me.Symbol.Name = "Symbol"
        Me.Symbol.ReadOnly = True
        '
        'Checked
        '
        resources.ApplyResources(Me.Checked, "Checked")
        Me.Checked.Name = "Checked"
        Me.Checked.ReadOnly = True
        '
        'Recs
        '
        resources.ApplyResources(Me.Recs, "Recs")
        Me.Recs.MaxInputLength = 7
        Me.Recs.Name = "Recs"
        Me.Recs.ReadOnly = True
        '
        'startDt
        '
        Me.startDt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        resources.ApplyResources(Me.startDt, "startDt")
        Me.startDt.MaxInputLength = 10
        Me.startDt.Name = "startDt"
        Me.startDt.ReadOnly = True
        '
        'endDt
        '
        Me.endDt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        resources.ApplyResources(Me.endDt, "endDt")
        Me.endDt.MaxInputLength = 10
        Me.endDt.Name = "endDt"
        Me.endDt.ReadOnly = True
        '
        'dUp
        '
        Me.dUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        resources.ApplyResources(Me.dUp, "dUp")
        Me.dUp.MaxInputLength = 9
        Me.dUp.Name = "dUp"
        Me.dUp.ReadOnly = True
        '
        'DDn
        '
        Me.DDn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        resources.ApplyResources(Me.DDn, "DDn")
        Me.DDn.MaxInputLength = 9
        Me.DDn.Name = "DDn"
        Me.DDn.ReadOnly = True
        '
        'LastDOW
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.LastDOW.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.LastDOW, "LastDOW")
        Me.LastDOW.MaxInputLength = 9
        Me.LastDOW.Name = "LastDOW"
        '
        'DataGridViewTextBoxColumn9
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn9, "DataGridViewTextBoxColumn9")
        Me.DataGridViewTextBoxColumn9.MaxInputLength = 155
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn10, "DataGridViewTextBoxColumn10")
        Me.DataGridViewTextBoxColumn10.MaxInputLength = 11
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn11, "DataGridViewTextBoxColumn11")
        Me.DataGridViewTextBoxColumn11.MaxInputLength = 11
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'ParamFiles_
        '
        Me.ParamFiles_.Controls.Add(Me.Button3)
        Me.ParamFiles_.Controls.Add(Me.Button2)
        Me.ParamFiles_.Controls.Add(Me.Button1)
        Me.ParamFiles_.Controls.Add(Me.CoSecuritiesListBox)
        Me.ParamFiles_.Controls.Add(Me.SecuritiesListBox)
        Me.ParamFiles_.Controls.Add(Me.Label2)
        Me.ParamFiles_.Controls.Add(Me.CurrentDataFiles)
        Me.ParamFiles_.Controls.Add(Me.Label1)
        Me.ParamFiles_.Controls.Add(Me.LinkLabelData)
        Me.ParamFiles_.Controls.Add(Me.BaseDataFiles)
        Me.ParamFiles_.Controls.Add(Me.dbSymbols)
        Me.ParamFiles_.Controls.Add(Me.dbSignals)
        Me.ParamFiles_.Controls.Add(Me.dbTrades)
        resources.ApplyResources(Me.ParamFiles_, "ParamFiles_")
        Me.ParamFiles_.Name = "ParamFiles_"
        Me.ParamFiles_.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CoSecuritiesListBox
        '
        Me.CoSecuritiesListBox.FormattingEnabled = True
        resources.ApplyResources(Me.CoSecuritiesListBox, "CoSecuritiesListBox")
        Me.CoSecuritiesListBox.MultiColumn = True
        Me.CoSecuritiesListBox.Name = "CoSecuritiesListBox"
        '
        'SecuritiesListBox
        '
        Me.SecuritiesListBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        resources.ApplyResources(Me.SecuritiesListBox, "SecuritiesListBox")
        Me.SecuritiesListBox.FormattingEnabled = True
        Me.SecuritiesListBox.MultiColumn = True
        Me.SecuritiesListBox.Name = "SecuritiesListBox"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'CurrentDataFiles
        '
        resources.ApplyResources(Me.CurrentDataFiles, "CurrentDataFiles")
        Me.CurrentDataFiles.Name = "CurrentDataFiles"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LinkLabelData
        '
        resources.ApplyResources(Me.LinkLabelData, "LinkLabelData")
        Me.LinkLabelData.Name = "LinkLabelData"
        Me.LinkLabelData.TabStop = True
        '
        'BaseDataFiles
        '
        resources.ApplyResources(Me.BaseDataFiles, "BaseDataFiles")
        Me.BaseDataFiles.Name = "BaseDataFiles"
        '
        'dbSymbols
        '
        resources.ApplyResources(Me.dbSymbols, "dbSymbols")
        Me.dbSymbols.Name = "dbSymbols"
        '
        'dbSignals
        '
        resources.ApplyResources(Me.dbSignals, "dbSignals")
        Me.dbSignals.Name = "dbSignals"
        '
        'dbTrades
        '
        resources.ApplyResources(Me.dbTrades, "dbTrades")
        Me.dbTrades.Name = "dbTrades"
        '
        'Current
        '
        Me.Current.Controls.Add(Me.CoThisDayDOW)
        Me.Current.Controls.Add(Me.coEndDayDate)
        Me.Current.Controls.Add(Me.coFirstDayDate)
        Me.Current.Controls.Add(Me.coLastDayDate)
        Me.Current.Controls.Add(Me.coThisDayDate)
        Me.Current.Controls.Add(Me.coThisDayNo)
        Me.Current.Controls.Add(Me.coLastDayNo)
        Me.Current.Controls.Add(Me.coFirstDayNo)
        Me.Current.Controls.Add(Me.coEndDayNo)
        Me.Current.Controls.Add(Me.coStartDayDate)
        Me.Current.Controls.Add(Me.coStartDayNo)
        Me.Current.Controls.Add(Me.Label12)
        Me.Current.Controls.Add(Me.Label11)
        Me.Current.Controls.Add(Me.Label10)
        Me.Current.Controls.Add(Me.Label9)
        Me.Current.Controls.Add(Me.Label8)
        Me.Current.Controls.Add(Me.CoSymbolTxt)
        Me.Current.Controls.Add(Me.thisDayDOW)
        Me.Current.Controls.Add(Me.Label7)
        Me.Current.Controls.Add(Me.Label6)
        Me.Current.Controls.Add(Me.Label5)
        Me.Current.Controls.Add(Me.Label4)
        Me.Current.Controls.Add(Me.Label3)
        Me.Current.Controls.Add(Me.symbolTxt)
        Me.Current.Controls.Add(Me.EndDayDate)
        Me.Current.Controls.Add(Me.EndDayNo)
        Me.Current.Controls.Add(Me.ThisDayNo)
        Me.Current.Controls.Add(Me.ThisDayDate)
        Me.Current.Controls.Add(Me.LastDayDate)
        Me.Current.Controls.Add(Me.LastDayNo)
        Me.Current.Controls.Add(Me.FirstDayDate)
        Me.Current.Controls.Add(Me.FirstDayNo)
        Me.Current.Controls.Add(Me.StartDayDate)
        Me.Current.Controls.Add(Me.StartDayNo)
        Me.Current.Controls.Add(Me.ReloadCurrentData)
        Me.Current.Controls.Add(Me.TextBox1)
        resources.ApplyResources(Me.Current, "Current")
        Me.Current.Name = "Current"
        Me.Current.UseVisualStyleBackColor = True
        '
        'CoThisDayDOW
        '
        resources.ApplyResources(Me.CoThisDayDOW, "CoThisDayDOW")
        Me.CoThisDayDOW.Name = "CoThisDayDOW"
        '
        'coEndDayDate
        '
        resources.ApplyResources(Me.coEndDayDate, "coEndDayDate")
        Me.coEndDayDate.Name = "coEndDayDate"
        '
        'coFirstDayDate
        '
        resources.ApplyResources(Me.coFirstDayDate, "coFirstDayDate")
        Me.coFirstDayDate.Name = "coFirstDayDate"
        '
        'coLastDayDate
        '
        resources.ApplyResources(Me.coLastDayDate, "coLastDayDate")
        Me.coLastDayDate.Name = "coLastDayDate"
        '
        'coThisDayDate
        '
        resources.ApplyResources(Me.coThisDayDate, "coThisDayDate")
        Me.coThisDayDate.Name = "coThisDayDate"
        '
        'coThisDayNo
        '
        resources.ApplyResources(Me.coThisDayNo, "coThisDayNo")
        Me.coThisDayNo.Name = "coThisDayNo"
        '
        'coLastDayNo
        '
        resources.ApplyResources(Me.coLastDayNo, "coLastDayNo")
        Me.coLastDayNo.Name = "coLastDayNo"
        '
        'coFirstDayNo
        '
        resources.ApplyResources(Me.coFirstDayNo, "coFirstDayNo")
        Me.coFirstDayNo.Name = "coFirstDayNo"
        '
        'coEndDayNo
        '
        resources.ApplyResources(Me.coEndDayNo, "coEndDayNo")
        Me.coEndDayNo.Name = "coEndDayNo"
        '
        'coStartDayDate
        '
        resources.ApplyResources(Me.coStartDayDate, "coStartDayDate")
        Me.coStartDayDate.Name = "coStartDayDate"
        '
        'coStartDayNo
        '
        resources.ApplyResources(Me.coStartDayNo, "coStartDayNo")
        Me.coStartDayNo.Name = "coStartDayNo"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'CoSymbolTxt
        '
        resources.ApplyResources(Me.CoSymbolTxt, "CoSymbolTxt")
        Me.CoSymbolTxt.Name = "CoSymbolTxt"
        '
        'thisDayDOW
        '
        resources.ApplyResources(Me.thisDayDOW, "thisDayDOW")
        Me.thisDayDOW.Name = "thisDayDOW"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'symbolTxt
        '
        resources.ApplyResources(Me.symbolTxt, "symbolTxt")
        Me.symbolTxt.Name = "symbolTxt"
        '
        'EndDayDate
        '
        resources.ApplyResources(Me.EndDayDate, "EndDayDate")
        Me.EndDayDate.Name = "EndDayDate"
        '
        'EndDayNo
        '
        resources.ApplyResources(Me.EndDayNo, "EndDayNo")
        Me.EndDayNo.Name = "EndDayNo"
        '
        'ThisDayNo
        '
        resources.ApplyResources(Me.ThisDayNo, "ThisDayNo")
        Me.ThisDayNo.Name = "ThisDayNo"
        '
        'ThisDayDate
        '
        resources.ApplyResources(Me.ThisDayDate, "ThisDayDate")
        Me.ThisDayDate.Name = "ThisDayDate"
        '
        'LastDayDate
        '
        resources.ApplyResources(Me.LastDayDate, "LastDayDate")
        Me.LastDayDate.Name = "LastDayDate"
        '
        'LastDayNo
        '
        resources.ApplyResources(Me.LastDayNo, "LastDayNo")
        Me.LastDayNo.Name = "LastDayNo"
        '
        'FirstDayDate
        '
        resources.ApplyResources(Me.FirstDayDate, "FirstDayDate")
        Me.FirstDayDate.Name = "FirstDayDate"
        '
        'FirstDayNo
        '
        resources.ApplyResources(Me.FirstDayNo, "FirstDayNo")
        Me.FirstDayNo.Name = "FirstDayNo"
        '
        'StartDayDate
        '
        resources.ApplyResources(Me.StartDayDate, "StartDayDate")
        Me.StartDayDate.Name = "StartDayDate"
        '
        'StartDayNo
        '
        resources.ApplyResources(Me.StartDayNo, "StartDayNo")
        Me.StartDayNo.Name = "StartDayNo"
        '
        'ReloadCurrentData
        '
        resources.ApplyResources(Me.ReloadCurrentData, "ReloadCurrentData")
        Me.ReloadCurrentData.Name = "ReloadCurrentData"
        Me.ReloadCurrentData.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'selectSecurities
        '
        Me.selectSecurities.Controls.Add(Me.Cl0nnCl)
        Me.selectSecurities.Controls.Add(Me.Cl0nnOp)
        Me.selectSecurities.Controls.Add(Me.Cl0nCl)
        Me.selectSecurities.Controls.Add(Me.nOp0nnOp)
        Me.selectSecurities.Controls.Add(Me.nOp0nnCl)
        Me.selectSecurities.Controls.Add(Me.nCl0nnCl)
        Me.selectSecurities.Controls.Add(Me.nCl0nnOp)
        Me.selectSecurities.Controls.Add(Me.qShowDG)
        Me.selectSecurities.Controls.Add(Me.qshowByEntryData)
        Me.selectSecurities.Controls.Add(Me.DGSignalsByEntry)
        Me.selectSecurities.Controls.Add(Me.ListBox1)
        Me.selectSecurities.Controls.Add(Me.Cl0nOp)
        Me.selectSecurities.Controls.Add(Me.thisClose)
        Me.selectSecurities.Controls.Add(Me.nOp0nCl)
        Me.selectSecurities.Controls.Add(Me.nextClose)
        Me.selectSecurities.Controls.Add(Me.nextOpen)
        resources.ApplyResources(Me.selectSecurities, "selectSecurities")
        Me.selectSecurities.Name = "selectSecurities"
        Me.selectSecurities.UseVisualStyleBackColor = True
        '
        'Cl0nnCl
        '
        resources.ApplyResources(Me.Cl0nnCl, "Cl0nnCl")
        Me.Cl0nnCl.Name = "Cl0nnCl"
        '
        'Cl0nnOp
        '
        resources.ApplyResources(Me.Cl0nnOp, "Cl0nnOp")
        Me.Cl0nnOp.Name = "Cl0nnOp"
        '
        'Cl0nCl
        '
        resources.ApplyResources(Me.Cl0nCl, "Cl0nCl")
        Me.Cl0nCl.Name = "Cl0nCl"
        '
        'nOp0nnOp
        '
        resources.ApplyResources(Me.nOp0nnOp, "nOp0nnOp")
        Me.nOp0nnOp.Name = "nOp0nnOp"
        '
        'nOp0nnCl
        '
        resources.ApplyResources(Me.nOp0nnCl, "nOp0nnCl")
        Me.nOp0nnCl.Name = "nOp0nnCl"
        '
        'nCl0nnCl
        '
        resources.ApplyResources(Me.nCl0nnCl, "nCl0nnCl")
        Me.nCl0nnCl.Name = "nCl0nnCl"
        '
        'nCl0nnOp
        '
        resources.ApplyResources(Me.nCl0nnOp, "nCl0nnOp")
        Me.nCl0nnOp.Name = "nCl0nnOp"
        '
        'qShowDG
        '
        resources.ApplyResources(Me.qShowDG, "qShowDG")
        Me.qShowDG.Name = "qShowDG"
        Me.qShowDG.UseVisualStyleBackColor = True
        '
        'qshowByEntryData
        '
        resources.ApplyResources(Me.qshowByEntryData, "qshowByEntryData")
        Me.qshowByEntryData.Name = "qshowByEntryData"
        Me.qshowByEntryData.UseVisualStyleBackColor = True
        '
        'DGSignalsByEntry
        '
        Me.DGSignalsByEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSignalsByEntry.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Symb, Me.DOW, Me.movAvg, Me.ZScrMode, Me.bInDay, Me.Entry, Me.maxDH, Me.sExit, Me.iters, Me.totIters, Me.Q, Me.totQ, Me.avgQ})
        resources.ApplyResources(Me.DGSignalsByEntry, "DGSignalsByEntry")
        Me.DGSignalsByEntry.Name = "DGSignalsByEntry"
        '
        'Symb
        '
        resources.ApplyResources(Me.Symb, "Symb")
        Me.Symb.MaxInputLength = 9
        Me.Symb.Name = "Symb"
        '
        'DOW
        '
        resources.ApplyResources(Me.DOW, "DOW")
        Me.DOW.MaxInputLength = 7
        Me.DOW.Name = "DOW"
        '
        'movAvg
        '
        resources.ApplyResources(Me.movAvg, "movAvg")
        Me.movAvg.MaxInputLength = 29
        Me.movAvg.Name = "movAvg"
        '
        'ZScrMode
        '
        resources.ApplyResources(Me.ZScrMode, "ZScrMode")
        Me.ZScrMode.MaxInputLength = 29
        Me.ZScrMode.Name = "ZScrMode"
        '
        'bInDay
        '
        resources.ApplyResources(Me.bInDay, "bInDay")
        Me.bInDay.MaxInputLength = 13
        Me.bInDay.Name = "bInDay"
        '
        'Entry
        '
        resources.ApplyResources(Me.Entry, "Entry")
        Me.Entry.MaxInputLength = 9
        Me.Entry.Name = "Entry"
        '
        'maxDH
        '
        resources.ApplyResources(Me.maxDH, "maxDH")
        Me.maxDH.MaxInputLength = 4
        Me.maxDH.Name = "maxDH"
        '
        'sExit
        '
        resources.ApplyResources(Me.sExit, "sExit")
        Me.sExit.MaxInputLength = 9
        Me.sExit.Name = "sExit"
        '
        'iters
        '
        resources.ApplyResources(Me.iters, "iters")
        Me.iters.MaxInputLength = 9
        Me.iters.Name = "iters"
        '
        'totIters
        '
        resources.ApplyResources(Me.totIters, "totIters")
        Me.totIters.MaxInputLength = 13
        Me.totIters.Name = "totIters"
        '
        'Q
        '
        resources.ApplyResources(Me.Q, "Q")
        Me.Q.Name = "Q"
        '
        'totQ
        '
        resources.ApplyResources(Me.totQ, "totQ")
        Me.totQ.MaxInputLength = 11
        Me.totQ.Name = "totQ"
        '
        'avgQ
        '
        resources.ApplyResources(Me.avgQ, "avgQ")
        Me.avgQ.MaxInputLength = 7
        Me.avgQ.Name = "avgQ"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        resources.ApplyResources(Me.ListBox1, "ListBox1")
        Me.ListBox1.Name = "ListBox1"
        '
        'Cl0nOp
        '
        resources.ApplyResources(Me.Cl0nOp, "Cl0nOp")
        Me.Cl0nOp.Name = "Cl0nOp"
        '
        'thisClose
        '
        resources.ApplyResources(Me.thisClose, "thisClose")
        Me.thisClose.Name = "thisClose"
        Me.thisClose.UseVisualStyleBackColor = True
        '
        'nOp0nCl
        '
        resources.ApplyResources(Me.nOp0nCl, "nOp0nCl")
        Me.nOp0nCl.Name = "nOp0nCl"
        '
        'nextClose
        '
        resources.ApplyResources(Me.nextClose, "nextClose")
        Me.nextClose.Name = "nextClose"
        Me.nextClose.UseVisualStyleBackColor = True
        '
        'nextOpen
        '
        resources.ApplyResources(Me.nextOpen, "nextOpen")
        Me.nextOpen.Name = "nextOpen"
        Me.nextOpen.UseVisualStyleBackColor = True
        '
        'Parameters
        '
        resources.ApplyResources(Me.Parameters, "Parameters")
        Me.Parameters.Controls.Add(Me.sTargetProfit50)
        Me.Parameters.Controls.Add(Me.sTargetProfit40)
        Me.Parameters.Controls.Add(Me.sTargetProfit30)
        Me.Parameters.Controls.Add(Me.sTargetProfit20)
        Me.Parameters.Controls.Add(Me.sTargetProfit10)
        Me.Parameters.Controls.Add(Me.sTargetProfit00)
        Me.Parameters.Controls.Add(Me.MApbUp4)
        Me.Parameters.Controls.Add(Me.Label18)
        Me.Parameters.Controls.Add(Me.Label15)
        Me.Parameters.Controls.Add(Me.Label13)
        Me.Parameters.Controls.Add(Me.adjQThreshHold)
        Me.Parameters.Controls.Add(Me.QThreshhold)
        Me.Parameters.Controls.Add(Me.Model09)
        Me.Parameters.Controls.Add(Me.Model08)
        Me.Parameters.Controls.Add(Me.Model07)
        Me.Parameters.Controls.Add(Me.Model06)
        Me.Parameters.Controls.Add(Me.Model05)
        Me.Parameters.Controls.Add(Me.Model04)
        Me.Parameters.Controls.Add(Me.Model03)
        Me.Parameters.Controls.Add(Me.Model02)
        Me.Parameters.Controls.Add(Me.Model01)
        Me.Parameters.Controls.Add(Me.Model00)
        Me.Parameters.Controls.Add(Me.ZScrRank9)
        Me.Parameters.Controls.Add(Me.ZScrRank8)
        Me.Parameters.Controls.Add(Me.ZScrRank7)
        Me.Parameters.Controls.Add(Me.ZScrRank6)
        Me.Parameters.Controls.Add(Me.ZScrRank5)
        Me.Parameters.Controls.Add(Me.ZScrRank4)
        Me.Parameters.Controls.Add(Me.ZScrRank3)
        Me.Parameters.Controls.Add(Me.ZScrRank2)
        Me.Parameters.Controls.Add(Me.ZScrRank1)
        Me.Parameters.Controls.Add(Me.ZScrRank0)
        Me.Parameters.Controls.Add(Me.qZOffSet1)
        Me.Parameters.Controls.Add(Me.qZOffSet5)
        Me.Parameters.Controls.Add(Me.qZOffSet4)
        Me.Parameters.Controls.Add(Me.qZOffSet3)
        Me.Parameters.Controls.Add(Me.qZOffSet2)
        Me.Parameters.Controls.Add(Me.qZOffSet0)
        Me.Parameters.Controls.Add(Me.qZPP)
        Me.Parameters.Controls.Add(Me.qZP_)
        Me.Parameters.Controls.Add(Me.qZNN)
        Me.Parameters.Controls.Add(Me.qZN_)
        Me.Parameters.Controls.Add(Me.qZBase)
        Me.Parameters.Controls.Add(Me.qInDay10)
        Me.Parameters.Controls.Add(Me.qInDay09)
        Me.Parameters.Controls.Add(Me.qMovAvgDn0)
        Me.Parameters.Controls.Add(Me.qMaxDay10)
        Me.Parameters.Controls.Add(Me.qMaxDay9)
        Me.Parameters.Controls.Add(Me.mapbdn1)
        Me.Parameters.Controls.Add(Me.qMaxDay8)
        Me.Parameters.Controls.Add(Me.mapbdn2)
        Me.Parameters.Controls.Add(Me.qMaxDay7)
        Me.Parameters.Controls.Add(Me.mapbdn3)
        Me.Parameters.Controls.Add(Me.qMaxDay6)
        Me.Parameters.Controls.Add(Me.qMovAvgUp0)
        Me.Parameters.Controls.Add(Me.qInDay08)
        Me.Parameters.Controls.Add(Me.bindaypb)
        Me.Parameters.Controls.Add(Me.qInDay07)
        Me.Parameters.Controls.Add(Me.mapbup3)
        Me.Parameters.Controls.Add(Me.qInDay06)
        Me.Parameters.Controls.Add(Me.mapbup2)
        Me.Parameters.Controls.Add(Me.qInDay05)
        Me.Parameters.Controls.Add(Me.mapbup1)
        Me.Parameters.Controls.Add(Me.qInDay04)
        Me.Parameters.Controls.Add(Me.qInDay03)
        Me.Parameters.Controls.Add(Me.qSparkLine)
        Me.Parameters.Controls.Add(Me.qCreateSignals)
        Me.Parameters.Controls.Add(Me.qCreateKeys)
        Me.Parameters.Controls.Add(Me.qUseCurrentData)
        Me.Parameters.Controls.Add(Me.qInDay02)
        Me.Parameters.Controls.Add(Me.qInDay01)
        Me.Parameters.Controls.Add(Me.qInDay00)
        Me.Parameters.Controls.Add(Me.qtoThisDay)
        Me.Parameters.Controls.Add(Me.qMaxDay5)
        Me.Parameters.Controls.Add(Me.SaveAllSignals)
        Me.Parameters.Controls.Add(Me.qEveryDay)
        Me.Parameters.Controls.Add(Me.qMaxDay4)
        Me.Parameters.Controls.Add(Me.qMaxDay3)
        Me.Parameters.Controls.Add(Me.qMaxDay2)
        Me.Parameters.Controls.Add(Me.qMaxDay1)
        Me.Parameters.Controls.Add(Me.qMaxDay0)
        Me.Parameters.Controls.Add(Me.qNFrid)
        Me.Parameters.Controls.Add(Me.qFrid)
        Me.Parameters.Controls.Add(Me.qThurs)
        Me.Parameters.Controls.Add(Me.qNThurs)
        Me.Parameters.Controls.Add(Me.qNWens)
        Me.Parameters.Controls.Add(Me.qMon)
        Me.Parameters.Controls.Add(Me.qNMon)
        Me.Parameters.Controls.Add(Me.qTues)
        Me.Parameters.Controls.Add(Me.qNTues)
        Me.Parameters.Controls.Add(Me.qWens)
        Me.Parameters.Controls.Add(Me.qCalcCov)
        Me.Parameters.Controls.Add(Me.qCalcSparklines)
        Me.Parameters.Name = "Parameters"
        Me.Parameters.UseVisualStyleBackColor = True
        '
        'sTargetProfit50
        '
        resources.ApplyResources(Me.sTargetProfit50, "sTargetProfit50")
        Me.sTargetProfit50.Name = "sTargetProfit50"
        Me.sTargetProfit50.ThreeState = True
        Me.sTargetProfit50.UseVisualStyleBackColor = True
        '
        'sTargetProfit40
        '
        resources.ApplyResources(Me.sTargetProfit40, "sTargetProfit40")
        Me.sTargetProfit40.Name = "sTargetProfit40"
        Me.sTargetProfit40.ThreeState = True
        Me.sTargetProfit40.UseVisualStyleBackColor = True
        '
        'sTargetProfit30
        '
        resources.ApplyResources(Me.sTargetProfit30, "sTargetProfit30")
        Me.sTargetProfit30.Name = "sTargetProfit30"
        Me.sTargetProfit30.ThreeState = True
        Me.sTargetProfit30.UseVisualStyleBackColor = True
        '
        'sTargetProfit20
        '
        resources.ApplyResources(Me.sTargetProfit20, "sTargetProfit20")
        Me.sTargetProfit20.Name = "sTargetProfit20"
        Me.sTargetProfit20.ThreeState = True
        Me.sTargetProfit20.UseVisualStyleBackColor = True
        '
        'sTargetProfit10
        '
        resources.ApplyResources(Me.sTargetProfit10, "sTargetProfit10")
        Me.sTargetProfit10.Name = "sTargetProfit10"
        Me.sTargetProfit10.ThreeState = True
        Me.sTargetProfit10.UseVisualStyleBackColor = True
        '
        'sTargetProfit00
        '
        resources.ApplyResources(Me.sTargetProfit00, "sTargetProfit00")
        Me.sTargetProfit00.Name = "sTargetProfit00"
        Me.sTargetProfit00.ThreeState = True
        Me.sTargetProfit00.UseVisualStyleBackColor = True
        '
        'MApbUp4
        '
        resources.ApplyResources(Me.MApbUp4, "MApbUp4")
        Me.MApbUp4.Maximum = 4
        Me.MApbUp4.Name = "MApbUp4"
        Me.MApbUp4.Step = 1
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'adjQThreshHold
        '
        Me.adjQThreshHold.DecimalPlaces = 2
        resources.ApplyResources(Me.adjQThreshHold, "adjQThreshHold")
        Me.adjQThreshHold.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.adjQThreshHold.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.adjQThreshHold.Name = "adjQThreshHold"
        Me.adjQThreshHold.Value = New Decimal(New Integer() {10500, 0, 0, 131072})
        '
        'QThreshhold
        '
        Me.QThreshhold.DecimalPlaces = 2
        Me.QThreshhold.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        resources.ApplyResources(Me.QThreshhold, "QThreshhold")
        Me.QThreshhold.Name = "QThreshhold"
        Me.QThreshhold.Value = New Decimal(New Integer() {175, 0, 0, 131072})
        '
        'Model09
        '
        resources.ApplyResources(Me.Model09, "Model09")
        Me.Model09.Name = "Model09"
        Me.Model09.ThreeState = True
        Me.Model09.UseVisualStyleBackColor = True
        '
        'Model08
        '
        resources.ApplyResources(Me.Model08, "Model08")
        Me.Model08.Name = "Model08"
        Me.Model08.ThreeState = True
        Me.Model08.UseVisualStyleBackColor = True
        '
        'Model07
        '
        resources.ApplyResources(Me.Model07, "Model07")
        Me.Model07.Name = "Model07"
        Me.Model07.ThreeState = True
        Me.Model07.UseVisualStyleBackColor = True
        '
        'Model06
        '
        resources.ApplyResources(Me.Model06, "Model06")
        Me.Model06.Name = "Model06"
        Me.Model06.ThreeState = True
        Me.Model06.UseVisualStyleBackColor = True
        '
        'Model05
        '
        resources.ApplyResources(Me.Model05, "Model05")
        Me.Model05.Name = "Model05"
        Me.Model05.ThreeState = True
        Me.Model05.UseVisualStyleBackColor = True
        '
        'Model04
        '
        resources.ApplyResources(Me.Model04, "Model04")
        Me.Model04.Name = "Model04"
        Me.Model04.ThreeState = True
        Me.Model04.UseVisualStyleBackColor = True
        '
        'Model03
        '
        resources.ApplyResources(Me.Model03, "Model03")
        Me.Model03.Name = "Model03"
        Me.Model03.ThreeState = True
        Me.Model03.UseVisualStyleBackColor = True
        '
        'Model02
        '
        resources.ApplyResources(Me.Model02, "Model02")
        Me.Model02.Name = "Model02"
        Me.Model02.ThreeState = True
        Me.Model02.UseVisualStyleBackColor = True
        '
        'Model01
        '
        resources.ApplyResources(Me.Model01, "Model01")
        Me.Model01.Name = "Model01"
        Me.Model01.ThreeState = True
        Me.Model01.UseVisualStyleBackColor = True
        '
        'Model00
        '
        resources.ApplyResources(Me.Model00, "Model00")
        Me.Model00.Name = "Model00"
        Me.Model00.ThreeState = True
        Me.Model00.UseVisualStyleBackColor = True
        '
        'ZScrRank9
        '
        resources.ApplyResources(Me.ZScrRank9, "ZScrRank9")
        Me.ZScrRank9.Name = "ZScrRank9"
        Me.ZScrRank9.ThreeState = True
        Me.ZScrRank9.UseVisualStyleBackColor = True
        '
        'ZScrRank8
        '
        resources.ApplyResources(Me.ZScrRank8, "ZScrRank8")
        Me.ZScrRank8.Name = "ZScrRank8"
        Me.ZScrRank8.ThreeState = True
        Me.ZScrRank8.UseVisualStyleBackColor = True
        '
        'ZScrRank7
        '
        resources.ApplyResources(Me.ZScrRank7, "ZScrRank7")
        Me.ZScrRank7.Name = "ZScrRank7"
        Me.ZScrRank7.ThreeState = True
        Me.ZScrRank7.UseVisualStyleBackColor = True
        '
        'ZScrRank6
        '
        resources.ApplyResources(Me.ZScrRank6, "ZScrRank6")
        Me.ZScrRank6.Name = "ZScrRank6"
        Me.ZScrRank6.ThreeState = True
        Me.ZScrRank6.UseVisualStyleBackColor = True
        '
        'ZScrRank5
        '
        resources.ApplyResources(Me.ZScrRank5, "ZScrRank5")
        Me.ZScrRank5.Name = "ZScrRank5"
        Me.ZScrRank5.ThreeState = True
        Me.ZScrRank5.UseVisualStyleBackColor = True
        '
        'ZScrRank4
        '
        resources.ApplyResources(Me.ZScrRank4, "ZScrRank4")
        Me.ZScrRank4.Name = "ZScrRank4"
        Me.ZScrRank4.ThreeState = True
        Me.ZScrRank4.UseVisualStyleBackColor = True
        '
        'ZScrRank3
        '
        resources.ApplyResources(Me.ZScrRank3, "ZScrRank3")
        Me.ZScrRank3.Name = "ZScrRank3"
        Me.ZScrRank3.ThreeState = True
        Me.ZScrRank3.UseVisualStyleBackColor = True
        '
        'ZScrRank2
        '
        resources.ApplyResources(Me.ZScrRank2, "ZScrRank2")
        Me.ZScrRank2.Name = "ZScrRank2"
        Me.ZScrRank2.ThreeState = True
        Me.ZScrRank2.UseVisualStyleBackColor = True
        '
        'ZScrRank1
        '
        resources.ApplyResources(Me.ZScrRank1, "ZScrRank1")
        Me.ZScrRank1.Name = "ZScrRank1"
        Me.ZScrRank1.ThreeState = True
        Me.ZScrRank1.UseVisualStyleBackColor = True
        '
        'ZScrRank0
        '
        resources.ApplyResources(Me.ZScrRank0, "ZScrRank0")
        Me.ZScrRank0.Name = "ZScrRank0"
        Me.ZScrRank0.ThreeState = True
        Me.ZScrRank0.UseVisualStyleBackColor = True
        '
        'qZOffSet1
        '
        resources.ApplyResources(Me.qZOffSet1, "qZOffSet1")
        Me.qZOffSet1.Name = "qZOffSet1"
        Me.qZOffSet1.ThreeState = True
        Me.qZOffSet1.UseVisualStyleBackColor = True
        '
        'qZOffSet5
        '
        resources.ApplyResources(Me.qZOffSet5, "qZOffSet5")
        Me.qZOffSet5.Name = "qZOffSet5"
        Me.qZOffSet5.ThreeState = True
        Me.qZOffSet5.UseVisualStyleBackColor = True
        '
        'qZOffSet4
        '
        resources.ApplyResources(Me.qZOffSet4, "qZOffSet4")
        Me.qZOffSet4.Name = "qZOffSet4"
        Me.qZOffSet4.ThreeState = True
        Me.qZOffSet4.UseVisualStyleBackColor = True
        '
        'qZOffSet3
        '
        resources.ApplyResources(Me.qZOffSet3, "qZOffSet3")
        Me.qZOffSet3.Name = "qZOffSet3"
        Me.qZOffSet3.ThreeState = True
        Me.qZOffSet3.UseVisualStyleBackColor = True
        '
        'qZOffSet2
        '
        resources.ApplyResources(Me.qZOffSet2, "qZOffSet2")
        Me.qZOffSet2.Name = "qZOffSet2"
        Me.qZOffSet2.ThreeState = True
        Me.qZOffSet2.UseVisualStyleBackColor = True
        '
        'qZOffSet0
        '
        resources.ApplyResources(Me.qZOffSet0, "qZOffSet0")
        Me.qZOffSet0.Name = "qZOffSet0"
        Me.qZOffSet0.ThreeState = True
        Me.qZOffSet0.UseVisualStyleBackColor = True
        '
        'qZPP
        '
        resources.ApplyResources(Me.qZPP, "qZPP")
        Me.qZPP.Name = "qZPP"
        Me.qZPP.ThreeState = True
        Me.qZPP.UseVisualStyleBackColor = True
        '
        'qZP_
        '
        resources.ApplyResources(Me.qZP_, "qZP_")
        Me.qZP_.Name = "qZP_"
        Me.qZP_.ThreeState = True
        Me.qZP_.UseVisualStyleBackColor = True
        '
        'qZNN
        '
        resources.ApplyResources(Me.qZNN, "qZNN")
        Me.qZNN.Name = "qZNN"
        Me.qZNN.ThreeState = True
        Me.qZNN.UseVisualStyleBackColor = True
        '
        'qZN_
        '
        resources.ApplyResources(Me.qZN_, "qZN_")
        Me.qZN_.Name = "qZN_"
        Me.qZN_.ThreeState = True
        Me.qZN_.UseVisualStyleBackColor = True
        '
        'qZBase
        '
        resources.ApplyResources(Me.qZBase, "qZBase")
        Me.qZBase.Name = "qZBase"
        Me.qZBase.ThreeState = True
        Me.qZBase.UseVisualStyleBackColor = True
        '
        'qInDay10
        '
        resources.ApplyResources(Me.qInDay10, "qInDay10")
        Me.qInDay10.Checked = True
        Me.qInDay10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay10.Name = "qInDay10"
        Me.qInDay10.UseVisualStyleBackColor = True
        '
        'qInDay09
        '
        resources.ApplyResources(Me.qInDay09, "qInDay09")
        Me.qInDay09.Checked = True
        Me.qInDay09.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay09.Name = "qInDay09"
        Me.qInDay09.UseVisualStyleBackColor = True
        '
        'qMovAvgDn0
        '
        resources.ApplyResources(Me.qMovAvgDn0, "qMovAvgDn0")
        Me.qMovAvgDn0.Name = "qMovAvgDn0"
        Me.qMovAvgDn0.UseVisualStyleBackColor = True
        '
        'qMaxDay10
        '
        resources.ApplyResources(Me.qMaxDay10, "qMaxDay10")
        Me.qMaxDay10.Name = "qMaxDay10"
        Me.qMaxDay10.UseVisualStyleBackColor = True
        '
        'qMaxDay9
        '
        resources.ApplyResources(Me.qMaxDay9, "qMaxDay9")
        Me.qMaxDay9.Name = "qMaxDay9"
        Me.qMaxDay9.UseVisualStyleBackColor = True
        '
        'mapbdn1
        '
        resources.ApplyResources(Me.mapbdn1, "mapbdn1")
        Me.mapbdn1.Maximum = 9
        Me.mapbdn1.Name = "mapbdn1"
        Me.mapbdn1.Step = 1
        '
        'qMaxDay8
        '
        resources.ApplyResources(Me.qMaxDay8, "qMaxDay8")
        Me.qMaxDay8.Name = "qMaxDay8"
        Me.qMaxDay8.UseVisualStyleBackColor = True
        '
        'mapbdn2
        '
        resources.ApplyResources(Me.mapbdn2, "mapbdn2")
        Me.mapbdn2.Maximum = 13
        Me.mapbdn2.Minimum = 5
        Me.mapbdn2.Name = "mapbdn2"
        Me.mapbdn2.Step = 1
        Me.mapbdn2.Value = 5
        '
        'qMaxDay7
        '
        resources.ApplyResources(Me.qMaxDay7, "qMaxDay7")
        Me.qMaxDay7.Name = "qMaxDay7"
        Me.qMaxDay7.UseVisualStyleBackColor = True
        '
        'mapbdn3
        '
        resources.ApplyResources(Me.mapbdn3, "mapbdn3")
        Me.mapbdn3.Maximum = 17
        Me.mapbdn3.Minimum = 10
        Me.mapbdn3.Name = "mapbdn3"
        Me.mapbdn3.Step = 1
        Me.mapbdn3.Value = 10
        '
        'qMaxDay6
        '
        resources.ApplyResources(Me.qMaxDay6, "qMaxDay6")
        Me.qMaxDay6.Name = "qMaxDay6"
        Me.qMaxDay6.UseVisualStyleBackColor = True
        '
        'qMovAvgUp0
        '
        resources.ApplyResources(Me.qMovAvgUp0, "qMovAvgUp0")
        Me.qMovAvgUp0.Name = "qMovAvgUp0"
        Me.qMovAvgUp0.UseVisualStyleBackColor = True
        '
        'qInDay08
        '
        resources.ApplyResources(Me.qInDay08, "qInDay08")
        Me.qInDay08.Checked = True
        Me.qInDay08.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay08.Name = "qInDay08"
        Me.qInDay08.UseVisualStyleBackColor = True
        '
        'bindaypb
        '
        resources.ApplyResources(Me.bindaypb, "bindaypb")
        Me.bindaypb.MarqueeAnimationSpeed = 11
        Me.bindaypb.Maximum = 11
        Me.bindaypb.Name = "bindaypb"
        Me.bindaypb.Step = 1
        '
        'qInDay07
        '
        resources.ApplyResources(Me.qInDay07, "qInDay07")
        Me.qInDay07.Checked = True
        Me.qInDay07.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay07.Name = "qInDay07"
        Me.qInDay07.UseVisualStyleBackColor = True
        '
        'mapbup3
        '
        resources.ApplyResources(Me.mapbup3, "mapbup3")
        Me.mapbup3.Maximum = 4
        Me.mapbup3.Name = "mapbup3"
        Me.mapbup3.Step = 1
        '
        'qInDay06
        '
        resources.ApplyResources(Me.qInDay06, "qInDay06")
        Me.qInDay06.Checked = True
        Me.qInDay06.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay06.Name = "qInDay06"
        Me.qInDay06.UseVisualStyleBackColor = True
        '
        'mapbup2
        '
        resources.ApplyResources(Me.mapbup2, "mapbup2")
        Me.mapbup2.Maximum = 4
        Me.mapbup2.Name = "mapbup2"
        Me.mapbup2.Step = 1
        Me.mapbup2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'qInDay05
        '
        resources.ApplyResources(Me.qInDay05, "qInDay05")
        Me.qInDay05.Checked = True
        Me.qInDay05.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay05.Name = "qInDay05"
        Me.qInDay05.UseVisualStyleBackColor = True
        '
        'mapbup1
        '
        resources.ApplyResources(Me.mapbup1, "mapbup1")
        Me.mapbup1.Maximum = 4
        Me.mapbup1.Name = "mapbup1"
        Me.mapbup1.Step = 1
        '
        'qInDay04
        '
        resources.ApplyResources(Me.qInDay04, "qInDay04")
        Me.qInDay04.Checked = True
        Me.qInDay04.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay04.Name = "qInDay04"
        Me.qInDay04.UseVisualStyleBackColor = True
        '
        'qInDay03
        '
        resources.ApplyResources(Me.qInDay03, "qInDay03")
        Me.qInDay03.Checked = True
        Me.qInDay03.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay03.Name = "qInDay03"
        Me.qInDay03.UseVisualStyleBackColor = True
        '
        'qSparkLine
        '
        resources.ApplyResources(Me.qSparkLine, "qSparkLine")
        Me.qSparkLine.Name = "qSparkLine"
        Me.qSparkLine.UseVisualStyleBackColor = True
        '
        'qCreateSignals
        '
        resources.ApplyResources(Me.qCreateSignals, "qCreateSignals")
        Me.qCreateSignals.Name = "qCreateSignals"
        Me.qCreateSignals.UseVisualStyleBackColor = True
        '
        'qCreateKeys
        '
        resources.ApplyResources(Me.qCreateKeys, "qCreateKeys")
        Me.qCreateKeys.Checked = True
        Me.qCreateKeys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qCreateKeys.Name = "qCreateKeys"
        Me.qCreateKeys.UseVisualStyleBackColor = True
        '
        'qUseCurrentData
        '
        resources.ApplyResources(Me.qUseCurrentData, "qUseCurrentData")
        Me.qUseCurrentData.Name = "qUseCurrentData"
        Me.qUseCurrentData.UseVisualStyleBackColor = True
        '
        'qInDay02
        '
        resources.ApplyResources(Me.qInDay02, "qInDay02")
        Me.qInDay02.Checked = True
        Me.qInDay02.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay02.Name = "qInDay02"
        Me.qInDay02.UseVisualStyleBackColor = True
        '
        'qInDay01
        '
        resources.ApplyResources(Me.qInDay01, "qInDay01")
        Me.qInDay01.Checked = True
        Me.qInDay01.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay01.Name = "qInDay01"
        Me.qInDay01.UseVisualStyleBackColor = True
        '
        'qInDay00
        '
        resources.ApplyResources(Me.qInDay00, "qInDay00")
        Me.qInDay00.Checked = True
        Me.qInDay00.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qInDay00.Name = "qInDay00"
        Me.qInDay00.UseVisualStyleBackColor = True
        '
        'qtoThisDay
        '
        resources.ApplyResources(Me.qtoThisDay, "qtoThisDay")
        Me.qtoThisDay.Checked = True
        Me.qtoThisDay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qtoThisDay.Name = "qtoThisDay"
        Me.qtoThisDay.UseVisualStyleBackColor = True
        '
        'qMaxDay5
        '
        resources.ApplyResources(Me.qMaxDay5, "qMaxDay5")
        Me.qMaxDay5.Name = "qMaxDay5"
        Me.qMaxDay5.UseVisualStyleBackColor = True
        '
        'SaveAllSignals
        '
        resources.ApplyResources(Me.SaveAllSignals, "SaveAllSignals")
        Me.SaveAllSignals.Name = "SaveAllSignals"
        Me.SaveAllSignals.UseVisualStyleBackColor = True
        '
        'qEveryDay
        '
        resources.ApplyResources(Me.qEveryDay, "qEveryDay")
        Me.qEveryDay.Name = "qEveryDay"
        Me.qEveryDay.UseVisualStyleBackColor = True
        '
        'qMaxDay4
        '
        resources.ApplyResources(Me.qMaxDay4, "qMaxDay4")
        Me.qMaxDay4.Name = "qMaxDay4"
        Me.qMaxDay4.UseVisualStyleBackColor = True
        '
        'qMaxDay3
        '
        resources.ApplyResources(Me.qMaxDay3, "qMaxDay3")
        Me.qMaxDay3.Name = "qMaxDay3"
        Me.qMaxDay3.UseVisualStyleBackColor = True
        '
        'qMaxDay2
        '
        resources.ApplyResources(Me.qMaxDay2, "qMaxDay2")
        Me.qMaxDay2.Name = "qMaxDay2"
        Me.qMaxDay2.UseVisualStyleBackColor = True
        '
        'qMaxDay1
        '
        resources.ApplyResources(Me.qMaxDay1, "qMaxDay1")
        Me.qMaxDay1.Name = "qMaxDay1"
        Me.qMaxDay1.UseVisualStyleBackColor = True
        '
        'qMaxDay0
        '
        resources.ApplyResources(Me.qMaxDay0, "qMaxDay0")
        Me.qMaxDay0.Checked = True
        Me.qMaxDay0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qMaxDay0.Name = "qMaxDay0"
        Me.qMaxDay0.UseVisualStyleBackColor = True
        '
        'qNFrid
        '
        resources.ApplyResources(Me.qNFrid, "qNFrid")
        Me.qNFrid.Name = "qNFrid"
        Me.qNFrid.UseVisualStyleBackColor = True
        '
        'qFrid
        '
        resources.ApplyResources(Me.qFrid, "qFrid")
        Me.qFrid.Name = "qFrid"
        Me.qFrid.ThreeState = True
        Me.qFrid.UseVisualStyleBackColor = True
        '
        'qThurs
        '
        resources.ApplyResources(Me.qThurs, "qThurs")
        Me.qThurs.Name = "qThurs"
        Me.qThurs.ThreeState = True
        Me.qThurs.UseVisualStyleBackColor = True
        '
        'qNThurs
        '
        resources.ApplyResources(Me.qNThurs, "qNThurs")
        Me.qNThurs.Name = "qNThurs"
        Me.qNThurs.UseVisualStyleBackColor = True
        '
        'qNWens
        '
        resources.ApplyResources(Me.qNWens, "qNWens")
        Me.qNWens.Name = "qNWens"
        Me.qNWens.UseVisualStyleBackColor = True
        '
        'qMon
        '
        resources.ApplyResources(Me.qMon, "qMon")
        Me.qMon.Name = "qMon"
        Me.qMon.ThreeState = True
        Me.qMon.UseVisualStyleBackColor = True
        '
        'qNMon
        '
        resources.ApplyResources(Me.qNMon, "qNMon")
        Me.qNMon.Name = "qNMon"
        Me.qNMon.UseVisualStyleBackColor = True
        '
        'qTues
        '
        resources.ApplyResources(Me.qTues, "qTues")
        Me.qTues.Name = "qTues"
        Me.qTues.ThreeState = True
        Me.qTues.UseVisualStyleBackColor = True
        '
        'qNTues
        '
        resources.ApplyResources(Me.qNTues, "qNTues")
        Me.qNTues.Name = "qNTues"
        Me.qNTues.UseVisualStyleBackColor = True
        '
        'qWens
        '
        resources.ApplyResources(Me.qWens, "qWens")
        Me.qWens.Name = "qWens"
        Me.qWens.ThreeState = True
        Me.qWens.UseVisualStyleBackColor = True
        '
        'qCalcCov
        '
        resources.ApplyResources(Me.qCalcCov, "qCalcCov")
        Me.qCalcCov.Name = "qCalcCov"
        Me.qCalcCov.UseVisualStyleBackColor = True
        '
        'qCalcSparklines
        '
        resources.ApplyResources(Me.qCalcSparklines, "qCalcSparklines")
        Me.qCalcSparklines.Name = "qCalcSparklines"
        Me.qCalcSparklines.UseVisualStyleBackColor = True
        '
        'signalsGrid
        '
        resources.ApplyResources(Me.signalsGrid, "signalsGrid")
        Me.signalsGrid.Name = "signalsGrid"
        Me.signalsGrid.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.qAdjustForAfterMidNight)
        Me.TabPage1.Controls.Add(Me.SymbolGridViewCurrent)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'qAdjustForAfterMidNight
        '
        resources.ApplyResources(Me.qAdjustForAfterMidNight, "qAdjustForAfterMidNight")
        Me.qAdjustForAfterMidNight.Checked = True
        Me.qAdjustForAfterMidNight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qAdjustForAfterMidNight.Name = "qAdjustForAfterMidNight"
        Me.qAdjustForAfterMidNight.UseVisualStyleBackColor = True
        '
        'SymbolGridViewCurrent
        '
        Me.SymbolGridViewCurrent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.SymbolGridViewCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SymbolGridViewCurrent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.thisDate1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.firstDt, Me.lastDt, Me.fd, Me.Updated})
        resources.ApplyResources(Me.SymbolGridViewCurrent, "SymbolGridViewCurrent")
        Me.SymbolGridViewCurrent.MultiSelect = False
        Me.SymbolGridViewCurrent.Name = "SymbolGridViewCurrent"
        Me.SymbolGridViewCurrent.RowTemplate.Height = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DividerWidth = 4
        Me.DataGridViewTextBoxColumn1.FillWeight = 111.0!
        Me.DataGridViewTextBoxColumn1.Frozen = True
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 9
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'thisDate1
        '
        resources.ApplyResources(Me.thisDate1, "thisDate1")
        Me.thisDate1.MaxInputLength = 11
        Me.thisDate1.Name = "thisDate1"
        '
        'DataGridViewTextBoxColumn2
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 25
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        resources.ApplyResources(Me.DataGridViewCheckBoxColumn1, "DataGridViewCheckBoxColumn1")
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3")
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        resources.ApplyResources(Me.DataGridViewTextBoxColumn4, "DataGridViewTextBoxColumn4")
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        resources.ApplyResources(Me.DataGridViewTextBoxColumn5, "DataGridViewTextBoxColumn5")
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        resources.ApplyResources(Me.DataGridViewTextBoxColumn6, "DataGridViewTextBoxColumn6")
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 9
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        resources.ApplyResources(Me.DataGridViewTextBoxColumn7, "DataGridViewTextBoxColumn7")
        Me.DataGridViewTextBoxColumn7.MaxInputLength = 9
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.DataGridViewTextBoxColumn8, "DataGridViewTextBoxColumn8")
        Me.DataGridViewTextBoxColumn8.MaxInputLength = 9
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'firstDt
        '
        resources.ApplyResources(Me.firstDt, "firstDt")
        Me.firstDt.MaxInputLength = 11
        Me.firstDt.Name = "firstDt"
        '
        'lastDt
        '
        resources.ApplyResources(Me.lastDt, "lastDt")
        Me.lastDt.MaxInputLength = 144
        Me.lastDt.Name = "lastDt"
        '
        'fd
        '
        resources.ApplyResources(Me.fd, "fd")
        Me.fd.MaxInputLength = 11
        Me.fd.Name = "fd"
        '
        'Updated
        '
        resources.ApplyResources(Me.Updated, "Updated")
        Me.Updated.MaxInputLength = 11
        Me.Updated.Name = "Updated"
        '
        'QFE_Securities
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "QFE_Securities"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.NumberofDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_Securities.ResumeLayout(False)
        Me.Securities.ResumeLayout(False)
        Me.SymbolParams_.ResumeLayout(False)
        Me.SymbolParams_.PerformLayout()
        CType(Me.SymbolGridViewBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParamFiles_.ResumeLayout(False)
        Me.ParamFiles_.PerformLayout()
        Me.Current.ResumeLayout(False)
        Me.Current.PerformLayout()
        Me.selectSecurities.ResumeLayout(False)
        Me.selectSecurities.PerformLayout()
        CType(Me.DGSignalsByEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Parameters.ResumeLayout(False)
        Me.Parameters.PerformLayout()
        CType(Me.adjQThreshHold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QThreshhold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.SymbolGridViewCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TAB_Securities As TabControl
    Friend WithEvents Securities As TabPage
    Friend WithEvents SymbolParams_ As TabPage
    Friend WithEvents SecuritiesList As CheckedListBox
    '    Friend WithEvents SymbolsTableAdapter As QFE_SignalsDataSet1TableAdapters.SymbolsTableAdapter
    Friend WithEvents SymbolGridViewBase As DataGridView
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents dbTrades As RichTextBox
    Friend WithEvents dbSignals As RichTextBox
    Friend WithEvents dbSymbols As RichTextBox
    Friend WithEvents Result As Button
    Friend WithEvents BaseDataFiles As RichTextBox
    Friend WithEvents ParamFiles_ As TabPage
    Friend WithEvents txtSymbol As RichTextBox
    Friend WithEvents totIterations As TextBox
    Friend WithEvents txtItersPerSecond As TextBox
    Friend WithEvents totSeconds As TextBox
    Friend WithEvents qEveryDay As CheckBox
    Friend WithEvents DataFiles As TextBox
    Friend WithEvents NoSecs As TextBox
    Friend WithEvents SecNo_ As TextBox
    Friend WithEvents ThisDate As DateTimePicker
    Friend WithEvents ReloadBaseData As Button
    Friend WithEvents qtoThisDay As CheckBox
    Friend WithEvents qCalcSparklines As CheckBox
    Friend WithEvents qCalcCov As CheckBox
    Friend WithEvents LinkLabelData As LinkLabel
    Friend WithEvents Current As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CurrentDataFiles As RichTextBox
    Friend WithEvents ReloadCurrentData As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Execute_Base As Button
    Friend WithEvents Execute_Current As Button
    Friend WithEvents SaveAllSignals As CheckBox
    Friend WithEvents saveOnlyBaseKeys As CheckBox
    Friend WithEvents qCreateKeys As CheckBox
    Friend WithEvents qSparkLine As CheckBox
    Friend WithEvents qCreateSignals As CheckBox
    Friend WithEvents qUseCurrentData As CheckBox
    Friend WithEvents LastDayDate As TextBox
    Friend WithEvents LastDayNo As TextBox
    Friend WithEvents FirstDayDate As TextBox
    Friend WithEvents FirstDayNo As TextBox
    Friend WithEvents StartDayDate As TextBox
    Friend WithEvents StartDayNo As TextBox
    Friend WithEvents SecNo As DataGridViewTextBoxColumn
    Friend WithEvents Symbol As DataGridViewTextBoxColumn
    Friend WithEvents Checked As DataGridViewCheckBoxColumn
    Friend WithEvents Recs As DataGridViewTextBoxColumn
    Friend WithEvents startDt As DataGridViewTextBoxColumn
    Friend WithEvents endDt As DataGridViewTextBoxColumn
    Friend WithEvents dUp As DataGridViewTextBoxColumn
    Friend WithEvents DDn As DataGridViewTextBoxColumn
    Friend WithEvents LastDOW As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents mapbup3 As ProgressBar
    Friend WithEvents mapbup2 As ProgressBar
    Friend WithEvents mapbup1 As ProgressBar
    Friend WithEvents bindaypb As ProgressBar
    Friend WithEvents selectSecurities As TabPage
    Friend WithEvents SecuritiesListBox As CheckedListBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ThisDayNo As TextBox
    Friend WithEvents ThisDayDate As TextBox
    Friend WithEvents EndDayNo As TextBox
    Friend WithEvents EndDayDate As TextBox
    Friend WithEvents symbolTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents thisDayDOW As TextBox
    Friend WithEvents mapbdn1 As ProgressBar
    Friend WithEvents mapbdn2 As ProgressBar
    Friend WithEvents mapbdn3 As ProgressBar
    Friend WithEvents thisClose As CheckBox
    Friend WithEvents nOp0nCl As TextBox
    Friend WithEvents nextClose As CheckBox
    Friend WithEvents nextOpen As CheckBox
    Friend WithEvents Cl0nOp As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CoSecuritiesListBox As CheckedListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CoSymbolTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents coStartDayNo As TextBox
    Friend WithEvents coStartDayDate As TextBox
    Friend WithEvents coThisDayNo As TextBox
    Friend WithEvents coLastDayNo As TextBox
    Friend WithEvents coFirstDayNo As TextBox
    Friend WithEvents coEndDayNo As TextBox
    Friend WithEvents coLastDayDate As TextBox
    Friend WithEvents coThisDayDate As TextBox
    Friend WithEvents coFirstDayDate As TextBox
    Friend WithEvents coEndDayDate As TextBox
    Friend WithEvents CoThisDayDOW As TextBox
    Friend WithEvents Average As TextBox
    Friend WithEvents NumberofDays As NumericUpDown
    Friend WithEvents Symbol1 As RichTextBox
    Friend WithEvents Qavg As TextBox
    Friend WithEvents Records As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DGSignalsByEntry As DataGridView
    Friend WithEvents qshowByEntryData As CheckBox
    Friend WithEvents Symb As DataGridViewTextBoxColumn
    Friend WithEvents DOW As DataGridViewTextBoxColumn
    Friend WithEvents movAvg As DataGridViewTextBoxColumn
    Friend WithEvents ZScrMode As DataGridViewTextBoxColumn
    Friend WithEvents bInDay As DataGridViewTextBoxColumn
    Friend WithEvents Entry As DataGridViewTextBoxColumn
    Friend WithEvents maxDH As DataGridViewTextBoxColumn
    Friend WithEvents sExit As DataGridViewTextBoxColumn
    Friend WithEvents iters As DataGridViewTextBoxColumn
    Friend WithEvents totIters As DataGridViewTextBoxColumn
    Friend WithEvents Q As DataGridViewTextBoxColumn
    Friend WithEvents totQ As DataGridViewTextBoxColumn
    Friend WithEvents avgQ As DataGridViewTextBoxColumn
    Friend WithEvents Parameters As TabPage
    Friend WithEvents qInDay10 As CheckBox
    Friend WithEvents qInDay09 As CheckBox
    Friend WithEvents qMovAvgDn0 As CheckBox
    Friend WithEvents qMaxDay10 As CheckBox
    Friend WithEvents qMaxDay9 As CheckBox
    Friend WithEvents qMaxDay8 As CheckBox
    Friend WithEvents qMaxDay7 As CheckBox
    Friend WithEvents qMaxDay6 As CheckBox
    Friend WithEvents qMovAvgUp0 As CheckBox
    Friend WithEvents qInDay08 As CheckBox
    Friend WithEvents qInDay07 As CheckBox
    Friend WithEvents qInDay06 As CheckBox
    Friend WithEvents qInDay05 As CheckBox
    Friend WithEvents qInDay04 As CheckBox
    Friend WithEvents qInDay03 As CheckBox
    Friend WithEvents qInDay02 As CheckBox
    Friend WithEvents qInDay01 As CheckBox
    Friend WithEvents qInDay00 As CheckBox
    Friend WithEvents qMaxDay5 As CheckBox
    Friend WithEvents qMaxDay4 As CheckBox
    Friend WithEvents qMaxDay3 As CheckBox
    Friend WithEvents qMaxDay2 As CheckBox
    Friend WithEvents qMaxDay1 As CheckBox
    Friend WithEvents qMaxDay0 As CheckBox
    Friend WithEvents qNFrid As CheckBox
    Friend WithEvents qFrid As CheckBox
    Friend WithEvents qThurs As CheckBox
    Friend WithEvents qNThurs As CheckBox
    Friend WithEvents qNWens As CheckBox
    Friend WithEvents qMon As CheckBox
    Friend WithEvents qNMon As CheckBox
    Friend WithEvents qTues As CheckBox
    Friend WithEvents qNTues As CheckBox
    Friend WithEvents qWens As CheckBox
    Friend WithEvents qZBase As CheckBox
    Friend WithEvents qZPP As CheckBox
    Friend WithEvents qZP_ As CheckBox
    Friend WithEvents qZNN As CheckBox
    Friend WithEvents qZN_ As CheckBox
    Friend WithEvents qShowDG As CheckBox
    Friend WithEvents qZOffSet1 As CheckBox
    Friend WithEvents qZOffSet5 As CheckBox
    Friend WithEvents qZOffSet4 As CheckBox
    Friend WithEvents qZOffSet3 As CheckBox
    Friend WithEvents qZOffSet2 As CheckBox
    Friend WithEvents qZOffSet0 As CheckBox
    Friend WithEvents signalsGrid As TabPage
    Friend WithEvents nOp0nnOp As TextBox
    Friend WithEvents nOp0nnCl As TextBox
    Friend WithEvents nCl0nnCl As TextBox
    Friend WithEvents nCl0nnOp As TextBox
    Friend WithEvents Cl0nCl As TextBox
    Friend WithEvents Cl0nnCl As TextBox
    Friend WithEvents Cl0nnOp As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SymbolGridViewCurrent As DataGridView
    Friend WithEvents ZScrRank5 As CheckBox
    Friend WithEvents ZScrRank4 As CheckBox
    Friend WithEvents ZScrRank3 As CheckBox
    Friend WithEvents ZScrRank2 As CheckBox
    Friend WithEvents ZScrRank1 As CheckBox
    Friend WithEvents ZScrRank0 As CheckBox
    Friend WithEvents adjDate As DateTimePicker
    Friend WithEvents ReadFiles As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents thisDate1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents firstDt As DataGridViewTextBoxColumn
    Friend WithEvents lastDt As DataGridViewTextBoxColumn
    Friend WithEvents fd As DataGridViewTextBoxColumn
    Friend WithEvents Updated As DataGridViewTextBoxColumn
    Friend WithEvents qAdjustForAfterMidNight As CheckBox
    Friend WithEvents ZScrRank8 As CheckBox
    Friend WithEvents ZScrRank7 As CheckBox
    Friend WithEvents ZScrRank6 As CheckBox
    Friend WithEvents Set_All As Button
    Friend WithEvents ZScrRank9 As CheckBox
    Friend WithEvents Model09 As CheckBox
    Friend WithEvents Model08 As CheckBox
    Friend WithEvents Model07 As CheckBox
    Friend WithEvents Model06 As CheckBox
    Friend WithEvents Model05 As CheckBox
    Friend WithEvents Model04 As CheckBox
    Friend WithEvents Model03 As CheckBox
    Friend WithEvents Model02 As CheckBox
    Friend WithEvents Model01 As CheckBox
    Friend WithEvents Model00 As CheckBox
    Friend WithEvents QThreshhold As NumericUpDown
    Friend WithEvents errorCnt As TextBox
    Friend WithEvents adjQThreshHold As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents MApbUp4 As ProgressBar
    Friend WithEvents sTargetProfit50 As CheckBox
    Friend WithEvents sTargetProfit40 As CheckBox
    Friend WithEvents sTargetProfit30 As CheckBox
    Friend WithEvents sTargetProfit20 As CheckBox
    Friend WithEvents sTargetProfit10 As CheckBox
    Friend WithEvents sTargetProfit00 As CheckBox
    Friend WithEvents Written As TextBox
End Class
