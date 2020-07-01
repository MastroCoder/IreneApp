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

        private void ItemsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}