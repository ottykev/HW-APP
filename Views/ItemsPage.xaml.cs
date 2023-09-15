using HW_APP.Models;
using HW_APP.ViewModels;

namespace HW_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new ItemsViewModel();
            ViewModel.OnAppearing();
        }

        ItemsViewModel ViewModel { get; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnAppearing();
        }
    }
}