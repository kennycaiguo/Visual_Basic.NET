'Wilman Gonzales
'Class MathOp

'this is the MathOP class

Public Class MathOp
    Protected Num1 As Decimal
    Protected Num2 As Decimal

    Public Sub New(n1 As Decimal, n2 As Decimal)
        Num1 = n1
        Num2 = n2
    End Sub
    ' this is the add function
    Public Function Add() As Decimal
        Return Num1 + Num2
    End Function
    ' this is the subtract funtion
    Public Function Subtract() As Decimal
        Return Num1 - Num2
    End Function

End Class
