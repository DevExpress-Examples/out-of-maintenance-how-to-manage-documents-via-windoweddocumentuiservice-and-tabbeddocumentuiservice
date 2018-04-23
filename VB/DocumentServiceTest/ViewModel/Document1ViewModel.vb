Imports DevExpress.Mvvm

Namespace DocumentServiceTest.ViewModel
    Public Class Document1ViewModel
        Inherits ViewModelBase


        Private text_Renamed As String
        Public Property Text() As String
            Get
                Return text_Renamed
            End Get
            Set(ByVal value As String)
                SetProperty(text_Renamed, value, Function() Text)
            End Set
        End Property
    End Class
End Namespace
