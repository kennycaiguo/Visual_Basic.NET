' Name:         Payroll.vb
' Programmer:   Wilman Gonzales 10/09/14

Option Explicit On
Option Strict On
Option Infer Off

' base 
Public Class Bonus
    Public Property SalesId As String
    Public Property Sales As Double
    Public Sub New()
        _SalesId = String.Empty
        _Sales = 0
    End Sub
    Public Sub New(ByVal strId As String, ByVal dblSold As Double)
        SalesId = strId
        Sales = dblSold
    End Sub
    Public Overridable Function GetBonus() As Double
        Return _Sales * 0.05
    End Function
End Class




'this is the other 





' derived 
Public Class PremiumBonus
    Inherits Bonus

    Public Sub New()
        MyBase.new()
    End Sub
    Public Sub New(ByVal strId As String, ByVal dblSold As Double)
        MyBase.New(strId, dblSold)
    End Sub
    Public Overrides Function GetBonus() As Double
        Return MyBase.GetBonus + (Sales - 2500) * 0.01
    End Function
End Class
