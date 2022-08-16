Public Class Form1
    Private Sub BtnOutput_Click(sender As Object, e As EventArgs) Handles BtnOutput.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            MsgBox(aiData(i))
        Next

    End Sub

    Private Sub btnOutputAll_Click(sender As Object, e As EventArgs) Handles btnOutputAll.Click


        Dim aiData(4) As Integer
        Dim stConcat As String
        stConcat = ""


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8
        For i = 0 To 4
            stConcat = stConcat & aiData(i) & vbNewLine

        Next

        MsgBox(stConcat)

    End Sub

    Private Sub BtnAddAll_Click(sender As Object, e As EventArgs) Handles BtnAddAll.Click

        Dim aiData(4) As Integer
        Dim holder As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            holder += aiData(i)

        Next
        MsgBox("The sum total is " & holder)

    End Sub

    Private Sub BtnAverage_Click(sender As Object, e As EventArgs) Handles BtnAverage.Click

        Dim aiData(4) As Integer
        Dim holder As Integer
        Dim average As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            holder += aiData(i)
        Next
        average = holder / aiData.Length

        MsgBox("The average is " & average)
    End Sub

    Private Sub BtnAddOver20_Click(sender As Object, e As EventArgs) Handles BtnAddOver20.Click

        Dim aiData(4) As Integer
        Dim sum As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            If aiData(i) > 20 Then
                sum += aiData(i)
            End If
        Next
        MsgBox("The sum of numbers over 20 is " & sum)

    End Sub

    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles BtnMax.Click

        Dim aiData(4) As Integer
        Dim intLarge As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            If aiData(i) > intLarge Then
                intLarge = aiData(i)
            End If
        Next

        MsgBox("The largest number is " & intLarge)


    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click


        Dim aiData(4) As Integer
        Dim intSmall As Integer
        intSmall = 50

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            If aiData(i) < intSmall Then
                intSmall = aiData(i)
            End If
        Next

        MsgBox("The smallest number is " & intSmall)

    End Sub

    Private Sub BtnDoubleAndOutput_Click(sender As Object, e As EventArgs) Handles BtnDoubleAndOutput.Click

        Dim aiData(4) As Integer
        Dim aiDouble(4) As Integer
        Dim stHolder As String
        stHolder = ""


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            aiDouble(i) = 2 * aiData(i)
            stHolder = stHolder & aiDouble(i) & vbNewLine
        Next
        MsgBox(stHolder)
    End Sub
End Class
