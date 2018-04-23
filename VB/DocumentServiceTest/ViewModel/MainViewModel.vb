Imports DevExpress.Mvvm
Imports System.Windows.Input

Namespace DocumentServiceTest.ViewModel
    Public Class MainViewModel
        Inherits ViewModelBase

        Private privateShowDocumentCommand As ICommand
        Public Property ShowDocumentCommand() As ICommand
            Get
                Return privateShowDocumentCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateShowDocumentCommand = value
            End Set
        End Property
        Private ReadOnly Property DocumentManager() As IDocumentManagerService
            Get
                Return GetService(Of IDocumentManagerService)()
            End Get
        End Property
        Public Sub New()
            ShowDocumentCommand = New DelegateCommand(Of String)(AddressOf OnShowDocumentCommandExecute)
        End Sub
        Private Sub OnShowDocumentCommandExecute(ByVal document As String)
            Dim doc As IDocument = DocumentManager.CreateDocument(document, Nothing, Me)
            doc.DestroyOnClose = True
            doc.Title = document
            doc.Show()
        End Sub
    End Class
End Namespace