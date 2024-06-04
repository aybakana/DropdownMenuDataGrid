using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropdownMenuDataGrid
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Persons = new ObservableCollection<PersonViewModel>
        {
            new PersonViewModel("Alice", 25),
            new PersonViewModel("Bob", 30),
            new PersonViewModel("Charlie", 35)
        };
        }

        public ObservableCollection<PersonViewModel> Persons { get; }
    }
}
