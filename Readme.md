<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CurrentWindowServiceTest/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CurrentWindowServiceTest/MainWindow.xaml))
* [MainView.xaml](./CS/CurrentWindowServiceTest/View/MainView.xaml) (VB: [MainView.xaml](./VB/CurrentWindowServiceTest/View/MainView.xaml))
* [MainViewModel.cs](./CS/CurrentWindowServiceTest/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/CurrentWindowServiceTest/ViewModel/MainViewModel.vb))
* [TabbedDocumentUIServiceWindow.xaml](./CS/DocumentServiceTest/TabbedDocumentUIServiceWindow.xaml) (VB: [TabbedDocumentUIServiceWindow.xaml](./VB/DocumentServiceTest/TabbedDocumentUIServiceWindow.xaml))
* [Document1View.xaml](./CS/DocumentServiceTest/View/Document1View.xaml) (VB: [Document1View.xaml](./VB/DocumentServiceTest/View/Document1View.xaml))
* [Document2View.xaml](./CS/DocumentServiceTest/View/Document2View.xaml) (VB: [Document2View.xaml](./VB/DocumentServiceTest/View/Document2View.xaml))
* [MainView.xaml](./CS/DocumentServiceTest/View/MainView.xaml) (VB: [MainView.xaml](./VB/DocumentServiceTest/View/MainView.xaml))
* [Document1ViewModel.cs](./CS/DocumentServiceTest/ViewModel/Document1ViewModel.cs) (VB: [Document1ViewModel.vb](./VB/DocumentServiceTest/ViewModel/Document1ViewModel.vb))
* [Document2ViewModel.cs](./CS/DocumentServiceTest/ViewModel/Document2ViewModel.cs) (VB: [Document2ViewModel.vb](./VB/DocumentServiceTest/ViewModel/Document2ViewModel.vb))
* [MainViewModel.cs](./CS/DocumentServiceTest/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DocumentServiceTest/ViewModel/MainViewModel.vb))
* [WindowedDocumentUIServiceWindow.xaml](./CS/DocumentServiceTest/WindowedDocumentUIServiceWindow.xaml) (VB: [WindowedDocumentUIServiceWindow.xaml](./VB/DocumentServiceTest/WindowedDocumentUIServiceWindow.xaml))
<!-- default file list end -->
# How to: Manage documents via WindowedDocumentUIService and TabbedDocumentUIService


<p>The WindowedDocumentUIService provides methods to create and show documents as windows.<br /> The TabbedDocumentUIService provides methods to create and show documents as tabs.<br /> The CurrentWindowService provides methods to close the current window.</p>
<p>The following example demonstrates how to use the above services in a View Model.<br /><br />If you wish to perform some actions when the document is about to close or wish to prevent a document from being closed, implement the IDocumentViewModel interface for the view model that represents a document. The IDocumentViewModel.Close method will be called before the document closure.</p>

<br/>


