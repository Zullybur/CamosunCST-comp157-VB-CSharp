'Address class to store objects containing nicknames, names, and emails of individuals
'Created by: Matthew Casiro
'Created on: May 5th 2016
Public Class Address
    Private strNickname As String
    Private strName As String
    Private strEmail As String
    'Create new address object with all fields filled
    Sub New(ByVal pstrNickname As String, ByVal pstrName As String, ByVal pstrEmail As String)
        MyBase.New()
        strNickname = pstrNickname
        strName = pstrName
        strEmail = pstrEmail
    End Sub
    'Get or set the Nickname property
    Public Property Nickname() As String
        Get
            Return strNickname
        End Get
        Set(ByVal value As String)
            strNickname = value
        End Set
    End Property
    'Get or set the Name property
    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property
    'Get or set the Email property
    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property

End Class