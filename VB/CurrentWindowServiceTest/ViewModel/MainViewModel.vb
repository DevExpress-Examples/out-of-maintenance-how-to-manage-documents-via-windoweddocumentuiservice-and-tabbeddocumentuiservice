Imports DevExpress.Mvvm
Imports System.Windows.Input

Namespace CurrentWindowServiceTest.ViewModel
    Public Class MainViewModel
        Inherits ViewModelBase

        Private ReadOnly Property CurrentWindowService() As ICurrentWindowService
            Get
                Return GetService(Of ICurrentWindowService)()
            End Get
        End Property
        Private privateCloseWindowCommand As ICommand
        Public Property CloseWindowCommand() As ICommand
            Get
                Return privateCloseWindowCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateCloseWindowCommand = value
            End Set
        End Property
        Public Sub New()
            CloseWindowCommand = New DelegateCommand(AddressOf OnCloseWindowCommandExecute)
        End Sub
        Private Sub OnCloseWindowCommandExecute()
            CurrentWindowService.Close()
        End Sub
    End Class
End Namespace
