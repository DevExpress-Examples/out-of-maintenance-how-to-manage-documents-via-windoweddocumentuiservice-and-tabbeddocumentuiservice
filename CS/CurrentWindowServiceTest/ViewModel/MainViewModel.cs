using DevExpress.Mvvm;
using System.Windows.Input;

namespace CurrentWindowServiceTest.ViewModel {
    public class MainViewModel : ViewModelBase {
        ICurrentWindowService CurrentWindowService { get { return GetService<ICurrentWindowService>(); } }
        public ICommand CloseWindowCommand { get; private set; }
        public MainViewModel() {
            CloseWindowCommand = new DelegateCommand(OnCloseWindowCommandExecute);
        }
        void OnCloseWindowCommandExecute() {
            CurrentWindowService.Close();
        }
    }
}
