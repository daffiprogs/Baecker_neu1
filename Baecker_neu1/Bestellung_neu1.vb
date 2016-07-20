Public Class Bestellung_neu1
    Dim SelectGruppe As String
    Dim SelectArtikel As String
    Dim oSM As Object
    Dim oDesk, oDoc As Object
    Dim oSheet, oCell As Object
    Dim WahlPreis, WahlPreisOriginal As Double
    Dim WahlArtikel As String
    Dim WahlAnzahl As Integer



    Private Sub Auswertung_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        oSM = CreateObject("com.sun.star.ServiceManager")
        oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
        Dim str As String = "X:\Claudia\Baecker_neu1\Baecker_neu.ods"
        str = str.Replace("\", "/")

        Dim ladeZustand(0)
        ladeZustand(0) = oSM.Bridge_GetStruct("com.sun.star.beans.PropertyValue")
        ladeZustand(0).Name = "Hidden"
        ladeZustand(0).Value = True

        Dim lastZe As String = 0
        oDoc = oDesk.loadComponentFromURL("file:///" & str, "_blank", 0, ladeZustand)
        oSheet = oDoc.getSheets().getByIndex(0)
        ' erste Zelle des Blattes. Achtung: Obere Ecke A1 ist (0, 0)
        ' also auch die Zellen sind 0-indiziert
        lastZe = UBound(oSheet.data)
        Dim i As Integer = 0
        'Anzeige der Gruppen
        For i = 1 To lastZe
            oCell = oSheet.getCellByPosition(0, i)
            Gruppe.Items.Add(oCell.string)
        Next
    End Sub

    'Das folgende Sub wird aufgerufen, sobald eine Gruppe durch anklicken gewählt wurde
    Private Sub Gruppe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gruppe.SelectedIndexChanged
        SelectGruppe = Gruppe.SelectedItem 'Select Gruppe bekommt die ausgewählte Gruppe zugewiesen
        LB_Artikel.Items.Clear()
        Dim lastZe As String = 0
        oSheet = oDoc.getSheets().getByIndex(1)
        lastZe = UBound(oSheet.data)
        'Anzeige der Artikel
        Dim i As Integer = 1
        For i = 1 To lastZe
            oCell = oSheet.getCellByPosition(0, i)
            If oCell.String = SelectGruppe Then
                oCell = oSheet.getCellByPosition(1, i)
                LB_Artikel.Items.Add(oCell.string)
            End If
        Next
    End Sub
    Private Sub Artikel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_Artikel.SelectedIndexChanged
        SelectArtikel = LB_Artikel.SelectedItem 'SelectArtikel bekommt den ausgewählten Artikel zugewiesen
        Dim lastZe As String = 0
        oSheet = oDoc.getSheets().getByIndex(1)
        lastZe = UBound(oSheet.data)

        'Wenn die ausgewählte Gruppe und der gewählte Artikel stimmen,
        'werden Beschreibung und Preis angezeigt. Anzahl wird zurückgesetzt.
        Dim i As Integer = 1
        For i = 1 To lastZe
            oCell = oSheet.getCellByPosition(0, i)
            If oCell.String = SelectGruppe Then
                oCell = oSheet.getCellByPosition(1, i)
                If oCell.string = SelectArtikel Then
                    WahlArtikel = oCell.String
                    oCell = oSheet.getCellByPosition(2, i)
                    TB_Beschreibung.Text = oCell.string
                    oCell = oSheet.getCellByPosition(4, i)
                    TB_Preis.Text = oCell.string
                    WahlAnzahl = 0

                    Exit For
                End If
            End If
        Next

    End Sub

    Private Sub NUD_Anzahl_ValueChanged(sender As Object, e As EventArgs) Handles NUD_Anzahl.ValueChanged
        WahlPreisOriginal = Convert.ToDouble(TB_Preis.Text)
        WahlAnzahl = NUD_Anzahl.Value
        WahlPreis = WahlAnzahl * WahlPreisOriginal
    End Sub

    Private Sub Uebernehmen_Click(sender As Object, e As EventArgs) Handles Uebernehmen.Click
        'Prüfen, ob item schon existiert.
        Dim item1 As ListViewItem = ListView1.FindItemWithText(WahlArtikel)
        If (item1 IsNot Nothing) Then
            Dim i = item1.Index
            If WahlAnzahl = 0 Then
                ListView1.Items.RemoveAt(i)
                'Ansonsten, wenn Item exisitiert, Anzahl und Preis ändern
            Else
                'Anzahl und Preis ändern
                ListView1.Items(i).SubItems(1).Text = WahlAnzahl
                ListView1.Items(i).SubItems(2).Text = WahlPreis
                i = Nothing
                NUD_Anzahl.Value = 0
            End If
        Else
            lvwAddItem(ListView1, WahlArtikel, WahlAnzahl, WahlPreis)
        End If
    End Sub

    Public Sub lvwAddItem(ByVal lvw As ListView, ByVal ParamArray Werte() As String)
        With lvw.Items
            ' 1. Eintrag hinzufügen - Werte(0) gibt den Namen ListView1 an
            With .Add(Werte(0))
                'With .Add(ListView1)
                If Werte.Length > 1 Then
                    ' String-Array für die weiteren Zellen erstellen...
                    ' Es wird ein String-Array angelegt. werte.lenth-1 gibt an, wieviele Werte
                    Dim SubItems(Werte.Length - 1) As String
                    Array.Copy(Werte, 1, SubItems, 0, Werte.Length - 1)


                    ' ... und diese via AddRange dem ListView hinzufügen
                    .SubItems.AddRange(SubItems)
                End If
            End With
        End With
        'Anzahl für den nächsten Artikel zurücksetzen
        NUD_Anzahl.Value = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'OpenOffice sauber (ab)schliessen
        oDoc.Close(True)
        oDoc = Nothing
        oSheet = Nothing
        oDesk = Nothing
        oSM = Nothing
        Close()
    End Sub
End Class