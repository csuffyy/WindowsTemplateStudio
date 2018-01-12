﻿using System.Collections.ObjectModel;
using Wts.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wts.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewListPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListViewListPage()
        {
            InitializeComponent();
            BindingContext = new ListViewListViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var vm = BindingContext as ListViewListViewModel;
            await vm.LoadDataAsync();

        }
    }
}