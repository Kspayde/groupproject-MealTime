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
        Me.btnSettings2 = New System.Windows.Forms.Button()
        Me.btnWeight = New System.Windows.Forms.Button()
        Me.btnExercises = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSettings2
        '
        Me.btnSettings2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSettings2.AutoSize = True
        Me.btnSettings2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSettings2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnSettings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSettings2.Location = New System.Drawing.Point(46, 178)
        Me.btnSettings2.Name = "btnSettings2"
        Me.btnSettings2.Size = New System.Drawing.Size(107, 68)
        Me.btnSettings2.TabIndex = 9
        Me.btnSettings2.Text = "👤"
        Me.btnSettings2.UseVisualStyleBackColor = False
        '
        'btnWeight
        '
        Me.btnWeight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnWeight.AutoSize = True
        Me.btnWeight.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnWeight.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnWeight.Location = New System.Drawing.Point(195, 53)
        Me.btnWeight.Name = "btnWeight"
        Me.btnWeight.Size = New System.Drawing.Size(107, 68)
        Me.btnWeight.TabIndex = 10
        Me.btnWeight.Text = "📊"
        Me.btnWeight.UseVisualStyleBackColor = False
        '
        'btnExercises
        '
        Me.btnExercises.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExercises.AutoSize = True
        Me.btnExercises.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExercises.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExercises.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExercises.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExercises.Location = New System.Drawing.Point(348, 53)
        Me.btnExercises.Name = "btnExercises"
        Me.btnExercises.Size = New System.Drawing.Size(107, 68)
        Me.btnExercises.TabIndex = 11
        Me.btnExercises.Text = "🏃"
        Me.btnExercises.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(46, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 68)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "🍱"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnExercises)
        Me.GroupBox1.Controls.Add(Me.btnWeight)
        Me.GroupBox1.Controls.Add(Me.btnSettings2)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 326)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSettings2 As Button
    Friend WithEvents btnWeight As Button
    Friend WithEvents btnExercises As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
