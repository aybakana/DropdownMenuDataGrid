using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DropdownMenuDataGrid
{
    /// <summary>
    /// Interaction logic for FilterMenuControl.xaml
    /// </summary>
    public partial class FilterMenuControl : UserControl
    {
        public FilterMenuControl()
        {
            InitializeComponent();
            DataContext = this; // Set the data context to the control itself
        }

        // Define dependency property for FilterOptions
        public static readonly DependencyProperty FilterOptionsProperty =
            DependencyProperty.Register("FilterOptions", typeof(IEnumerable<FilterOption>), typeof(FilterMenuControl));

        public IEnumerable<FilterOption> FilterOptions
        {
            get { return (IEnumerable<FilterOption>)GetValue(FilterOptionsProperty); }
            set { SetValue(FilterOptionsProperty, value); }
        }

        // Define dependency property for ApplyFilterCommand
        public static readonly DependencyProperty ApplyFilterCommandProperty =
            DependencyProperty.Register("ApplyFilterCommand", typeof(ICommand), typeof(FilterMenuControl));

        public ICommand ApplyFilterCommand
        {
            get { return (ICommand)GetValue(ApplyFilterCommandProperty); }
            set { SetValue(ApplyFilterCommandProperty, value); }
        }
    }
}
