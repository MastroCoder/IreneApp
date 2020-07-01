using IreneApp.Models;
using IreneApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IreneApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VendaAtualPage : ContentPage
    {
        VendaAtualViewModel viewModel;
        public VendaAtualPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new VendaAtualViewModel();
        }

        async void ItemsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
#pragma warning disable IDE0019 // Usar a correspondência de padrão
            var item = e.SelectedItem as Item;
#pragma warning restore IDE0019 // Usar a correspondência de padrão
            if (item == null)
                return;

            await Navigation.PushAsync(new ProdutoSelecionadoVendaPage(new ProdutoSelecionadoVendaViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}