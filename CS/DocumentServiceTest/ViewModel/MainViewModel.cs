using DevExpress.Mvvm;
using System.Windows.Input;

namespace DocumentServiceTest.ViewModel {
    public class MainViewModel : ViewModelBase {
        public ICommand ShowDocumentCommand { get; private set; }
        IDocumentManagerService DocumentManager { get { return GetService<IDocumentManagerService>(); } }
        public MainViewModel() {
            ShowDocumentCommand = new DelegateCommand<string>(OnShowDocumentCommandExecute);
        }
        void OnShowDocumentCommandExecute(string document) {
            IDocument doc = DocumentManager.CreateDocument(document, null, this);
            doc.DestroyOnClose = true;
            doc.Title = document;
            doc.Show();
        }
    }
}