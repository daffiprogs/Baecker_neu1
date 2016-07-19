<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ArtikelAuswahl
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
        Me.Beschreibung = New System.Windows.Forms.TextBox()
        Me.LB_Kalorien = New System.Windows.Forms.TextBox()
        Me.Punkte = New System.Windows.Forms.TextBox()
        Me.Fett = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Gruppe = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LB_Artikel = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Beschreibung
        '
        Me.Beschreibung.Location = New System.Drawing.Point(133, 150)
        Me.Beschreibung.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Beschreibung.Multiline = True
        Me.Beschreibung.Name = "Beschreibung"
        Me.Beschreibung.Size = New System.Drawing.Size(180, 86)
        Me.Beschreibung.TabIndex = 3
        '
        'LB_Kalorien
        '
        Me.LB_Kalorien.Location = New System.Drawing.Point(100, 283)
        Me.LB_Kalorien.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LB_Kalorien.Name = "LB_Kalorien"
        Me.LB_Kalorien.Size = New System.Drawing.Size(180, 22)
        Me.LB_Kalorien.TabIndex = 4
        '
        'Punkte
        '
        Me.Punkte.Location = New System.Drawing.Point(336, 324)
        Me.Punkte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Punkte.Name = "Punkte"
        Me.Punkte.Size = New System.Drawing.Size(180, 22)
        Me.Punkte.TabIndex = 6
        '
        'Fett
        '
        Me.Fett.Location = New System.Drawing.Point(100, 326)
        Me.Fett.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Fett.Name = "Fett"
        Me.Fett.Size = New System.Drawing.Size(180, 22)
        Me.Fett.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Kalorien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Fett"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Beschreibung"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Points"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Artikel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gruppe"
        '
        'Gruppe
        '
        Me.Gruppe.FormattingEnabled = True
        Me.Gruppe.ItemHeight = 16
        Me.Gruppe.Location = New System.Drawing.Point(133, 34)
        Me.Gruppe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Gruppe.Name = "Gruppe"
        Me.Gruppe.Size = New System.Drawing.Size(120, 36)
        Me.Gruppe.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 394)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Schließen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LB_Artikel
        '
        Me.LB_Artikel.FormattingEnabled = True
        Me.LB_Artikel.ItemHeight = 16
        Me.LB_Artikel.Location = New System.Drawing.Point(337, 80)
        Me.LB_Artikel.Margin = New System.Windows.Forms.Padding(4)
        Me.LB_Artikel.Name = "LB_Artikel"
        Me.LB_Artikel.Size = New System.Drawing.Size(159, 116)
        Me.LB_Artikel.TabIndex = 2
        '
        'Auswertung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 442)
        Me.Controls.Add(Me.LB_Artikel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Gruppe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB_Kalorien)
        Me.Controls.Add(Me.Punkte)
        Me.Controls.Add(Me.Fett)
        Me.Controls.Add(Me.Beschreibung)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Auswertung"
        Me.Text = "Auswertung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Beschreibung As TextBox
    Friend WithEvents LB_Kalorien As TextBox
    Friend WithEvents Punkte As TextBox
    Friend WithEvents Fett As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Gruppe As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LB_Artikel As ListBox

End Class
