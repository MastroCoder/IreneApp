using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IreneApp.ViewModels;
using IreneApp.Models;

namespace IreneApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProdutoSelecionadoVendaPage : ContentPage
    {
        ProdutoSelecionadoVendaViewModel viewModel;
        public ProdutoSelecionadoVendaPage()
        {
            InitializeComponent();
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ProdutoSelecionadoVendaViewModel(item);
            BindingContext = viewModel;
        }
        public ProdutoSelecionadoVendaPage(ProdutoSelecionadoVendaViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
        private void OnDesfazerVendaClicked(object sender, EventArgs e)
        {

        }
    }
}