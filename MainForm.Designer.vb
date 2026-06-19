<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.lblConnectedTitle = New System.Windows.Forms.Label()
        Me.lblNewTitle = New System.Windows.Forms.Label()
        Me.sparklineConnected = New TinySparkline()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.sparklineNew = New TinySparkline()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.PanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContainer.Controls.Add(Me.lblConnectedTitle)
        Me.PanelContainer.Controls.Add(Me.lblNewTitle)
        Me.PanelContainer.Controls.Add(Me.sparklineConnected)
        Me.PanelContainer.Controls.Add(Me.lblConnected)
        Me.PanelContainer.Controls.Add(Me.sparklineNew)
        Me.PanelContainer.Controls.Add(Me.lblNew)
        Me.PanelContainer.Controls.Add(Me.lblChange)
        Me.PanelContainer.Controls.Add(Me.lblStatus)
        Me.PanelContainer.Location = New System.Drawing.Point(10, 10)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelContainer.Size = New System.Drawing.Size(445, 145)
        Me.PanelContainer.TabIndex = 0
        '
        'lblConnectedTitle
        '
        Me.lblConnectedTitle.AutoSize = True
        Me.lblConnectedTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectedTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblConnectedTitle.Location = New System.Drawing.Point(125, 5)
        Me.lblConnectedTitle.Name = "lblConnectedTitle"
        Me.lblConnectedTitle.Size = New System.Drawing.Size(111, 13)
        Me.lblConnectedTitle.TabIndex = 0
        Me.lblConnectedTitle.Text = "Connected Devices"
        '
        'lblNewTitle
        '
        Me.lblNewTitle.AutoSize = True
        Me.lblNewTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblNewTitle.Location = New System.Drawing.Point(125, 45)
        Me.lblNewTitle.Name = "lblNewTitle"
        Me.lblNewTitle.Size = New System.Drawing.Size(56, 13)
        Me.lblNewTitle.TabIndex = 1
        Me.lblNewTitle.Text = "New Today"
        '
        'sparklineConnected
        '
        Me.sparklineConnected.AutoScale = True
        Me.sparklineConnected.BackColor = System.Drawing.Color.Transparent
        Me.sparklineConnected.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sparklineConnected.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sparklineConnected.LineColorDown = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sparklineConnected.LineThickness = 2.0!
        Me.sparklineConnected.Location = New System.Drawing.Point(15, 5)
        Me.sparklineConnected.MaxPoints = 25
        Me.sparklineConnected.MinimumSize = New System.Drawing.Size(40, 20)
        Me.sparklineConnected.Name = "sparklineConnected"
        Me.sparklineConnected.PointRadius = 3
        Me.sparklineConnected.ShowFill = True
        Me.sparklineConnected.ShowLastPoint = True
        Me.sparklineConnected.Size = New System.Drawing.Size(100, 30)
        Me.sparklineConnected.TabIndex = 2
        '
        'lblConnected
        '
        Me.lblConnected.AutoSize = True
        Me.lblConnected.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblConnected.Location = New System.Drawing.Point(125, 20)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(26, 32)
        Me.lblConnected.TabIndex = 3
        Me.lblConnected.Text = "8"
        '
        'sparklineNew
        '
        Me.sparklineNew.AutoScale = True
        Me.sparklineNew.BackColor = System.Drawing.Color.Transparent
        Me.sparklineNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sparklineNew.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sparklineNew.LineColorDown = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sparklineNew.LineThickness = 2.0!
        Me.sparklineNew.Location = New System.Drawing.Point(15, 45)
        Me.sparklineNew.MaxPoints = 25
        Me.sparklineNew.MinimumSize = New System.Drawing.Size(40, 20)
        Me.sparklineNew.Name = "sparklineNew"
        Me.sparklineNew.PointRadius = 3
        Me.sparklineNew.ShowFill = True
        Me.sparklineNew.ShowLastPoint = True
        Me.sparklineNew.Size = New System.Drawing.Size(100, 30)
        Me.sparklineNew.TabIndex = 4
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNew.Location = New System.Drawing.Point(125, 60)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(26, 32)
        Me.lblNew.TabIndex = 5
        Me.lblNew.Text = "2"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblChange.Location = New System.Drawing.Point(125, 90)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(99, 15)
        Me.lblChange.TabIndex = 6
        Me.lblChange.Text = "📈 Change: +0"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(125, 110)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(80, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "🟢 Running..."
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(10, 165)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "➕ Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(121, 165)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(105, 30)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "➖ Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(232, 165)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(105, 30)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "🔄 Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPause.FlatAppearance.BorderSize = 0
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.ForeColor = System.Drawing.Color.White
        Me.btnPause.Location = New System.Drawing.Point(343, 165)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(105, 30)
        Me.btnPause.TabIndex = 4
        Me.btnPause.Text = "⏸️ Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(465, 205)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.PanelContainer)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "📊 Device Monitor - MainForm"
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PanelContainer As System.Windows.Forms.Panel
    Private WithEvents lblConnectedTitle As System.Windows.Forms.Label
    Private WithEvents lblNewTitle As System.Windows.Forms.Label
    Private WithEvents sparklineConnected As TinySparkline
    Private WithEvents lblConnected As System.Windows.Forms.Label
    Private WithEvents sparklineNew As TinySparkline
    Private WithEvents lblNew As System.Windows.Forms.Label
    Private WithEvents lblChange As System.Windows.Forms.Label
    Private WithEvents lblStatus As System.Windows.Forms.Label
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents btnRemove As System.Windows.Forms.Button
    Private WithEvents btnReset As System.Windows.Forms.Button
    Private WithEvents btnPause As System.Windows.Forms.Button

End Class