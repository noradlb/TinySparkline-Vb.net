Imports System.Drawing
Imports System.Windows.Forms
Imports System.Threading.Tasks
Imports System.ComponentModel

Public Class MainForm

    ' ===== Variables =====
    Private currentDevices As Integer = 8
    Private newToday As Integer = 2
    Private isRunning As Boolean = True
    Private isPaused As Boolean = False
    Private rnd As New Random()

    ' ===== Constructor =====
    Public Sub New()
        InitializeComponent()
        LoadInitialData()
    End Sub

    ' ===== Load Initial Data =====
    Private Sub LoadInitialData()
        For i As Integer = 0 To 20
            Dim baseValue As Integer = 5 + rnd.Next(0, 10)
            sparklineConnected.AddValue(baseValue)
            sparklineNew.AddValue(Math.Max(0, baseValue - 5))
        Next

        sparklineConnected.AddValue(currentDevices)
        sparklineNew.AddValue(newToday)

        UpdateLabels()
    End Sub

    ' ===== Update UI =====
    Private Sub UpdateLabels()
        lblConnected.Text = sparklineConnected.CurrentValue.ToString()
        lblNew.Text = sparklineNew.CurrentValue.ToString()

        Dim change As Integer = sparklineConnected.Change
        Dim changeText As String
        Dim changeIcon As String

        If change > 0 Then
            changeText = $"+{change}"
            changeIcon = "📈"
            lblChange.ForeColor = Color.FromArgb(0, 180, 0)
        ElseIf change < 0 Then
            changeText = $"{change}"
            changeIcon = "📉"
            lblChange.ForeColor = Color.FromArgb(200, 50, 0)
        Else
            changeText = "0"
            changeIcon = "➖"
            lblChange.ForeColor = Color.FromArgb(100, 100, 100)
        End If

        lblChange.Text = $"{changeIcon} Change: {changeText}"

        Me.Text = $"📊 Device Monitor - {sparklineConnected.CurrentValue} Devices | Change: {sparklineConnected.Change:+0;-#;0}"
    End Sub

    ' ===== Button Handlers =====
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        currentDevices += 1
        newToday += 1

        sparklineConnected.AddValue(currentDevices)
        sparklineNew.AddValue(newToday)

        UpdateLabels()
        lblStatus.Text = $"✅ Added device - Total: {currentDevices}"
        lblStatus.ForeColor = Color.FromArgb(0, 180, 0)
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If currentDevices > 0 Then
            currentDevices -= 1
            If newToday > 0 Then newToday -= 1

            sparklineConnected.AddValue(currentDevices)
            sparklineNew.AddValue(newToday)

            UpdateLabels()
            lblStatus.Text = $"❌ Removed device - Total: {currentDevices}"
            lblStatus.ForeColor = Color.FromArgb(200, 50, 0)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        currentDevices = 8
        newToday = 2

        sparklineConnected.Clear()
        sparklineNew.Clear()

        For i As Integer = 0 To 20
            Dim baseValue As Integer = 5 + rnd.Next(0, 10)
            sparklineConnected.AddValue(baseValue)
            sparklineNew.AddValue(Math.Max(0, baseValue - 5))
        Next

        sparklineConnected.AddValue(currentDevices)
        sparklineNew.AddValue(newToday)

        UpdateLabels()
        lblStatus.Text = "🔄 Data reset"
        lblStatus.ForeColor = Color.FromArgb(100, 100, 100)
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        isPaused = Not isPaused
        If isPaused Then
            btnPause.Text = "▶️ Resume"
            btnPause.BackColor = Color.FromArgb(0, 180, 0)
            lblStatus.Text = "⏸️ Paused"
            lblStatus.ForeColor = Color.FromArgb(255, 180, 0)
        Else
            btnPause.Text = "⏸️ Pause"
            btnPause.BackColor = Color.FromArgb(255, 180, 0)
            lblStatus.Text = "🟢 Running..."
            lblStatus.ForeColor = Color.FromArgb(150, 150, 150)
        End If
    End Sub

    ' ===== Auto Update with Async/Await =====
    Private Async Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Await StartAutoUpdate()
    End Sub

    Private Async Function StartAutoUpdate() As Task
        While isRunning
            If Not isPaused Then
                ' Simulate random change
                Dim change As Integer = rnd.Next(-3, 4)
                currentDevices = Math.Max(0, currentDevices + change)
                newToday = Math.Max(0, newToday + change)

                ' Update sparklines
                sparklineConnected.AddValue(currentDevices)
                sparklineNew.AddValue(newToday)

                ' Update UI safely
                If Me.InvokeRequired Then
                    Me.Invoke(New Action(AddressOf UpdateLabels))
                Else
                    UpdateLabels()
                End If

                ' Update status
                Dim statusText As String
                Dim statusColor As Color

                If change > 0 Then
                    statusText = $"📈 +{change} devices - Total: {currentDevices}"
                    statusColor = Color.FromArgb(0, 180, 0)
                ElseIf change < 0 Then
                    statusText = $"📉 {change} devices - Total: {currentDevices}"
                    statusColor = Color.FromArgb(200, 50, 0)
                Else
                    statusText = $"➖ No change - Total: {currentDevices}"
                    statusColor = Color.FromArgb(100, 100, 100)
                End If

                If Me.InvokeRequired Then
                    Me.Invoke(Sub()
                                  lblStatus.Text = statusText
                                  lblStatus.ForeColor = statusColor
                              End Sub)
                Else
                    lblStatus.Text = statusText
                    lblStatus.ForeColor = statusColor
                End If
            End If

            ' Wait 2-3 seconds (random for more natural feel)
            Await Task.Delay(rnd.Next(2000, 3500))
        End While
    End Function

    ' ===== Cleanup =====
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        isRunning = False
    End Sub

End Class