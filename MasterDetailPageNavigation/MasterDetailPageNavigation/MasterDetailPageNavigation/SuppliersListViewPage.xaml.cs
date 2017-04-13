using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuppliersListViewPage : ContentPage
    {
        public SuppliersListViewPage()
        {
            InitializeComponent();
            BindingContext = new SuppliersListViewPageViewModel();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
            => ((ListView)sender).SelectedItem = null;

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            await DisplayAlert("Selected", e.SelectedItem.ToString(), "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }



    class SuppliersListViewPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Item> Items { get; }
        public ObservableCollection<Grouping<string, Item>> ItemsGrouped { get; }

        public SuppliersListViewPageViewModel()
        {
            Items = new ObservableCollection<Item>(new[]
            {
                new Item { Text = "Solvay", Detail = "Detail", Url = "http://www.solvay.com" },
                new Item { Text = "Sabic", Detail = "Detail", Url = "http://www.sabic.com" },
                new Item { Text = "Covestro", Detail = "Detail", Url = "http://www.covestro.com" },
                new Item { Text = "Ineos", Detail = "Detail", Url = "http://www.ineos.com" },
                new Item { Text = "Borealis", Detail= "Detail", Url = "http://www.borealis.com" },
                new Item { Text = "BASF", Detail = "Detail", Url = "http://www.basf.com" },
                new Item { Text = "Bayer", Detail = "Detail", Url = "http://www.bayer.com" },
                new Item { Text = "DuPont", Detail = "Detail", Url = "http://www.dupont.com" },
                new Item { Text = "Celanese", Detail = "Detail", Url = "http://www.celanese.com" },
             });

            var sorted = from item in Items
                         orderby item.Text
                         group item by item.Text[0].ToString() into itemGroup
                         select new Grouping<string, Item>(itemGroup.Key, itemGroup);

            ItemsGrouped = new ObservableCollection<Grouping<string, Item>>(sorted);

            RefreshDataCommand = new Command(
                async () => await RefreshData());
        }

        public ICommand RefreshDataCommand { get; }

        async Task RefreshData()
        {
            IsBusy = true;
            //Load Data Here
            await Task.Delay(2000);

            IsBusy = false;
        }

        bool busy;
        public bool IsBusy
        {
            get { return busy; }
            set
            {
                busy = value;
                OnPropertyChanged();
                ((Command)RefreshDataCommand).ChangeCanExecute();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public class Item
        {
            public string Text { get; set; }
            public string Detail { get; set; }
            public string Url { get; set; }

//            public override string ToString() => Text;
            public override string ToString() => Url;
         }

        public class Grouping<K, T> : ObservableCollection<T>
        {
            public K Key { get; private set; }

            public Grouping(K key, IEnumerable<T> items)
            {
                Key = key;
                foreach (var item in items)
                    this.Items.Add(item);
            }
        }
    }
}
