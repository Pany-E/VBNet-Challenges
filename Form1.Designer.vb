<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnOutput = New System.Windows.Forms.Button()
        Me.btnOutputAll = New System.Windows.Forms.Button()
        Me.BtnAddAll = New System.Windows.Forms.Button()
        Me.BtnAverage = New System.Windows.Forms.Button()
        Me.BtnAddOver20 = New System.Windows.Forms.Button()
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnDoubleAndOutput = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnOutput
        '
        Me.BtnOutput.Location = New System.Drawing.Point(-4, 64)
        Me.BtnOutput.Name = "BtnOutput"
        Me.BtnOutput.Size = New System.Drawing.Size(151, 39)
        Me.BtnOutput.TabIndex = 0
        Me.BtnOutput.Text = "Exercise1"
        Me.BtnOutput.UseVisualStyleBackColor = True
        '
        'btnOutputAll
        '
        Me.btnOutputAll.Location = New System.Drawing.Point(-4, 127)
        Me.btnOutputAll.Name = "btnOutputAll"
        Me.btnOutputAll.Size = New System.Drawing.Size(151, 33)
        Me.btnOutputAll.TabIndex = 1
        Me.btnOutputAll.Text = "Exercise2"
        Me.btnOutputAll.UseVisualStyleBackColor = True
        '
        'BtnAddAll
        '
        Me.BtnAddAll.Location = New System.Drawing.Point(-4, 177)
        Me.BtnAddAll.Name = "BtnAddAll"
        Me.BtnAddAll.Size = New System.Drawing.Size(151, 24)
        Me.BtnAddAll.TabIndex = 2
        Me.BtnAddAll.Text = "Exercise3"
        Me.BtnAddAll.UseVisualStyleBackColor = True
        '
        'BtnAverage
        '
        Me.BtnAverage.Location = New System.Drawing.Point(-4, 221)
        Me.BtnAverage.Name = "BtnAverage"
        Me.BtnAverage.Size = New System.Drawing.Size(151, 27)
        Me.BtnAverage.TabIndex = 3
        Me.BtnAverage.Text = "Exercise4"
        Me.BtnAverage.UseVisualStyleBackColor = True
        '
        'BtnAddOver20
        '
        Me.BtnAddOver20.Location = New System.Drawing.Point(-4, 263)
        Me.BtnAddOver20.Name = "BtnAddOver20"
        Me.BtnAddOver20.Size = New System.Drawing.Size(151, 28)
        Me.BtnAddOver20.TabIndex = 4
        Me.BtnAddOver20.Text = "Exercise5"
        Me.BtnAddOver20.UseVisualStyleBackColor = True
        '
        'BtnMax
        '
        Me.BtnMax.Location = New System.Drawing.Point(-4, 309)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.Size = New System.Drawing.Size(151, 29)
        Me.BtnMax.TabIndex = 5
        Me.BtnMax.Text = "Exercise6"
        Me.BtnMax.UseVisualStyleBackColor = True
        '
        'BtnMin
        '
        Me.BtnMin.Location = New System.Drawing.Point(-4, 355)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(151, 33)
        Me.BtnMin.TabIndex = 6
        Me.BtnMin.Text = "Exercise7"
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnDoubleAndOutput
        '
        Me.BtnDoubleAndOutput.Location = New System.Drawing.Point(-4, 406)
        Me.BtnDoubleAndOutput.Name = "BtnDoubleAndOutput"
        Me.BtnDoubleAndOutput.Size = New System.Drawing.Size(151, 32)
        Me.BtnDoubleAndOutput.TabIndex = 7
        Me.BtnDoubleAndOutput.Text = "Exercise8"
        Me.BtnDoubleAndOutput.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDoubleAndOutput)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.BtnMax)
        Me.Controls.Add(Me.BtnAddOver20)
        Me.Controls.Add(Me.BtnAverage)
        Me.Controls.Add(Me.BtnAddAll)
        Me.Controls.Add(Me.btnOutputAll)
        Me.Controls.Add(Me.BtnOutput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnOutput As Button
    Friend WithEvents btnOutputAll As Button
    Friend WithEvents BtnAddAll As Button
    Friend WithEvents BtnAverage As Button
    Friend WithEvents BtnAddOver20 As Button
    Friend WithEvents BtnMax As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnDoubleAndOutput As Button
End Class
