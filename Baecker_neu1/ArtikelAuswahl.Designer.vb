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
        Me.LB_Gewicht = New System.Windows.Forms.TextBox()
        Me.LB_Preis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Gruppe = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LB_Artikel = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Beschreibung
        '
        Me.Beschreibung.Location = New System.Drawing.Point(100, 122)
        Me.Beschreibung.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Beschreibung.Multiline = True
        Me.Beschreibung.Name = "Beschreibung"
        Me.Beschreibung.Size = New System.Drawing.Size(136, 71)
        Me.Beschreibung.TabIndex = 3
        '
        'LB_Gewicht
        '
        Me.LB_Gewicht.Location = New System.Drawing.Point(75, 230)
        Me.LB_Gewicht.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LB_Gewicht.Name = "LB_Gewicht"
        Me.LB_Gewicht.Size = New System.Drawing.Size(136, 20)
        Me.LB_Gewicht.TabIndex = 4
        '
        'LB_Preis
        '
        Me.LB_Preis.Location = New System.Drawing.Point(75, 265)
        Me.LB_Preis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LB_Preis.Name = "LB_Preis"
        Me.LB_Preis.Size = New System.Drawing.Size(136, 20)
        Me.LB_Preis.TabIndex = 5
        Me.LB_Preis.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 230)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Gewicht"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 267)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Preis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Beschreibung"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(250, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Artikel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gruppe"
        '
        'Gruppe
        '
        Me.Gruppe.FormattingEnabled = True
        Me.Gruppe.Location = New System.Drawing.Point(100, 28)
        Me.Gruppe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Gruppe.Name = "Gruppe"
        Me.Gruppe.Size = New System.Drawing.Size(91, 30)
        Me.Gruppe.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 320)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 19)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Schließen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LB_Artikel
        '
        Me.LB_Artikel.FormattingEnabled = True
        Me.LB_Artikel.Location = New System.Drawing.Point(253, 53)
        Me.LB_Artikel.Name = "LB_Artikel"
        Me.LB_Artikel.Size = New System.Drawing.Size(120, 108)
        Me.LB_Artikel.TabIndex = 2
        '
        'ArtikelAuswahl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 359)
        Me.Controls.Add(Me.LB_Artikel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Gruppe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB_Gewicht)
        Me.Controls.Add(Me.LB_Preis)
        Me.Controls.Add(Me.Beschreibung)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ArtikelAuswahl"
        Me.Text = "Auswertung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Beschreibung As TextBox
    Friend WithEvents LB_Gewicht As TextBox
    Friend WithEvents LB_Preis As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Gruppe As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LB_Artikel As ListBox

End Class
