'Wilman Gonzales


'this is the MathOP2 class


Public Class MathOp2
    Inherits MathOp

    Public Sub New(n1 As Decimal, n2 As Decimal)
        ' Call the base class constructor to store n1 and n2. 
        MyBase.New(n1, n2)
    End Sub
    'this is the Multiply function
    Public Function Multiply() As Decimal
        Return Num1 * Num2
    End Function
    ' this is the division function
    Public Function Divide() As Decimal
        Return Num1 / Num2
    End Function
End Class
