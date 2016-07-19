Public Class ArtikelAuswahl

    'Hier werden alle Variablen definiert, die für OpenOffice von Bedeutung sind
    ' Sie müssen außerhalb der Routine Button1_Click definiert werden, damit sie
    ' auch für die weiteren Routinen (Sub) zur Verfügung stehen
    Dim SelectGruppe As String
    Dim SelectArtikel As String
    Dim oSM As Object
    Dim oDesk, oDoc As Object
    Dim oSheet, oCell As Object


    Private Sub Auswertung_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' OpenOffice instanziieren
        ' Zwingend notwenig für die Kommunikation von VB.Net mit OpenOffice API
        ' Erstellen des ersten und wichtigsten Diensts
        ' Öffnet ein vorhandenes OO-Calc-Tabellendokuments
        oSM = CreateObject("com.sun.star.ServiceManager")
        oDesk = oSM.createInstance("com.sun.star.frame.Desktop")

        ' In die Variable str wird der Pfad für die OpenOfficeCalc Datei abgespeichert
        ' ----> HIER PFAD ANPASSEN!!
        ' Da OpenOffice aus der Unix-Welt stammt, müssen die Windows Backslash
        ' mit der Funktion Replace in Slash umgewandelt werden
        Dim str As String = "X:\Claudia\Baecker_neu1\abnehmen.ods"
        str = str.Replace("\", "/")

        'Die folgende Funktion bewirkt, dass das .ods Dokument nicht sichtbar ist
        'Ihr merkt also gar nicht, dass Open Office gestartet wird.
        'Bei Hidden = False seht ihr die Tabelle
        Dim ladeZustand(0)
        ladeZustand(0) = oSM.Bridge_GetStruct("com.sun.star.beans.PropertyValue")
        ladeZustand(0).Name = "Hidden"
        ladeZustand(0).Value = True

        ' öffnen der Datei mit der Variablen ladeZustand für Tabelle sichtbar oder nicht
        ' mit & wird der Ausdruck "file:" und der Pfad von str verbunden
        oDoc = oDesk.loadComponentFromURL("file:///" & str, "_blank", 0, ladeZustand)
        ' Bezugspunkt: 1.Blatt der OpenOffice-Calc-Mappe (0-indiziert)
        ' 0-indiziert bedeutet, dass eigentlich die erste Tabelle mit 0 aufgerufen wird
        ' die zweite Tabelle mit 1 und so weiter
        ' Alternativ kann auch .getByName("name der Tabelle") für den Aufruf der
        ' Tabelle gewählt werden
        Dim lastZe As String = 0

        oSheet = oDoc.getSheets().getByIndex(3)
        ' erste Zelle des Blattes. Achtung: Obere Ecke ist A1 ist (0, 0)
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
        Dim lastZe As String = 0
        oSheet = oDoc.getSheets().getByIndex(1)
        lastZe = UBound(oSheet.data)

        Dim i As Integer = 1
        For i = 1 To lastZe
            oCell = oSheet.getCellByPosition(0, i)
            'MessageBox.Show(oCell.string)
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


        Dim i As Integer = 1
        For i = 1 To lastZe
            oCell = oSheet.getCellByPosition(0, i)
            'MessageBox.Show(oCell.string)
            If oCell.String = SelectGruppe Then
                oCell = oSheet.getCellByPosition(1, i)
                If oCell.string = SelectArtikel Then
                    oCell = oSheet.getCellByPosition(2, i)
                    Beschreibung.Text = oCell.string
                    oCell = oSheet.getCellByPosition(3, i)
                    LB_Kalorien.Text = oCell.string
                    oCell = oSheet.getCellByPosition(4, i)
                    Fett.Text = oCell.string
                    oCell = oSheet.getCellByPosition(5, i)
                    Punkte.Text = oCell.string
                    Exit For
                End If
            End If
        Next

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