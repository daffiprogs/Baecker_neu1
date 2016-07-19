Public Class TagEingabe
    Dim SelectGruppe As String
    Dim SelectArtikel As String
    Dim oSM As Object
    Dim oDesk, oDoc As Object
    Dim oSheet, oCell As Object
    Dim WahlPunkte As Integer
    Dim WahlArtikel As String
    Dim WahlAnzahl As Integer


    Private Sub Auswertung_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oSM = CreateObject("com.sun.star.ServiceManager")
        oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
        Dim str As String = "Z:\Florian\Baecker_neu1\Liste 1.ods"
        str = str.Replace("\", "/")

        Dim ladeZustand(0)
        ladeZustand(0) = oSM.Bridge_GetStruct("com.sun.star.beans.PropertyValue")
        ladeZustand(0).Name = "Hidden"
        ladeZustand(0).Value = True
        oDoc = oDesk.loadComponentFromURL("file:///" & str, "_blank", 0, ladeZustand)

        Dim lastZe As String = 0

        oSheet = oDoc.getSheets().getByIndex(3)
        ' erste Zelle des Blattes. Achtung: Obere Ecke A1 ist (0, 0)
        ' also auch die Zellen sind 0-indiziert
        lastZe = UBound(oSheet.data)
        Dim i As Integer = 1

        For i = 1 To lastZe
            oCell = oSheet.getCellByPosition(0, i)
            Gruppe.Items.Add(oCell.string)
        Next
    End Sub
    Private Sub Gruppe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gruppe.SelectedIndexChanged
        SelectGruppe = Gruppe.SelectedItem 'Select Gruppe bekommt die ausgewählte Gruppe zugewiesen
        LB_Artikel.Items.Clear()
        Dim lastZe As String = 0
        oSheet = oDoc.getSheets().getByIndex(1)
        lastZe = UBound(oSheet.data)

        Dim i As Integer = 1
        For i = 1 To lastZe
            oCell = oSheet.getCellByPosition(0, i)
            If oCell.String = SelectGruppe Then
                oCell = oSheet.getCellByPosition(1, i)
                LB_Artikel.Items.Add(oCell.string)
            End If
        Next
    End Sub



    'Private Sub Artikel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_Artikel.SelectedIndexChanged
    '    SelectArtikel = LB_Artikel.SelectedItem 'SelectArtikel bekommt den ausgewählten Artikel zugewiesen
    '    Dim lastZe As String = 0
    '    oSheet = oDoc.getSheets().getByIndex(1)
    '    lastZe = UBound(oSheet.data)
    '    LB_Beschreibung.Text = " "
    '    LB_Kalorien.Text = " "
    '    LB_Fett.Text = " "
    '    LB_Punkte.Text = " "


    '    Dim i As Integer = 1
    '    For i = 1 To lastZe
    '        oCell = oSheet.getCellByPosition(0, i)
    '        'MessageBox.Show(oCell.string)
    '        If oCell.String = SelectGruppe Then
    '            oCell = oSheet.getCellByPosition(1, i)
    '            If oCell.string = SelectArtikel Then
    '                WahlArtikel = oCell.String
    '                oCell = oSheet.getCellByPosition(2, i)
    '                LB_Beschreibung.Text = oCell.string
    '                oCell = oSheet.getCellByPosition(3, i)
    '                LB_Kalorien.Text = LB_Kalorien.Text & ": " & oCell.string
    '                oCell = oSheet.getCellByPosition(4, i)
    '                LB_Fett.Text = LB_Fett.Text & ": " & oCell.String
    '                oCell = oSheet.getCellByPosition(5, i)
    '                LB_Punkte.Text = LB_Punkte.Text & ": " & oCell.string
    '                WahlPunkte = oCell.Value
    '            End If
    '        End If

    '    Next

    'End Sub
    'Private Sub NUD_Anzahl_ValueChanged(sender As Object, e As EventArgs) Handles NUD_Anzahl.ValueChanged
    '    WahlAnzahl = NUD_Anzahl.Value
    '    WahlPunkte = NUD_Anzahl.Value * WahlPunkte
    'End Sub
    'Private Sub Uebernehmen_Click(sender As Object, e As EventArgs) Handles Uebernehmen.Click
    '    lvwAddItem(ListView1, WahlArtikel, WahlAnzahl, WahlPunkte)
    'End Sub


    'Public Sub lvwAddItem(ByVal lvw As ListView, ByVal ParamArray Werte() As String)
    '    'Definition Array.copy
    '    'Public Shared Sub Copy(
    '    'sourceArray As Array,
    '    'sourceIndex As Integer..Index ab dem kopiert werden soll,
    '    'destinationArray As Array,
    '    'destinationIndex As Integer Index ab dem gespeichert werden soll
    '    'length As Integer Anzahl der zu kopierenden Elemente
    '    With lvw.Items
    '        ' 1. Eintrag hinzufügen - Werte(0) gibt den Namen ListView1 an
    '        With .Add(Werte(0))
    '            'With .Add(ListView1)
    '            If Werte.Length > 1 Then
    '                    ' String-Array für die weiteren Zellen erstellen...
    '                    ' Es wird ein String-Array angelegt. werte.lenth-1 gibt an, wieviele Werte
    '                    Dim SubItems(Werte.Length - 1) As String
    '                    Array.Copy(Werte, 1, SubItems, 0, Werte.Length - 1)

    '                    ' ... und diese via AddRange dem ListView hinzufügen
    '                    .SubItems.AddRange(SubItems)
    '                End If
    '            End With
    '        End With
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'oSheet = oDoc.getSheets().getByName("Teilnehmer")
        'oCell = oSheet.getCellByPosition(0, 0)
        'Dim i As Integer = 1
        'Dim LastZe As Integer = 0
        'LastZe = UBound(oSheet.data)
        'For i = 0 To LastZe
        '    oCell = oSheet.getCellByPosition(1, i)
        '    If oCell.string = "Teilnehmer" Then

        '        oCell = oSheet.getCellByPosition(6, i)
        '        oCell.value = "WoLimit"
        '    End If
        'Next

        'oSheet = oDoc.getSheets().getByName("Tage")
        ''i = 0
        'LastZe = UBound(oSheet.data)

        For Each item As ListViewItem In ListView1.Items

            'For i = 0 To item.SubItems.Count - 1
            oCell = oSheet.getCellByPosition(0, LastZe)

            oCell = oSheet.getCellByPosition(1, LastZe)
            oCell.value = DateTimePicker1.Value
            oCell = oSheet.getCellByPosition(2, LastZe)
            oCell.string = item.SubItems(0).Text
            oCell = oSheet.getCellByPosition(3, LastZe)
            oCell.value = item.SubItems(1).Text
            oCell = oSheet.getCellByPosition(4, LastZe)
            oCell.value = item.SubItems(2).Text
            LastZe = LastZe + 1

        Next
        'Dim MeStr As String = Hauptmenue.str.Replace("\", "/")
        'MeStr = MeStr.Replace("\", "/")
        'Hauptmenue.ladezustand(0) = Hauptmenue.oSM.Bridge_GetStruct("com.sun.star.beans.PropertyValue")
        'Hauptmenue.ladezustand(0).Name = "Hidden"
        'Hauptmenue.ladezustand(0).Value = True

        MessageBox.Show("Str")
        oDoc.storeAsURL("file:///" & Str(), ladezustand)

        MessageBox.Show("Ihre Änderungen wurden gespeichert")

        oSheet = Nothing
        Close()

        'OpenOffice sauber (ab)schliessen
        oDoc.Close(True)
        oDoc = Nothing
        oSheet = Nothing
        oDesk = Nothing
        oSM = Nothing
        Close()
    End Sub
End Class