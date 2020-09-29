using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace ModulesTest.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ObservableCollection<string> Tabs { get; } = new ObservableCollection<string>();

        private DelegateCommand<string> _showModuleCommand;
        public DelegateCommand<string> ShowModuleCommand =>
            _showModuleCommand ?? (_showModuleCommand = new DelegateCommand<string>(ExecuteShowModuleCommand));

        void ExecuteShowModuleCommand(string module)
        {
            Tabs.Add("Module" + module);
        }

        public MainWindowViewModel()
        {
        }
    }
}
