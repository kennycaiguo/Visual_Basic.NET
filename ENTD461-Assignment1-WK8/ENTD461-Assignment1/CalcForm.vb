'Wilman Gonzales
'week 8 Assignment


Imports System.IO
Imports System.Xml

Public Class CalcForm

  Dim Num1 As Decimal
  Dim Num2 As Decimal
  Dim Num3 As Decimal
  Dim LastOperation As String ' Indicates the last operation (+,-,* or /) that was used. Appended to file when 'Save' is clicked
  Dim adapter As New EquationsTableAdapters.Table1TableAdapter()
  Dim xmlFilename As String = "Equations.xml"

  Private Function ValidateInput() As Boolean
    TextBoxNum3.Clear()
    Try
      Num1 = TextBoxNum1.Text
    Catch ex As Exception
      MessageBox.Show(String.Format("First Number: {0}", ex.Message))
      TextBoxNum1.Clear()
      TextBoxNum1.Focus()
      Return False
    End Try

    Try
      Num2 = TextBoxNum2.Text
    Catch ex As Exception
      MessageBox.Show(String.Format("Second Number: {0}", ex.Message))
      TextBoxNum2.Clear()
      TextBoxNum2.Focus()
      Return False
    End Try
    Return True
  End Function

  Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
    If Not ValidateInput() Then Return

    Dim objCalc As New MathOp(Num1, Num2)
    Num3 = objCalc.Add()

    TextBoxNum3.Text = Num3
    LastOperation = String.Format("{0}+{1}={2}", Num1, Num2, Num3)
  End Sub

  Private Sub ButtonSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubtract.Click
    If Not ValidateInput() Then Return

    Dim objCalc As New MathOp(Num1, Num2)
    Num3 = objCalc.Subtract()

    TextBoxNum3.Text = Num3
    LastOperation = String.Format("{0}-{1}={2}", Num1, Num2, Num3)
  End Sub

  Private Sub ButtonMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMultiply.Click
    If Not ValidateInput() Then Return

    Dim objCalc As New MathOp2(Num1, Num2)
    Num3 = objCalc.Multiply()

    TextBoxNum3.Text = Num3
    LastOperation = String.Format("{0}*{1}={2}", Num1, Num2, Num3)
  End Sub

  Private Sub ButtonDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDivide.Click
    If Not ValidateInput() Then Return
    Try
      Dim objCalc As New MathOp2(Num1, Num2)
      Num3 = objCalc.Divide()
    Catch ex As DivideByZeroException When Num2 = 0
      MessageBox.Show("Cannot divide by 0, Please try again")
      TextBoxNum2.Focus()
      LastOperation = String.Empty
      Return
    End Try
    TextBoxNum3.Text = Num3
    LastOperation = String.Format("{0}/{1}={2}", Num1, Num2, Num3)

  End Sub

  Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    ListBox1.Items.Clear()
    My.Computer.FileSystem.WriteAllText("test.txt", "", False)
  End Sub

  Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    Dim file As System.IO.StreamWriter
    file = My.Computer.FileSystem.OpenTextFileWriter("test.txt", True)
    file.WriteLine(LastOperation)
    file.Close()
  End Sub

  Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
    Dim lines() As String = IO.File.ReadAllLines("test.txt")
    ListBox1.Items.Clear()
    ListBox1.Items.AddRange(lines)
  End Sub

  Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
    If ListBox1.SelectedIndex = -1 Then Return

    Dim line As String = ListBox1.SelectedItem
    Dim parts As String() = line.Split(New [Char]() {"+"c, "-"c, "*"c, "/"c, "="c})
    If parts.Length >= 3 Then
      TextBoxNum1.Text = parts(0)
      TextBoxNum2.Text = parts(1)
      TextBoxNum3.Clear()
    End If
  End Sub

  Private Sub btnWriteDB_Click(sender As Object, e As EventArgs) Handles btnWriteDB.Click
    If Not LastOperation Is Nothing Then
      adapter.Insert(LastOperation)
    End If
  End Sub

  Private Sub btnLoadDB_Click(sender As Object, e As EventArgs) Handles btnLoadDB.Click
    adapter.Fill(Equations1.Table1)
    ListBox1.Items.Clear()
    For Each row As Equations.Table1Row In Equations1.Table1.Rows()
      ListBox1.Items.Add(row.LastOperation)
    Next
  End Sub

  Private Sub btnWriteXML_Click(sender As Object, e As EventArgs) Handles btnWriteXML.Click
    If LastOperation Is Nothing Then
      Return
    End If

    Dim doc As New XmlDocument()
    Dim equationsNode As XmlElement
    Dim newElement As XmlElement

    If File.Exists(xmlFilename) Then
      doc.Load(xmlFilename)
      equationsNode = doc("Equations")
    Else
      doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", "yes"))
      equationsNode = doc.CreateElement("Equations")
      doc.AppendChild(equationsNode)
    End If

    newElement = doc.CreateElement("Equation")
    newElement.InnerText = LastOperation
    equationsNode.AppendChild(newElement)
    doc.Save(xmlFilename)
  End Sub

  Private Sub btnLoadXML_Click(sender As Object, e As EventArgs) Handles btnLoadXML.Click
    If Not File.Exists(xmlFilename) Then
      Return
    End If

    Dim doc As New XmlDocument()
    Dim equationsNode As XmlElement
    doc.Load(xmlFilename)
    equationsNode = doc("Equations")
    ListBox1.Items.Clear()
    For Each childNode As XmlElement In doc("Equations")
      ListBox1.Items.Add(childNode.InnerText)
    Next
  End Sub
End Class
