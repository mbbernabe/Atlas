
Imports System
Imports System.Collections
Imports System.Collections.Specialized



'*********************************************************************
'
' colMsgErro Class
'
'
'*********************************************************************

Public Class colMsgErros
    Inherits Hashtable

    Private erroOrdenado As New ArrayList()
    Private erroPorID As New Hashtable()




    '*********************************************************************
    '
    ' Add Method
    '
    '
    '*********************************************************************
    Public Overrides Sub Add(ByVal key As [Object], ByVal value As [Object])

        ' Don't allow duplicate values
        If Contains(key) Then
            Return
        End If
        erroOrdenado.Add(value)
        erroPorID.Add(key, value)
        MyBase.Add(key, value)
    End Sub 'Add


    '*********************************************************************
    '
    ' this Indexer
    '
    ' Adds a SectionInfo object. 
    '
    '*********************************************************************

    Default Public Overloads Overrides Property Item(ByVal key As [Object]) As [Object]
        Set(ByVal Value As [Object])
            ' Don't allow duplicate values
            If Contains(key) Then
                Return
            End If
            ' erroOrdenado.Add(Value)
            'erroPorID.Add(CType(Value, SectionInfo).ID, Value)
            'MyBase.Item(key) = Value
        End Set
        Get
            Return MyBase.Item(key)
        End Get
    End Property





    '*********************************************************************
    '
    ' GetOrderedSections Method
    '
    ' Returns an ordered list of sections. 
    '
    '*********************************************************************
    Public Function GetErroOrdenado() As ArrayList
        Return erroOrdenado
    End Function 'GetOrderedSections



    '*********************************************************************
    '
    ' GetSectionByID Method
    '
    ' Returns SectionInfo object from a section ID. 
    '
    '*********************************************************************
    Public Function GetErroPorID(ByVal Key As Integer) As String
        Return CType(erroPorID(Key), String)
    End Function 'GetSectionByID





    '*********************************************************************
    '
    ' SectionCollection Constructor
    '
    ' Initializes SectionCollection as a case-insensitive Hashtable. 
    '
    '*********************************************************************
    Public Sub New()
        MyBase.New(New CaseInsensitiveHashCodeProvider(), New CaseInsensitiveComparer())
    End Sub 'New 
End Class