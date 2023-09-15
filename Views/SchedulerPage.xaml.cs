﻿using HW_APP.ViewModels;

namespace HW_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulerPage : ContentPage
    {
        public SchedulerPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new SchedulerViewModel();
        }

        SchedulerViewModel ViewModel { get; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnAppearing();
        }
    }
}