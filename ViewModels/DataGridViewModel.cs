using HW_APP.Models;
using System.Collections.ObjectModel;

namespace HW_APP.ViewModels
{
    public class DataGridViewModel : BaseViewModel
    {
        public DataGridViewModel()
        {
            Title = "DataGrid";
            Items = new ObservableCollection<Item>();
        }

        public ObservableCollection<Item> Items { get; private set; }

        async public void OnAppearing()
        {
            IEnumerable<Item> items = await DataStore.GetItemsAsync(true);
            Items.Clear();
            foreach (Item item in items)
            {
                Items.Add(item);
            }
        }
    }
}