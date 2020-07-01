using System;
using System.Collections.Generic;
using System.Text;
using IreneApp.Models;


namespace IreneApp.ViewModels
{
    public class ProdutoSelecionadoVendaViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ProdutoSelecionadoVendaViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }  
}
