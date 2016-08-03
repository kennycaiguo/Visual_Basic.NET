Public Class MathOp2
    Inherits MathOp

    Public Sub New(n1 As Decimal, n2 As Decimal)
        ' Call the base class constructor to store n1 and n2. Nothing else needed
        MyBase.New(n1, n2)
    End Sub

    Public Function Multiply() As Decimal
        Return Num1 * Num2
    End Function

    Public Function Divide() As Decimal
        Return Num1 / Num2
    End Function
End Class
