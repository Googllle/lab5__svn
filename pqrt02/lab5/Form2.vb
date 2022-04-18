Public Class Form2
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Dim listOfStudent As List(Of Student) = New List(Of Student)()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stud As Student = New Student
        stud.firstName = TextBox1.Text
        stud.lastName = TextBox2.Text
        stud.firstExam = TextBox3.Text
        stud.secondExam = TextBox4.Text
        stud.thirdExam = TextBox5.Text
        stud.stipend = 2
        listOfStudent.Add(stud)
        showStudents()
    End Sub
    Public Sub clearGrid()
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
    End Sub

    Public Sub showStudents()
        clearGrid()
        For i As Integer = 0 To listOfStudent.Count - 1
            DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells(0).Value = listOfStudent(i).firstName.ToString
            DataGridView1.Rows(i).Cells(1).Value = listOfStudent(i).lastName.ToString
            DataGridView1.Rows(i).Cells(2).Value = listOfStudent(i).firstExam
            DataGridView1.Rows(i).Cells(3).Value = listOfStudent(i).secondExam
            DataGridView1.Rows(i).Cells(4).Value = listOfStudent(i).thirdExam
            DataGridView1.Rows(i).Cells(5).Value = listOfStudent(i).stipend
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 0 To listOfStudent.Count - 1
            If listOfStudent(i).check = False Then
                If listOfStudent(i).firstExam = 5 And listOfStudent(i).secondExam = 5 And listOfStudent(i).thirdExam = 5 Then
                    Dim result As Double = ((listOfStudent(i).stipend * 50) / 100) + listOfStudent(i).stipend
                    listOfStudent(i).stipend = result
                    listOfStudent(i).check = True
                ElseIf (listOfStudent(i).firstExam = 5 And listOfStudent(i).secondExam = 5 And listOfStudent(i).thirdExam = 4) Or (listOfStudent(i).firstExam = 5 And listOfStudent(i).secondExam = 4 And listOfStudent(i).thirdExam = 5) Or (listOfStudent(i).firstExam = 4 And listOfStudent(i).secondExam = 5 And listOfStudent(i).thirdExam = 5) Then
                    Dim result As Double = ((listOfStudent(i).stipend * 25) / 100) + listOfStudent(i).stipend
                    listOfStudent(i).stipend = result
                    listOfStudent(i).check = True
                ElseIf listOfStudent(i).firstExam = 2 Or listOfStudent(i).secondExam = 2 Or listOfStudent(i).thirdExam = 2 Then
                    listOfStudent(i).stipend = 0
                    listOfStudent(i).check = True
                End If
            End If
        Next
        showStudents()
    End Sub
End Class