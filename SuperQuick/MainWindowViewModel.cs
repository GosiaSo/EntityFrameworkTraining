using System.ComponentModel;

namespace SuperQuick
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        protected readonly SuperQuickContext context;

        public MainWindowViewModel()
        {
            context = new SuperQuickContext();
            Customers = new ObservableCollection<Customer>(context.Customers);
        }


        public ObservableCollection<Customer> Customers { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
