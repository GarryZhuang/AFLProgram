Imports System.IO

Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make the background tinted black
        Panel1.BackColor = Color.FromArgb(90, 0, 0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheckStats.Click
        'Load the database
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\AFLDatabase.csv")
        Dim a As String


        'Read the database
        Do
            a = reader.ReadLine
            If Not a Is Nothing Then
                Dim teamDataReader As String() = a.Split(",")
                If cbxTeam.SelectedItem.ToString = teamDataReader(0) Then

                    Dim RoundInfo As String = cbxRound.SelectedItem.ToString

                    txtRounds.Text = "Round " & RoundInfo & Environment.NewLine & cbxTeam.SelectedItem.ToString & Environment.NewLine & " VS " & Environment.NewLine & teamDataReader(RoundInfo)

                    Select Case cbxTeam.SelectedItem.ToString
                        Case "Adelaide"
                            pbxCurrent.BackgroundImage = My.Resources.AD

                        Case "Brisbane"
                            pbxCurrent.BackgroundImage = My.Resources.BL

                        Case "Carlton"
                            pbxCurrent.BackgroundImage = My.Resources.CFC

                        Case "Collingwood"
                            pbxCurrent.BackgroundImage = My.Resources.CP


                        Case "Essendon"
                            pbxCurrent.BackgroundImage = My.Resources.EFC

                        Case "Fremantle"

                            pbxCurrent.BackgroundImage = My.Resources.FFC
                        Case "Geelong"
                            pbxCurrent.BackgroundImage = My.Resources.GC

                        Case "Gold coast"
                            pbxCurrent.BackgroundImage = My.Resources.GC
                        Case "GWS"
                            pbxCurrent.BackgroundImage = My.Resources.G
                        Case "Hawthorn"

                            pbxCurrent.BackgroundImage = My.Resources.HW
                        Case "Melbourne"

                            pbxCurrent.BackgroundImage = My.Resources.MEL
                        Case "North Melbourne"

                            pbxCurrent.BackgroundImage = My.Resources.NMEL
                        Case "Port Adelaide"

                            pbxCurrent.BackgroundImage = My.Resources.PWR
                        Case "Richmond"

                            pbxCurrent.BackgroundImage = My.Resources.RMT
                        Case "St.Kilda"

                            pbxCurrent.BackgroundImage = My.Resources.STK
                        Case "Sydney"

                            pbxCurrent.BackgroundImage = My.Resources.SDS

                        Case "West Coast"

                            pbxCurrent.BackgroundImage = My.Resources.WCE
                        Case "Bulldogs"

                            pbxCurrent.BackgroundImage = My.Resources.WB

                    End Select




                    Select Case teamDataReader(RoundInfo)
                        Case "Adelaide"
                            pbxLater.BackgroundImage = My.Resources.AD

                        Case "Brisbane"
                            pbxLater.BackgroundImage = My.Resources.BL

                        Case "Carlton"
                            pbxLater.BackgroundImage = My.Resources.CFC

                        Case "Collingwood"
                            pbxLater.BackgroundImage = My.Resources.CP


                        Case "Essendon"
                            pbxLater.BackgroundImage = My.Resources.EFC

                        Case "Fremantle"

                            pbxLater.BackgroundImage = My.Resources.FFC
                        Case "Geelong"
                            pbxLater.BackgroundImage = My.Resources.GC

                        Case "Gold coast"
                            pbxLater.BackgroundImage = My.Resources.GC
                        Case "GWS"
                            pbxLater.BackgroundImage = My.Resources.G
                        Case "Hawthorn"

                            pbxLater.BackgroundImage = My.Resources.HW
                        Case "Melbourne"

                            pbxLater.BackgroundImage = My.Resources.MEL
                        Case "North Melbourne"

                            pbxLater.BackgroundImage = My.Resources.NMEL
                        Case "Port Adelaide"

                            pbxLater.BackgroundImage = My.Resources.PWR
                        Case "Richmond"

                            pbxLater.BackgroundImage = My.Resources.RMT
                        Case "St.Kilda"

                            pbxLater.BackgroundImage = My.Resources.STK
                        Case "Sydney"

                            pbxLater.BackgroundImage = My.Resources.SDS

                        Case "West Coast"

                            pbxLater.BackgroundImage = My.Resources.WCE
                        Case "Bulldogs"

                            pbxLater.BackgroundImage = My.Resources.WB

                    End Select


                    lblPW.Text = teamDataReader(24)
                    lblWSW.Text = teamDataReader(25)

                End If
            End If
        Loop Until a Is Nothing
        reader.Close()
    End Sub

    'Damon Fraser
End Class
