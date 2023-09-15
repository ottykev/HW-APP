using HW_APP.ViewModels;
using System.Runtime.CompilerServices;

namespace HW_APP.Views
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}