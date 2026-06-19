Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.ComponentModel

<ToolboxItem(True)>
<ToolboxBitmap(GetType(Panel))>
Public Class TinySparkline
    Inherits Panel

    ' ===== Private Fields =====
    Private _values As New List(Of Integer)()
    Private _maxPoints As Integer = 20
    Private _currentValue As Integer = 0
    Private _lineColor As Color = Color.FromArgb(0, 180, 0)
    Private _lineColorDown As Color = Color.FromArgb(200, 50, 0)
    Private _fillColor As Color = Color.FromArgb(40, 0, 180, 0)
    Private _showFill As Boolean = True
    Private _showLastPoint As Boolean = True
    Private _lineThickness As Single = 1.5F
    Private _pointRadius As Integer = 2
    Private _autoScale As Boolean = True
    Private _minValue As Integer = 0
    Private _maxValue As Integer = 100

    ' ===== Constructor =====
    Public Sub New()
        Me.Size = New Size(100, 30)
        Me.BackColor = Color.Transparent
        Me.DoubleBuffered = True
        Me.ResizeRedraw = True
        Me.Padding = New Padding(2)
        Me.MinimumSize = New Size(40, 20)
    End Sub

    ' ===== Public Properties =====

    <Category("Appearance")>
    <Description("The color of the line when going up")>
    Public Property LineColor As Color
        Get
            Return _lineColor
        End Get
        Set(value As Color)
            _lineColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Description("The color of the line when going down")>
    Public Property LineColorDown As Color
        Get
            Return _lineColorDown
        End Get
        Set(value As Color)
            _lineColorDown = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Description("The fill color under the line")>
    Public Property FillColor As Color
        Get
            Return _fillColor
        End Get
        Set(value As Color)
            _fillColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Description("Show or hide the fill area under the line")>
    Public Property ShowFill As Boolean
        Get
            Return _showFill
        End Get
        Set(value As Boolean)
            _showFill = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Description("Show or hide the last point dot")>
    Public Property ShowLastPoint As Boolean
        Get
            Return _showLastPoint
        End Get
        Set(value As Boolean)
            _showLastPoint = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Description("Thickness of the line in pixels")>
    Public Property LineThickness As Single
        Get
            Return _lineThickness
        End Get
        Set(value As Single)
            _lineThickness = Math.Max(0.5F, value)
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Description("Radius of the last point dot")>
    Public Property PointRadius As Integer
        Get
            Return _pointRadius
        End Get
        Set(value As Integer)
            _pointRadius = Math.Max(1, value)
            Me.Invalidate()
        End Set
    End Property

    <Category("Behavior")>
    <Description("Maximum number of points to display")>
    Public Property MaxPoints As Integer
        Get
            Return _maxPoints
        End Get
        Set(value As Integer)
            _maxPoints = Math.Max(2, value)
            While _values.Count > _maxPoints
                _values.RemoveAt(0)
            End While
            Me.Invalidate()
        End Set
    End Property

    <Category("Behavior")>
    <Description("Automatically scale the chart to fit the data")>
    Public Property AutoScale As Boolean
        Get
            Return _autoScale
        End Get
        Set(value As Boolean)
            _autoScale = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Behavior")>
    <Description("Minimum value for the Y-axis (only used when AutoScale is False)")>
    Public Property MinValue As Integer
        Get
            Return _minValue
        End Get
        Set(value As Integer)
            _minValue = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Behavior")>
    <Description("Maximum value for the Y-axis (only used when AutoScale is False)")>
    Public Property MaxValue As Integer
        Get
            Return _maxValue
        End Get
        Set(value As Integer)
            _maxValue = value
            Me.Invalidate()
        End Set
    End Property

    ' ===== Read-only Properties =====

    <Browsable(False)>
    Public ReadOnly Property CurrentValue As Integer
        Get
            Return _currentValue
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property Change As Integer
        Get
            If _values.Count >= 2 Then
                Return _values.Last() - _values(_values.Count - 2)
            End If
            Return 0
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property ChangePercent As Double
        Get
            If _values.Count >= 2 Then
                Dim oldVal As Integer = _values(_values.Count - 2)
                If oldVal > 0 Then
                    Return ((_currentValue - oldVal) / oldVal) * 100
                End If
            End If
            Return 0
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property MinData As Integer
        Get
            If _values.Count > 0 Then
                Return _values.Min()
            End If
            Return 0
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property MaxData As Integer
        Get
            If _values.Count > 0 Then
                Return _values.Max()
            End If
            Return 0
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property DataCount As Integer
        Get
            Return _values.Count
        End Get
    End Property

    ' ===== Public Methods =====

    Public Sub AddValue(value As Integer)
        _values.Add(value)
        _currentValue = value

        While _values.Count > _maxPoints
            _values.RemoveAt(0)
        End While

        Me.Invalidate()
    End Sub

    Public Sub UpdateTrend(newValue As Integer)
        AddValue(newValue)
    End Sub

    Public Sub AddRange(values As IEnumerable(Of Integer))
        For Each val As Integer In values
            AddValue(val)
        Next
    End Sub

    Public Sub Clear()
        _values.Clear()
        _currentValue = 0
        Me.Invalidate()
    End Sub

    Public Function GetValues() As Integer()
        Return _values.ToArray()
    End Function

    Public Sub SetValues(values As Integer())
        Clear()
        For Each val As Integer In values
            _values.Add(val)
        Next
        If _values.Count > 0 Then
            _currentValue = _values.Last()
        End If
        Me.Invalidate()
    End Sub

    ' ===== Protected Methods =====

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)

        If _values.Count < 2 Then
            DrawEmptyState(g)
            Return
        End If

        Dim area As Rectangle = Me.ClientRectangle
        area.Inflate(-Me.Padding.Left, -Me.Padding.Top)
        area.Width -= Me.Padding.Right
        area.Height -= Me.Padding.Bottom

        If area.Width < 5 OrElse area.Height < 5 Then Return

        Dim minVal As Integer
        Dim maxVal As Integer

        If _autoScale Then
            minVal = _values.Min()
            maxVal = _values.Max()

            If maxVal = minVal Then
                maxVal = minVal + 1
            End If

            ' Add 10% margin
            Dim range As Integer = maxVal - minVal
            Dim margin As Integer = Math.Max(1, CInt(range * 0.1))
            minVal = Math.Max(0, minVal - margin)
            maxVal = maxVal + margin
        Else
            minVal = _minValue
            maxVal = _maxValue
            If maxVal <= minVal Then
                maxVal = minVal + 1
            End If
        End If

        If _showFill Then
            DrawFillArea(g, area, minVal, maxVal)
        End If

        DrawTrendLine(g, area, minVal, maxVal)

        If _showLastPoint Then
            DrawLastPoint(g, area, minVal, maxVal)
        End If
    End Sub

    ' ===== Private Drawing Methods =====

    Private Sub DrawEmptyState(g As Graphics)
        Using pen As New Pen(Color.FromArgb(150, 200, 200, 200), 1)
            pen.DashStyle = DashStyle.Dash
            Dim area As Rectangle = Me.ClientRectangle
            area.Inflate(-2, -2)
            If area.Width > 0 AndAlso area.Height > 0 Then
                Dim midY As Single = CSng(area.Top + area.Height / 2)
                g.DrawLine(pen, CSng(area.Left), midY, CSng(area.Right), midY)
            End If
        End Using
    End Sub

    Private Sub DrawFillArea(g As Graphics, area As Rectangle, minVal As Integer, maxVal As Integer)
        Dim points As New List(Of PointF)()

        For i As Integer = 0 To _values.Count - 1
            Dim x As Single = CSng(area.Left + (i * area.Width / (_values.Count - 1)))
            Dim y As Single = CSng(area.Bottom - ((_values(i) - minVal) * area.Height / (maxVal - minVal)))
            points.Add(New PointF(x, y))
        Next

        points.Add(New PointF(CSng(area.Right), CSng(area.Bottom)))
        points.Add(New PointF(CSng(area.Left), CSng(area.Bottom)))

        Using brush As New SolidBrush(_fillColor)
            g.FillPolygon(brush, points.ToArray())
        End Using
    End Sub

    Private Sub DrawTrendLine(g As Graphics, area As Rectangle, minVal As Integer, maxVal As Integer)
        Dim color As Color = GetLineColor()

        Using pen As New Pen(color, _lineThickness)
            pen.LineJoin = LineJoin.Round
            pen.StartCap = LineCap.Round
            pen.EndCap = LineCap.Round

            For i As Integer = 0 To _values.Count - 2
                Dim x1 As Single = CSng(area.Left + (i * area.Width / (_values.Count - 1)))
                Dim y1 As Single = CSng(area.Bottom - ((_values(i) - minVal) * area.Height / (maxVal - minVal)))

                Dim x2 As Single = CSng(area.Left + ((i + 1) * area.Width / (_values.Count - 1)))
                Dim y2 As Single = CSng(area.Bottom - ((_values(i + 1) - minVal) * area.Height / (maxVal - minVal)))

                g.DrawLine(pen, x1, y1, x2, y2)
            Next
        End Using
    End Sub

    Private Sub DrawLastPoint(g As Graphics, area As Rectangle, minVal As Integer, maxVal As Integer)
        If _values.Count = 0 Then Return

        Dim lastIdx As Integer = _values.Count - 1
        Dim x As Single = CSng(area.Left + (lastIdx * area.Width / (_values.Count - 1)))
        Dim y As Single = CSng(area.Bottom - ((_values(lastIdx) - minVal) * area.Height / (maxVal - minVal)))

        Dim color As Color = GetLineColor()
        Dim radius As Integer = _pointRadius

        Using brush As New SolidBrush(color)
            g.FillEllipse(brush, x - radius, y - radius, radius * 2, radius * 2)
        End Using
    End Sub

    Private Function GetLineColor() As Color
        If _values.Count >= 2 Then
            If _values.Last() < _values(_values.Count - 2) Then
                Return _lineColorDown
            End If
        End If
        Return _lineColor
    End Function

    ' ===== Performance Optimization =====
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        ' Skip background painting for better performance
        ' Only clear if backcolor is not transparent
        If Me.BackColor <> Color.Transparent Then
            Using brush As New SolidBrush(Me.BackColor)
                e.Graphics.FillRectangle(brush, Me.ClientRectangle)
            End Using
        End If
    End Sub
End Class