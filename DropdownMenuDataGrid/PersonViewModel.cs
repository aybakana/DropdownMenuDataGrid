using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DropdownMenuDataGrid
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private string _name;
        private int _age;

        public PersonViewModel(string name, int age)
        {
            _name = name;
            _age = age;
            FilterOptions = new ObservableCollection<FilterOption>
        {
            new FilterOption("All", true),
            new FilterOption(name),
            new FilterOption("Other")
        };
            ApplyFilterCommand = new RelayCommand(ApplyFilter);
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged(nameof(Age));
                }
            }
        }

        public ObservableCollection<FilterOption> FilterOptions { get; }

        public ICommand ApplyFilterCommand { get; }

        private void ApplyFilter()
        {
            // Implement filter logic here
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
