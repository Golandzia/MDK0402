using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace PracticeWork6.ViewModel
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private string _group;
        private int _numberOfGroup;
        private string _nameOfGroup;

        public string Group
        {
            get => _group;
            set
            {
                _group = value;
                OnPropertyChanged(nameof(Group));
            }
        }
        public int NumberOfGroup
        {
            get => _numberOfGroup;
            set
            {
                _numberOfGroup = value;
                OnPropertyChanged(nameof(NumberOfGroup));
            }
        }
        public string NameOfGroup
        {
            get => _nameOfGroup;
            set
            {
                _nameOfGroup = value;
                OnPropertyChanged(nameof(NameOfGroup));
            }
        }

        public ICommand ShowBtn
        {
            get;
        }
        public MainWindowViewModel()
        {
            ShowBtn = new DelegateCommand(ShowGroup);
        }

        private void ShowGroup(object obj)
        {
            if (string.IsNullOrEmpty(Group) || string.IsNullOrEmpty(NumberOfGroup.ToString()))
            {
                MessageBox.Show("Заполните все поля!", "", MessageBoxButton.OK, MessageBoxImage.Hand);
                return;
            }
            else
                NameOfGroup = _group + "-" + _numberOfGroup.ToString();
        }
    }
}
