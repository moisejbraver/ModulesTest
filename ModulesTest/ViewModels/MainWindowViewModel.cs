using Prism.Commands;
using Prism.Mvvm;

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

        private string fieldName;
        public string Module
        {
            get { return fieldName; }
            set { SetProperty(ref fieldName, value); }
        }

        private DelegateCommand<string> _showModuleCommand;
        public DelegateCommand<string> ShowModuleCommand =>
            _showModuleCommand ?? (_showModuleCommand = new DelegateCommand<string>(ExecuteShowModuleCommand));

        void ExecuteShowModuleCommand(string module)
        {
            Module = "Module" + module;
        }

        public MainWindowViewModel()
        {
            Module = "ModuleA";
        }
    }
}
