using DevExpress.Mvvm;

namespace DocumentServiceTest.ViewModel {
    public class Document1ViewModel : ViewModelBase {
        string text;
        public string Text {
            get { return text; }
            set { SetProperty(ref text, value, () => Text); }
        }
    }
}
