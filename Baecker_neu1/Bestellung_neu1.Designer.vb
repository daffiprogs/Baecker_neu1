<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bestellung_neu1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bestellung_neu1))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Gruppe = New System.Windows.Forms.ListBox()
        Me.LB_Artikel = New System.Windows.Forms.ListBox()
        Me.Uebernehmen = New System.Windows.Forms.Button()
        Me.NUD_Anzahl = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Beschr = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.LV_Brötchen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV_Anzahl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV_Preis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Beschreibung = New System.Windows.Forms.TextBox()
        Me.TB_Preis = New System.Windows.Forms.TextBox()
        CType(Me.NUD_Anzahl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(20, 22)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(192, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(548, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 50)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Bestellung Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Gesamtpreis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 341)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gruppen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 341)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Artikel"
        '
        'Gruppe
        '
        Me.Gruppe.FormattingEnabled = True
        Me.Gruppe.Location = New System.Drawing.Point(45, 368)
        Me.Gruppe.Margin = New System.Windows.Forms.Padding(2)
        Me.Gruppe.Name = "Gruppe"
        Me.Gruppe.Size = New System.Drawing.Size(91, 69)
        Me.Gruppe.TabIndex = 1
        '
        'LB_Artikel
        '
        Me.LB_Artikel.FormattingEnabled = True
        Me.LB_Artikel.Location = New System.Drawing.Point(175, 368)
        Me.LB_Artikel.Margin = New System.Windows.Forms.Padding(2)
        Me.LB_Artikel.Name = "LB_Artikel"
        Me.LB_Artikel.Size = New System.Drawing.Size(91, 69)
        Me.LB_Artikel.TabIndex = 2
        '
        'Uebernehmen
        '
        Me.Uebernehmen.Location = New System.Drawing.Point(584, 418)
        Me.Uebernehmen.Margin = New System.Windows.Forms.Padding(2)
        Me.Uebernehmen.Name = "Uebernehmen"
        Me.Uebernehmen.Size = New System.Drawing.Size(85, 19)
        Me.Uebernehmen.TabIndex = 4
        Me.Uebernehmen.Text = "Übernehmen"
        Me.Uebernehmen.UseVisualStyleBackColor = True
        '
        'NUD_Anzahl
        '
        Me.NUD_Anzahl.Location = New System.Drawing.Point(584, 380)
        Me.NUD_Anzahl.Margin = New System.Windows.Forms.Padding(2)
        Me.NUD_Anzahl.Name = "NUD_Anzahl"
        Me.NUD_Anzahl.Size = New System.Drawing.Size(90, 20)
        Me.NUD_Anzahl.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(584, 351)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Anzahl"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 341)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Beschreibung:"
        '
        'Beschr
        '
        Me.Beschr.AutoSize = True
        Me.Beschr.Location = New System.Drawing.Point(290, 368)
        Me.Beschr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Beschr.Name = "Beschr"
        Me.Beschr.Size = New System.Drawing.Size(0, 13)
        Me.Beschr.TabIndex = 14
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LV_Brötchen, Me.LV_Anzahl, Me.LV_Preis})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(20, 65)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(475, 263)
        Me.ListView1.TabIndex = 22
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'LV_Brötchen
        '
        Me.LV_Brötchen.Text = "Artikel"
        '
        'LV_Anzahl
        '
        Me.LV_Anzahl.Text = "Anzahl"
        '
        'LV_Preis
        '
        Me.LV_Preis.Text = "Preis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 341)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Preis:"
        '
        'TB_Beschreibung
        '
        Me.TB_Beschreibung.Location = New System.Drawing.Point(293, 368)
        Me.TB_Beschreibung.Multiline = True
        Me.TB_Beschreibung.Name = "TB_Beschreibung"
        Me.TB_Beschreibung.Size = New System.Drawing.Size(100, 80)
        Me.TB_Beschreibung.TabIndex = 3
        '
        'TB_Preis
        '
        Me.TB_Preis.Location = New System.Drawing.Point(418, 368)
        Me.TB_Preis.Name = "TB_Preis"
        Me.TB_Preis.Size = New System.Drawing.Size(100, 20)
        Me.TB_Preis.TabIndex = 4
        Me.TB_Preis.Text = "0,0"
        '
        'Bestellung_neu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(716, 453)
        Me.Controls.Add(Me.TB_Preis)
        Me.Controls.Add(Me.TB_Beschreibung)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Beschr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NUD_Anzahl)
        Me.Controls.Add(Me.Uebernehmen)
        Me.Controls.Add(Me.LB_Artikel)
        Me.Controls.Add(Me.Gruppe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Bestellung_neu1"
        Me.Text = "Tag"
        CType(Me.NUD_Anzahl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Gruppe As ListBox
    Friend WithEvents LB_Artikel As ListBox
    Friend WithEvents Uebernehmen As Button
    Friend WithEvents NUD_Anzahl As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Beschr As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents LV_Brötchen As ColumnHeader
    Friend WithEvents LV_Anzahl As ColumnHeader
    Friend WithEvents LV_Preis As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_Beschreibung As TextBox
    Friend WithEvents TB_Preis As TextBox
End Class
